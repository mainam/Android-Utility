using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Android_Utility
{
    public class Constant
    {
        public static string QB_USERNAME = "QB_SETTING";
        public static string QB_PASSWORD = "QB_PASSWORD";
        public static string QB_AUTOLOGIN = "QB_AUTOLOGIN";
    }
    public class Utils
    {
        static String APPLICATION_NAME = "Android_Utility";
        public static void GhiKey(string name, object value)
        {
            RegistryKey TaoKey = Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            if (TaoKey.GetValue(APPLICATION_NAME) == null)
                TaoKey.CreateSubKey(APPLICATION_NAME);
            TaoKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + APPLICATION_NAME, true);
            TaoKey.SetValue(name, value);
        }
        public static void XoaKey(string name)
        {
            RegistryKey Key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + APPLICATION_NAME, true);
            try
            {
                Key.DeleteSubKey(name, false);
            }
            catch (Exception)
            {
            }
        }
        public static string DocKey(string name)
        {
            RegistryKey GetKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + APPLICATION_NAME, true);
            try
            {
                return GetKey.GetValue(name).ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void SetAutorun(bool autorun)
        {
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (autorun)
                rkApp.SetValue(APPLICATION_NAME, Application.ExecutablePath);
            else
                rkApp.SetValue(APPLICATION_NAME, "");
        }

        public static bool? GetAutorun()
        {
            try
            {
                RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                return (rkApp.GetValue(APPLICATION_NAME).ToString() == Application.ExecutablePath);
            }
            catch (Exception)
            {
                return null;
            }
        }



    }
}
