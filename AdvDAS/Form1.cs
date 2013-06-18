using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;


namespace AdvDAS
{
    public partial class Form1 : Form
    {
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnScreenShot_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = ScreenShot();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            String fileName = "Screenshots/ScreenShotShot" + count + ".jpg";
            pictureBox1.Image.Save(fileName, ImageFormat.Jpeg);
            count++;
        }

        public Bitmap ScreenShot()
        {
            Bitmap screenShotBMP = new Bitmap(Screen.PrimaryScreen.WorkingArea.Width,
            Screen.PrimaryScreen.WorkingArea.Height, PixelFormat.Format32bppArgb);

            Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);
            
            screenShotGraphics.CopyFromScreen(Screen.PrimaryScreen.WorkingArea.X,
                Screen.PrimaryScreen.WorkingArea.Y, 0, 0, Screen.PrimaryScreen.WorkingArea.Size,
                CopyPixelOperation.SourceCopy);

            screenShotGraphics.Dispose();

            return screenShotBMP;
        }
    }
}
