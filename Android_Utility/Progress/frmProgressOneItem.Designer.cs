namespace Android_Utility.Progress
{
    partial class frmProgressOneItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgressOneItem));
            this.ctProcessStyle21 = new MLLib.Controls.ctProcessStyle2();
            this.SuspendLayout();
            // 
            // ctProcessStyle21
            // 
            this.ctProcessStyle21.CurrentForm = this;
            this.ctProcessStyle21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctProcessStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctProcessStyle21.Location = new System.Drawing.Point(0, 0);
            this.ctProcessStyle21.LockForm = false;
            this.ctProcessStyle21.Name = "ctProcessStyle21";
            this.ctProcessStyle21.Size = new System.Drawing.Size(355, 67);
            this.ctProcessStyle21.TabIndex = 0;
            // 
            // frmProgressOneItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 67);
            this.Controls.Add(this.ctProcessStyle21);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgressOneItem";
            this.Opacity = 0.98D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProgessInstall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgessInstall_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctProcessStyle2 ctProcessStyle21;

    }
}