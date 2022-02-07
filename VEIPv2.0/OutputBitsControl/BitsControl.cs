using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CustomControl
{
    public partial class BitsControl: UserControl
    {
        int bit = 0;
        int dint = 0;
        string tag = "";
        
        
        //int datatype = 32;
        
        public BitsControl(int dint, int bit, string tag, bool isEnabled)
        {
            
            InitializeComponent();
            this.dint = dint;
            this.bit = bit;
            this.tag = makeTag(tag, dint, bit);
            this.textBox1.Text = this.tag;
            checkBox1.Enabled = isEnabled;
            //checkBox1.Checked = true;
        }

        private string makeTag(string tag, int dint, int bit)
        {
            string newTag =  tag + ":[" + dint + "]." + bit;
            return newTag;
        }

        public void setCheckBox(bool set)
        {
            if(checkBox1.InvokeRequired)
            {
                checkBox1.Invoke(new MethodInvoker(delegate
                {
                    checkBox1.Checked = set;
                }));
            }
            
        }

        public bool isChecked()
        {
            return checkBox1.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
