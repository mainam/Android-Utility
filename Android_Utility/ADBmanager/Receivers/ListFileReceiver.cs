using Managed.Adb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Android_Utility.ADBmanager.Receivers
{
    public enum FileType
    {
        FolderParent,
        Directory,
        Link,
        File
    }
    public class FileInfo
    {
        public string filename;
        public FileType type;
        public string filetype;
        public FileInfo()
        {
            filename = "";
            filetype = "";
            type = FileType.File;
        }
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}
        //public override bool Equals(object obj)
        //{
        //    try
        //    {
        //        if (!(obj is FileInfo))
        //            return false;
        //        var a = obj as FileInfo;
        //        return (a.filename == this.filename && a.filetype == this.filetype && a.type == this.type);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
            
        //}
    }
    public class ListFileReceiver : MultiLineReceiver
    {
        public ListFileReceiver()
        {
            listfile = new List<FileInfo>();
        }

        List<FileInfo> listfile;
        public List<FileInfo> ListFile
        {
            get
            {
                return listfile;
            }
        }
        protected override void ProcessNewLines(string[] lines)
        {
            listfile.Clear();
            foreach (var item in lines)
            {
                if (item == null)
                    continue;
                var fileinfo = new FileInfo();
                fileinfo.type = FileType.File;
                if (item.StartsWith("d"))
                {
                    fileinfo.type = FileType.Directory;
                    var regex = @"(.+\s+){5}(\d{2}:\d{2}\s*)([^$]+)";
                    if (item.IsMatch(regex))
                    {
                        fileinfo.filename = "";
                        var group = item.Match(regex).Groups;
                        for (int i = 3; i < group.Count; i++)
                            fileinfo.filename += group[i].Value;
                    }
                    else
                        fileinfo = null;
                }
                else
                {
                    if (item.StartsWith("l"))
                    {
                        fileinfo.type = FileType.Link;
                        var regex = @"(.+\s*){5}(\d{2}:\d{2}\s*)([^$]+)->\s+([^$]+)";
                        if (item.IsMatch(regex))
                        {
                            fileinfo.filename = "";
                            var group = item.Match(regex).Groups;
                            fileinfo.filename += group[3].Value;
                        }
                        else
                            fileinfo = null;
                    }
                    else
                    {
                        var regex = @"(.+\s+){5}(\d{2}:\d{2}\s*)([^$]+)";
                        if (item.IsMatch(regex))
                        {
                            fileinfo.filename = "";
                            var group = item.Match(regex).Groups;
                            for (int i = 3; i < group.Count; i++)
                                fileinfo.filename += group[i].Value;

                            var a = fileinfo.filename.Split('.');
                            if (a.Length >= 2)
                                fileinfo.filetype = a.Last();
                        }
                        else
                            fileinfo = null;
                    }
                }
                if (fileinfo != null)
                {
                    fileinfo.filename = fileinfo.filename.Trim();
                    listfile.Add(fileinfo);
                }
            }
        }
    }
}
