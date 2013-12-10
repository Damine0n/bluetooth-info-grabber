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
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
//using System.Data.SQLite;
using Finisar.SQLite;
using System.Drawing.Drawing2D;
using log4net;
//[assembly: log4net.Config.XmlConfigurator(Watch = true)]


namespace CRS
{
    public partial class MainMenu : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private System.Drawing.Rectangle tabArea;
        private RectangleF tabTextArea;
        public List<ScaleDisplay> scaleDisplays = new List<ScaleDisplay>();
        public List<TableLayoutPanel> tiles = new List<TableLayoutPanel>();
        public List<string> tableNames = new List<string>();
        public Color textColor = Color.Black;
        public Color backgroundColor = Color.Black;
        private List<double> num = new List<double>();
        private ToolTip tp = new ToolTip();
        private SetUpReport configReport = new SetUpReport();
        private SetUpProcedure configProcedure;
        TestRecords tRecords = new TestRecords();
        Customer customer = new Customer();
        private Calibration caliForm = new Calibration();
        public static EquipmentSite eSite;
        private Form2 forming = new Form2();
        private List<Tuple<Label, Label, Button>> lblList1 = new List<Tuple<Label, Label, Button>>();
        private List<Tuple<Label, Label, Label, Button>> lblList2 = new List<Tuple<Label, Label, Label, Button>>();
        private bool rFirst = true;
        private bool tFirst = true;
        private bool pFirst = true;
        private DateTime running = new DateTime();
        public static DateTime testTime;
        public static DateTime rampUp = new DateTime(2000, 2, 1, 0, 0, 0);
        public static DateTime testData = new DateTime(2000, 2, 1, 0, 0, 0);
        public static DateTime purge = new DateTime(2000, 2, 1, 0, 0, 0);
        private DateTime tempRampUp = new DateTime(2000, 2, 1, 0, 0, 0);
        private DateTime tempTestData = new DateTime(2000, 2, 1, 0, 0, 0);
        private DateTime tempPurge = new DateTime(2000, 2, 2, 0, 0, 0);
        List<Facts> elements = new List<Facts>();
        public static bool purged;
        public static int dgInterval, cycles, tested;
        public static int currentCycle = 1;
        public static string cUnit, nUnit, numOfCycles, site, equipment = "Not Selected";
        public J2KNProtocol protocol = new J2KNProtocol();
        private string tableName = "";
        private bool run = false;
        private string units = "Time, O2, CO, CO2, NO, NO2, NOx, Tgas, Tamb, Tcell, IFlow";
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public MainMenu()
        {
            InitializeComponent();
            log.Debug("Initialized");
            createScaleDisplays();
            log.Debug("Created Displays");
            timer2.Start();
            log.Debug("timer2");
            filltable();
            log.Debug("filltable");
            dgInterval = 1000;
            numOfCycles = "1";
            cUnit = "g/bhp-hr";
            nUnit = "g/bhp-hr";
            if (protocol.processProtocol(true))
            {
                log.Debug("protocol.processProtocol()");
                dataGridTimer.Start();
                log.Debug("dataGridTimer.Start()");
            }

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
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel1, this.label1, this.tileButton1));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel2, this.label2, this.tileButton2));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel3, this.label3, this.tileButton3));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel4, this.label4, this.tileButton4));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel5, this.label5, this.tileButton5));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel6, this.label6, this.tileButton6));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel7, this.label7, this.tileButton7));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel8, this.label8, this.tileButton8));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel9, this.label9, this.tileButton9));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel10, this.label10, this.tileButton10));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel11, this.label11, this.tileButton11));
            lblList1.Add(new Tuple<Label, Label, Button>(this.tileLabel12, this.label12, this.tileButton12));
            //this loop adds all the popup displays to a list
            for (int i = 0; i <= 11; i++)
            {
                scaleDisplays.Add(new ScaleDisplay(lblList1[i]));
                scaleDisplays[i].elementComboBox.SelectedItem = lblList1[i].Item1.Text;
            }

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
            tiles.Add(sTile10);
            tiles.Add(sTile11);
        }
        //Start recording
        private void startRecordingItem_Click(object sender, EventArgs e)
        {
            if (!equipment.Equals("Not Selected"))
            {
                if (!run)
                {
                    if (tempRampUp.ToString("HH:mm:ss").Equals("00:00:00") && tempTestData.ToString("HH:mm:ss").Equals("00:00:00") && tempPurge.ToString("HH:mm:ss").Equals("00:00:00") && numOfCycles == currentCycle.ToString())
                    {
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Do you need to do a Pre-Calibration now? \n\nSelect YES if you do. \n\nSelect NO if you have already done it or if you do not need a Pre-Calibration.", "Pre-Calibration?", MessageBoxButtons.YesNo);
                        if (dialog == DialogResult.Yes)
                        {
                            caliForm.ShowDialog();
                        }
                        else
                        {
                            protocol.processProtocol("$0F1066 0x20");
                            this.configureRecordingToolStripMenuItem.Enabled = run;
                            this.button1.Enabled = run;
                            run = true;
                            this.timer1.Start();
                            this.startRecordingButton.BackgroundImage = CRS.Properties.Resources.pause_A;
                            this.stopRecordingButton.Enabled = run;
                        }
                    }
                }
                else
                {
                    this.configureRecordingToolStripMenuItem.Enabled = run;
                    this.button1.Enabled = run;
                    run = false;
                    this.timer1.Stop();
                    this.recordingSign.Visible = false;
                    this.startRecordingButton.BackgroundImage = CRS.Properties.Resources.start_A;
                }
            }
        }


        //Stops recording
        private void stopRecordingItem_Click(object sender, EventArgs e)
        {
            stopIt(true);
        }

        private void stopIt(bool test)
        {
            foreach (Tuple<Label, Label, Button> tupes in lblList1)
            {
                tupes.Item3.Enabled = true;
            }
            this.configureRecordingToolStripMenuItem.Enabled = run;
            this.button1.Enabled = run;
            this.timer1.Stop();
            recordingSign.Visible = false;
            this.startRecordingButton.BackgroundImage = CRS.Properties.Resources.start_A;
            run = false;
            rampUp = new DateTime(2000, 2, 1, 0, 0, 0);
            testData = new DateTime(2000, 2, 1, 0, 0, 0);
            purge = new DateTime(2000, 2, 1, 0, 0, 0);
            rFirst = true;
            tFirst = true;
            pFirst = true;
            testTime = new DateTime(2000, 1, 1, 0, 0, 0);
            this.startRecordingButton.Enabled = true;
            this.stopRecordingButton.Enabled = false;
            if (test)
            {
                DialogResult dialog1 = MessageBox.Show("Do you want to save your test?", "Save Test", MessageBoxButtons.YesNo);
                if (dialog1 == DialogResult.Yes)
                {
                    PrintDocs pDoc = new PrintDocs();
                    pDoc.printReport(tableNames);
                }
                tableNames.Clear();
                currentCycle = 1;

                DialogResult dialog2 = MessageBox.Show("Do you need to do a post drift check now?", "Post Test Drift Check?", MessageBoxButtons.YesNo);
                if (dialog2 == DialogResult.Yes)
                {
                    caliForm.ShowDialog();
                }
            }
        }
        //Takes Snapshot Recording
        private void snapShot_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                string time = DateTime.Now.ToString();
                NotesForm note = new NotesForm();
                DialogResult dialog = note.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    new GasAnalysis(Convert.ToDateTime(time)).SnapShot(protocol, note.snapNote, timer1.Enabled, tableName);
                }
            }
        }

        //Timer makes all the test numbers tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            recordingSign.Visible = true;
            foreach (Tuple<Label, Label, Button> tupes in lblList1)
            {
                tupes.Item3.Enabled = false;
            }
            resetButton.Enabled = false;
            recordData.Interval = dgInterval;
            resetAll();
            if (!numOfCycles.Equals("-1"))
            {
                cycles = Convert.ToInt32(numOfCycles);
                label22.Text = currentCycle + " of " + numOfCycles;
                label48.Text = currentCycle + " of " + numOfCycles;
                if (rampUpMethod())
                {

                }
                else if (testDataMethod())
                {

                }
                else if (purgeMethod())
                {

                }
                else if (!currentCycle.ToString().Equals(numOfCycles))
                {
                    currentCycle++;
                    rFirst = true;
                    tFirst = true;
                    pFirst = true;
                    resetAll();
                    protocol.processProtocol("$0F1066 0x20");
                }
                else if (currentCycle.ToString().Equals(numOfCycles))
                {
                    timer1.Stop();
                    foreach (Tuple<Label, Label, Button> tupes in lblList1)
                    {
                        tupes.Item3.Enabled = true;
                    }
                    resetButton.Enabled = true;
                    this.recordingSign.Visible = false;
                    protocol.processProtocol("$0F1066 0x20");
                    this.startRecordingButton.BackgroundImage = CRS.Properties.Resources.start_A;
                    stopIt(true);
                }
            }
            else
            {
                label22.Text = currentCycle + " of " + "\u221e";
                label48.Text = currentCycle + " of " + "\u221e";
                if (rampUpMethod())
                {

                }
                else if (testDataMethod())
                {

                }
                else if (purgeMethod())
                {

                }
                else if (!currentCycle.ToString().Equals(numOfCycles))
                {
                    currentCycle++;
                    rFirst = true;
                    tFirst = true;
                    pFirst = true;
                    resetAll();
                    protocol.processProtocol("$0F1066 0x20");
                }
            }
        }
        private bool rampUpMethod()
        {
            if (rFirst)
            {
                if (!(tempRampUp <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    protocol.processProtocol("$0F1066 0x20");
                    rFirst = false;
                    tempRampUp = tempRampUp.AddSeconds(-1);
                    rTimelbl.Text = tempRampUp.ToString("HH:mm:ss");
                    rTimelblB.Text = tempRampUp.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!(tempRampUp <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    tempRampUp = tempRampUp.AddSeconds(-1);
                    rTimelbl.Text = tempRampUp.ToString("HH:mm:ss");
                    rTimelblB.Text = tempRampUp.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);

                    return true;
                }
                else
                {
                    tempRampUp = new DateTime(2000, 2, 1, 0, 0, 0);
                    resetAll();
                    return false;
                }
            }
        }

        private bool testDataMethod()
        {
            resetAll();
            if (tFirst)
            {
                if (!(tempTestData <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    protocol.processProtocol("$0F1066 0x20");
                    tFirst = false;
                    tempTestData = testData.AddSeconds(-1);
                    tTimelbl.Text = tempTestData.ToString("HH:mm:ss");
                    tTimelblB.Text = tempTestData.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                    tableName = new GasAnalysis().newEntry(protocol);
                    if (tableName.Equals("Error"))
                    {
                        MessageBox.Show(tableName + ": You must have an equipment selected.");
                        stopIt(false);
                    }
                    else
                        tableNames.Add(tableName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!(tempTestData <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    tempTestData = tempTestData.AddSeconds(-1);
                    tTimelbl.Text = tempTestData.ToString("HH:mm:ss");
                    tTimelblB.Text = tempTestData.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                    recordData.Start();
                    return true;
                }
                else
                {
                    tempTestData = new DateTime(2000, 2, 1, 0, 0, 0);
                    recordData.Stop();
                    return false;
                }
            }
        }

        private bool purgeMethod()
        {

            if (pFirst)
            {
                if (purged.Equals(false))
                {
                    timer1.Stop();
                    MessageBox.Show("Remove the sample line from the analyzer to purge with fresh air, then click ok.");
                    timer1.Start();
                }
                if (!(tempPurge <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    protocol.processProtocol("$0F1066 0x20");
                    protocol.processProtocol("$0F1050 0x20");
                    pFirst = false;
                    tempPurge = tempPurge.AddSeconds(-1);
                    pTimelbl.Text = tempPurge.ToString("HH:mm:ss");
                    pTimelblB.Text = tempPurge.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                if (!(tempPurge <= new DateTime(2000, 2, 1, 0, 0, 0)))
                {
                    tempPurge = tempPurge.AddSeconds(-1);
                    pTimelbl.Text = tempPurge.ToString("HH:mm:ss");
                    pTimelblB.Text = tempPurge.ToString("HH:mm:ss");
                    running = running.AddSeconds(1);
                    return true;
                }
                else
                {
                    protocol.processProtocol("$0F1051 0x20");
                    tempPurge = new DateTime(2000, 2, 1, 0, 0, 0);
                    return false;
                }
            }
        }

        //Regular time and refreshes all other time
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (rFirst)
                tempRampUp = rampUp;
            if (tFirst)
                tempTestData = testData;
            if (pFirst)
                tempPurge = purge;
            DateTime now = DateTime.Now;
            this.clock_lbl.Text = now.ToString();
            this.recordTimeLabel.Text = testTime.ToString("HH:mm:ss");
            this.pTimelbl.Text = tempPurge.ToString("HH:mm:ss");
            this.tTimelbl.Text = tempTestData.ToString("HH:mm:ss");
            this.rTimelbl.Text = tempRampUp.ToString("HH:mm:ss");
            this.recordTimeLabelB.Text = testTime.ToString("HH:mm:ss");
            this.pTimelblB.Text = tempPurge.ToString("HH:mm:ss");
            this.tTimelblB.Text = tempTestData.ToString("HH:mm:ss");
            this.rTimelblB.Text = tempRampUp.ToString("HH:mm:ss");
            this.label16.Text = "Equipment: " + equipment + "\n ";
            this.label23.Text = dgInterval / 1000 + " sec(s)";
            this.label43.Text = dgInterval / 1000 + " sec(s)";
            this.label14.Text = "\n" + tested + " Machines Tested\nSince Last Calibration\n ";
            if (protocol.processProtocol())
                dataGridTimer.Start();


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
            configProcedure = new SetUpProcedure(rampUp, testData, purge, numOfCycles, dgInterval);
            configProcedure.ShowDialog();
        }

        //Opens Personal Data Window
        private void personalDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonalData personalData = new PersonalData();
            personalData.ShowDialog();
        }

        //Opens Custome Window
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer.ShowDialog();
        }

        //Opens Equipment/Site Window

        //Changes Label color
        private void labelColor(Control ctrl, Color color)
        {
            foreach (Control c in ctrl.Controls)
            {
                labelColor(c, color);
                if (c is Label)
                {
                    c.ForeColor = color;
                }
            }
        }
        // Changes Background color
        //private void backGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ColorDialog colorDialog = new ColorDialog();
        //    // Keeps the user from selecting a custom color.
        //    colorDialog.AllowFullOpen = false;
        //    // Sets the initial color select to the current text color.
        //    colorDialog.Color = label1_.ForeColor;

        //    // Update the text box color if the user clicks OK  
        //    if (colorDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        //this.BackColor= colorDialog.Color;
        //        this.tabPage1.BackColor = colorDialog.Color;
        //        this.tabPage2.BackColor = colorDialog.Color;
        //        this.tabPage3.BackColor = colorDialog.Color;
        //        this.tabPage4.BackColor = colorDialog.Color;
        //    }
        //}

        ////changes background color of tiles
        //private void tileBackGroundColorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ColorDialog colorDialog = new ColorDialog();
        //    // Keeps the user from selecting a custom color.
        //    colorDialog.AllowFullOpen = false;
        //    // Sets the initial color select to the current text color.
        //    colorDialog.Color = label1_.ForeColor;

        //    // Update the text box color if the user clicks OK  
        //    if (colorDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        foreach (TableLayoutPanel tile in tiles)
        //            tile.BackColor = colorDialog.Color;
        //    }

        //}

        ////Resets all colors
        //private void resetColorToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    foreach (TableLayoutPanel tile in tiles)
        //        tile.BackColor = System.Drawing.SystemColors.ActiveCaption;
        //    this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
        //    this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
        //    this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
        //    this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
        //    labelColor(this, System.Drawing.SystemColors.ControlText);
        //}
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
        private void resetButton_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void resetAll()
        {
            int i = 0;
            foreach (ScaleDisplay display in scaleDisplays)
            {
                scaleDisplays[i].resetAverage();
                i++;
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
                    try
                    {
                        switch (sourceControl.Name)
                        {
                            case "sTile0":
                                scaleDisplays[0].Index = scaleDisplays[0].elementComboBox.SelectedIndex;
                                scaleDisplays[0].source = sourceControl;
                                scaleDisplays[0].ShowDialog();
                                break;
                            case "sTile1":
                                scaleDisplays[1].Index = scaleDisplays[1].elementComboBox.SelectedIndex;
                                scaleDisplays[1].source = sourceControl;
                                scaleDisplays[1].ShowDialog();
                                break;
                            case "sTile2":
                                scaleDisplays[2].Index = scaleDisplays[2].elementComboBox.SelectedIndex;
                                scaleDisplays[2].source = sourceControl;
                                scaleDisplays[2].ShowDialog();
                                break;
                            case "sTile3":
                                scaleDisplays[3].Index = scaleDisplays[3].elementComboBox.SelectedIndex;
                                scaleDisplays[3].source = sourceControl;
                                scaleDisplays[3].ShowDialog();
                                break;
                            case "sTile4":
                                scaleDisplays[4].Index = scaleDisplays[4].elementComboBox.SelectedIndex;
                                scaleDisplays[4].source = sourceControl;
                                scaleDisplays[4].ShowDialog();
                                break;
                            case "sTile5":
                                scaleDisplays[5].Index = scaleDisplays[5].elementComboBox.SelectedIndex;
                                scaleDisplays[5].source = sourceControl;
                                scaleDisplays[5].ShowDialog();
                                break;
                            case "sTile6":
                                scaleDisplays[6].Index = scaleDisplays[6].elementComboBox.SelectedIndex;
                                scaleDisplays[6].source = sourceControl;
                                scaleDisplays[6].ShowDialog();
                                break;
                            case "sTile7":
                                scaleDisplays[7].Index = scaleDisplays[7].elementComboBox.SelectedIndex;
                                scaleDisplays[7].source = sourceControl;
                                scaleDisplays[7].ShowDialog();
                                break;
                            case "sTile8":
                                scaleDisplays[8].Index = scaleDisplays[8].elementComboBox.SelectedIndex;
                                scaleDisplays[8].source = sourceControl;
                                scaleDisplays[8].ShowDialog();
                                break;
                            case "sTile9":
                                scaleDisplays[9].Index = scaleDisplays[9].elementComboBox.SelectedIndex;
                                scaleDisplays[9].source = sourceControl;
                                scaleDisplays[9].ShowDialog();
                                break;
                            case "sTile10":
                                scaleDisplays[10].Index = scaleDisplays[10].elementComboBox.SelectedIndex;
                                scaleDisplays[10].source = sourceControl;
                                scaleDisplays[10].ShowDialog();
                                break;
                            case "sTile11":
                                scaleDisplays[11].Index = scaleDisplays[11].elementComboBox.SelectedIndex;
                                scaleDisplays[11].source = sourceControl;
                                scaleDisplays[11].ShowDialog();
                                break;

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                    }
                }
            }
        }
        private void tileButton_Click(object sender, EventArgs e)
        {
            Button avgBTN = sender as Button;
            int i = 0;
            foreach (ScaleDisplay display in scaleDisplays)
            {
                if (scaleDisplays[i].btn.Name.Equals(avgBTN.Name))
                {
                    scaleDisplays[i].resetAverage();
                }
                i++;
            }
        }


        /////////////////////////////////////////////////////////////////TAB-NUMBER-2/////////////////////////////////////////////////////////
        //Fills the table in Graph tab
        void filltable()
        {
            elements.Add(new Facts("O2", "", "%"));
            elements.Add(new Facts("CO", "", "ppm"));
            elements.Add(new Facts("CO2", "", "%"));
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
            elements.Add(new Facts("CO lb/mmBTU", "", "ppm"));
            elements.Add(new Facts("NOx lb/mmBTU", "", "ppm"));
            elements.Add(new Facts("CO TPY", "", "ppm"));
            elements.Add(new Facts("NOx TPY", "", "ppm"));
            elements.Add(new Facts("CO lb/hr", "", "ppm"));
            elements.Add(new Facts("NOx lb/hr", "", "ppm"));
            elements.Add(new Facts("CO g/BHP-Hr", "", "ppm"));
            elements.Add(new Facts("NOx g/BHP-Hr", "", "ppm"));
            for (int i = 0; i < elements.Count; i++)
            {
                elementTable.Rows.Add(elements[i].Name, elements[i].Value, elements[i].Unit);
                trendGraph.Series[i].Enabled = false;
                chart1.Series[i].Enabled = false;
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
                    DialogResult dialogResult = MessageBox.Show("If you select yes, your chart's data will restart.", "Are you sure? ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var series in trendGraph.Series)
                        {
                            series.Points.Clear();
                        }
                        foreach (var series in chart1.Series)
                        {
                            series.Points.Clear();
                        }
                        trendGraph.Series[e.RowIndex].Enabled = true;
                        chart1.Series[e.RowIndex].Enabled = true;
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    }
                }
                else
                {
                    trendGraph.Series[e.RowIndex].Enabled = false;
                    chart1.Series[e.RowIndex].Enabled = false;
                }
            }
        }
        public int nums = 1;

        private void dataGridTimer_Tick(object sender, EventArgs e)
        {
            
            label13.Text = "Connected";
            pictureBox1.Image = Properties.Resources.wi_fi_btn;
            label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(97)))), ((int)(((byte)(175)))));
            
            if (numOfCycles.Equals("-1"))
            {
                label22.Text = currentCycle + " of " + "\u221e";
                label48.Text = currentCycle + " of " + "\u221e";
            }
            else
            {
                label22.Text = currentCycle + " of " + numOfCycles;
                label48.Text = currentCycle + " of " + numOfCycles;
            }

            //get all values
            protocol.processProtocol();
            //get Serial Number
            protocol.processProtocol("$0A0514");
            //get Firmware ID
            protocol.processProtocol("$0A0515");
            //get losses number
            protocol.processProtocol("$0A053D");
            //get Internal Flow
            protocol.processProtocol("$0A0531");
            //get Signal Strength
            protocol.processProtocol("$0A0512");
            //
            if(!equipment.Equals("Not Selected"))
                protocol.massEmissions(equipment,site);
            elementTable.Rows[0].Cells[1].Value = protocol.vO2;
            trendGraph.Series[0].Points.AddY(elementTable.Rows[0].Cells[1].Value);
            chart1.Series[0].Points.AddY(elementTable.Rows[0].Cells[1].Value);
            elementTable.Rows[1].Cells[1].Value = protocol.vCO;
            trendGraph.Series[1].Points.AddY(elementTable.Rows[1].Cells[1].Value);
            chart1.Series[1].Points.AddY(elementTable.Rows[1].Cells[1].Value);
            elementTable.Rows[2].Cells[1].Value = protocol.vCO2;
            trendGraph.Series[2].Points.AddY(elementTable.Rows[2].Cells[1].Value);
            chart1.Series[2].Points.AddY(elementTable.Rows[2].Cells[1].Value);
            elementTable.Rows[3].Cells[1].Value = protocol.vNO;
            trendGraph.Series[3].Points.AddY(elementTable.Rows[3].Cells[1].Value);
            chart1.Series[3].Points.AddY(elementTable.Rows[3].Cells[1].Value);
            elementTable.Rows[4].Cells[1].Value = protocol.vNO2;
            trendGraph.Series[4].Points.AddY(elementTable.Rows[4].Cells[1].Value);
            chart1.Series[4].Points.AddY(elementTable.Rows[4].Cells[1].Value);
            elementTable.Rows[5].Cells[1].Value = protocol.vNOx;
            trendGraph.Series[5].Points.AddY(elementTable.Rows[5].Cells[1].Value);
            chart1.Series[5].Points.AddY(elementTable.Rows[5].Cells[1].Value);
            elementTable.Rows[6].Cells[1].Value = protocol.vSO2;
            trendGraph.Series[6].Points.AddY(elementTable.Rows[6].Cells[1].Value);
            chart1.Series[6].Points.AddY(elementTable.Rows[6].Cells[1].Value);
            elementTable.Rows[7].Cells[1].Value = protocol.vCxHy;
            trendGraph.Series[7].Points.AddY(elementTable.Rows[7].Cells[1].Value);
            chart1.Series[7].Points.AddY(elementTable.Rows[7].Cells[1].Value);
            elementTable.Rows[8].Cells[1].Value = protocol.vTgas;
            trendGraph.Series[8].Points.AddY(elementTable.Rows[8].Cells[1].Value);
            chart1.Series[8].Points.AddY(elementTable.Rows[8].Cells[1].Value);
            elementTable.Rows[9].Cells[1].Value = protocol.vTamb;
            trendGraph.Series[9].Points.AddY(elementTable.Rows[9].Cells[1].Value);
            chart1.Series[9].Points.AddY(elementTable.Rows[9].Cells[1].Value);
            elementTable.Rows[10].Cells[1].Value = protocol.vTcell;
            trendGraph.Series[10].Points.AddY(elementTable.Rows[10].Cells[1].Value);
            chart1.Series[10].Points.AddY(elementTable.Rows[10].Cells[1].Value);
            elementTable.Rows[11].Cells[1].Value = protocol.vEfficiency;
            trendGraph.Series[11].Points.AddY(elementTable.Rows[11].Cells[1].Value);
            chart1.Series[11].Points.AddY(elementTable.Rows[11].Cells[1].Value);
            elementTable.Rows[12].Cells[1].Value = protocol.vIFlow;
            trendGraph.Series[12].Points.AddY(elementTable.Rows[12].Cells[1].Value);
            chart1.Series[12].Points.AddY(elementTable.Rows[12].Cells[1].Value);
            elementTable.Rows[13].Cells[1].Value = protocol.vDraft;
            trendGraph.Series[13].Points.AddY(elementTable.Rows[13].Cells[1].Value);
            chart1.Series[13].Points.AddY(elementTable.Rows[13].Cells[1].Value);
            elementTable.Rows[14].Cells[1].Value = protocol.vLosses;
            trendGraph.Series[14].Points.AddY(elementTable.Rows[14].Cells[1].Value);
            chart1.Series[14].Points.AddY(elementTable.Rows[14].Cells[1].Value);
            elementTable.Rows[15].Cells[1].Value = protocol.vExcessAir;
            trendGraph.Series[15].Points.AddY(elementTable.Rows[15].Cells[1].Value);
            chart1.Series[15].Points.AddY(elementTable.Rows[15].Cells[1].Value);
            elementTable.Rows[16].Cells[1].Value = protocol.vCOBtu;
            trendGraph.Series[16].Points.AddY(elementTable.Rows[16].Cells[1].Value);
            chart1.Series[16].Points.AddY(elementTable.Rows[16].Cells[1].Value);
            elementTable.Rows[17].Cells[1].Value = protocol.vNOxBtu;
            trendGraph.Series[17].Points.AddY(elementTable.Rows[17].Cells[1].Value);
            chart1.Series[17].Points.AddY(elementTable.Rows[17].Cells[1].Value);
            elementTable.Rows[18].Cells[1].Value = protocol.vCOTPY;
            trendGraph.Series[18].Points.AddY(elementTable.Rows[18].Cells[1].Value);
            chart1.Series[18].Points.AddY(elementTable.Rows[18].Cells[1].Value);
            elementTable.Rows[19].Cells[1].Value = protocol.vNOxTPY;
            trendGraph.Series[19].Points.AddY(elementTable.Rows[19].Cells[1].Value);
            chart1.Series[19].Points.AddY(elementTable.Rows[19].Cells[1].Value);
            elementTable.Rows[20].Cells[1].Value = protocol.vCOHr;
            trendGraph.Series[20].Points.AddY(elementTable.Rows[20].Cells[1].Value);
            chart1.Series[20].Points.AddY(elementTable.Rows[20].Cells[1].Value);
            elementTable.Rows[21].Cells[1].Value = protocol.vNOxHr;
            trendGraph.Series[21].Points.AddY(elementTable.Rows[21].Cells[1].Value);
            chart1.Series[21].Points.AddY(elementTable.Rows[21].Cells[1].Value);
            elementTable.Rows[22].Cells[1].Value = protocol.vCOBhp;
            trendGraph.Series[22].Points.AddY(elementTable.Rows[22].Cells[1].Value);
            chart1.Series[22].Points.AddY(elementTable.Rows[22].Cells[1].Value);
            elementTable.Rows[23].Cells[1].Value = protocol.vNOxBhp;
            trendGraph.Series[23].Points.AddY(elementTable.Rows[23].Cells[1].Value);
            chart1.Series[23].Points.AddY(elementTable.Rows[23].Cells[1].Value);
            this.serialNO_lbl.Text = protocol.vSerialNumber;
            this.iflowlbl.Text = protocol.vIFlow;
            this.Firmware_lbl.Text = protocol.vFirmware;
            //if (!lblList1[0].Item3.Enabled)
            //{
            //    for (int i = 0; i < lblList1.Count; i++)
            //        lblList1[i].Item3. = Color.Green;
            //}
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            elementTable.Rows[elementTable.RowCount - 2].Cells[2].Value = cUnit;
            elementTable.Rows[elementTable.RowCount - 1].Cells[2].Value = nUnit;
        }

        private void recordSign_Tick(object sender, EventArgs e)
        {

        }

        private void aboutAdvDASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CRSAboutBox about = new CRSAboutBox();
            about.ShowDialog();
        }

        private void blue25GrayColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TableLayoutPanel tile in tiles)
            {
                tile.BackgroundImage = CRS.Properties.Resources.ecomblu_25graybox_25grayback;
                lblList1[i].Item2.ForeColor = Color.Black;
                this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                i++;
            }
            label21.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            cycleLabel.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            rlbl.ForeColor = Color.Black;
            tlbl.ForeColor = Color.Black;
            plbl.ForeColor = Color.Black;
            rTimelbl.ForeColor = Color.Black;
            tTimelbl.ForeColor = Color.Black;
            pTimelbl.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            clock_lbl.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            recordTimeLabel.ForeColor = Color.Black;

        }
        private void blue50GrayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TableLayoutPanel tile in tiles)
            {
                tile.BackgroundImage = CRS.Properties.Resources.ecomblu_50graybox_25grayback;
                lblList1[i].Item2.ForeColor = Color.Black;
                this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                i++;
            }
        }
        private void blueWhiteColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TableLayoutPanel tile in tiles)
            {
                tile.BackgroundImage = CRS.Properties.Resources.ecomblu_whitebox_25gray;
                lblList1[i].Item2.ForeColor = Color.Black;
                this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
                i++;
            }
            label21.ForeColor = Color.Black;
            label23.ForeColor = Color.Black;
            cycleLabel.ForeColor = Color.Black;
            label22.ForeColor = Color.Black;
            rlbl.ForeColor = Color.Black;
            tlbl.ForeColor = Color.Black;
            plbl.ForeColor = Color.Black;
            rTimelbl.ForeColor = Color.Black;
            tTimelbl.ForeColor = Color.Black;
            pTimelbl.ForeColor = Color.Black;
            label14.ForeColor = Color.Black;
            clock_lbl.ForeColor = Color.Black;
            label16.ForeColor = Color.Black;
            label15.ForeColor = Color.Black;
            recordTimeLabel.ForeColor = Color.Black;
        }
        private void blueBlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (TableLayoutPanel tile in tiles)
            {
                tile.BackgroundImage = CRS.Properties.Resources.ecomblu_blackbox_black;
                lblList1[i].Item2.ForeColor = Color.White;
                this.tabPage1.BackColor = Color.Black;
                i++;
            }
            label21.ForeColor = Color.White;
            label23.ForeColor = Color.White;
            cycleLabel.ForeColor = Color.White;
            label22.ForeColor = Color.White;
            rlbl.ForeColor = Color.White;
            tlbl.ForeColor = Color.White;
            plbl.ForeColor = Color.White;
            rTimelbl.ForeColor = Color.White;
            tTimelbl.ForeColor = Color.White;
            pTimelbl.ForeColor = Color.White;
            label14.ForeColor = Color.White;
            clock_lbl.ForeColor = Color.White;
            label16.ForeColor = Color.White;
            label15.ForeColor = Color.White;
            recordTimeLabel.ForeColor = Color.White;


        }

        private void startRecordingButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (run.Equals(false))
                startRecordingButton.BackgroundImage = CRS.Properties.Resources.start_B;
            else
                startRecordingButton.BackgroundImage = CRS.Properties.Resources.pause_B;
        }

        private void startRecordingButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (run.Equals(false))
                startRecordingButton.BackgroundImage = CRS.Properties.Resources.start_A;
            else
                startRecordingButton.BackgroundImage = CRS.Properties.Resources.pause_A;
        }

        private void stopRecordingButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.stopRecordingButton.BackgroundImage = CRS.Properties.Resources.stop_B;
        }

        private void stopRecordingButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.stopRecordingButton.BackgroundImage = CRS.Properties.Resources.stop_A;
        }

        private void snapShotButton_MouseDown(object sender, MouseEventArgs e)
        {
            this.snapShotButton.BackgroundImage = CRS.Properties.Resources.snapshot_B;
        }

        private void snapShotButton_MouseUp(object sender, MouseEventArgs e)
        {
            this.snapShotButton.BackgroundImage = CRS.Properties.Resources.snapshot_A;
        }

        private void pPump_Click(object sender, EventArgs e)
        {
            protocol.processProtocol("$0F1063 0x20");
        }

        private void buzzer_Click(object sender, EventArgs e)
        {
            protocol.processProtocol("$0F1066 0x20");
        }
        private System.Drawing.Rectangle myTabRect;

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Pink);
            System.Drawing.Font font = new System.Drawing.Font("Arial", 10.0f);
            SolidBrush brush = new SolidBrush(Color.Red);

            g.DrawRectangle(p, tabArea);
            g.DrawString("tabPage1", font, brush, tabTextArea);
        }

        private void menuCalibrationItem_Click(object sender, EventArgs e)
        {
            caliForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            configProcedure = new SetUpProcedure(rampUp, testData, purge, numOfCycles, dgInterval);
            configProcedure.ShowDialog();

        }

        private void viewTestRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tRecords.ShowDialog();
        }

        private void viewSnapshotsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewSnapShots snaps = new ViewSnapShots();
            snaps.ShowDialog();

        }
        private void toolStripComboBox1_SelectedItemChanged(object sender, EventArgs e)
        {
            protocol.massEmissions(MainMenu.equipment,MainMenu.site);
            ToolStripComboBox menuItem = sender as ToolStripComboBox;
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
                        case "lTile0":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNOxHr;
                                    break;
                                case 11:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNOxTPY;
                                    break;
                                case 12:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNOxBhp;
                                    break;
                                case 13:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vNOxBtu;
                                    break;
                                case 14:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel0.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel0.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile1":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel1.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel1.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile2":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel2.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel2.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile3":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel3.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel3.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile4":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel4.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel4.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile5":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel5.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel5.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile6":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel6.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel6.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile7":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel7.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel7.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                        case "lTile8":
                            switch (toolStripComboBox1.SelectedIndex)
                            {
                                case 0:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vO2;
                                    break;
                                case 1:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCO;
                                    break;
                                case 2:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCOHr;
                                    break;
                                case 3:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCOTPY;
                                    break;
                                case 4:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCOBhp;
                                    break;
                                case 5:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCOBtu;
                                    break;
                                case 6:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCO2;
                                    break;
                                case 7:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vNO;
                                    break;
                                case 8:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vNO2;
                                    break;
                                case 9:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vNOx;
                                    break;
                                case 10:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 11:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 12:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 13:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    break;
                                case 14:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vSO2;
                                    break;
                                case 15:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vCxHy;
                                    break;
                                case 16:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vTgas;
                                    break;
                                case 17:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vTamb;
                                    break;
                                case 18:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vTcell;
                                    break;
                                case 19:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vEfficiency;
                                    break;
                                case 20:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vIFlow;
                                    break;
                                case 21:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vDraft;
                                    break;
                                case 22:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vLosses;
                                    break;
                                case 23:
                                    lTileLabel8.Text = toolStripComboBox1.SelectedItem.ToString();
                                    lLabel8.Text = protocol.vExcessAir;
                                    break;
                            }
                            break;
                    }
                }
            }
        }


        private void browseReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "Reports/";
            openFileDialog1.Filter = "pdf files (*.pdf)|*.pdf|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            // Insert code to read the stream here.
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PrintDocs pDoc = new PrintDocs();
            pDoc.printGraph(trendGraph);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //start Calibration phase
            protocol.processProtocol("$0F100740000");
            //protocol.processProtocol("$0F1006 0x20");
            //protocol.processProtocol("$0F1004 0x20");
        }

        private void resetButton_MouseDown(object sender, MouseEventArgs e)
        {
            resetButton.BackgroundImage = CRS.Properties.Resources.reset_B;
        }

        private void resetButton_MouseUp(object sender, MouseEventArgs e)
        {
            resetButton.BackgroundImage = CRS.Properties.Resources.reset_A;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = CRS.Properties.Resources.edit_prodedure_btnB;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.BackgroundImage = CRS.Properties.Resources.edit_prodedure_btnA;
        }

        private void tileButton9_EnabledChanged(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (run)
                button.ForeColor = Color.Black;
            else
                button.ForeColor = Color.Silver;
        }

        private void applyO2CorrectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string CO_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
            if (CO_C.Equals(""))
            {
                ScaleDisplay.correction = 0;
            }
            else
            {
                ScaleDisplay.correction = Convert.ToDouble(CO_C);
            }

        }
        private void Button1_EnabledChanged(object sender, System.EventArgs e)
        {
            var button = sender as Button;
            for (int i = 0; i < 12; i++)
            {
                lblList1[i].Item3.ForeColor = button.Enabled == false ? Color.Blue : Color.Red;
                //lblList1[0].Item3.BackColor = Color.AliceBlue;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.ShowDialog();
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = CRS.Properties.Resources.edit_site_B;
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.BackgroundImage = CRS.Properties.Resources.edit_site_A;
        }

        private void saveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connection connectForm = new Connection(this);
            connectForm.ShowDialog();
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Beep
            protocol.processProtocol("$0F1066 0x20");
        }

        private void recordData_Tick(object sender, EventArgs e)
        {
            new GasAnalysis().newEntry(protocol, tableName);
        }

    }
}