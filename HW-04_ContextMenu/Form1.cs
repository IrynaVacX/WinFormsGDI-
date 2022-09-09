using System;
using System.Drawing;
using System.Windows.Forms;

namespace HW_04_ContextMenu
{
    public partial class Form1 : Form
    {
        private int cButton = 3;
        private int cTextbox = 3;
        private int cCheckbox = 3;
        private int x;
        private int y;
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateControl(int x, int y, Control c, string cText = null)
        {
            c.Location = new Point(x, y);
            c.Size = new Size(100, 30);
            if (cText != null)
                c.Text = cText;
            this.Controls.Add(c);
        }
        private void createAButtonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cButton != 0)
            {
                CreateControl(x, y, new Button(), toolStripTextBox1.Text);
                createAButtonToolStripMenuItem.Text = $"Create a button ({--cButton})";
            }
            if (cButton == 0)
                createAButtonToolStripMenuItem.Visible = false;
        }
        private void createATextboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cTextbox != 0)
            {
                CreateControl(x, y, new TextBox());
                createATextboxToolStripMenuItem.Text = $"Create a textbox ({--cTextbox})";
            }
            if(cTextbox == 0)
                createATextboxToolStripMenuItem.Visible = false;
        }
        private void createACheckboxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cCheckbox != 0)
            {
                CreateControl(x, y, new CheckBox(), toolStripTextBox2.Text);
                createACheckboxToolStripMenuItem.Text = $"Create a checkbox ({--cCheckbox})";
            }
            if (cCheckbox == 0)
                createACheckboxToolStripMenuItem.Visible = false;
        }
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                x = e.X;
                y = e.Y;
            }
        }
    }
}
