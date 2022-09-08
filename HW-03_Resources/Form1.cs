using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW_03_Resources
{
    public partial class Form1 : Form
    {
        Image[] arr = { Properties.Resources._0, Properties.Resources._1, Properties.Resources._2, Properties.Resources._3, Properties.Resources._4 };
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            PictureFunc();
        }
        private void PictureFunc()
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Image = arr[i];
        }
        private void nextImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = arr[++i];
            if (i == arr.Length - 1)
                i = -1;
        }
    }
}
