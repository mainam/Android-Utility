using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Android_Utility.App
{
    public class Config
    {
        public void SetConfig()
        {
            try
            {
                MLLib.MLApplication.Config.APPNAME = "Android_Utility";
                MLLib.Windows.Registry.WriteKey("ExecutablePath", Application.ExecutablePath);
                MLLib.Windows.FileAssociation.Associate(".apk", "Android.Utility", "Open this apk with android utility app", "C:/ico/Android.ico", Application.ExecutablePath);
                MLLib.Windows.Protocol.SetProtocol("android", "Open android utility appliction", "C:/Android.ico", Application.ExecutablePath);

                var data = MLLib.Windows.Environment.GetEnviroment("Path");
                if (data != null)
                {
                    data = data.ToLower();
                    if (!data.Contains("c:\\adb\\"))
                    {
                        data += ";c:\\adb\\;";
                        MLLib.Windows.Environment.SetEnviroment("Path", data);
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
