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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4.6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint11 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint12 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 261D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint13 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint14 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint17 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint18 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 350D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint19 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 290D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint20 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint21 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint22 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint23 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 75D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint24 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint25 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series31 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series32 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series33 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series34 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.blackBlueColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitPurgeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitStandbyModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAnalyzerStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startPeristalticPumpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkUpgradeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAdvDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.connectionStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phaseLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.phaseTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.recordingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.clock_lbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.tilePopUpMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.snapShot = new System.Windows.Forms.Button();
            this.stopRecordingItem = new System.Windows.Forms.Button();
            this.pauseRecordingItem = new System.Windows.Forms.Button();
            this.startRecordingItem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label11_ = new System.Windows.Forms.Label();
            this.tileButton11 = new System.Windows.Forms.Button();
            this.rLabel1 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.tileButton3 = new System.Windows.Forms.Button();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton10 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton9 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.tileButton6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.hTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label12_ = new System.Windows.Forms.Label();
            this.tileButton12 = new System.Windows.Forms.Button();
            this.rLabel2 = new System.Windows.Forms.Label();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.tileButton1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button13 = new System.Windows.Forms.Button();
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
            this.trendGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.elementTable = new System.Windows.Forms.DataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGraph = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel12 = new System.Windows.Forms.Panel();
            this.recordingSign = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.recordSign = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).BeginInit();
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
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupEquipmentSiteToolStripMenuItem,
            this.configureToolStripMenuItem,
            this.menuCalibrationItem,
            this.analyzeToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedFunctionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveReportToolStripMenuItem,
            this.browseReportsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // advancedFunctionsToolStripMenuItem
            // 
            this.advancedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem});
            this.advancedFunctionsToolStripMenuItem.Name = "advancedFunctionsToolStripMenuItem";
            resources.ApplyResources(this.advancedFunctionsToolStripMenuItem, "advancedFunctionsToolStripMenuItem");
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            resources.ApplyResources(this.instrumentToolStripMenuItem, "instrumentToolStripMenuItem");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // saveReportToolStripMenuItem
            // 
            this.saveReportToolStripMenuItem.Name = "saveReportToolStripMenuItem";
            resources.ApplyResources(this.saveReportToolStripMenuItem, "saveReportToolStripMenuItem");
            // 
            // browseReportsToolStripMenuItem
            // 
            this.browseReportsToolStripMenuItem.Name = "browseReportsToolStripMenuItem";
            resources.ApplyResources(this.browseReportsToolStripMenuItem, "browseReportsToolStripMenuItem");
            // 
            // setupEquipmentSiteToolStripMenuItem
            // 
            this.setupEquipmentSiteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.equipmentSiteToolStripMenuItem,
            this.toolStripSeparator4,
            this.themeToolStripMenuItem});
            this.setupEquipmentSiteToolStripMenuItem.Name = "setupEquipmentSiteToolStripMenuItem";
            resources.ApplyResources(this.setupEquipmentSiteToolStripMenuItem, "setupEquipmentSiteToolStripMenuItem");
            // 
            // personalDataToolStripMenuItem
            // 
            this.personalDataToolStripMenuItem.Name = "personalDataToolStripMenuItem";
            resources.ApplyResources(this.personalDataToolStripMenuItem, "personalDataToolStripMenuItem");
            this.personalDataToolStripMenuItem.Click += new System.EventHandler(this.personalDataToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            resources.ApplyResources(this.customerToolStripMenuItem, "customerToolStripMenuItem");
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // equipmentSiteToolStripMenuItem
            // 
            this.equipmentSiteToolStripMenuItem.Name = "equipmentSiteToolStripMenuItem";
            resources.ApplyResources(this.equipmentSiteToolStripMenuItem, "equipmentSiteToolStripMenuItem");
            this.equipmentSiteToolStripMenuItem.Click += new System.EventHandler(this.equipmentSiteToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueWhiteColorToolStripMenuItem,
            this.blackBlueColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            resources.ApplyResources(this.themeToolStripMenuItem, "themeToolStripMenuItem");
            // 
            // blueWhiteColorToolStripMenuItem
            // 
            this.blueWhiteColorToolStripMenuItem.Name = "blueWhiteColorToolStripMenuItem";
            resources.ApplyResources(this.blueWhiteColorToolStripMenuItem, "blueWhiteColorToolStripMenuItem");
            this.blueWhiteColorToolStripMenuItem.Click += new System.EventHandler(this.blueWhiteColorToolStripMenuItem_Click);
            // 
            // blackBlueColorToolStripMenuItem
            // 
            this.blackBlueColorToolStripMenuItem.Name = "blackBlueColorToolStripMenuItem";
            resources.ApplyResources(this.blackBlueColorToolStripMenuItem, "blackBlueColorToolStripMenuItem");
            this.blackBlueColorToolStripMenuItem.Click += new System.EventHandler(this.blackBlueColorToolStripMenuItem_Click);
            // 
            // configureToolStripMenuItem
            // 
            this.configureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configureRecordingToolStripMenuItem,
            this.configureReportToolStripMenuItem,
            this.performPreAndPostCalibrationToolStripMenuItem,
            this.setupCommunictaionPortsToolStripMenuItem});
            this.configureToolStripMenuItem.Name = "configureToolStripMenuItem";
            resources.ApplyResources(this.configureToolStripMenuItem, "configureToolStripMenuItem");
            // 
            // configureRecordingToolStripMenuItem
            // 
            this.configureRecordingToolStripMenuItem.Name = "configureRecordingToolStripMenuItem";
            resources.ApplyResources(this.configureRecordingToolStripMenuItem, "configureRecordingToolStripMenuItem");
            this.configureRecordingToolStripMenuItem.Click += new System.EventHandler(this.configureRecordingToolStripMenuItem_Click);
            // 
            // configureReportToolStripMenuItem
            // 
            this.configureReportToolStripMenuItem.Name = "configureReportToolStripMenuItem";
            resources.ApplyResources(this.configureReportToolStripMenuItem, "configureReportToolStripMenuItem");
            this.configureReportToolStripMenuItem.Click += new System.EventHandler(this.configureReportToolStripMenuItem_Click);
            // 
            // performPreAndPostCalibrationToolStripMenuItem
            // 
            this.performPreAndPostCalibrationToolStripMenuItem.Checked = true;
            this.performPreAndPostCalibrationToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            resources.ApplyResources(this.performPreAndPostCalibrationToolStripMenuItem, "performPreAndPostCalibrationToolStripMenuItem");
            this.performPreAndPostCalibrationToolStripMenuItem.Name = "performPreAndPostCalibrationToolStripMenuItem";
            // 
            // setupCommunictaionPortsToolStripMenuItem
            // 
            this.setupCommunictaionPortsToolStripMenuItem.Name = "setupCommunictaionPortsToolStripMenuItem";
            resources.ApplyResources(this.setupCommunictaionPortsToolStripMenuItem, "setupCommunictaionPortsToolStripMenuItem");
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
            this.menuCalibrationItem.Name = "menuCalibrationItem";
            resources.ApplyResources(this.menuCalibrationItem, "menuCalibrationItem");
            // 
            // viewCalibrationInfoToolStripMenuItem
            // 
            this.viewCalibrationInfoToolStripMenuItem.Name = "viewCalibrationInfoToolStripMenuItem";
            resources.ApplyResources(this.viewCalibrationInfoToolStripMenuItem, "viewCalibrationInfoToolStripMenuItem");
            this.viewCalibrationInfoToolStripMenuItem.Click += new System.EventHandler(this.viewCalibrationInfoToolStripMenuItem_Click);
            // 
            // enterCalGasInfoToolStripMenuItem
            // 
            this.enterCalGasInfoToolStripMenuItem.Name = "enterCalGasInfoToolStripMenuItem";
            resources.ApplyResources(this.enterCalGasInfoToolStripMenuItem, "enterCalGasInfoToolStripMenuItem");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // preTestCalibrationToolStripMenuItem
            // 
            this.preTestCalibrationToolStripMenuItem.Name = "preTestCalibrationToolStripMenuItem";
            resources.ApplyResources(this.preTestCalibrationToolStripMenuItem, "preTestCalibrationToolStripMenuItem");
            // 
            // postTestCalibrationToolStripMenuItem
            // 
            resources.ApplyResources(this.postTestCalibrationToolStripMenuItem, "postTestCalibrationToolStripMenuItem");
            this.postTestCalibrationToolStripMenuItem.Name = "postTestCalibrationToolStripMenuItem";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // abortCalibrationToolStripMenuItem
            // 
            this.abortCalibrationToolStripMenuItem.Name = "abortCalibrationToolStripMenuItem";
            resources.ApplyResources(this.abortCalibrationToolStripMenuItem, "abortCalibrationToolStripMenuItem");
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
            resources.ApplyResources(this.analyzeToolStripMenuItem, "analyzeToolStripMenuItem");
            // 
            // exitPurgeModeToolStripMenuItem
            // 
            this.exitPurgeModeToolStripMenuItem.Name = "exitPurgeModeToolStripMenuItem";
            resources.ApplyResources(this.exitPurgeModeToolStripMenuItem, "exitPurgeModeToolStripMenuItem");
            // 
            // exitStandbyModeToolStripMenuItem
            // 
            this.exitStandbyModeToolStripMenuItem.Name = "exitStandbyModeToolStripMenuItem";
            resources.ApplyResources(this.exitStandbyModeToolStripMenuItem, "exitStandbyModeToolStripMenuItem");
            // 
            // viewAnalyzerStatusToolStripMenuItem
            // 
            this.viewAnalyzerStatusToolStripMenuItem.Name = "viewAnalyzerStatusToolStripMenuItem";
            resources.ApplyResources(this.viewAnalyzerStatusToolStripMenuItem, "viewAnalyzerStatusToolStripMenuItem");
            // 
            // beepToolStripMenuItem
            // 
            this.beepToolStripMenuItem.Name = "beepToolStripMenuItem";
            resources.ApplyResources(this.beepToolStripMenuItem, "beepToolStripMenuItem");
            // 
            // startPeristalticPumpToolStripMenuItem
            // 
            this.startPeristalticPumpToolStripMenuItem.Name = "startPeristalticPumpToolStripMenuItem";
            resources.ApplyResources(this.startPeristalticPumpToolStripMenuItem, "startPeristalticPumpToolStripMenuItem");
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkUpgradeToolStripMenuItem,
            this.aboutAdvDASToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // checkUpgradeToolStripMenuItem
            // 
            this.checkUpgradeToolStripMenuItem.Name = "checkUpgradeToolStripMenuItem";
            resources.ApplyResources(this.checkUpgradeToolStripMenuItem, "checkUpgradeToolStripMenuItem");
            // 
            // aboutAdvDASToolStripMenuItem
            // 
            this.aboutAdvDASToolStripMenuItem.Name = "aboutAdvDASToolStripMenuItem";
            resources.ApplyResources(this.aboutAdvDASToolStripMenuItem, "aboutAdvDASToolStripMenuItem");
            this.aboutAdvDASToolStripMenuItem.Click += new System.EventHandler(this.aboutAdvDASToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionStatusLabel,
            this.recordStatusLabel,
            this.recordTimeLabel,
            this.phaseLabel,
            this.phaseTimeLabel,
            this.recordingProgressBar,
            this.clock_lbl});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // connectionStatusLabel
            // 
            this.connectionStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.connectionStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.connectionStatusLabel.Name = "connectionStatusLabel";
            resources.ApplyResources(this.connectionStatusLabel, "connectionStatusLabel");
            // 
            // recordStatusLabel
            // 
            this.recordStatusLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.recordStatusLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.recordStatusLabel.Name = "recordStatusLabel";
            resources.ApplyResources(this.recordStatusLabel, "recordStatusLabel");
            // 
            // recordTimeLabel
            // 
            this.recordTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.recordTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.recordTimeLabel.Name = "recordTimeLabel";
            resources.ApplyResources(this.recordTimeLabel, "recordTimeLabel");
            // 
            // phaseLabel
            // 
            this.phaseLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.phaseLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.phaseLabel.Name = "phaseLabel";
            resources.ApplyResources(this.phaseLabel, "phaseLabel");
            // 
            // phaseTimeLabel
            // 
            this.phaseTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.phaseTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.phaseTimeLabel.Name = "phaseTimeLabel";
            resources.ApplyResources(this.phaseTimeLabel, "phaseTimeLabel");
            // 
            // recordingProgressBar
            // 
            this.recordingProgressBar.Maximum = 20;
            this.recordingProgressBar.Name = "recordingProgressBar";
            resources.ApplyResources(this.recordingProgressBar, "recordingProgressBar");
            // 
            // clock_lbl
            // 
            this.clock_lbl.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.clock_lbl.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.clock_lbl.Name = "clock_lbl";
            resources.ApplyResources(this.clock_lbl, "clock_lbl");
            // 
            // tilePopUpMenu
            // 
            this.tilePopUpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDisplayToolStripMenuItem});
            this.tilePopUpMenu.Name = "panelPopUpMenu";
            resources.ApplyResources(this.tilePopUpMenu, "tilePopUpMenu");
            // 
            // editDisplayToolStripMenuItem
            // 
            this.editDisplayToolStripMenuItem.Name = "editDisplayToolStripMenuItem";
            resources.ApplyResources(this.editDisplayToolStripMenuItem, "editDisplayToolStripMenuItem");
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
            // checkBox10
            // 
            resources.ApplyResources(this.checkBox10, "checkBox10");
            this.checkBox10.Name = "checkBox10";
            this.toolTip1.SetToolTip(this.checkBox10, resources.GetString("checkBox10.ToolTip"));
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            resources.ApplyResources(this.checkBox13, "checkBox13");
            this.checkBox13.Name = "checkBox13";
            this.toolTip1.SetToolTip(this.checkBox13, resources.GetString("checkBox13.ToolTip"));
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            resources.ApplyResources(this.checkBox14, "checkBox14");
            this.checkBox14.Name = "checkBox14";
            this.toolTip1.SetToolTip(this.checkBox14, resources.GetString("checkBox14.ToolTip"));
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            resources.ApplyResources(this.checkBox15, "checkBox15");
            this.checkBox15.Name = "checkBox15";
            this.toolTip1.SetToolTip(this.checkBox15, resources.GetString("checkBox15.ToolTip"));
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            resources.ApplyResources(this.checkBox16, "checkBox16");
            this.checkBox16.Name = "checkBox16";
            this.toolTip1.SetToolTip(this.checkBox16, resources.GetString("checkBox16.ToolTip"));
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            resources.ApplyResources(this.checkBox19, "checkBox19");
            this.checkBox19.Name = "checkBox19";
            this.toolTip1.SetToolTip(this.checkBox19, resources.GetString("checkBox19.ToolTip"));
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            resources.ApplyResources(this.checkBox1, "checkBox1");
            this.checkBox1.Name = "checkBox1";
            this.toolTip1.SetToolTip(this.checkBox1, resources.GetString("checkBox1.ToolTip"));
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            resources.ApplyResources(this.checkBox2, "checkBox2");
            this.checkBox2.Name = "checkBox2";
            this.toolTip1.SetToolTip(this.checkBox2, resources.GetString("checkBox2.ToolTip"));
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            resources.ApplyResources(this.checkBox3, "checkBox3");
            this.checkBox3.Name = "checkBox3";
            this.toolTip1.SetToolTip(this.checkBox3, resources.GetString("checkBox3.ToolTip"));
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // snapShot
            // 
            this.snapShot.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.snapShot, "snapShot");
            this.snapShot.Name = "snapShot";
            this.toolTip1.SetToolTip(this.snapShot, resources.GetString("snapShot.ToolTip"));
            this.snapShot.UseVisualStyleBackColor = false;
            // 
            // stopRecordingItem
            // 
            resources.ApplyResources(this.stopRecordingItem, "stopRecordingItem");
            this.stopRecordingItem.Name = "stopRecordingItem";
            this.toolTip1.SetToolTip(this.stopRecordingItem, resources.GetString("stopRecordingItem.ToolTip"));
            this.stopRecordingItem.UseVisualStyleBackColor = true;
            this.stopRecordingItem.Click += new System.EventHandler(this.stopRecordingItem_Click);
            // 
            // pauseRecordingItem
            // 
            resources.ApplyResources(this.pauseRecordingItem, "pauseRecordingItem");
            this.pauseRecordingItem.Name = "pauseRecordingItem";
            this.toolTip1.SetToolTip(this.pauseRecordingItem, resources.GetString("pauseRecordingItem.ToolTip"));
            this.pauseRecordingItem.UseVisualStyleBackColor = true;
            this.pauseRecordingItem.Click += new System.EventHandler(this.pauseRecordingItem_Click);
            // 
            // startRecordingItem
            // 
            resources.ApplyResources(this.startRecordingItem, "startRecordingItem");
            this.startRecordingItem.ForeColor = System.Drawing.Color.Transparent;
            this.startRecordingItem.Name = "startRecordingItem";
            this.toolTip1.SetToolTip(this.startRecordingItem, resources.GetString("startRecordingItem.ToolTip"));
            this.startRecordingItem.UseVisualStyleBackColor = true;
            this.startRecordingItem.Click += new System.EventHandler(this.startRecordingItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.shapeContainer1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
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
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // hTile0
            // 
            this.hTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.hTile0, "hTile0");
            this.tableLayoutPanel1.SetColumnSpan(this.hTile0, 2);
            this.hTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile0.Controls.Add(this.tileLabel11, 0, 0);
            this.hTile0.Controls.Add(this.label11, 0, 1);
            this.hTile0.Controls.Add(this.label11_, 3, 1);
            this.hTile0.Controls.Add(this.tileButton11, 1, 2);
            this.hTile0.Controls.Add(this.rLabel1, 1, 1);
            this.hTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile0.Name = "hTile0";
            // 
            // tileLabel11
            // 
            resources.ApplyResources(this.tileLabel11, "tileLabel11");
            this.hTile0.SetColumnSpan(this.tileLabel11, 4);
            this.tileLabel11.Name = "tileLabel11";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Name = "label11";
            this.hTile0.SetRowSpan(this.label11, 2);
            // 
            // label11_
            // 
            resources.ApplyResources(this.label11_, "label11_");
            this.label11_.BackColor = System.Drawing.SystemColors.Control;
            this.label11_.Name = "label11_";
            this.hTile0.SetRowSpan(this.label11_, 2);
            // 
            // tileButton11
            // 
            this.hTile0.SetColumnSpan(this.tileButton11, 2);
            resources.ApplyResources(this.tileButton11, "tileButton11");
            this.tileButton11.Name = "tileButton11";
            this.tileButton11.UseVisualStyleBackColor = true;
            // 
            // rLabel1
            // 
            resources.ApplyResources(this.rLabel1, "rLabel1");
            this.hTile0.SetColumnSpan(this.rLabel1, 2);
            this.rLabel1.Name = "rLabel1";
            // 
            // sTile2
            // 
            this.sTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile2.BackgroundImage = global::CRS.Properties.Resources.dashboardPanel;
            resources.ApplyResources(this.sTile2, "sTile2");
            this.sTile2.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile2.Controls.Add(this.label3, 0, 1);
            this.sTile2.Controls.Add(this.tileLabel3, 0, 0);
            this.sTile2.Controls.Add(this.tileButton3, 0, 2);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile2.Name = "sTile2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Name = "label3";
            // 
            // tileLabel3
            // 
            resources.ApplyResources(this.tileLabel3, "tileLabel3");
            this.tileLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel3.Name = "tileLabel3";
            // 
            // tileButton3
            // 
            this.tileButton3.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton3, "tileButton3");
            this.tileButton3.Name = "tileButton3";
            this.tileButton3.UseVisualStyleBackColor = false;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile9, "sTile9");
            this.sTile9.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile9.Controls.Add(this.tileButton10, 0, 2);
            this.sTile9.Controls.Add(this.label10, 0, 1);
            this.sTile9.Controls.Add(this.tileLabel10, 0, 0);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile9.Name = "sTile9";
            // 
            // tileButton10
            // 
            this.tileButton10.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton10, "tileButton10");
            this.tileButton10.Name = "tileButton10";
            this.tileButton10.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Name = "label10";
            // 
            // tileLabel10
            // 
            resources.ApplyResources(this.tileLabel10, "tileLabel10");
            this.tileLabel10.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel10.Name = "tileLabel10";
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile8, "sTile8");
            this.sTile8.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile8.Controls.Add(this.tileButton9, 0, 2);
            this.sTile8.Controls.Add(this.label9, 0, 1);
            this.sTile8.Controls.Add(this.tileLabel9, 0, 0);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile8.Name = "sTile8";
            // 
            // tileButton9
            // 
            this.tileButton9.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton9, "tileButton9");
            this.tileButton9.Name = "tileButton9";
            this.tileButton9.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Name = "label9";
            // 
            // tileLabel9
            // 
            resources.ApplyResources(this.tileLabel9, "tileLabel9");
            this.tileLabel9.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel9.Name = "tileLabel9";
            // 
            // sTile7
            // 
            this.sTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile7, "sTile7");
            this.sTile7.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile7.Controls.Add(this.tileButton8, 0, 2);
            this.sTile7.Controls.Add(this.label8, 0, 1);
            this.sTile7.Controls.Add(this.tileLabel8, 0, 0);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile7.Name = "sTile7";
            // 
            // tileButton8
            // 
            this.tileButton8.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton8, "tileButton8");
            this.tileButton8.Name = "tileButton8";
            this.tileButton8.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Name = "label8";
            // 
            // tileLabel8
            // 
            resources.ApplyResources(this.tileLabel8, "tileLabel8");
            this.tileLabel8.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel8.Name = "tileLabel8";
            // 
            // sTile6
            // 
            this.sTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile6, "sTile6");
            this.sTile6.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile6.Controls.Add(this.tileButton7, 0, 2);
            this.sTile6.Controls.Add(this.label7, 0, 1);
            this.sTile6.Controls.Add(this.tileLabel7, 0, 0);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile6.Name = "sTile6";
            // 
            // tileButton7
            // 
            this.tileButton7.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton7, "tileButton7");
            this.tileButton7.Name = "tileButton7";
            this.tileButton7.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Name = "label7";
            // 
            // tileLabel7
            // 
            resources.ApplyResources(this.tileLabel7, "tileLabel7");
            this.tileLabel7.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel7.Name = "tileLabel7";
            // 
            // sTile1
            // 
            this.sTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile1.BackgroundImage = global::CRS.Properties.Resources.dashboardPanel;
            resources.ApplyResources(this.sTile1, "sTile1");
            this.sTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile1.Controls.Add(this.tileButton2, 0, 2);
            this.sTile1.Controls.Add(this.label2, 0, 1);
            this.sTile1.Controls.Add(this.tileLabel2, 0, 0);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile1.Name = "sTile1";
            // 
            // tileButton2
            // 
            this.tileButton2.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton2, "tileButton2");
            this.tileButton2.Name = "tileButton2";
            this.tileButton2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // tileLabel2
            // 
            resources.ApplyResources(this.tileLabel2, "tileLabel2");
            this.tileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel2.Name = "tileLabel2";
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile4, "sTile4");
            this.sTile4.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile4.Controls.Add(this.tileButton5, 0, 2);
            this.sTile4.Controls.Add(this.label5, 0, 1);
            this.sTile4.Controls.Add(this.tileLabel5, 0, 0);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile4.Name = "sTile4";
            // 
            // tileButton5
            // 
            this.tileButton5.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton5, "tileButton5");
            this.tileButton5.Name = "tileButton5";
            this.tileButton5.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // tileLabel5
            // 
            resources.ApplyResources(this.tileLabel5, "tileLabel5");
            this.tileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel5.Name = "tileLabel5";
            // 
            // sTile3
            // 
            this.sTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile3, "sTile3");
            this.sTile3.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile3.Controls.Add(this.tileButton4, 0, 2);
            this.sTile3.Controls.Add(this.label4, 0, 1);
            this.sTile3.Controls.Add(this.tileLabel4, 0, 0);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile3.Name = "sTile3";
            // 
            // tileButton4
            // 
            this.tileButton4.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton4, "tileButton4");
            this.tileButton4.Name = "tileButton4";
            this.tileButton4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Name = "label4";
            // 
            // tileLabel4
            // 
            resources.ApplyResources(this.tileLabel4, "tileLabel4");
            this.tileLabel4.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel4.Name = "tileLabel4";
            // 
            // sTile5
            // 
            this.sTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.sTile5, "sTile5");
            this.sTile5.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile5.Controls.Add(this.tileButton6, 0, 2);
            this.sTile5.Controls.Add(this.label6, 0, 1);
            this.sTile5.Controls.Add(this.tileLabel6, 0, 0);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile5.Name = "sTile5";
            // 
            // tileButton6
            // 
            this.tileButton6.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton6, "tileButton6");
            this.tileButton6.Name = "tileButton6";
            this.tileButton6.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Name = "label6";
            // 
            // tileLabel6
            // 
            resources.ApplyResources(this.tileLabel6, "tileLabel6");
            this.tileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel6.Name = "tileLabel6";
            // 
            // hTile1
            // 
            this.hTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.hTile1, "hTile1");
            this.tableLayoutPanel1.SetColumnSpan(this.hTile1, 2);
            this.hTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile1.Controls.Add(this.label12, 0, 1);
            this.hTile1.Controls.Add(this.label12_, 3, 1);
            this.hTile1.Controls.Add(this.tileButton12, 1, 2);
            this.hTile1.Controls.Add(this.rLabel2, 1, 1);
            this.hTile1.Controls.Add(this.tileLabel12, 0, 0);
            this.hTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile1.Name = "hTile1";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Name = "label12";
            this.hTile1.SetRowSpan(this.label12, 2);
            // 
            // label12_
            // 
            resources.ApplyResources(this.label12_, "label12_");
            this.label12_.BackColor = System.Drawing.SystemColors.Control;
            this.label12_.Name = "label12_";
            this.hTile1.SetRowSpan(this.label12_, 2);
            // 
            // tileButton12
            // 
            this.tileButton12.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.SetColumnSpan(this.tileButton12, 2);
            resources.ApplyResources(this.tileButton12, "tileButton12");
            this.tileButton12.Name = "tileButton12";
            this.tileButton12.UseVisualStyleBackColor = false;
            // 
            // rLabel2
            // 
            resources.ApplyResources(this.rLabel2, "rLabel2");
            this.hTile1.SetColumnSpan(this.rLabel2, 2);
            this.rLabel2.Name = "rLabel2";
            // 
            // tileLabel12
            // 
            resources.ApplyResources(this.tileLabel12, "tileLabel12");
            this.hTile1.SetColumnSpan(this.tileLabel12, 4);
            this.tileLabel12.Name = "tileLabel12";
            // 
            // sTile0
            // 
            this.sTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile0.BackgroundImage = global::CRS.Properties.Resources.dashboardPanel;
            resources.ApplyResources(this.sTile0, "sTile0");
            this.sTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile0.Controls.Add(this.label1, 0, 1);
            this.sTile0.Controls.Add(this.tileLabel1, 0, 0);
            this.sTile0.Controls.Add(this.tileButton1, 0, 2);
            this.sTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile0.Name = "sTile0";
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // tileLabel1
            // 
            resources.ApplyResources(this.tileLabel1, "tileLabel1");
            this.tileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel1.Name = "tileLabel1";
            // 
            // tileButton1
            // 
            this.tileButton1.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.tileButton1, "tileButton1");
            this.tileButton1.FlatAppearance.BorderSize = 0;
            this.tileButton1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tileButton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tileButton1.Name = "tileButton1";
            this.tileButton1.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel11
            // 
            resources.ApplyResources(this.tableLayoutPanel11, "tableLayoutPanel11");
            this.tableLayoutPanel11.Controls.Add(this.progressBar1, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.button13, 0, 5);
            this.tableLayoutPanel11.Controls.Add(this.cycleLabel, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.rTimelbl, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.tTimelbl, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.pTimelbl, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.plbl, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.tlbl, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.rlbl, 0, 1);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.tableLayoutPanel11.SetColumnSpan(this.progressBar1, 2);
            this.progressBar1.Name = "progressBar1";
            // 
            // button13
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.button13, 2);
            resources.ApplyResources(this.button13, "button13");
            this.button13.Name = "button13";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // cycleLabel
            // 
            resources.ApplyResources(this.cycleLabel, "cycleLabel");
            this.tableLayoutPanel11.SetColumnSpan(this.cycleLabel, 2);
            this.cycleLabel.Name = "cycleLabel";
            // 
            // rTimelbl
            // 
            resources.ApplyResources(this.rTimelbl, "rTimelbl");
            this.rTimelbl.Name = "rTimelbl";
            // 
            // tTimelbl
            // 
            resources.ApplyResources(this.tTimelbl, "tTimelbl");
            this.tTimelbl.Name = "tTimelbl";
            // 
            // pTimelbl
            // 
            resources.ApplyResources(this.pTimelbl, "pTimelbl");
            this.pTimelbl.Name = "pTimelbl";
            // 
            // plbl
            // 
            resources.ApplyResources(this.plbl, "plbl");
            this.plbl.Name = "plbl";
            // 
            // tlbl
            // 
            resources.ApplyResources(this.tlbl, "tlbl");
            this.tlbl.Name = "tlbl";
            // 
            // rlbl
            // 
            resources.ApplyResources(this.rlbl, "rlbl");
            this.rlbl.Name = "rlbl";
            // 
            // shapeContainer1
            // 
            resources.ApplyResources(this.shapeContainer1, "shapeContainer1");
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            resources.ApplyResources(this.lineShape1, "lineShape1");
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableLayoutPanel14);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // tableLayoutPanel14
            // 
            resources.ApplyResources(this.tableLayoutPanel14, "tableLayoutPanel14");
            this.tableLayoutPanel14.Controls.Add(this.trendGraph, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            // 
            // trendGraph
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea1.AxisY.ScaleBreakStyle.Spacing = 10D;
            chartArea1.Name = "ChartArea1";
            this.trendGraph.ChartAreas.Add(chartArea1);
            resources.ApplyResources(this.trendGraph, "trendGraph");
            legend1.Name = "Legend1";
            this.trendGraph.Legends.Add(legend1);
            this.trendGraph.Name = "trendGraph";
            this.trendGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend1";
            series1.Name = "O2";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.Points.Add(dataPoint5);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "CO";
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series2.Points.Add(dataPoint9);
            series2.Points.Add(dataPoint10);
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series3.Legend = "Legend1";
            series3.Name = "CO2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series4.Legend = "Legend1";
            series4.Name = "NO";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series5.Legend = "Legend1";
            series5.Name = "NO2";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series6.Legend = "Legend1";
            series6.Name = "NOx";
            series6.Points.Add(dataPoint11);
            series6.Points.Add(dataPoint12);
            series6.Points.Add(dataPoint13);
            series6.Points.Add(dataPoint14);
            series6.Points.Add(dataPoint15);
            series6.YValueMembers = "Tag";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series7.Legend = "Legend1";
            series7.Name = "SO2";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series8.Legend = "Legend1";
            series8.Name = "CxHy";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series9.Legend = "Legend1";
            series9.Name = "T(gas)";
            series9.Points.Add(dataPoint16);
            series9.Points.Add(dataPoint17);
            series9.Points.Add(dataPoint18);
            series9.Points.Add(dataPoint19);
            series9.Points.Add(dataPoint20);
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series10.Legend = "Legend1";
            series10.Name = "T(amb)";
            series10.Points.Add(dataPoint21);
            series10.Points.Add(dataPoint22);
            series10.Points.Add(dataPoint23);
            series10.Points.Add(dataPoint24);
            series10.Points.Add(dataPoint25);
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series11.Legend = "Legend1";
            series11.Name = "T(cell)";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "Efficiency";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Legend = "Legend1";
            series13.Name = "I.Flow";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Legend = "Legend1";
            series14.Name = "Draft";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Legend = "Legend1";
            series15.Name = "Losses";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Excess Air";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "CO(mass)";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series18.Legend = "Legend1";
            series18.Name = "NOx(mass)";
            this.trendGraph.Series.Add(series1);
            this.trendGraph.Series.Add(series2);
            this.trendGraph.Series.Add(series3);
            this.trendGraph.Series.Add(series4);
            this.trendGraph.Series.Add(series5);
            this.trendGraph.Series.Add(series6);
            this.trendGraph.Series.Add(series7);
            this.trendGraph.Series.Add(series8);
            this.trendGraph.Series.Add(series9);
            this.trendGraph.Series.Add(series10);
            this.trendGraph.Series.Add(series11);
            this.trendGraph.Series.Add(series12);
            this.trendGraph.Series.Add(series13);
            this.trendGraph.Series.Add(series14);
            this.trendGraph.Series.Add(series15);
            this.trendGraph.Series.Add(series16);
            this.trendGraph.Series.Add(series17);
            this.trendGraph.Series.Add(series18);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.elementTable);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
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
            resources.ApplyResources(this.elementTable, "elementTable");
            this.elementTable.Name = "elementTable";
            this.elementTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.elementTable_CellContentClick);
            // 
            // dgName
            // 
            this.dgName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.dgName, "dgName");
            this.dgName.Name = "dgName";
            this.dgName.ReadOnly = true;
            // 
            // dgValue
            // 
            this.dgValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dgValue, "dgValue");
            this.dgValue.Name = "dgValue";
            this.dgValue.ReadOnly = true;
            // 
            // dgUnit
            // 
            this.dgUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dgUnit, "dgUnit");
            this.dgUnit.Name = "dgUnit";
            this.dgUnit.ReadOnly = true;
            // 
            // dgGraph
            // 
            this.dgGraph.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.dgGraph, "dgGraph");
            this.dgGraph.Name = "dgGraph";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
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
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel15, "tableLayoutPanel15");
            this.tableLayoutPanel15.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel15.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label54, 0, 1);
            this.tableLayoutPanel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Name = "label19";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox3);
            this.panel5.Controls.Add(this.label20);
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.Name = "panel5";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Name = "label20";
            // 
            // label54
            // 
            resources.ApplyResources(this.label54, "label54");
            this.label54.BackColor = System.Drawing.SystemColors.Control;
            this.label54.Name = "label54";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel6, "tableLayoutPanel6");
            this.tableLayoutPanel6.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Name = "label17";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.label18);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Name = "label18";
            // 
            // label53
            // 
            resources.ApplyResources(this.label53, "label53");
            this.label53.BackColor = System.Drawing.SystemColors.Control;
            this.label53.Name = "label53";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel5, "tableLayoutPanel5");
            this.tableLayoutPanel5.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 1);
            this.tableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Name = "label15";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.label16);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Name = "label16";
            // 
            // label44
            // 
            resources.ApplyResources(this.label44, "label44");
            this.label44.BackColor = System.Drawing.SystemColors.Control;
            this.label44.Name = "label44";
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.SetColumnSpan(this.panel13, 2);
            this.panel13.ContextMenuStrip = this.tilePopUpMenu;
            resources.ApplyResources(this.panel13, "panel13");
            this.panel13.Name = "panel13";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel4, "tableLayoutPanel4");
            this.tableLayoutPanel4.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            // 
            // label31
            // 
            resources.ApplyResources(this.label31, "label31");
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Name = "label31";
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.checkBox10);
            this.panel14.Controls.Add(this.label33);
            resources.ApplyResources(this.panel14, "panel14");
            this.panel14.Name = "panel14";
            // 
            // label33
            // 
            resources.ApplyResources(this.label33, "label33");
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Name = "label33";
            // 
            // label40
            // 
            resources.ApplyResources(this.label40, "label40");
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Name = "label40";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel7, "tableLayoutPanel7");
            this.tableLayoutPanel7.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel7.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.checkBox13);
            this.panel17.Controls.Add(this.label41);
            resources.ApplyResources(this.panel17, "panel17");
            this.panel17.Name = "panel17";
            // 
            // label41
            // 
            resources.ApplyResources(this.label41, "label41");
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Name = "label41";
            // 
            // label42
            // 
            resources.ApplyResources(this.label42, "label42");
            this.label42.BackColor = System.Drawing.Color.Transparent;
            this.label42.Name = "label42";
            // 
            // label49
            // 
            resources.ApplyResources(this.label49, "label49");
            this.label49.BackColor = System.Drawing.SystemColors.Control;
            this.label49.Name = "label49";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel8, "tableLayoutPanel8");
            this.tableLayoutPanel8.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel8.Controls.Add(this.label43, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label46, 0, 1);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            // 
            // label43
            // 
            resources.ApplyResources(this.label43, "label43");
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Name = "label43";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.checkBox14);
            this.panel18.Controls.Add(this.label45);
            resources.ApplyResources(this.panel18, "panel18");
            this.panel18.Name = "panel18";
            // 
            // label45
            // 
            resources.ApplyResources(this.label45, "label45");
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Name = "label45";
            // 
            // label46
            // 
            resources.ApplyResources(this.label46, "label46");
            this.label46.BackColor = System.Drawing.SystemColors.Control;
            this.label46.Name = "label46";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel9, "tableLayoutPanel9");
            this.tableLayoutPanel9.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel9.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.label32, 0, 1);
            this.tableLayoutPanel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.checkBox15);
            this.panel19.Controls.Add(this.label47);
            resources.ApplyResources(this.panel19, "panel19");
            this.panel19.Name = "panel19";
            // 
            // label47
            // 
            resources.ApplyResources(this.label47, "label47");
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Name = "label47";
            // 
            // label48
            // 
            resources.ApplyResources(this.label48, "label48");
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Name = "label48";
            // 
            // label32
            // 
            resources.ApplyResources(this.label32, "label32");
            this.label32.BackColor = System.Drawing.SystemColors.Control;
            this.label32.Name = "label32";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel10, "tableLayoutPanel10");
            this.tableLayoutPanel10.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel10.Controls.Add(this.panel20, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label51, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label61, 0, 1);
            this.tableLayoutPanel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.checkBox16);
            this.panel20.Controls.Add(this.label50);
            resources.ApplyResources(this.panel20, "panel20");
            this.panel20.Name = "panel20";
            // 
            // label50
            // 
            resources.ApplyResources(this.label50, "label50");
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.ForeColor = System.Drawing.Color.Black;
            this.label50.Name = "label50";
            // 
            // label51
            // 
            resources.ApplyResources(this.label51, "label51");
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Name = "label51";
            // 
            // label61
            // 
            resources.ApplyResources(this.label61, "label61");
            this.label61.BackColor = System.Drawing.SystemColors.Control;
            this.label61.Name = "label61";
            // 
            // chart1
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel3.SetColumnSpan(this.chart1, 2);
            resources.ApplyResources(this.chart1, "chart1");
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.tableLayoutPanel3.SetRowSpan(this.chart1, 4);
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Legend = "Legend1";
            series19.Name = "O2";
            series19.Points.Add(dataPoint26);
            series19.Points.Add(dataPoint27);
            series19.Points.Add(dataPoint28);
            series19.Points.Add(dataPoint29);
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Legend = "Legend1";
            series20.Name = "CO";
            series20.Points.Add(dataPoint30);
            series20.Points.Add(dataPoint31);
            series20.Points.Add(dataPoint32);
            series20.Points.Add(dataPoint33);
            series20.Points.Add(dataPoint34);
            series20.Points.Add(dataPoint35);
            series20.Points.Add(dataPoint36);
            series20.Points.Add(dataPoint37);
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series21.Legend = "Legend1";
            series21.Name = "CO2";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Legend = "Legend1";
            series22.Name = "NO";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series23.Legend = "Legend1";
            series23.Name = "NO2";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series24.Legend = "Legend1";
            series24.Name = "NOx";
            series24.YValueMembers = "Tag";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series25.Legend = "Legend1";
            series25.Name = "SO2";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series26.Legend = "Legend1";
            series26.Name = "CxHy";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series27.Legend = "Legend1";
            series27.Name = "T(gas)";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series28.Legend = "Legend1";
            series28.Name = "T(amb)";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series29.Legend = "Legend1";
            series29.Name = "Temp1";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series30.Legend = "Legend1";
            series30.Name = "Temp2";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series31.Legend = "Legend1";
            series31.Name = "T(cell)";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series32.Legend = "Legend1";
            series32.Name = "Efficiency";
            series33.ChartArea = "ChartArea1";
            series33.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series33.Legend = "Legend1";
            series33.Name = "Flow";
            series34.ChartArea = "ChartArea1";
            series34.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series34.Legend = "Legend1";
            series34.Name = "NH3";
            this.chart1.Series.Add(series19);
            this.chart1.Series.Add(series20);
            this.chart1.Series.Add(series21);
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Series.Add(series25);
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
            this.chart1.Series.Add(series31);
            this.chart1.Series.Add(series32);
            this.chart1.Series.Add(series33);
            this.chart1.Series.Add(series34);
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.tableLayoutPanel13, "tableLayoutPanel13");
            this.tableLayoutPanel13.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel13.Controls.Add(this.label59, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label52, 0, 1);
            this.tableLayoutPanel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            // 
            // label59
            // 
            resources.ApplyResources(this.label59, "label59");
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Name = "label59";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.checkBox19);
            this.panel23.Controls.Add(this.label60);
            resources.ApplyResources(this.panel23, "panel23");
            this.panel23.Name = "panel23";
            // 
            // label60
            // 
            resources.ApplyResources(this.label60, "label60");
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Name = "label60";
            // 
            // label52
            // 
            resources.ApplyResources(this.label52, "label52");
            this.label52.BackColor = System.Drawing.SystemColors.Control;
            this.label52.Name = "label52";
            // 
            // tabPage4
            // 
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.shapeContainer2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            resources.ApplyResources(this.button16, "button16");
            this.button16.Name = "button16";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            resources.ApplyResources(this.button15, "button15");
            this.button15.Name = "button15";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // shapeContainer2
            // 
            resources.ApplyResources(this.shapeContainer2, "shapeContainer2");
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            resources.ApplyResources(this.lineShape2, "lineShape2");
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.recordingSign);
            this.panel12.Controls.Add(this.snapShot);
            this.panel12.Controls.Add(this.stopRecordingItem);
            this.panel12.Controls.Add(this.pauseRecordingItem);
            this.panel12.Controls.Add(this.startRecordingItem);
            resources.ApplyResources(this.panel12, "panel12");
            this.panel12.Name = "panel12";
            // 
            // recordingSign
            // 
            resources.ApplyResources(this.recordingSign, "recordingSign");
            this.recordingSign.Name = "recordingSign";
            this.recordingSign.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.Interval = 1000;
            this.dataGridTimer.Tick += new System.EventHandler(this.dataGridTimer_Tick);
            // 
            // recordSign
            // 
            this.recordSign.Interval = 500;
            this.recordSign.Tick += new System.EventHandler(this.recordSign_Tick);
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).EndInit();
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
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.recordingSign)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar recordingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel recordStatusLabel;
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
        private ToolStripStatusLabel phaseTimeLabel;
        private ToolStripStatusLabel phaseLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Panel panel12;
        private Button snapShot;
        private Button stopRecordingItem;
        private Button pauseRecordingItem;
        private Button startRecordingItem;
        private TableLayoutPanel tableLayoutPanel2;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel13;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label31;
        private Panel panel14;
        private CheckBox checkBox10;
        public Label label33;
        private TableLayoutPanel tableLayoutPanel7;
        private Panel panel17;
        private CheckBox checkBox13;
        public Label label41;
        private Label label42;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label43;
        private Panel panel18;
        private CheckBox checkBox14;
        public Label label45;
        private TableLayoutPanel tableLayoutPanel9;
        private Panel panel19;
        private CheckBox checkBox15;
        public Label label47;
        private Label label48;
        private TableLayoutPanel tableLayoutPanel10;
        private Panel panel20;
        private CheckBox checkBox16;
        public Label label50;
        private Label label51;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label59;
        private Panel panel23;
        private CheckBox checkBox19;
        public Label label60;
        private TableLayoutPanel tableLayoutPanel14;
        public System.Windows.Forms.DataVisualization.Charting.Chart trendGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sTile9;
        private TableLayoutPanel sTile8;
        private TableLayoutPanel sTile7;
        private TableLayoutPanel sTile6;
        private TableLayoutPanel sTile1;
        private TableLayoutPanel sTile0;
        private TableLayoutPanel sTile4;
        private TableLayoutPanel sTile3;
        private TableLayoutPanel sTile5;
        private TableLayoutPanel hTile1;
        private TableLayoutPanel hTile0;
        private Label tileLabel11;
        private Label tileLabel12;
        private Label label11;
        private Label label11_;
        private Label label12_;
        private Label label12;
        private Label label61;
        public ToolStripStatusLabel recordTimeLabel;
        private Label label2;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label6;
        private TabPage tabPage4;
        private Label tileLabel1;
        private Label tileLabel10;
        private Label tileLabel9;
        private Label tileLabel8;
        private Label tileLabel7;
        private Label tileLabel2;
        private Label tileLabel5;
        private Label tileLabel4;
        private Label tileLabel6;
        private Panel panel1;
        private Button button2;
        public DataGridView elementTable;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgValue;
        private DataGridViewTextBoxColumn dgUnit;
        private DataGridViewCheckBoxColumn dgGraph;
        private Button tileButton10;
        private Button tileButton9;
        private Button tileButton8;
        private Button tileButton7;
        private Button tileButton2;
        private Button tileButton5;
        private Button tileButton4;
        private Button tileButton6;
        private Button tileButton1;
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
        private Label label40;
        private Label label49;
        private Label label46;
        private Label label32;
        private Label label52;
        private TableLayoutPanel tableLayoutPanel11;
        private Button button13;
        private Label cycleLabel;
        private Label rTimelbl;
        private Label tTimelbl;
        private Label pTimelbl;
        private Label plbl;
        private Label tlbl;
        private Label rlbl;
        private ProgressBar progressBar1;
        private Button tileButton12;
        public Label rLabel2;
        private Button tileButton11;
        private Label rLabel1;
        private PictureBox recordingSign;
        private Button button15;
        private Button button16;
        private System.Windows.Forms.Timer recordSign;
        private ToolStripMenuItem instrumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem blueWhiteColorToolStripMenuItem;
        private ToolStripMenuItem blackBlueColorToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        internal System.Windows.Forms.Timer dataGridTimer;
        private Label label1;
        private TableLayoutPanel sTile2;
        private Label label3;
        private Label tileLabel3;
        private Button tileButton3;


    }
}

