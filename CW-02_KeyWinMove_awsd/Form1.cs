using System;
using System.Drawing;
using System.Windows.Forms;

namespace CW_02_KeyWinMove_awsd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            x = Screen.PrimaryScreen.Bounds.Width/2 - this.Size.Width/2;
            y = Screen.PrimaryScreen.Bounds.Height / 2 - this.Size.Height / 2;
            this.Location = new Point(x,y);
            this.StartPosition = FormStartPosition.Manual;
        }
        private int x, y;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left || e.KeyCode == Keys.W || e.KeyCode == Keys.Up || e.KeyCode == Keys.S || e.KeyCode == Keys.Down || e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                    x -= 25;
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                    y -= 25;
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                    y += 25;
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                    x += 25;

                if (Screen.PrimaryScreen.Bounds.Width - this.Size.Width < x || Screen.PrimaryScreen.Bounds.Height - this.Size.Height < y || x < 0 || y < 0)
                {
                    if (Screen.PrimaryScreen.Bounds.Width - this.Size.Width < x)
                        x = Screen.PrimaryScreen.Bounds.Width - this.Size.Width;
                    else if (Screen.PrimaryScreen.Bounds.Height - this.Size.Height < y)
                        y = Screen.PrimaryScreen.Bounds.Height - this.Size.Height;
                    else if (x < 0)
                        x = 0;
                    else if (y < 0)
                        y = 0;
                }

                this.Location = new Point(x, y);
            }
        }
    }
}
