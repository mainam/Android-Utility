namespace Android_Utility
{
    partial class ctListOfDevice
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
            this.components = new System.ComponentModel.Container();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbAutoReload = new System.Windows.Forms.CheckBox();
            this.btnReload = new MLLib.Controls.ctButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnDevice = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 372);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(883, 1);
            this.ctBreakLine1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chbAutoReload);
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 373);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 29);
            this.panel1.TabIndex = 1;
            // 
            // chbAutoReload
            // 
            this.chbAutoReload.AutoSize = true;
            this.chbAutoReload.Checked = true;
            this.chbAutoReload.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbAutoReload.Dock = System.Windows.Forms.DockStyle.Left;
            this.chbAutoReload.Location = new System.Drawing.Point(0, 0);
            this.chbAutoReload.Name = "chbAutoReload";
            this.chbAutoReload.Size = new System.Drawing.Size(85, 29);
            this.chbAutoReload.TabIndex = 13;
            this.chbAutoReload.Text = "Auto Reload";
            this.chbAutoReload.UseVisualStyleBackColor = true;
            this.chbAutoReload.CheckedChanged += new System.EventHandler(this.chbAutoReload_CheckedChanged);
            // 
            // btnReload
            // 
            this.btnReload.ButtonBackgroundColor = System.Drawing.Color.Transparent;
            this.btnReload.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnReload.ButtonBorderSize = 1;
            this.btnReload.ButtonDataText = "Reload";
            this.btnReload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnReload.Location = new System.Drawing.Point(799, 0);
            this.btnReload.Name = "btnReload";
            this.btnReload.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.btnReload.Size = new System.Drawing.Size(84, 29);
            this.btnReload.TabIndex = 12;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnDevice
            // 
            this.pnDevice.AutoScroll = true;
            this.pnDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDevice.Location = new System.Drawing.Point(0, 0);
            this.pnDevice.Name = "pnDevice";
            this.pnDevice.Size = new System.Drawing.Size(883, 372);
            this.pnDevice.TabIndex = 2;
            // 
            // ctListOfDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnDevice);
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.panel1);
            this.Name = "ctListOfDevice";
            this.Size = new System.Drawing.Size(883, 402);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctBreakLine ctBreakLine1;
        private System.Windows.Forms.Panel panel1;
        private MLLib.Controls.ctButton btnReload;
        private System.Windows.Forms.Panel pnDevice;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.CheckBox chbAutoReload;

    }
}
