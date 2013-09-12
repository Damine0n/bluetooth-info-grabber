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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series35 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint38 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint39 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint40 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4.6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series36 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series37 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series38 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series39 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series40 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 261D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series41 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series42 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series43 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 350D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 290D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series44 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 75D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint61 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint62 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series45 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series46 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series47 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series48 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series49 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series50 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series51 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series52 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series53 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint63 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint64 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint65 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint66 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series54 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint67 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint68 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint69 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint70 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint71 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint72 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint73 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint74 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series55 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series56 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.equipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueWhiteColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueBlackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackBlueColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTestRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyO2CorrectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureRecordingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configureReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.performPreAndPostCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupCommunictaionPortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalibrationItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCalibrationInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterCalGasInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.preTestCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postTestCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.abortCalibrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAdvDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tilePopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.snapShotButton = new System.Windows.Forms.Button();
            this.stopRecordingButton = new System.Windows.Forms.Button();
            this.startRecordingButton = new System.Windows.Forms.Button();
            this.tileButton3 = new System.Windows.Forms.Button();
            this.tileButton10 = new System.Windows.Forms.Button();
            this.tileButton9 = new System.Windows.Forms.Button();
            this.tileButton8 = new System.Windows.Forms.Button();
            this.tileButton7 = new System.Windows.Forms.Button();
            this.tileButton2 = new System.Windows.Forms.Button();
            this.tileButton5 = new System.Windows.Forms.Button();
            this.tileButton4 = new System.Windows.Forms.Button();
            this.tileButton6 = new System.Windows.Forms.Button();
            this.tileButton1 = new System.Windows.Forms.Button();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.recordSign = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.tileButton11 = new System.Windows.Forms.Button();
            this.label11_ = new System.Windows.Forms.Label();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.rLabela2 = new System.Windows.Forms.Label();
            this.rLabela1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.hTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label12_ = new System.Windows.Forms.Label();
            this.tileButton12 = new System.Windows.Forms.Button();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.rLabelb2 = new System.Windows.Forms.Label();
            this.rLabelb1 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.cycleLabel = new System.Windows.Forms.Label();
            this.rTimelbl = new System.Windows.Forms.Label();
            this.tTimelbl = new System.Windows.Forms.Label();
            this.pTimelbl = new System.Windows.Forms.Label();
            this.plbl = new System.Windows.Forms.Label();
            this.tlbl = new System.Windows.Forms.Label();
            this.rlbl = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label19 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label43 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label59 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.recordingSign = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.iflowlbl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.phaseTimeLabel = new System.Windows.Forms.Label();
            this.recordingProgressBar = new System.Windows.Forms.ProgressBar();
            this.connectionStatusLabel = new System.Windows.Forms.Label();
            this.recordTimeLabel = new System.Windows.Forms.Label();
            this.clock_lbl = new System.Windows.Forms.Label();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.menuStrip1.SuspendLayout();
            this.tilePopUpMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.hTile0.SuspendLayout();
            this.sTile2.SuspendLayout();
            this.sTile9.SuspendLayout();
            this.sTile8.SuspendLayout();
            this.sTile7.SuspendLayout();
            this.sTile6.SuspendLayout();
            this.sTile1.SuspendLayout();
            this.sTile4.SuspendLayout();
            this.sTile3.SuspendLayout();
            this.sTile5.SuspendLayout();
            this.hTile1.SuspendLayout();
            this.sTile0.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel14.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel17.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.panel18.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.panel19.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.panel20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel23.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.panel7.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(326, 24);
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
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // advancedFunctionsToolStripMenuItem
            // 
            this.advancedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem});
            this.advancedFunctionsToolStripMenuItem.Name = "advancedFunctionsToolStripMenuItem";
            this.advancedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.advancedFunctionsToolStripMenuItem.Text = "Advanced Functions";
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.instrumentToolStripMenuItem.Text = "Instrument";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            this.saveReportToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.saveReportToolStripMenuItem.Text = "Save Report";
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            this.browseReportsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.browseReportsToolStripMenuItem.Text = "Browse Reports";
            // 
            // setupEquipmentSiteToolStripMenuItem
            // 
            this.setupEquipmentSiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.equipmentSiteToolStripMenuItem,
            this.toolStripSeparator4,
            this.themeToolStripMenuItem});
            this.setupEquipmentSiteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            this.customerToolStripMenuItem.Text = "Customer Data";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // equipmentSiteToolStripMenuItem
            // 
            this.equipmentSiteToolStripMenuItem.Name = "equipmentSiteToolStripMenuItem";
            this.equipmentSiteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.equipmentSiteToolStripMenuItem.Text = "Equipment/Site";
            this.equipmentSiteToolStripMenuItem.Click += new System.EventHandler(this.equipmentSiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueWhiteColorToolStripMenuItem,
            this.blueBlackToolStripMenuItem,
            this.blackBlueColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // blueWhiteColorToolStripMenuItem
            // 
            this.blueWhiteColorToolStripMenuItem.Name = "blueWhiteColorToolStripMenuItem";
            this.blueWhiteColorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.blueWhiteColorToolStripMenuItem.Text = "Blue-White";
            this.blueWhiteColorToolStripMenuItem.Click += new System.EventHandler(this.blueWhiteColorToolStripMenuItem_Click);
            // 
            // blueBlackToolStripMenuItem
            // 
            this.blueBlackToolStripMenuItem.Name = "blueBlackToolStripMenuItem";
            this.blueBlackToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.blueBlackToolStripMenuItem.Text = "Blue-Black";
            this.blueBlackToolStripMenuItem.Click += new System.EventHandler(this.blueBlackToolStripMenuItem_Click);
            // 
            // blackBlueColorToolStripMenuItem
            // 
            this.blackBlueColorToolStripMenuItem.Name = "blackBlueColorToolStripMenuItem";
            this.blackBlueColorToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.blackBlueColorToolStripMenuItem.Text = "Black-Blue";
            this.blackBlueColorToolStripMenuItem.Click += new System.EventHandler(this.blackBlueColorToolStripMenuItem_Click);
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTestRecordsToolStripMenuItem,
            this.applyO2CorrectionToolStripMenuItem});
            this.dataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // viewTestRecordsToolStripMenuItem
            // 
            this.viewTestRecordsToolStripMenuItem.Name = "viewTestRecordsToolStripMenuItem";
            this.viewTestRecordsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewTestRecordsToolStripMenuItem.Text = "View Test Records";
            // 
            // applyO2CorrectionToolStripMenuItem
            // 
            this.applyO2CorrectionToolStripMenuItem.Name = "applyO2CorrectionToolStripMenuItem";
            this.applyO2CorrectionToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.applyO2CorrectionToolStripMenuItem.Text = "Apply O2 Correction";
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureRecordingToolStripMenuItem,
            this.configureReportToolStripMenuItem,
            this.performPreAndPostCalibrationToolStripMenuItem,
            this.setupCommunictaionPortsToolStripMenuItem});
            this.configureToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            // setupCommunictaionPortsToolStripMenuItem
            // 
            this.setupCommunictaionPortsToolStripMenuItem.Name = "setupCommunictaionPortsToolStripMenuItem";
            this.setupCommunictaionPortsToolStripMenuItem.Size = new System.Drawing.Size(309, 22);
            this.setupCommunictaionPortsToolStripMenuItem.Text = "Setup Communication";
            this.setupCommunictaionPortsToolStripMenuItem.Click += new System.EventHandler(this.setupCommunictaionPortsToolStripMenuItem_Click);
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
            this.menuCalibrationItem.ForeColor = System.Drawing.SystemColors.Control;
            this.menuCalibrationItem.Name = "menuCalibrationItem";
            this.menuCalibrationItem.Size = new System.Drawing.Size(77, 20);
            this.menuCalibrationItem.Text = "Calibration";
            // 
            // viewCalibrationInfoToolStripMenuItem
            // 
            this.viewCalibrationInfoToolStripMenuItem.Name = "viewCalibrationInfoToolStripMenuItem";
            this.viewCalibrationInfoToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.viewCalibrationInfoToolStripMenuItem.Text = "Calibration Gas Info";
            this.viewCalibrationInfoToolStripMenuItem.Click += new System.EventHandler(this.viewCalibrationInfoToolStripMenuItem_Click);
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
            this.preTestCalibrationToolStripMenuItem.Text = "Calibration";
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
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpgradeToolStripMenuItem,
            this.aboutAdvDASToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
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
            this.aboutAdvDASToolStripMenuItem.Text = "About CRS";
            this.aboutAdvDASToolStripMenuItem.Click += new System.EventHandler(this.aboutAdvDASToolStripMenuItem_Click);
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
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 4000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox19.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox19.Location = new System.Drawing.Point(120, 0);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(15, 31);
            this.checkBox19.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox19, "Click to disable in report");
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox16.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox16.Location = new System.Drawing.Point(120, 0);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 31);
            this.checkBox16.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox16, "Click to disable in report");
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox15.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox15.Location = new System.Drawing.Point(120, 0);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 31);
            this.checkBox15.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkBox15, "Click to disable in report");
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox14.Location = new System.Drawing.Point(120, 0);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 33);
            this.checkBox14.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox14, "Click to disable in report");
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox13.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox13.Location = new System.Drawing.Point(120, 0);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 33);
            this.checkBox13.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkBox13, "Click to disable in report");
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox10.Location = new System.Drawing.Point(120, 0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 31);
            this.checkBox10.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBox10, "Click to disable in report");
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox1.Location = new System.Drawing.Point(120, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 31);
            this.checkBox1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox1, "Click to disable in report");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox2.Location = new System.Drawing.Point(120, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 31);
            this.checkBox2.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox2, "Click to disable in report");
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBox3.Location = new System.Drawing.Point(120, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 31);
            this.checkBox3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox3, "Click to disable in report");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // snapShotButton
            // 
            this.snapShotButton.BackColor = System.Drawing.Color.Black;
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
            this.snapShotButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.snapShotButton_MouseDown);
            this.snapShotButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.snapShotButton_MouseUp);
            // 
            // stopRecordingButton
            // 
            this.stopRecordingButton.BackColor = System.Drawing.Color.Black;
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
            this.stopRecordingButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.stopRecordingButton_MouseDown);
            this.stopRecordingButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stopRecordingButton_MouseUp);
            // 
            // startRecordingButton
            // 
            this.startRecordingButton.BackColor = System.Drawing.Color.Black;
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
            this.startRecordingButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.startRecordingButton_MouseDown);
            this.startRecordingButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.startRecordingButton_MouseUp);
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
            this.tileButton3.Location = new System.Drawing.Point(3, 134);
            this.tileButton3.Name = "tileButton3";
            this.tileButton3.Size = new System.Drawing.Size(174, 46);
            this.tileButton3.TabIndex = 2;
            this.tileButton3.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton3, "Click here to reset average");
            this.tileButton3.UseVisualStyleBackColor = false;
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
            this.tileButton10.Location = new System.Drawing.Point(3, 135);
            this.tileButton10.Name = "tileButton10";
            this.tileButton10.Size = new System.Drawing.Size(178, 47);
            this.tileButton10.TabIndex = 21;
            this.tileButton10.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton10, "Click here to reset average");
            this.tileButton10.UseVisualStyleBackColor = false;
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
            this.tileButton9.Location = new System.Drawing.Point(3, 135);
            this.tileButton9.Name = "tileButton9";
            this.tileButton9.Size = new System.Drawing.Size(174, 47);
            this.tileButton9.TabIndex = 20;
            this.tileButton9.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton9, "Click here to reset average");
            this.tileButton9.UseVisualStyleBackColor = false;
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
            this.tileButton8.Location = new System.Drawing.Point(3, 135);
            this.tileButton8.Name = "tileButton8";
            this.tileButton8.Size = new System.Drawing.Size(174, 47);
            this.tileButton8.TabIndex = 19;
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
            this.tileButton7.Location = new System.Drawing.Point(3, 135);
            this.tileButton7.Name = "tileButton7";
            this.tileButton7.Size = new System.Drawing.Size(174, 47);
            this.tileButton7.TabIndex = 18;
            this.tileButton7.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton7, "Click here to reset average");
            this.tileButton7.UseVisualStyleBackColor = false;
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
            this.tileButton2.Location = new System.Drawing.Point(3, 175);
            this.tileButton2.Name = "tileButton2";
            this.tileButton2.Size = new System.Drawing.Size(174, 5);
            this.tileButton2.TabIndex = 13;
            this.tileButton2.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton2, "Click here to reset average");
            this.tileButton2.UseVisualStyleBackColor = false;
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
            this.tileButton5.Location = new System.Drawing.Point(3, 134);
            this.tileButton5.Name = "tileButton5";
            this.tileButton5.Size = new System.Drawing.Size(178, 46);
            this.tileButton5.TabIndex = 16;
            this.tileButton5.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton5, "Click here to reset average");
            this.tileButton5.UseVisualStyleBackColor = false;
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
            this.tileButton4.Location = new System.Drawing.Point(3, 134);
            this.tileButton4.Name = "tileButton4";
            this.tileButton4.Size = new System.Drawing.Size(174, 46);
            this.tileButton4.TabIndex = 15;
            this.tileButton4.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton4, "Click here to reset average");
            this.tileButton4.UseVisualStyleBackColor = false;
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
            this.tileButton6.Location = new System.Drawing.Point(3, 135);
            this.tileButton6.Name = "tileButton6";
            this.tileButton6.Size = new System.Drawing.Size(174, 47);
            this.tileButton6.TabIndex = 17;
            this.tileButton6.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton6, "Click here to reset average");
            this.tileButton6.UseVisualStyleBackColor = false;
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
            this.tileButton1.Location = new System.Drawing.Point(5, 136);
            this.tileButton1.Margin = new System.Windows.Forms.Padding(5);
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.Size = new System.Drawing.Size(170, 42);
            this.tileButton1.TabIndex = 12;
            this.tileButton1.Text = "0.0 AVG";
            this.toolTip1.SetToolTip(this.tileButton1, "Click here to reset average");
            this.tileButton1.UseVisualStyleBackColor = false;
            this.tileButton1.Click += new System.EventHandler(this.tileButton_Click);
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.Interval = 1000;
            this.dataGridTimer.Tick += new System.EventHandler(this.dataGridTimer_Tick);
            // 
            // recordSign
            // 
            this.recordSign.Interval = 1000;
            this.recordSign.Tick += new System.EventHandler(this.recordSign_Tick);
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
            this.tabControl1.Location = new System.Drawing.Point(3, 74);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 594);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 564);
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
            this.tableLayoutPanel1.Controls.Add(this.hTile0, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.hTile1, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel11, 2, 2);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.74101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.17073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1004, 554);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // hTile0
            // 
            this.hTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hTile0.BackgroundImage = global::CRS.Properties.Resources.dashboard_mass_blue_white;
            this.hTile0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hTile0.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.hTile0.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.hTile0, 2);
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.28198F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.22715F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.05483F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.44909F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.96606F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.4987F));
            this.hTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile0.Controls.Add(this.label11, 0, 1);
            this.hTile0.Controls.Add(this.tileButton11, 1, 2);
            this.hTile0.Controls.Add(this.label11_, 4, 1);
            this.hTile0.Controls.Add(this.tileLabel11, 2, 1);
            this.hTile0.Controls.Add(this.rLabela2, 4, 0);
            this.hTile0.Controls.Add(this.rLabela1, 0, 0);
            this.hTile0.Controls.Add(this.label14, 0, 2);
            this.hTile0.Controls.Add(this.label21, 5, 2);
            this.hTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hTile0.Location = new System.Drawing.Point(3, 411);
            this.hTile0.Name = "hTile0";
            this.hTile0.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hTile0.RowCount = 3;
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.59259F));
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.40741F));
            this.hTile0.Size = new System.Drawing.Size(394, 140);
            this.hTile0.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.label11, 2);
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(7, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 78);
            this.label11.TabIndex = 7;
            this.label11.Text = "0.0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileButton11
            // 
            this.tileButton11.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.tileButton11, 4);
            this.tileButton11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton11.FlatAppearance.BorderSize = 0;
            this.tileButton11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton11.Location = new System.Drawing.Point(102, 109);
            this.tileButton11.Name = "tileButton11";
            this.tileButton11.Size = new System.Drawing.Size(191, 27);
            this.tileButton11.TabIndex = 8;
            this.tileButton11.Text = "RESET AVERAGE";
            this.tileButton11.UseVisualStyleBackColor = false;
            // 
            // label11_
            // 
            this.label11_.AutoSize = true;
            this.label11_.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.label11_, 2);
            this.label11_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11_.Font = new System.Drawing.Font("Myriad Pro SemiExt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11_.Location = new System.Drawing.Point(256, 26);
            this.label11_.Margin = new System.Windows.Forms.Padding(1);
            this.label11_.Name = "label11_";
            this.label11_.Size = new System.Drawing.Size(131, 78);
            this.label11_.TabIndex = 6;
            this.label11_.Text = "0.0";
            this.label11_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel11
            // 
            this.tileLabel11.AutoSize = true;
            this.tileLabel11.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.tileLabel11, 2);
            this.tileLabel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel11.Font = new System.Drawing.Font("Myriad Pro SemiExt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel11.Location = new System.Drawing.Point(145, 25);
            this.tileLabel11.Name = "tileLabel11";
            this.tileLabel11.Size = new System.Drawing.Size(106, 80);
            this.tileLabel11.TabIndex = 0;
            this.tileLabel11.Text = "CO(mass)";
            this.tileLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rLabela2
            // 
            this.rLabela2.AutoSize = true;
            this.rLabela2.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.rLabela2, 2);
            this.rLabela2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabela2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabela2.Location = new System.Drawing.Point(258, 1);
            this.rLabela2.Name = "rLabela2";
            this.rLabela2.Size = new System.Drawing.Size(127, 23);
            this.rLabela2.TabIndex = 10;
            this.rLabela2.Text = "g/bhp-hr";
            this.rLabela2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rLabela1
            // 
            this.rLabela1.AutoSize = true;
            this.rLabela1.BackColor = System.Drawing.Color.Transparent;
            this.hTile0.SetColumnSpan(this.rLabela1, 2);
            this.rLabela1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabela1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabela1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rLabela1.Location = new System.Drawing.Point(9, 1);
            this.rLabela1.Name = "rLabela1";
            this.rLabela1.Size = new System.Drawing.Size(129, 23);
            this.rLabela1.TabIndex = 9;
            this.rLabela1.Text = "g/bhp-hr";
            this.rLabela1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 33);
            this.label14.TabIndex = 11;
            this.label14.Text = "label14";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(300, 106);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 33);
            this.label21.TabIndex = 12;
            this.label21.Text = "label21";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile2.Size = new System.Drawing.Size(180, 183);
            this.sTile2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 81);
            this.label3.TabIndex = 0;
            this.label3.Text = "0.0";
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
            this.tileLabel3.Size = new System.Drawing.Size(174, 50);
            this.tileLabel3.TabIndex = 1;
            this.tileLabel3.Text = "NO ppm";
            this.tileLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.sTile9.Location = new System.Drawing.Point(810, 213);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 3;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile9.Size = new System.Drawing.Size(184, 185);
            this.sTile9.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(3, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(178, 81);
            this.label10.TabIndex = 18;
            this.label10.Text = "0.0";
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
            this.tileLabel10.Size = new System.Drawing.Size(178, 51);
            this.tileLabel10.TabIndex = 20;
            this.tileLabel10.Text = "T(amb)°F";
            this.tileLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.sTile8.Location = new System.Drawing.Point(610, 213);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 3;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile8.Size = new System.Drawing.Size(180, 185);
            this.sTile8.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(3, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 81);
            this.label9.TabIndex = 17;
            this.label9.Text = "0.0";
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
            this.tileLabel9.Size = new System.Drawing.Size(174, 51);
            this.tileLabel9.TabIndex = 19;
            this.tileLabel9.Text = "T(gas)°F";
            this.tileLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile7.Location = new System.Drawing.Point(410, 213);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 3;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile7.Size = new System.Drawing.Size(180, 185);
            this.sTile7.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(3, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 81);
            this.label8.TabIndex = 16;
            this.label8.Text = "0.0";
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
            this.tileLabel8.Size = new System.Drawing.Size(174, 51);
            this.tileLabel8.TabIndex = 18;
            this.tileLabel8.Text = "CxHy ppm";
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
            this.sTile6.Location = new System.Drawing.Point(210, 213);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 3;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile6.Size = new System.Drawing.Size(180, 185);
            this.sTile6.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(3, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 81);
            this.label7.TabIndex = 15;
            this.label7.Text = "0.0";
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
            this.tileLabel7.Size = new System.Drawing.Size(174, 51);
            this.tileLabel7.TabIndex = 17;
            this.tileLabel7.Text = "SO2 ppm";
            this.tileLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile1.Size = new System.Drawing.Size(180, 183);
            this.sTile1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 162);
            this.label2.TabIndex = 10;
            this.label2.Text = "0000";
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
            this.tileLabel2.Size = new System.Drawing.Size(174, 10);
            this.tileLabel2.TabIndex = 12;
            this.tileLabel2.Text = "CO ppm";
            this.tileLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.Color.Black;
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
            this.sTile4.Location = new System.Drawing.Point(810, 10);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 3;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.50495F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.49505F));
            this.sTile4.Size = new System.Drawing.Size(184, 183);
            this.sTile4.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(3, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 81);
            this.label5.TabIndex = 13;
            this.label5.Text = "0.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel5
            // 
            this.tileLabel5.AutoSize = true;
            this.tileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel5.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel5.Location = new System.Drawing.Point(3, 0);
            this.tileLabel5.Name = "tileLabel5";
            this.tileLabel5.Size = new System.Drawing.Size(178, 50);
            this.tileLabel5.TabIndex = 15;
            this.tileLabel5.Text = "NOx ppm";
            this.tileLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile3.Size = new System.Drawing.Size(180, 183);
            this.sTile3.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 81);
            this.label4.TabIndex = 12;
            this.label4.Text = "0.0";
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
            this.tileLabel4.Size = new System.Drawing.Size(174, 50);
            this.tileLabel4.TabIndex = 14;
            this.tileLabel4.Text = "NO2 ppm";
            this.tileLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile5.Location = new System.Drawing.Point(10, 213);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 3;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.sTile5.Size = new System.Drawing.Size(180, 185);
            this.sTile5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Myriad Pro SemiExt", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(3, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 81);
            this.label6.TabIndex = 14;
            this.label6.Text = "0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel6
            // 
            this.tileLabel6.AutoSize = true;
            this.tileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel6.Font = new System.Drawing.Font("Myriad Pro SemiExt", 24F);
            this.tileLabel6.ForeColor = System.Drawing.Color.Black;
            this.tileLabel6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel6.Location = new System.Drawing.Point(3, 0);
            this.tileLabel6.Name = "tileLabel6";
            this.tileLabel6.Size = new System.Drawing.Size(174, 51);
            this.tileLabel6.TabIndex = 16;
            this.tileLabel6.Text = "CO2%";
            this.tileLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // hTile1
            // 
            this.hTile1.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.BackgroundImage = global::CRS.Properties.Resources.dashboard_mass_blue_white;
            this.hTile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.hTile1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.hTile1.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.hTile1, 2);
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.53471F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.940875F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5964F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.48072F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.940875F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.50643F));
            this.hTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile1.Controls.Add(this.label22, 0, 2);
            this.hTile1.Controls.Add(this.label12, 0, 1);
            this.hTile1.Controls.Add(this.label12_, 4, 1);
            this.hTile1.Controls.Add(this.tileButton12, 1, 2);
            this.hTile1.Controls.Add(this.tileLabel12, 1, 1);
            this.hTile1.Controls.Add(this.rLabelb2, 5, 0);
            this.hTile1.Controls.Add(this.rLabelb1, 0, 0);
            this.hTile1.Controls.Add(this.label23, 5, 2);
            this.hTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hTile1.Location = new System.Drawing.Point(603, 411);
            this.hTile1.Name = "hTile1";
            this.hTile1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.hTile1.RowCount = 3;
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.63636F));
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.36364F));
            this.hTile1.Size = new System.Drawing.Size(398, 140);
            this.hTile1.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(10, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(100, 30);
            this.label22.TabIndex = 13;
            this.label22.Text = "label22";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.SetColumnSpan(this.label12, 2);
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(8, 27);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 78);
            this.label12.TabIndex = 7;
            this.label12.Text = "0.0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12_
            // 
            this.label12_.AutoSize = true;
            this.label12_.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.SetColumnSpan(this.label12_, 2);
            this.label12_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12_.Font = new System.Drawing.Font("Myriad Pro SemiExt", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12_.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12_.Location = new System.Drawing.Point(259, 27);
            this.label12_.Margin = new System.Windows.Forms.Padding(1);
            this.label12_.Name = "label12_";
            this.label12_.Size = new System.Drawing.Size(131, 78);
            this.label12_.TabIndex = 6;
            this.label12_.Text = "0.0";
            this.label12_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileButton12
            // 
            this.tileButton12.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.SetColumnSpan(this.tileButton12, 4);
            this.tileButton12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileButton12.FlatAppearance.BorderSize = 0;
            this.tileButton12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tileButton12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileButton12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileButton12.Location = new System.Drawing.Point(118, 111);
            this.tileButton12.Name = "tileButton12";
            this.tileButton12.Size = new System.Drawing.Size(162, 24);
            this.tileButton12.TabIndex = 8;
            this.tileButton12.Text = "RESET AVERAGE";
            this.tileButton12.UseVisualStyleBackColor = false;
            // 
            // tileLabel12
            // 
            this.tileLabel12.AutoSize = true;
            this.hTile1.SetColumnSpan(this.tileLabel12, 2);
            this.tileLabel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel12.Font = new System.Drawing.Font("Myriad Pro SemiExt", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tileLabel12.Location = new System.Drawing.Point(145, 26);
            this.tileLabel12.Name = "tileLabel12";
            this.tileLabel12.Size = new System.Drawing.Size(108, 80);
            this.tileLabel12.TabIndex = 0;
            this.tileLabel12.Text = "NOx(mass)";
            this.tileLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rLabelb2
            // 
            this.rLabelb2.AutoSize = true;
            this.rLabelb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabelb2.Font = new System.Drawing.Font("Myriad Pro SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabelb2.Location = new System.Drawing.Point(288, 2);
            this.rLabelb2.Name = "rLabelb2";
            this.rLabelb2.Size = new System.Drawing.Size(100, 22);
            this.rLabelb2.TabIndex = 10;
            this.rLabelb2.Text = "g/bhp-hr";
            this.rLabelb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rLabelb1
            // 
            this.rLabelb1.AutoSize = true;
            this.rLabelb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabelb1.Font = new System.Drawing.Font("Myriad Pro SemiExt", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabelb1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rLabelb1.Location = new System.Drawing.Point(10, 2);
            this.rLabelb1.Name = "rLabelb1";
            this.rLabelb1.Size = new System.Drawing.Size(100, 22);
            this.rLabelb1.TabIndex = 9;
            this.rLabelb1.Text = "g/bhp-hr";
            this.rLabelb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Myriad Pro SemiExt", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(288, 108);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(100, 30);
            this.label23.TabIndex = 14;
            this.label23.Text = "label23";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile0.Size = new System.Drawing.Size(180, 183);
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
            this.label1.Location = new System.Drawing.Point(3, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 81);
            this.label1.TabIndex = 9;
            this.label1.Text = "0.0";
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
            this.tileLabel1.Size = new System.Drawing.Size(174, 50);
            this.tileLabel1.TabIndex = 11;
            this.tileLabel1.Text = "O2%";
            this.tileLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackgroundImage = global::CRS.Properties.Resources.status_box;
            this.tableLayoutPanel11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.57732F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.42268F));
            this.tableLayoutPanel11.Controls.Add(this.cycleLabel, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.rTimelbl, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.tTimelbl, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.pTimelbl, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.plbl, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.tlbl, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.rlbl, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(403, 411);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 7;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.Size = new System.Drawing.Size(194, 140);
            this.tableLayoutPanel11.TabIndex = 25;
            // 
            // cycleLabel
            // 
            this.cycleLabel.AutoSize = true;
            this.cycleLabel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel11.SetColumnSpan(this.cycleLabel, 2);
            this.cycleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleLabel.Font = new System.Drawing.Font("Myriad Pro SemiExt", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cycleLabel.Location = new System.Drawing.Point(3, 0);
            this.cycleLabel.Name = "cycleLabel";
            this.cycleLabel.Size = new System.Drawing.Size(188, 19);
            this.cycleLabel.TabIndex = 1;
            this.cycleLabel.Text = "Cycle: 1";
            this.cycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTimelbl
            // 
            this.rTimelbl.AutoSize = true;
            this.rTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.rTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rTimelbl.Location = new System.Drawing.Point(105, 19);
            this.rTimelbl.Name = "rTimelbl";
            this.rTimelbl.Size = new System.Drawing.Size(86, 23);
            this.rTimelbl.TabIndex = 26;
            this.rTimelbl.Text = "00:00:00";
            this.rTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tTimelbl
            // 
            this.tTimelbl.AutoSize = true;
            this.tTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.tTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tTimelbl.Location = new System.Drawing.Point(105, 42);
            this.tTimelbl.Name = "tTimelbl";
            this.tTimelbl.Size = new System.Drawing.Size(86, 23);
            this.tTimelbl.TabIndex = 27;
            this.tTimelbl.Text = "00:00:00";
            this.tTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pTimelbl
            // 
            this.pTimelbl.AutoSize = true;
            this.pTimelbl.BackColor = System.Drawing.Color.Transparent;
            this.pTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTimelbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimelbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pTimelbl.Location = new System.Drawing.Point(105, 65);
            this.pTimelbl.Name = "pTimelbl";
            this.pTimelbl.Size = new System.Drawing.Size(86, 23);
            this.pTimelbl.TabIndex = 28;
            this.pTimelbl.Text = "00:00:00";
            this.pTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plbl
            // 
            this.plbl.AutoSize = true;
            this.plbl.BackColor = System.Drawing.Color.Transparent;
            this.plbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.plbl.Location = new System.Drawing.Point(3, 65);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(96, 23);
            this.plbl.TabIndex = 23;
            this.plbl.Text = "Purge:";
            this.plbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlbl
            // 
            this.tlbl.AutoSize = true;
            this.tlbl.BackColor = System.Drawing.Color.Transparent;
            this.tlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tlbl.Location = new System.Drawing.Point(3, 42);
            this.tlbl.Name = "tlbl";
            this.tlbl.Size = new System.Drawing.Size(96, 23);
            this.tlbl.TabIndex = 4;
            this.tlbl.Text = "Test:";
            this.tlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rlbl
            // 
            this.rlbl.AutoSize = true;
            this.rlbl.BackColor = System.Drawing.Color.Transparent;
            this.rlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rlbl.Location = new System.Drawing.Point(3, 19);
            this.rlbl.Name = "rlbl";
            this.rlbl.Size = new System.Drawing.Size(96, 23);
            this.rlbl.TabIndex = 2;
            this.rlbl.Text = "Ramp Up:";
            this.rlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1004, 554);
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
            this.tabPage2.Size = new System.Drawing.Size(1014, 564);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            // 
            // tableLayoutPanel14
            // 
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
            this.tableLayoutPanel14.Size = new System.Drawing.Size(1008, 558);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.elementTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 544);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(273, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "PRINT GRAPH";
            this.button2.UseVisualStyleBackColor = true;
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
            this.elementTable.Size = new System.Drawing.Size(273, 544);
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
            series35.ChartArea = "ChartArea1";
            series35.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series35.Legend = "Legend1";
            series35.Name = "O2";
            series35.Points.Add(dataPoint38);
            series35.Points.Add(dataPoint39);
            series35.Points.Add(dataPoint40);
            series35.Points.Add(dataPoint41);
            series35.Points.Add(dataPoint42);
            series36.ChartArea = "ChartArea1";
            series36.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series36.Legend = "Legend1";
            series36.Name = "CO";
            series36.Points.Add(dataPoint43);
            series36.Points.Add(dataPoint44);
            series36.Points.Add(dataPoint45);
            series36.Points.Add(dataPoint46);
            series36.Points.Add(dataPoint47);
            series37.ChartArea = "ChartArea1";
            series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series37.Legend = "Legend1";
            series37.Name = "CO2";
            series38.ChartArea = "ChartArea1";
            series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series38.Legend = "Legend1";
            series38.Name = "NO";
            series39.ChartArea = "ChartArea1";
            series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series39.Legend = "Legend1";
            series39.Name = "NO2";
            series40.ChartArea = "ChartArea1";
            series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series40.Legend = "Legend1";
            series40.Name = "NOx";
            series40.Points.Add(dataPoint48);
            series40.Points.Add(dataPoint49);
            series40.Points.Add(dataPoint50);
            series40.Points.Add(dataPoint51);
            series40.Points.Add(dataPoint52);
            series40.YValueMembers = "Tag";
            series41.ChartArea = "ChartArea1";
            series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series41.Legend = "Legend1";
            series41.Name = "SO2";
            series42.ChartArea = "ChartArea1";
            series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series42.Legend = "Legend1";
            series42.Name = "CxHy";
            series43.ChartArea = "ChartArea1";
            series43.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series43.Legend = "Legend1";
            series43.Name = "T(gas)";
            series43.Points.Add(dataPoint53);
            series43.Points.Add(dataPoint54);
            series43.Points.Add(dataPoint55);
            series43.Points.Add(dataPoint56);
            series43.Points.Add(dataPoint57);
            series44.ChartArea = "ChartArea1";
            series44.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series44.Legend = "Legend1";
            series44.Name = "T(amb)";
            series44.Points.Add(dataPoint58);
            series44.Points.Add(dataPoint59);
            series44.Points.Add(dataPoint60);
            series44.Points.Add(dataPoint61);
            series44.Points.Add(dataPoint62);
            series45.ChartArea = "ChartArea1";
            series45.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series45.Legend = "Legend1";
            series45.Name = "T(cell)";
            series46.ChartArea = "ChartArea1";
            series46.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series46.Legend = "Legend1";
            series46.Name = "Efficiency";
            series47.ChartArea = "ChartArea1";
            series47.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series47.Legend = "Legend1";
            series47.Name = "I.Flow";
            series48.ChartArea = "ChartArea1";
            series48.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series48.Legend = "Legend1";
            series48.Name = "Draft";
            series49.ChartArea = "ChartArea1";
            series49.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series49.Legend = "Legend1";
            series49.Name = "Losses";
            series50.ChartArea = "ChartArea1";
            series50.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series50.Legend = "Legend1";
            series50.Name = "Excess Air";
            series51.ChartArea = "ChartArea1";
            series51.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series51.Legend = "Legend1";
            series51.Name = "CO(mass)";
            series52.ChartArea = "ChartArea1";
            series52.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series52.Legend = "Legend1";
            series52.Name = "NOx(mass)";
            this.trendGraph.Series.Add(series35);
            this.trendGraph.Series.Add(series36);
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
            this.trendGraph.Size = new System.Drawing.Size(720, 550);
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
            this.tabPage3.Size = new System.Drawing.Size(1014, 564);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hybrid";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel15, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel13, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chart1, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel13, 0, 2);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.82443F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.701F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.1492F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.32538F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1008, 558);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel15.BackgroundImage")));
            this.tableLayoutPanel15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel15.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label54, 0, 1);
            this.tableLayoutPanel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(320, 274);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(135, 114);
            this.tableLayoutPanel15.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(3, 86);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 28);
            this.label19.TabIndex = 13;
            this.label19.Text = "CURRENT";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(135, 31);
            this.panel5.TabIndex = 7;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Dock = System.Windows.Forms.DockStyle.Left;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 31);
            this.label20.TabIndex = 0;
            this.label20.Text = "NOx";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label54.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label54.Location = new System.Drawing.Point(3, 31);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(129, 55);
            this.label54.TabIndex = 14;
            this.label54.Text = "0.0";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel6.BackgroundImage")));
            this.tableLayoutPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(165, 274);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(135, 114);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label17.Location = new System.Drawing.Point(3, 86);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 28);
            this.label17.TabIndex = 13;
            this.label17.Text = "CURRENT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(135, 31);
            this.panel3.TabIndex = 7;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Left;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(0, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(67, 31);
            this.label18.TabIndex = 0;
            this.label18.Text = "NOx";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label53.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label53.Location = new System.Drawing.Point(3, 31);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(129, 55);
            this.label53.TabIndex = 14;
            this.label53.Text = "0.0";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel5.BackgroundImage")));
            this.tableLayoutPanel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 1);
            this.tableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 142);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(3, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 27);
            this.label15.TabIndex = 13;
            this.label15.Text = "CURRENT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(135, 31);
            this.panel2.TabIndex = 7;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 31);
            this.label16.TabIndex = 0;
            this.label16.Text = "NOx";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label44.Location = new System.Drawing.Point(3, 31);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(129, 54);
            this.label44.TabIndex = 14;
            this.label44.Text = "0.0";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.SetColumnSpan(this.panel13, 3);
            this.panel13.ContextMenuStrip = this.tilePopUpMenu;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(10, 408);
            this.panel13.Margin = new System.Windows.Forms.Padding(10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(445, 140);
            this.panel13.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel4.BackgroundImage")));
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(320, 10);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label31.Location = new System.Drawing.Point(3, 85);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(129, 27);
            this.label31.TabIndex = 10;
            this.label31.Text = "CURRENT";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.Transparent;
            this.panel14.Controls.Add(this.checkBox10);
            this.panel14.Controls.Add(this.label33);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(135, 31);
            this.panel14.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Dock = System.Windows.Forms.DockStyle.Left;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 31);
            this.label33.TabIndex = 0;
            this.label33.Text = "CO2";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label40.Location = new System.Drawing.Point(3, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(129, 54);
            this.label40.TabIndex = 11;
            this.label40.Text = "0.0";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel7.BackgroundImage")));
            this.tableLayoutPanel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel7.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(320, 142);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Transparent;
            this.panel17.Controls.Add(this.checkBox13);
            this.panel17.Controls.Add(this.label41);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(135, 33);
            this.panel17.TabIndex = 7;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Dock = System.Windows.Forms.DockStyle.Left;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label41.Location = new System.Drawing.Point(0, 0);
            this.label41.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(80, 31);
            this.label41.TabIndex = 0;
            this.label41.Text = "CxHy";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label42.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label42.Location = new System.Drawing.Point(3, 85);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(129, 27);
            this.label42.TabIndex = 15;
            this.label42.Text = "CURRENT";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label49.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label49.Location = new System.Drawing.Point(3, 33);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(129, 52);
            this.label49.TabIndex = 16;
            this.label49.Text = "0.0";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel8.BackgroundImage")));
            this.tableLayoutPanel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel8.Controls.Add(this.label43, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label46, 0, 1);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(165, 142);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label43.Location = new System.Drawing.Point(3, 85);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(129, 27);
            this.label43.TabIndex = 14;
            this.label43.Text = "CURRENT";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.BackColor = System.Drawing.Color.Transparent;
            this.panel18.Controls.Add(this.checkBox14);
            this.panel18.Controls.Add(this.label45);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(135, 33);
            this.panel18.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Dock = System.Windows.Forms.DockStyle.Left;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label45.Location = new System.Drawing.Point(0, 0);
            this.label45.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(64, 31);
            this.label45.TabIndex = 0;
            this.label45.Text = "SO2";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label46.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label46.Location = new System.Drawing.Point(3, 33);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(129, 52);
            this.label46.TabIndex = 15;
            this.label46.Text = "0.0";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel9.BackgroundImage")));
            this.tableLayoutPanel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel9.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(165, 10);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.Color.Transparent;
            this.panel19.Controls.Add(this.checkBox15);
            this.panel19.Controls.Add(this.label47);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(135, 31);
            this.panel19.TabIndex = 7;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Dock = System.Windows.Forms.DockStyle.Left;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label47.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label47.Location = new System.Drawing.Point(0, 0);
            this.label47.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(54, 31);
            this.label47.TabIndex = 0;
            this.label47.Text = "CO";
            this.label47.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label48.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label48.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label48.Location = new System.Drawing.Point(3, 85);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(129, 27);
            this.label48.TabIndex = 9;
            this.label48.Text = "CURRENT";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label32.Location = new System.Drawing.Point(3, 31);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(129, 54);
            this.label32.TabIndex = 10;
            this.label32.Text = "0.0";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel10.BackgroundImage = global::CRS.Properties.Resources.dashboard_blue_white_box;
            this.tableLayoutPanel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel10.Controls.Add(this.panel20, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label51, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label61, 0, 1);
            this.tableLayoutPanel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.1358F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.8642F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(135, 112);
            this.tableLayoutPanel10.TabIndex = 14;
            // 
            // panel20
            // 
            this.panel20.BackColor = System.Drawing.Color.Transparent;
            this.panel20.Controls.Add(this.checkBox16);
            this.panel20.Controls.Add(this.label50);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(135, 31);
            this.panel20.TabIndex = 7;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Dock = System.Windows.Forms.DockStyle.Left;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label50.Location = new System.Drawing.Point(0, 0);
            this.label50.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(49, 31);
            this.label50.TabIndex = 0;
            this.label50.Text = "O2";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label51.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label51.Location = new System.Drawing.Point(35, 87);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(64, 25);
            this.label51.TabIndex = 8;
            this.label51.Text = "CURRENT";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label61.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label61.Location = new System.Drawing.Point(3, 31);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(129, 56);
            this.label61.TabIndex = 9;
            this.label61.Text = "0.0";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            series53.ChartArea = "ChartArea1";
            series53.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series53.Legend = "Legend1";
            series53.Name = "O2";
            series53.Points.Add(dataPoint63);
            series53.Points.Add(dataPoint64);
            series53.Points.Add(dataPoint65);
            series53.Points.Add(dataPoint66);
            series54.ChartArea = "ChartArea1";
            series54.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series54.Legend = "Legend1";
            series54.Name = "CO";
            series54.Points.Add(dataPoint67);
            series54.Points.Add(dataPoint68);
            series54.Points.Add(dataPoint69);
            series54.Points.Add(dataPoint70);
            series54.Points.Add(dataPoint71);
            series54.Points.Add(dataPoint72);
            series54.Points.Add(dataPoint73);
            series54.Points.Add(dataPoint74);
            series55.ChartArea = "ChartArea1";
            series55.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series55.Legend = "Legend1";
            series55.Name = "CO2";
            series56.ChartArea = "ChartArea1";
            series56.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series56.Legend = "Legend1";
            series56.Name = "NO";
            series57.ChartArea = "ChartArea1";
            series57.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series57.Legend = "Legend1";
            series57.Name = "NO2";
            series58.ChartArea = "ChartArea1";
            series58.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series58.Legend = "Legend1";
            series58.Name = "NOx";
            series58.YValueMembers = "Tag";
            series59.ChartArea = "ChartArea1";
            series59.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series59.Legend = "Legend1";
            series59.Name = "SO2";
            series60.ChartArea = "ChartArea1";
            series60.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series60.Legend = "Legend1";
            series60.Name = "CxHy";
            series61.ChartArea = "ChartArea1";
            series61.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series61.Legend = "Legend1";
            series61.Name = "T(gas)";
            series62.ChartArea = "ChartArea1";
            series62.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series62.Legend = "Legend1";
            series62.Name = "T(amb)";
            series63.ChartArea = "ChartArea1";
            series63.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series63.Legend = "Legend1";
            series63.Name = "Temp1";
            series64.ChartArea = "ChartArea1";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series64.Legend = "Legend1";
            series64.Name = "Temp2";
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
            series67.Name = "Flow";
            series68.ChartArea = "ChartArea1";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series68.Legend = "Legend1";
            series68.Name = "NH3";
            this.chart1.Series.Add(series53);
            this.chart1.Series.Add(series54);
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
            this.chart1.Size = new System.Drawing.Size(537, 552);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel13.BackgroundImage")));
            this.tableLayoutPanel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel13.Controls.Add(this.label59, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label52, 0, 1);
            this.tableLayoutPanel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(10, 274);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(135, 114);
            this.tableLayoutPanel13.TabIndex = 11;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.label59.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label59.Location = new System.Drawing.Point(3, 86);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(129, 28);
            this.label59.TabIndex = 13;
            this.label59.Text = "CURRENT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.Transparent;
            this.panel23.Controls.Add(this.checkBox19);
            this.panel23.Controls.Add(this.label60);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(135, 31);
            this.panel23.TabIndex = 7;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Dock = System.Windows.Forms.DockStyle.Left;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label60.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label60.Location = new System.Drawing.Point(0, 0);
            this.label60.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(67, 31);
            this.label60.TabIndex = 0;
            this.label60.Text = "NOx";
            this.label60.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.label52.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label52.Location = new System.Drawing.Point(3, 31);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(129, 55);
            this.label52.TabIndex = 14;
            this.label52.Text = "0.0";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.tableLayoutPanel12);
            this.tabPage4.Location = new System.Drawing.Point(4, 26);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1014, 564);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analyzer Control";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel12
            // 
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
            this.tableLayoutPanel12.Size = new System.Drawing.Size(1008, 558);
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
            this.panel4.Size = new System.Drawing.Size(677, 552);
            this.panel4.TabIndex = 5;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button16.Location = new System.Drawing.Point(162, 156);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(188, 28);
            this.button16.TabIndex = 1;
            this.button16.Text = "Start Peristaltik Pump";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button15.Location = new System.Drawing.Point(188, 57);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(188, 26);
            this.button15.TabIndex = 0;
            this.button15.Text = "Beep";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 5;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel18.Controls.Add(this.label27, 3, 0);
            this.tableLayoutPanel18.Controls.Add(this.O2_Vlbl, 1, 0);
            this.tableLayoutPanel18.Controls.Add(this.label24, 0, 0);
            this.tableLayoutPanel18.Controls.Add(this.serialNO_lbl, 4, 0);
            this.tableLayoutPanel18.Controls.Add(this.label28, 0, 1);
            this.tableLayoutPanel18.Controls.Add(this.CO_Vlbl, 1, 1);
            this.tableLayoutPanel18.Controls.Add(this.label34, 3, 1);
            this.tableLayoutPanel18.Controls.Add(this.operationHrs_lbl, 4, 1);
            this.tableLayoutPanel18.Controls.Add(this.label35, 0, 2);
            this.tableLayoutPanel18.Controls.Add(this.NO_Vlbl, 1, 2);
            this.tableLayoutPanel18.Controls.Add(this.label37, 3, 2);
            this.tableLayoutPanel18.Controls.Add(this.ProgramVrs_lbl, 4, 2);
            this.tableLayoutPanel18.Controls.Add(this.label39, 0, 3);
            this.tableLayoutPanel18.Controls.Add(this.NO2_Vlbl, 1, 3);
            this.tableLayoutPanel18.Controls.Add(this.label58, 0, 4);
            this.tableLayoutPanel18.Controls.Add(this.batt_Vlbl, 1, 4);
            this.tableLayoutPanel18.Controls.Add(this.label65, 0, 5);
            this.tableLayoutPanel18.Controls.Add(this.battB_Vlbl, 1, 5);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(686, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 6;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel18.Size = new System.Drawing.Size(319, 552);
            this.tableLayoutPanel18.TabIndex = 2;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(170, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(75, 17);
            this.label27.TabIndex = 3;
            this.label27.Text = "Serial NO.";
            // 
            // O2_Vlbl
            // 
            this.O2_Vlbl.AutoSize = true;
            this.O2_Vlbl.Location = new System.Drawing.Point(101, 0);
            this.O2_Vlbl.Name = "O2_Vlbl";
            this.O2_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.O2_Vlbl.TabIndex = 1;
            this.O2_Vlbl.Text = "label25";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(3, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(28, 17);
            this.label24.TabIndex = 0;
            this.label24.Text = "O2";
            // 
            // serialNO_lbl
            // 
            this.serialNO_lbl.AutoSize = true;
            this.serialNO_lbl.Location = new System.Drawing.Point(275, 0);
            this.serialNO_lbl.Name = "serialNO_lbl";
            this.serialNO_lbl.Size = new System.Drawing.Size(54, 17);
            this.serialNO_lbl.TabIndex = 2;
            this.serialNO_lbl.Text = "label26";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(3, 17);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(31, 17);
            this.label28.TabIndex = 4;
            this.label28.Text = "CO";
            // 
            // CO_Vlbl
            // 
            this.CO_Vlbl.AutoSize = true;
            this.CO_Vlbl.Location = new System.Drawing.Point(101, 17);
            this.CO_Vlbl.Name = "CO_Vlbl";
            this.CO_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.CO_Vlbl.TabIndex = 5;
            this.CO_Vlbl.Text = "label29";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(170, 17);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 17);
            this.label34.TabIndex = 6;
            this.label34.Text = "Operation Hrs";
            // 
            // operationHrs_lbl
            // 
            this.operationHrs_lbl.AutoSize = true;
            this.operationHrs_lbl.Location = new System.Drawing.Point(275, 17);
            this.operationHrs_lbl.Name = "operationHrs_lbl";
            this.operationHrs_lbl.Size = new System.Drawing.Size(54, 17);
            this.operationHrs_lbl.TabIndex = 7;
            this.operationHrs_lbl.Text = "label34";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 34);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(30, 17);
            this.label35.TabIndex = 8;
            this.label35.Text = "NO";
            // 
            // NO_Vlbl
            // 
            this.NO_Vlbl.AutoSize = true;
            this.NO_Vlbl.Location = new System.Drawing.Point(101, 34);
            this.NO_Vlbl.Name = "NO_Vlbl";
            this.NO_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.NO_Vlbl.TabIndex = 9;
            this.NO_Vlbl.Text = "label36";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(170, 34);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(90, 17);
            this.label37.TabIndex = 10;
            this.label37.Text = "Program Vrs";
            // 
            // ProgramVrs_lbl
            // 
            this.ProgramVrs_lbl.AutoSize = true;
            this.ProgramVrs_lbl.Location = new System.Drawing.Point(275, 34);
            this.ProgramVrs_lbl.Name = "ProgramVrs_lbl";
            this.ProgramVrs_lbl.Size = new System.Drawing.Size(54, 17);
            this.ProgramVrs_lbl.TabIndex = 11;
            this.ProgramVrs_lbl.Text = "label38";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 51);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(38, 17);
            this.label39.TabIndex = 12;
            this.label39.Text = "NO2";
            // 
            // NO2_Vlbl
            // 
            this.NO2_Vlbl.AutoSize = true;
            this.NO2_Vlbl.Location = new System.Drawing.Point(101, 51);
            this.NO2_Vlbl.Name = "NO2_Vlbl";
            this.NO2_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.NO2_Vlbl.TabIndex = 13;
            this.NO2_Vlbl.Text = "label55";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(3, 68);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(54, 17);
            this.label58.TabIndex = 16;
            this.label58.Text = "Battery";
            // 
            // batt_Vlbl
            // 
            this.batt_Vlbl.AutoSize = true;
            this.batt_Vlbl.Location = new System.Drawing.Point(101, 68);
            this.batt_Vlbl.Name = "batt_Vlbl";
            this.batt_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.batt_Vlbl.TabIndex = 17;
            this.batt_Vlbl.Text = "label62";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Location = new System.Drawing.Point(3, 85);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(92, 17);
            this.label65.TabIndex = 20;
            this.label65.Text = "Battery Base";
            // 
            // battB_Vlbl
            // 
            this.battB_Vlbl.AutoSize = true;
            this.battB_Vlbl.Location = new System.Drawing.Point(101, 85);
            this.battB_Vlbl.Name = "battB_Vlbl";
            this.battB_Vlbl.Size = new System.Drawing.Size(54, 17);
            this.battB_Vlbl.TabIndex = 21;
            this.battB_Vlbl.Text = "label66";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.snapShotButton);
            this.panel12.Controls.Add(this.stopRecordingButton);
            this.panel12.Controls.Add(this.startRecordingButton);
            this.panel12.Controls.Add(this.recordingSign);
            this.panel12.Location = new System.Drawing.Point(3, 27);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(565, 41);
            this.panel12.TabIndex = 23;
            // 
            // recordingSign
            // 
            this.recordingSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.recordingSign.Image = global::CRS.Properties.Resources.recording_A;
            this.recordingSign.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.recordingSign.Location = new System.Drawing.Point(390, 0);
            this.recordingSign.Margin = new System.Windows.Forms.Padding(0);
            this.recordingSign.Name = "recordingSign";
            this.recordingSign.Size = new System.Drawing.Size(192, 41);
            this.recordingSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordingSign.TabIndex = 8;
            this.recordingSign.TabStop = false;
            this.recordingSign.Visible = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 457F));
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel16, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 12F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1028, 683);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.18847F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.81153F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Controls.Add(this.tableLayoutPanel17, 1, 0);
            this.tableLayoutPanel16.Controls.Add(this.panel7, 0, 0);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(574, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel2.SetRowSpan(this.tableLayoutPanel16, 2);
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(451, 65);
            this.tableLayoutPanel16.TabIndex = 24;
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel17.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Controls.Add(this.iflowlbl, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label13, 0, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(296, 3);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel16.SetRowSpan(this.tableLayoutPanel17, 2);
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(152, 59);
            this.tableLayoutPanel17.TabIndex = 1;
            // 
            // iflowlbl
            // 
            this.iflowlbl.AutoSize = true;
            this.iflowlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iflowlbl.Font = new System.Drawing.Font("Myriad Pro SemiExt", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iflowlbl.ForeColor = System.Drawing.SystemColors.Control;
            this.iflowlbl.Location = new System.Drawing.Point(6, 3);
            this.iflowlbl.Name = "iflowlbl";
            this.iflowlbl.Size = new System.Drawing.Size(140, 25);
            this.iflowlbl.TabIndex = 0;
            this.iflowlbl.Text = "0.0";
            this.iflowlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Myriad Pro SemiExt", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(6, 31);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 25);
            this.label13.TabIndex = 1;
            this.label13.Text = "I.Flow (L/min)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.phaseTimeLabel);
            this.panel7.Controls.Add(this.recordingProgressBar);
            this.panel7.Controls.Add(this.connectionStatusLabel);
            this.panel7.Controls.Add(this.recordTimeLabel);
            this.panel7.Controls.Add(this.clock_lbl);
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.tableLayoutPanel16.SetRowSpan(this.panel7, 2);
            this.panel7.Size = new System.Drawing.Size(287, 59);
            this.panel7.TabIndex = 4;
            // 
            // phaseTimeLabel
            // 
            this.phaseTimeLabel.AutoSize = true;
            this.phaseTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.phaseTimeLabel.Location = new System.Drawing.Point(3, 44);
            this.phaseTimeLabel.Name = "phaseTimeLabel";
            this.phaseTimeLabel.Size = new System.Drawing.Size(41, 13);
            this.phaseTimeLabel.TabIndex = 7;
            this.phaseTimeLabel.Text = "label24";
            // 
            // recordingProgressBar
            // 
            this.recordingProgressBar.Location = new System.Drawing.Point(184, 34);
            this.recordingProgressBar.Name = "recordingProgressBar";
            this.recordingProgressBar.Size = new System.Drawing.Size(100, 23);
            this.recordingProgressBar.TabIndex = 6;
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.AutoSize = true;
            this.connectionStatusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.connectionStatusLabel.Location = new System.Drawing.Point(3, 31);
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            this.connectionStatusLabel.Size = new System.Drawing.Size(41, 13);
            this.connectionStatusLabel.TabIndex = 5;
            this.connectionStatusLabel.Text = "label24";
            // 
            // recordTimeLabel
            // 
            this.recordTimeLabel.AutoSize = true;
            this.recordTimeLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.recordTimeLabel.Location = new System.Drawing.Point(3, 18);
            this.recordTimeLabel.Name = "recordTimeLabel";
            this.recordTimeLabel.Size = new System.Drawing.Size(41, 13);
            this.recordTimeLabel.TabIndex = 4;
            this.recordTimeLabel.Text = "label24";
            // 
            // clock_lbl
            // 
            this.clock_lbl.AutoSize = true;
            this.clock_lbl.ForeColor = System.Drawing.SystemColors.Control;
            this.clock_lbl.Location = new System.Drawing.Point(3, 5);
            this.clock_lbl.Name = "clock_lbl";
            this.clock_lbl.Size = new System.Drawing.Size(41, 13);
            this.clock_lbl.TabIndex = 3;
            this.clock_lbl.Text = "label24";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1028, 683);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1028, 683);
            this.toolStripContainer1.TabIndex = 25;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 683);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "ECOM America: CRS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tilePopUpMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.hTile0.ResumeLayout(false);
            this.hTile0.PerformLayout();
            this.sTile2.ResumeLayout(false);
            this.sTile2.PerformLayout();
            this.sTile9.ResumeLayout(false);
            this.sTile9.PerformLayout();
            this.sTile8.ResumeLayout(false);
            this.sTile8.PerformLayout();
            this.sTile7.ResumeLayout(false);
            this.sTile7.PerformLayout();
            this.sTile6.ResumeLayout(false);
            this.sTile6.PerformLayout();
            this.sTile1.ResumeLayout(false);
            this.sTile1.PerformLayout();
            this.sTile4.ResumeLayout(false);
            this.sTile4.PerformLayout();
            this.sTile3.ResumeLayout(false);
            this.sTile3.PerformLayout();
            this.sTile5.ResumeLayout(false);
            this.sTile5.PerformLayout();
            this.hTile1.ResumeLayout(false);
            this.hTile1.PerformLayout();
            this.sTile0.ResumeLayout(false);
            this.sTile0.PerformLayout();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.panel19.ResumeLayout(false);
            this.panel19.PerformLayout();
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureRecordingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configureReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem performPreAndPostCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupCommunictaionPortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewCalibrationInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterCalGasInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem preTestCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postTestCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem abortCalibrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveReportToolStripMenuItem;


        //////////////////////////////////////////CHECKBOXES/////////////////////////////////////////

        //////////////////////////////////////////TEXTBOXS/////////////////////////////////////////

        //////////////////////////////////////////TABLELAYOUTPANELS/////////////////////////////////////////


        //////////////////////////////////////////BUTTONS/////////////////////////////////////////
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ToolTip toolTip1;

        public DateTime startTime = DateTime.Now;
        private ToolStripMenuItem checkUpgradeToolStripMenuItem;
        private ToolStripMenuItem aboutAdvDASToolStripMenuItem;
        private ToolStripMenuItem setupEquipmentSiteToolStripMenuItem;
        private ToolStripMenuItem personalDataToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem equipmentSiteToolStripMenuItem;
        private System.Windows.Forms.Timer recordSign;
        private ToolStripMenuItem instrumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem blueWhiteColorToolStripMenuItem;
        private ToolStripMenuItem blackBlueColorToolStripMenuItem;
        private ToolStripMenuItem blueBlackToolStripMenuItem;
        private ToolStripMenuItem dataToolStripMenuItem;
        private ToolStripMenuItem viewTestRecordsToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel hTile0;
        private Label label11;
        private Label label11_;
        private Button tileButton11;
        public Label rLabela1;
        private Label tileLabel11;
        private Label rLabela2;
        private TableLayoutPanel sTile2;
        private Label label3;
        private Label tileLabel3;
        private Button tileButton3;
        private TableLayoutPanel sTile9;
        private Button tileButton10;
        private Label label10;
        private Label tileLabel10;
        private TableLayoutPanel sTile8;
        private Button tileButton9;
        private Label label9;
        private Label tileLabel9;
        private TableLayoutPanel sTile7;
        private Button tileButton8;
        private Label label8;
        private Label tileLabel8;
        private TableLayoutPanel sTile6;
        private Button tileButton7;
        private Label label7;
        private Label tileLabel7;
        private TableLayoutPanel sTile1;
        private Button tileButton2;
        private Label label2;
        private Label tileLabel2;
        private TableLayoutPanel sTile4;
        private Button tileButton5;
        private Label label5;
        private Label tileLabel5;
        private TableLayoutPanel sTile3;
        private Button tileButton4;
        private Label label4;
        private Label tileLabel4;
        private TableLayoutPanel sTile5;
        private Button tileButton6;
        private Label label6;
        private Label tileLabel6;
        private TableLayoutPanel hTile1;
        private Label label12;
        private Label label12_;
        private Button tileButton12;
        public Label rLabelb1;
        private Label tileLabel12;
        private Label rLabelb2;
        private TableLayoutPanel sTile0;
        private Label label1;
        private Label tileLabel1;
        private Button tileButton1;
        private TableLayoutPanel tableLayoutPanel11;
        private Label cycleLabel;
        private Label rTimelbl;
        private Label tTimelbl;
        private Label pTimelbl;
        private Label plbl;
        private Label tlbl;
        private Label rlbl;
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
        private TableLayoutPanel tableLayoutPanel15;
        private Label label19;
        private Panel panel5;
        private CheckBox checkBox3;
        public Label label20;
        private Label label54;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label17;
        private Panel panel3;
        private CheckBox checkBox2;
        public Label label18;
        private Label label53;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label15;
        private Panel panel2;
        private CheckBox checkBox1;
        public Label label16;
        private Label label44;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label31;
        private Panel panel14;
        private CheckBox checkBox10;
        public Label label33;
        private Label label40;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel17;
        private CheckBox checkBox13;
        public Label label41;
        private Label label42;
        private Label label49;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label43;
        private Panel panel18;
        private CheckBox checkBox14;
        public Label label45;
        private Label label46;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel19;
        private CheckBox checkBox15;
        public Label label47;
        private Label label48;
        private Label label32;
        private TableLayoutPanel tableLayoutPanel10;
        private Panel panel20;
        private CheckBox checkBox16;
        public Label label50;
        private Label label51;
        private Label label61;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label59;
        private Panel panel23;
        private CheckBox checkBox19;
        public Label label60;
        private Label label52;
        private TabPage tabPage4;
        private Button button16;
        private Button button15;
        private TableLayoutPanel tableLayoutPanel12;
        private Panel panel4;
        private Panel panel12;
        private PictureBox recordingSign;
        private Button snapShotButton;
        private Button stopRecordingButton;
        private Button startRecordingButton;
        private TableLayoutPanel tableLayoutPanel2;
        private ToolStripMenuItem applyO2CorrectionToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel16;
        private Label iflowlbl;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label13;
        private Label label14;
        private Label label21;
        private Label label22;
        private Label label23;
        private ToolStripContainer toolStripContainer1;
        private Panel panel7;
        private Label connectionStatusLabel;
        private Label recordTimeLabel;
        private Label clock_lbl;
        private ProgressBar recordingProgressBar;
        private Label phaseTimeLabel;
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
        internal System.Windows.Forms.Timer dataGridTimer;


    }
}

