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
            this.btnTurnOnAndConnect = new MLLib.Controls.ctButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new MLLib.Controls.ctTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnConnect.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnConnect.ButtonBorderSize = 1;
            this.btnConnect.ButtonDataText = "Connect";
            this.btnConnect.Location = new System.Drawing.Point(84, 169);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(66, 25);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnTurnOnAndConnect
            // 
            this.btnTurnOnAndConnect.ButtonBackgroundColor = System.Drawing.SystemColors.Control;
            this.btnTurnOnAndConnect.ButtonBorderColor = System.Drawing.Color.Empty;
            this.btnTurnOnAndConnect.ButtonBorderSize = 1;
            this.btnTurnOnAndConnect.ButtonDataText = "Turn On TCPIP and Connect";
            this.btnTurnOnAndConnect.Location = new System.Drawing.Point(84, 52);
            this.btnTurnOnAndConnect.Name = "btnTurnOnAndConnect";
            this.btnTurnOnAndConnect.Size = new System.Drawing.Size(257, 50);
            this.btnTurnOnAndConnect.TabIndex = 1;
            this.btnTurnOnAndConnect.Click += new System.EventHandler(this.btnTurnOnAndConnect_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnTurnOnAndConnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Location = new System.Drawing.Point(71, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 233);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "OR Connect with IP (if your device is turn ON TCPIP)";
            // 
            // txtIP
            // 
            this.txtIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIP.BorderColor = System.Drawing.Color.Gray;
            this.txtIP.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.DataText = "";
            this.txtIP.IsPasswordTextBox = false;
            this.txtIP.Location = new System.Drawing.Point(84, 138);
            this.txtIP.Name = "txtIP";
            this.txtIP.PaddingBottom = 0;
            this.txtIP.PaddingLeft = 0;
            this.txtIP.PaddingRight = 0;
            this.txtIP.PaddingTop = 0;
            this.txtIP.ReadOnly = false;
            this.txtIP.Size = new System.Drawing.Size(257, 25);
            this.txtIP.TabIndex = 3;
            this.txtIP.TextHint = "Enter IP";
            this.txtIP.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtIP.TextHintWidth = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Step 1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Step 2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Connect your device Android (with USB cable) and click to Turn On button bellow";
            // 
            // ctEnableTCPIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ctEnableTCPIP";
            this.Size = new System.Drawing.Size(537, 314);
            this.SizeChanged += new System.EventHandler(this.ctEnableTCPIP_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MLLib.Controls.ctButton btnConnect;
        private MLLib.Controls.ctButton btnTurnOnAndConnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private MLLib.Controls.ctTextBox txtIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}
