using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Drawing.Imaging;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;


namespace AdvDAS
{
    public partial class MainMenu : Form
    {
        private int count = 0;
        public List<ScaleDisplay> scaleDisplays = new List<ScaleDisplay>();
        private List<double> num =new List<double>();
        private ToolTip tp = new ToolTip();
        //private bool thisState = false;
        private Thread t;
        private Trend viewTrend = new Trend();
        public static List<Label> lblList = new List<Label>();
        DateTime testTime = new DateTime();
        public DateTime startTime = DateTime.Now;
        private DateTime running = new DateTime();
        public MainMenu()
        {
            for (int i = 0; i < 8; i++)
            {
                scaleDisplays.Add(new ScaleDisplay(this,i));
            }
            InitializeComponent();
            timer2.Start();
        }
        private void btnSnapShot_Click(object sender, EventArgs e)
        {
            screenShotBox.Image = ScreenShot();
            screenShotBox.SizeMode = PictureBoxSizeMode.Zoom;
            String fileName = "Screenshots/ScreenShot "+DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")+ ".jpg";
            screenShotBox.Image.Save(fileName, ImageFormat.Jpeg);
            count++;
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test SnapShot File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save SnapShot";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write
                //Insert Image
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(fileName);
                PNG.ScalePercent(50f);
                doc.Add(PNG);
                //Write Some Content
                Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
                //Adds above created text using different class object to our pdf document.
                doc.Add(paragraph);
                doc.Close();//Closes Document

            }
            
        }

        public Bitmap ScreenShot()
        {
            Bitmap screenShotBMP = new Bitmap(this.Bounds.Width,
            this.Bounds.Height, PixelFormat.Format32bppArgb);

            Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);

            screenShotGraphics.CopyFromScreen(new Point(this.Bounds.Left, this.Bounds.Top), Point.Empty, this.Bounds.Size);

            screenShotGraphics.Dispose();

            return screenShotBMP;
        }
        //private void ThreadProc(object num)
        //{
        //    Application.Run(scaleDisplays[Convert.ToInt32(num)]);
        //}
        private void menuRecording_Click(object sender, EventArgs e)
        {
            if (menuRecordingItem.Text.Equals("Start Recording"))
            {
                this.timer1.Start();
                menuRecordingItem.Text = "Stop Recording";
                menuRecordingItem.Image = global::AdvDAS.Properties.Resources.stop;
            }
            else
            {
                this.timer1.Stop();
                menuRecordingItem.Text = "Start Recording";
                menuRecordingItem.Image = global::AdvDAS.Properties.Resources.play;
            }
        }
        private void checkBoxHover(object sender, EventArgs e)
        {
            this.tp.SetToolTip(this.checkBox0, "Your text here :) ");
            this.tp.ShowAlways = true;
        }

        private void hidePanelMenuItem_Click(object sender, EventArgs e)
        {
            List<Panel> panelList = new List<Panel>();
            panelList.Add(sTile1);
            panelList.Add(sTile0);
            MessageBox.Show(Cursor.Position.X+","+Cursor.Position.Y);
            ToolStripMenuItem thisPanel;
            if (sender is ToolStripMenuItem)
            {
                thisPanel = (ToolStripMenuItem)sender;
            }
            else
            {
                MessageBox.Show("THIS IS A " + sender.GetType().Name);
                return;
            }            


                //string p = "sTile" + i;
                //sende
                foreach(Panel p in panelList) {
                    Control masterControl = MasterParent(p);
                    int pX0 = masterControl.Left;
                    int pX1 = masterControl.Right;
                    int pY0 = masterControl.Top;
                    int pY1 = masterControl.Bottom;

                    if ((pX0 <= Cursor.Position.X && Cursor.Position.X <= pX1) && (pY0 <= Cursor.Position.Y && Cursor.Position.Y <= pY1))
                        p.Visible = false;
                        return;
                    }
                

                /*this.hidePanelMenuItem.Text = "Hide This Display";
                (sender as Panel).Visible = false;*/
                //this.sTile0.Visible = thisState;
            //else 
            //{
            //    this.hidePanelMenuItem.Text = "Show This Display";
            //    (sender as Panel).Visible = thisState;
            //    //this.sTile0.Visible = thisState;
            //}
           
        }

        private Control MasterParent(Control control)
        {
            Control returnValue;
            Point locationOnForm = control.FindForm().PointToClient(
                control.Parent.PointToScreen(control.Location));
            for (returnValue = control; control.Parent != null; control = control.Parent)
            {
                returnValue = (control.Parent);
            }

            return returnValue;
        }

        private void editDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            scaleDisplays[2].ShowDialog();
            //scaleDisplays[2].elementComboBox.SelectedIndex=4;
        }
        private void viewTrendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewTrend.ShowDialog();
        }
        private void resetAllAveragesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doAverage(-1);
        }

        private double doAverage(double p)
        {
            if (p == -1)
                num.Clear();
            else
                num.Add(p);
            return num.Average();
            throw new NotImplementedException();
        }
        private void sTile4_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(sender.ToString());
            if (sTile4.Visible.Equals(true))
                sTile4.Hide();
            //sTile4.Visible = false;
            else
                sTile4.Show();
                //sTile4.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.recordingProgressBar.Increment(1);
            
            running = running.AddSeconds(1);
  
            this.recordTimeLabel.Text = "REC = ("+testTime.ToString("HH:mm:ss")+") "+running.ToString("HH:mm:ss");
 
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.clock_lbl.Text = now.ToString();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this program?","Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
    }
}