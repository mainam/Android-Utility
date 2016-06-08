namespace Android_Utility
{
    partial class frmInstallMultipleDevice
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabDevice = new MLLib.Controls.ctTabControl();
            this.tabPageEx1 = new MLLib.Controls.TabPageEx();
            this.listofdevice = new Android_Utility.ctListOfDevice();
            this.tabFunction = new MLLib.Controls.ctTabControl();
            this.tpInstall = new MLLib.Controls.TabPageEx();
            this.tabLog = new MLLib.Controls.ctTabControl();
            this.tabPage5 = new MLLib.Controls.TabPageEx();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabDevice.SuspendLayout();
            this.tabPageEx1.SuspendLayout();
            this.tabFunction.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlFooter
            // 
            this.mlFooter.ImageFooter = global::Android_Utility.Properties.Resources._1446820679_android;
            this.mlFooter.Location = new System.Drawing.Point(0, 641);
            this.mlFooter.Size = new System.Drawing.Size(1162, 42);
            this.mlFooter.TitleFooter = "ANDROID UTILITY";
            // 
            // mlHeader
            // 
            this.mlHeader.AllowClose = true;
            this.mlHeader.AllowMaximize = true;
            this.mlHeader.AllowMinimize = true;
            this.mlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mlHeader.Icon = global::Android_Utility.Properties.Resources._1446820849_android_online_social_media;
            this.mlHeader.Location = new System.Drawing.Point(0, 1);
            this.mlHeader.Size = new System.Drawing.Size(1162, 65);
            this.mlHeader.Title = "frmInstallMultipleDevice";
            this.mlHeader.TitleBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.mlHeader.IconClick += new System.EventHandler(this.mlHeader_IconClick);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.splitContainer1);
            this.panel.Controls.Add(this.tabLog);
            this.panel.Size = new System.Drawing.Size(1162, 683);
            this.panel.Controls.SetChildIndex(this.mlFooter, 0);
            this.panel.Controls.SetChildIndex(this.tabLog, 0);
            this.panel.Controls.SetChildIndex(this.mlHeader, 0);
            this.panel.Controls.SetChildIndex(this.splitContainer1, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 66);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabDevice);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabFunction);
            this.splitContainer1.Size = new System.Drawing.Size(1162, 398);
            this.splitContainer1.SplitterDistance = 283;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 12;
            // 
            // tabDevice
            // 
            this.tabDevice.AllowDrop = true;
            this.tabDevice.BackgroundHatcher.BackColor = System.Drawing.Color.Silver;
            this.tabDevice.BackgroundHatcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabDevice.BackgroundHatcher.HatchStyle = "LightUpwardDiagonal";
            this.tabDevice.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal;
            this.tabDevice.BorderColor = System.Drawing.Color.SteelBlue;
            this.tabDevice.Controls.Add(this.tabPageEx1);
            this.tabDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDevice.HeaderStyle = MLLib.Controls.ctTabControl.TabHeaderStyle.Hatch;
            this.tabDevice.IsCaptionVisible = false;
            this.tabDevice.IsDrawEdgeBorder = true;
            this.tabDevice.ItemSize = new System.Drawing.Size(0, 35);
            this.tabDevice.Location = new System.Drawing.Point(0, 0);
            this.tabDevice.Name = "tabDevice";
            this.tabDevice.SelectedIndex = 0;
            this.tabDevice.Size = new System.Drawing.Size(283, 398);
            this.tabDevice.TabGradient.ColorEnd = System.Drawing.Color.White;
            this.tabDevice.TabIndex = 0;
            this.tabDevice.TabPageCloseIconColor = System.Drawing.Color.Transparent;
            this.tabDevice.TabStyles = MLLib.Controls.ctTabControl.TabStyle.OfficeXP;
            this.tabDevice.UpDownStyle = MLLib.Controls.ctTabControl.UpDown32Style.OfficeBlue;
            // 
            // tabPageEx1
            // 
            this.tabPageEx1.BackColor = System.Drawing.Color.White;
            this.tabPageEx1.Controls.Add(this.listofdevice);
            this.tabPageEx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPageEx1.Location = new System.Drawing.Point(5, 41);
            this.tabPageEx1.Name = "tabPageEx1";
            this.tabPageEx1.Size = new System.Drawing.Size(273, 352);
            this.tabPageEx1.TabIndex = 0;
            this.tabPageEx1.Text = "List of Devices";
            // 
            // listofdevice
            // 
            this.listofdevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listofdevice.Location = new System.Drawing.Point(0, 0);
            this.listofdevice.MultipleSelect = false;
            this.listofdevice.Name = "listofdevice";
            this.listofdevice.Padding = new System.Windows.Forms.Padding(3);
            this.listofdevice.Size = new System.Drawing.Size(273, 352);
            this.listofdevice.TabIndex = 0;
            this.listofdevice.OutputLog += new Android_Utility.Utils.InsertLogDelegate(this.InsertLog);
            // 
            // tabFunction
            // 
            this.tabFunction.AllowDrop = true;
            this.tabFunction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tabFunction.BackgroundHatcher.BackColor = System.Drawing.Color.Silver;
            this.tabFunction.BackgroundHatcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabFunction.BackgroundHatcher.HatchStyle = "LightDownwardDiagonal";
            this.tabFunction.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.tabFunction.BorderColor = System.Drawing.Color.SteelBlue;
            this.tabFunction.Controls.Add(this.tpInstall);
            this.tabFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFunction.HeaderStyle = MLLib.Controls.ctTabControl.TabHeaderStyle.Hatch;
            this.tabFunction.IsCaptionVisible = false;
            this.tabFunction.IsDrawEdgeBorder = true;
            this.tabFunction.ItemSize = new System.Drawing.Size(0, 35);
            this.tabFunction.Location = new System.Drawing.Point(0, 0);
            this.tabFunction.Name = "tabFunction";
            this.tabFunction.SelectedIndex = 0;
            this.tabFunction.Size = new System.Drawing.Size(878, 398);
            this.tabFunction.TabGradient.ColorEnd = System.Drawing.Color.White;
            this.tabFunction.TabIndex = 8;
            this.tabFunction.TabPageCloseIconColor = System.Drawing.Color.Transparent;
            this.tabFunction.TabStyles = MLLib.Controls.ctTabControl.TabStyle.OfficeXP;
            this.tabFunction.UpDownStyle = MLLib.Controls.ctTabControl.UpDown32Style.OfficeBlue;
            this.tabFunction.SelectedIndexChanged += new System.EventHandler(this.tabFunction_SelectedIndexChanged);
            // 
            // tpInstall
            // 
            this.tpInstall.BackColor = System.Drawing.Color.White;
            this.tpInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpInstall.IsClosable = false;
            this.tpInstall.Location = new System.Drawing.Point(5, 41);
            this.tpInstall.Name = "tpInstall";
            this.tpInstall.Padding = new System.Windows.Forms.Padding(3);
            this.tpInstall.Size = new System.Drawing.Size(868, 352);
            this.tpInstall.TabIndex = 1;
            this.tpInstall.Text = "List Apk Files";
            this.tpInstall.UseVisualStyleBackColor = true;
            // 
            // tabLog
            // 
            this.tabLog.AllowDrop = true;
            this.tabLog.BackgroundHatcher.BackColor = System.Drawing.Color.Silver;
            this.tabLog.BackgroundHatcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabLog.BackgroundHatcher.HatchStyle = "LightDownwardDiagonal";
            this.tabLog.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.LightDownwardDiagonal;
            this.tabLog.BorderColor = System.Drawing.Color.SteelBlue;
            this.tabLog.Controls.Add(this.tabPage5);
            this.tabLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabLog.HeaderStyle = MLLib.Controls.ctTabControl.TabHeaderStyle.Hatch;
            this.tabLog.IsCaptionVisible = false;
            this.tabLog.IsDrawEdgeBorder = true;
            this.tabLog.IsDrawTabSeparator = true;
            this.tabLog.ItemSize = new System.Drawing.Size(0, 35);
            this.tabLog.Location = new System.Drawing.Point(0, 464);
            this.tabLog.Name = "tabLog";
            this.tabLog.SelectedIndex = 0;
            this.tabLog.Size = new System.Drawing.Size(1162, 177);
            this.tabLog.TabGradient.ColorEnd = System.Drawing.Color.White;
            this.tabLog.TabIndex = 13;
            this.tabLog.TabPageCloseIconColor = System.Drawing.Color.Transparent;
            this.tabLog.TabStyles = MLLib.Controls.ctTabControl.TabStyle.OfficeXP;
            this.tabLog.UpDownStyle = MLLib.Controls.ctTabControl.UpDown32Style.OfficeBlue;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.richTextBox1);
            this.tabPage5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabPage5.Location = new System.Drawing.Point(5, 41);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1152, 131);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Log";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.White;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1146, 125);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // frmInstallMultipleDevice
            // 
            this.AllowClose = true;
            this.AllowMaximize = true;
            this.AllowMinimize = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 685);
            this.HideFooter = false;
            this.HideHeader = false;
            this.Name = "frmInstallMultipleDevice";
            this.ShowPinButton = true;
            this.Text = "frmInstallMultipleDevice";
            this.Load += new System.EventHandler(this.frmInstallMultipleDevice_Load);
            this.panel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabDevice.ResumeLayout(false);
            this.tabPageEx1.ResumeLayout(false);
            this.tabFunction.ResumeLayout(false);
            this.tabLog.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private MLLib.Controls.ctTabControl tabDevice;
        private MLLib.Controls.TabPageEx tabPageEx1;
        private MLLib.Controls.ctTabControl tabFunction;
        private MLLib.Controls.TabPageEx tpInstall;
        private MLLib.Controls.ctTabControl tabLog;
        private MLLib.Controls.TabPageEx tabPage5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private ctListOfDevice listofdevice;
    }
}