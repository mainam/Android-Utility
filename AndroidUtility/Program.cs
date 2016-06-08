using Android_Utility;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidUtility
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            try
            {
                Process.Start("file://107.113.53.35/common/5.USERS/ngoc.nam/PROJECT/ANDROID_UTILITY/Android%20Utility.application");
            }
            catch (Exception)
            {
                try
                {
                    var path = Utils.DocKey("ExecutablePath");
                    Process.Start(path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Error occur. Please contact ngoc.nam@samsung.com");
                }
            }
        }
    }
}
