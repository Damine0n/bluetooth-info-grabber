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
using Finisar.SQLite;
using System.Drawing.Drawing2D;


namespace CRS
{
    public partial class MainMenu : Form
    {
        private int count = 0;
        public static PrintDoc pDoc = new PrintDoc();
        public List<ScaleDisplay> scaleDisplays = new List<ScaleDisplay>();
        private List<double> num =new List<double>();
        private ToolTip tp = new ToolTip();
        private Trend viewTrend = new Trend(pDoc);
        private SetUpReport configReport = new SetUpReport(pDoc);
        private SetUpProcedure configProcedure = new SetUpProcedure();
        private EquipmentSite eSite = new EquipmentSite();
        private PersonalData personalData = new PersonalData();
        private Customer customer = new Customer();
        private Form2 forming = new Form2();
        public List<Label> lblList = new List<Label>();
        DateTime testTime = new DateTime();
        private DateTime running = new DateTime();
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public MainMenu()
        {            
            InitializeComponent();
            createScaleDisplays();
            timer2.Start();
            //startDataBase();
        }
        void createScaleDisplays()
        {
            lblList.Add(this.label1);
            lblList.Add(this.label2);
            lblList.Add(this.label3);
            lblList.Add(this.label4);
            lblList.Add(this.label5);
            lblList.Add(this.label6);
            lblList.Add(this.label7);
            lblList.Add(this.label8);
            lblList.Add(this.label9);
            lblList.Add(this.label10);
            for (int i = 0; i < 10; i++)
            {
                scaleDisplays.Add(new ScaleDisplay(lblList[i]));
            }
        }
        private void startDataBase()
        {

            sqlite_conn.Open();

            // create a new SQL command:
            sqlite_cmd = sqlite_conn.CreateCommand();

            // Let the SQLiteCommand object know our SQL-Query:
            sqlite_cmd.CommandText = "CREATE TABLE Customers (CustomerNumber integer primary key, Company VARCHAR(255), Contact VARCHAR(255), Phone integer, Street VARCHAR(255), Zip integer, City VARCHAR(255), Fax integer, CellPhone integer, Email VARCHAR(255)), Notes VARCHAR(2000));";

            // Now lets execute the SQL ;D
            sqlite_cmd.ExecuteNonQuery();
        }
        private void btnSnapShot_Click(object sender, EventArgs e)
        {
            screenShotBox.Image = ScreenShot();
            screenShotBox.SizeMode = PictureBoxSizeMode.Zoom;
            String fileName = "Screenshots/ScreenShot "+DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss")+ ".jpg";
            screenShotBox.Image.Save(fileName, ImageFormat.Jpeg);
            count++;
            //pDoc.printSnapShot(fileName);
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
        private void menuRecording_Click(object sender, EventArgs e)
        {
            if (menuRecordingItem.Text.Equals("Start Recording"))
            {
                this.timer1.Start();
                menuRecordingItem.Text = "Stop Recording";
                menuRecordingItem.Image = global::CRS.Properties.Resources.stop;
            }
            else
            {
                this.timer1.Stop();
                menuRecordingItem.Text = "Start Recording";
                menuRecordingItem.Image = global::CRS.Properties.Resources.play;
            }
        }

        private void hidePanelMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    sourceControl.Hide();
                }
            }
        }

        private void editDisplayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    switch(sourceControl.Name)
                    {
                        case "sTile0":
                            scaleDisplays[0].elementComboBox.SelectedIndex = 1;
                            scaleDisplays[0].source = sourceControl;
                            scaleDisplays[0].ShowDialog(this);
                            break;
                        case "sTile1":
                            scaleDisplays[1].elementComboBox.SelectedIndex = 2;
                            scaleDisplays[1].source = sourceControl;
                            scaleDisplays[1].ShowDialog(this);
                            break;
                        case "sTile2":
                            scaleDisplays[2].elementComboBox.SelectedIndex = 3;
                            scaleDisplays[2].source = sourceControl;
                            scaleDisplays[2].ShowDialog(this);
                            break;
                        case "sTile3":
                            scaleDisplays[3].elementComboBox.SelectedIndex = 4;
                            scaleDisplays[3].source = sourceControl;
                            scaleDisplays[3].ShowDialog(this);
                            break;
                        case "sTile4":
                            scaleDisplays[4].elementComboBox.SelectedIndex = 5;
                            scaleDisplays[4].source = sourceControl;
                            scaleDisplays[4].ShowDialog(this);
                            break;
                        case "sTile5":
                            scaleDisplays[5].elementComboBox.SelectedIndex = 6;
                            scaleDisplays[5].source = sourceControl;
                            scaleDisplays[5].ShowDialog(this);
                            break;
                        case "sTile6":
                            scaleDisplays[6].elementComboBox.SelectedIndex = 7;
                            scaleDisplays[6].source = sourceControl;
                            scaleDisplays[6].ShowDialog(this);
                            break;
                        case "sTile7":
                            scaleDisplays[7].elementComboBox.SelectedIndex = 8;
                            scaleDisplays[7].source = sourceControl;
                            scaleDisplays[7].ShowDialog(this);
                            break;
                        case "sTile8":
                            scaleDisplays[8].elementComboBox.SelectedIndex = 9;
                            scaleDisplays[8].source = sourceControl;
                            scaleDisplays[8].ShowDialog(this);
                            break;
                        case "sTile9":
                            scaleDisplays[9].elementComboBox.SelectedIndex = 10;
                            scaleDisplays[9].source = sourceControl;
                            scaleDisplays[9].ShowDialog(this);
                            break;
                    }
                }
            }
        }
        private void graphToolStripMenuItem_Click(object sender, EventArgs e)
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
            forming.ShowDialog();
        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this program?","Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
        private void getSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Try to cast the sender to a ToolStripItem
            ToolStripItem menuItem = sender as ToolStripItem;
            if (menuItem != null)
            {
                // Retrieve the ContextMenuStrip that owns this ToolStripItem
                ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                if (owner != null)
                {
                    // Get the control that is displaying this context menu
                    Control sourceControl = owner.SourceControl;
                    MessageBox.Show(sourceControl.Name);
                }
            }
            MessageBox.Show(sender.ToString()+" / "+e.ToString());
        }
        private void configureReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configReport.ShowDialog();
        }

        private void configureRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configProcedure.ShowDialog();
        }

        private void personalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalData.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer.ShowDialog();
        }

        private void equipmentSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eSite.ShowDialog();
        }
        private void sTile3_DoubleClick_1(object sender, EventArgs e)
        {
            sTile3.Hide();
            MessageBox.Show(sTile2.Parent.Name);
        }
        private void isSoSelected(object sender, EventArgs e)
        {
             ToolStripItem menuItem = sender as ToolStripItem;
             if (menuItem != null)
             {
                 // Retrieve the ContextMenuStrip that owns this ToolStripItem
                 ContextMenuStrip owner = menuItem.Owner as ContextMenuStrip;
                 if (owner != null)
                 {
                     // Get the control that is displaying this context menu
                     Control sourceControl = owner.SourceControl;
                     MessageBox.Show(sourceControl.Name);
                     sourceControl.Enabled = false;
                 }
             }


        }




        //private void sTile0_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics v = e.Graphics;
        //    DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
        //    //Without rounded corners
        //    //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
        //    base.OnPaint(e);
        //}
        //public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        //{
        //    GraphicsPath gp = new GraphicsPath();
        //    gp.AddLine(X + radius, Y, X + width - (radius * 2), Y);
        //    gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
        //    gp.AddLine(X + width, Y + radius, X + width, Y + height - (radius * 2));
        //    gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
        //    gp.AddLine(X + width - (radius * 2), Y + height, X + radius, Y + height);
        //    gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
        //    gp.AddLine(X, Y + height - (radius * 2), X, Y + radius);
        //    gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
        //    gp.CloseFigure();
        //    g.DrawPath(p, gp);
        //    gp.Dispose();
        //}
    }
}