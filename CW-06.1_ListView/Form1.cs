using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace CW_06._1_ListView
{
    public partial class Form1 : Form
    {
        ListView listView1;
        public Form1()
        {
            InitializeComponent();

            listView1 = new ListView();
            listView1.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            listView1.View = View.Details;
            listView1.Dock = DockStyle.Fill;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.CheckBoxes = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Sorting = SortOrder.Ascending;

            WishListRead("../../ListWish.txt");
        }
        private void WishListRead(string TXTpath)
        {
            StreamReader sr = new StreamReader(TXTpath);
            ListViewItem item;
            ImageList imageListSmall = new ImageList();
            string[] str = sr.ReadToEnd().Split(new char[] { '\n' });
            sr.Close();
            for (int i = 0; i < str.Length; i+=3)
            {
                imageListSmall.Images.Add(Bitmap.FromFile(str[i]));
                item = new ListViewItem(str[i+1], i/3);
                item.Checked = false;
                item.SubItems.Add(str[i+2]);
                listView1.Items.Add(item);
            }
            listView1.SmallImageList = imageListSmall;
            listView1.Columns.Add("Name", 300, HorizontalAlignment.Center);
            listView1.Columns.Add("Price", 60, HorizontalAlignment.Center);
            this.Controls.Add(listView1);
            Width = 500;
            Height = 300;
        }
    }
}
