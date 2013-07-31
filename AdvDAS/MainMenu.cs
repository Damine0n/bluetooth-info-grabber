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
        public static PrintDoc pDoc = new PrintDoc();
        public static List<ScaleDisplay> scaleDisplays = new List<ScaleDisplay>();
        public static List<hTile> ht = new List<hTile>();
        public List<TableLayoutPanel> tiles = new List<TableLayoutPanel>();
        public Color textColor = Color.Black;
        public Color backgroundColor = Color.Black;
        private List<double> num = new List<double>();
        private ToolTip tp = new ToolTip();
        private Trend viewTrend = new Trend(pDoc);
        private SetUpReport configReport = new SetUpReport(pDoc);
        private SetUpProcedure configProcedure;
        private EquipmentSite eSite = new EquipmentSite();
        private PersonalData personalData = new PersonalData();
        private Customer customer = new Customer();
        private Form2 forming = new Form2();
        public List<Label> lblList = new List<Label>();
        public static DateTime testTime;
        private DateTime running = new DateTime();
        List<Facts> elements = new List<Facts>();
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public static int dgInterval;
        public static string cUnit, nUnit;
        public MainMenu()
        {
            InitializeComponent();
            filltable();
            createScaleDisplays();
            timer2.Start();
            dgInterval = 1000;
            cUnit = "g/bhp-hr";
            nUnit = "g/bhp-hr";
            dataGridTimer.Start();
            
            //startDataBase();
        }

        private void load_table()
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:


            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");


            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM test;", sqlite_conn);
                da.Fill(ds);
                elementTable.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite_conn.Close();
        }
        void createScaleDisplays()
        {
            lblList.Add(this.tileLabel1);
            lblList.Add(this.tileLabel2);
            lblList.Add(this.tileLabel3);
            lblList.Add(this.tileLabel4);
            lblList.Add(this.tileLabel5);
            lblList.Add(this.tileLabel6);
            lblList.Add(this.tileLabel7);
            lblList.Add(this.tileLabel8);
            lblList.Add(this.tileLabel9);
            lblList.Add(this.tileLabel10);
            lblList.Add(this.tileLabel11);
            lblList.Add(this.tileLabel12);
            for (int i = 0; i < 10; i++)
            {
                scaleDisplays.Add(new ScaleDisplay(lblList[i]));
                scaleDisplays[i].elementComboBox.SelectedItem = lblList[i].Text;
            } 
            ht.Add(new hTile(lblList[10],cUnit));
            ht[0].elementComboBox.Items.AddRange(new object[] { "CO(mass)", "CO(mass) - correction" });
            ht[0].elementComboBox.SelectedIndex = 0;
            ht.Add(new hTile(lblList[11], nUnit));
            ht[1].elementComboBox.Items.AddRange(new object[] { "NOx(mass)", "NOx(mass) - correction" });
            ht[1].elementComboBox.SelectedIndex = 0;
            tiles.Add(sTile0);
            tiles.Add(sTile1);
            tiles.Add(sTile2);
            tiles.Add(sTile3);
            tiles.Add(sTile4);
            tiles.Add(sTile5);
            tiles.Add(sTile6);
            tiles.Add(sTile7);
            tiles.Add(sTile8);
            tiles.Add(sTile9);
            tiles.Add(hTile0);
            tiles.Add(hTile1);
        }

        private void startRecordingItem_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.startRecordingItem.Enabled = false;
            this.pauseRecordingItem.Enabled = true;
            this.stopRecordingItem.Enabled = true;
        }

        private void pauseRecordingItem_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.startRecordingItem.Enabled = true;
            this.pauseRecordingItem.Enabled = false;
            this.stopRecordingItem.Enabled = true;
        }

        private void stopRecordingItem_Click(object sender, EventArgs e)
        {
            recordingProgressBar.Value = 0;
            running = new DateTime();
            this.phaseTimeLabel.Text = running.ToString("HH:mm:ss");
            this.timer1.Stop();
            this.startRecordingItem.Enabled = true;
            this.pauseRecordingItem.Enabled = false;
            this.stopRecordingItem.Enabled = false;
        }

        //private void snapShot_Click(object sender, EventArgs e)
        //{
        //    //screenShotBox.Image = ScreenShot();
        //    //screenShotBox.SizeMode = PictureBoxSizeMode.Zoom;
        //    //String fileName = "Screenshots/ScreenShot " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + ".jpg";
        //    //screenShotBox.Image.Save(fileName, ImageFormat.Jpeg);
        //    count++;
        //    //pDoc.printSnapShot(fileName);
        //    Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
        //    SaveFileDialog sfd = new SaveFileDialog();
        //    sfd.Filter = "PDF File|*.pdf";
        //    sfd.FileName = "Test SnapShot File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
        //    sfd.Title = "Save SnapShot";
        //    if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //    {
        //        string path = sfd.FileName;
        //        PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
        //        doc.Open();//Open Document To Write
        //        //Insert Image
        //        iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(fileName);
        //        PNG.ScalePercent(50f);
        //        doc.Add(PNG);
        //        //Write Some Content
        //        Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
        //        //Adds above created text using different class object to our pdf document.
        //        doc.Add(paragraph);
        //        doc.Close();//Closes Document
        //    }
        //}
        //public Bitmap ScreenShot()
        //{
        //    Bitmap screenShotBMP = new Bitmap(this.Bounds.Width,
        //    this.Bounds.Height, PixelFormat.Format32bppArgb);

        //    Graphics screenShotGraphics = Graphics.FromImage(screenShotBMP);

        //    screenShotGraphics.CopyFromScreen(new Point(this.Bounds.Left, this.Bounds.Top), Point.Empty, this.Bounds.Size);

        //    screenShotGraphics.Dispose();

        //    return screenShotBMP;
        //}
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.recordingProgressBar.Increment(1);

            running = running.AddSeconds(1);
            this.phaseTimeLabel.Text = running.ToString("HH:mm:ss");
            if (this.recordingProgressBar.Value == this.recordingProgressBar.Maximum)
            {
                this.recordingProgressBar.Value = 0;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.clock_lbl.Text = now.ToString();
            this.recordTimeLabel.Text = "Total Test Time = " + testTime.ToString("HH:mm:ss");
            this.pTimelbl.Text = "";
            this.tTimelbl.Text = "";
            this.rTimelbl.Text = "";
        }
        
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forming.ShowDialog();
        }
        private void configureReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configReport.ShowDialog();
        }

        private void configureRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configProcedure = new SetUpProcedure(testTime);
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
        private void textColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Sets the initial color select to the current text color.
            colorDialog.Color = label1.ForeColor;

            // Update the text box color if the user clicks OK  
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                labelColor(this, colorDialog);
            }

        }

        private void labelColor(Control ctrl, ColorDialog color)
        {
            foreach (Control c in ctrl.Controls)
            {
                labelColor(c,color);
                if (c is Label)
                {
                    c.ForeColor = color.Color;
                }
            }
        }
        private void backGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Sets the initial color select to the current text color.
            colorDialog.Color = label2.ForeColor;

            // Update the text box color if the user clicks OK  
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                //this.BackColor= colorDialog.Color;
                this.tabPage1.BackColor = colorDialog.Color;
                this.tabPage2.BackColor = colorDialog.Color;
                this.tabPage3.BackColor = colorDialog.Color;
                this.tabPage4.BackColor = colorDialog.Color;
            }
        }

        private void tileBackGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Sets the initial color select to the current text color.
            colorDialog.Color = label2.ForeColor;

            // Update the text box color if the user clicks OK  
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (TableLayoutPanel tile in tiles)
                    tile.BackColor = colorDialog.Color;
            }
        }
        /////////////////////////////////////////////////////////////////TAB-NUMBER-1/////////////////////////////////////////////////////////

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
                    switch (sourceControl.Name)
                    {
                        case "sTile0":
                            scaleDisplays[0].Index = scaleDisplays[0].elementComboBox.SelectedIndex;
                            scaleDisplays[0].source = sourceControl;
                            scaleDisplays[0].ShowDialog(this);
                            break;
                        case "sTile1":
                            scaleDisplays[1].Index = scaleDisplays[1].elementComboBox.SelectedIndex;
                            scaleDisplays[1].source = sourceControl;
                            scaleDisplays[1].ShowDialog(this);
                            break;
                        case "sTile2":
                            scaleDisplays[2].Index = scaleDisplays[2].elementComboBox.SelectedIndex;
                            scaleDisplays[2].source = sourceControl;
                            scaleDisplays[2].ShowDialog(this);
                            break;
                        case "sTile3":
                            scaleDisplays[3].Index = scaleDisplays[3].elementComboBox.SelectedIndex;
                            scaleDisplays[3].source = sourceControl;
                            scaleDisplays[3].ShowDialog(this);
                            break;
                        case "sTile4":
                            scaleDisplays[4].Index = scaleDisplays[4].elementComboBox.SelectedIndex;
                            scaleDisplays[4].source = sourceControl;
                            scaleDisplays[4].ShowDialog(this);
                            break;
                        case "sTile5":
                            scaleDisplays[5].Index = scaleDisplays[5].elementComboBox.SelectedIndex;
                            scaleDisplays[5].source = sourceControl;
                            scaleDisplays[5].ShowDialog(this);
                            break;
                        case "sTile6":
                            scaleDisplays[6].Index = scaleDisplays[6].elementComboBox.SelectedIndex;
                            scaleDisplays[6].source = sourceControl;
                            scaleDisplays[6].ShowDialog(this);
                            break;
                        case "sTile7":
                            scaleDisplays[7].Index = scaleDisplays[7].elementComboBox.SelectedIndex;
                            scaleDisplays[7].source = sourceControl;
                            scaleDisplays[7].ShowDialog(this);
                            break;
                        case "sTile8":
                            scaleDisplays[8].Index = scaleDisplays[8].elementComboBox.SelectedIndex;
                            scaleDisplays[8].source = sourceControl;
                            scaleDisplays[8].ShowDialog(this);
                            break;
                        case "sTile9":
                            scaleDisplays[9].Index = scaleDisplays[9].elementComboBox.SelectedIndex;
                            scaleDisplays[9].source = sourceControl;
                            scaleDisplays[9].ShowDialog(this);
                            break;
                        case "hTile0":
                            ht[0].Index = ht[0].elementComboBox.SelectedIndex;
                            ht[0].source = sourceControl;
                            ht[0].ShowDialog(this);
                            break;
                        case "hTile1":

                            ht[1].Index = ht[1].elementComboBox.SelectedIndex;
                            ht[1].source = sourceControl;
                            ht[1].ShowDialog(this);
                            break;
                    }
                }
            }
        }
        
        

        /////////////////////////////////////////////////////////////////TAB-NUMBER-2/////////////////////////////////////////////////////////
        void filltable()
        {
            elements.Add(new Facts("O2", 0, "%"));
            elements.Add(new Facts("CO", 0, "ppm"));
            elements.Add(new Facts("CO2", 0, "ppm"));
            elements.Add(new Facts("NO", 0, "ppm"));
            elements.Add(new Facts("NO2", 0, "ppm"));
            elements.Add(new Facts("NOx", 0, "ppm"));
            elements.Add(new Facts("SO2", 0, "ppm"));
            elements.Add(new Facts("CxHy", 0, "ppm"));
            elements.Add(new Facts("T(gas)", 0, "°F"));
            elements.Add(new Facts("T(amb)", 0, "°F"));
            elements.Add(new Facts("T(cell)", 0, "°F"));
            elements.Add(new Facts("Efficiency", 0, "%"));
            elements.Add(new Facts("I.Flow", 0, "L/Min"));
            elements.Add(new Facts("Draft", 0, "i.w.g."));
            elements.Add(new Facts("Losses", 0, "%"));
            elements.Add(new Facts("Excess Air", 0, ""));
            elements.Add(new Facts ("CO(mass)",0, cUnit ));
            elements.Add(new Facts ("NOx(mass)",0, nUnit ));
            for (int i = 0; i < elements.Count; i++)
            {
                elementTable.Rows.Add(elements[i].Name, elements[i].Value, elements[i].Unit);
                trendGraph.Series[i].Enabled = false;
            }
        }
        private void elementTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //This condition will make sure that this code execute if and only if checkbox cell is clicked.
            if (e.ColumnIndex == elementTable.Columns["dgGraph"].Index)  //Checking index of checkbox column is equal to clickable cell index.
            {
                elementTable.EndEdit();  //Stop editing of cell.
                if ((bool)elementTable.Rows[e.RowIndex].Cells[3].Value)//only activates on check
                {
                    DialogResult dialogResult = MessageBox.Show("If you select yes your chart's data will restart.", "Are you sure? ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var series in trendGraph.Series)
                        {
                            series.Points.Clear();
                        }
                        trendGraph.Series[e.RowIndex].Enabled = true;                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
                else
                {
                    trendGraph.Series[e.RowIndex].Enabled = false;
                }
            }
        }

        private void dataGridTimer_Tick(object sender, EventArgs e)
        {
            Random ran = new Random();
            int i = 0;
            foreach (var row in elementTable.Rows)
            { 
                this.dataGridTimer.Interval = dgInterval;
                elementTable.Rows[i].Cells[1].Value = double.Parse(ran.Next(0, 100).ToString());
                trendGraph.Series[i].Points.AddY(Double.Parse(elementTable.Rows[i].Cells[1].Value.ToString()));//DataBindY((DataView)elementTable.DataSource, "dgValue");
                i++;
            }
        }

         private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
         {
                    elementTable.Rows[elementTable.RowCount-2].Cells[2].Value = cUnit;
                    elementTable.Rows[elementTable.RowCount-1].Cells[2].Value = nUnit;
         }
    }
}