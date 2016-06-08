namespace Android_Utility
{
    partial class ctFillData
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
            this.tabFillData = new MLLib.Controls.ctTabControl();
            this.tpFillFileMedia = new MLLib.Controls.TabPageEx();
            this.tpFillContactCallLogSMS = new MLLib.Controls.TabPageEx();
            this.tpFillFullMemory = new MLLib.Controls.TabPageEx();
            this.tabFillData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFillData
            // 
            this.tabFillData.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabFillData.Alignments = MLLib.Controls.ctTabControl.TabAlignments.Bottom;
            this.tabFillData.AllowDrop = true;
            this.tabFillData.BackgroundHatcher.BackColor = System.Drawing.Color.Silver;
            this.tabFillData.BackgroundHatcher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabFillData.BackgroundHatcher.HatchStyle = "LightUpwardDiagonal";
            this.tabFillData.BackgroundHatcher.HatchType = System.Drawing.Drawing2D.HatchStyle.LightUpwardDiagonal;
            this.tabFillData.BorderColor = System.Drawing.Color.White;
            this.tabFillData.BorderStyle = MLLib.Controls.ctTabControl.ControlBorderStyle.Dotted;
            this.tabFillData.Controls.Add(this.tpFillContactCallLogSMS);
            this.tabFillData.Controls.Add(this.tpFillFileMedia);
            this.tabFillData.Controls.Add(this.tpFillFullMemory);
            this.tabFillData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabFillData.HeaderStyle = MLLib.Controls.ctTabControl.TabHeaderStyle.Hatch;
            this.tabFillData.IsCaptionVisible = false;
            this.tabFillData.IsDrawTabSeparator = true;
            this.tabFillData.ItemSize = new System.Drawing.Size(0, 35);
            this.tabFillData.Location = new System.Drawing.Point(0, 0);
            this.tabFillData.Name = "tabFillData";
            this.tabFillData.SelectedIndex = 1;
            this.tabFillData.Size = new System.Drawing.Size(652, 416);
            this.tabFillData.TabGradient.ColorEnd = System.Drawing.Color.White;
            this.tabFillData.TabIndex = 1;
            this.tabFillData.TabPageCloseIconColor = System.Drawing.Color.Transparent;
            this.tabFillData.TabStyles = MLLib.Controls.ctTabControl.TabStyle.OfficeXP;
            this.tabFillData.UpDownStyle = MLLib.Controls.ctTabControl.UpDown32Style.Default;
            this.tabFillData.SelectedIndexChanged += new System.EventHandler(this.tabSelectTypeFill_SelectedIndexChanged);
            // 
            // tpFillFileMedia
            // 
            this.tpFillFileMedia.BackColor = System.Drawing.Color.White;
            this.tpFillFileMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpFillFileMedia.IsClosable = false;
            this.tpFillFileMedia.Location = new System.Drawing.Point(1, 1);
            this.tpFillFileMedia.Name = "tpFillFileMedia";
            this.tpFillFileMedia.Size = new System.Drawing.Size(650, 374);
            this.tpFillFileMedia.TabIndex = 1;
            this.tpFillFileMedia.Text = "Fill File && Media";
            // 
            // tpFillContactCallLogSMS
            // 
            this.tpFillContactCallLogSMS.BackColor = System.Drawing.Color.White;
            this.tpFillContactCallLogSMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpFillContactCallLogSMS.IsClosable = false;
            this.tpFillContactCallLogSMS.Location = new System.Drawing.Point(1, 1);
            this.tpFillContactCallLogSMS.Name = "tpFillContactCallLogSMS";
            this.tpFillContactCallLogSMS.Size = new System.Drawing.Size(650, 374);
            this.tpFillContactCallLogSMS.TabIndex = 2;
            this.tpFillContactCallLogSMS.Text = "Fill Contact - Call Log - SMS";
            // 
            // tpFillFullMemory
            // 
            this.tpFillFullMemory.BackColor = System.Drawing.Color.White;
            this.tpFillFullMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tpFillFullMemory.IsClosable = false;
            this.tpFillFullMemory.Location = new System.Drawing.Point(1, 1);
            this.tpFillFullMemory.Name = "tpFillFullMemory";
            this.tpFillFullMemory.Size = new System.Drawing.Size(650, 374);
            this.tpFillFullMemory.TabIndex = 0;
            this.tpFillFullMemory.Text = "Fill Full Memory";
            // 
            // ctFillData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabFillData);
            this.Name = "ctFillData";
            this.Size = new System.Drawing.Size(652, 416);
            this.tabFillData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctTabControl tabFillData;
        private MLLib.Controls.TabPageEx tpFillFullMemory;
        private MLLib.Controls.TabPageEx tpFillFileMedia;
        private MLLib.Controls.TabPageEx tpFillContactCallLogSMS;
    }
}
