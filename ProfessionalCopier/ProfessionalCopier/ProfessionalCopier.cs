using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;

namespace PC
{
    delegate void CopierCallback();
    public class CopyInfo
    {
        public Object dir;
        public string path;
        public CopyInfo(Object d,string path)
        {
            dir = d;
            this.path = path;
        }
    }
    public class ProfessionalCopier
    {
        private string _source;
        private string _dest;
        private int _counter;
        private CopyProgress _form;
        private double _progress = 0;
        private int copied;
        public ProfessionalCopier(string source, string dest)
        {
            _source = source;
            _dest = dest;
            if (File.Exists(source))
            {
                _form = new CopyProgress();
                _form.numFiles.Text += 0.ToString();
                _form.dest.Text += _dest;
                _form.source.Text += _source;
                _form.Show();
                ThreadPool.QueueUserWorkItem(_copyFileHelper, new CopyInfo(new FileInfo(source), dest ));
            }
            else
            {
                var t=new DirectoryInfo(source);
                _counter = _count(t);
                _form = new CopyProgress();
                _form.numFiles.Text += _counter.ToString();
                _form.dest.Text += _dest;
                _form.source.Text += _source;
                _form.Show();
                ThreadPool.QueueUserWorkItem(_copyDirHelper, new CopyInfo(t, dest + "\\" + t.Name));
            }
        }
        private int _count(DirectoryInfo dir)
        {
            int result = 0;
            DirectoryInfo[] dirs = dir.GetDirectories();
            foreach (DirectoryInfo item in dirs)
            {
                result += _count(item);
            }
            return result + dir.GetFiles().Length;
        }
        private void _directoryCallback()
        {
            copied++;
            _progress = (double)copied / _counter;
            if (copied == _counter)
            {
                _form.Hide();
                _form.Dispose();
            }
            _updProgress();
        }
        private void _fileCallback(object state)
        {
            try
            {
                FileInfo fSource = new FileInfo(_source);
                FileInfo fRez = new FileInfo(_dest + "\\" + fSource.Name);
                if (fSource.Length == fRez.Length)
                {
                    _form.Hide();
                    _form.Dispose();
                    fileTimer.Dispose();
                    return;
                }
                _progress = (double)fRez.Length / fSource.Length;
                _updProgress();
            }
            catch { }
        }
        private void _updProgress()
        {
            _form.progressBar1.Value = Convert.ToInt32(_progress * 100);
        }
        private string getOnlyName(string name)
        {
            int index = name.LastIndexOf('.');
            if (index != -1) return name.Substring(0, index);
            return name;
        }
        private bool copyFile(FileInfo file,string path)
        {
            bool success = false;
            string tPath;
            if (path.Length > 3)
                tPath = path + '\\' + file.Name;
            else
                tPath = path + file.Name;
            int tryIndex = 0;
            while (!success)
            {
                try
                {
                    file.CopyTo(tPath);
                    return true;
                }
                catch (IOException)
                {
                    tryIndex++;
                    if (path.Length > 3)
                        tPath = path + '\\';
                    else
                        tPath = path;
                    tPath += getOnlyName(file.Name) + '(' + tryIndex.ToString() + ')' + file.Extension;
                }
            }
            return false;
        }
        Timer fileTimer;
        private void copyFileAsync(FileInfo file, string path)
        {
            fileTimer = new Timer(_fileCallback);
            fileTimer.Change(50, 50);          
            copyFile(file, path);

        }
        private void _copyDirHelper(object arr)
        { 
            CopyInfo t=(CopyInfo)arr;
            copyDir((DirectoryInfo)t.dir, t.path);
        }
        private void _copyFileHelper(object arr)
        {
            CopyInfo t = (CopyInfo)arr;
            copyFileAsync((FileInfo)t.dir, t.path);
        }
        private void copyDir(DirectoryInfo dir, string path)
        {
            DirectoryInfo[] dirs = dir.GetDirectories();
            string tPath = path;
            if (path.Length > 3) tPath += "\\";
            for (int i = 0; i < dirs.Length; i++)
            {
                Directory.CreateDirectory(tPath + "\\" + dirs[i].Name);
                copyDir(dirs[i], tPath + "\\" + dirs[i].Name);
            }
            FileInfo[] files = dir.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                copyFile(files[i], path);
                _directoryCallback();
            }
        }
    }
}
