using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Managed.Adb;
using System.Diagnostics;
using System.Management;
using System.Threading;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctListOfDevice : UserControl
    {

        SyncService syncService = null;

        private void ChangeService(Device device)
        {

            try
            {

                try
                {
                    if (syncService != null)
                    {
                        if (syncService.Device == device)
                            return;
                        if (syncService.IsOpen)
                            syncService.Close();
                    }
                }
                catch (Exception)
                {
                }
                if (device != null)
                    syncService = new SyncService(device);
                else
                    syncService = null;
            }
            catch (Exception)
            {

            }
        }
        public SyncService SyncServiceInstant
        {
            get
            {
                try
                {
                    if (syncService != null && !syncService.IsOpen)
                    {
                        syncService.Open();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
                return syncService;
            }
        }

        bool multipleSelect = false;
        public bool MultipleSelect
        {
            get
            {
                return multipleSelect;
            }
            set
            {
                multipleSelect = value;
                if (value)
                {
                    currentDevice = null;
                    ListDeviceSelected.Clear();
                }
            }
        }
        public List<Device> ListDeviceSelected;

        public ctListOfDevice()
        {
            InitializeComponent();
            listdevice = new List<Device>();
            ListDeviceSelected = new List<Device>();
        }
        List<Device> listdevice;
        Device currentDevice = null;

        


        public Device CurrentDevice
        {
            get
            {
                return this.currentDevice;
            }
        }

        public void LoadDevice(bool load)
        {
            if (load && !timer1.Enabled)
            {
                timer1_Tick(null, null);
                timer1.Start();
            }

            if (!load && timer1.Enabled)
            {
                timer1.Stop();
            }

        }


        public event EventHandler ChangeDevice;
        public event InsertLogDelegate OutputLog;

        public void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (AdbHelper.Instance != null)
                {

                    List<Device> devices = AdbHelper.Instance.GetDevices(AndroidDebugBridge.SocketAddress);
                    if (devices.Count == 0)
                    {
                        if (!multipleSelect)
                        {
                            ChangeService(null);

                            if (currentDevice != null)
                            {
                                currentDevice = null;
                                if (ChangeDevice != null)
                                    ChangeDevice(null, null);
                            }
                        }
                        ListDeviceSelected.Clear();
                    }

                    if (!CompareDevice(devices, listdevice))
                    {
                        BindToPanel(devices);
                        listdevice = devices;
                    }
                    System.GC.Collect();
                }
            }
            catch (Exception e1)
            {
                ClearDevice();
                if (OutputLog != null)
                    OutputLog(e1.Message, UtilLog.LogType.Error);
            }
        }
        private void ClearDevice()
        {
            try
            {
                ChangeService(null);
                listdevice.Clear();
                pnDevice.Controls.Clear();
                if (currentDevice != null)
                {
                    currentDevice = null;
                    if (ChangeDevice != null)
                        ChangeDevice(null, null);
                }
            }
            catch (Exception e1)
            {
                if (OutputLog != null)
                    OutputLog(e1.Message, UtilLog.LogType.Error);
            }
        }
        bool CompareDevice(Device a, Device b)
        {
            try
            {
                if (a.SerialNumber != b.SerialNumber || a.IsOnline != b.IsOnline)
                    return false;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        bool CompareDevice(List<Device> a, List<Device> b)
        {
            try
            {
                if (a.Count != b.Count)
                    return false;
                a = a.OrderBy(x => x.SerialNumber).ToList();
                b = b.OrderBy(x => x.SerialNumber).ToList();
                for (int i = 0; i < a.Count; i++)
                {
                    if (!CompareDevice(a[i], b[i]))
                        return false;
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void BindToPanel(List<Device> devices)
        {
            pnDevice.Controls.Clear();

            if (!multipleSelect)
            {
                if (currentDevice == null)
                {
                    if (devices.Count != 0)
                    {
                        currentDevice = devices.First();
                        ChangeService(currentDevice);
                        if (ChangeDevice != null)
                            ChangeDevice(null, null);
                    }
                }
                else
                {
                    if (devices.SingleOrDefault(x => x.SerialNumber == currentDevice.SerialNumber) == null)
                    {
                        if (devices.Count > 0)
                            currentDevice = devices.First();
                        else
                            currentDevice = null;
                        ChangeService(currentDevice);
                        if (ChangeDevice != null)
                            ChangeDevice(null, null);

                    }
                }
            }
            var temp = devices.Select(x => x.SerialNumber);
            for (int i = 0; i < ListDeviceSelected.Count; i++)
            {
                if (!temp.Contains(ListDeviceSelected[i].SerialNumber))
                {
                    ListDeviceSelected.RemoveAt(i);
                    i--;
                }
            }
            temp = ListDeviceSelected.Select(x => x.SerialNumber);

            foreach (var item in devices)
            {
                ctDevice dv = null;
                if (!multipleSelect)
                {
                    dv = new ctDevice(item, item.SerialNumber == currentDevice.SerialNumber);
                }
                else
                {
                    dv = new ctDevice(item, temp.Contains(item.SerialNumber));
                }
                dv.DeviceClick += dv_DeviceClick;
                dv.Dock = DockStyle.Top;
                pnDevice.Controls.Add(dv);
            }
        }


        object obj = new object();
        void dv_DeviceClick(object sender, EventArgs e)
        {
            lock (obj)
            {
                if (!multipleSelect)
                {
                    ctDevice dv = sender as ctDevice;
                    if (dv.selected)
                        return;
                    foreach (ctDevice item in pnDevice.Controls)
                    {
                        if (item.selected)
                        {
                            item.SetSelected(false);
                            break;
                        }
                    }
                    dv.SetSelected(true);
                    currentDevice = dv.currentDevice;

                    ChangeService(currentDevice);
                    if (ChangeDevice != null)
                        ChangeDevice(null, null);
                }
                else
                {
                    ctDevice dv = sender as ctDevice;
                    dv.SetSelected(!dv.selected);

                    var listselected = ListDeviceSelected.Select(x => x.SerialNumber);

                    var temp = ListDeviceSelected.SingleOrDefault(x => x.SerialNumber == dv.currentDevice.SerialNumber);
                    if (temp != null && !dv.selected)
                        ListDeviceSelected.Remove(temp);
                    if (temp == null && dv.selected)
                        ListDeviceSelected.Add(dv.currentDevice);
                }
            }
        }

        private void chbAutoReload_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAutoReload.Checked)
                LoadDevice(true);
            else
                LoadDevice(false);
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
        }

    }
}
