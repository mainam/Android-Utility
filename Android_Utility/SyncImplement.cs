using Managed.Adb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android_Utility
{
    class SyncImplement : ISyncProgressMonitor
    {


        public void Start(long totalWork)
        {
            
        }

        public void Stop()
        {
           
        }

        public bool IsCanceled
        {

            get { return false; }
        }

        public void StartSubTask(string source, string destination)
        {
       
        }

        public void Advance(long work)
        {
            
        }
    }
}
