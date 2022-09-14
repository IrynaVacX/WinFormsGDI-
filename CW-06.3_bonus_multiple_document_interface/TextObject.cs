using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MDIExample
{
    public class TextObject
    {
        private String location = "";
        public String Location
        {
            get { return location; }
            set { location = value; }
        }

        private Boolean isSaved = true;
        public Boolean IsSaved
        {
            get { return isSaved; }
        }

        private String text = "";
        public String Text
        {
            get { return text; }
            set
            {
                if (text != value)
                {
                    text = value;
                    isSaved = false;
                }
            }
        }

        public void OpenFile()
        {
            try
            {
                TextReader textReader = new StreamReader(location, Encoding.Default, true);
                text = textReader.ReadToEnd();
                textReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка открытия файла!", "MDI Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveFile()
        {
            try
            {
                TextWriter textWriter = new StreamWriter(location, false, Encoding.Default);
                textWriter.Write(text);
                textWriter.Close();

                isSaved = true;
            }
            catch
            {
                MessageBox.Show("Ошибка сохранения файла!", "MDI Sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
