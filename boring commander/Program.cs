using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using Microsoft.Win32;

namespace boring_commander
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]        
        static void Main()
        {
            bool a=true;
            Mutex m = new Mutex(true, "myMutexxxx", out a);
            if (!a) return;
            toAutoRun();
            Hook.StartHook();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new BoringCommander();
            Application.Run(mainForm);
            
        }
        public static BoringCommander mainForm;
        static void toAutoRun()
        {
            try
            {
                Microsoft.Win32.RegistryKey myKey =
                Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);
                myKey.SetValue("BoringCommander", Application.ExecutablePath);
            }
            catch
            {
                MessageBox.Show("No accesss to change registry");
            }
        }
    }
}
