using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Android_Utility.Utils
{
    public class UtilThread
    {
        public static void AbortThread(Thread thread, InsertLogDelegate InsertLog)
        {
            try
            {
                if (thread == null)
                    return;
                if (thread.ThreadState == System.Threading.ThreadState.Running)
                {
                    thread.Abort();
                }
                thread = null;
            }
            catch (Exception e)
            {
                if (InsertLog != null)
                    InsertLog(e.Message, UtilLog.LogType.Error);
            }
        }
    }
}
