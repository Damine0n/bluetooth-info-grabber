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
namespace CRS
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
            this.browseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupEquipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllAveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAdvDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.clock_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tilePopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hidePanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getSourceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox0 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bigPanel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.screenShotBox = new System.Windows.Forms.PictureBox();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.bigPanel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tilePopUpMenu.SuspendLayout();
            this.sTile5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.sTile3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.sTile4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.sTile0.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sTile1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sTile6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.sTile7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.sTile8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.sTile9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.sTile2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupEquipmentSiteToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.menuCalibrationItem,
            this.analyzeToolStripMenuItem,
            this.menuRecordingItem,
            this.graphToolStripMenuItem,
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
            this.browseReportsToolStripMenuItem,
            this.advancedFunctionsToolStripMenuItem,
            this.saveReportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            this.browseReportsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.browseReportsToolStripMenuItem.Text = "Browse Reports";
            // 
            // advancedFunctionsToolStripMenuItem
            // 
            this.advancedFunctionsToolStripMenuItem.Name = "advancedFunctionsToolStripMenuItem";
            this.advancedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.advancedFunctionsToolStripMenuItem.Text = "Advanced Functions";
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // setupEquipmentSiteToolStripMenuItem
            // 
            this.setupEquipmentSiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.equipmentSiteToolStripMenuItem});
            this.setupEquipmentSiteToolStripMenuItem.Name = "setupEquipmentSiteToolStripMenuItem";
            this.setupEquipmentSiteToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.setupEquipmentSiteToolStripMenuItem.Text = "Edit";
            // 
            // personalDataToolStripMenuItem
            // 
            this.personalDataToolStripMenuItem.Name = "personalDataToolStripMenuItem";
            this.personalDataToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.personalDataToolStripMenuItem.Text = "Personal Data";
            this.personalDataToolStripMenuItem.Click += new System.EventHandler(this.personalDataToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // equipmentSiteToolStripMenuItem
            // 
            this.equipmentSiteToolStripMenuItem.Name = "equipmentSiteToolStripMenuItem";
            this.equipmentSiteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.equipmentSiteToolStripMenuItem.Text = "Equipment/Site";
            this.equipmentSiteToolStripMenuItem.Click += new System.EventHandler(this.equipmentSiteToolStripMenuItem_Click);
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
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.configureToolStripMenuItem.Text = "Procedures";
            // 
            // configureRecordingToolStripMenuItem
            // 
            this.configureRecordingToolStripMenuItem.Name = "configureRecordingToolStripMenuItem";
            this.configureRecordingToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.configureRecordingToolStripMenuItem.Text = "Set-Up Procedure";
            this.configureRecordingToolStripMenuItem.Click += new System.EventHandler(this.configureRecordingToolStripMenuItem_Click);
            // 
            // configureReportToolStripMenuItem
            // 
            this.configureReportToolStripMenuItem.Name = "configureReportToolStripMenuItem";
            this.configureReportToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.configureReportToolStripMenuItem.Text = "Set-Up Report";
            this.configureReportToolStripMenuItem.Click += new System.EventHandler(this.configureReportToolStripMenuItem_Click);
            // 
            // performPreAndPostCalibrationToolStripMenuItem
            // 
            this.performPreAndPostCalibrationToolStripMenuItem.Checked = true;
            this.performPreAndPostCalibrationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.performPreAndPostCalibrationToolStripMenuItem.Enabled = false;
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
            this.postTestCalibrationToolStripMenuItem.Enabled = false;
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
            this.menuRecordingItem.Image = global::CRS.Properties.Resources.play;
            this.menuRecordingItem.Name = "menuRecordingItem";
            this.menuRecordingItem.Size = new System.Drawing.Size(116, 20);
            this.menuRecordingItem.Tag = "";
            this.menuRecordingItem.Text = "Start Recording";
            this.menuRecordingItem.Click += new System.EventHandler(this.menuRecording_Click);
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.graphToolStripMenuItem.Text = "Graph";
            this.graphToolStripMenuItem.Click += new System.EventHandler(this.graphToolStripMenuItem_Click);
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
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpgradeToolStripMenuItem,
            this.aboutAdvDASToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkUpgradeToolStripMenuItem
            // 
            this.checkUpgradeToolStripMenuItem.Name = "checkUpgradeToolStripMenuItem";
            this.checkUpgradeToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.checkUpgradeToolStripMenuItem.Text = "Check Upgrade";
            // 
            // aboutAdvDASToolStripMenuItem
            // 
            this.aboutAdvDASToolStripMenuItem.Name = "aboutAdvDASToolStripMenuItem";
            this.aboutAdvDASToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.aboutAdvDASToolStripMenuItem.Text = "About AdvDAS";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel,
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
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.connectionStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(92, 19);
            this.connectionStatusLabel.Text = "Not Connected";
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
            this.recordTimeLabel.Size = new System.Drawing.Size(141, 19);
            this.recordTimeLabel.Text = "REC = (00:00:00) 00:00:00";
            // 
            // recordingProgressBar
            // 
            this.recordingProgressBar.Maximum = 20;
            this.recordingProgressBar.Name = "recordingProgressBar";
            this.recordingProgressBar.Size = new System.Drawing.Size(250, 18);
            // 
            // clock_lbl
            // 
            this.clock_lbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.clock_lbl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clock_lbl.Size = new System.Drawing.Size(91, 19);
            this.clock_lbl.Text = "The Time & Date";
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
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox5.Location = new System.Drawing.Point(125, 0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 33);
            this.checkBox5.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox5, "Click to disable in report");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox3.Location = new System.Drawing.Point(125, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 32);
            this.checkBox3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.checkBox3, "Click to disable in report");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox4.Location = new System.Drawing.Point(129, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 32);
            this.checkBox4.TabIndex = 7;
            this.toolTip1.SetToolTip(this.checkBox4, "Click to disable in report");
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox0.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox0.Location = new System.Drawing.Point(125, 0);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(15, 32);
            this.checkBox0.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox0, "Click to disable in report");
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(125, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 32);
            this.checkBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkBox1, "Click to disable in report");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox6.Location = new System.Drawing.Point(125, 0);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 33);
            this.checkBox6.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox6, "Click to disable in report");
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox7.Location = new System.Drawing.Point(125, 0);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 33);
            this.checkBox7.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkBox7, "Click to disable in report");
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox8.Location = new System.Drawing.Point(125, 0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 33);
            this.checkBox8.TabIndex = 2;
            this.toolTip1.SetToolTip(this.checkBox8, "Click to disable in report");
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox9.Location = new System.Drawing.Point(129, 0);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 33);
            this.checkBox9.TabIndex = 3;
            this.toolTip1.SetToolTip(this.checkBox9, "Click to disable in report");
            this.checkBox9.UseVisualStyleBackColor = true;
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
            this.toolTip1.SetToolTip(this.checkBox2, "Click to disable in report");
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox6.Location = new System.Drawing.Point(3, 36);
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
            this.panel5.Size = new System.Drawing.Size(140, 33);
            this.panel5.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "NOx";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox4.Location = new System.Drawing.Point(3, 35);
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
            this.label14.Location = new System.Drawing.Point(3, 123);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(134, 28);
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
            this.textBox14.Location = new System.Drawing.Point(3, 92);
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
            this.panel6.Size = new System.Drawing.Size(140, 32);
            this.panel6.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "NO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 64);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(134, 25);
            this.label24.TabIndex = 11;
            this.label24.Text = "CURRENT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile4.Size = new System.Drawing.Size(144, 151);
            this.sTile4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox5.Location = new System.Drawing.Point(3, 35);
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
            this.label15.Location = new System.Drawing.Point(3, 123);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label15.Size = new System.Drawing.Size(138, 28);
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
            this.textBox15.Location = new System.Drawing.Point(3, 92);
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
            this.label25.Location = new System.Drawing.Point(3, 64);
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
            this.panel7.Size = new System.Drawing.Size(144, 32);
            this.panel7.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "NO2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65634F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65634F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67274F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67493F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33965F));
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
            this.textBox1.Location = new System.Drawing.Point(3, 35);
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
            this.label11.Location = new System.Drawing.Point(3, 123);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(134, 28);
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
            this.textBox11.Location = new System.Drawing.Point(3, 92);
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
            this.panel1.Size = new System.Drawing.Size(140, 32);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "O2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 64);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(134, 25);
            this.label21.TabIndex = 8;
            this.label21.Text = "CURRENT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67339F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67379F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34236F));
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
            this.textBox2.Location = new System.Drawing.Point(3, 35);
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
            this.label12.Location = new System.Drawing.Point(3, 123);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(134, 28);
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
            this.textBox12.Location = new System.Drawing.Point(3, 92);
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
            this.panel2.Size = new System.Drawing.Size(140, 32);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "CO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(134, 25);
            this.label22.TabIndex = 9;
            this.label22.Text = "CURRENT";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox7.Location = new System.Drawing.Point(3, 36);
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
            this.panel8.Controls.Add(this.checkBox6);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(140, 33);
            this.panel8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "SO2";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox8.Location = new System.Drawing.Point(3, 36);
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
            this.panel9.Size = new System.Drawing.Size(140, 33);
            this.panel9.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "CxHy";
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
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66611F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66611F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70071F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.60276F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36431F));
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
            this.textBox9.Location = new System.Drawing.Point(3, 36);
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
            this.panel10.Controls.Add(this.checkBox8);
            this.panel10.Controls.Add(this.label9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(140, 33);
            this.panel10.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "T(gas)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65585F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65585F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67717F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67131F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33983F));
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
            this.textBox10.Location = new System.Drawing.Point(3, 36);
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
            this.panel11.Size = new System.Drawing.Size(144, 33);
            this.panel11.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "T(amb)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "CO2";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tableLayoutPanel1.Controls.Add(this.bigPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bigPanel2, 3, 2);
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
            // bigPanel1
            // 
            this.bigPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.bigPanel1, 2);
            this.bigPanel1.ContextMenuStrip = this.tilePopUpMenu;
            this.bigPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigPanel1.Location = new System.Drawing.Point(3, 347);
            this.bigPanel1.Name = "bigPanel1";
            this.bigPanel1.Size = new System.Drawing.Size(314, 117);
            this.bigPanel1.TabIndex = 22;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.screenShotBox);
            this.panel4.Controls.Add(this.btnSnapShot);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(323, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(154, 117);
            this.panel4.TabIndex = 20;
            // 
            // screenShotBox
            // 
            this.screenShotBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenShotBox.Location = new System.Drawing.Point(0, 0);
            this.screenShotBox.Name = "screenShotBox";
            this.screenShotBox.Size = new System.Drawing.Size(154, 94);
            this.screenShotBox.TabIndex = 1;
            this.screenShotBox.TabStop = false;
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSnapShot.Location = new System.Drawing.Point(0, 94);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(154, 23);
            this.btnSnapShot.TabIndex = 0;
            this.btnSnapShot.Text = "Snap Shot";
            this.btnSnapShot.UseVisualStyleBackColor = true;
            // 
            // bigPanel2
            // 
            this.bigPanel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.SetColumnSpan(this.bigPanel2, 2);
            this.bigPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigPanel2.Location = new System.Drawing.Point(483, 347);
            this.bigPanel2.Name = "bigPanel2";
            this.bigPanel2.Size = new System.Drawing.Size(318, 117);
            this.bigPanel2.TabIndex = 21;
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
            this.Text = "ECOM America: CRS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tilePopUpMenu.ResumeLayout(false);
            this.sTile5.ResumeLayout(false);
            this.sTile5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.sTile3.ResumeLayout(false);
            this.sTile3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.sTile4.ResumeLayout(false);
            this.sTile4.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.sTile0.ResumeLayout(false);
            this.sTile0.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sTile1.ResumeLayout(false);
            this.sTile1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.sTile6.ResumeLayout(false);
            this.sTile6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.sTile7.ResumeLayout(false);
            this.sTile7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.sTile8.ResumeLayout(false);
            this.sTile8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.sTile9.ResumeLayout(false);
            this.sTile9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.sTile2.ResumeLayout(false);
            this.sTile2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion



        private System.Windows.Forms.ContextMenuStrip tilePopUpMenu;



        ////////////////////////////////////////LABELS//////////////////////////////////////////

        //////////////////////////////////////////PANELS///////////////////////////////////////// 

        //////////////////////////////////////////TOOLSTRIPMENUITEMS/////////////////////////////////////////

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCalibrationItem;
        private System.Windows.Forms.ToolStripMenuItem menuRecordingItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllAveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar recordingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel recordTimeLabel;
        private System.Windows.Forms.ToolStripStatusLabel recordStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem hidePanelMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDisplayToolStripMenuItem;
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

        //////////////////////////////////////////TEXTBOXS/////////////////////////////////////////

        //////////////////////////////////////////TABLELAYOUTPANELS/////////////////////////////////////////


        //////////////////////////////////////////BUTTONS/////////////////////////////////////////
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolStripMenuItem getSourceToolStripMenuItem;
        private ToolTip toolTip1;

        public DateTime startTime = DateTime.Now;
        private ToolStripMenuItem checkUpgradeToolStripMenuItem;
        private ToolStripMenuItem aboutAdvDASToolStripMenuItem;
        private ToolStripStatusLabel connectionStatusLabel;
        private ToolStripStatusLabel clock_lbl;
        private ToolStripMenuItem setupEquipmentSiteToolStripMenuItem;
        private ToolStripMenuItem personalDataToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem equipmentSiteToolStripMenuItem;
        private TableLayoutPanel sTile5;
        private TextBox textBox6;
        private Label label16;
        private Label label26;
        private TextBox textBox16;
        private Panel panel5;
        private CheckBox checkBox5;
        public Label label6;
        private TableLayoutPanel sTile3;
        private TextBox textBox4;
        private Label label14;
        private TextBox textBox14;
        private Panel panel6;
        private CheckBox checkBox3;
        public Label label4;
        private Label label24;
        private TableLayoutPanel sTile4;
        private TextBox textBox5;
        private Label label15;
        private TextBox textBox15;
        private Label label25;
        private Panel panel7;
        private CheckBox checkBox4;
        public Label label5;
        private TableLayoutPanel sTile0;
        private TextBox textBox1;
        private Label label11;
        private TextBox textBox11;
        private Panel panel1;
        private CheckBox checkBox0;
        public Label label1;
        private Label label21;
        private TableLayoutPanel sTile1;
        private TextBox textBox2;
        private Label label12;
        private TextBox textBox12;
        private Panel panel2;
        private CheckBox checkBox1;
        public Label label2;
        private Label label22;
        private TableLayoutPanel sTile6;
        private TextBox textBox7;
        private Label label27;
        private Label label17;
        private TextBox textBox17;
        private Panel panel8;
        private CheckBox checkBox6;
        public Label label7;
        private TableLayoutPanel sTile7;
        private TextBox textBox8;
        private Label label18;
        private TextBox textBox18;
        private Panel panel9;
        private CheckBox checkBox7;
        public Label label8;
        private Label label28;
        private TableLayoutPanel sTile8;
        private TextBox textBox19;
        private TextBox textBox9;
        private Label label29;
        private Label label19;
        private Panel panel10;
        private CheckBox checkBox8;
        public Label label9;
        private TableLayoutPanel sTile9;
        private TextBox textBox10;
        private Label label30;
        private Label label20;
        private TextBox textBox20;
        private Panel panel11;
        private CheckBox checkBox9;
        public Label label10;
        private TableLayoutPanel sTile2;
        private Label label23;
        private TextBox textBox3;
        private Label label13;
        private TextBox textBox13;
        private Panel panel3;
        private CheckBox checkBox2;
        public Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel bigPanel1;
        private Panel panel4;
        private Panel bigPanel2;
        private PictureBox screenShotBox;
        private Button btnSnapShot;


    }
}

