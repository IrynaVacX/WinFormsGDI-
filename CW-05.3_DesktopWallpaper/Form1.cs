using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Runtime.InteropServices;
using System.IO;

namespace CW_05._3_DesktopWallpaper
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        private string[] dirs = Directory.GetFiles("C:/pics/");
        private int i = 0;
        public Form1()
        {
            InitializeComponent();
            SetWallpaper(dirs[1], 2, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetWallpaper(dirs[i++], 2, 0);
            if (dirs.Length == i)
                i = 0;
        }
        private void SetWallpaper(string path, int style, int tile)
        {
            SystemParametersInfo(20, 0, path, 0x01 | 0x02);
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);
            key.SetValue("WallpaperStyle", style);
            key.SetValue("TileWallpaper", tile);
            key.Close();
            pictureBox1.ImageLocation = GetCurrentWallpaper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.ImageLocation = GetCurrentWallpaper();
            timer1.Interval = 1000;
            timer1.Start();
        }
        private string GetCurrentWallpaper()
        {
            RegistryKey rkWallPaper = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", false);
            string WallpaperPath = rkWallPaper.GetValue("WallPaper").ToString();
            rkWallPaper.Close();
            return WallpaperPath;
        }
    }
}
