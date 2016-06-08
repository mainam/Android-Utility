using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MLLib.Windows
{
    public class Protocol
    {
        public static void SetProtocol(string protocol,
              string description, string icon, string application)
        {
            using (RegistryKey key = Microsoft.Win32.Registry.ClassesRoot.CreateSubKey(protocol))
            {
                if (description != null)
                    key.SetValue("", description);
                if (description != null)
                    key.SetValue("URL Protocol", "");

                key.CreateSubKey("DefaultIcon").SetValue("", (icon != null) ? ToShortPathName(icon) : application != null ? application : "");
                if (application != null)
                    key.CreateSubKey(@"Shell\Open\Command").SetValue("",
                                ToShortPathName(application) + " \"%1\"");
            }
        }

        // Return true if protocol already setup in registry
        public static bool IsSetProtocol(string protocol)
        {
            return (Microsoft.Win32.Registry.ClassesRoot.OpenSubKey(protocol, false) != null);
        }

        [DllImport("Kernel32.dll")]
        private static extern uint GetShortPathName(string lpszLongPath,
            [Out] StringBuilder lpszShortPath, uint cchBuffer);

        // Return short path format of a file name
        private static string ToShortPathName(string longName)
        {
            StringBuilder s = new StringBuilder(1000);
            uint iSize = (uint)s.Capacity;
            uint iRet = GetShortPathName(longName, s, iSize);
            return s.ToString();
        }
    }

}
