namespace MLLib.Controls
{
    partial class ctOpenFileDialog
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
            this.txtFile = new MLLib.Controls.ctTextBox();
            this.btnBrowser = new MLLib.Controls.ctButton();
            this.SuspendLayout();
            // 
            // txtFile
            // 
            this.txtFile.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFile.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFile.BorderColor = System.Drawing.Color.White;
            this.txtFile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFile.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFile.DataText = "";
            this.txtFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFile.Enabled = false;
            this.txtFile.IsPasswordTextBox = false;
            this.txtFile.Location = new System.Drawing.Point(0, 0);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(618, 27);
            this.txtFile.TabIndex = 3;
            this.txtFile.TextHint = "";
            this.txtFile.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtFile.TextHintWidth = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnBrowser.ButtonBackgroundColor = System.Drawing.Color.Aquamarine;
            this.btnBrowser.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnBrowser.ButtonBorderSize = 0;
            this.btnBrowser.ButtonDataText = "...";
            this.btnBrowser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBrowser.Location = new System.Drawing.Point(618, 0);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btnBrowser.Size = new System.Drawing.Size(62, 27);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "...";
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // ctOpenFileDialog
            // 
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.btnBrowser);
            this.Name = "ctOpenFileDialog";
            this.Size = new System.Drawing.Size(680, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private ctButton btnBrowser;
        private MLLib.Controls.ctTextBox txtFile;
    }
}
