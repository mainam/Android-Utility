using MLLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Android_Utility
{
    public partial class frmFormInput : mlForm
    {
        public frmFormInput(string name)
        {
            InitializeComponent();
            AllowClose = false;
            AllowMaximize = false;
            AllowMinimize = false;
            ShowPinButton = false;
            HideHeader = false;
            HideFooter = true;
            this.ctTextBox1.Text = name;
        }
        public frmFormInput(string title, string name): this(name)
        {
            this.Text = title;
        }
        public string NewName
        {
            get
            {
                return ctTextBox1.Text;
            }
            set
            {
                this.ctTextBox1.Text = value;
            }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
            DialogResult = DialogResult.OK;
        }

        private void ctTextBox1_EventKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOK.PerformClick();
            }
        }

        private void frmRenameRemoteFile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                btnCancel.PerformClick();
            else
                if (e.KeyCode == Keys.Enter)
                btnOK.PerformClick();
        }

        private void frmFormInput_Load(object sender, EventArgs e)
        {
            ctTextBox1.Select();
            ctTextBox1.Select(0,0);
        }
    }
}
