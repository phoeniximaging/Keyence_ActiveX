using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ActiveXControls
{
    public partial class RemoteDesktopWindow : Form
    {
        public RemoteDesktopWindow()
        {
            InitializeComponent();
            axCVX1.Initialize();
            axXGX1.Initialize();
        }

        public void connectCVX(string ipAddress)
        {
            axCVX1.Address = ipAddress;
            axCVX1.Port = 8502;
            axCVX1.Connect();
            axCVX1.StartRemoteDesktop(0);
            axCVX1.EnableRemoteMouseOperation = true;
            RemoteTabs.SelectedIndex = 0;
        }

        public void connectXGX(string ipAddress)
        {
            axXGX1.Address = ipAddress;
            axXGX1.Port = 8502;
            axXGX1.Connect();
            axXGX1.StartRemoteDesktop(0);
            axXGX1.EnableRemoteConsole = true;
            RemoteTabs.SelectedIndex = 1;
        }

        public void DisconnectCVX()
        {
            axCVX1.Disconnect();
        }

        public void DisconnectXGX()
        {
            axXGX1.Disconnect();
        }
    }
}
