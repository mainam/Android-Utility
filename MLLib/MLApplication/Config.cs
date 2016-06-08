using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MLLib.MLApplication
{
    public class Config
    {
        static string appname;
        public static string APPNAME
        {
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new Exception("Application name khong duoc null");
                appname = value.Trim();
            }
            get
            {
                return appname;
            }
        }
        public static void ThrowAppNull()
        {
            if (APPNAME == null)
                throw new Exception("Chua config application name");
        }
    }
}
