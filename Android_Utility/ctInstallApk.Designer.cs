namespace Android_Utility
{
    partial class ctInstallApk
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnInstall = new MLLib.Controls.ctButton();
            this.ctInstallApkFromLocal1 = new Android_Utility.ctInstallApkFromLocal();
            this.ctInstallApkFromLink1 = new Android_Utility.ctInstallApkFromLink();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInstall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Size = new System.Drawing.Size(447, 32);
            this.panel1.TabIndex = 2;
            // 
            // btnInstall
            // 
            this.btnInstall.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnInstall.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnInstall.ButtonBorderSize = 1;
            this.btnInstall.ButtonDataText = "Install Multiple Device";
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInstall.Location = new System.Drawing.Point(286, 0);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInstall.Size = new System.Drawing.Size(161, 29);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // ctInstallApkFromLocal1
            // 
            this.ctInstallApkFromLocal1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctInstallApkFromLocal1.FileName = "";
            this.ctInstallApkFromLocal1.ListOfDevice = null;
            this.ctInstallApkFromLocal1.Location = new System.Drawing.Point(0, 32);
            this.ctInstallApkFromLocal1.Name = "ctInstallApkFromLocal1";
            this.ctInstallApkFromLocal1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ctInstallApkFromLocal1.Size = new System.Drawing.Size(447, 32);
            this.ctInstallApkFromLocal1.TabIndex = 1;
            // 
            // ctInstallApkFromLink1
            // 
            this.ctInstallApkFromLink1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ctInstallApkFromLink1.Link = "";
            this.ctInstallApkFromLink1.ListOfDevice = null;
            this.ctInstallApkFromLink1.Location = new System.Drawing.Point(0, 0);
            this.ctInstallApkFromLink1.Name = "ctInstallApkFromLink1";
            this.ctInstallApkFromLink1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.ctInstallApkFromLink1.Size = new System.Drawing.Size(447, 32);
            this.ctInstallApkFromLink1.TabIndex = 0;
            this.ctInstallApkFromLink1.TextHintColor = System.Drawing.SystemColors.ControlText;
            // 
            // ctInstallApk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ctInstallApkFromLocal1);
            this.Controls.Add(this.ctInstallApkFromLink1);
            this.Name = "ctInstallApk";
            this.Size = new System.Drawing.Size(447, 285);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctInstallApkFromLink ctInstallApkFromLink1;
        private ctInstallApkFromLocal ctInstallApkFromLocal1;
        private System.Windows.Forms.Panel panel1;
        private MLLib.Controls.ctButton btnInstall;
    }
}
