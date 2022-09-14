using System;
using System.Windows.Forms;

namespace MDIExample
{
    public partial class ContentForm : Form
    {
        private TextObject textObject = new TextObject();

        public ContentForm()
        {
            InitializeComponent();
        }

        private void tbxText_TextChanged(object sender, EventArgs e)
        {
            textObject.Text = tbxText.Text;
        }

        private void ContentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!textObject.IsSaved)
            {
                DialogResult dr = MessageBox.Show("Сохранить файл?", "Файл не сохранен!", MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

                switch (dr)
                {
                    case DialogResult.Yes: SaveFile(); break;
                    case DialogResult.No: break;
                    case DialogResult.Cancel: e.Cancel = true; break;
                }
            }
        }

        public void SaveFile()
        {
            if (textObject.Location != String.Empty) textObject.SaveFile();
            else SaveFileAs();
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
                textObject.Location = sfd.FileName;
                textObject.SaveFile();
            }
        }

        public void OpenFile(String fileName)
        {
            textObject.Location = fileName;
            textObject.OpenFile();
            tbxText.Text = textObject.Text;
        }
    }
}
