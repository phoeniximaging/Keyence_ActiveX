namespace VEIPv2._0
{
    partial class MainForm
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
            this.SearchBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ConnectionInfo = new System.Windows.Forms.TextBox();
            this.CloseConnectionBtn = new System.Windows.Forms.Button();
            this.ConnectBrn = new System.Windows.Forms.Button();
            this.IPInputString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InputBitsGroup = new System.Windows.Forms.GroupBox();
            this.InputBitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.InputByteGroup = new System.Windows.Forms.GroupBox();
            this.InputBytesTable = new System.Windows.Forms.TableLayoutPanel();
            this.OutputBitsGroup = new System.Windows.Forms.GroupBox();
            this.OutputBitsTable = new System.Windows.Forms.TableLayoutPanel();
            this.OutputListGroup = new System.Windows.Forms.GroupBox();
            this.OutputByteTable = new System.Windows.Forms.TableLayoutPanel();
            this.ConnectionButtonList = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remoteEnable = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.InputBitsGroup.SuspendLayout();
            this.InputByteGroup.SuspendLayout();
            this.OutputBitsGroup.SuspendLayout();
            this.OutputListGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(71, 41);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(83, 26);
            this.SearchBtn.TabIndex = 0;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ConnectionInfo);
            this.groupBox1.Controls.Add(this.CloseConnectionBtn);
            this.groupBox1.Controls.Add(this.ConnectBrn);
            this.groupBox1.Controls.Add(this.IPInputString);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(223, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(182, 427);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Connection Settings";
            // 
            // ConnectionInfo
            // 
            this.ConnectionInfo.Location = new System.Drawing.Point(8, 109);
            this.ConnectionInfo.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectionInfo.Multiline = true;
            this.ConnectionInfo.Name = "ConnectionInfo";
            this.ConnectionInfo.Size = new System.Drawing.Size(170, 314);
            this.ConnectionInfo.TabIndex = 4;
            // 
            // CloseConnectionBtn
            // 
            this.CloseConnectionBtn.Location = new System.Drawing.Point(8, 81);
            this.CloseConnectionBtn.Margin = new System.Windows.Forms.Padding(2);
            this.CloseConnectionBtn.Name = "CloseConnectionBtn";
            this.CloseConnectionBtn.Size = new System.Drawing.Size(169, 23);
            this.CloseConnectionBtn.TabIndex = 3;
            this.CloseConnectionBtn.Text = "CloseConnection";
            this.CloseConnectionBtn.UseVisualStyleBackColor = true;
            this.CloseConnectionBtn.Click += new System.EventHandler(this.CloseConnectionBtn_Click);
            // 
            // ConnectBrn
            // 
            this.ConnectBrn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectBrn.Location = new System.Drawing.Point(8, 54);
            this.ConnectBrn.Margin = new System.Windows.Forms.Padding(2);
            this.ConnectBrn.Name = "ConnectBrn";
            this.ConnectBrn.Size = new System.Drawing.Size(169, 23);
            this.ConnectBrn.TabIndex = 2;
            this.ConnectBrn.Text = "Connect";
            this.ConnectBrn.UseVisualStyleBackColor = true;
            this.ConnectBrn.Click += new System.EventHandler(this.ConnectBrn_Click);
            // 
            // IPInputString
            // 
            this.IPInputString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IPInputString.Location = new System.Drawing.Point(8, 31);
            this.IPInputString.Margin = new System.Windows.Forms.Padding(2);
            this.IPInputString.Name = "IPInputString";
            this.IPInputString.Size = new System.Drawing.Size(170, 20);
            this.IPInputString.TabIndex = 1;
            this.IPInputString.Text = "192.168.1.83";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address";
            // 
            // InputBitsGroup
            // 
            this.InputBitsGroup.Controls.Add(this.InputBitsTable);
            this.InputBitsGroup.Location = new System.Drawing.Point(408, 41);
            this.InputBitsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.InputBitsGroup.Name = "InputBitsGroup";
            this.InputBitsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.InputBitsGroup.Size = new System.Drawing.Size(322, 167);
            this.InputBitsGroup.TabIndex = 3;
            this.InputBitsGroup.TabStop = false;
            this.InputBitsGroup.Text = "Input Bits";
            // 
            // InputBitsTable
            // 
            this.InputBitsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputBitsTable.ColumnCount = 1;
            this.InputBitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputBitsTable.Location = new System.Drawing.Point(6, 18);
            this.InputBitsTable.Margin = new System.Windows.Forms.Padding(2);
            this.InputBitsTable.Name = "InputBitsTable";
            this.InputBitsTable.RowCount = 1;
            this.InputBitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputBitsTable.Size = new System.Drawing.Size(311, 143);
            this.InputBitsTable.TabIndex = 0;
            // 
            // InputByteGroup
            // 
            this.InputByteGroup.Controls.Add(this.InputBytesTable);
            this.InputByteGroup.Location = new System.Drawing.Point(408, 212);
            this.InputByteGroup.Margin = new System.Windows.Forms.Padding(2);
            this.InputByteGroup.Name = "InputByteGroup";
            this.InputByteGroup.Padding = new System.Windows.Forms.Padding(2);
            this.InputByteGroup.Size = new System.Drawing.Size(322, 256);
            this.InputByteGroup.TabIndex = 4;
            this.InputByteGroup.TabStop = false;
            this.InputByteGroup.Text = "Input List";
            // 
            // InputBytesTable
            // 
            this.InputBytesTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.InputBytesTable.ColumnCount = 1;
            this.InputBytesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.InputBytesTable.Location = new System.Drawing.Point(6, 18);
            this.InputBytesTable.Margin = new System.Windows.Forms.Padding(2);
            this.InputBytesTable.Name = "InputBytesTable";
            this.InputBytesTable.RowCount = 1;
            this.InputBytesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.InputBytesTable.Size = new System.Drawing.Size(311, 232);
            this.InputBytesTable.TabIndex = 0;
            // 
            // OutputBitsGroup
            // 
            this.OutputBitsGroup.Controls.Add(this.OutputBitsTable);
            this.OutputBitsGroup.Location = new System.Drawing.Point(734, 41);
            this.OutputBitsGroup.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBitsGroup.Name = "OutputBitsGroup";
            this.OutputBitsGroup.Padding = new System.Windows.Forms.Padding(2);
            this.OutputBitsGroup.Size = new System.Drawing.Size(322, 167);
            this.OutputBitsGroup.TabIndex = 5;
            this.OutputBitsGroup.TabStop = false;
            this.OutputBitsGroup.Text = "Output Bits";
            // 
            // OutputBitsTable
            // 
            this.OutputBitsTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputBitsTable.ColumnCount = 1;
            this.OutputBitsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OutputBitsTable.Location = new System.Drawing.Point(4, 18);
            this.OutputBitsTable.Margin = new System.Windows.Forms.Padding(2);
            this.OutputBitsTable.Name = "OutputBitsTable";
            this.OutputBitsTable.RowCount = 1;
            this.OutputBitsTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OutputBitsTable.Size = new System.Drawing.Size(313, 143);
            this.OutputBitsTable.TabIndex = 0;
            // 
            // OutputListGroup
            // 
            this.OutputListGroup.Controls.Add(this.OutputByteTable);
            this.OutputListGroup.Location = new System.Drawing.Point(734, 212);
            this.OutputListGroup.Margin = new System.Windows.Forms.Padding(2);
            this.OutputListGroup.Name = "OutputListGroup";
            this.OutputListGroup.Padding = new System.Windows.Forms.Padding(2);
            this.OutputListGroup.Size = new System.Drawing.Size(322, 256);
            this.OutputListGroup.TabIndex = 6;
            this.OutputListGroup.TabStop = false;
            this.OutputListGroup.Text = "Output List";
            // 
            // OutputByteTable
            // 
            this.OutputByteTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OutputByteTable.ColumnCount = 1;
            this.OutputByteTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.OutputByteTable.Location = new System.Drawing.Point(4, 18);
            this.OutputByteTable.Margin = new System.Windows.Forms.Padding(2);
            this.OutputByteTable.Name = "OutputByteTable";
            this.OutputByteTable.RowCount = 1;
            this.OutputByteTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.OutputByteTable.Size = new System.Drawing.Size(314, 232);
            this.OutputByteTable.TabIndex = 0;
            // 
            // ConnectionButtonList
            // 
            this.ConnectionButtonList.AutoSize = true;
            this.ConnectionButtonList.ColumnCount = 1;
            this.ConnectionButtonList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConnectionButtonList.Location = new System.Drawing.Point(0, 0);
            this.ConnectionButtonList.Margin = new System.Windows.Forms.Padding(0);
            this.ConnectionButtonList.Name = "ConnectionButtonList";
            this.ConnectionButtonList.RowCount = 1;
            this.ConnectionButtonList.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ConnectionButtonList.Size = new System.Drawing.Size(192, 395);
            this.ConnectionButtonList.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ConnectionButtonList);
            this.panel1.Location = new System.Drawing.Point(4, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 397);
            this.panel1.TabIndex = 8;
            // 
            // remoteEnable
            // 
            this.remoteEnable.AutoSize = true;
            this.remoteEnable.Location = new System.Drawing.Point(955, 10);
            this.remoteEnable.Margin = new System.Windows.Forms.Padding(2);
            this.remoteEnable.Name = "remoteEnable";
            this.remoteEnable.Size = new System.Drawing.Size(106, 17);
            this.remoteEnable.TabIndex = 9;
            this.remoteEnable.Text = "Remote Desktop";
            this.remoteEnable.UseVisualStyleBackColor = true;
            this.remoteEnable.CheckedChanged += new System.EventHandler(this.remoteEnable_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1063, 476);
            this.Controls.Add(this.remoteEnable);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.OutputBitsGroup);
            this.Controls.Add(this.OutputListGroup);
            this.Controls.Add(this.InputByteGroup);
            this.Controls.Add(this.InputBitsGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SearchBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main Screen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.InputBitsGroup.ResumeLayout(false);
            this.InputByteGroup.ResumeLayout(false);
            this.OutputBitsGroup.ResumeLayout(false);
            this.OutputListGroup.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ConnectionInfo;
        private System.Windows.Forms.Button CloseConnectionBtn;
        private System.Windows.Forms.Button ConnectBrn;
        private System.Windows.Forms.TextBox IPInputString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox InputBitsGroup;
        private System.Windows.Forms.GroupBox InputByteGroup;
        private System.Windows.Forms.GroupBox OutputBitsGroup;
        private System.Windows.Forms.TableLayoutPanel InputBitsTable;
        private System.Windows.Forms.TableLayoutPanel InputBytesTable;
        private System.Windows.Forms.GroupBox OutputListGroup;
        private System.Windows.Forms.TableLayoutPanel OutputBitsTable;
        private System.Windows.Forms.TableLayoutPanel OutputByteTable;
        private System.Windows.Forms.TableLayoutPanel ConnectionButtonList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox remoteEnable;
    }
}

