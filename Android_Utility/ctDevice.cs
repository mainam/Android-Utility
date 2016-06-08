using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Managed.Adb;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctDevice : UserControl
    {
        public Device currentDevice;
        public bool selected = false;
        UtilEvent utilEvent;
        public ctDevice(Device device, bool selected)
        {
            InitializeComponent();
            this.currentDevice = device;
            BindDevice(device);
            this.selected = selected;
            SetSelected(selected);
        }

        public void SetSelected(bool selected)
        {
            if (selected)
            {
                txtSerial.BackColor = txtOnline.BackColor = Color.LightGreen;
            }
            else
            {
                txtSerial.BackColor = txtOnline.BackColor = System.Drawing.SystemColors.Control;
            }
            this.selected = selected;
        }

        public event EventHandler DeviceClick;

        private void BindDevice(Device device)
        {
            txtSerial.Text = device.SerialNumber;
            txtOnline.Text = device.IsOnline + "";
        }

        private void ctDevice_Click(object sender, EventArgs e)
        {
            if (DeviceClick != null)
                DeviceClick(sender, e);
        }

        private void ctDevice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control)
            {
                try
                {
                    Clipboard.SetText(txtSerial.Text);
                    utilEvent.InsertLog("Serial Number of this device has been added to clipboard", UtilLog.LogType.Success);
                }
                catch (Exception e1)
                {
                    utilEvent.InsertLog(e1.Message, UtilLog.LogType.Error);
                }
            }

        }

    }
}
