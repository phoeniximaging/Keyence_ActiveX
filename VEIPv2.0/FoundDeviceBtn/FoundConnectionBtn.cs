using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sres.Net.EEIP;


namespace FoundDeviceBtn
{
    public partial class FoundConnection: UserControl
    {
        Encapsulation.CIPIdentityItem foundMe;
        public event EventHandler ConnectionBtn_Clicked;
        public string ipAddress = "";
        public string controllerType = "";


        public FoundConnection(Encapsulation.CIPIdentityItem IdentityItem)
        {
            InitializeComponent();

            foundMe = IdentityItem;
            ConnectBtn.Text = "Ethernet/IP Device Found:";
            ConnectBtn.Text += IdentityItem.ProductName1 + "\r\n";
            ConnectBtn.Text += "IP-Address: " + Sres.Net.EEIP.Encapsulation.CIPIdentityItem.getIPAddress(IdentityItem.SocketAddress.SIN_Address) + "\r\n";
            ConnectBtn.Text += "Port: " + IdentityItem.SocketAddress.SIN_port + "\r\n";
            ConnectBtn.Text += "Vendor ID: " + IdentityItem.VendorID1 + "\r\n";
            ConnectBtn.Text += "Product-code: " + IdentityItem.ProductCode1 + "\r\n";
            ConnectBtn.Text += "Type-Code: " + IdentityItem.ItemTypeCode + "\r\n";

            controllerType = IdentityItem.ProductName1;
            ipAddress = Sres.Net.EEIP.Encapsulation.CIPIdentityItem.getIPAddress(IdentityItem.SocketAddress.SIN_Address);
        }

        public void button1_Click(object sender, EventArgs e)
        {

            EventHandler handler = ConnectionBtn_Clicked;
            handler(this, e);
            
        }

        public string getControllerType()
        {
            return controllerType;
        }
    }
}
