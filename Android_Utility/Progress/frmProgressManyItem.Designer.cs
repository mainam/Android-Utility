namespace Android_Utility.Progress
{
    partial class frmProgressManyItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgressManyItem));
            this.ctProcessStyle11 = new MLLib.Controls.ctProcessStyle1();
            this.SuspendLayout();
            // 
            // ctProcessStyle11
            // 
            this.ctProcessStyle11.CurrentForm = this;
            this.ctProcessStyle11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctProcessStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctProcessStyle11.Location = new System.Drawing.Point(0, 0);
            this.ctProcessStyle11.LockForm = false;
            this.ctProcessStyle11.Name = "ctProcessStyle11";
            this.ctProcessStyle11.Size = new System.Drawing.Size(371, 93);
            this.ctProcessStyle11.TabIndex = 0;
            this.ctProcessStyle11.CancelButtonClick += new System.EventHandler(this.ctProcessStyle11_CancelButtonClick);
            // 
            // frmProgressManyItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 93);
            this.Controls.Add(this.ctProcessStyle11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmProgressManyItem";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmProgressManyItem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgressManyItem_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctProcessStyle1 ctProcessStyle11;
    }
}