using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_02._2_TimerWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "0";
            timer1.Interval = 1;
        }
        private int i = 0;
        private DateTime dt;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i = (int)(DateTime.Now - dt).TotalMilliseconds;
            this.Text = i.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            timer1.Start();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
