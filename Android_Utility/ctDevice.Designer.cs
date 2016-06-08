namespace Android_Utility
{
    partial class ctDevice
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
            this.txtSerial = new MLLib.Controls.ctTextBox();
            this.txtOnline = new MLLib.Controls.ctTextBox();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.SuspendLayout();
            // 
            // txtSerial
            // 
            this.txtSerial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSerial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSerial.BorderColor = System.Drawing.Color.White;
            this.txtSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSerial.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.DataText = "";
            this.txtSerial.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSerial.Enabled = false;
            this.txtSerial.IsPasswordTextBox = false;
            this.txtSerial.Location = new System.Drawing.Point(0, 0);
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(377, 22);
            this.txtSerial.TabIndex = 0;
            this.txtSerial.TextHint = "Serial";
            this.txtSerial.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtSerial.TextHintWidth = 50;
            // 
            // txtOnline
            // 
            this.txtOnline.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOnline.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOnline.BorderColor = System.Drawing.Color.White;
            this.txtOnline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtOnline.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOnline.DataText = "";
            this.txtOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtOnline.Enabled = false;
            this.txtOnline.IsPasswordTextBox = false;
            this.txtOnline.Location = new System.Drawing.Point(0, 22);
            this.txtOnline.Name = "txtOnline";
            this.txtOnline.Size = new System.Drawing.Size(377, 22);
            this.txtOnline.TabIndex = 1;
            this.txtOnline.TextHint = "Online";
            this.txtOnline.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtOnline.TextHintWidth = 50;
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.Black;
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.Black;
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 44);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(377, 1);
            this.ctBreakLine1.TabIndex = 2;
            // 
            // ctDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctBreakLine1);
            this.Controls.Add(this.txtOnline);
            this.Controls.Add(this.txtSerial);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ctDevice";
            this.Size = new System.Drawing.Size(377, 52);
            this.Click += new System.EventHandler(this.ctDevice_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ctDevice_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctTextBox txtSerial;
        private MLLib.Controls.ctTextBox txtOnline;
        private MLLib.Controls.ctBreakLine ctBreakLine1;

    }
}
