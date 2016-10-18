namespace Android_Utility
{
    partial class ctEnableTCPIP
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
            this.btnConnect = new MLLib.Controls.ctButton();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnConnect.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnConnect.ButtonBorderSize = 1;
            this.btnConnect.ButtonDataText = "Connect / Reconnect";
            this.btnConnect.Location = new System.Drawing.Point(116, 114);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(233, 72);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // ctEnableTCPIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConnect);
            this.Name = "ctEnableTCPIP";
            this.Size = new System.Drawing.Size(490, 314);
            this.SizeChanged += new System.EventHandler(this.ctEnableTCPIP_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctButton btnConnect;
    }
}
