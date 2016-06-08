using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MLLib.Controls
{
    public partial class ctProcessStyle1 : UserControl
    {
        public ctProcessStyle1()
        {
            InitializeComponent();
        }

        Form currentform = null;
        bool lockForm;

        public bool LockForm
        {
            get
            {
                return lockForm;
            }
            set
            {
                lockForm = value;
            }
        }

        [DefaultValue(0)]
        public Form CurrentForm
        {
            get
            {
                return currentform;
            }
            set
            {
                currentform = value;
                if (currentform != null)
                {
                    currentform.FormBorderStyle = FormBorderStyle.None;
                    currentform.Opacity = 90;

                }
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        public void PreExecute()
        {

        }

        public void EndExecute()
        {

        }

        public void SetValue2(int max, int rerun)
        {
            progressBar1.Maximum = max;
            lbStatus.Text = "0 / " + max;
            if (rerun != 0)
            {
                lbRerun.Text = "Rerun: " + rerun;
            }
            else
            {
                lbRerun.Text = "";
            }
        }
        public void SetValue(int max, int rerun)
        {
            this.Invoke(new EventHandler(delegate
            {
                progressBar1.Maximum = max;
                lbStatus.Text = "0 / " + max;
                if (rerun != 0)
                {
                    lbRerun.Text = "Rerun: " + rerun;
                }
                else
                {
                    lbRerun.Text = "";
                }
            }));
        }

        public void UpdateValue(int newValue, string status)
        {
            this.Invoke(new EventHandler(delegate
            {
                try
                {
                    if (newValue > progressBar1.Maximum)
                    {
                        progressBar1.Value = progressBar1.Maximum;
                    }
                    else
                        progressBar1.Value = newValue;
                    lbStatus.Text = string.Format("{0} / {1}", progressBar1.Value, progressBar1.Maximum);
                    label1.Text = status;
                }
                catch (Exception)
                {

                }
            }));
        }
        public void UpdateValue(int newValue)
        {
            this.Invoke(new EventHandler(delegate
            {
                if (newValue > progressBar1.Maximum)
                {
                    progressBar1.Value = progressBar1.Maximum;
                }
                else
                    progressBar1.Value = newValue;
                lbStatus.Text = string.Format("{0} / {1}", progressBar1.Value, progressBar1.Maximum);
            }));
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (currentform != null)
                {
                    ReleaseCapture();
                    SendMessage(currentform.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        public event EventHandler CancelButtonClick;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (CancelButtonClick != null)
                CancelButtonClick(sender, e);
        }

        private void ctProcessStyle1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            //this.MaximumSize = this.MinimumSize = this.Size = new Size(354, 95);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
