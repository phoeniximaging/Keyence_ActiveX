namespace FoundDeviceBtn
{
    partial class FoundConnection
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(0, 0);
            this.ConnectBtn.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(248, 140);
            this.ConnectBtn.TabIndex = 0;
            this.ConnectBtn.Text = "button1";
            this.ConnectBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoundConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ConnectBtn);
            this.Name = "FoundConnection";
            this.Size = new System.Drawing.Size(248, 140);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ConnectBtn;
    }
}
