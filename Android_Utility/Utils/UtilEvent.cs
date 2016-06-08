using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Android_Utility.Utils
{
    public delegate void InsertLogDelegate(object log, UtilLog.LogType type);
    public delegate void UpdateStatusOneItemDelegate(string status);
    public delegate void UpdateStatusManyItemDelegate(int item, string status);
    public delegate void ShowMessageDelegate(string message);
    public delegate void ShowProcessOneItemDelegate();
    public delegate void CloseProcessOneItemDelegate();
    public delegate void ShowProcessManyItemDelegate(int max, int rerun, EventHandler cancel);
    public delegate void CloseProcessManyItemDelegate();
    public delegate void ClearMemDelegate();
    public delegate void AbortThreadDelegate(Thread thear, InsertLogDelegate InsertLog);

    public class UtilEvent
    {
        public UpdateStatusOneItemDelegate UpdateStatusOneItem;
        public UpdateStatusManyItemDelegate UpdateStatusManyItem;
        public InsertLogDelegate InsertLog;
        public ShowProcessOneItemDelegate ShowProcessOneItem;
        public CloseProcessOneItemDelegate CloseProcessOneItem;
        public ShowProcessManyItemDelegate ShowProcessManyItem;
        public CloseProcessManyItemDelegate CloseProcessManyItem;
        public ShowMessageDelegate ShowMessage;
        public ClearMemDelegate ClearMem;
        public AbortThreadDelegate AbortThread;
        public UtilEvent(UpdateStatusOneItemDelegate UpdateStatusOneItem,
            InsertLogDelegate InsertLog,
            ShowProcessOneItemDelegate ShowProcessOneItem,
            CloseProcessOneItemDelegate CloseProcessOneItem,
            ShowProcessManyItemDelegate ShowProcessManyItem,
            CloseProcessManyItemDelegate CloseProcessManyItem,
            ShowMessageDelegate ShowMessage,
            ClearMemDelegate ClearMem,
            AbortThreadDelegate AbortThread,
            UpdateStatusManyItemDelegate UpdateStatusManyItem
            )
        {
            this.UpdateStatusOneItem = _UpdateStatusOneItem;
            this.UpdateStatusManyItem = _UpdateStatusManyItem;
            this.InsertLog = _InsertLog;
            this.ShowMessage = _ShowMessage;
            this.ShowProcessOneItem = _ShowProcessOneItem;
            this.CloseProcessOneItem = _CloseProcessOneItem;
            this.AbortThread = _AbortThread;
            this.ClearMem = _ClearMem;
            this.ShowProcessManyItem = _ShowProcessManyItem;
            this.CloseProcessManyItem = _CloseProcessManyItem;

            this.UpdateStatusOneItem += UpdateStatusOneItem;
            this.UpdateStatusManyItem += UpdateStatusManyItem;
            this.InsertLog += InsertLog;
            this.ShowMessage += ShowMessage;
            this.ShowProcessOneItem += ShowProcessOneItem;
            this.CloseProcessOneItem += CloseProcessOneItem;
            this.AbortThread += AbortThread;
            this.ClearMem += ClearMem;
            this.ShowProcessManyItem += ShowProcessManyItem;
            this.CloseProcessManyItem += CloseProcessManyItem;
        }

        private void _CloseProcessManyItem()
        {
        }

        private void _ShowProcessManyItem(int max, int rerun, EventHandler cancel)
        {
        }

        private void _ClearMem()
        {
        }

        private void _AbortThread(Thread thear, InsertLogDelegate InsertLog)
        {
        }

        private void _CloseProcessOneItem()
        {
        }

        private void _ShowProcessOneItem()
        {
        }

        private void _ShowMessage(string message)
        {
        }

        private void _InsertLog(object log, UtilLog.LogType type)
        {
        }

        private void _UpdateStatusManyItem(int item, string status)
        {
        }

        private void _UpdateStatusOneItem(string status)
        {
        }
    }
}
