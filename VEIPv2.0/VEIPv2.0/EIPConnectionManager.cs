using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sres.Net.EEIP;
using System.ComponentModel;

namespace VEIPv2._0
{
    class EIPConnectionManager
    {
        EEIPClient eipClient = new EEIPClient();
        BackgroundWorker worker = new BackgroundWorker();
        string lastConnection = "";
        string lastDevice = "";
        List<Sres.Net.EEIP.Encapsulation.CIPIdentityItem> cipIdentityItem;

        private List<CustomControl.BitsControl> outputBitsList = new List<CustomControl.BitsControl>();
        private List<CustomControl.BytesControl> outputBytesList = new List<CustomControl.BytesControl>();

        bool isConnected = false;
        //eeipclient will will send this object a byte array. The following are arrays to store conversions
        //of the provided byte array and vice versa

        //inputs
        int[] inputByteToInt = new int[124];

        //outputs
        byte[] outputIntToByte = new byte[496];

        public EIPConnectionManager()
        {

        }
        
        /*This method will establish connections.
         * 1) Checks if it's already connected. If it is, return/exit method.
         * 2) takes the provided ipAddress and uses it to register a new connection
         * 3) sets the necessary parameters for the systems. This code can be found in the eeip website
         * 4) Creates a string  to be displayed on the connection text box. This will first be passed back
         * to MainScreen
         */
        public string Connect(string ipAddress)
        {
            string returnData = ""; //index 0 is connection status. index 1 is controller type (CV-X or XG-X) i. index 2 is ip address.
                                                 //1
            if (isConnected == true)
                return returnData = "A connection has already been established. Aborting connection attempt. \r\n";
            isConnected = true;

            //2
            eipClient.IPAddress = ipAddress;
            eipClient.RegisterSession();


            //3
            //Parameters from Originator -> Target
            eipClient.O_T_InstanceID = 0x65;              //Instance ID of the input Assembly. 100 for cv-x CORRECTION: This is 101
            eipClient.O_T_Length = eipClient.Detect_O_T_Length();   //The Method "Detect_O_T_Length" detect the Length using an UCMM Message. Print this. It may be output size
            eipClient.O_T_RealTimeFormat = Sres.Net.EEIP.RealTimeFormat.Header32Bit;   //Header Format
            eipClient.O_T_OwnerRedundant = false;
            eipClient.O_T_Priority = Sres.Net.EEIP.Priority.Scheduled;
            eipClient.O_T_VariableLength = false;
            eipClient.O_T_ConnectionType = Sres.Net.EEIP.ConnectionType.Point_to_Point;
            eipClient.RequestedPacketRate_O_T = 500000; //(uint)RPI;        //500ms is the Standard value
            //eipClient.TCPPort = 44818;
            eipClient.TCPPort = 8500;

            //Parameters from Target (CV-X) -> Originator(this program)
            eipClient.T_O_InstanceID = 0x64;  //this is 101 in hex. Compliant with the CV-X CORRECTION: this is 100
            eipClient.T_O_Length = eipClient.Detect_T_O_Length();
            eipClient.T_O_RealTimeFormat = Sres.Net.EEIP.RealTimeFormat.Modeless;
            eipClient.T_O_OwnerRedundant = false;
            eipClient.T_O_Priority = Sres.Net.EEIP.Priority.Scheduled;
            eipClient.T_O_VariableLength = false;
            eipClient.T_O_ConnectionType = Sres.Net.EEIP.ConnectionType.Multicast;
            eipClient.RequestedPacketRate_T_O = 500000;//(uint)RPI;    //RPI in  500ms is the Standard value
            eipClient.T_O_Length = eipClient.Detect_T_O_Length();

            //4
            //Forward open initiates the Implicit Messaging
            string ConnectionStatus = "Attempting connection to: " + ipAddress.ToString() + "...\r\n";
            try
            {
                eipClient.ForwardOpen();
                ConnectionStatus += "Connection Success!\r\n";
                lastConnection = ipAddress;
            }
            catch(Exception e)
            {
                isConnected = false;
                ConnectionStatus += "Connection attempt failed.\r\n";
                ConnectionStatus += e.Message + "\r\n";
                return returnData = ConnectionStatus;
            }
            return returnData = ConnectionStatus;
        }

        public string[] connectBtn(string ipAddress)
        {
            string[] objectInfo = new string[2];//an array of 2 strings. first is the model (CV-X or XG-X) and the second is the... somthing.

            //if there was no provided IP address...
            if (ipAddress == "" || ipAddress == null)
            {
                //... check if there was a previous connetion.
                if (lastConnection != "" || lastConnection != null)
                {
                    objectInfo = manualConnection(lastConnection);
                }
            }
            else
            {
                objectInfo = manualConnection(ipAddress);
            }

            return objectInfo;
            
        }

        public List<Encapsulation.CIPIdentityItem> Search()
        {
            try
            {
                cipIdentityItem = eipClient.ListIdentity();
            }catch(Exception e)
            {
                throw e;
            }
            

            return cipIdentityItem;
        }

        public void Close()
        {
            eipClient.ForwardClose();
            eipClient.UnRegisterSession();
            isConnected = false;
        }

        //TODO: complete the worker thread.
        public void work()
        {
            while (isConnected)
            {
                byteToInt(eipClient.T_O_IOData);
                eipClient.O_T_IOData = intToByte();
                
                System.Threading.Thread.Sleep(50);
            }
            
        }

        private string[] manualConnection(string ipAddress)
        {
            string[] objectInfo = new string[2];
            try
            {
                objectInfo[0] = Connect(ipAddress);
            }
            catch (Exception e)
            {
                //exit and stop trying. This is for the case if someone types an invalid IP address or something.
                return objectInfo = new string[2] { "No valid IP input or archive\r\n", "none" };
            }
            objectInfo[1] = eipClient.IdentityObject.ProductName;
            Console.WriteLine(objectInfo[0]);
            Console.WriteLine(objectInfo[1]);
            return objectInfo;
        }

        private void byteToInt(byte[] inputArray)
        {
            lock(inputByteToInt)// lock this variable to make sure the main thread doesn't use it simultaneously.
            {
                int holder = 0;
                for (int i = 0; i < inputByteToInt.Length; i++)
                {
                    inputByteToInt[i] = 0;
                    for (int j = 0; j < 4; j++)
                    {
                        
                        holder = inputArray[(i * 4) + j];
                        inputByteToInt[i] = inputByteToInt[i] | (holder << (8 * j));
                        holder = 0;
                    }
                }
            }
            
        }

        private byte[] intToByte()
        {
            int[] outputDINT = createOutputDINT();
            int holder = 0;
            int mask = 255;
            int a = 0;
            for (int i = 0; i < outputDINT.Length; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    holder = outputDINT[i] & mask;
                    outputIntToByte[a] = (byte)(holder >> (8*j));
                    mask = mask << 8;
                    a++;
                }
                holder = 0;
                mask = 255;
            }
            Console.Write(outputIntToByte[2] + "\r\n");
            
            return outputIntToByte;
        }
        //used by the main thread
        public int[] getInputDINT()
        {
            lock(inputByteToInt)
            {
                return inputByteToInt;
            }
            
        }

        private int[] createOutputDINT()
        {
            int[] outputDINT = new int[124];
            int dindex = 0;
            int holder = 0;

            //bits to DINTS
            for(int i = 0; i < outputBitsList.Count; i+=0)
            {
                for(int j = 0; j < 32; j++)
                {
                    if (outputBitsList[i].isChecked())
                    {
                        holder = holder | (1 << j);
                    }
                    i++; 
                }
                outputDINT[dindex] = holder;
                dindex++;
                holder = 0;
                
            }
            

            //bytes to DINTS
            for (int i = 0; i < outputBytesList.Count; i++)
            {
                outputDINT[dindex] = outputBytesList[i].getNumber();
                dindex++;
            }
            
            return outputDINT;
        }

        public void setOutputBitsList(List<CustomControl.BitsControl> outputBitsList)
        {
            this.outputBitsList = outputBitsList;
        }

        public void setOutputBytesList(List<CustomControl.BytesControl> outputBytesList)
        {
            this.outputBytesList = outputBytesList;
        }

        public bool getConnectionStatus()
        {
            return isConnected;
        }
    }
}
