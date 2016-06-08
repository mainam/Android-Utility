using Microsoft.Win32;
using MLLib.MLApplication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLLib.Windows
{
    public class Registry
    {
        public static void WriteKey(string name, object value)
        {
            Config.ThrowAppNull();
            RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE", true);
            if (Key.GetValue(Config.APPNAME) == null)
                Key.CreateSubKey(Config.APPNAME);
            Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Config.APPNAME, true);
            Key.SetValue(name, value);
        }
        public static void RemoveKey(string name)
        {
            Config.ThrowAppNull();
            RegistryKey Key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Config.APPNAME, true);
            try
            {
                Key.DeleteSubKey(name, false);
            }
            catch (Exception)
            {
            }
        }
        public static string ReadKey(string name)
        {
            Config.ThrowAppNull();
            RegistryKey GetKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\" + Config.APPNAME, true);
            try
            {
                return GetKey.GetValue(name).ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
