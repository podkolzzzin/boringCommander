using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace boring_commander
{
    public partial class BoringCommander : Form
    {
        BoringCommanderLogic commander;
        public bool IsShown = true;
        public BoringCommander()
        {
            InitializeComponent();
            _nameHeaderL.Width = 250;
            _nameHeaderR.Width = 250;
            _extensionHeaderL.Width = 80;
            _extensionHeaderR.Width = 80;
            commander=new BoringCommanderLogic(this);
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            commander.Copy();
        }

        private void показатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppDomain Domain = AppDomain.CreateDomain("Demo Domain");
           
            //загружаем в созданный нами домен приложения заранее подготовленную dll библиотеку
            Assembly asm = Domain.Load(AssemblyName.GetAssemblyName("History.dll"));
            //получаем модуль, из которого будем осуществлять вызов
            Module module = asm.GetModule("History.dll");
            Type type = module.GetType("History.Starter");
            MethodInfo method = type.GetMethod("Start");
            method.Invoke(null, null);
        }

        private void отобразитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText("history.info", "");
        }

    }
}
