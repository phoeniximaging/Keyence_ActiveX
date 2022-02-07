using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sres.Net.EEIP;
using System.IO;

namespace VEIPv2._0
{
    class EIPObject
    {
        String ipAddress = "";
        int RPI = 50000;
        int maxDataTypes = 124; //default number of BYTE, SINT or DINT
        int numberOfBits = 4; //default number of BYTE's, SINT's or DINTs that are converted  to bits
        int dataType = 32; //8 = BYTE, 16 = SINT, 32 = DINT(default)
        bool isConnected = false;
        int currentInt; //used in the worker to loop throgh the Int array to be converted to bits
        string devName;
        static string directoryOfExe = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        StreamReader tagsFile = new StreamReader(directoryOfExe + @"\VEIP_Tags.csv");
        EEIPClient eeipClient;

        public EIPObject()
        {
            eeipClient = new EEIPClient();
        }

        public EIPObject(string ipAddress) : this()
        {
            

        }
    }
}
