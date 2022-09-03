using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_02._3_Button_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
        }
        private Button[,] ButtonArray;
        private Random rand;
        private int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Mvalue.Text.Length == 0 || Nvalue.Text.Length == 0 || SizeValue.Text.Length == 0 || DistanceValue.Text.Length == 0 || Mvalue.Text == "0" || Nvalue.Text == "0" || SizeValue.Text == "0")
                MessageBox.Show("Fields filled out incorrectly!");
            else
            {
                ShowButtonArray(Convert.ToInt32(Mvalue.Text), Convert.ToInt32(Nvalue.Text), Convert.ToInt32(SizeValue.Text), Convert.ToInt32(DistanceValue.Text));
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                Mvalue.Visible = false;
                Nvalue.Visible = false;
                SizeValue.Visible = false;
                DistanceValue.Visible = false;
                start.Visible = false;
                this.FormBorderStyle = FormBorderStyle.Sizable;
            }
        }
        private void ShowButtonArray(int m, int n, int x, int y)
        {
            ButtonArray = new Button[m, n];
            this.Size = new Size(y * (n + 1) + x * n, y * (m + 1) + x * m);
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    CreateButton(i, j, x, y);
        }
        private void CreateButton(int i, int j, int x, int y)
        {
            ButtonArray[i, j] = new Button();
            ButtonArray[i, j].Size = new Size(x, x);
            ButtonArray[i, j].Location = new Point(y * (j + 1) + x * j, y * (i + 1) + x * i);
            ButtonArray[i, j].Name = "Button_" + index;
            ButtonArray[i, j].Text = index++.ToString();
            ButtonArray[i, j].FlatStyle = FlatStyle.Standard;
            ButtonArray[i, j].BackColor = Color.FromArgb(rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
            ButtonArray[i, j].ForeColor = Color.FromArgb(ButtonArray[i, j].BackColor.R / 2, ButtonArray[i, j].BackColor.G / 2, ButtonArray[i, j].BackColor.B / 2);
            ButtonArray[i, j].MouseClick += DeleteButton;
            Controls.Add(ButtonArray[i, j]);
        }
        private void DeleteButton(object sender, EventArgs e)
        {
            this.Controls.Remove(sender as Button);
            index--;
            if (index == 0)
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                Mvalue.Visible = true;
                Nvalue.Visible = true;
                SizeValue.Visible = true;
                DistanceValue.Visible = true;
                Mvalue.Text = "";
                Nvalue.Text = "";
                SizeValue.Text = "";
                DistanceValue.Text = "";
                start.Visible = true;
                this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
                this.Size = new Size(250, 260);
            }
        }
    }
}
