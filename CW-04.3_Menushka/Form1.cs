using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_04._3_Menushka
{
    public partial class Form1 : Form
    {
        private int count = 1;
        public Form1()
        {
            InitializeComponent();
            CreateMenuStrip();
        }
        private void CreateMenuStrip()
        {
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem tsmi = new ToolStripMenuItem(count++.ToString());
            tsmi.MouseHover += CreateToolMenuStrip;
            ms.Items.Add(tsmi);
            this.Controls.Add(ms);
        }
        private void CreateToolMenuStrip(object sender, EventArgs e)
        {
            if ((sender as ToolStripMenuItem).DropDownItems.Count == 0)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem(count++.ToString());
                tsmi.MouseHover += CreateToolMenuStrip;
                (sender as ToolStripMenuItem).DropDownItems.Add(tsmi);
            }
        }

    }
}
