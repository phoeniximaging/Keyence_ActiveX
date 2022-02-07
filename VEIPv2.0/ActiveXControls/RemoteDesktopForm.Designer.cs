namespace ActiveXControls
{
    partial class RemoteDesktopWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoteDesktopWindow));
            this.RemoteTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.axCVX1 = new AxCVXLib.AxCVX();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.axXGX1 = new AxXGXLib.AxXGX();
            this.RemoteTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axCVX1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axXGX1)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoteTabs
            // 
            this.RemoteTabs.Controls.Add(this.tabPage1);
            this.RemoteTabs.Controls.Add(this.tabPage2);
            this.RemoteTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoteTabs.Location = new System.Drawing.Point(0, 0);
            this.RemoteTabs.Margin = new System.Windows.Forms.Padding(2);
            this.RemoteTabs.Name = "RemoteTabs";
            this.RemoteTabs.SelectedIndex = 0;
            this.RemoteTabs.Size = new System.Drawing.Size(935, 701);
            this.RemoteTabs.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.axCVX1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(927, 675);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CV-X";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // axCVX1
            // 
            this.axCVX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axCVX1.Enabled = true;
            this.axCVX1.Location = new System.Drawing.Point(2, 2);
            this.axCVX1.Margin = new System.Windows.Forms.Padding(2);
            this.axCVX1.Name = "axCVX1";
            this.axCVX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axCVX1.OcxState")));
            this.axCVX1.Size = new System.Drawing.Size(892, 669);
            this.axCVX1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.axXGX1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(927, 675);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XG-X";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // axXGX1
            // 
            this.axXGX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axXGX1.Enabled = true;
            this.axXGX1.Location = new System.Drawing.Point(2, 2);
            this.axXGX1.Margin = new System.Windows.Forms.Padding(2);
            this.axXGX1.Name = "axXGX1";
            this.axXGX1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axXGX1.OcxState")));
            this.axXGX1.Size = new System.Drawing.Size(923, 671);
            this.axXGX1.TabIndex = 0;
            // 
            // RemoteDesktopWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 701);
            this.ControlBox = false;
            this.Controls.Add(this.RemoteTabs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoteDesktopWindow";
            this.Text = "Remote Desktop";
            this.RemoteTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axCVX1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axXGX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl RemoteTabs;
        private System.Windows.Forms.TabPage tabPage1;
        //private AxCVXLib.AxCVX axCVX1;
        private System.Windows.Forms.TabPage tabPage2;
        //private AxXGXLib.AxXGX axXGX1;
    }
}

