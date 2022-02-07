using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace VEIPv2._0
{
    public partial class MainForm : Form
    {
        static string[] tagsFile = Properties.Resources.VEIP2_Tags.Split('\n');
        static int tagIndex = 0;
        static string currentTag = "";
        static bool isRemote = false;
        static string controllerType = "";
        CustomControl.BitsControl newBits;
        private List<CustomControl.BitsControl> inputBitsList = new List<CustomControl.BitsControl>();
        private List<CustomControl.BitsControl> outputBitsList = new List<CustomControl.BitsControl>();
        private List<CustomControl.BytesControl> inputBytesList = new List<CustomControl.BytesControl>();
        private List<CustomControl.BytesControl> outputBytesList = new List<CustomControl.BytesControl>();
        //static int[] inputArray;
        //static int[] outputArray;
        static EIPConnectionManager EIPManager = new EIPConnectionManager();
        //static ActiveXControls.RemoteDesktopWindow RemoteWindow = new ActiveXControls.RemoteDesktopWindow();
        List<Sres.Net.EEIP.Encapsulation.CIPIdentityItem> CIPList;
        FoundDeviceBtn.FoundConnection[] FoundButtonList;
        Thread connectionThread;
        Thread dataMovingThread;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawInputBits();
            DrawInputBytes();
            DrawOutputBits();
            DrawOutputBytes();

            InputBitsTable_DrawScroll();
            InputBytesTable_DrawScroll();
            OutputBitsTable_DrawScroll();
            OutputBytesTable_DrawScroll();
            

        }

        private void DrawOutputBytes()
        {
            for (int i = 4; i < 124; i++)
            {
                currentTag = tagsFile[tagIndex];
                tagIndex++;
                CustomControl.BytesControl newByte = new CustomControl.BytesControl(i, currentTag, true);
                OutputByteTable.Controls.Add(newByte);
                outputBytesList.Add(newByte);
            }
        }

        private void DrawInputBytes()
        {
            for (int i = 4; i < 124; i++)
            {
                currentTag = tagsFile[tagIndex];
                tagIndex++;
                CustomControl.BytesControl newByte = new CustomControl.BytesControl(i, currentTag, false);
                InputBytesTable.Controls.Add(newByte);
                inputBytesList.Add(newByte);
            }
        }

        private void DrawOutputBits()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    currentTag = tagsFile[tagIndex];
                    tagIndex++;
                    CustomControl.BitsControl newBits = new CustomControl.BitsControl(i, j, currentTag, true);
                    OutputBitsTable.Controls.Add(newBits);
                    outputBitsList.Add(newBits);
                }
            }
        }

        private void DrawInputBits()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 32; j++)
                {

                    currentTag = tagsFile[tagIndex];
                    tagIndex++;
                    newBits = new CustomControl.BitsControl(i, j, currentTag, false);
                    InputBitsTable.Controls.Add(newBits);
                    inputBitsList.Add(newBits);
                }
            }
            
        }

        private void InputBitsTable_DrawScroll()
        {
            
            InputBitsTable.HorizontalScroll.Maximum = 0;
            InputBitsTable.AutoScroll = false;
            InputBitsTable.VerticalScroll.Visible = false;
            InputBitsTable.AutoScroll = true;
        }

        private void OutputBitsTable_DrawScroll()
        {
            OutputBitsTable.HorizontalScroll.Maximum = 0;
            OutputBitsTable.AutoScroll = false;
            OutputBitsTable.VerticalScroll.Visible = false;
            OutputBitsTable.AutoScroll = true;
        }

        private void InputBytesTable_DrawScroll()
        {
            InputBytesTable.HorizontalScroll.Maximum = 0;
            InputBytesTable.AutoScroll = false;
            InputBytesTable.VerticalScroll.Visible = false;
            InputBytesTable.AutoScroll = true;
        }

        private void OutputBytesTable_DrawScroll()
        {
            OutputByteTable.HorizontalScroll.Maximum = 0;
            OutputByteTable.AutoScroll = false;
            OutputByteTable.VerticalScroll.Visible = false;
            OutputByteTable.AutoScroll = true;
        }

        /*This method:
         * 1) gets the CIP list
         * 2) Creates an array of connection buttons
         * 3) populates the button array by
         *      a) creating a new button
         *      b) suscribing to custom made event handler that activates when the button is clicked
         * 4) adds the button to the main screen.
         */
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CIPList = EIPManager.Search();
            }
            catch(Exception ex)
            {
                ConnectionInfo.Text += ex.ToString();
            }
            
            int listLength = CIPList.Count;
            FoundButtonList = new FoundDeviceBtn.FoundConnection[listLength];
            for (int i = 0; i < listLength; i++)
            {
                FoundButtonList[i] = new FoundDeviceBtn.FoundConnection(CIPList[i]);
                FoundButtonList[i].ConnectionBtn_Clicked += FoundConnectionButton_Click;
                ConnectionButtonList.Controls.Add(FoundButtonList[i]);
                
            }

            
        }

        public void ConnectFromList(string IPfromButton)
        {
            connectionThread = new Thread(new ThreadStart(ThreadProc1));
            dataMovingThread = new Thread(new ThreadStart(ThreadProc2));
            try
            {

                connectionThread.Start();
                dataMovingThread.Start();
            }catch(ThreadStateException e)
            {
                Console.WriteLine(e.Message);
                ConnectionInfo.Text += "connection failed\r\n";
            }
            

        }

        public void FoundConnectionButton_Click(object sender, EventArgs e)
        {
            FoundDeviceBtn.FoundConnection btn = sender as FoundDeviceBtn.FoundConnection;
            string connectionStatus = EIPManager.Connect(btn.ipAddress);
            ConnectionInfo.Text += connectionStatus;
            ConnectFromList(btn.ipAddress);
            controllerType = btn.controllerType;
            remoteEnable.Enabled = false;
            if (isRemote == true && controllerType.Contains("CV-X"))
            {
                //RemoteWindow.connectCVX(btn.ipAddress);
                ConnectionInfo.Text += "Connecting to CV-X\r\n";
            }else if(isRemote == true && controllerType.Contains("XG-X"))
            {
                //RemoteWindow.connectXGX(btn.ipAddress);
                ConnectionInfo.Text += "Connecting to XG-X\r\n";
            }
            this.ControlBox = false;
        }

        private void ConnectBrn_Click(object sender, EventArgs e)
        {
            string[] objectInfo = EIPManager.connectBtn(IPInputString.Text);
            ConnectionInfo.Text += objectInfo[0] + "\r\n";
            controllerType = objectInfo[1];
            if (objectInfo[0].Contains("Success"))
            {
                ConnectFromList(IPInputString.Text);
                remoteEnable.Enabled = false;
                if (isRemote == true && controllerType.Contains("CV-X"))
                {
                    //RemoteWindow.connectCVX(IPInputString.Text);
                    ConnectionInfo.Text += "Connecting to CV-X\r\n";
                }
                else if (isRemote == true && controllerType.Contains("XG-X"))
                {
                    //RemoteWindow.connectXGX(IPInputString.Text);
                    ConnectionInfo.Text += "Connecting to XG-X\r\n";
                }
                this.ControlBox = false;
            }
        }

        private void CloseConnectionBtn_Click(object sender, EventArgs e)
        {
            if (EIPManager.getConnectionStatus() == true)
            {
                EIPManager.Close();
                remoteEnable.Enabled = true;
                ConnectionInfo.Text += "connection closed\r\n";
            }

            if(isRemote == true && controllerType.Contains("CV-X"))
            {
                //RemoteWindow.DisconnectCVX();
            }else if(isRemote == true && controllerType.Contains("XG-X"))
            {
                //RemoteWindow.DisconnectXGX();
            }
            this.ControlBox = true;
            //dataMovingThread.Join();
            //connectionThread.Join();
                
        }

        public void ThreadProc1()
        {
            EIPManager.work();
            
        }

        public void ThreadProc2()
        {

            while (EIPManager.getConnectionStatus())
            {
                UpdateInputsScreen(EIPManager.getInputDINT());
                EIPManager.setOutputBitsList(outputBitsList);
                EIPManager.setOutputBytesList(outputBytesList);
                System.Threading.Thread.Sleep(50);
            }
        }

        private void UpdateInputsScreen(int[] inputDINTS)
        {
            //input bits
            for (int i = 0; i < InputBitsTable.Controls.Count; i+=0)
            {
                for(int DINTindex = 0; DINTindex < 4; DINTindex ++)
                {
                    for(int bitIndex = 0; bitIndex < 32; bitIndex++)
                    {
                        inputBitsList[i].setCheckBox(isBitOn(inputDINTS[DINTindex], bitIndex));
                        i++;
                    }
                }
                
            }
            //input bytes
            for (int i = 0; i < InputBytesTable.Controls.Count; i++)
            {
                inputBytesList[i].setNumber(inputDINTS[i + 4]);
            }
            

        }

        private bool isBitOn(int dint, int shift)
        {
            int passMe = 0;

            passMe = dint & (1 << shift);
            if (passMe == 0)
                return false;
            else if (passMe != 0)
                return true;
            else
                return false;
        }

        private void remoteEnable_CheckedChanged(object sender, EventArgs e)
        {
            if (isRemote == false)
            {
                //RemoteWindow.Show();
                isRemote = true;
            }
            else
            {
                //RemoteWindow.Hide();
                isRemote = false;
            }
        }
    }
}
