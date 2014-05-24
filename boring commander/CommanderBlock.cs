using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace boring_commander
{
    class CommanderBlock
    {
        ListView _control;
        private string _currentPath;
        private Folder _currentFolder;
        private bool _isLogicalDrivesPage;
        private Dictionary<string, Folder> _children;
        private Folder _parent;
        public ListView Control { get { return _control;} }
        public string FullPath
        {
            get
            {
                try
                {
                    return _currentFolder.NameAt(_control.SelectedIndices[0]);
                }
                catch
                {
                    return "";
                }
            }
        }
        public string Path
        {
            get
            {
                try
                {
                    return _currentPath;
                }
                catch
                {
                    return "";
                }
            }

        }
        public CommanderBlock(ListView list, string path)
        {
            _control = list;
            _currentPath = path;
            if (_currentPath.Length == 0)
            {
                _isLogicalDrivesPage = true;
                _showLogicalDrives();
            }
            else
            {
                _openFolder();
            }
            list.Click += new EventHandler(list_Click);
            list.KeyDown += new KeyEventHandler(list_KeyDown);
        }

        void list_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _openFolderHelper();
            }
            else if(e.KeyCode == Keys.Back)
            {
                _upperLevel();
            }
        }
        void _upperLevel()
        {
            if (_parent == null || (_parent.DirPath==_currentPath))
            {
                _showLogicalDrives();
                return;
            }
            else
            {
                _currentPath = _parent.DirPath;
                _currentFolder = _parent;
                _children.Clear();
                ThreadPool.QueueUserWorkItem(_loadChildren, _currentPath);
            }
            _show();
        }
        void list_Click(object sender, EventArgs e)
        {
            _openFolderHelper();
        }
        private void _openFolderHelper()
        {
            if (_control.SelectedItems.Count > 0)
            {
                if (!_isLogicalDrivesPage)
                {
                    if (_currentFolder.IsFile(_control.SelectedItems[0].Index))
                    {
                        try
                        {
                            System.Diagnostics.Process.Start(_currentFolder.FileAt(_control.SelectedItems[0].Index));
                        }
                        catch { }
                    }
                    else
                    {
                        string futurePath = _currentFolder.FolderAt(_control.SelectedItems[0].Index);
                        try
                        {
                            var t = _children[futurePath];
                            _currentPath = futurePath;
                            _parent = _currentFolder;
                            _openFolder();
                        }
                        catch 
                        {
                            MessageBox.Show("Access denied!");
                        }
                        
                    }
                }
                else
                {
                    _currentPath = _control.SelectedItems[0].Text;
                    _parent = null;
                    
                    _openFolder();
                    _isLogicalDrivesPage = false;
                }                
                GC.Collect();
            }
        }
        private void _openFolder()
        {
            if (_children == null)
            {
                _currentFolder = Folder.Load(_currentPath);
            }
            else
            {
                try
                {
                    _currentFolder = _children[_currentPath];
                }
                catch(KeyNotFoundException)
                {
                    //MessageBox.Show("Access denied!");
                }

            }
            if(_children!=null)
                _children.Clear();
            ThreadPool.QueueUserWorkItem(_loadChildren, _currentPath);
            _show();
        }
        private void _addToHistory()
        {
            try
            {
                StreamWriter sr;
                FileInfo fi = new FileInfo("history.info");
                sr = fi.AppendText();
                sr.WriteLine(DateTime.Now.ToBinary().ToString() + " " + _currentFolder.DirPath);
                sr.Flush();
                sr.Close();
                sr.Dispose();
            }
            catch { }
        }
        private void _show()
        {
            _addToHistory();
            if (_currentFolder != null)
            {
                _control.Items.Clear();
                _currentFolder.AddOnListView(_control);
            }
        }
        private bool _areChildrenLoaded = false;
        private void _loadChildren(Object s)
        {
            if(_children!=null)
                _children.Clear();
            _areChildrenLoaded = false ;
            DirectoryInfo cur = new DirectoryInfo((string)s);
            Folder t;
            if (_children == null)
                _children = new Dictionary<string, Folder>();
            DirectoryInfo[] childDirs;
            try
            {
                childDirs = cur.GetDirectories();
            }
            catch 
            {
                _children.Clear();
                return;
            }
            foreach (DirectoryInfo dir in childDirs)
            {
                try
                {
                    t = new Folder();
                    t.Dirs = dir.GetDirectories();
                    t.Files = dir.GetFiles();
                    t.DirPath = dir.FullName;
                    lock (_children)
                    {
                        _children.Add(dir.FullName, t);
                    }
                }
                catch { }
            }
            _areChildrenLoaded = true;
        }
        private void _showLogicalDrives()
        {
            string[] ld = Directory.GetLogicalDrives();
            ListViewItem lvi;
            Folder t;
            DirectoryInfo di;
            _children = new Dictionary<string, Folder>();
            _control.Items.Clear();
            _isLogicalDrivesPage = true;
            foreach (string drive in ld)
            {
                try
                {
                    lvi = new ListViewItem(drive);
                    lvi.SubItems.Add("<drive>");
                    lvi.SubItems.Add("");
                    _control.Items.Add(lvi);
                    di = new DirectoryInfo(drive);
                    t = new Folder();
                    t.Dirs = di.GetDirectories();
                    t.Files = di.GetFiles();
                    t.DirPath = drive;
                    _children.Add(drive, t);
                }
                catch { }
            }
            _areChildrenLoaded = true;
        }
    }
}
