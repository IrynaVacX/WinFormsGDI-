using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int x, y, i = 1;
        Button newBut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            newBut.Width = e.X - newBut.Location.X;
            newBut.Height = e.Y - newBut.Location.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            x = e.X;
            y = e.Y;
            newBut = new Button();
            newBut.Location = new Point(x, y);
            newBut.Name = "Button" + i;
            newBut.Text = "Button" + i++;

            this.Controls.Add(newBut);
        }
    }
}
