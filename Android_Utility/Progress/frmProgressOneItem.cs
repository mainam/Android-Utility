using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Android_Utility.Progress
{
    public partial class frmProgressOneItem : Form
    {
        public frmProgressOneItem()
        {
            InitializeComponent();
            this.BringToFront();
            this.StartPosition = FormStartPosition.CenterParent;

        }
        bool close = false;
        public bool showing = false;
        public void ShowProcess()
        {
            this.showing = true;
            this.ShowDialog();
        }
        public void CloseProcess()
        {
            showing = false;
            this.close = true;
            this.Close();
        }
        public void Update(string status)
        {
            ctProcessStyle21.Update(status);
        }

        private void frmProgessInstall_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
                e.Cancel = true;
        }

    }
}
