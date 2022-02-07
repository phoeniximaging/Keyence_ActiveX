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
    public partial class BytesControl : UserControl
    {
        int dint;
        string tag = "";

        public BytesControl(int dint, string tag, bool isEnabled)
        {
            InitializeComponent();
            this.dint = dint;
            this.tag = makeTag(tag, dint);
            this.textBox1.Text = this.tag;
            this.Anchor = AnchorStyles.Left;
            numericUpDown1.Enabled = isEnabled;
        }

        private string makeTag(string tag, int dint)
        {
            string newTag = tag + ":[" + dint + "]";
            return newTag;
        }

        public void setNumber(int number)
        {
            if (numericUpDown1.InvokeRequired)
            {
                numericUpDown1.Invoke(new MethodInvoker(delegate
                {
                    numericUpDown1.Value = number;
                }));
            }
        }

        public int getNumber()
        {
            return (int)(numericUpDown1.Value);
        }

        public decimal getDec()
        {
            return numericUpDown1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
