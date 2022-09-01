using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW_01_button_drawing
{
    public partial class Form1 : Form
    {
        private Button newBut;
        private int index = 0;
        private bool ifMdown = false;
        private bool button_creation = false;
        private int x0;
        private int y0;
        private int x1;
        private int y1;
        private int x;
        private int y;
        private int Width;
        private int Height;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ifMdown = true;
            x0 = e.X;
            y0 = e.Y;
            x = e.X;
            y = e.Y;
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ifMdown = false;
            button_creation = false;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ifMdown)
            {
                x1 = e.X;
                y1 = e.Y;
                Width  = x1 - x0;
                Height = y1 - y0;
                if (Width > 0 && Height < 0)
                {
                    y = y1;
                    Height *= -1;
                }
                else if (Width < 0 && Height > 0)
                {
                    x = x1;
                    Width *= -1;
                }
                else if (Width < 0 && Height < 0)
                {
                    x = x1;
                    y = y1;
                    Height *= -1;
                    Width *= -1;
                }

                if (!button_creation)
                {
                    button_creation = true;
                    newBut = new Button();
                    newBut.Location = new Point(x, y);
                    newBut.Size = new Size(Width, Height);
                    newBut.Name = "Button" + index;
                    newBut.Text = "Button" + index++;
                    Controls.Add(newBut);
                }
                else
                {
                    newBut.Location = new Point(x, y);
                    newBut.Size = new Size(Width, Height);
                }
            }
        }
    }
}
