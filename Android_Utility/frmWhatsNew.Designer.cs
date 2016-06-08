namespace Android_Utility
{
    partial class frmWhatsNew
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
            this.ctWhatsNew1 = new Android_Utility.ctWhatsNew();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mlFooter
            // 
            this.mlFooter.Location = new System.Drawing.Point(0, 415);
            this.mlFooter.Size = new System.Drawing.Size(635, 55);
            // 
            // mlHeader
            // 
            this.mlHeader.AllowClose = true;
            this.mlHeader.AllowMaximize = true;
            this.mlHeader.AllowMinimize = true;
            this.mlHeader.Location = new System.Drawing.Point(0, 1);
            this.mlHeader.Size = new System.Drawing.Size(635, 46);
            this.mlHeader.Title = "WHAT\'S NEW";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ctWhatsNew1);
            this.panel.Size = new System.Drawing.Size(635, 470);
            this.panel.Controls.SetChildIndex(this.mlHeader, 0);
            this.panel.Controls.SetChildIndex(this.mlFooter, 0);
            this.panel.Controls.SetChildIndex(this.ctWhatsNew1, 0);
            // 
            // ctWhatsNew1
            // 
            this.ctWhatsNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctWhatsNew1.Location = new System.Drawing.Point(0, 47);
            this.ctWhatsNew1.Name = "ctWhatsNew1";
            this.ctWhatsNew1.Padding = new System.Windows.Forms.Padding(5);
            this.ctWhatsNew1.Size = new System.Drawing.Size(635, 368);
            this.ctWhatsNew1.TabIndex = 3;
            // 
            // frmWhatsNew
            // 
            this.AllowClose = true;
            this.AllowMaximize = true;
            this.AllowMinimize = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 472);
            this.HideFooter = false;
            this.HideHeader = false;
            this.Name = "frmWhatsNew";
            this.ShowIcon = false;
            this.ShowPinButton = true;
            this.Text = "WHAT\'S NEW";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctWhatsNew ctWhatsNew1;
    }
}