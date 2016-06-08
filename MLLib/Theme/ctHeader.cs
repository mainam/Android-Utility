using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;

using System.Windows.Forms;
using System.Runtime.InteropServices;
using MLLib.Theme;

namespace MLLib
{
    public partial class ctHeader : UserControl
    {
        public ctHeader()
        {
            InitializeComponent();
        }

        public event EventHandler FormWindowStateChange;


        public Form _currentForm = new Form();
        bool pin = false;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void ctTitle_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Top;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private void pnTitle_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 1 && _currentForm != null && _currentForm.WindowState != FormWindowState.Maximized)
            {
                if (_currentForm != null)
                {
                    ReleaseCapture();
                    SendMessage(_currentForm.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        public bool Pin
        {
            get
            {
                if (this._currentForm != null)
                {
                    return pin = this._currentForm.TopMost;
                }
                return pin;
            }
            set
            {
                if (this._currentForm != null)
                {
                    this._currentForm.TopMost = pin = value;
                }
                else
                {
                    pin = value;
                }
                if (value)
                {
                    btnPin.Image = global::MLLib.Properties.Resources.btn_pin_o;
                    toolTip1.SetToolTip(btnPin, "unpin");
                }
                else
                {
                    btnPin.Image = global::MLLib.Properties.Resources.btn_no_pin_o;
                    toolTip1.SetToolTip(btnPin, "pin");
                }
            }

        }



        public string Title
        {
            get
            {
                return lbTitle.Text;
            }
            set
            {
                lbTitle.Text = value;
                lbTitle.Left = (this.Width - lbTitle.Width) / 2;
                lbTitle.Top = (pnLabelTitle.Height - lbTitle.Height) / 2;
            }
        }
        public Font TitleFont
        {
            get
            {
                return lbTitle.Font;
            }
            set
            {
                lbTitle.Font = value;
                lbTitle.Left = (this.Width - lbTitle.Width) / 2;
                lbTitle.Top = (pnLabelTitle.Height - lbTitle.Height) / 2;
            }
        }

        public Color TitleColor
        {
            get
            {
                return lbTitle.ForeColor;
            }
            set
            {
                lbTitle.ForeColor = value;
            }
        }
        public Color TitleBackground
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        [DefaultValue(0)]
        public Form CurrentForm
        {
            get { return _currentForm; }
            set
            {
                try
                {
                    _currentForm = value;
                    _currentForm.ControlBox = false;
                    _currentForm.Text = "";
                    _currentForm.FormBorderStyle = FormBorderStyle.None;
                    _currentForm.SizeChanged += _currentForm_SizeChanged;
                    _currentForm.StartPosition = FormStartPosition.CenterScreen;
                    Pin = _currentForm.TopMost;
                }
                catch (Exception)
                {

                }

            }
        }

        void _currentForm_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                //if (!btnMinimize.Visible)
                //{
                //    if (FormWindowState.Minimized == _currentForm.WindowState)
                //        _currentForm.WindowState = FormWindowState.Normal;
                //}
                //if (!btnMaximize.Visible)
                //{
                //    if (FormWindowState.Maximized == _currentForm.WindowState)
                //        _currentForm.WindowState = FormWindowState.Normal;
                //}

                if (_currentForm.WindowState == FormWindowState.Maximized)
                {
                    if (btnMaximize.Image != global::MLLib.Properties.Resources.restore_d240)
                    {
                        btnMaximize.Image = global::MLLib.Properties.Resources.restore_d240;
                        toolTip1.SetToolTip(btnMaximize, "Restore Down");
                    }

                }
                else
                    if (_currentForm.WindowState == FormWindowState.Maximized)
                    {
                        if (btnMaximize.Image != global::MLLib.Properties.Resources.maximize_d240)
                        {
                            btnMaximize.Image = global::MLLib.Properties.Resources.maximize_d240;
                            toolTip1.SetToolTip(btnMaximize, "Maximize");
                        }

                    }
            }
            catch (Exception)
            {

            }
        }

        [DefaultValue(0)]
        public Image Icon
        {
            get { return ptBoxIcon.Image; }
            set
            {
                try
                {
                    ptBoxIcon.Image = value;
                }
                catch (Exception)
                {

                }

            }
        }

        public bool AllowMaximize
        {
            get
            {
                return pnMaximize.Visible;
            }
            set
            {
                pnMaximize.Visible = value;
            }
        }

        public bool AllowMinimize
        {
            get
            {
                return pnMinimize.Visible;
            }
            set
            {
                pnMinimize.Visible = value;
            }
        }

        public bool AllowClose
        {
            get
            {
                return pnClose.Visible;
            }
            set
            {
                pnClose.Visible = value;
            }
        }

        public String TooltipIcon
        {
            get
            {
                return toolTip1.GetToolTip(ptBoxIcon);
            }
            set
            {
                toolTip1.SetToolTip(ptBoxIcon, value);
            }
        }

        public event EventHandler IconClick;


        private void pnTitle_SizeChanged(object sender, EventArgs e)
        {
            try
            {

                if (_currentForm.WindowState != FormWindowState.Maximized && _currentForm.WindowState != FormWindowState.Minimized)
                {
                    SetMaximize(false);
                }
            }
            catch (Exception)
            {

            }
        }

        private void pnLabelTitle_SizeChanged(object sender, EventArgs e)
        {
            lbTitle.Left = (this.Width - lbTitle.Width) / 2;
            lbTitle.Top = (this.Height - lbTitle.Height) / 2;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                _currentForm.Close();
            }
            catch (Exception)
            {
            }
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            SetMaximize(toolTip1.GetToolTip(btnMaximize) == "Maximize");
        }

        private void pnLabelTitle_DoubleClick(object sender, EventArgs e)
        {
            SetMaximize(toolTip1.GetToolTip(btnMaximize) == "Maximize");
        }

        private void SetMaximize(bool Maximize)
        {
            try
            {
                if (Maximize)
                {
                    if (!pnMaximize.Visible)
                        return;
                    if (FormWindowStateChange != null)
                        FormWindowStateChange("Maximize", null);
                    _currentForm.WindowState = FormWindowState.Maximized;
                    btnMaximize.Image = global::MLLib.Properties.Resources.restore_d240;
                    toolTip1.SetToolTip(btnMaximize, "Restore Down");
                    //_currentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
                }
                else
                {
                    //_currentForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    _currentForm.WindowState = FormWindowState.Normal;
                    btnMaximize.Image = global::MLLib.Properties.Resources.maximize_d240;
                    toolTip1.SetToolTip(btnMaximize, "Maximize");
                    if (FormWindowStateChange != null)
                        FormWindowStateChange("Normal", null);
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                _currentForm.WindowState = FormWindowState.Minimized;
            }
            catch (Exception)
            {
            }
        }


        private void ptBoxIcon_SizeChanged(object sender, EventArgs e)
        {
            ptBoxIcon.Width = ptBoxIcon.Height;
        }

        private void ptBoxIcon_Click(object sender, EventArgs e)
        {
            if (IconClick != null)
            {
                IconClick(sender, e);
            }
        }

        private void btnMaximize_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            Pin = !Pin;
        }

        public void AddButton(ButtonTitle button)
        {
            if (button != null)
            {
                button.DoubleClick += new System.EventHandler(this.pnLabelTitle_DoubleClick);
                button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
                this.pnTitle.Controls.Add(button);
                button.BringToFront();
            }
        }
    }
}
