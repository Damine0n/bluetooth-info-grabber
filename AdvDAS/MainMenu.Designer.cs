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
 

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4.6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 261D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 350D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 290D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 75D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint63 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint64 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint65 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint66 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint67 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint68 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint69 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint70 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint71 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint72 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint73 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint74 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series57 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series58 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series59 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series60 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series61 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series62 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series63 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series67 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series68 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series71 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series72 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tilePopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.snapShotButton = new System.Windows.Forms.Button();
            this.stopRecordingButton = new System.Windows.Forms.Button();
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.tileButton9 = new System.Windows.Forms.Button();
            this.tileButton10 = new System.Windows.Forms.Button();
            this.tileButton11 = new System.Windows.Forms.Button();
            this.tileButton12 = new System.Windows.Forms.Button();
            this.tileButton3 = new System.Windows.Forms.Button();
            this.tileButton8 = new System.Windows.Forms.Button();
            this.tileButton7 = new System.Windows.Forms.Button();
            this.tileButton6 = new System.Windows.Forms.Button();
            this.tileButton2 = new System.Windows.Forms.Button();
            this.tileButton4 = new System.Windows.Forms.Button();
            this.tileButton5 = new System.Windows.Forms.Button();
            this.tileButton1 = new System.Windows.Forms.Button();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.recordSignTimer = new System.Windows.Forms.Timer(this.components);
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.recordingSign = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.sTile10 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.sTile11 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.pTimelbl = new System.Windows.Forms.Label();
            this.plbl = new System.Windows.Forms.Label();
            this.tTimelbl = new System.Windows.Forms.Label();
            this.tlbl = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rlbl = new System.Windows.Forms.Label();
            this.rTimelbl = new System.Windows.Forms.Label();
            this.cycleLabel = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clock_lbl = new System.Windows.Forms.Label();
            this.recordTimeLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.elementTable = new System.Windows.Forms.DataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGraph = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trendGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lTileLabel8 = new System.Windows.Forms.Label();
            this.lLabel8 = new System.Windows.Forms.Label();
            this.lTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lTileLabel7 = new System.Windows.Forms.Label();
            this.lLabel7 = new System.Windows.Forms.Label();
            this.lTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lTileLabel3 = new System.Windows.Forms.Label();
            this.lLabel3 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.lTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.lTileLabel2 = new System.Windows.Forms.Label();
            this.lLabel2 = new System.Windows.Forms.Label();
            this.lTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.lTileLabel5 = new System.Windows.Forms.Label();
            this.lLabel5 = new System.Windows.Forms.Label();
            this.lTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.lTileLabel4 = new System.Windows.Forms.Label();
            this.lLabel4 = new System.Windows.Forms.Label();
            this.lTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.lTileLabel1 = new System.Windows.Forms.Label();
            this.lLabel1 = new System.Windows.Forms.Label();
            this.lTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lTileLabel0 = new System.Windows.Forms.Label();
            this.lLabel0 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.panel23 = new System.Windows.Forms.Panel();
            this.lTileLabel6 = new System.Windows.Forms.Label();
            this.lLabel6 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.label27 = new System.Windows.Forms.Label();
            this.O2_Vlbl = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.serialNO_lbl = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.CO_Vlbl = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.operationHrs_lbl = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.NO_Vlbl = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.ProgramVrs_lbl = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.NO2_Vlbl = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.batt_Vlbl = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.battB_Vlbl = new System.Windows.Forms.Label();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.iflowlbl = new System.Windows.Forms.Label();
            this.flowlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupEquipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackBlueColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueWhiteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTestRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSnapshotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyO2CorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performPreAndPostCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCommunictaionPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalibrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAdvDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzerSignal = new WindowWidgets.SignalStrength();
            this.tilePopUpMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.sTile8.SuspendLayout();
            this.sTile9.SuspendLayout();
            this.sTile10.SuspendLayout();
            this.sTile11.SuspendLayout();
            this.sTile2.SuspendLayout();
            this.sTile7.SuspendLayout();
            this.sTile6.SuspendLayout();
            this.sTile5.SuspendLayout();
            this.sTile1.SuspendLayout();
            this.sTile3.SuspendLayout();
            this.sTile4.SuspendLayout();
            this.sTile0.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.lTile8.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.lTile7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.lTile3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.lTile2.SuspendLayout();
            this.panel14.SuspendLayout();
            this.lTile5.SuspendLayout();
            this.panel17.SuspendLayout();
            this.lTile4.SuspendLayout();
            this.panel18.SuspendLayout();
            this.lTile1.SuspendLayout();
            this.panel19.SuspendLayout();
            this.lTile0.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.lTile6.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tilePopUpMenu
            // 
            this.tilePopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDisplayToolStripMenuItem});
            this.tilePopUpMenu.Name = "panelPopUpMenu";
            this.tilePopUpMenu.Size = new System.Drawing.Size(136, 26);
            // 
            // editDisplayToolStripMenuItem
            // 
            this.editDisplayToolStripMenuItem.Name = "editDisplayToolStripMenuItem";
            this.editDisplayToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editDisplayToolStripMenuItem.Text = "Edit Display";
            this.editDisplayToolStripMenuItem.Click += new System.EventHandler(this.editDisplayToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // snapShotButton
            // 
            this.snapShotButton.BackColor = System.Drawing.Color.Transparent;
            this.snapShotButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snapShotButton.BackgroundImage")));
            this.snapShotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snapShotButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.snapShotButton.FlatAppearance.BorderSize = 0;
            this.snapShotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.snapShotButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.snapShotButton.Location = new System.Drawing.Point(275, 0);
            this.snapShotButton.Name = "snapShotButton";
            this.snapShotButton.Size = new System.Drawing.Size(131, 41);
            this.snapShotButton.TabIndex = 6;
            this.snapShotButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.snapShotButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.snapShotButton, "Stop Recording");
            this.snapShotButton.UseVisualStyleBackColor = false;
            this.snapShotButton.Click += new System.EventHandler(this.snapShot_Click);
            // 
            // stopRecordingButton
            // 
            this.stopRecordingButton.BackColor = System.Drawing.Color.Transparent;
            this.stopRecordingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopRecordingButton.BackgroundImage")));
            this.stopRecordingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stopRecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopRecordingButton.Enabled = false;
            this.stopRecordingButton.FlatAppearance.BorderSize = 0;
            this.stopRecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopRecordingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stopRecordingButton.Location = new System.Drawing.Point(138, 0);
            this.stopRecordingButton.Name = "stopRecordingButton";
            this.stopRecordingButton.Size = new System.Drawing.Size(131, 41);
            this.stopRecordingButton.TabIndex = 5;
            this.stopRecordingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopRecordingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.stopRecordingButton, "Pause Recording");
            this.stopRecordingButton.UseVisualStyleBackColor = false;
            this.stopRecordingButton.Click += new System.EventHandler(this.stopRecordingItem_Click);
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.BackColor = System.Drawing.Color.Transparent;
            this.startRecordingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startRecordingButton.BackgroundImage")));
            this.startRecordingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startRecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startRecordingButton.FlatAppearance.BorderSize = 0;
            this.startRecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startRecordingButton.ForeColor = System.Drawing.Color.Transparent;
            this.startRecordingButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startRecordingButton.Location = new System.Drawing.Point(1, 0);
            this.startRecordingButton.Name = "startRecordingButton";
            this.startRecordingButton.Size = new System.Drawing.Size(131, 41);
            this.startRecordingButton.TabIndex = 4;
            this.startRecordingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startRecordingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.startRecordingButton, "Start Recording");
            this.startRecordingButton.UseVisualStyleBackColor = false;
            this.startRecordingButton.Click += new System.EventHandler(this.startRecordingItem_Click);
            // 
            // tileButton9
            // 
            this.tileButton9.BackColor = System.Drawing.Color.Transparent;
            this.tileButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton9.FlatAppearance.BorderSize = 0;
            this.tileButton9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton9.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton9.ForeColor = System.Drawing.Color.Silver;
            this.tileButton9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton9.Location = new System.Drawing.Point(3, 126);
            this.tileButton9.Name = "tileButton9";
            this.tileButton9.Size = new System.Drawing.Size(174, 38);
            this.tileButton9.TabIndex = 16;
            this.tileButton9.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton9, "Click here to reset average");
            this.tileButton9.UseVisualStyleBackColor = false;
            // 
            // tileButton10
            // 
            this.tileButton10.BackColor = System.Drawing.Color.Transparent;
            this.tileButton10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton10.FlatAppearance.BorderSize = 0;
            this.tileButton10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton10.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton10.ForeColor = System.Drawing.Color.Silver;
            this.tileButton10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton10.Location = new System.Drawing.Point(3, 126);
            this.tileButton10.Name = "tileButton10";
            this.tileButton10.Size = new System.Drawing.Size(174, 38);
            this.tileButton10.TabIndex = 16;
            this.tileButton10.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton10, "Click here to reset average");
            this.tileButton10.UseVisualStyleBackColor = false;
            // 
            // tileButton11
            // 
            this.tileButton11.BackColor = System.Drawing.Color.Transparent;
            this.tileButton11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton11.FlatAppearance.BorderSize = 0;
            this.tileButton11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton11.ForeColor = System.Drawing.Color.Silver;
            this.tileButton11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton11.Location = new System.Drawing.Point(3, 126);
            this.tileButton11.Name = "tileButton11";
            this.tileButton11.Size = new System.Drawing.Size(174, 38);
            this.tileButton11.TabIndex = 16;
            this.tileButton11.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton11, "Click here to reset average");
            this.tileButton11.UseVisualStyleBackColor = false;
            // 
            // tileButton12
            // 
            this.tileButton12.BackColor = System.Drawing.Color.Transparent;
            this.tileButton12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton12.FlatAppearance.BorderSize = 0;
            this.tileButton12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton12.ForeColor = System.Drawing.Color.Silver;
            this.tileButton12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton12.Location = new System.Drawing.Point(3, 126);
            this.tileButton12.Name = "tileButton12";
            this.tileButton12.Size = new System.Drawing.Size(174, 38);
            this.tileButton12.TabIndex = 16;
            this.tileButton12.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton12, "Click here to reset average");
            this.tileButton12.UseVisualStyleBackColor = false;
            // 
            // tileButton3
            // 
            this.tileButton3.BackColor = System.Drawing.Color.Transparent;
            this.tileButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton3.FlatAppearance.BorderSize = 0;
            this.tileButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton3.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton3.ForeColor = System.Drawing.Color.Silver;
            this.tileButton3.Location = new System.Drawing.Point(3, 125);
            this.tileButton3.Name = "tileButton3";
            this.tileButton3.Size = new System.Drawing.Size(174, 37);
            this.tileButton3.TabIndex = 2;
            this.tileButton3.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton3, "Click here to reset average");
            this.tileButton3.UseVisualStyleBackColor = false;
            // 
            // tileButton8
            // 
            this.tileButton8.BackColor = System.Drawing.Color.Transparent;
            this.tileButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton8.FlatAppearance.BorderSize = 0;
            this.tileButton8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton8.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton8.ForeColor = System.Drawing.Color.Silver;
            this.tileButton8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton8.Location = new System.Drawing.Point(3, 125);
            this.tileButton8.Name = "tileButton8";
            this.tileButton8.Size = new System.Drawing.Size(174, 37);
            this.tileButton8.TabIndex = 20;
            this.tileButton8.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton8, "Click here to reset average");
            this.tileButton8.UseVisualStyleBackColor = false;
            // 
            // tileButton7
            // 
            this.tileButton7.BackColor = System.Drawing.Color.Transparent;
            this.tileButton7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton7.FlatAppearance.BorderSize = 0;
            this.tileButton7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton7.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton7.ForeColor = System.Drawing.Color.Silver;
            this.tileButton7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton7.Location = new System.Drawing.Point(3, 125);
            this.tileButton7.Name = "tileButton7";
            this.tileButton7.Size = new System.Drawing.Size(174, 37);
            this.tileButton7.TabIndex = 19;
            this.tileButton7.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton7, "Click here to reset average");
            this.tileButton7.UseVisualStyleBackColor = false;
            // 
            // tileButton6
            // 
            this.tileButton6.BackColor = System.Drawing.Color.Transparent;
            this.tileButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton6.FlatAppearance.BorderSize = 0;
            this.tileButton6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton6.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton6.ForeColor = System.Drawing.Color.Silver;
            this.tileButton6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton6.Location = new System.Drawing.Point(3, 125);
            this.tileButton6.Name = "tileButton6";
            this.tileButton6.Size = new System.Drawing.Size(174, 37);
            this.tileButton6.TabIndex = 18;
            this.tileButton6.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton6, "Click here to reset average");
            this.tileButton6.UseVisualStyleBackColor = false;
            // 
            // tileButton2
            // 
            this.tileButton2.BackColor = System.Drawing.Color.Transparent;
            this.tileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton2.FlatAppearance.BorderSize = 0;
            this.tileButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton2.ForeColor = System.Drawing.Color.Silver;
            this.tileButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton2.Location = new System.Drawing.Point(3, 125);
            this.tileButton2.Name = "tileButton2";
            this.tileButton2.Size = new System.Drawing.Size(174, 37);
            this.tileButton2.TabIndex = 13;
            this.tileButton2.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton2, "Click here to reset average");
            this.tileButton2.UseVisualStyleBackColor = false;
            // 
            // tileButton4
            // 
            this.tileButton4.BackColor = System.Drawing.Color.Transparent;
            this.tileButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton4.FlatAppearance.BorderSize = 0;
            this.tileButton4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton4.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton4.ForeColor = System.Drawing.Color.Silver;
            this.tileButton4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton4.Location = new System.Drawing.Point(3, 125);
            this.tileButton4.Name = "tileButton4";
            this.tileButton4.Size = new System.Drawing.Size(174, 37);
            this.tileButton4.TabIndex = 15;
            this.tileButton4.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton4, "Click here to reset average");
            this.tileButton4.UseVisualStyleBackColor = false;
            // 
            // tileButton5
            // 
            this.tileButton5.BackColor = System.Drawing.Color.Transparent;
            this.tileButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton5.FlatAppearance.BorderSize = 0;
            this.tileButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton5.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton5.ForeColor = System.Drawing.Color.Silver;
            this.tileButton5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton5.Location = new System.Drawing.Point(3, 125);
            this.tileButton5.Name = "tileButton5";
            this.tileButton5.Size = new System.Drawing.Size(174, 37);
            this.tileButton5.TabIndex = 17;
            this.tileButton5.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton5, "Click here to reset average");
            this.tileButton5.UseVisualStyleBackColor = false;
            // 
            // tileButton1
            // 
            this.tileButton1.BackColor = System.Drawing.Color.Transparent;
            this.tileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton1.FlatAppearance.BorderSize = 0;
            this.tileButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.tileButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton1.ForeColor = System.Drawing.Color.Silver;
            this.tileButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton1.Location = new System.Drawing.Point(5, 127);
            this.tileButton1.Margin = new System.Windows.Forms.Padding(5);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(170, 33);
            this.tileButton1.TabIndex = 12;
            this.tileButton1.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton1, "Click here to reset average");
            this.tileButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.Interval = 1000;
            this.dataGridTimer.Tick += new System.EventHandler(this.dataGridTimer_Tick);
            // 
            // recordSignTimer
            // 
            this.recordSignTimer.Interval = 1000;
            this.recordSignTimer.Tick += new System.EventHandler(this.recordSign_Tick);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 683);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(1028, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(1028, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightToolStripPanel.Location = new System.Drawing.Point(1003, 25);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(25, 658);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 25);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 658);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(1003, 658);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1028, 683);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.snapShotButton);
            this.panel12.Controls.Add(this.stopRecordingButton);
            this.panel12.Controls.Add(this.startRecordingButton);
            this.panel12.Controls.Add(this.recordingSign);
            this.panel12.Location = new System.Drawing.Point(3, 28);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(572, 41);
            this.panel12.TabIndex = 23;
            // 
            // recordingSign
            // 
            this.recordingSign.BackColor = System.Drawing.Color.Transparent;
            this.recordingSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recordingSign.Image = global::CRS.Properties.Resources.recording_A;
            this.recordingSign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recordingSign.Location = new System.Drawing.Point(395, 0);
            this.recordingSign.Margin = new System.Windows.Forms.Padding(0);
            this.recordingSign.Name = "recordingSign";
            this.recordingSign.Size = new System.Drawing.Size(192, 41);
            this.recordingSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordingSign.TabIndex = 8;
            this.recordingSign.TabStop = false;
            this.recordingSign.Visible = false;
            // 
            // tabControl1
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tabControl1, 2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 597);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.sTile8, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile9, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile7, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel19, 4, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 557);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.Color.Black;
            this.sTile8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile8.BackgroundImage")));
            this.sTile8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile8.ColumnCount = 1;
            this.sTile8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile8.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile8.Controls.Add(this.tileButton9, 0, 2);
            this.sTile8.Controls.Add(this.label9, 0, 1);
            this.sTile8.Controls.Add(this.tileLabel9, 0, 0);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile8.Location = new System.Drawing.Point(10, 380);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 3;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.sTile8.Size = new System.Drawing.Size(180, 167);
            this.sTile8.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 81);
            this.label9.TabIndex = 13;
            this.label9.Text = "----";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel9
            // 
            this.tileLabel9.AutoSize = true;
            this.tileLabel9.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel9.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel9.Location = new System.Drawing.Point(3, 0);
            this.tileLabel9.Name = "tileLabel9";
            this.tileLabel9.Size = new System.Drawing.Size(174, 42);
            this.tileLabel9.TabIndex = 15;
            this.tileLabel9.Text = "NOx ppm";
            this.tileLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.Color.Black;
            this.sTile9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile9.BackgroundImage")));
            this.sTile9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile9.ColumnCount = 1;
            this.sTile9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile9.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile9.Controls.Add(this.tileButton10, 0, 2);
            this.sTile9.Controls.Add(this.label10, 0, 1);
            this.sTile9.Controls.Add(this.tileLabel10, 0, 0);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile9.Location = new System.Drawing.Point(210, 380);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 3;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.sTile9.Size = new System.Drawing.Size(180, 167);
            this.sTile9.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(3, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 81);
            this.label10.TabIndex = 13;
            this.label10.Text = "----";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel10
            // 
            this.tileLabel10.AutoSize = true;
            this.tileLabel10.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel10.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel10.Location = new System.Drawing.Point(3, 0);
            this.tileLabel10.Name = "tileLabel10";
            this.tileLabel10.Size = new System.Drawing.Size(174, 42);
            this.tileLabel10.TabIndex = 15;
            this.tileLabel10.Text = "T(amb)°F";
            this.tileLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile10
            // 
            this.sTile10.BackColor = System.Drawing.Color.Black;
            this.sTile10.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile10.BackgroundImage")));
            this.sTile10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile10.ColumnCount = 1;
            this.sTile10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile10.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile10.Controls.Add(this.tileButton11, 0, 2);
            this.sTile10.Controls.Add(this.label11, 0, 1);
            this.sTile10.Controls.Add(this.tileLabel11, 0, 0);
            this.sTile10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile10.Location = new System.Drawing.Point(410, 380);
            this.sTile10.Margin = new System.Windows.Forms.Padding(10);
            this.sTile10.Name = "sTile10";
            this.sTile10.RowCount = 3;
            this.sTile10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.sTile10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.sTile10.Size = new System.Drawing.Size(180, 167);
            this.sTile10.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(3, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(174, 81);
            this.label11.TabIndex = 13;
            this.label11.Text = "----";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel11
            // 
            this.tileLabel11.AutoSize = true;
            this.tileLabel11.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel11.Location = new System.Drawing.Point(3, 0);
            this.tileLabel11.Name = "tileLabel11";
            this.tileLabel11.Size = new System.Drawing.Size(174, 42);
            this.tileLabel11.TabIndex = 15;
            this.tileLabel11.Text = "T(cell)°F";
            this.tileLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile11
            // 
            this.sTile11.BackColor = System.Drawing.Color.Black;
            this.sTile11.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile11.BackgroundImage")));
            this.sTile11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile11.ColumnCount = 1;
            this.sTile11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile11.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile11.Controls.Add(this.tileButton12, 0, 2);
            this.sTile11.Controls.Add(this.label12, 0, 1);
            this.sTile11.Controls.Add(this.tileLabel12, 0, 0);
            this.sTile11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile11.Location = new System.Drawing.Point(610, 380);
            this.sTile11.Margin = new System.Windows.Forms.Padding(10);
            this.sTile11.Name = "sTile11";
            this.sTile11.RowCount = 3;
            this.sTile11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.sTile11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.sTile11.Size = new System.Drawing.Size(180, 167);
            this.sTile11.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(3, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 81);
            this.label12.TabIndex = 13;
            this.label12.Text = "----";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel12
            // 
            this.tileLabel12.AutoSize = true;
            this.tileLabel12.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel12.Location = new System.Drawing.Point(3, 0);
            this.tileLabel12.Name = "tileLabel12";
            this.tileLabel12.Size = new System.Drawing.Size(174, 42);
            this.tileLabel12.TabIndex = 15;
            this.tileLabel12.Text = "Efficiency %";
            this.tileLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile2
            // 
            this.sTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile2.BackgroundImage")));
            this.sTile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile2.ColumnCount = 1;
            this.sTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile2.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile2.Controls.Add(this.label3, 0, 1);
            this.sTile2.Controls.Add(this.tileLabel3, 0, 0);
            this.sTile2.Controls.Add(this.tileButton3, 0, 2);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile2.Location = new System.Drawing.Point(410, 10);
            this.sTile2.Margin = new System.Windows.Forms.Padding(10);
            this.sTile2.Name = "sTile2";
            this.sTile2.RowCount = 3;
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile2.Size = new System.Drawing.Size(180, 165);
            this.sTile2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = "----";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel3
            // 
            this.tileLabel3.AutoSize = true;
            this.tileLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel3.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel3.Location = new System.Drawing.Point(3, 0);
            this.tileLabel3.Name = "tileLabel3";
            this.tileLabel3.Size = new System.Drawing.Size(174, 41);
            this.tileLabel3.TabIndex = 1;
            this.tileLabel3.Text = "NO ppm";
            this.tileLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile7
            // 
            this.sTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile7.BackgroundImage")));
            this.sTile7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile7.ColumnCount = 1;
            this.sTile7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile7.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile7.Controls.Add(this.tileButton8, 0, 2);
            this.sTile7.Controls.Add(this.label8, 0, 1);
            this.sTile7.Controls.Add(this.tileLabel8, 0, 0);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile7.Location = new System.Drawing.Point(610, 195);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 3;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile7.Size = new System.Drawing.Size(180, 165);
            this.sTile7.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(3, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 81);
            this.label8.TabIndex = 17;
            this.label8.Text = "----";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel8
            // 
            this.tileLabel8.AutoSize = true;
            this.tileLabel8.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel8.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel8.Location = new System.Drawing.Point(3, 0);
            this.tileLabel8.Name = "tileLabel8";
            this.tileLabel8.Size = new System.Drawing.Size(174, 41);
            this.tileLabel8.TabIndex = 19;
            this.tileLabel8.Text = "T(gas)°F";
            this.tileLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile6
            // 
            this.sTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile6.BackgroundImage")));
            this.sTile6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile6.ColumnCount = 1;
            this.sTile6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile6.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile6.Controls.Add(this.tileButton7, 0, 2);
            this.sTile6.Controls.Add(this.label7, 0, 1);
            this.sTile6.Controls.Add(this.tileLabel7, 0, 0);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile6.Location = new System.Drawing.Point(410, 195);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 3;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile6.Size = new System.Drawing.Size(180, 165);
            this.sTile6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 81);
            this.label7.TabIndex = 16;
            this.label7.Text = "----";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel7
            // 
            this.tileLabel7.AutoSize = true;
            this.tileLabel7.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel7.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel7.Location = new System.Drawing.Point(3, 0);
            this.tileLabel7.Name = "tileLabel7";
            this.tileLabel7.Size = new System.Drawing.Size(174, 41);
            this.tileLabel7.TabIndex = 18;
            this.tileLabel7.Text = "CxHy ppm";
            this.tileLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile5
            // 
            this.sTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile5.BackgroundImage")));
            this.sTile5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile5.ColumnCount = 1;
            this.sTile5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile5.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile5.Controls.Add(this.tileButton6, 0, 2);
            this.sTile5.Controls.Add(this.label6, 0, 1);
            this.sTile5.Controls.Add(this.tileLabel6, 0, 0);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile5.Location = new System.Drawing.Point(210, 195);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 3;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile5.Size = new System.Drawing.Size(180, 165);
            this.sTile5.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 81);
            this.label6.TabIndex = 15;
            this.label6.Text = "----";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel6
            // 
            this.tileLabel6.AutoSize = true;
            this.tileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel6.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel6.Location = new System.Drawing.Point(3, 0);
            this.tileLabel6.Name = "tileLabel6";
            this.tileLabel6.Size = new System.Drawing.Size(174, 41);
            this.tileLabel6.TabIndex = 17;
            this.tileLabel6.Text = "SO2 ppm";
            this.tileLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile1
            // 
            this.sTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile1.BackgroundImage")));
            this.sTile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile1.ColumnCount = 1;
            this.sTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile1.Controls.Add(this.tileButton2, 0, 2);
            this.sTile1.Controls.Add(this.label2, 0, 1);
            this.sTile1.Controls.Add(this.tileLabel2, 0, 0);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile1.Location = new System.Drawing.Point(210, 10);
            this.sTile1.Margin = new System.Windows.Forms.Padding(10);
            this.sTile1.Name = "sTile1";
            this.sTile1.RowCount = 3;
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile1.Size = new System.Drawing.Size(180, 165);
            this.sTile1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 81);
            this.label2.TabIndex = 10;
            this.label2.Text = "----";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel2
            // 
            this.tileLabel2.AutoSize = true;
            this.tileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel2.Location = new System.Drawing.Point(3, 0);
            this.tileLabel2.Name = "tileLabel2";
            this.tileLabel2.Size = new System.Drawing.Size(174, 41);
            this.tileLabel2.TabIndex = 12;
            this.tileLabel2.Text = "CO ppm";
            this.tileLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile3
            // 
            this.sTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile3.BackgroundImage")));
            this.sTile3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile3.ColumnCount = 1;
            this.sTile3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile3.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile3.Controls.Add(this.tileButton4, 0, 2);
            this.sTile3.Controls.Add(this.label4, 0, 1);
            this.sTile3.Controls.Add(this.tileLabel4, 0, 0);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile3.Location = new System.Drawing.Point(610, 10);
            this.sTile3.Margin = new System.Windows.Forms.Padding(10);
            this.sTile3.Name = "sTile3";
            this.sTile3.RowCount = 3;
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile3.Size = new System.Drawing.Size(180, 165);
            this.sTile3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 81);
            this.label4.TabIndex = 12;
            this.label4.Text = "----";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel4
            // 
            this.tileLabel4.AutoSize = true;
            this.tileLabel4.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel4.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel4.Location = new System.Drawing.Point(3, 0);
            this.tileLabel4.Name = "tileLabel4";
            this.tileLabel4.Size = new System.Drawing.Size(174, 41);
            this.tileLabel4.TabIndex = 14;
            this.tileLabel4.Text = "NO2 ppm";
            this.tileLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile4.BackgroundImage")));
            this.sTile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile4.ColumnCount = 1;
            this.sTile4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile4.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile4.Controls.Add(this.tileButton5, 0, 2);
            this.sTile4.Controls.Add(this.label5, 0, 1);
            this.sTile4.Controls.Add(this.tileLabel5, 0, 0);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile4.Location = new System.Drawing.Point(10, 195);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 3;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile4.Size = new System.Drawing.Size(180, 165);
            this.sTile4.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 81);
            this.label5.TabIndex = 14;
            this.label5.Text = "----";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel5
            // 
            this.tileLabel5.AutoSize = true;
            this.tileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel5.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel5.ForeColor = System.Drawing.Color.Black;
            this.tileLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel5.Location = new System.Drawing.Point(3, 0);
            this.tileLabel5.Name = "tileLabel5";
            this.tileLabel5.Size = new System.Drawing.Size(174, 41);
            this.tileLabel5.TabIndex = 16;
            this.tileLabel5.Text = "CO2%";
            this.tileLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile0
            // 
            this.sTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sTile0.BackgroundImage")));
            this.sTile0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sTile0.ColumnCount = 1;
            this.sTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile0.Controls.Add(this.label1, 0, 1);
            this.sTile0.Controls.Add(this.tileLabel1, 0, 0);
            this.sTile0.Controls.Add(this.tileButton1, 0, 2);
            this.sTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile0.Location = new System.Drawing.Point(10, 10);
            this.sTile0.Margin = new System.Windows.Forms.Padding(10);
            this.sTile0.Name = "sTile0";
            this.sTile0.RowCount = 3;
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile0.Size = new System.Drawing.Size(180, 165);
            this.sTile0.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "----";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel1
            // 
            this.tileLabel1.AutoSize = true;
            this.tileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel1.Location = new System.Drawing.Point(3, 0);
            this.tileLabel1.Name = "tileLabel1";
            this.tileLabel1.Size = new System.Drawing.Size(174, 41);
            this.tileLabel1.TabIndex = 11;
            this.tileLabel1.Text = "O2%";
            this.tileLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.ColumnCount = 2;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.Controls.Add(this.pTimelbl, 1, 7);
            this.tableLayoutPanel19.Controls.Add(this.plbl, 0, 7);
            this.tableLayoutPanel19.Controls.Add(this.tTimelbl, 1, 5);
            this.tableLayoutPanel19.Controls.Add(this.tlbl, 0, 5);
            this.tableLayoutPanel19.Controls.Add(this.label21, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.label14, 0, 10);
            this.tableLayoutPanel19.Controls.Add(this.rlbl, 0, 3);
            this.tableLayoutPanel19.Controls.Add(this.rTimelbl, 1, 3);
            this.tableLayoutPanel19.Controls.Add(this.cycleLabel, 0, 2);
            this.tableLayoutPanel19.Controls.Add(this.label23, 1, 1);
            this.tableLayoutPanel19.Controls.Add(this.label22, 1, 2);
            this.tableLayoutPanel19.Controls.Add(this.button1, 0, 12);
            this.tableLayoutPanel19.Controls.Add(this.clock_lbl, 0, 13);
            this.tableLayoutPanel19.Controls.Add(this.recordTimeLabel, 1, 8);
            this.tableLayoutPanel19.Controls.Add(this.label15, 0, 8);
            this.tableLayoutPanel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel19.Location = new System.Drawing.Point(803, 3);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 14;
            this.tableLayoutPanel1.SetRowSpan(this.tableLayoutPanel19, 3);
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel19.Size = new System.Drawing.Size(198, 551);
            this.tableLayoutPanel19.TabIndex = 31;
            // 
            // pTimelbl
            // 
            this.pTimelbl.AutoSize = true;
            this.pTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.pTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pTimelbl.Location = new System.Drawing.Point(102, 95);
            this.pTimelbl.Name = "pTimelbl";
            this.pTimelbl.Size = new System.Drawing.Size(69, 19);
            this.pTimelbl.TabIndex = 28;
            this.pTimelbl.Text = "00:00:00";
            this.pTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plbl
            // 
            this.plbl.AutoSize = true;
            this.plbl.BackColor = System.Drawing.Color.Transparent;
            this.plbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plbl.Location = new System.Drawing.Point(3, 95);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(93, 19);
            this.plbl.TabIndex = 23;
            this.plbl.Text = "Purge:";
            this.plbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tTimelbl
            // 
            this.tTimelbl.AutoSize = true;
            this.tTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.tTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tTimelbl.Location = new System.Drawing.Point(102, 76);
            this.tTimelbl.Name = "tTimelbl";
            this.tTimelbl.Size = new System.Drawing.Size(69, 19);
            this.tTimelbl.TabIndex = 27;
            this.tTimelbl.Text = "00:00:00";
            this.tTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlbl
            // 
            this.tlbl.AutoSize = true;
            this.tlbl.BackColor = System.Drawing.Color.Transparent;
            this.tlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlbl.Location = new System.Drawing.Point(3, 76);
            this.tlbl.Name = "tlbl";
            this.tlbl.Size = new System.Drawing.Size(93, 19);
            this.tlbl.TabIndex = 4;
            this.tlbl.Text = "Test:";
            this.tlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(93, 38);
            this.label21.TabIndex = 31;
            this.label21.Text = "Sample Rate:";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.tableLayoutPanel19.SetColumnSpan(this.label14, 2);
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 19);
            this.label14.TabIndex = 32;
            this.label14.Text = "## Machine(s) tested";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rlbl
            // 
            this.rlbl.AutoSize = true;
            this.rlbl.BackColor = System.Drawing.Color.Transparent;
            this.rlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rlbl.Location = new System.Drawing.Point(3, 57);
            this.rlbl.Name = "rlbl";
            this.rlbl.Size = new System.Drawing.Size(93, 19);
            this.rlbl.TabIndex = 2;
            this.rlbl.Text = "Ramp Up:";
            this.rlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rTimelbl
            // 
            this.rTimelbl.AutoSize = true;
            this.rTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.rTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rTimelbl.Location = new System.Drawing.Point(102, 57);
            this.rTimelbl.Name = "rTimelbl";
            this.rTimelbl.Size = new System.Drawing.Size(69, 19);
            this.rTimelbl.TabIndex = 26;
            this.rTimelbl.Text = "00:00:00";
            this.rTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cycleLabel
            // 
            this.cycleLabel.AutoSize = true;
            this.cycleLabel.BackColor = System.Drawing.Color.Transparent;
            this.cycleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleLabel.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cycleLabel.Location = new System.Drawing.Point(3, 38);
            this.cycleLabel.Name = "cycleLabel";
            this.cycleLabel.Size = new System.Drawing.Size(93, 19);
            this.cycleLabel.TabIndex = 1;
            this.cycleLabel.Text = "Cycle:";
            this.cycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(102, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 19);
            this.label23.TabIndex = 34;
            this.label23.Text = "1 sec(s)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(102, 38);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(50, 19);
            this.label22.TabIndex = 33;
            this.label22.Text = "1 of 1";
            // 
            // button1
            // 
            this.tableLayoutPanel19.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 29);
            this.button1.TabIndex = 36;
            this.button1.Text = "Edit Procedure";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clock_lbl
            // 
            this.clock_lbl.AutoSize = true;
            this.tableLayoutPanel19.SetColumnSpan(this.clock_lbl, 2);
            this.clock_lbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.clock_lbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clock_lbl.Location = new System.Drawing.Point(3, 532);
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(192, 19);
            this.clock_lbl.TabIndex = 2;
            this.clock_lbl.Text = "label15";
            this.clock_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordTimeLabel
            // 
            this.recordTimeLabel.AutoSize = true;
            this.recordTimeLabel.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordTimeLabel.ForeColor = System.Drawing.Color.Black;
            this.recordTimeLabel.Location = new System.Drawing.Point(102, 114);
            this.recordTimeLabel.Name = "recordTimeLabel";
            this.recordTimeLabel.Size = new System.Drawing.Size(69, 19);
            this.recordTimeLabel.TabIndex = 4;
            this.recordTimeLabel.Text = "00:00:00";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 38);
            this.label15.TabIndex = 37;
            this.label15.Text = "Total Test Time:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1004, 557);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 413;
            this.lineShape1.X2 = 488;
            this.lineShape1.Y1 = 214;
            this.lineShape1.Y2 = 237;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableLayoutPanel14);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel14.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.trendGraph, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1008, 561);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.elementTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 547);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(0, 521);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "PRINT GRAPH";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // elementTable
            // 
            this.elementTable.AllowUserToAddRows = false;
            this.elementTable.AllowUserToDeleteRows = false;
            this.elementTable.AllowUserToOrderColumns = true;
            this.elementTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.elementTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.elementTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.elementTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgName,
            this.dgValue,
            this.dgUnit,
            this.dgGraph});
            this.elementTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementTable.Location = new System.Drawing.Point(0, 0);
            this.elementTable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.elementTable.Name = "elementTable";
            this.elementTable.Size = new System.Drawing.Size(273, 547);
            this.elementTable.TabIndex = 6;
            this.elementTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elementTable_CellContentClick);
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgName.HeaderText = "Name";
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgValue
            // 
            this.dgValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgValue.HeaderText = "Value";
            this.dgValue.Name = "dgValue";
            this.dgValue.ReadOnly = true;
            this.dgValue.Width = 68;
            // 
            // dgUnit
            // 
            this.dgUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgUnit.HeaderText = "Unit";
            this.dgUnit.Name = "dgUnit";
            this.dgUnit.ReadOnly = true;
            this.dgUnit.Width = 58;
            // 
            // dgGraph
            // 
            this.dgGraph.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgGraph.HeaderText = "Graph";
            this.dgGraph.Name = "dgGraph";
            this.dgGraph.Width = 54;
            // 
            // trendGraph
            // 
            chartArea3.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea3.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea3.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea3.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea3.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea3.AxisY.ScaleBreakStyle.Spacing = 10D;
            chartArea3.Name = "ChartArea1";
            this.trendGraph.ChartAreas.Add(chartArea3);
            this.trendGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.trendGraph.Legends.Add(legend3);
            this.trendGraph.Location = new System.Drawing.Point(285, 3);
            this.trendGraph.Margin = new System.Windows.Forms.Padding(0);
            this.trendGraph.Name = "trendGraph";
            this.trendGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series37.Legend = "Legend1";
            series37.Name = "O2";
            series37.Points.Add(dataPoint38);
            series37.Points.Add(dataPoint39);
            series37.Points.Add(dataPoint40);
            series37.Points.Add(dataPoint41);
            series37.Points.Add(dataPoint42);
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series38.Legend = "Legend1";
            series38.Name = "CO";
            series38.Points.Add(dataPoint43);
            series38.Points.Add(dataPoint44);
            series38.Points.Add(dataPoint45);
            series38.Points.Add(dataPoint46);
            series38.Points.Add(dataPoint47);
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series39.Legend = "Legend1";
            series39.Name = "CO2";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series40.Legend = "Legend1";
            series40.Name = "NO";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series41.Legend = "Legend1";
            series41.Name = "NO2";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series42.Legend = "Legend1";
            series42.Name = "NOx";
            series42.Points.Add(dataPoint48);
            series42.Points.Add(dataPoint49);
            series42.Points.Add(dataPoint50);
            series42.Points.Add(dataPoint51);
            series42.Points.Add(dataPoint52);
            series42.YValueMembers = "Tag";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series43.Legend = "Legend1";
            series43.Name = "SO2";
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series44.Legend = "Legend1";
            series44.Name = "CxHy";
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series45.Legend = "Legend1";
            series45.Name = "T(gas)";
            series45.Points.Add(dataPoint53);
            series45.Points.Add(dataPoint54);
            series45.Points.Add(dataPoint55);
            series45.Points.Add(dataPoint56);
            series45.Points.Add(dataPoint57);
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series46.Legend = "Legend1";
            series46.Name = "T(amb)";
            series46.Points.Add(dataPoint58);
            series46.Points.Add(dataPoint59);
            series46.Points.Add(dataPoint60);
            series46.Points.Add(dataPoint61);
            series46.Points.Add(dataPoint62);
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series47.Legend = "Legend1";
            series47.Name = "T(cell)";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series48.Legend = "Legend1";
            series48.Name = "Efficiency";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series49.Legend = "Legend1";
            series49.Name = "I.Flow";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series50.Legend = "Legend1";
            series50.Name = "Draft";
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series51.Legend = "Legend1";
            series51.Name = "Losses";
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series52.Legend = "Legend1";
            series52.Name = "Excess Air";
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series53.Legend = "Legend1";
            series53.Name = "CO(mass)";
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series54.Legend = "Legend1";
            series54.Name = "NOx(mass)";
            this.trendGraph.Series.Add(series37);
            this.trendGraph.Series.Add(series38);
            this.trendGraph.Series.Add(series39);
            this.trendGraph.Series.Add(series40);
            this.trendGraph.Series.Add(series41);
            this.trendGraph.Series.Add(series42);
            this.trendGraph.Series.Add(series43);
            this.trendGraph.Series.Add(series44);
            this.trendGraph.Series.Add(series45);
            this.trendGraph.Series.Add(series46);
            this.trendGraph.Series.Add(series47);
            this.trendGraph.Series.Add(series48);
            this.trendGraph.Series.Add(series49);
            this.trendGraph.Series.Add(series50);
            this.trendGraph.Series.Add(series51);
            this.trendGraph.Series.Add(series52);
            this.trendGraph.Series.Add(series53);
            this.trendGraph.Series.Add(series54);
            this.trendGraph.Size = new System.Drawing.Size(720, 553);
            this.trendGraph.TabIndex = 1;
            this.trendGraph.Text = "trendChart";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1014, 567);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hybrid";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.lTile8, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.lTile7, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lTile3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.lTile2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lTile5, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.lTile4, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lTile1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lTile0, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chart1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lTile6, 0, 2);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82443F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.701F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.1492F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32538F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 561);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // lTile8
            // 
            this.lTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile8.BackgroundImage")));
            this.lTile8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile8.ColumnCount = 1;
            this.lTile8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile8.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile8.Controls.Add(this.panel5, 0, 0);
            this.lTile8.Controls.Add(this.lLabel8, 0, 1);
            this.lTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile8.Location = new System.Drawing.Point(320, 275);
            this.lTile8.Margin = new System.Windows.Forms.Padding(10);
            this.lTile8.Name = "lTile8";
            this.lTile8.RowCount = 3;
            this.lTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile8.Size = new System.Drawing.Size(135, 115);
            this.lTile8.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 31);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "O2%",
            "CO ppm",
            "CO lbs/hr",
            "CO TPY",
            "CO gr/bhp",
            "CO mmBTU/hr",
            "CO2%",
            "NO ppm",
            "NO2 ppm",
            "NOx ppm",
            "NOx lbs/hr",
            "NOx TPY",
            "NOx gr/bhp",
            "NOx mmBTU/hr",
            "SO2 ppm",
            "CxHy ppm",
            "T(gas)°F",
            "T(amb)°F",
            "T(cell)°F",
            "Efficiency",
            "I.Flow",
            "Draft",
            "Losses%",
            "Excess Air"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 23);
            this.toolStripComboBox1.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox1_SelectedItemChanged);
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.lTileLabel8);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 31);
            this.panel5.TabIndex = 7;
            // 
            // lTileLabel8
            // 
            this.lTileLabel8.AutoSize = true;
            this.lTileLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel8.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel8.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel8.Name = "lTileLabel8";
            this.lTileLabel8.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel8.TabIndex = 0;
            this.lTileLabel8.Text = "N/A";
            this.lTileLabel8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel8
            // 
            this.lLabel8.AutoSize = true;
            this.lLabel8.BackColor = System.Drawing.Color.Transparent;
            this.lLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel8.Location = new System.Drawing.Point(3, 31);
            this.lLabel8.Name = "lLabel8";
            this.lLabel8.Size = new System.Drawing.Size(129, 56);
            this.lLabel8.TabIndex = 14;
            this.lLabel8.Text = "----";
            this.lLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile7
            // 
            this.lTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile7.BackgroundImage")));
            this.lTile7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile7.ColumnCount = 1;
            this.lTile7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile7.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile7.Controls.Add(this.panel3, 0, 0);
            this.lTile7.Controls.Add(this.lLabel7, 0, 1);
            this.lTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile7.Location = new System.Drawing.Point(165, 275);
            this.lTile7.Margin = new System.Windows.Forms.Padding(10);
            this.lTile7.Name = "lTile7";
            this.lTile7.RowCount = 3;
            this.lTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile7.Size = new System.Drawing.Size(135, 115);
            this.lTile7.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lTileLabel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 31);
            this.panel3.TabIndex = 7;
            // 
            // lTileLabel7
            // 
            this.lTileLabel7.AutoSize = true;
            this.lTileLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel7.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel7.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel7.Name = "lTileLabel7";
            this.lTileLabel7.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel7.TabIndex = 0;
            this.lTileLabel7.Text = "N/A";
            this.lTileLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel7
            // 
            this.lLabel7.AutoSize = true;
            this.lLabel7.BackColor = System.Drawing.Color.Transparent;
            this.lLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel7.Location = new System.Drawing.Point(3, 31);
            this.lLabel7.Name = "lLabel7";
            this.lLabel7.Size = new System.Drawing.Size(129, 56);
            this.lLabel7.TabIndex = 14;
            this.lLabel7.Text = "----";
            this.lLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile3
            // 
            this.lTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile3.BackgroundImage")));
            this.lTile3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile3.ColumnCount = 1;
            this.lTile3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile3.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile3.Controls.Add(this.panel2, 0, 0);
            this.lTile3.Controls.Add(this.lLabel3, 0, 1);
            this.lTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile3.Location = new System.Drawing.Point(10, 143);
            this.lTile3.Margin = new System.Windows.Forms.Padding(10);
            this.lTile3.Name = "lTile3";
            this.lTile3.RowCount = 3;
            this.lTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile3.Size = new System.Drawing.Size(135, 112);
            this.lTile3.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lTileLabel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 31);
            this.panel2.TabIndex = 7;
            // 
            // lTileLabel3
            // 
            this.lTileLabel3.AutoSize = true;
            this.lTileLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel3.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel3.Name = "lTileLabel3";
            this.lTileLabel3.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel3.TabIndex = 0;
            this.lTileLabel3.Text = "N/A";
            this.lTileLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel3
            // 
            this.lLabel3.AutoSize = true;
            this.lLabel3.BackColor = System.Drawing.Color.Transparent;
            this.lLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel3.Location = new System.Drawing.Point(3, 31);
            this.lLabel3.Name = "lLabel3";
            this.lLabel3.Size = new System.Drawing.Size(129, 54);
            this.lLabel3.TabIndex = 14;
            this.lLabel3.Text = "----";
            this.lLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.SetColumnSpan(this.panel13, 3);
            this.panel13.ContextMenuStrip = this.tilePopUpMenu;
            this.panel13.Controls.Add(this.tableLayoutPanel4);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(10, 410);
            this.panel13.Margin = new System.Windows.Forms.Padding(10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(445, 141);
            this.panel13.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.label17, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.label19, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.label25, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.label26, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.label30, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 10);
            this.tableLayoutPanel4.Controls.Add(this.label36, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label38, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label43, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label48, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label55, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.label56, 0, 8);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 14;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(445, 141);
            this.tableLayoutPanel4.TabIndex = 32;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(225, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 19);
            this.label17.TabIndex = 28;
            this.label17.Text = "00:00:00";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(3, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(216, 19);
            this.label19.TabIndex = 23;
            this.label19.Text = "Purge:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label25.Location = new System.Drawing.Point(225, 57);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 19);
            this.label25.TabIndex = 27;
            this.label25.Text = "00:00:00";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(3, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(216, 19);
            this.label26.TabIndex = 4;
            this.label26.Text = "Test:";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(216, 19);
            this.label30.TabIndex = 31;
            this.label30.Text = "Sample Rate:";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.tableLayoutPanel4.SetColumnSpan(this.label31, 2);
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 114);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(439, 19);
            this.label31.TabIndex = 32;
            this.label31.Text = "## Machine(s) tested";
            this.label31.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.Color.Transparent;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label36.Location = new System.Drawing.Point(3, 38);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(216, 19);
            this.label36.TabIndex = 2;
            this.label36.Text = "Ramp Up:";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.Color.Transparent;
            this.label38.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label38.Location = new System.Drawing.Point(225, 38);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(69, 19);
            this.label38.TabIndex = 26;
            this.label38.Text = "00:00:00";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(3, 19);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(216, 19);
            this.label42.TabIndex = 1;
            this.label42.Text = "Cycle:";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(225, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(63, 19);
            this.label43.TabIndex = 34;
            this.label43.Text = "1 sec(s)";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(225, 19);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(50, 19);
            this.label48.TabIndex = 33;
            this.label48.Text = "1 of 1";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.ForeColor = System.Drawing.Color.Black;
            this.label55.Location = new System.Drawing.Point(225, 95);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(69, 19);
            this.label55.TabIndex = 4;
            this.label55.Text = "00:00:00";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label56.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.Color.Black;
            this.label56.Location = new System.Drawing.Point(3, 95);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(216, 19);
            this.label56.TabIndex = 37;
            this.label56.Text = "Total Test Time:";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lTile2
            // 
            this.lTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile2.BackgroundImage")));
            this.lTile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile2.ColumnCount = 1;
            this.lTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile2.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile2.Controls.Add(this.panel14, 0, 0);
            this.lTile2.Controls.Add(this.lLabel2, 0, 1);
            this.lTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile2.Location = new System.Drawing.Point(320, 10);
            this.lTile2.Margin = new System.Windows.Forms.Padding(10);
            this.lTile2.Name = "lTile2";
            this.lTile2.RowCount = 3;
            this.lTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile2.Size = new System.Drawing.Size(135, 113);
            this.lTile2.TabIndex = 4;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.lTileLabel2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(135, 31);
            this.panel14.TabIndex = 7;
            // 
            // lTileLabel2
            // 
            this.lTileLabel2.AutoSize = true;
            this.lTileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel2.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel2.Name = "lTileLabel2";
            this.lTileLabel2.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel2.TabIndex = 0;
            this.lTileLabel2.Text = "N/A";
            this.lTileLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel2
            // 
            this.lLabel2.AutoSize = true;
            this.lLabel2.BackColor = System.Drawing.Color.Transparent;
            this.lLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel2.Location = new System.Drawing.Point(3, 31);
            this.lLabel2.Name = "lLabel2";
            this.lLabel2.Size = new System.Drawing.Size(129, 54);
            this.lLabel2.TabIndex = 11;
            this.lLabel2.Text = "----";
            this.lLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile5
            // 
            this.lTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile5.BackgroundImage")));
            this.lTile5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile5.ColumnCount = 1;
            this.lTile5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile5.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile5.Controls.Add(this.panel17, 0, 0);
            this.lTile5.Controls.Add(this.lLabel5, 0, 1);
            this.lTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile5.Location = new System.Drawing.Point(320, 143);
            this.lTile5.Margin = new System.Windows.Forms.Padding(10);
            this.lTile5.Name = "lTile5";
            this.lTile5.RowCount = 3;
            this.lTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile5.Size = new System.Drawing.Size(135, 112);
            this.lTile5.TabIndex = 17;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.lTileLabel5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(135, 33);
            this.panel17.TabIndex = 7;
            // 
            // lTileLabel5
            // 
            this.lTileLabel5.AutoSize = true;
            this.lTileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel5.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel5.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel5.Name = "lTileLabel5";
            this.lTileLabel5.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel5.TabIndex = 0;
            this.lTileLabel5.Text = "N/A";
            this.lTileLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLabel5
            // 
            this.lLabel5.AutoSize = true;
            this.lLabel5.BackColor = System.Drawing.Color.Transparent;
            this.lLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel5.Location = new System.Drawing.Point(3, 33);
            this.lLabel5.Name = "lLabel5";
            this.lLabel5.Size = new System.Drawing.Size(129, 52);
            this.lLabel5.TabIndex = 16;
            this.lLabel5.Text = "----";
            this.lLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile4
            // 
            this.lTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile4.BackgroundImage")));
            this.lTile4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile4.ColumnCount = 1;
            this.lTile4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile4.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile4.Controls.Add(this.panel18, 0, 0);
            this.lTile4.Controls.Add(this.lLabel4, 0, 1);
            this.lTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile4.Location = new System.Drawing.Point(165, 143);
            this.lTile4.Margin = new System.Windows.Forms.Padding(10);
            this.lTile4.Name = "lTile4";
            this.lTile4.RowCount = 3;
            this.lTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile4.Size = new System.Drawing.Size(135, 112);
            this.lTile4.TabIndex = 16;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Controls.Add(this.lTileLabel4);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(135, 33);
            this.panel18.TabIndex = 7;
            // 
            // lTileLabel4
            // 
            this.lTileLabel4.AutoSize = true;
            this.lTileLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel4.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel4.Name = "lTileLabel4";
            this.lTileLabel4.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel4.TabIndex = 0;
            this.lTileLabel4.Text = "N/A";
            this.lTileLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel4
            // 
            this.lLabel4.AutoSize = true;
            this.lLabel4.BackColor = System.Drawing.Color.Transparent;
            this.lLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel4.Location = new System.Drawing.Point(3, 33);
            this.lLabel4.Name = "lLabel4";
            this.lLabel4.Size = new System.Drawing.Size(129, 52);
            this.lLabel4.TabIndex = 15;
            this.lLabel4.Text = "----";
            this.lLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile1
            // 
            this.lTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile1.BackgroundImage")));
            this.lTile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile1.ColumnCount = 1;
            this.lTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile1.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile1.Controls.Add(this.panel19, 0, 0);
            this.lTile1.Controls.Add(this.lLabel1, 0, 1);
            this.lTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile1.Location = new System.Drawing.Point(165, 10);
            this.lTile1.Margin = new System.Windows.Forms.Padding(10);
            this.lTile1.Name = "lTile1";
            this.lTile1.RowCount = 3;
            this.lTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile1.Size = new System.Drawing.Size(135, 113);
            this.lTile1.TabIndex = 15;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.Controls.Add(this.lTileLabel1);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(135, 31);
            this.panel19.TabIndex = 7;
            // 
            // lTileLabel1
            // 
            this.lTileLabel1.AutoSize = true;
            this.lTileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel1.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel1.Name = "lTileLabel1";
            this.lTileLabel1.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel1.TabIndex = 0;
            this.lTileLabel1.Text = "N/A";
            this.lTileLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel1
            // 
            this.lLabel1.AutoSize = true;
            this.lLabel1.BackColor = System.Drawing.Color.Transparent;
            this.lLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel1.Location = new System.Drawing.Point(3, 31);
            this.lLabel1.Name = "lLabel1";
            this.lLabel1.Size = new System.Drawing.Size(129, 54);
            this.lLabel1.TabIndex = 10;
            this.lLabel1.Text = "----";
            this.lLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lTile0
            // 
            this.lTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile0.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile0.BackgroundImage")));
            this.lTile0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile0.ColumnCount = 1;
            this.lTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile0.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile0.Controls.Add(this.panel20, 0, 0);
            this.lTile0.Controls.Add(this.lLabel0, 0, 1);
            this.lTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile0.Location = new System.Drawing.Point(10, 10);
            this.lTile0.Margin = new System.Windows.Forms.Padding(10);
            this.lTile0.Name = "lTile0";
            this.lTile0.RowCount = 3;
            this.lTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.1358F));
            this.lTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.8642F));
            this.lTile0.Size = new System.Drawing.Size(135, 113);
            this.lTile0.TabIndex = 14;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.Controls.Add(this.lTileLabel0);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(135, 31);
            this.panel20.TabIndex = 7;
            // 
            // lTileLabel0
            // 
            this.lTileLabel0.AutoSize = true;
            this.lTileLabel0.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel0.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel0.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel0.ForeColor = System.Drawing.Color.Black;
            this.lTileLabel0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel0.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel0.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel0.Name = "lTileLabel0";
            this.lTileLabel0.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel0.TabIndex = 0;
            this.lTileLabel0.Text = "N/A";
            this.lTileLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lLabel0
            // 
            this.lLabel0.AutoSize = true;
            this.lLabel0.BackColor = System.Drawing.Color.Transparent;
            this.lLabel0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel0.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel0.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel0.Location = new System.Drawing.Point(3, 31);
            this.lLabel0.Name = "lLabel0";
            this.lLabel0.Size = new System.Drawing.Size(129, 56);
            this.lLabel0.TabIndex = 9;
            this.lLabel0.Text = "----";
            this.lLabel0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea4.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea4.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(468, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.tableLayoutPanel3.SetRowSpan(this.chart1, 4);
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series55.Legend = "Legend1";
            series55.Name = "O2";
            series55.Points.Add(dataPoint63);
            series55.Points.Add(dataPoint64);
            series55.Points.Add(dataPoint65);
            series55.Points.Add(dataPoint66);
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series56.Legend = "Legend1";
            series56.Name = "CO";
            series56.Points.Add(dataPoint67);
            series56.Points.Add(dataPoint68);
            series56.Points.Add(dataPoint69);
            series56.Points.Add(dataPoint70);
            series56.Points.Add(dataPoint71);
            series56.Points.Add(dataPoint72);
            series56.Points.Add(dataPoint73);
            series56.Points.Add(dataPoint74);
            series57.ChartArea = "ChartArea1";
            series57.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series57.Legend = "Legend1";
            series57.Name = "CO2";
            series58.ChartArea = "ChartArea1";
            series58.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series58.Legend = "Legend1";
            series58.Name = "NO";
            series59.ChartArea = "ChartArea1";
            series59.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series59.Legend = "Legend1";
            series59.Name = "NO2";
            series60.ChartArea = "ChartArea1";
            series60.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series60.Legend = "Legend1";
            series60.Name = "NOx";
            series60.YValueMembers = "Tag";
            series61.ChartArea = "ChartArea1";
            series61.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series61.Legend = "Legend1";
            series61.Name = "SO2";
            series62.ChartArea = "ChartArea1";
            series62.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series62.Legend = "Legend1";
            series62.Name = "CxHy";
            series63.ChartArea = "ChartArea1";
            series63.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series63.Legend = "Legend1";
            series63.Name = "T(gas)";
            series64.ChartArea = "ChartArea1";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series64.Legend = "Legend1";
            series64.Name = "T(amb)";
            series65.ChartArea = "ChartArea1";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series65.Legend = "Legend1";
            series65.Name = "T(cell)";
            series66.ChartArea = "ChartArea1";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series66.Legend = "Legend1";
            series66.Name = "Efficiency";
            series67.ChartArea = "ChartArea1";
            series67.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series67.Legend = "Legend1";
            series67.Name = "I.Flow";
            series68.ChartArea = "ChartArea1";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series68.Legend = "Legend1";
            series68.Name = "Draft";
            series69.ChartArea = "ChartArea1";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series69.Legend = "Legend1";
            series69.Name = "Losses";
            series70.ChartArea = "ChartArea1";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series70.Legend = "Legend1";
            series70.Name = "Excess Air";
            series71.ChartArea = "ChartArea1";
            series71.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series71.Legend = "Legend1";
            series71.Name = "CO(mass)";
            series72.ChartArea = "ChartArea1";
            series72.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series72.Legend = "Legend1";
            series72.Name = "NOx(mass)";
            this.chart1.Series.Add(series55);
            this.chart1.Series.Add(series56);
            this.chart1.Series.Add(series57);
            this.chart1.Series.Add(series58);
            this.chart1.Series.Add(series59);
            this.chart1.Series.Add(series60);
            this.chart1.Series.Add(series61);
            this.chart1.Series.Add(series62);
            this.chart1.Series.Add(series63);
            this.chart1.Series.Add(series64);
            this.chart1.Series.Add(series65);
            this.chart1.Series.Add(series66);
            this.chart1.Series.Add(series67);
            this.chart1.Series.Add(series68);
            this.chart1.Series.Add(series69);
            this.chart1.Series.Add(series70);
            this.chart1.Series.Add(series71);
            this.chart1.Series.Add(series72);
            this.chart1.Size = new System.Drawing.Size(537, 555);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // lTile6
            // 
            this.lTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lTile6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lTile6.BackgroundImage")));
            this.lTile6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lTile6.ColumnCount = 1;
            this.lTile6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lTile6.ContextMenuStrip = this.contextMenuStrip1;
            this.lTile6.Controls.Add(this.panel23, 0, 0);
            this.lTile6.Controls.Add(this.lLabel6, 0, 1);
            this.lTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTile6.Location = new System.Drawing.Point(10, 275);
            this.lTile6.Margin = new System.Windows.Forms.Padding(10);
            this.lTile6.Name = "lTile6";
            this.lTile6.RowCount = 3;
            this.lTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.lTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.lTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.lTile6.Size = new System.Drawing.Size(135, 115);
            this.lTile6.TabIndex = 11;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.Controls.Add(this.lTileLabel6);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(135, 31);
            this.panel23.TabIndex = 7;
            // 
            // lTileLabel6
            // 
            this.lTileLabel6.AutoSize = true;
            this.lTileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lTileLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.lTileLabel6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lTileLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lTileLabel6.Location = new System.Drawing.Point(0, 0);
            this.lTileLabel6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.lTileLabel6.Name = "lTileLabel6";
            this.lTileLabel6.Size = new System.Drawing.Size(60, 31);
            this.lTileLabel6.TabIndex = 0;
            this.lTileLabel6.Text = "N/A";
            this.lTileLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lLabel6
            // 
            this.lLabel6.AutoSize = true;
            this.lLabel6.BackColor = System.Drawing.Color.Transparent;
            this.lLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.lLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lLabel6.Location = new System.Drawing.Point(3, 31);
            this.lLabel6.Name = "lLabel6";
            this.lLabel6.Size = new System.Drawing.Size(129, 56);
            this.lLabel6.TabIndex = 14;
            this.lLabel6.Text = "----";
            this.lLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.tableLayoutPanel12);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1014, 567);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analyzer Control";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.tableLayoutPanel12.ColumnCount = 2;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.75793F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.24206F));
            this.tableLayoutPanel12.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.tableLayoutPanel18, 1, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1008, 561);
            this.tableLayoutPanel12.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::CRS.Properties.Resources.Analyzer_control;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.button16);
            this.panel4.Controls.Add(this.button15);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(677, 556);
            this.panel4.TabIndex = 5;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.BackColor = System.Drawing.Color.Transparent;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button16.Location = new System.Drawing.Point(329, 165);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(188, 28);
            this.button16.TabIndex = 1;
            this.button16.Text = "Start Peristaltik Pump";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.pPump_Click);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.BackColor = System.Drawing.Color.Transparent;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(193, 59);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(188, 26);
            this.button15.TabIndex = 0;
            this.button15.Text = "Beep";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.buzzer_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 4;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel18.Controls.Add(this.O2_Vlbl, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.serialNO_lbl, 3, 0);
            this.tableLayoutPanel18.Controls.Add(this.label28, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.CO_Vlbl, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label34, 2, 1);
            this.tableLayoutPanel18.Controls.Add(this.operationHrs_lbl, 3, 1);
            this.tableLayoutPanel18.Controls.Add(this.label35, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.NO_Vlbl, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.label37, 2, 2);
            this.tableLayoutPanel18.Controls.Add(this.ProgramVrs_lbl, 3, 2);
            this.tableLayoutPanel18.Controls.Add(this.label39, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.NO2_Vlbl, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.label58, 0, 4);
            this.tableLayoutPanel18.Controls.Add(this.batt_Vlbl, 1, 4);
            this.tableLayoutPanel18.Controls.Add(this.label65, 0, 5);
            this.tableLayoutPanel18.Controls.Add(this.battB_Vlbl, 1, 5);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(686, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 6;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.Size = new System.Drawing.Size(319, 106);
            this.tableLayoutPanel18.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(154, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(99, 17);
            this.label27.TabIndex = 3;
            this.label27.Text = "Serial NO.    #";
            // 
            // O2_Vlbl
            // 
            this.O2_Vlbl.AutoSize = true;
            this.O2_Vlbl.Location = new System.Drawing.Point(101, 0);
            this.O2_Vlbl.Name = "O2_Vlbl";
            this.O2_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.O2_Vlbl.TabIndex = 1;
            this.O2_Vlbl.Text = "0000v";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(92, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "O2";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serialNO_lbl
            // 
            this.serialNO_lbl.AutoSize = true;
            this.serialNO_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serialNO_lbl.Location = new System.Drawing.Point(259, 0);
            this.serialNO_lbl.Name = "serialNO_lbl";
            this.serialNO_lbl.Size = new System.Drawing.Size(57, 17);
            this.serialNO_lbl.TabIndex = 2;
            this.serialNO_lbl.Text = "label26";
            this.serialNO_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(3, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(92, 17);
            this.label28.TabIndex = 4;
            this.label28.Text = "CO";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CO_Vlbl
            // 
            this.CO_Vlbl.AutoSize = true;
            this.CO_Vlbl.Location = new System.Drawing.Point(101, 17);
            this.CO_Vlbl.Name = "CO_Vlbl";
            this.CO_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.CO_Vlbl.TabIndex = 5;
            this.CO_Vlbl.Text = "0000v";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(154, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 17);
            this.label34.TabIndex = 6;
            this.label34.Text = "Operation Hrs";
            // 
            // operationHrs_lbl
            // 
            this.operationHrs_lbl.AutoSize = true;
            this.operationHrs_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationHrs_lbl.Location = new System.Drawing.Point(259, 17);
            this.operationHrs_lbl.Name = "operationHrs_lbl";
            this.operationHrs_lbl.Size = new System.Drawing.Size(57, 17);
            this.operationHrs_lbl.TabIndex = 7;
            this.operationHrs_lbl.Text = "label34";
            this.operationHrs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(3, 34);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(92, 17);
            this.label35.TabIndex = 8;
            this.label35.Text = "NO";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NO_Vlbl
            // 
            this.NO_Vlbl.AutoSize = true;
            this.NO_Vlbl.Location = new System.Drawing.Point(101, 34);
            this.NO_Vlbl.Name = "NO_Vlbl";
            this.NO_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.NO_Vlbl.TabIndex = 9;
            this.NO_Vlbl.Text = "0000v";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(154, 34);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 17);
            this.label37.TabIndex = 10;
            this.label37.Text = "Program Vrs";
            // 
            // ProgramVrs_lbl
            // 
            this.ProgramVrs_lbl.AutoSize = true;
            this.ProgramVrs_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProgramVrs_lbl.Location = new System.Drawing.Point(259, 34);
            this.ProgramVrs_lbl.Name = "ProgramVrs_lbl";
            this.ProgramVrs_lbl.Size = new System.Drawing.Size(57, 17);
            this.ProgramVrs_lbl.TabIndex = 11;
            this.ProgramVrs_lbl.Text = "label38";
            this.ProgramVrs_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(3, 51);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(92, 17);
            this.label39.TabIndex = 12;
            this.label39.Text = "NO2";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NO2_Vlbl
            // 
            this.NO2_Vlbl.AutoSize = true;
            this.NO2_Vlbl.Location = new System.Drawing.Point(101, 51);
            this.NO2_Vlbl.Name = "NO2_Vlbl";
            this.NO2_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.NO2_Vlbl.TabIndex = 13;
            this.NO2_Vlbl.Text = "0000v";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Location = new System.Drawing.Point(3, 68);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(92, 17);
            this.label58.TabIndex = 16;
            this.label58.Text = "Battery";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // batt_Vlbl
            // 
            this.batt_Vlbl.AutoSize = true;
            this.batt_Vlbl.Location = new System.Drawing.Point(101, 68);
            this.batt_Vlbl.Name = "batt_Vlbl";
            this.batt_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.batt_Vlbl.TabIndex = 17;
            this.batt_Vlbl.Text = "0000v";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Location = new System.Drawing.Point(3, 85);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(92, 21);
            this.label65.TabIndex = 20;
            this.label65.Text = "Battery Base";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // battB_Vlbl
            // 
            this.battB_Vlbl.AutoSize = true;
            this.battB_Vlbl.Location = new System.Drawing.Point(101, 85);
            this.battB_Vlbl.Name = "battB_Vlbl";
            this.battB_Vlbl.Size = new System.Drawing.Size(47, 17);
            this.battB_Vlbl.TabIndex = 21;
            this.battB_Vlbl.Text = "0000v";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.00671F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.99329F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel16.Controls.Add(this.analyzerSignal, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(578, 0);
            this.tableLayoutPanel16.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel16, 2);
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(450, 72);
            this.tableLayoutPanel16.TabIndex = 24;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.iflowlbl, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.flowlbl, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(226, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel16.SetRowSpan(this.tableLayoutPanel17, 2);
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(209, 66);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // iflowlbl
            // 
            this.iflowlbl.AutoSize = true;
            this.iflowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iflowlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iflowlbl.ForeColor = System.Drawing.Color.Black;
            this.iflowlbl.Location = new System.Drawing.Point(6, 3);
            this.iflowlbl.Name = "iflowlbl";
            this.iflowlbl.Size = new System.Drawing.Size(197, 28);
            this.iflowlbl.TabIndex = 0;
            this.iflowlbl.Text = "0.0";
            this.iflowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowlbl
            // 
            this.flowlbl.AutoSize = true;
            this.flowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowlbl.ForeColor = System.Drawing.Color.Black;
            this.flowlbl.Location = new System.Drawing.Point(6, 34);
            this.flowlbl.Name = "flowlbl";
            this.flowlbl.Size = new System.Drawing.Size(197, 29);
            this.flowlbl.TabIndex = 1;
            this.flowlbl.Text = "I.Flow (L/min)";
            this.flowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(97, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Not Connected";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupEquipmentSiteToolStripMenuItem,
            this.dataToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.menuCalibrationItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(352, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedFunctionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveReportToolStripMenuItem,
            this.browseReportsToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // advancedFunctionsToolStripMenuItem
            // 
            this.advancedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem});
            this.advancedFunctionsToolStripMenuItem.Name = "advancedFunctionsToolStripMenuItem";
            this.advancedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.advancedFunctionsToolStripMenuItem.Text = "Advanced Functions";
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.instrumentToolStripMenuItem.Text = "Instrument";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            this.browseReportsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.browseReportsToolStripMenuItem.Text = "Browse Reports";
            this.browseReportsToolStripMenuItem.Click += new System.EventHandler(this.browseReportsToolStripMenuItem_Click);
            // 
            // setupEquipmentSiteToolStripMenuItem
            // 
            this.setupEquipmentSiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.toolStripSeparator4,
            this.themeToolStripMenuItem});
            this.setupEquipmentSiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupEquipmentSiteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.setupEquipmentSiteToolStripMenuItem.Name = "setupEquipmentSiteToolStripMenuItem";
            this.setupEquipmentSiteToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.setupEquipmentSiteToolStripMenuItem.Text = "Edit";
            // 
            // personalDataToolStripMenuItem
            // 
            this.personalDataToolStripMenuItem.Name = "personalDataToolStripMenuItem";
            this.personalDataToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.personalDataToolStripMenuItem.Text = "Personal Data";
            this.personalDataToolStripMenuItem.Click += new System.EventHandler(this.personalDataToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.customerToolStripMenuItem.Text = "Customer Data";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(160, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackBlueColorToolStripMenuItem,
            this.blueBlackToolStripMenuItem,
            this.blueWhiteColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // blackBlueColorToolStripMenuItem
            // 
            this.blackBlueColorToolStripMenuItem.Name = "blackBlueColorToolStripMenuItem";
            this.blackBlueColorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.blackBlueColorToolStripMenuItem.Text = "Blue-Gray";
            this.blackBlueColorToolStripMenuItem.Click += new System.EventHandler(this.blue25GrayColorToolStripMenuItem_Click);
            // 
            // blueBlackToolStripMenuItem
            // 
            this.blueBlackToolStripMenuItem.Name = "blueBlackToolStripMenuItem";
            this.blueBlackToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.blueBlackToolStripMenuItem.Text = "Blue-Black";
            this.blueBlackToolStripMenuItem.Click += new System.EventHandler(this.blueBlackToolStripMenuItem_Click);
            // 
            // blueWhiteColorToolStripMenuItem
            // 
            this.blueWhiteColorToolStripMenuItem.Name = "blueWhiteColorToolStripMenuItem";
            this.blueWhiteColorToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.blueWhiteColorToolStripMenuItem.Text = "Blue-White";
            this.blueWhiteColorToolStripMenuItem.Click += new System.EventHandler(this.blueWhiteColorToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTestRecordsToolStripMenuItem,
            this.viewSnapshotsToolStripMenuItem,
            this.applyO2CorrectionToolStripMenuItem});
            this.dataToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewTestRecordsToolStripMenuItem
            // 
            this.viewTestRecordsToolStripMenuItem.Name = "viewTestRecordsToolStripMenuItem";
            this.viewTestRecordsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.viewTestRecordsToolStripMenuItem.Text = "View Test Records";
            this.viewTestRecordsToolStripMenuItem.Click += new System.EventHandler(this.viewTestRecordsToolStripMenuItem_Click);
            // 
            // viewSnapshotsToolStripMenuItem
            // 
            this.viewSnapshotsToolStripMenuItem.Name = "viewSnapshotsToolStripMenuItem";
            this.viewSnapshotsToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.viewSnapshotsToolStripMenuItem.Text = "View Snapshots";
            this.viewSnapshotsToolStripMenuItem.Click += new System.EventHandler(this.viewSnapshotsToolStripMenuItem_Click);
            // 
            // applyO2CorrectionToolStripMenuItem
            // 
            this.applyO2CorrectionToolStripMenuItem.Name = "applyO2CorrectionToolStripMenuItem";
            this.applyO2CorrectionToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.applyO2CorrectionToolStripMenuItem.Text = "Apply O2 Correction";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureRecordingToolStripMenuItem,
            this.configureReportToolStripMenuItem,
            this.performPreAndPostCalibrationToolStripMenuItem,
            this.setupCommunictaionPortsToolStripMenuItem});
            this.configureToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configureToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            this.configureToolStripMenuItem.Size = new System.Drawing.Size(86, 21);
            this.configureToolStripMenuItem.Text = "Procedures";
            // 
            // configureRecordingToolStripMenuItem
            // 
            this.configureRecordingToolStripMenuItem.Name = "configureRecordingToolStripMenuItem";
            this.configureRecordingToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.configureRecordingToolStripMenuItem.Text = "Set-Up Procedure";
            this.configureRecordingToolStripMenuItem.Click += new System.EventHandler(this.configureRecordingToolStripMenuItem_Click);
            // 
            // configureReportToolStripMenuItem
            // 
            this.configureReportToolStripMenuItem.Name = "configureReportToolStripMenuItem";
            this.configureReportToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.configureReportToolStripMenuItem.Text = "Set-Up Report";
            this.configureReportToolStripMenuItem.Click += new System.EventHandler(this.configureReportToolStripMenuItem_Click);
            // 
            // performPreAndPostCalibrationToolStripMenuItem
            // 
            this.performPreAndPostCalibrationToolStripMenuItem.Checked = true;
            this.performPreAndPostCalibrationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.performPreAndPostCalibrationToolStripMenuItem.Enabled = false;
            this.performPreAndPostCalibrationToolStripMenuItem.Name = "performPreAndPostCalibrationToolStripMenuItem";
            this.performPreAndPostCalibrationToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.performPreAndPostCalibrationToolStripMenuItem.Text = "Perform Pre and Post Calibration Procedures";
            // 
            // setupCommunictaionPortsToolStripMenuItem
            // 
            this.setupCommunictaionPortsToolStripMenuItem.Name = "setupCommunictaionPortsToolStripMenuItem";
            this.setupCommunictaionPortsToolStripMenuItem.Size = new System.Drawing.Size(338, 22);
            this.setupCommunictaionPortsToolStripMenuItem.Text = "Setup Communication";
            this.setupCommunictaionPortsToolStripMenuItem.Click += new System.EventHandler(this.setupCommunictaionPortsToolStripMenuItem_Click);
            // 
            // menuCalibrationItem
            // 
            this.menuCalibrationItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCalibrationItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuCalibrationItem.Name = "menuCalibrationItem";
            this.menuCalibrationItem.Size = new System.Drawing.Size(83, 21);
            this.menuCalibrationItem.Text = "Calibration";
            this.menuCalibrationItem.Click += new System.EventHandler(this.menuCalibrationItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpgradeToolStripMenuItem,
            this.aboutAdvDASToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkUpgradeToolStripMenuItem
            // 
            this.checkUpgradeToolStripMenuItem.Name = "checkUpgradeToolStripMenuItem";
            this.checkUpgradeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.checkUpgradeToolStripMenuItem.Text = "Check Upgrade";
            // 
            // aboutAdvDASToolStripMenuItem
            // 
            this.aboutAdvDASToolStripMenuItem.Name = "aboutAdvDASToolStripMenuItem";
            this.aboutAdvDASToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutAdvDASToolStripMenuItem.Text = "About CRS";
            this.aboutAdvDASToolStripMenuItem.Click += new System.EventHandler(this.aboutAdvDASToolStripMenuItem_Click);
            // 
            // analyzerSignal
            // 
            this.analyzerSignal.BackgroundStyle = WindowWidgets.SignalStrengthBackgroundStyle.Normal;
            this.analyzerSignal.BarLayout = WindowWidgets.SignalStrengthLayout.LeftToRight;
            this.analyzerSignal.BarSpacing = 2;
            this.analyzerSignal.BarStepSize = 20;
            this.analyzerSignal.CenterGradientColor = System.Drawing.Color.WhiteSmoke;
            this.analyzerSignal.Dock = System.Windows.Forms.DockStyle.Right;
            this.analyzerSignal.EmptyBarColor = System.Drawing.Color.Gray;
            this.analyzerSignal.GoodSignalColor = System.Drawing.Color.Green;
            this.analyzerSignal.GoodSignalThreshold = 0.8F;
            this.analyzerSignal.Location = new System.Drawing.Point(146, 3);
            this.analyzerSignal.MaximumValue = 1F;
            this.analyzerSignal.MinimumValue = 0F;
            this.analyzerSignal.Name = "analyzerSignal";
            this.analyzerSignal.NoSignalColor = System.Drawing.Color.White;
            this.analyzerSignal.NoSignalThreshold = 0F;
            this.analyzerSignal.NumberOfBars = 5;
            this.analyzerSignal.PoorSignalColor = System.Drawing.Color.Yellow;
            this.analyzerSignal.PoorSignalThreshold = 0.5F;
            this.analyzerSignal.Size = new System.Drawing.Size(74, 48);
            this.analyzerSignal.SmallBarHeight = 10;
            this.analyzerSignal.UseSolidBars = false;
            this.analyzerSignal.Value = 0F;
            this.analyzerSignal.WeakSignalColor = System.Drawing.Color.Red;
            this.analyzerSignal.WeakSignalThreshold = 0.2F;
            this.analyzerSignal.XColor = System.Drawing.Color.Red;
            this.analyzerSignal.XIfNoSignal = true;
            this.analyzerSignal.XWidth = 1.5F;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(1028, 683);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "ECOM America: CRS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.tilePopUpMenu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.sTile8.ResumeLayout(false);
            this.sTile8.PerformLayout();
            this.sTile9.ResumeLayout(false);
            this.sTile9.PerformLayout();
            this.sTile10.ResumeLayout(false);
            this.sTile10.PerformLayout();
            this.sTile11.ResumeLayout(false);
            this.sTile11.PerformLayout();
            this.sTile2.ResumeLayout(false);
            this.sTile2.PerformLayout();
            this.sTile7.ResumeLayout(false);
            this.sTile7.PerformLayout();
            this.sTile6.ResumeLayout(false);
            this.sTile6.PerformLayout();
            this.sTile5.ResumeLayout(false);
            this.sTile5.PerformLayout();
            this.sTile1.ResumeLayout(false);
            this.sTile1.PerformLayout();
            this.sTile3.ResumeLayout(false);
            this.sTile3.PerformLayout();
            this.sTile4.ResumeLayout(false);
            this.sTile4.PerformLayout();
            this.sTile0.ResumeLayout(false);
            this.sTile0.PerformLayout();
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.lTile8.ResumeLayout(false);
            this.lTile8.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.lTile7.ResumeLayout(false);
            this.lTile7.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.lTile3.ResumeLayout(false);
            this.lTile3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.lTile2.ResumeLayout(false);
            this.lTile2.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.lTile5.ResumeLayout(false);
            this.lTile5.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.lTile4.ResumeLayout(false);
            this.lTile4.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.lTile1.ResumeLayout(false);
            this.lTile1.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.lTile0.ResumeLayout(false);
            this.lTile0.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.lTile6.ResumeLayout(false);
            this.lTile6.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.ContextMenuStrip tilePopUpMenu;



        ////////////////////////////////////////LABELS//////////////////////////////////////////

        //////////////////////////////////////////PANELS///////////////////////////////////////// 

        //////////////////////////////////////////TOOLSTRIPMENUITEMS/////////////////////////////////////////
        private System.Windows.Forms.ToolStripMenuItem editDisplayToolStripMenuItem;


        //////////////////////////////////////////CHECKBOXES/////////////////////////////////////////

        //////////////////////////////////////////TEXTBOXS/////////////////////////////////////////

        //////////////////////////////////////////TABLELAYOUTPANELS/////////////////////////////////////////


        //////////////////////////////////////////BUTTONS/////////////////////////////////////////
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolTip toolTip1;

        public DateTime startTime = DateTime.Now;
        private System.Windows.Forms.Timer recordSignTimer;
        internal System.Windows.Forms.Timer dataGridTimer;
        private ToolStripPanel BottomToolStripPanel;
        private ToolStripPanel TopToolStripPanel;
        private ToolStripPanel RightToolStripPanel;
        private ToolStripPanel LeftToolStripPanel;
        private ToolStripContentPanel ContentPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel12;
        private Button snapShotButton;
        private Button stopRecordingButton;
        private Button startRecordingButton;
        private PictureBox recordingSign;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sTile8;
        private Button tileButton9;
        private Label label9;
        private Label tileLabel9;
        private TableLayoutPanel sTile9;
        private Button tileButton10;
        private Label label10;
        private Label tileLabel10;
        private TableLayoutPanel sTile10;
        private Button tileButton11;
        private Label label11;
        private Label tileLabel11;
        private TableLayoutPanel sTile11;
        private Button tileButton12;
        private Label label12;
        private Label tileLabel12;
        private TableLayoutPanel sTile2;
        private Label label3;
        private Label tileLabel3;
        private Button tileButton3;
        private TableLayoutPanel sTile7;
        private Button tileButton8;
        private Label label8;
        private Label tileLabel8;
        private TableLayoutPanel sTile6;
        private Button tileButton7;
        private Label label7;
        private Label tileLabel7;
        private TableLayoutPanel sTile5;
        private Button tileButton6;
        private Label label6;
        private Label tileLabel6;
        private TableLayoutPanel sTile1;
        private Button tileButton2;
        private Label label2;
        private Label tileLabel2;
        private TableLayoutPanel sTile3;
        private Button tileButton4;
        private Label label4;
        private Label tileLabel4;
        private TableLayoutPanel sTile4;
        private Button tileButton5;
        public Label label5;
        private Label tileLabel5;
        private TableLayoutPanel sTile0;
        private Label label1;
        private Label tileLabel1;
        private Button tileButton1;
        private TableLayoutPanel tableLayoutPanel19;
        private Label pTimelbl;
        private Label plbl;
        private Label tTimelbl;
        private Label tlbl;
        private Label label13;
        private Label label21;
        private Label label14;
        private Label rlbl;
        private Label rTimelbl;
        private Label cycleLabel;
        private Label label23;
        private Label label22;
        private Button button1;
        private Label clock_lbl;
        private Label recordTimeLabel;
        private Label label15;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel14;
        private Panel panel1;
        private Button button2;
        public DataGridView elementTable;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgValue;
        private DataGridViewTextBoxColumn dgUnit;
        private DataGridViewCheckBoxColumn dgGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart trendGraph;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel lTile8;
        private Panel panel5;
        public Label lTileLabel8;
        private Label lLabel8;
        private TableLayoutPanel lTile7;
        private Panel panel3;
        public Label lTileLabel7;
        private Label lLabel7;
        private TableLayoutPanel lTile3;
        private Panel panel2;
        public Label lTileLabel3;
        private Label lLabel3;
        private Panel panel13;
        private TableLayoutPanel lTile2;
        private Panel panel14;
        public Label lTileLabel2;
        private Label lLabel2;
        private TableLayoutPanel lTile5;
        private Panel panel17;
        public Label lTileLabel5;
        private Label lLabel5;
        private TableLayoutPanel lTile4;
        private Panel panel18;
        public Label lTileLabel4;
        private Label lLabel4;
        private TableLayoutPanel lTile1;
        private Panel panel19;
        public Label lTileLabel1;
        private Label lLabel1;
        private TableLayoutPanel lTile0;
        private Panel panel20;
        public Label lTileLabel0;
        private Label lLabel0;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel lTile6;
        private Panel panel23;
        public Label lTileLabel6;
        private Label lLabel6;
        private TabPage tabPage4;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel panel4;
        private Button button16;
        private Button button15;
        private TableLayoutPanel tableLayoutPanel18;
        private Label label27;
        private Label O2_Vlbl;
        private Label label24;
        private Label serialNO_lbl;
        private Label label28;
        private Label CO_Vlbl;
        private Label label34;
        private Label operationHrs_lbl;
        private Label label35;
        private Label NO_Vlbl;
        private Label label37;
        private Label ProgramVrs_lbl;
        private Label label39;
        private Label NO2_Vlbl;
        private Label label58;
        private Label batt_Vlbl;
        private Label label65;
        private Label battB_Vlbl;
        private TableLayoutPanel tableLayoutPanel16;
        private TableLayoutPanel tableLayoutPanel17;
        private Label iflowlbl;
        private Label flowlbl;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem advancedFunctionsToolStripMenuItem;
        private ToolStripMenuItem instrumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem saveReportToolStripMenuItem;
        private ToolStripMenuItem browseReportsToolStripMenuItem;
        private ToolStripMenuItem setupEquipmentSiteToolStripMenuItem;
        private ToolStripMenuItem personalDataToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem blackBlueColorToolStripMenuItem;
        private ToolStripMenuItem blueBlackToolStripMenuItem;
        private ToolStripMenuItem blueWhiteColorToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem viewTestRecordsToolStripMenuItem;
        private ToolStripMenuItem applyO2CorrectionToolStripMenuItem;
        private ToolStripMenuItem configureToolStripMenuItem;
        private ToolStripMenuItem configureRecordingToolStripMenuItem;
        private ToolStripMenuItem configureReportToolStripMenuItem;
        private ToolStripMenuItem performPreAndPostCalibrationToolStripMenuItem;
        private ToolStripMenuItem setupCommunictaionPortsToolStripMenuItem;
        private ToolStripMenuItem menuCalibrationItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem checkUpgradeToolStripMenuItem;
        private ToolStripMenuItem aboutAdvDASToolStripMenuItem;
        private ToolStripMenuItem viewSnapshotsToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label17;
        private Label label19;
        private Label label25;
        private Label label26;
        private Label label30;
        private Label label31;
        private Label label36;
        private Label label38;
        private Label label42;
        private Label label43;
        private Label label48;
        private Label label55;
        private Label label56;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripComboBox toolStripComboBox1;
        private WindowWidgets.SignalStrength analyzerSignal;


    }
}

