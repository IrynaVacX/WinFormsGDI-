using System;
using System.Windows.Forms;

namespace CW_04._1_CreateNewForms
{
    public partial class Parent : Form
    {
        Child ch;
        public Parent()
        {
            InitializeComponent();
            ShowChild();
        }
        private void ShowChild()
        {
            ch = new Child();
            ch.Owner = this;
            ch.Show();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in ch.Controls)
                if (c as TextBox != null)
                    (c as TextBox).Text = textBox1.Text;
        }
    }
}
