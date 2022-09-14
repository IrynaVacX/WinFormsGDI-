using System;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }
        public void SaveFile()
        {
            SaveFileAs();
        }
        public void SaveFileAs()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.CheckPathExists = true;
            sfd.Title = "Save File - MDI Sample";
            sfd.ValidateNames = true;
            sfd.Filter = "Text files (*.txt)|*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                TextObject tb = new TextObject();
                tb.Text = label1.Text + '\n' + label2.Text;
                tb.Location = sfd.FileName;
                tb.SaveFile();
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
