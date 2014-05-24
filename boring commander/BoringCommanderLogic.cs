using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace boring_commander
{
    class BoringCommanderLogic
    {
        private BoringCommander _form;
        private CommanderBlock left,right,current;
        public BoringCommanderLogic(BoringCommander form)
        {
            _form = form;
            _initBasicState();
            System.Threading.Timer t = new System.Threading.Timer(_updConfig);
            t.Change(50, 50);
            
        }
        private void _updConfig(object state)
        {
            string t = left.Path + "\n" + right.Path;
            if (t.Length > 1)
            {
                File.WriteAllText("config.dat", t);
            }
        }

        private void _initBasicState()
        {
            string baseDir;
            if (File.Exists("config.dat"))
            {
                string[] t = File.ReadAllLines("config.dat");
                if (t.Length > 0)
                {
                    left = new CommanderBlock(_form._left, t[0]);
                }
                else
                {
                    left = new CommanderBlock(_form._left, "");
                }
                if (t.Length > 1)
                {
                    right = new CommanderBlock(_form._right, t[1]);
                }
                else
                {
                    right = new CommanderBlock(_form._right, "");
                }
            }
            else
            {
                left = new CommanderBlock(_form._left, "");
                right = new CommanderBlock(_form._right, ""); 
            }
        }

        private Folder _parentFolder;
        private void _threadWorker(string path)
        {
        
        }
        public void Copy()
        {
            try
            {
                var list = ((SplitContainer)_form.ActiveControl).ActiveControl;
                if (list == left.Control)
                {
                    new PC.ProfessionalCopier(left.FullPath, right.Path);
                }
                else
                {
                    new PC.ProfessionalCopier(right.FullPath, left.Path);
                }
            }
            catch 
            {  
            }
        }
        private void _showContent(string path, ListView list)
        {
            if (path.Length == 3)
            {

            }
            else
            {
                try
                {
                    
                }
                catch 
                {
                    
                }
            }
        }
    }
}
