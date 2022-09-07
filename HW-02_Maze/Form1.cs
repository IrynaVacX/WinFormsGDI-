using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace HW_02_Maze
{
    public partial class Form1 : Form
    {
        private Labirint l;
        private PictureBox pers;
        private StatusStrip status;
        private DateTime starTime;
        private int scoreMedal;
        private int hearts;
        private int CountOfMedals = 0;
        public Form1()
        {
            InitializeComponent();
            Options();
            StartGame();
            statusStrip1.BackColor = Color.FromArgb(255, 92, 118, 137);
            status = statusStrip1;
        }
        public void Options()
        {
            BackColor = Color.FromArgb(255, 92, 118, 137);

            int sizeX = 40;
            int sizeY = 20;

            Width = sizeX * 16 + 16;
            Height = sizeY * 16 + 40;
            StartPosition = FormStartPosition.CenterScreen;

            scoreMedal = 0;
            hearts = 5;
            status_Medals.Text = $" > > 0*★ < <";
            status_Hearts.Text = "❤❤❤❤❤";
        }
        public void StartGame()
        {
            l = new Labirint(this, 40, 20);
            l.Show();
            CountOfMedals = 0;
            for (int i = 0; i < l.height; i++)
            {
                for (int j = 0; j < l.width; j++)
                {
                    if (l.maze[i, j].type == MazeObject.MazeObjectType.MEDAL)
                        CountOfMedals++;
                }
            }
            pers = new PictureBox();
            pers = l.images[l.smileY, l.smileX];
            l.parent.Controls.Add(status);
            this.Height += 27;
            starTime = DateTime.Now;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.W || e.KeyCode == Keys.S || e.KeyCode == Keys.D || e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)
            {
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    if (CheckMove(pers.Location.X - 16, pers.Location.Y))
                        pers.Location = new Point(pers.Location.X - 16, pers.Location.Y);
                }
                else if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    if (CheckMove(pers.Location.X, pers.Location.Y - 16))
                        pers.Location = new Point(pers.Location.X, pers.Location.Y - 16);
                }
                else if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    if (CheckMove(pers.Location.X, pers.Location.Y + 16))
                        pers.Location = new Point(pers.Location.X, pers.Location.Y + 16);
                }
                else if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
                {
                    if (CheckMove(pers.Location.X + 16, pers.Location.Y))
                        pers.Location = new Point(pers.Location.X + 16, pers.Location.Y);
                }
            }
        }
        private bool CheckMove(int x, int y)
        {
            x /= 16;
            y /= 16;
            if (x >= 0 && y >= 0)
            {
                if (l.maze[y,x].type == MazeObject.MazeObjectType.WALL)
                {
                    return false;
                }
                else if (l.maze[y, x].type == MazeObject.MazeObjectType.ENEMY)
                {
                    l.maze[y, x].type = MazeObject.MazeObjectType.HALL;
                    l.images[y, x].BackgroundImage = new Bitmap(@"C:\1\hall.png");
                    hearts--;
                    status_Hearts.Text = "";
                    for (int i = 0; i < hearts; i++)
                        status_Hearts.Text += "❤";
                    if (hearts == 0)
                        GameOver();
                }
                else if (l.maze[y, x].type == MazeObject.MazeObjectType.MEDAL)
                {
                    l.maze[y, x].type = MazeObject.MazeObjectType.HALL;
                    l.images[y, x].BackgroundImage = new Bitmap(@"C:\1\hall.png");
                    status_Medals.Text = $" > > {++scoreMedal}*★ < <";
                    if (CountOfMedals == scoreMedal)
                    {
                        pers.Location = new Point(x * 16, y * 16);
                        MessageBox.Show("Super Teleport to the finish line activated!!!", "Attention!", MessageBoxButtons.OK);
                        pers.Location = new Point(l.width * 16 - 16, l.height * 16 - 16 * 3);
                        WIN();
                    }
                    else
                        return true;
                }
                else if (l.maze[y, x].type == MazeObject.MazeObjectType.HEAL)
                {
                    if (hearts != 5)
                    {
                        l.maze[y, x].type = MazeObject.MazeObjectType.HALL;
                        l.images[y, x].BackgroundImage = new Bitmap(@"C:\1\hall.png");
                        hearts++;
                        status_Hearts.Text += "❤";
                        return true;
                    }
                    else
                        MessageBox.Show("Max Health Reached", "❤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (x == l.width - 1 && y == l.height - 3)
                {
                    pers.Location = new Point(l.width * 16 - 16, l.height * 16 - 16 * 3);
                    WIN();
                }
                else
                    return true;
            }
            return false;
        }
        private void WIN()
        {
            MessageBox.Show($"  > You won <\n> Health: {status_Hearts.Text}\n> Medals: {scoreMedal}\n> Time: {DateTime.Now - starTime}", ":)", MessageBoxButtons.OK);
            DialogResult res = MessageBox.Show("Start a new game?", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Controls.Clear();
                Options();
                StartGame();
            }
            else
                Close();
        }
        private void GameOver()
        {
            this.Controls.Clear();
            MessageBox.Show(" > Congratulations, you have lost))", ":3", MessageBoxButtons.OK); 
            DialogResult res = MessageBox.Show("Shall we try again?", "?", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                Options();
                StartGame();
            }
            else
                Close();
        }
    }
}
