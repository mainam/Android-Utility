namespace Android_Utility
{
    partial class ctFillContactCallLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctFillContactCallLog));
            this.ctPanel2 = new MLLib.Controls.ctPanel();
            this.btnFillCallLog = new MLLib.Controls.ctButton();
            this.txtInComing = new MLLib.Controls.ctTextBox();
            this.txtOutGoing = new MLLib.Controls.ctTextBox();
            this.txtMissed = new MLLib.Controls.ctTextBox();
            this.ctPanel1 = new MLLib.Controls.ctPanel();
            this.ctPanel4 = new MLLib.Controls.ctPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSetDefault = new MLLib.Controls.ctButton();
            this.txtInbox = new MLLib.Controls.ctTextBox();
            this.btnFillSMS = new MLLib.Controls.ctButton();
            this.txtSent = new MLLib.Controls.ctTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctPanel3 = new MLLib.Controls.ctPanel();
            this.btnFillContact = new MLLib.Controls.ctButton();
            this.txtContact = new MLLib.Controls.ctTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctPanel2.SuspendLayout();
            this.ctPanel1.SuspendLayout();
            this.ctPanel4.SuspendLayout();
            this.ctPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctPanel2
            // 
            this.ctPanel2.AutoScroll = true;
            this.ctPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel2.BackgroundImage")));
            this.ctPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel2.Controls.Add(this.btnFillCallLog);
            this.ctPanel2.Controls.Add(this.txtInComing);
            this.ctPanel2.Controls.Add(this.txtOutGoing);
            this.ctPanel2.Controls.Add(this.txtMissed);
            this.ctPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel2.Location = new System.Drawing.Point(0, 23);
            this.ctPanel2.Name = "ctPanel2";
            this.ctPanel2.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel2.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel2.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel2.Size = new System.Drawing.Size(769, 151);
            this.ctPanel2.TabIndex = 3;
            // 
            // btnFillCallLog
            // 
            this.btnFillCallLog.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnFillCallLog.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnFillCallLog.ButtonBorderSize = 1;
            this.btnFillCallLog.ButtonDataText = "Fill CallLog";
            this.btnFillCallLog.Location = new System.Drawing.Point(260, 114);
            this.btnFillCallLog.Name = "btnFillCallLog";
            this.btnFillCallLog.Size = new System.Drawing.Size(78, 31);
            this.btnFillCallLog.TabIndex = 3;
            this.btnFillCallLog.Click += new System.EventHandler(this.btnFillCallLog_Click);
            // 
            // txtInComing
            // 
            this.txtInComing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtInComing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtInComing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtInComing.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInComing.DataText = "0";
            this.txtInComing.IsPasswordTextBox = false;
            this.txtInComing.Location = new System.Drawing.Point(6, 78);
            this.txtInComing.Name = "txtInComing";
            this.txtInComing.PaddingBottom = 0;
            this.txtInComing.PaddingLeft = 0;
            this.txtInComing.PaddingRight = 0;
            this.txtInComing.PaddingTop = 0;
            this.txtInComing.ReadOnly = false;
            this.txtInComing.Size = new System.Drawing.Size(332, 30);
            this.txtInComing.TabIndex = 2;
            this.txtInComing.TextHint = "InComing";
            this.txtInComing.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtInComing.TextHintWidth = 100;
            this.txtInComing.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtInComing.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // txtOutGoing
            // 
            this.txtOutGoing.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOutGoing.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOutGoing.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtOutGoing.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutGoing.DataText = "0";
            this.txtOutGoing.IsPasswordTextBox = false;
            this.txtOutGoing.Location = new System.Drawing.Point(6, 42);
            this.txtOutGoing.Name = "txtOutGoing";
            this.txtOutGoing.PaddingBottom = 0;
            this.txtOutGoing.PaddingLeft = 0;
            this.txtOutGoing.PaddingRight = 0;
            this.txtOutGoing.PaddingTop = 0;
            this.txtOutGoing.ReadOnly = false;
            this.txtOutGoing.Size = new System.Drawing.Size(332, 30);
            this.txtOutGoing.TabIndex = 1;
            this.txtOutGoing.TextHint = "OutGoing";
            this.txtOutGoing.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtOutGoing.TextHintWidth = 100;
            this.txtOutGoing.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtOutGoing.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // txtMissed
            // 
            this.txtMissed.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtMissed.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtMissed.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtMissed.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMissed.DataText = "0";
            this.txtMissed.IsPasswordTextBox = false;
            this.txtMissed.Location = new System.Drawing.Point(6, 6);
            this.txtMissed.Name = "txtMissed";
            this.txtMissed.PaddingBottom = 0;
            this.txtMissed.PaddingLeft = 0;
            this.txtMissed.PaddingRight = 0;
            this.txtMissed.PaddingTop = 0;
            this.txtMissed.ReadOnly = false;
            this.txtMissed.Size = new System.Drawing.Size(332, 30);
            this.txtMissed.TabIndex = 0;
            this.txtMissed.TextHint = "Missed";
            this.txtMissed.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtMissed.TextHintWidth = 100;
            this.txtMissed.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtMissed.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // ctPanel1
            // 
            this.ctPanel1.AutoScroll = true;
            this.ctPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel1.BackgroundImage")));
            this.ctPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel1.BorderColor = System.Drawing.Color.White;
            this.ctPanel1.Controls.Add(this.ctPanel4);
            this.ctPanel1.Controls.Add(this.label3);
            this.ctPanel1.Controls.Add(this.ctPanel3);
            this.ctPanel1.Controls.Add(this.label2);
            this.ctPanel1.Controls.Add(this.ctPanel2);
            this.ctPanel1.Controls.Add(this.label1);
            this.ctPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctPanel1.Location = new System.Drawing.Point(0, 0);
            this.ctPanel1.Name = "ctPanel1";
            this.ctPanel1.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel1.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel1.Size = new System.Drawing.Size(769, 466);
            this.ctPanel1.TabIndex = 0;
            // 
            // ctPanel4
            // 
            this.ctPanel4.AutoScroll = true;
            this.ctPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel4.BackgroundImage")));
            this.ctPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel4.Controls.Add(this.label4);
            this.ctPanel4.Controls.Add(this.btnSetDefault);
            this.ctPanel4.Controls.Add(this.txtInbox);
            this.ctPanel4.Controls.Add(this.btnFillSMS);
            this.ctPanel4.Controls.Add(this.txtSent);
            this.ctPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel4.Location = new System.Drawing.Point(0, 299);
            this.ctPanel4.Name = "ctPanel4";
            this.ctPanel4.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel4.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel4.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel4.Size = new System.Drawing.Size(769, 146);
            this.ctPanel4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(339, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tip: before filling in the data, please click \"set default sms app\" button \r\nand " +
    "click confirm in device. If not, this function not working.";
            // 
            // btnSetDefault
            // 
            this.btnSetDefault.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnSetDefault.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnSetDefault.ButtonBorderSize = 1;
            this.btnSetDefault.ButtonDataText = "Set default SMS App";
            this.btnSetDefault.Location = new System.Drawing.Point(6, 109);
            this.btnSetDefault.Name = "btnSetDefault";
            this.btnSetDefault.Size = new System.Drawing.Size(119, 31);
            this.btnSetDefault.TabIndex = 3;
            this.btnSetDefault.Click += new System.EventHandler(this.btnSetDefault_Click);
            // 
            // txtInbox
            // 
            this.txtInbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtInbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtInbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtInbox.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInbox.DataText = "0";
            this.txtInbox.IsPasswordTextBox = false;
            this.txtInbox.Location = new System.Drawing.Point(6, 42);
            this.txtInbox.Name = "txtInbox";
            this.txtInbox.PaddingBottom = 0;
            this.txtInbox.PaddingLeft = 0;
            this.txtInbox.PaddingRight = 0;
            this.txtInbox.PaddingTop = 0;
            this.txtInbox.ReadOnly = false;
            this.txtInbox.Size = new System.Drawing.Size(332, 30);
            this.txtInbox.TabIndex = 2;
            this.txtInbox.TextHint = "Inbox";
            this.txtInbox.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtInbox.TextHintWidth = 100;
            this.txtInbox.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtInbox.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // btnFillSMS
            // 
            this.btnFillSMS.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnFillSMS.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnFillSMS.ButtonBorderSize = 1;
            this.btnFillSMS.ButtonDataText = "Fill SMS";
            this.btnFillSMS.Location = new System.Drawing.Point(260, 109);
            this.btnFillSMS.Name = "btnFillSMS";
            this.btnFillSMS.Size = new System.Drawing.Size(78, 31);
            this.btnFillSMS.TabIndex = 1;
            this.btnFillSMS.Click += new System.EventHandler(this.btnFillSMS_Click);
            // 
            // txtSent
            // 
            this.txtSent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSent.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSent.DataText = "0";
            this.txtSent.IsPasswordTextBox = false;
            this.txtSent.Location = new System.Drawing.Point(6, 6);
            this.txtSent.Name = "txtSent";
            this.txtSent.PaddingBottom = 0;
            this.txtSent.PaddingLeft = 0;
            this.txtSent.PaddingRight = 0;
            this.txtSent.PaddingTop = 0;
            this.txtSent.ReadOnly = false;
            this.txtSent.Size = new System.Drawing.Size(332, 30);
            this.txtSent.TabIndex = 0;
            this.txtSent.TextHint = "Sent";
            this.txtSent.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtSent.TextHintWidth = 100;
            this.txtSent.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtSent.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 276);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Fill SMS";
            // 
            // ctPanel3
            // 
            this.ctPanel3.AutoScroll = true;
            this.ctPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ctPanel3.BackgroundImage")));
            this.ctPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ctPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ctPanel3.Controls.Add(this.btnFillContact);
            this.ctPanel3.Controls.Add(this.txtContact);
            this.ctPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctPanel3.Location = new System.Drawing.Point(0, 197);
            this.ctPanel3.Name = "ctPanel3";
            this.ctPanel3.Padding = new System.Windows.Forms.Padding(3);
            this.ctPanel3.PageEndColor = System.Drawing.Color.Empty;
            this.ctPanel3.PageStartColor = System.Drawing.Color.Empty;
            this.ctPanel3.Size = new System.Drawing.Size(769, 79);
            this.ctPanel3.TabIndex = 15;
            // 
            // btnFillContact
            // 
            this.btnFillContact.ButtonBackgroundColor = System.Drawing.Color.White;
            this.btnFillContact.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnFillContact.ButtonBorderSize = 1;
            this.btnFillContact.ButtonDataText = "Fill Contact";
            this.btnFillContact.Location = new System.Drawing.Point(260, 42);
            this.btnFillContact.Name = "btnFillContact";
            this.btnFillContact.Size = new System.Drawing.Size(78, 31);
            this.btnFillContact.TabIndex = 1;
            this.btnFillContact.Click += new System.EventHandler(this.btnFillContact_Click);
            // 
            // txtContact
            // 
            this.txtContact.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtContact.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtContact.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtContact.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContact.DataText = "0";
            this.txtContact.IsPasswordTextBox = false;
            this.txtContact.Location = new System.Drawing.Point(6, 6);
            this.txtContact.Name = "txtContact";
            this.txtContact.PaddingBottom = 0;
            this.txtContact.PaddingLeft = 0;
            this.txtContact.PaddingRight = 0;
            this.txtContact.PaddingTop = 0;
            this.txtContact.ReadOnly = false;
            this.txtContact.Size = new System.Drawing.Size(332, 30);
            this.txtContact.TabIndex = 0;
            this.txtContact.TextHint = "Contact";
            this.txtContact.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtContact.TextHintWidth = 100;
            this.txtContact.EventKeyLeave += new System.EventHandler(this.txtMissed_EventKeyLeave);
            this.txtContact.EventKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMissed_EventKeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 174);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fill Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fill Call Log";
            // 
            // ctFillContactCallLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ctPanel1);
            this.Name = "ctFillContactCallLog";
            this.Size = new System.Drawing.Size(769, 466);
            this.ctPanel2.ResumeLayout(false);
            this.ctPanel1.ResumeLayout(false);
            this.ctPanel1.PerformLayout();
            this.ctPanel4.ResumeLayout(false);
            this.ctPanel4.PerformLayout();
            this.ctPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctPanel ctPanel2;
        private MLLib.Controls.ctTextBox txtInComing;
        private MLLib.Controls.ctTextBox txtOutGoing;
        private MLLib.Controls.ctTextBox txtMissed;
        private MLLib.Controls.ctButton btnFillCallLog;
        private MLLib.Controls.ctPanel ctPanel1;
        private System.Windows.Forms.Label label1;
        private MLLib.Controls.ctPanel ctPanel3;
        private MLLib.Controls.ctButton btnFillContact;
        private MLLib.Controls.ctTextBox txtContact;
        private System.Windows.Forms.Label label2;
        private MLLib.Controls.ctPanel ctPanel4;
        private MLLib.Controls.ctTextBox txtInbox;
        private MLLib.Controls.ctButton btnFillSMS;
        private MLLib.Controls.ctTextBox txtSent;
        private System.Windows.Forms.Label label3;
        private MLLib.Controls.ctButton btnSetDefault;
        private System.Windows.Forms.Label label4;
    }
}
