namespace MLLib
{
    partial class ctFooter
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
            this.lbTitleFooter = new System.Windows.Forms.Label();
            this.ptImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitleFooter
            // 
            this.lbTitleFooter.AutoSize = true;
            this.lbTitleFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitleFooter.Location = new System.Drawing.Point(26, 18);
            this.lbTitleFooter.Name = "lbTitleFooter";
            this.lbTitleFooter.Size = new System.Drawing.Size(147, 20);
            this.lbTitleFooter.TabIndex = 0;
            this.lbTitleFooter.Text = "LABEL FOOTER ";
            // 
            // ptImage
            // 
            this.ptImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.ptImage.Location = new System.Drawing.Point(806, 5);
            this.ptImage.Name = "ptImage";
            this.ptImage.Size = new System.Drawing.Size(55, 45);
            this.ptImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptImage.TabIndex = 2;
            this.ptImage.TabStop = false;
            // 
            // ctFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.ptImage);
            this.Controls.Add(this.lbTitleFooter);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ctFooter";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(866, 55);
            this.Load += new System.EventHandler(this.ctFooter_Load);
            this.SizeChanged += new System.EventHandler(this.ctFooter_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.ptImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitleFooter;
        private System.Windows.Forms.PictureBox ptImage;

    }
}
