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
    public partial class frmProgressManyItem : Form
    {
        public frmProgressManyItem()
        {
            InitializeComponent();
            this.BringToFront();
            this.StartPosition = FormStartPosition.CenterParent;
        }
        public frmProgressManyItem(int max, int rerun)
        {
            InitializeComponent();
            ctProcessStyle11.SetValue2(max, rerun);
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
        public void SetValue(int max, int rerun)
        {
            ctProcessStyle11.SetValue(max, rerun);
        }
        public void Update(int percent, string status)
        {
            ctProcessStyle11.UpdateValue(percent, status);
        }

        private void frmProgressManyItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close == false)
                e.Cancel = true;
        }

        public event EventHandler Cancel;
        private void ctProcessStyle11_CancelButtonClick(object sender, EventArgs e)
        {
            if (Cancel != null)
                Cancel(this, e);
            close = true;
            this.Close();
        }
    }
}
