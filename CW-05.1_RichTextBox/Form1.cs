using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_05._1_RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureAndSomeText();
        }
        private void PictureAndSomeText()
        {
            Image img = Image.FromFile("1.png");
            Clipboard.SetImage(img);
            richTextBox1.Text += "something text...";
            richTextBox1.Paste();
        }
    }
}
