using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android_Utility.Utils
{
    public class UtilMemory
    {
        public static void ClearMemory()
        {
            try
            {
                //System.GC.Collect();
            }
            catch (Exception)
            {
            }
        }
    }
}
