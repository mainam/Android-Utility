using Microsoft.Win32;
using MLLib.MLApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MLLib.Windows
{
    public class Autorun
    {
        public static bool isAutorun
        {
            get
            {
                Config.ThrowAppNull();
                RegistryKey rkApp = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                return (rkApp.GetValue(MLApplication.Config.APPNAME).ToString() == Application.ExecutablePath);
            }
        }

        public static bool SetAutorun(bool autorun)
        {
            Config.ThrowAppNull();
            try
            {
                RegistryKey rkApp = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (autorun)
                {
                    rkApp.SetValue(Config.APPNAME, Application.ExecutablePath);
                    return isAutorun;
                }
                else
                {
                    rkApp.SetValue(Config.APPNAME, "");
                    return !isAutorun;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
