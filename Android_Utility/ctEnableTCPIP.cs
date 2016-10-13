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
    public partial class ctEnableTCPIP : UserControl
    {
        private UtilEvent utilEvent;

        public ctEnableTCPIP(UtilEvent utilEvent)
        {
            InitializeComponent();
            this.utilEvent = utilEvent;
        }

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
    }
}
