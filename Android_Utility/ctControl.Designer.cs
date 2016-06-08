namespace Android_Utility
{
    partial class ctControl
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
            this.ctRunADB = new MLLib.Controls.ctButton();
            this.ctRebootDownload = new MLLib.Controls.ctButton();
            this.ctRebootUpload = new MLLib.Controls.ctButton();
            this.ctKillAdb = new MLLib.Controls.ctButton();
            this.SuspendLayout();
            // 
            // ctRunADB
            // 
            this.ctRunADB.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.ctRunADB.ButtonBorderColor = System.Drawing.Color.Empty;
            this.ctRunADB.ButtonBorderSize = 1;
            this.ctRunADB.ButtonDataText = "Run ADB";
            this.ctRunADB.Location = new System.Drawing.Point(20, 23);
            this.ctRunADB.Name = "ctRunADB";
            this.ctRunADB.Size = new System.Drawing.Size(179, 44);
            this.ctRunADB.TabIndex = 0;
            this.ctRunADB.Click += new System.EventHandler(this.ctRunADB_ButtonClick);
            // 
            // ctRebootDownload
            // 
            this.ctRebootDownload.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.ctRebootDownload.ButtonBorderColor = System.Drawing.Color.Empty;
            this.ctRebootDownload.ButtonBorderSize = 1;
            this.ctRebootDownload.ButtonDataText = "Reboot To Download Mode";
            this.ctRebootDownload.Location = new System.Drawing.Point(20, 84);
            this.ctRebootDownload.Name = "ctRebootDownload";
            this.ctRebootDownload.Size = new System.Drawing.Size(179, 44);
            this.ctRebootDownload.TabIndex = 0;
            this.ctRebootDownload.Click += new System.EventHandler(this.ctRebootDownload_Click);
            // 
            // ctRebootUpload
            // 
            this.ctRebootUpload.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.ctRebootUpload.ButtonBorderColor = System.Drawing.Color.Empty;
            this.ctRebootUpload.ButtonBorderSize = 1;
            this.ctRebootUpload.ButtonDataText = "Reboot To Upload Mode";
            this.ctRebootUpload.Location = new System.Drawing.Point(20, 144);
            this.ctRebootUpload.Name = "ctRebootUpload";
            this.ctRebootUpload.Size = new System.Drawing.Size(179, 44);
            this.ctRebootUpload.TabIndex = 0;
            this.ctRebootUpload.Click += new System.EventHandler(this.ctRebootUpload_Click);
            // 
            // ctKillAdb
            // 
            this.ctKillAdb.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.ctKillAdb.ButtonBorderColor = System.Drawing.Color.Empty;
            this.ctKillAdb.ButtonBorderSize = 1;
            this.ctKillAdb.ButtonDataText = "Kill ADB";
            this.ctKillAdb.Location = new System.Drawing.Point(20, 207);
            this.ctKillAdb.Name = "ctKillAdb";
            this.ctKillAdb.Size = new System.Drawing.Size(179, 44);
            this.ctKillAdb.TabIndex = 0;
            this.ctKillAdb.Click += new System.EventHandler(this.ctKillAdb_ButtonClick);
            // 
            // ctControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctKillAdb);
            this.Controls.Add(this.ctRebootUpload);
            this.Controls.Add(this.ctRebootDownload);
            this.Controls.Add(this.ctRunADB);
            this.Name = "ctControl";
            this.Size = new System.Drawing.Size(890, 408);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctButton ctRunADB;
        public MLLib.Controls.ctButton ctRebootDownload;
        public MLLib.Controls.ctButton ctRebootUpload;
        public MLLib.Controls.ctButton ctKillAdb;
    }
}
