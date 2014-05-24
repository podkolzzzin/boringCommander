using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace boring_commander
{
    class Folder
    {
        public DirectoryInfo[] Dirs;
        public FileInfo[] Files;
        public string DirPath;
        public static Folder Load(string path)
        {
            DirectoryInfo t = new DirectoryInfo(path);           
            return Folder.Load(t);
        }
        public static Folder Load(DirectoryInfo dir)
        {
            Folder f = new Folder();
            f.Dirs = dir.GetDirectories();
            f.Files = dir.GetFiles();
            f.DirPath = dir.FullName;
            return f;
        }
        public static string fileSizeStr(Int64 length)
        {
            if (length < 10240) return length.ToString() + " Byte";
            else if (length < 1024 * 1024 * 10) return (length / 1024).ToString() + " KB";
            else if (length < (Int64)1024 * 1024 * 1024 * 10) return (length / 1024 / 1024).ToString() + " MB";
            else if (length < (Int64)1024 * 1024 * 1024 * 1024 * 10) return (length / 1024 / 1024 / 1024).ToString() + " GB";
            else  return (length / 1024 / 1024 / 1024 / 1024).ToString() + " TB";
        }
        public void AddOnListView(ListView list)
        {
            ListViewItem lvi;
            foreach (DirectoryInfo dir in Dirs)
            {
                lvi = new ListViewItem(dir.Name);
                lvi.SubItems.Add("<dir>");
                lvi.SubItems.Add("");
                list.Items.Add(lvi);
            }
            foreach (FileInfo file in Files)
            {
                lvi = new ListViewItem(file.Name);
                if(file.Extension.Length>0)
                    lvi.SubItems.Add(file.Extension.Substring(1));
                
                lvi.SubItems.Add(Folder.fileSizeStr(file.Length));
                list.Items.Add(lvi);
            }
        }
        public bool IsFile(int index)
        {
            return index >= Dirs.Length;
        }
        public string FileAt(int index)
        {
            return Files[index - Dirs.Length].FullName;
        }
        public string FolderAt(int index)
        {
            return Dirs[index].FullName;
        }
        public string NameAt(int index)
        {
            if (index < Dirs.Length)
                return Dirs[index].FullName;
            else
                return Files[index-Dirs.Length].FullName;
        }
    }
}
