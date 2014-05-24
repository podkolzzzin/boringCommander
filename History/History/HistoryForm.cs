using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace History
{
    public static class Starter
    {
        public static void Start()
        {
            new HistoryForm().Show() ;
        }
    }
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            string[] lines=File.ReadAllLines("history.info");
            MShow(lines);
        }
        public void MShow(string[] t)
        {
            string tArr;
            foreach (string line in t)
            {
                tArr = line.Substring(0,line.IndexOf(' '));
                ListViewItem lvi=new ListViewItem(DateTime.FromBinary(Convert.ToInt64(tArr)).ToString());
                lvi.SubItems.Add(line.Substring(tArr.Length + 1));
                this.listView1.Items.Add(lvi);
            }
        }
    }
}
