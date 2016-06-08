namespace Android_Utility
{
    partial class ctPackageMgr
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaveTo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ClearData = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Uninstall = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ForceStop = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearchPackage = new MLLib.Controls.ctTextBox();
            this.ctBreakLine1 = new MLLib.Controls.ctBreakLine();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package,
            this.Path,
            this.SaveTo,
            this.ClearData,
            this.Uninstall,
            this.ForceStop});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(464, 234);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // Package
            // 
            this.Package.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            this.Package.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 300;
            // 
            // SaveTo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            this.SaveTo.DefaultCellStyle = dataGridViewCellStyle1;
            this.SaveTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveTo.HeaderText = "Save To";
            this.SaveTo.Name = "SaveTo";
            this.SaveTo.ReadOnly = true;
            this.SaveTo.Text = "Save To";
            this.SaveTo.UseColumnTextForButtonValue = true;
            this.SaveTo.Width = 80;
            // 
            // ClearData
            // 
            this.ClearData.DefaultCellStyle = dataGridViewCellStyle1;
            this.ClearData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearData.HeaderText = "Clear Data";
            this.ClearData.Name = "ClearData";
            this.ClearData.ReadOnly = true;
            this.ClearData.Text = "Clear Data";
            this.ClearData.UseColumnTextForButtonValue = true;
            this.ClearData.Width = 80;
            // 
            // Uninstall
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            this.Uninstall.DefaultCellStyle = dataGridViewCellStyle2;
            this.Uninstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Uninstall.HeaderText = "Uninstall";
            this.Uninstall.Name = "Uninstall";
            this.Uninstall.ReadOnly = true;
            this.Uninstall.Text = "Uninstall";
            this.Uninstall.UseColumnTextForButtonValue = true;
            this.Uninstall.Width = 80;
            // 
            // ForceStop
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            this.ForceStop.DefaultCellStyle = dataGridViewCellStyle3;
            this.ForceStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForceStop.HeaderText = "Force Stop";
            this.ForceStop.Name = "ForceStop";
            this.ForceStop.ReadOnly = true;
            this.ForceStop.Text = "Force Stop";
            this.ForceStop.UseColumnTextForButtonValue = true;
            this.ForceStop.Width = 80;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ctBreakLine1);
            this.panel3.Controls.Add(this.txtSearchPackage);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel3.Size = new System.Drawing.Size(464, 35);
            this.panel3.TabIndex = 17;
            // 
            // txtSearchPackage
            // 
            this.txtSearchPackage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearchPackage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearchPackage.BorderColor = System.Drawing.Color.White;
            this.txtSearchPackage.DataFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPackage.DataText = "";
            this.txtSearchPackage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearchPackage.IsPasswordTextBox = false;
            this.txtSearchPackage.Location = new System.Drawing.Point(0, 0);
            this.txtSearchPackage.Name = "txtSearchPackage";
            this.txtSearchPackage.Size = new System.Drawing.Size(464, 32);
            this.txtSearchPackage.TabIndex = 3;
            this.txtSearchPackage.TextHint = "Enter Package Name: ";
            this.txtSearchPackage.TextHintColor = System.Drawing.SystemColors.ControlText;
            this.txtSearchPackage.TextHintWidth = 0;
            this.txtSearchPackage.EventTextChange += new System.EventHandler(this.txtSearchPackage_EventTextChange);
            // 
            // ctBreakLine1
            // 
            this.ctBreakLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.BreakLineHeight = 1;
            this.ctBreakLine1.BreakLinneColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ctBreakLine1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctBreakLine1.Location = new System.Drawing.Point(0, 35);
            this.ctBreakLine1.Name = "ctBreakLine1";
            this.ctBreakLine1.Size = new System.Drawing.Size(464, 1);
            this.ctBreakLine1.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctPackageMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel3);
            this.Name = "ctPackageMgr";
            this.Size = new System.Drawing.Size(464, 270);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewButtonColumn ClearData;
        private System.Windows.Forms.DataGridViewButtonColumn SaveTo;
        private System.Windows.Forms.DataGridViewButtonColumn Uninstall;
        private System.Windows.Forms.DataGridViewButtonColumn ForceStop;
        private MLLib.Controls.ctTextBox txtSearchPackage;
        private MLLib.Controls.ctBreakLine ctBreakLine1;
    }
}
