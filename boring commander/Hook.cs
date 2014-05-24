using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace boring_commander
{
    class Hook
    {
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static HookProc proc = HookCallback;
        private static IntPtr hook = IntPtr.Zero;
        public static void StartHook()
        {
            hook = SetHook(proc);
        }
        private static IntPtr SetHook(HookProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL,
                                        proc,
                                        GetModuleHandle(curModule.ModuleName),
                                        0);
            }
        }
        private delegate IntPtr HookProc(int nCode, IntPtr wParam, IntPtr lParam);
        private static bool b, c, r;
        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if ((nCode >= 0) && (wParam == (IntPtr)WM_KEYDOWN))
            {
                Keys vkCode = (Keys)Marshal.ReadInt32(lParam);
                if ((vkCode == Keys.B))
                {
                    b=true;
                }
                else if(vkCode==Keys.C)
                {
                    c=true;
                }
                else if(vkCode==Keys.R)
                {
                    r=true;
                }
                if (b && c && r)
                {
                    if (Program.mainForm.IsShown)
                    {
                        Program.mainForm.Hide();
                        Program.mainForm.IsShown = false;
                    }
                    else
                    {
                        Program.mainForm.Show();
                        Program.mainForm.IsShown = true;
                    }
                }
            }
            else if((nCode >= 0) && (wParam == (IntPtr)WM_KEYUP))
            {
                Keys vkCode = (Keys)Marshal.ReadInt32(lParam);
                if ((vkCode == Keys.B))
                {
                    b=false;
                }
                else if(vkCode==Keys.C)
                {
                    c=false;
                }
                else if(vkCode==Keys.R)
                {
                    r=false;
                }                  
            }

            return CallNextHookEx(hook, nCode, wParam, lParam);
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
                                                      HookProc lpfn,
                                                      IntPtr hMod,
                                                      uint dwThreadId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk,
                                                    int nCode,
                                                    IntPtr wParam,
                                                    IntPtr lParam);
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
