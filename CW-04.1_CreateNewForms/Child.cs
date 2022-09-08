using System;
using System.Windows.Forms;

namespace CW_04._1_CreateNewForms
{
    public partial class Child : Form
    {
        public Child()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (var c in this.Owner.Controls)
                if (c as TextBox != null)
                    (c as TextBox).Text = textBox1.Text;
        }
    }
}
