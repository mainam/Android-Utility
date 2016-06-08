namespace Android_Utility
{
    partial class ctInstallApkFromLink
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
            this.ctTextBox1 = new MLLib.Controls.ctTextBox();
            this.btnInstall = new MLLib.Controls.ctButton();
            this.SuspendLayout();
            // 
            // ctTextBox1
            // 
            this.ctTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ctTextBox1.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTextBox1.Text = "";
            this.ctTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctTextBox1.IsPasswordTextBox = false;
            this.ctTextBox1.Location = new System.Drawing.Point(0, 0);
            this.ctTextBox1.Name = "ctTextBox1";
            this.ctTextBox1.Size = new System.Drawing.Size(568, 29);
            this.ctTextBox1.TabIndex = 0;
            this.ctTextBox1.TextHint = "Link Apk";
            this.ctTextBox1.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.ctTextBox1.TextHintWidth = 100;
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
            this.btnInstall.TabIndex = 1;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_ButtonClick);
            // 
            // ctInstallApkFromLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ctTextBox1);
            this.Controls.Add(this.btnInstall);
            this.Name = "ctInstallApkFromLink";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.Size = new System.Drawing.Size(676, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctTextBox ctTextBox1;
        private MLLib.Controls.ctButton btnInstall;
    }
}
