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
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectSiteEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.browseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performPreAndPostCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technichianCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCommunictaionPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalibrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCalibrationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCalGasInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.preTestCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postTestCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.abortCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitPurgeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStandbyModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAnalyzerStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPeristalticPumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRecordingItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTrendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllAveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.recordStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.clock_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.tilePopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.screenShotBox = new System.Windows.Forms.PictureBox();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.sTile2.SuspendLayout();
            this.tilePopUpMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.sTile9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.sTile8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.sTile7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.sTile6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.sTile1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sTile0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sTile4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.sTile3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).BeginInit();
            this.sTile5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.menuCalibrationItem,
            this.analyzeToolStripMenuItem,
            this.menuRecordingItem,
            this.viewTrendToolStripMenuItem,
            this.resetAllAveragesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectSiteEquipmentToolStripMenuItem,
            this.toolStripSeparator1,
            this.browseReportsToolStripMenuItem,
            this.advancedFunctionsToolStripMenuItem,
            this.saveReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // selectSiteEquipmentToolStripMenuItem
            // 
            this.selectSiteEquipmentToolStripMenuItem.Name = "selectSiteEquipmentToolStripMenuItem";
            this.selectSiteEquipmentToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.selectSiteEquipmentToolStripMenuItem.Text = "Select Site/Equipment";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(187, 6);
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            this.browseReportsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.browseReportsToolStripMenuItem.Text = "Browse Reports";
            // 
            // advancedFunctionsToolStripMenuItem
            // 
            this.advancedFunctionsToolStripMenuItem.Name = "advancedFunctionsToolStripMenuItem";
            this.advancedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.advancedFunctionsToolStripMenuItem.Text = "Advanced Functions";
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureRecordingToolStripMenuItem,
            this.configureReportToolStripMenuItem,
            this.performPreAndPostCalibrationToolStripMenuItem,
            this.technichianCompanyToolStripMenuItem,
            this.manageDisplayToolStripMenuItem,
            this.setupCommunictaionPortsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.configureToolStripMenuItem.Text = "Configure";
            // 
            // configureRecordingToolStripMenuItem
            // 
            this.configureRecordingToolStripMenuItem.Name = "configureRecordingToolStripMenuItem";
            this.configureRecordingToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.configureRecordingToolStripMenuItem.Text = "Configure Recording";
            // 
            // configureReportToolStripMenuItem
            // 
            this.configureReportToolStripMenuItem.Name = "configureReportToolStripMenuItem";
            this.configureReportToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.configureReportToolStripMenuItem.Text = "Configure Report";
            // 
            // performPreAndPostCalibrationToolStripMenuItem
            // 
            this.performPreAndPostCalibrationToolStripMenuItem.Name = "performPreAndPostCalibrationToolStripMenuItem";
            this.performPreAndPostCalibrationToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.performPreAndPostCalibrationToolStripMenuItem.Text = "Perform Pre and Post Calibration Procedures";
            // 
            // technichianCompanyToolStripMenuItem
            // 
            this.technichianCompanyToolStripMenuItem.Name = "technichianCompanyToolStripMenuItem";
            this.technichianCompanyToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.technichianCompanyToolStripMenuItem.Text = "Technician/Company";
            // 
            // manageDisplayToolStripMenuItem
            // 
            this.manageDisplayToolStripMenuItem.Name = "manageDisplayToolStripMenuItem";
            this.manageDisplayToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.manageDisplayToolStripMenuItem.Text = "Manage Display";
            // 
            // setupCommunictaionPortsToolStripMenuItem
            // 
            this.setupCommunictaionPortsToolStripMenuItem.Name = "setupCommunictaionPortsToolStripMenuItem";
            this.setupCommunictaionPortsToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.setupCommunictaionPortsToolStripMenuItem.Text = "Setup Communictaion Ports";
            // 
            // menuCalibrationItem
            // 
            this.menuCalibrationItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewCalibrationInfoToolStripMenuItem,
            this.enterCalGasInfoToolStripMenuItem,
            this.toolStripSeparator2,
            this.preTestCalibrationToolStripMenuItem,
            this.postTestCalibrationToolStripMenuItem,
            this.toolStripSeparator3,
            this.abortCalibrationToolStripMenuItem});
            this.menuCalibrationItem.Name = "menuCalibrationItem";
            this.menuCalibrationItem.Size = new System.Drawing.Size(77, 20);
            this.menuCalibrationItem.Text = "Calibration";
            // 
            // viewCalibrationInfoToolStripMenuItem
            // 
            this.viewCalibrationInfoToolStripMenuItem.Name = "viewCalibrationInfoToolStripMenuItem";
            this.viewCalibrationInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewCalibrationInfoToolStripMenuItem.Text = "View Calibration Info";
            // 
            // enterCalGasInfoToolStripMenuItem
            // 
            this.enterCalGasInfoToolStripMenuItem.Name = "enterCalGasInfoToolStripMenuItem";
            this.enterCalGasInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.enterCalGasInfoToolStripMenuItem.Text = "Enter Cal Gas Info";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // preTestCalibrationToolStripMenuItem
            // 
            this.preTestCalibrationToolStripMenuItem.Name = "preTestCalibrationToolStripMenuItem";
            this.preTestCalibrationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.preTestCalibrationToolStripMenuItem.Text = "Pre-Test Calibration";
            // 
            // postTestCalibrationToolStripMenuItem
            // 
            this.postTestCalibrationToolStripMenuItem.Name = "postTestCalibrationToolStripMenuItem";
            this.postTestCalibrationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.postTestCalibrationToolStripMenuItem.Text = "Post-Test Calibration";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(182, 6);
            // 
            // abortCalibrationToolStripMenuItem
            // 
            this.abortCalibrationToolStripMenuItem.Name = "abortCalibrationToolStripMenuItem";
            this.abortCalibrationToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.abortCalibrationToolStripMenuItem.Text = "Abort Calibration";
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitPurgeModeToolStripMenuItem,
            this.exitStandbyModeToolStripMenuItem,
            this.viewAnalyzerStatusToolStripMenuItem,
            this.beepToolStripMenuItem,
            this.startPeristalticPumpToolStripMenuItem});
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.analyzeToolStripMenuItem.Text = "Analyzer Control";
            // 
            // exitPurgeModeToolStripMenuItem
            // 
            this.exitPurgeModeToolStripMenuItem.Name = "exitPurgeModeToolStripMenuItem";
            this.exitPurgeModeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitPurgeModeToolStripMenuItem.Text = "Exit Purge Mode";
            // 
            // exitStandbyModeToolStripMenuItem
            // 
            this.exitStandbyModeToolStripMenuItem.Name = "exitStandbyModeToolStripMenuItem";
            this.exitStandbyModeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.exitStandbyModeToolStripMenuItem.Text = "Exit Standby Mode";
            // 
            // viewAnalyzerStatusToolStripMenuItem
            // 
            this.viewAnalyzerStatusToolStripMenuItem.Name = "viewAnalyzerStatusToolStripMenuItem";
            this.viewAnalyzerStatusToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.viewAnalyzerStatusToolStripMenuItem.Text = "View Analyzer Status";
            // 
            // beepToolStripMenuItem
            // 
            this.beepToolStripMenuItem.Name = "beepToolStripMenuItem";
            this.beepToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.beepToolStripMenuItem.Text = "Beep";
            // 
            // startPeristalticPumpToolStripMenuItem
            // 
            this.startPeristalticPumpToolStripMenuItem.Name = "startPeristalticPumpToolStripMenuItem";
            this.startPeristalticPumpToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.startPeristalticPumpToolStripMenuItem.Text = "Start Peristaltic Pump";
            // 
            // menuRecordingItem
            // 
            this.menuRecordingItem.Image = global::AdvDAS.Properties.Resources.play;
            this.menuRecordingItem.Name = "menuRecordingItem";
            this.menuRecordingItem.Size = new System.Drawing.Size(116, 20);
            this.menuRecordingItem.Tag = "";
            this.menuRecordingItem.Text = "Start Recording";
            this.menuRecordingItem.Click += new System.EventHandler(this.menuRecording_Click);
            // 
            // viewTrendToolStripMenuItem
            // 
            this.viewTrendToolStripMenuItem.Name = "viewTrendToolStripMenuItem";
            this.viewTrendToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.viewTrendToolStripMenuItem.Text = "View Trend";
            this.viewTrendToolStripMenuItem.Click += new System.EventHandler(this.viewTrendToolStripMenuItem_Click);
            // 
            // resetAllAveragesToolStripMenuItem
            // 
            this.resetAllAveragesToolStripMenuItem.Name = "resetAllAveragesToolStripMenuItem";
            this.resetAllAveragesToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.resetAllAveragesToolStripMenuItem.Text = "Reset All Averages";
            this.resetAllAveragesToolStripMenuItem.ToolTipText = "Resets the values";
            this.resetAllAveragesToolStripMenuItem.Click += new System.EventHandler(this.resetAllAveragesToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recordStatusLabel,
            this.recordTimeLabel,
            this.recordingProgressBar,
            this.clock_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 491);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(804, 24);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // recordStatusLabel
            // 
            this.recordStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.recordStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.recordStatusLabel.Name = "recordStatusLabel";
            this.recordStatusLabel.Size = new System.Drawing.Size(176, 19);
            this.recordStatusLabel.Text = "Ready To Begin Pre-Calibration";
            // 
            // recordTimeLabel
            // 
            this.recordTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.recordTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.recordTimeLabel.Name = "recordTimeLabel";
            this.recordTimeLabel.Size = new System.Drawing.Size(88, 19);
            this.recordTimeLabel.Text = "REC = 00:00:00";
            // 
            // recordingProgressBar
            // 
            this.recordingProgressBar.Maximum = 12;
            this.recordingProgressBar.Name = "recordingProgressBar";
            this.recordingProgressBar.Size = new System.Drawing.Size(200, 18);
            // 
            // clock_lbl
            // 
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(0, 19);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(314, 117);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.sTile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 0, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.6167F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.04497F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(804, 467);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // sTile2
            // 
            this.sTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile2.ColumnCount = 1;
            this.sTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile2.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile2.Controls.Add(this.label23, 0, 2);
            this.sTile2.Controls.Add(this.textBox3, 0, 1);
            this.sTile2.Controls.Add(this.label13, 0, 4);
            this.sTile2.Controls.Add(this.textBox13, 0, 3);
            this.sTile2.Controls.Add(this.panel3, 0, 0);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile2.Location = new System.Drawing.Point(330, 10);
            this.sTile2.Margin = new System.Windows.Forms.Padding(10);
            this.sTile2.Name = "sTile2";
            this.sTile2.RowCount = 5;
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62645F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.90712F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58455F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.2741F));
            this.sTile2.Size = new System.Drawing.Size(140, 151);
            this.sTile2.TabIndex = 4;
            // 
            // tilePopUpMenu
            // 
            this.tilePopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDisplayToolStripMenuItem,
            this.hidePanelMenuItem,
            this.getSourceToolStripMenuItem});
            this.tilePopUpMenu.Name = "panelPopUpMenu";
            this.tilePopUpMenu.Size = new System.Drawing.Size(166, 70);
            // 
            // editDisplayToolStripMenuItem
            // 
            this.editDisplayToolStripMenuItem.Name = "editDisplayToolStripMenuItem";
            this.editDisplayToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.editDisplayToolStripMenuItem.Text = "Edit Display";
            this.editDisplayToolStripMenuItem.Click += new System.EventHandler(this.editDisplayToolStripMenuItem_Click);
            // 
            // hidePanelMenuItem
            // 
            this.hidePanelMenuItem.Name = "hidePanelMenuItem";
            this.hidePanelMenuItem.Size = new System.Drawing.Size(165, 22);
            this.hidePanelMenuItem.Text = "Hide This Display";
            this.hidePanelMenuItem.Click += new System.EventHandler(this.hidePanelMenuItem_Click);
            // 
            // getSourceToolStripMenuItem
            // 
            this.getSourceToolStripMenuItem.Name = "getSourceToolStripMenuItem";
            this.getSourceToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.getSourceToolStripMenuItem.Text = "GetSource";
            this.getSourceToolStripMenuItem.Click += new System.EventHandler(this.getSourceToolStripMenuItem_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 65);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(134, 25);
            this.label23.TabIndex = 10;
            this.label23.Text = "CURRENT";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox3.Location = new System.Drawing.Point(3, 32);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(134, 29);
            this.textBox3.TabIndex = 1;
            this.textBox3.TabStop = false;
            this.textBox3.Text = "TEST";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 124);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label13.Size = new System.Drawing.Size(134, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "AVERAGE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox13
            // 
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox13.Location = new System.Drawing.Point(3, 93);
            this.textBox13.Name = "textBox13";
            this.textBox13.ReadOnly = true;
            this.textBox13.Size = new System.Drawing.Size(134, 29);
            this.textBox13.TabIndex = 3;
            this.textBox13.TabStop = false;
            this.textBox13.Text = "20.8%";
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(140, 29);
            this.panel3.TabIndex = 7;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox2.Location = new System.Drawing.Point(125, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 29);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "LABEL3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile9.ColumnCount = 1;
            this.sTile9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile9.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile9.Controls.Add(this.textBox10, 0, 1);
            this.sTile9.Controls.Add(this.label30, 0, 2);
            this.sTile9.Controls.Add(this.label20, 0, 4);
            this.sTile9.Controls.Add(this.textBox20, 0, 3);
            this.sTile9.Controls.Add(this.panel11, 0, 0);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile9.Location = new System.Drawing.Point(650, 181);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 5;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile9.Size = new System.Drawing.Size(144, 153);
            this.sTile9.TabIndex = 19;
            // 
            // textBox10
            // 
            this.textBox10.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox10.Location = new System.Drawing.Point(3, 33);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(138, 29);
            this.textBox10.TabIndex = 1;
            this.textBox10.TabStop = false;
            this.textBox10.Text = "TEST";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(138, 25);
            this.label30.TabIndex = 17;
            this.label30.Text = "CURRENT";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(3, 125);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label20.Size = new System.Drawing.Size(138, 28);
            this.label20.TabIndex = 4;
            this.label20.Text = "AVERAGE";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox20
            // 
            this.textBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox20.Enabled = false;
            this.textBox20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox20.Location = new System.Drawing.Point(3, 94);
            this.textBox20.Name = "textBox20";
            this.textBox20.ReadOnly = true;
            this.textBox20.Size = new System.Drawing.Size(138, 29);
            this.textBox20.TabIndex = 3;
            this.textBox20.TabStop = false;
            this.textBox20.Text = "20.8%";
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.checkBox9);
            this.panel11.Controls.Add(this.label10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(144, 30);
            this.panel11.TabIndex = 7;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox9.Location = new System.Drawing.Point(129, 0);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 30);
            this.checkBox9.TabIndex = 3;
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 26);
            this.label10.TabIndex = 0;
            this.label10.Text = "LABEL10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile8.ColumnCount = 1;
            this.sTile8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile8.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile8.Controls.Add(this.textBox19, 0, 3);
            this.sTile8.Controls.Add(this.textBox9, 0, 1);
            this.sTile8.Controls.Add(this.label29, 0, 2);
            this.sTile8.Controls.Add(this.label19, 0, 4);
            this.sTile8.Controls.Add(this.panel10, 0, 0);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile8.Location = new System.Drawing.Point(490, 181);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 5;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.64965F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93393F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.62663F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.5025F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.28729F));
            this.sTile8.Size = new System.Drawing.Size(140, 153);
            this.sTile8.TabIndex = 18;
            // 
            // textBox19
            // 
            this.textBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox19.Enabled = false;
            this.textBox19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox19.Location = new System.Drawing.Point(3, 94);
            this.textBox19.Name = "textBox19";
            this.textBox19.ReadOnly = true;
            this.textBox19.Size = new System.Drawing.Size(134, 29);
            this.textBox19.TabIndex = 3;
            this.textBox19.TabStop = false;
            this.textBox19.Text = "20.8%";
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox9.Location = new System.Drawing.Point(3, 33);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(134, 29);
            this.textBox9.TabIndex = 1;
            this.textBox9.TabStop = false;
            this.textBox9.Text = "TEST";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(134, 25);
            this.label29.TabIndex = 16;
            this.label29.Text = "CURRENT";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 125);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label19.Size = new System.Drawing.Size(134, 28);
            this.label19.TabIndex = 4;
            this.label19.Text = "AVERAGE";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label9);
            this.panel10.Controls.Add(this.checkBox8);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(140, 30);
            this.panel10.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "LABEL9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox8.Location = new System.Drawing.Point(125, 0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 30);
            this.checkBox8.TabIndex = 2;
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // sTile7
            // 
            this.sTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile7.ColumnCount = 1;
            this.sTile7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile7.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile7.Controls.Add(this.textBox8, 0, 1);
            this.sTile7.Controls.Add(this.label18, 0, 4);
            this.sTile7.Controls.Add(this.textBox18, 0, 3);
            this.sTile7.Controls.Add(this.panel9, 0, 0);
            this.sTile7.Controls.Add(this.label28, 0, 2);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile7.Location = new System.Drawing.Point(330, 181);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 5;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile7.Size = new System.Drawing.Size(140, 153);
            this.sTile7.TabIndex = 17;
            // 
            // textBox8
            // 
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox8.Location = new System.Drawing.Point(3, 33);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(134, 29);
            this.textBox8.TabIndex = 1;
            this.textBox8.TabStop = false;
            this.textBox8.Text = "TEST";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 125);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label18.Size = new System.Drawing.Size(134, 28);
            this.label18.TabIndex = 4;
            this.label18.Text = "AVERAGE";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox18
            // 
            this.textBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox18.Location = new System.Drawing.Point(3, 94);
            this.textBox18.Name = "textBox18";
            this.textBox18.ReadOnly = true;
            this.textBox18.Size = new System.Drawing.Size(134, 29);
            this.textBox18.TabIndex = 3;
            this.textBox18.TabStop = false;
            this.textBox18.Text = "20.8%";
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.checkBox7);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(140, 30);
            this.panel9.TabIndex = 7;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox7.Location = new System.Drawing.Point(125, 0);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 30);
            this.checkBox7.TabIndex = 5;
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "LABEL8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 66);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(134, 25);
            this.label28.TabIndex = 15;
            this.label28.Text = "CURRENT";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile6
            // 
            this.sTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile6.ColumnCount = 1;
            this.sTile6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile6.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile6.Controls.Add(this.textBox7, 0, 1);
            this.sTile6.Controls.Add(this.label27, 0, 2);
            this.sTile6.Controls.Add(this.label17, 0, 4);
            this.sTile6.Controls.Add(this.textBox17, 0, 3);
            this.sTile6.Controls.Add(this.panel8, 0, 0);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile6.Location = new System.Drawing.Point(170, 181);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 5;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile6.Size = new System.Drawing.Size(140, 153);
            this.sTile6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox7.Location = new System.Drawing.Point(3, 33);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(134, 29);
            this.textBox7.TabIndex = 1;
            this.textBox7.TabStop = false;
            this.textBox7.Text = "TEST";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 25);
            this.label27.TabIndex = 14;
            this.label27.Text = "CURRENT";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 125);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label17.Size = new System.Drawing.Size(134, 28);
            this.label17.TabIndex = 4;
            this.label17.Text = "AVERAGE";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox17
            // 
            this.textBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox17.Enabled = false;
            this.textBox17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox17.Location = new System.Drawing.Point(3, 94);
            this.textBox17.Name = "textBox17";
            this.textBox17.ReadOnly = true;
            this.textBox17.Size = new System.Drawing.Size(134, 29);
            this.textBox17.TabIndex = 3;
            this.textBox17.TabStop = false;
            this.textBox17.Text = "20.8%";
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label7);
            this.panel8.Controls.Add(this.checkBox6);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 30);
            this.panel8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "LABEL7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox6.Location = new System.Drawing.Point(125, 0);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 30);
            this.checkBox6.TabIndex = 4;
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // sTile1
            // 
            this.sTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile1.ColumnCount = 1;
            this.sTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile1.Controls.Add(this.textBox2, 0, 1);
            this.sTile1.Controls.Add(this.label12, 0, 4);
            this.sTile1.Controls.Add(this.textBox12, 0, 3);
            this.sTile1.Controls.Add(this.panel2, 0, 0);
            this.sTile1.Controls.Add(this.label22, 0, 2);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile1.Location = new System.Drawing.Point(170, 10);
            this.sTile1.Margin = new System.Windows.Forms.Padding(10);
            this.sTile1.Name = "sTile1";
            this.sTile1.RowCount = 5;
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62645F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.90712F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58455F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.2741F));
            this.sTile1.Size = new System.Drawing.Size(140, 151);
            this.sTile1.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox2.Location = new System.Drawing.Point(3, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(134, 29);
            this.textBox2.TabIndex = 1;
            this.textBox2.TabStop = false;
            this.textBox2.Text = "TEST";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 124);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(134, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "AVERAGE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox12
            // 
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox12.Location = new System.Drawing.Point(3, 93);
            this.textBox12.Name = "textBox12";
            this.textBox12.ReadOnly = true;
            this.textBox12.Size = new System.Drawing.Size(134, 29);
            this.textBox12.TabIndex = 3;
            this.textBox12.TabStop = false;
            this.textBox12.Text = "20.8%";
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 29);
            this.panel2.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(125, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 29);
            this.checkBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkBox1, "Stops From Displaying in Report");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "LABEL2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 65);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "CURRENT";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile0
            // 
            this.sTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile0.ColumnCount = 1;
            this.sTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile0.Controls.Add(this.textBox1, 0, 1);
            this.sTile0.Controls.Add(this.label11, 0, 4);
            this.sTile0.Controls.Add(this.textBox11, 0, 3);
            this.sTile0.Controls.Add(this.panel1, 0, 0);
            this.sTile0.Controls.Add(this.label21, 0, 2);
            this.sTile0.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile0.Location = new System.Drawing.Point(10, 10);
            this.sTile0.Margin = new System.Windows.Forms.Padding(10);
            this.sTile0.Name = "sTile0";
            this.sTile0.RowCount = 5;
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62566F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91303F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60627F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58453F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27052F));
            this.sTile0.Size = new System.Drawing.Size(140, 151);
            this.sTile0.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(3, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(134, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "TEST";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 124);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(134, 27);
            this.label11.TabIndex = 4;
            this.label11.Text = "AVERAGE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox11.Location = new System.Drawing.Point(3, 93);
            this.textBox11.Name = "textBox11";
            this.textBox11.ReadOnly = true;
            this.textBox11.Size = new System.Drawing.Size(134, 29);
            this.textBox11.TabIndex = 3;
            this.textBox11.TabStop = false;
            this.textBox11.Text = "20.8%";
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox0);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 29);
            this.panel1.TabIndex = 7;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox0.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox0.Location = new System.Drawing.Point(125, 0);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(15, 29);
            this.checkBox0.TabIndex = 1;
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LABEL1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 65);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "CURRENT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile4.ColumnCount = 1;
            this.sTile4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile4.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile4.Controls.Add(this.textBox5, 0, 1);
            this.sTile4.Controls.Add(this.label15, 0, 4);
            this.sTile4.Controls.Add(this.textBox15, 0, 3);
            this.sTile4.Controls.Add(this.label25, 0, 2);
            this.sTile4.Controls.Add(this.panel7, 0, 0);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile4.Location = new System.Drawing.Point(650, 10);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 5;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile4.Size = new System.Drawing.Size(144, 151);
            this.sTile4.TabIndex = 13;
            this.sTile4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sTile4_MouseClick);
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox5.Location = new System.Drawing.Point(3, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(138, 29);
            this.textBox5.TabIndex = 1;
            this.textBox5.TabStop = false;
            this.textBox5.Text = "TEST";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 124);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label15.Size = new System.Drawing.Size(138, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "AVERAGE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox15
            // 
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Enabled = false;
            this.textBox15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox15.Location = new System.Drawing.Point(3, 93);
            this.textBox15.Name = "textBox15";
            this.textBox15.ReadOnly = true;
            this.textBox15.Size = new System.Drawing.Size(138, 29);
            this.textBox15.TabIndex = 3;
            this.textBox15.TabStop = false;
            this.textBox15.Text = "20.8%";
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(138, 25);
            this.label25.TabIndex = 12;
            this.label25.Text = "CURRENT";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBox4);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(144, 29);
            this.panel7.TabIndex = 7;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox4.Location = new System.Drawing.Point(129, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 29);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "LABEL5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sTile3
            // 
            this.sTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile3.ColumnCount = 1;
            this.sTile3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile3.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile3.Controls.Add(this.textBox4, 0, 1);
            this.sTile3.Controls.Add(this.label14, 0, 4);
            this.sTile3.Controls.Add(this.textBox14, 0, 3);
            this.sTile3.Controls.Add(this.panel6, 0, 0);
            this.sTile3.Controls.Add(this.label24, 0, 2);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile3.Location = new System.Drawing.Point(490, 10);
            this.sTile3.Margin = new System.Windows.Forms.Padding(10);
            this.sTile3.Name = "sTile3";
            this.sTile3.RowCount = 5;
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile3.Size = new System.Drawing.Size(140, 151);
            this.sTile3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox4.Location = new System.Drawing.Point(3, 32);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(134, 29);
            this.textBox4.TabIndex = 1;
            this.textBox4.TabStop = false;
            this.textBox4.Text = "TEST";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 124);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(134, 27);
            this.label14.TabIndex = 4;
            this.label14.Text = "AVERAGE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox14
            // 
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox14.Location = new System.Drawing.Point(3, 93);
            this.textBox14.Name = "textBox14";
            this.textBox14.ReadOnly = true;
            this.textBox14.Size = new System.Drawing.Size(134, 29);
            this.textBox14.TabIndex = 3;
            this.textBox14.TabStop = false;
            this.textBox14.Text = "20.8%";
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox3);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 29);
            this.panel6.TabIndex = 7;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox3.Location = new System.Drawing.Point(125, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 29);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "LABEL4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 65);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 25);
            this.label24.TabIndex = 11;
            this.label24.Text = "CURRENT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button2, 2);
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(323, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(314, 117);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.screenShotBox);
            this.panel4.Controls.Add(this.btnSnapShot);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(660, 349);
            this.panel4.Margin = new System.Windows.Forms.Padding(20, 5, 20, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(124, 113);
            this.panel4.TabIndex = 10;
            // 
            // screenShotBox
            // 
            this.screenShotBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenShotBox.Location = new System.Drawing.Point(0, 0);
            this.screenShotBox.Name = "screenShotBox";
            this.screenShotBox.Size = new System.Drawing.Size(124, 90);
            this.screenShotBox.TabIndex = 1;
            this.screenShotBox.TabStop = false;
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.AutoSize = true;
            this.btnSnapShot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSnapShot.Location = new System.Drawing.Point(0, 90);
            this.btnSnapShot.Margin = new System.Windows.Forms.Padding(78);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(124, 23);
            this.btnSnapShot.TabIndex = 0;
            this.btnSnapShot.Text = "SnapShot";
            this.btnSnapShot.UseVisualStyleBackColor = true;
            this.btnSnapShot.Click += new System.EventHandler(this.btnSnapShot_Click);
            // 
            // sTile5
            // 
            this.sTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile5.ColumnCount = 1;
            this.sTile5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile5.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile5.Controls.Add(this.textBox6, 0, 1);
            this.sTile5.Controls.Add(this.label16, 0, 4);
            this.sTile5.Controls.Add(this.label26, 0, 2);
            this.sTile5.Controls.Add(this.textBox16, 0, 3);
            this.sTile5.Controls.Add(this.panel5, 0, 0);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile5.Location = new System.Drawing.Point(10, 181);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 5;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.63F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.91F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.61F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.27F));
            this.sTile5.Size = new System.Drawing.Size(140, 153);
            this.sTile5.TabIndex = 11;
            // 
            // textBox6
            // 
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox6.Location = new System.Drawing.Point(3, 33);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(134, 29);
            this.textBox6.TabIndex = 1;
            this.textBox6.TabStop = false;
            this.textBox6.Text = "TEST";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 125);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label16.Size = new System.Drawing.Size(134, 28);
            this.label16.TabIndex = 4;
            this.label16.Text = "AVERAGE";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(134, 25);
            this.label26.TabIndex = 13;
            this.label26.Text = "CURRENT";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox16
            // 
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Enabled = false;
            this.textBox16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox16.Location = new System.Drawing.Point(3, 94);
            this.textBox16.Name = "textBox16";
            this.textBox16.ReadOnly = true;
            this.textBox16.Size = new System.Drawing.Size(134, 29);
            this.textBox16.TabIndex = 3;
            this.textBox16.TabStop = false;
            this.textBox16.Text = "20.8%";
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(140, 30);
            this.panel5.TabIndex = 7;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox5.Location = new System.Drawing.Point(125, 0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 30);
            this.checkBox5.TabIndex = 6;
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "LABEL6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 515);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.sTile2.ResumeLayout(false);
            this.sTile2.PerformLayout();
            this.tilePopUpMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.sTile9.ResumeLayout(false);
            this.sTile9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.sTile8.ResumeLayout(false);
            this.sTile8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.sTile7.ResumeLayout(false);
            this.sTile7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.sTile6.ResumeLayout(false);
            this.sTile6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.sTile1.ResumeLayout(false);
            this.sTile1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sTile0.ResumeLayout(false);
            this.sTile0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sTile4.ResumeLayout(false);
            this.sTile4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.sTile3.ResumeLayout(false);
            this.sTile3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).EndInit();
            this.sTile5.ResumeLayout(false);
            this.sTile5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.ContextMenuStrip tilePopUpMenu;
        private System.Windows.Forms.PictureBox screenShotBox;
        


        ////////////////////////////////////////LABELS//////////////////////////////////////////
        
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;

        //////////////////////////////////////////PANELS/////////////////////////////////////////
        
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10; 
        private System.Windows.Forms.Panel panel11;

        //////////////////////////////////////////TOOLSTRIPMENUITEMS/////////////////////////////////////////

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCalibrationItem;
        private System.Windows.Forms.ToolStripMenuItem menuRecordingItem;
        private System.Windows.Forms.ToolStripMenuItem viewTrendToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllAveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar recordingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel recordTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel recordStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel clock_lbl;
        private System.Windows.Forms.ToolStripMenuItem hidePanelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectSiteEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem browseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performPreAndPostCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technichianCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCommunictaionPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCalibrationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCalGasInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem preTestCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postTestCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem abortCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitPurgeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitStandbyModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAnalyzerStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startPeristalticPumpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;


        //////////////////////////////////////////CHECKBOXES/////////////////////////////////////////

        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox0;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox1;

        //////////////////////////////////////////TEXTBOXS/////////////////////////////////////////

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        
        //////////////////////////////////////////TABLELAYOUTPANELS/////////////////////////////////////////

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel sTile0;
        private System.Windows.Forms.TableLayoutPanel sTile1;
        private System.Windows.Forms.TableLayoutPanel sTile2;
        private System.Windows.Forms.TableLayoutPanel sTile3;
        private System.Windows.Forms.TableLayoutPanel sTile4;
        private System.Windows.Forms.TableLayoutPanel sTile5;
        private System.Windows.Forms.TableLayoutPanel sTile6;
        private System.Windows.Forms.TableLayoutPanel sTile7;
        private System.Windows.Forms.TableLayoutPanel sTile8;
        private System.Windows.Forms.TableLayoutPanel sTile9;


        //////////////////////////////////////////BUTTONS/////////////////////////////////////////

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSnapShot;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolStripMenuItem getSourceToolStripMenuItem;
        private ToolTip toolTip1;



    }
}

