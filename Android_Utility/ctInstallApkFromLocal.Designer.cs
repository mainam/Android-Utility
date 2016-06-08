namespace Android_Utility
{
    partial class ctInstallApkFromLocal
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
            this.ctOpenFileDialog1 = new MLLib.Controls.ctOpenFileDialog();
            this.btnInstall = new MLLib.Controls.ctButton();
            this.SuspendLayout();
            // 
            // ctOpenFileDialog1
            // 
            this.ctOpenFileDialog1.BrowserButtonBackColor = System.Drawing.Color.Cyan;
            this.ctOpenFileDialog1.BrowserButtonText = "...";
            this.ctOpenFileDialog1.BrowserButtonWidth = 50;
            this.ctOpenFileDialog1.DialogTitle = "";
            this.ctOpenFileDialog1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctOpenFileDialog1.FileNameBackColor = System.Drawing.SystemColors.Control;
            this.ctOpenFileDialog1.FileNameReadOnly = true;
            this.ctOpenFileDialog1.FilterText = "Apk file | *.apk";
            this.ctOpenFileDialog1.LabelText = "Choose Apk file";
            this.ctOpenFileDialog1.LabelTextColor = System.Drawing.SystemColors.ControlText;
            this.ctOpenFileDialog1.LabelTextWidth = 100;
            this.ctOpenFileDialog1.Location = new System.Drawing.Point(0, 0);
            this.ctOpenFileDialog1.Name = "ctOpenFileDialog1";
            this.ctOpenFileDialog1.Size = new System.Drawing.Size(568, 29);
            this.ctOpenFileDialog1.TabIndex = 0;
            this.ctOpenFileDialog1.Type = MLLib.Controls.ctOpenFileDialog.TypeControl.SelectFile;
            this.ctOpenFileDialog1.Value = "";
            // 
            // btnInstall
            // 
            this.btnInstall.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnInstall.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnInstall.ButtonBorderSize = 1;
            this.btnInstall.ButtonDataText = "Install";
            this.btnInstall.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnInstall.Location = new System.Drawing.Point(568, 0);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInstall.Size = new System.Drawing.Size(108, 29);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // ctInstallApkFromLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctOpenFileDialog1);
            this.Controls.Add(this.btnInstall);
            this.Name = "ctInstallApkFromLocal";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(676, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctOpenFileDialog ctOpenFileDialog1;
        private MLLib.Controls.ctButton btnInstall;
    }
}
