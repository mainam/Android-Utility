using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Android_Utility.Utils
{
    public class UtilMessage
    {
        public static void ShowMessage(string status)
        {
            MessageBox.Show(status);
        }
    }
}
