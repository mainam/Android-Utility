namespace MLLib.Theme
{
    partial class ctHeaderBox
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
            this.lbTitleBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitleBox
            // 
            this.lbTitleBox.AutoSize = true;
            this.lbTitleBox.Location = new System.Drawing.Point(172, 18);
            this.lbTitleBox.Name = "lbTitleBox";
            this.lbTitleBox.Size = new System.Drawing.Size(35, 13);
            this.lbTitleBox.TabIndex = 0;
            this.lbTitleBox.Text = "label1";
            // 
            // ctHeaderBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTitleBox);
            this.Name = "ctHeaderBox";
            this.Size = new System.Drawing.Size(416, 50);
            this.Load += new System.EventHandler(this.ctHeaderBox_Load);
            this.SizeChanged += new System.EventHandler(this.ctHeaderBox_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleBox;
    }
}
