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
        //private Trend viewTrend = new Trend(pDoc);
        private SetUpReport configReport = new SetUpReport(pDoc);
        private SetUpProcedure configProcedure;
        private EquipmentSite eSite = new EquipmentSite();
        private PersonalData personalData = new PersonalData();
        private Calibration caliForm = new Calibration();
        private Customer customer = new Customer();
        private Form2 forming = new Form2();
        public  J2KNProtocol protocol = new J2KNProtocol();
        public List<Tuple<Label,Label,Label>> lblList = new List<Tuple<Label, Label, Label>>();
        private DateTime running = new DateTime();
        public static DateTime testTime;
        public static DateTime rampUp = new DateTime(2000, 1, 1, 0, 0, 0);
        public static DateTime testData = new DateTime(2000, 2, 1, 0, 0, 0);
        public static DateTime purge = new DateTime(2000, 1, 2, 0, 0, 0);
        List<Facts> elements = new List<Facts>();
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");

        public static int dgInterval, numOfCycles;
        public static string cUnit, nUnit;
        public MainMenu()
        {
            InitializeComponent();
            createScaleDisplays();
            timer2.Start();
            filltable();
            dgInterval = 1000;
            numOfCycles = 1;
            cUnit = "g/bhp-hr";
            nUnit = "g/bhp-hr";
            dataGridTimer.Start();
            //get all values
        }

        //This method creates the database connection ands populates the element Table on tab2
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

        //This methods creates the popups for the tiles
        void createScaleDisplays()
        {
            //list of all the labels on the tiles that will change
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel1, this.label1, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel2, this.label2, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel3, this.label3, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel4, this.label4, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel5, this.label5, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel6, this.label6, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel7, this.label7, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel8, this.label8, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel9, this.label9, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel10, this.label10, null));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel11, this.label11, this.rLabel1));
            lblList.Add(new Tuple<Label, Label, Label>(this.tileLabel12, this.label12, this.rLabel2));
            //this loop adds all the popup displays to a list
            for (int i = 0; i < 10; i++)
            {
                scaleDisplays.Add(new ScaleDisplay(lblList[i]));
                scaleDisplays[i].elementComboBox.SelectedItem = lblList[i].Item1.Text;
            } 
            ht.Add(new hTile(lblList[10],cUnit));
            ht[0].elementComboBox.Items.AddRange(new object[] { "CO(mass)", "CO(mass) - correction" });
            ht[0].elementComboBox.SelectedIndex = 0;
            ht.Add(new hTile(lblList[11], nUnit));
            ht[1].elementComboBox.Items.AddRange(new object[] { "NOx(mass)", "NOx(mass) - correction" });
            ht[1].elementComboBox.SelectedIndex = 0;
            //Creates a list of all the tiles in the main tab
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
        //Start recording
        private void startRecordingItem_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            this.recordSign.Start();
            this.startRecordingItem.Enabled = false;
            this.pauseRecordingItem.Enabled = true;
            this.stopRecordingItem.Enabled = true;
            if (rampUp.ToString("HH:mm:ss").Equals("00:00:00") && testData.ToString("HH:mm:ss").Equals("00:00:00") && rampUp.ToString("HH:mm:ss").Equals("00:00:00"))
            {
            }
        }
        //Pauses recording?
        private void pauseRecordingItem_Click(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.startRecordingItem.Enabled = true;
            this.pauseRecordingItem.Enabled = false;
            this.stopRecordingItem.Enabled = true;
        }
        //Stops recording
        private void stopRecordingItem_Click(object sender, EventArgs e)
        {
            recordingProgressBar.Value = 0;
            running = new DateTime();
            this.phaseTimeLabel.Text = running.ToString("HH:mm:ss");
            this.timer1.Stop();
            this.recordSign.Stop();
            this.startRecordingItem.Enabled = true;
            this.pauseRecordingItem.Enabled = false;
            this.stopRecordingItem.Enabled = false;
        }
        //Screen shot code might be unnecessary
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
        
        //
        //Timer makes all the test numbers tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= numOfCycles; i++)
            {
                if (rampUp.ToString("HH:mm:ss") != "00:00:00")
                {
                    this.recordingProgressBar.Value = 0;
                    this.recordingProgressBar.Maximum = rampUp.Second;
                    this.recordingProgressBar.Increment(1);
                    rampUp = rampUp.AddSeconds(-1);
                    rTimelbl.Text = rampUp.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                }
                else if (testData.ToString("HH:mm:ss") != "00:00:00")
                {
                    this.recordingProgressBar.Value = 0;
                    this.recordingProgressBar.Maximum = rampUp.Second;
                    this.recordingProgressBar.Increment(1);
                    rampUp = rampUp.AddSeconds(-1);
                    rTimelbl.Text = rampUp.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                }
                else if (purge.ToString("HH:mm:ss") != "00:00:00")
                {
                    this.recordingProgressBar.Value = 0;
                    this.recordingProgressBar.Maximum = rampUp.Second;
                    this.recordingProgressBar.Increment(1);
                    rampUp = rampUp.AddSeconds(-1);
                    rTimelbl.Text = rampUp.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                }
            }
            this.phaseTimeLabel.Text = running.ToString("HH:mm:ss");
        }
        //Regular time and refreshes all other time
        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            this.clock_lbl.Text = now.ToString();
            this.recordTimeLabel.Text = "Total Test Time = " + testTime.ToString("HH:mm:ss");
            this.pTimelbl.Text = purge.ToString("HH:mm:ss");
            this.tTimelbl.Text = testData.ToString("HH:mm:ss");
            this.rTimelbl.Text = rampUp.ToString("HH:mm:ss");
            //foreach (Label lbl in )
            //switch()
        }

        //add question during close
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close this program?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        //Opens Help Window
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            forming.ShowDialog();
        }

        //Opens report Window
        private void configureReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configReport.ShowDialog();
        }

        //Opens recording Window
        private void configureRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            configProcedure = new SetUpProcedure(rampUp, testData,purge, numOfCycles, dgInterval);
            configProcedure.ShowDialog();
        }
        
        //Opens Personal Data Window
        private void personalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personalData.ShowDialog();
        }

        //Opens Custome Window
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer.ShowDialog();
        }

        //Opens Equipment/Site Window
        private void equipmentSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eSite.ShowDialog();
        }

        //Method for reseting all averages
        private double doAverage(double p)
        {
            if (p == -1)
                num.Clear();
            else
                num.Add(p);
            return num.Average();
            throw new NotImplementedException();
        }

        //Changes color of text
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
                labelColor(this, colorDialog.Color);
            }

        }

        //Changes Label color
        private void labelColor(Control ctrl, Color color)
        {
            foreach (Control c in ctrl.Controls)
            {
                labelColor(c,color);
                if (c is Label)
                {
                    c.ForeColor = color;
                }
            }
        }
        // Changes Background color
        private void backGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Sets the initial color select to the current text color.
            colorDialog.Color = label1_.ForeColor;

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

        //changes background color of tiles
        private void tileBackGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            // Keeps the user from selecting a custom color.
            colorDialog.AllowFullOpen = false;
            // Sets the initial color select to the current text color.
            colorDialog.Color = label1_.ForeColor;

            // Update the text box color if the user clicks OK  
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (TableLayoutPanel tile in tiles)
                    tile.BackColor = colorDialog.Color;
            }
            
        }

        //Resets all colors
        private void resetColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TableLayoutPanel tile in tiles)
                tile.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            labelColor(this, System.Drawing.SystemColors.ControlText);
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
        //Fills the table in Graph tab
        void filltable()
        {
            elements.Add(new Facts("O2", "", "%"));
            elements.Add(new Facts("CO", "", "ppm"));
            elements.Add(new Facts("CO2", "", "ppm"));
            elements.Add(new Facts("NO", "", "ppm"));
            elements.Add(new Facts("NO2", "", "ppm"));
            elements.Add(new Facts("NOx", "", "ppm"));
            elements.Add(new Facts("SO2", "", "ppm"));
            elements.Add(new Facts("CxHy", "", "ppm"));
            elements.Add(new Facts("T(gas)", "", "°F"));
            elements.Add(new Facts("T(amb)", "", "°F"));
            elements.Add(new Facts("T(cell)", "", "°F"));
            elements.Add(new Facts("Efficiency", "", "%"));
            elements.Add(new Facts("I.Flow", "", "L/Min"));
            elements.Add(new Facts("Draft", "", "i.w.g."));
            elements.Add(new Facts("Losses", "", "%"));
            elements.Add(new Facts("Excess Air", "", ""));
            elements.Add(new Facts ("CO(mass)","", cUnit ));
            elements.Add(new Facts ("NOx(mass)","0000", nUnit ));
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
            this.dataGridTimer.Interval = dgInterval;
            //get all values
            protocol.processProtocol();
            //get Serial Number
            protocol.processProtocol("$0A0514");
            //get losses number
            protocol.processProtocol("$0A053D");
            //get Internal Flow
            protocol.processProtocol("$0A0531");
            //get Nox Number
            protocol.processProtocol("$0A054E");
            elementTable.Rows[0].Cells[1].Value = protocol.vO2;
            trendGraph.Series[0].Points.AddY(elementTable.Rows[0].Cells[1].Value);
            elementTable.Rows[1].Cells[1].Value = protocol.vCO;
            trendGraph.Series[1].Points.AddY(elementTable.Rows[1].Cells[1].Value);
            elementTable.Rows[2].Cells[1].Value = protocol.vCO2;
            trendGraph.Series[2].Points.AddY(elementTable.Rows[2].Cells[1].Value);
            elementTable.Rows[3].Cells[1].Value = protocol.vNO;
            trendGraph.Series[3].Points.AddY(elementTable.Rows[3].Cells[1].Value);
            elementTable.Rows[4].Cells[1].Value = protocol.vNO2;
            trendGraph.Series[4].Points.AddY(elementTable.Rows[4].Cells[1].Value);
            elementTable.Rows[5].Cells[1].Value = protocol.vNOx;
            trendGraph.Series[5].Points.AddY(elementTable.Rows[5].Cells[1].Value);
            elementTable.Rows[6].Cells[1].Value = protocol.vSO2;
            trendGraph.Series[6].Points.AddY(elementTable.Rows[6].Cells[1].Value);
            elementTable.Rows[7].Cells[1].Value = protocol.vCxHy;
            trendGraph.Series[7].Points.AddY(elementTable.Rows[7].Cells[1].Value);
            elementTable.Rows[8].Cells[1].Value = protocol.vTgas;
            trendGraph.Series[8].Points.AddY(elementTable.Rows[8].Cells[1].Value);
            elementTable.Rows[9].Cells[1].Value = protocol.vTamb;
            trendGraph.Series[9].Points.AddY(elementTable.Rows[9].Cells[1].Value);
            elementTable.Rows[10].Cells[1].Value = protocol.vTcell;
            trendGraph.Series[10].Points.AddY(elementTable.Rows[10].Cells[1].Value);
            elementTable.Rows[11].Cells[1].Value = protocol.vEfficiency;
            trendGraph.Series[11].Points.AddY(elementTable.Rows[11].Cells[1].Value);
            elementTable.Rows[12].Cells[1].Value = protocol.vIFlow;
            trendGraph.Series[12].Points.AddY(elementTable.Rows[12].Cells[1].Value);
            elementTable.Rows[13].Cells[1].Value = protocol.vDraft;
            trendGraph.Series[13].Points.AddY(elementTable.Rows[13].Cells[1].Value);
            elementTable.Rows[14].Cells[1].Value = protocol.vLosses;
            trendGraph.Series[14].Points.AddY(elementTable.Rows[14].Cells[1].Value);
            elementTable.Rows[15].Cells[1].Value = protocol.vExcessAir;
            trendGraph.Series[15].Points.AddY(elementTable.Rows[15].Cells[1].Value);
            elementTable.Rows[16].Cells[1].Value = protocol.vCOmass;
            trendGraph.Series[16].Points.AddY(elementTable.Rows[16].Cells[1].Value);
            elementTable.Rows[17].Cells[1].Value = protocol.vNOxmass;
            trendGraph.Series[17].Points.AddY(elementTable.Rows[17].Cells[1].Value);
        }

         private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
         {
                    elementTable.Rows[elementTable.RowCount-2].Cells[2].Value = cUnit;
                    elementTable.Rows[elementTable.RowCount-1].Cells[2].Value = nUnit;
         }

         private void viewCalibrationInfoToolStripMenuItem_Click(object sender, EventArgs e)
         {
             caliForm.ShowDialog();
         }

         private void recordSign_Tick(object sender, EventArgs e)
         {
             if (recordingSign.Visible.Equals(false))
                 recordingSign.Visible = true;
             else
                 recordingSign.Visible = false;
         }

         
     }
}