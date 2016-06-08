using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Android_Utility.Utils;

namespace Android_Utility
{
    public partial class ctFillData : UserControl
    {
        public ctFillData()
        {
            InitializeComponent();
        }

        public void SelectTab()
        {
            tabFillData.SelectedIndex = 0;
            tabSelectTypeFill_SelectedIndexChanged(null, null);
        }

        public UtilEvent utilEvent;
        private ctListOfDevice listofdevice;
        public ctListOfDevice ListOfDevice
        {
            get
            {
                return listofdevice;
            }
            set
            {
                listofdevice = value;
            }
        }


        private void tabSelectTypeFill_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabFillData.SelectedTab == tpFillFullMemory)
            {
                if (tpFillFullMemory.Controls.Count == 0)
                {
                    ctFillFullMemory fullmem = new ctFillFullMemory();
                    fullmem.Dock = DockStyle.Fill;
                    fullmem.utilEvent = utilEvent;
                    fullmem.ListOfDevice = listofdevice;
                    tpFillFullMemory.Controls.Add(fullmem);
                }
                return;
            }
            if (tabFillData.SelectedTab == tpFillFileMedia)
            {
                if (tpFillFileMedia.Controls.Count == 0)
                {
                    ctFillFileMedia fillmem = new ctFillFileMedia();
                    fillmem.Dock = DockStyle.Fill;
                    fillmem.utilEvent = utilEvent;
                    fillmem.ListOfDevice = listofdevice;
                    fillmem.Dock = DockStyle.Fill;
                    tpFillFileMedia.Controls.Add(fillmem);
                }
                return;
            }

            if (tabFillData.SelectedTab == tpFillContactCallLogSMS)
            {
                if (tpFillContactCallLogSMS.Controls.Count == 0)
                {
                    ctFillContactCallLog fillcontact = new ctFillContactCallLog();
                    fillcontact.Dock = DockStyle.Fill;
                    fillcontact.utilEvent = utilEvent;
                    fillcontact.ListOfDevice = listofdevice;
                    fillcontact.Dock = DockStyle.Fill;
                    tpFillContactCallLogSMS.Controls.Add(fillcontact);
                }
                return;
            }
        }
    }
}
