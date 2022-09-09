using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace CW_05._2_Screenshot_Timer
{
    public partial class Form1 : Form
    {
        private static Bitmap bmpScreenshot;
        private static Graphics gfxScreenshot;
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 5000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(400);
            bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
            gfxScreenshot = Graphics.FromImage(bmpScreenshot);
            gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
            bmpScreenshot.Save($"screen/{DateTime.Now.ToString().Replace(':','-')}.jpg", ImageFormat.Jpeg);
            this.Show();
        }
    }
}
