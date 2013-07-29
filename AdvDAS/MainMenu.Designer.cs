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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint26 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint27 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint28 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint29 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint30 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint31 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint32 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint33 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint34 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint35 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint36 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint37 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupEquipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipmentSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.resetAllAveragesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.hidePanelMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.checkBox17 = new System.Windows.Forms.CheckBox();
            this.checkBox18 = new System.Windows.Forms.CheckBox();
            this.checkBox19 = new System.Windows.Forms.CheckBox();
            this.snapShot = new System.Windows.Forms.Button();
            this.stopRecordingItem = new System.Windows.Forms.Button();
            this.pauseRecordingItem = new System.Windows.Forms.Button();
            this.startRecordingItem = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.label69 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.label67 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.label65 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.label63 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.label35 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.signalStrength1 = new WindowWidgets.SignalStrength();
            this.bTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tilePopUpMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bTile1.SuspendLayout();
            this.sTile2.SuspendLayout();
            this.sTile9.SuspendLayout();
            this.sTile8.SuspendLayout();
            this.sTile7.SuspendLayout();
            this.sTile6.SuspendLayout();
            this.sTile1.SuspendLayout();
            this.sTile4.SuspendLayout();
            this.sTile3.SuspendLayout();
            this.sTile5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.bTile2.SuspendLayout();
            this.sTile0.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
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
            this.tableLayoutPanel11.SuspendLayout();
            this.panel21.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.panel22.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel12.SuspendLayout();
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
            this.resetAllAveragesToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseReportsToolStripMenuItem,
            this.advancedFunctionsToolStripMenuItem,
            this.saveReportToolStripMenuItem,
            this.themeToolStripMenuItem});
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
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.backGroundColorToolStripMenuItem,
            this.resetColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            this.textColorToolStripMenuItem.Click += new System.EventHandler(this.textColorToolStripMenuItem_Click);
            // 
            // backGroundColorToolStripMenuItem
            // 
            this.backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
            this.backGroundColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.backGroundColorToolStripMenuItem.Text = "BackGround Color";
            this.backGroundColorToolStripMenuItem.Click += new System.EventHandler(this.backGroundColorToolStripMenuItem_Click);
            // 
            // resetColorToolStripMenuItem
            // 
            this.resetColorToolStripMenuItem.Name = "resetColorToolStripMenuItem";
            this.resetColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetColorToolStripMenuItem.Text = "Reset Color";
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
            this.phaseLabel,
            this.phaseTimeLabel,
            this.recordingProgressBar,
            this.clock_lbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 560);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(920, 24);
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
            this.recordStatusLabel.Size = new System.Drawing.Size(91, 19);
            this.recordStatusLabel.Text = "Pre-Calibration";
            // 
            // recordTimeLabel
            // 
            this.recordTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.recordTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.recordTimeLabel.Name = "recordTimeLabel";
            this.recordTimeLabel.Size = new System.Drawing.Size(37, 19);
            this.recordTimeLabel.Text = "TSET";
            this.recordTimeLabel.ToolTipText = "Total Test Time";
            // 
            // phaseLabel
            // 
            this.phaseLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.phaseLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.phaseLabel.Name = "phaseLabel";
            this.phaseLabel.Size = new System.Drawing.Size(42, 19);
            this.phaseLabel.Text = "Phase";
            // 
            // phaseTimeLabel
            // 
            this.phaseTimeLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.phaseTimeLabel.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.phaseTimeLabel.Name = "phaseTimeLabel";
            this.phaseTimeLabel.Size = new System.Drawing.Size(53, 19);
            this.phaseTimeLabel.Text = "00:00:00";
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
            this.hidePanelMenuItem});
            this.tilePopUpMenu.Name = "panelPopUpMenu";
            this.tilePopUpMenu.Size = new System.Drawing.Size(166, 48);
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
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox10.Location = new System.Drawing.Point(145, 0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 47);
            this.checkBox10.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBox10, "Click to disable in report");
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox13.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox13.Location = new System.Drawing.Point(145, 0);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 53);
            this.checkBox13.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkBox13, "Click to disable in report");
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox14.Location = new System.Drawing.Point(145, 0);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 53);
            this.checkBox14.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox14, "Click to disable in report");
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox15.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox15.Location = new System.Drawing.Point(145, 0);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(15, 52);
            this.checkBox15.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkBox15, "Click to disable in report");
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox16.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox16.Location = new System.Drawing.Point(145, 0);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 31);
            this.checkBox16.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox16, "Click to disable in report");
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox17
            // 
            this.checkBox17.AutoSize = true;
            this.checkBox17.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox17.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox17.Location = new System.Drawing.Point(145, 0);
            this.checkBox17.Name = "checkBox17";
            this.checkBox17.Size = new System.Drawing.Size(15, 52);
            this.checkBox17.TabIndex = 7;
            this.toolTip1.SetToolTip(this.checkBox17, "Click to disable in report");
            this.checkBox17.UseVisualStyleBackColor = true;
            // 
            // checkBox18
            // 
            this.checkBox18.AutoSize = true;
            this.checkBox18.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox18.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox18.Location = new System.Drawing.Point(145, 0);
            this.checkBox18.Name = "checkBox18";
            this.checkBox18.Size = new System.Drawing.Size(15, 52);
            this.checkBox18.TabIndex = 8;
            this.toolTip1.SetToolTip(this.checkBox18, "Click to disable in report");
            this.checkBox18.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox19.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox19.Location = new System.Drawing.Point(145, 0);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(15, 53);
            this.checkBox19.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox19, "Click to disable in report");
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // snapShot
            // 
            this.snapShot.BackColor = System.Drawing.Color.Transparent;
            this.snapShot.BackgroundImage = global::CRS.Properties.Resources.Ahmadhania_Spherical_Camera;
            this.snapShot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.snapShot.Location = new System.Drawing.Point(167, 3);
            this.snapShot.Name = "snapShot";
            this.snapShot.Size = new System.Drawing.Size(49, 38);
            this.snapShot.TabIndex = 7;
            this.snapShot.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.snapShot.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.snapShot, "Take Snap Shot");
            this.snapShot.UseVisualStyleBackColor = false;
            // 
            // stopRecordingItem
            // 
            this.stopRecordingItem.BackgroundImage = global::CRS.Properties.Resources.stop;
            this.stopRecordingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stopRecordingItem.Enabled = false;
            this.stopRecordingItem.Location = new System.Drawing.Point(113, 3);
            this.stopRecordingItem.Name = "stopRecordingItem";
            this.stopRecordingItem.Size = new System.Drawing.Size(49, 38);
            this.stopRecordingItem.TabIndex = 6;
            this.stopRecordingItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stopRecordingItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.stopRecordingItem, "Stop Recording");
            this.stopRecordingItem.UseVisualStyleBackColor = true;
            this.stopRecordingItem.Click += new System.EventHandler(this.stopRecordingItem_Click);
            // 
            // pauseRecordingItem
            // 
            this.pauseRecordingItem.BackgroundImage = global::CRS.Properties.Resources.Deleket_Soft_Scraps_Button_Pause;
            this.pauseRecordingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pauseRecordingItem.Enabled = false;
            this.pauseRecordingItem.Location = new System.Drawing.Point(58, 3);
            this.pauseRecordingItem.Name = "pauseRecordingItem";
            this.pauseRecordingItem.Size = new System.Drawing.Size(49, 38);
            this.pauseRecordingItem.TabIndex = 5;
            this.pauseRecordingItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pauseRecordingItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.pauseRecordingItem, "Pause Recording");
            this.pauseRecordingItem.UseVisualStyleBackColor = true;
            this.pauseRecordingItem.Click += new System.EventHandler(this.pauseRecordingItem_Click);
            // 
            // startRecordingItem
            // 
            this.startRecordingItem.BackgroundImage = global::CRS.Properties.Resources.play;
            this.startRecordingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startRecordingItem.Location = new System.Drawing.Point(3, 3);
            this.startRecordingItem.Name = "startRecordingItem";
            this.startRecordingItem.Size = new System.Drawing.Size(49, 38);
            this.startRecordingItem.TabIndex = 4;
            this.startRecordingItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.startRecordingItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.startRecordingItem, "Start Recording");
            this.startRecordingItem.UseVisualStyleBackColor = true;
            this.startRecordingItem.Click += new System.EventHandler(this.startRecordingItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 50);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 483);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(906, 457);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main";
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
            this.tableLayoutPanel1.Controls.Add(this.bTile1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile9, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile8, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile7, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile6, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.sTile1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bTile2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.74101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.17073F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08826F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // bTile1
            // 
            this.bTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bTile1.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.bTile1, 2);
            this.bTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.bTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.bTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.bTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.bTile1.Controls.Add(this.tileLabel11, 1, 0);
            this.bTile1.Controls.Add(this.label36, 0, 1);
            this.bTile1.Controls.Add(this.label37, 3, 1);
            this.bTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTile1.Location = new System.Drawing.Point(3, 335);
            this.bTile1.Name = "bTile1";
            this.bTile1.RowCount = 2;
            this.bTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bTile1.Size = new System.Drawing.Size(354, 113);
            this.bTile1.TabIndex = 24;
            // 
            // tileLabel11
            // 
            this.tileLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLabel11.AutoSize = true;
            this.bTile1.SetColumnSpan(this.tileLabel11, 2);
            this.tileLabel11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel11.Location = new System.Drawing.Point(102, 0);
            this.tileLabel11.Name = "tileLabel11";
            this.tileLabel11.Size = new System.Drawing.Size(148, 31);
            this.tileLabel11.TabIndex = 0;
            this.tileLabel11.Text = "COx(mass)";
            this.tileLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.BackColor = System.Drawing.SystemColors.Control;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(1, 32);
            this.label36.Margin = new System.Windows.Forms.Padding(1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(97, 80);
            this.label36.TabIndex = 4;
            this.label36.Text = "TEst";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.BackColor = System.Drawing.SystemColors.Control;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(254, 32);
            this.label37.Margin = new System.Windows.Forms.Padding(1);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(99, 80);
            this.label37.TabIndex = 5;
            this.label37.Text = "TEst";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile2
            // 
            this.sTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile2.ColumnCount = 1;
            this.sTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile2.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile2.Controls.Add(this.button5, 0, 4);
            this.sTile2.Controls.Add(this.label6, 0, 3);
            this.sTile2.Controls.Add(this.label23, 0, 2);
            this.sTile2.Controls.Add(this.label5, 0, 1);
            this.sTile2.Controls.Add(this.tileLabel3, 0, 0);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile2.Location = new System.Drawing.Point(370, 10);
            this.sTile2.Margin = new System.Windows.Forms.Padding(10);
            this.sTile2.Name = "sTile2";
            this.sTile2.RowCount = 5;
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.88801F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.32F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.792F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.Size = new System.Drawing.Size(160, 145);
            this.sTile2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(3, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 23);
            this.button5.TabIndex = 14;
            this.button5.Text = "AVERAGE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 31);
            this.label6.TabIndex = 12;
            this.label6.Text = "0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 63);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 22);
            this.label23.TabIndex = 10;
            this.label23.Text = "CURRENT";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "0.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel3
            // 
            this.tileLabel3.AutoSize = true;
            this.tileLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel3.Location = new System.Drawing.Point(3, 0);
            this.tileLabel3.Name = "tileLabel3";
            this.tileLabel3.Size = new System.Drawing.Size(154, 31);
            this.tileLabel3.TabIndex = 13;
            this.tileLabel3.Text = "CO2";
            this.tileLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile9.ColumnCount = 1;
            this.sTile9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile9.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile9.Controls.Add(this.button12, 0, 4);
            this.sTile9.Controls.Add(this.label69, 0, 3);
            this.sTile9.Controls.Add(this.label30, 0, 2);
            this.sTile9.Controls.Add(this.label68, 0, 1);
            this.sTile9.Controls.Add(this.tileLabel10, 0, 0);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile9.Location = new System.Drawing.Point(730, 175);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 5;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.64194F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.28706F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.9381F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.13289F));
            this.sTile9.Size = new System.Drawing.Size(160, 147);
            this.sTile9.TabIndex = 19;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(3, 123);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(154, 21);
            this.button12.TabIndex = 21;
            this.button12.Text = "AVERAGE";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.SystemColors.Control;
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(3, 87);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(154, 33);
            this.label69.TabIndex = 19;
            this.label69.Text = "0.0";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 63);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(154, 24);
            this.label30.TabIndex = 17;
            this.label30.Text = "CURRENT";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.SystemColors.Control;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(3, 31);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(154, 32);
            this.label68.TabIndex = 18;
            this.label68.Text = "0.0";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel10
            // 
            this.tileLabel10.AutoSize = true;
            this.tileLabel10.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel10.Location = new System.Drawing.Point(3, 0);
            this.tileLabel10.Name = "tileLabel10";
            this.tileLabel10.Size = new System.Drawing.Size(154, 31);
            this.tileLabel10.TabIndex = 20;
            this.tileLabel10.Text = "T(amb)";
            this.tileLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile8.ColumnCount = 1;
            this.sTile8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile8.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile8.Controls.Add(this.button11, 0, 4);
            this.sTile8.Controls.Add(this.label67, 0, 3);
            this.sTile8.Controls.Add(this.label29, 0, 2);
            this.sTile8.Controls.Add(this.label66, 0, 1);
            this.sTile8.Controls.Add(this.tileLabel9, 0, 0);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile8.Location = new System.Drawing.Point(550, 175);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 5;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.53593F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39187F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.0722F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.Size = new System.Drawing.Size(160, 147);
            this.sTile8.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(3, 119);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(154, 25);
            this.button11.TabIndex = 20;
            this.button11.Text = "AVERAGE";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.SystemColors.Control;
            this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(3, 84);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(154, 32);
            this.label67.TabIndex = 18;
            this.label67.Text = "0.0";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 61);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 23);
            this.label29.TabIndex = 16;
            this.label29.Text = "CURRENT";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.SystemColors.Control;
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(3, 31);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(154, 30);
            this.label66.TabIndex = 17;
            this.label66.Text = "0.0";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel9
            // 
            this.tileLabel9.AutoSize = true;
            this.tileLabel9.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel9.Location = new System.Drawing.Point(3, 0);
            this.tileLabel9.Name = "tileLabel9";
            this.tileLabel9.Size = new System.Drawing.Size(154, 31);
            this.tileLabel9.TabIndex = 19;
            this.tileLabel9.Text = "T(gas)";
            this.tileLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile7
            // 
            this.sTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile7.ColumnCount = 1;
            this.sTile7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile7.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile7.Controls.Add(this.button10, 0, 4);
            this.sTile7.Controls.Add(this.label65, 0, 3);
            this.sTile7.Controls.Add(this.label28, 0, 2);
            this.sTile7.Controls.Add(this.label64, 0, 1);
            this.sTile7.Controls.Add(this.tileLabel8, 0, 0);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile7.Location = new System.Drawing.Point(370, 175);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 5;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50034F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33707F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16259F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.Size = new System.Drawing.Size(160, 147);
            this.sTile7.TabIndex = 17;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(3, 121);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 23);
            this.button10.TabIndex = 19;
            this.button10.Text = "AVERAGE";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.SystemColors.Control;
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(3, 86);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(154, 32);
            this.label65.TabIndex = 17;
            this.label65.Text = "0.0";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 62);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(154, 24);
            this.label28.TabIndex = 15;
            this.label28.Text = "CURRENT";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.BackColor = System.Drawing.SystemColors.Control;
            this.label64.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(3, 31);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(154, 31);
            this.label64.TabIndex = 16;
            this.label64.Text = "0.0";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel8
            // 
            this.tileLabel8.AutoSize = true;
            this.tileLabel8.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel8.Location = new System.Drawing.Point(3, 0);
            this.tileLabel8.Name = "tileLabel8";
            this.tileLabel8.Size = new System.Drawing.Size(154, 31);
            this.tileLabel8.TabIndex = 18;
            this.tileLabel8.Text = "CxHy";
            this.tileLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile6
            // 
            this.sTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile6.ColumnCount = 1;
            this.sTile6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile6.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile6.Controls.Add(this.button9, 0, 4);
            this.sTile6.Controls.Add(this.label63, 0, 3);
            this.sTile6.Controls.Add(this.label27, 0, 2);
            this.sTile6.Controls.Add(this.label62, 0, 1);
            this.sTile6.Controls.Add(this.tileLabel7, 0, 0);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile6.Location = new System.Drawing.Point(190, 175);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 5;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50034F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33707F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16259F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.Size = new System.Drawing.Size(160, 147);
            this.sTile6.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(3, 121);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "AVERAGE";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.SystemColors.Control;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(3, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(154, 32);
            this.label63.TabIndex = 16;
            this.label63.Text = "0.0";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 62);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 24);
            this.label27.TabIndex = 14;
            this.label27.Text = "CURRENT";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.Control;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(3, 31);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(154, 31);
            this.label62.TabIndex = 15;
            this.label62.Text = "0.0";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel7
            // 
            this.tileLabel7.AutoSize = true;
            this.tileLabel7.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel7.Location = new System.Drawing.Point(3, 0);
            this.tileLabel7.Name = "tileLabel7";
            this.tileLabel7.Size = new System.Drawing.Size(154, 31);
            this.tileLabel7.TabIndex = 17;
            this.tileLabel7.Text = "SO2";
            this.tileLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile1
            // 
            this.sTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile1.ColumnCount = 1;
            this.sTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile1.Controls.Add(this.button4, 0, 4);
            this.sTile1.Controls.Add(this.label4, 0, 3);
            this.sTile1.Controls.Add(this.label3, 0, 1);
            this.sTile1.Controls.Add(this.label22, 0, 2);
            this.sTile1.Controls.Add(this.tileLabel2, 0, 0);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile1.Location = new System.Drawing.Point(190, 10);
            this.sTile1.Margin = new System.Windows.Forms.Padding(10);
            this.sTile1.Name = "sTile1";
            this.sTile1.RowCount = 5;
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.49897F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33234F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16868F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.Size = new System.Drawing.Size(160, 145);
            this.sTile1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(3, 118);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 24);
            this.button4.TabIndex = 13;
            this.button4.Text = "AVERAGE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "0.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 61);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 23);
            this.label22.TabIndex = 9;
            this.label22.Text = "CURRENT";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel2
            // 
            this.tileLabel2.AutoSize = true;
            this.tileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel2.Location = new System.Drawing.Point(3, 0);
            this.tileLabel2.Name = "tileLabel2";
            this.tileLabel2.Size = new System.Drawing.Size(154, 31);
            this.tileLabel2.TabIndex = 12;
            this.tileLabel2.Text = "CO";
            this.tileLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile4.ColumnCount = 1;
            this.sTile4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile4.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile4.Controls.Add(this.button7, 0, 4);
            this.sTile4.Controls.Add(this.label10, 0, 3);
            this.sTile4.Controls.Add(this.label25, 0, 2);
            this.sTile4.Controls.Add(this.label9, 0, 1);
            this.sTile4.Controls.Add(this.tileLabel5, 0, 0);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile4.Location = new System.Drawing.Point(730, 10);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 5;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50034F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33707F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16259F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.Size = new System.Drawing.Size(160, 145);
            this.sTile4.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(3, 118);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 24);
            this.button7.TabIndex = 16;
            this.button7.Text = "AVERAGE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "0.0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 61);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 23);
            this.label25.TabIndex = 12;
            this.label25.Text = "CURRENT";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 30);
            this.label9.TabIndex = 13;
            this.label9.Text = "0.0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel5
            // 
            this.tileLabel5.AutoSize = true;
            this.tileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel5.Location = new System.Drawing.Point(3, 0);
            this.tileLabel5.Name = "tileLabel5";
            this.tileLabel5.Size = new System.Drawing.Size(154, 31);
            this.tileLabel5.TabIndex = 15;
            this.tileLabel5.Text = "NO2";
            this.tileLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile3
            // 
            this.sTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile3.ColumnCount = 1;
            this.sTile3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile3.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile3.Controls.Add(this.button6, 0, 4);
            this.sTile3.Controls.Add(this.label8, 0, 3);
            this.sTile3.Controls.Add(this.label24, 0, 2);
            this.sTile3.Controls.Add(this.label7, 0, 1);
            this.sTile3.Controls.Add(this.tileLabel4, 0, 0);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile3.Location = new System.Drawing.Point(550, 10);
            this.sTile3.Margin = new System.Windows.Forms.Padding(10);
            this.sTile3.Name = "sTile3";
            this.sTile3.RowCount = 5;
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50034F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33707F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16259F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.Size = new System.Drawing.Size(160, 145);
            this.sTile3.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(3, 118);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 24);
            this.button6.TabIndex = 15;
            this.button6.Text = "AVERAGE";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "0.0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 23);
            this.label24.TabIndex = 11;
            this.label24.Text = "CURRENT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "0.0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel4
            // 
            this.tileLabel4.AutoSize = true;
            this.tileLabel4.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel4.Location = new System.Drawing.Point(3, 0);
            this.tileLabel4.Name = "tileLabel4";
            this.tileLabel4.Size = new System.Drawing.Size(154, 31);
            this.tileLabel4.TabIndex = 14;
            this.tileLabel4.Text = "NO";
            this.tileLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile5
            // 
            this.sTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile5.ColumnCount = 1;
            this.sTile5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile5.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile5.Controls.Add(this.button8, 0, 4);
            this.sTile5.Controls.Add(this.label35, 0, 3);
            this.sTile5.Controls.Add(this.label26, 0, 2);
            this.sTile5.Controls.Add(this.label34, 0, 1);
            this.sTile5.Controls.Add(this.tileLabel6, 0, 0);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile5.Location = new System.Drawing.Point(10, 175);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 5;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.50034F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33707F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16259F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.Size = new System.Drawing.Size(160, 147);
            this.sTile5.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(3, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "AVERAGE";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.Control;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 86);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 32);
            this.label35.TabIndex = 15;
            this.label35.Text = "0.0";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 24);
            this.label26.TabIndex = 13;
            this.label26.Text = "CURRENT";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Control;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(3, 31);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(154, 31);
            this.label34.TabIndex = 14;
            this.label34.Text = "0.0";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel6
            // 
            this.tileLabel6.AutoSize = true;
            this.tileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel6.Location = new System.Drawing.Point(3, 0);
            this.tileLabel6.Name = "tileLabel6";
            this.tileLabel6.Size = new System.Drawing.Size(154, 31);
            this.tileLabel6.TabIndex = 16;
            this.tileLabel6.Text = "NOx";
            this.tileLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.signalStrength1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(363, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 113);
            this.panel4.TabIndex = 20;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Purge: 00:00:00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Test: 00:00:00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Ramp Up: 00:00:00";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Phase";
            // 
            // signalStrength1
            // 
            this.signalStrength1.BackgroundStyle = WindowWidgets.SignalStrengthBackgroundStyle.Normal;
            this.signalStrength1.BarLayout = WindowWidgets.SignalStrengthLayout.LeftToRight;
            this.signalStrength1.BarSpacing = 2;
            this.signalStrength1.BarStepSize = 20;
            this.signalStrength1.CenterGradientColor = System.Drawing.Color.WhiteSmoke;
            this.signalStrength1.EmptyBarColor = System.Drawing.Color.Gray;
            this.signalStrength1.GoodSignalColor = System.Drawing.Color.Green;
            this.signalStrength1.GoodSignalThreshold = 0.8F;
            this.signalStrength1.Location = new System.Drawing.Point(102, 65);
            this.signalStrength1.MaximumValue = 1F;
            this.signalStrength1.MinimumValue = 0F;
            this.signalStrength1.Name = "signalStrength1";
            this.signalStrength1.NoSignalColor = System.Drawing.Color.White;
            this.signalStrength1.NoSignalThreshold = 0F;
            this.signalStrength1.NumberOfBars = 5;
            this.signalStrength1.PoorSignalColor = System.Drawing.Color.Yellow;
            this.signalStrength1.PoorSignalThreshold = 0.5F;
            this.signalStrength1.Size = new System.Drawing.Size(69, 45);
            this.signalStrength1.SmallBarHeight = 10;
            this.signalStrength1.UseSolidBars = false;
            this.signalStrength1.Value = 0F;
            this.signalStrength1.WeakSignalColor = System.Drawing.Color.Red;
            this.signalStrength1.WeakSignalThreshold = 0.2F;
            this.signalStrength1.XColor = System.Drawing.Color.Red;
            this.signalStrength1.XIfNoSignal = true;
            this.signalStrength1.XWidth = 1.5F;
            // 
            // bTile2
            // 
            this.bTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bTile2.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.bTile2, 2);
            this.bTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.bTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.bTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.bTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.bTile2.Controls.Add(this.tileLabel12, 1, 0);
            this.bTile2.Controls.Add(this.label39, 0, 1);
            this.bTile2.Controls.Add(this.label38, 3, 1);
            this.bTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bTile2.Location = new System.Drawing.Point(543, 335);
            this.bTile2.Name = "bTile2";
            this.bTile2.RowCount = 2;
            this.bTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bTile2.Size = new System.Drawing.Size(354, 113);
            this.bTile2.TabIndex = 23;
            // 
            // tileLabel12
            // 
            this.tileLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLabel12.AutoSize = true;
            this.bTile2.SetColumnSpan(this.tileLabel12, 2);
            this.tileLabel12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel12.Location = new System.Drawing.Point(102, 0);
            this.tileLabel12.Name = "tileLabel12";
            this.tileLabel12.Size = new System.Drawing.Size(148, 31);
            this.tileLabel12.TabIndex = 0;
            this.tileLabel12.Text = "NOx(mass)";
            this.tileLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.BackColor = System.Drawing.SystemColors.Control;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(1, 32);
            this.label39.Margin = new System.Windows.Forms.Padding(1);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(97, 80);
            this.label39.TabIndex = 7;
            this.label39.Text = "TEst";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.BackColor = System.Drawing.SystemColors.Control;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(254, 32);
            this.label38.Margin = new System.Windows.Forms.Padding(1);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(99, 80);
            this.label38.TabIndex = 6;
            this.label38.Text = "TEst";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile0
            // 
            this.sTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile0.ColumnCount = 1;
            this.sTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile0.Controls.Add(this.label2, 0, 3);
            this.sTile0.Controls.Add(this.label21, 0, 2);
            this.sTile0.Controls.Add(this.label1, 0, 1);
            this.sTile0.Controls.Add(this.tileLabel1, 0, 0);
            this.sTile0.Controls.Add(this.button3, 0, 4);
            this.sTile0.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile0.Location = new System.Drawing.Point(10, 10);
            this.sTile0.Margin = new System.Windows.Forms.Padding(10);
            this.sTile0.Name = "sTile0";
            this.sTile0.RowCount = 5;
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.49986F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.33057F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.16957F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.Size = new System.Drawing.Size(160, 145);
            this.sTile0.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "0.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 23);
            this.label21.TabIndex = 8;
            this.label21.Text = "CURRENT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel1
            // 
            this.tileLabel1.AutoSize = true;
            this.tileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tileLabel1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel1.Location = new System.Drawing.Point(3, 0);
            this.tileLabel1.Name = "tileLabel1";
            this.tileLabel1.Size = new System.Drawing.Size(154, 31);
            this.tileLabel1.TabIndex = 11;
            this.tileLabel1.Text = "O2";
            this.tileLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(3, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "AVERAGE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tableLayoutPanel14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.trendGraph, 1, 0);
            this.tableLayoutPanel14.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel14.TabIndex = 2;
            // 
            // trendGraph
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.Name = "ChartArea1";
            this.trendGraph.ChartAreas.Add(chartArea1);
            this.trendGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.trendGraph.Legends.Add(legend1);
            this.trendGraph.Location = new System.Drawing.Point(282, 3);
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
            series11.Name = "Temp1";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series12.Legend = "Legend1";
            series12.Name = "Temp2";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series13.Legend = "Legend1";
            series13.Name = "T(cell)";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series14.Legend = "Legend1";
            series14.Name = "Efficiency";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series15.Legend = "Legend1";
            series15.Name = "Flow";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series16.Legend = "Legend1";
            series16.Name = "NH3";
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
            this.trendGraph.Size = new System.Drawing.Size(615, 443);
            this.trendGraph.TabIndex = 1;
            this.trendGraph.Text = "trendChart";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.elementTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 443);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.Location = new System.Drawing.Point(0, 420);
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
            this.elementTable.Location = new System.Drawing.Point(0, 0);
            this.elementTable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.elementTable.Name = "elementTable";
            this.elementTable.Size = new System.Drawing.Size(272, 345);
            this.elementTable.TabIndex = 6;
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
            this.dgValue.Width = 59;
            // 
            // dgUnit
            // 
            this.dgUnit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgUnit.HeaderText = "Unit";
            this.dgUnit.Name = "dgUnit";
            this.dgUnit.ReadOnly = true;
            this.dgUnit.Width = 51;
            // 
            // dgGraph
            // 
            this.dgGraph.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgGraph.HeaderText = "Graph";
            this.dgGraph.Name = "dgGraph";
            this.dgGraph.Width = 42;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(906, 457);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hybrid";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.panel13, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel9, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel11, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel12, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panel24, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.chart1, 3, 1);
            this.tableLayoutPanel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.74101F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.17073F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.08826F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.SetColumnSpan(this.panel13, 2);
            this.panel13.ContextMenuStrip = this.tilePopUpMenu;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(3, 335);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(354, 113);
            this.panel13.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel4.Controls.Add(this.label31, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.textBox21, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(370, 10);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.63387F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.75156F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.61457F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 104);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(154, 41);
            this.label31.TabIndex = 10;
            this.label31.Text = "CURRENT";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox21
            // 
            this.textBox21.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox21.Enabled = false;
            this.textBox21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox21.Location = new System.Drawing.Point(3, 50);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(154, 51);
            this.textBox21.TabIndex = 1;
            this.textBox21.TabStop = false;
            this.textBox21.Text = "TEST";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.checkBox10);
            this.panel14.Controls.Add(this.label33);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(160, 47);
            this.panel14.TabIndex = 7;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Dock = System.Windows.Forms.DockStyle.Left;
            this.label33.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label33.Location = new System.Drawing.Point(0, 0);
            this.label33.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(68, 31);
            this.label33.TabIndex = 0;
            this.label33.Text = "CO2";
            this.label33.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel7.Controls.Add(this.textBox27, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(370, 175);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79917F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(160, 147);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // textBox27
            // 
            this.textBox27.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox27.Enabled = false;
            this.textBox27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox27.Location = new System.Drawing.Point(3, 56);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(154, 47);
            this.textBox27.TabIndex = 1;
            this.textBox27.TabStop = false;
            this.textBox27.Text = "TEST";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.checkBox13);
            this.panel17.Controls.Add(this.label41);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(160, 53);
            this.panel17.TabIndex = 7;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.BackColor = System.Drawing.Color.Transparent;
            this.label41.Dock = System.Windows.Forms.DockStyle.Left;
            this.label41.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
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
            this.label42.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(3, 106);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(154, 41);
            this.label42.TabIndex = 15;
            this.label42.Text = "CURRENT";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel8.Controls.Add(this.textBox29, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.label43, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(190, 175);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79917F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(160, 147);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // textBox29
            // 
            this.textBox29.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox29.Enabled = false;
            this.textBox29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox29.Location = new System.Drawing.Point(3, 56);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(154, 47);
            this.textBox29.TabIndex = 1;
            this.textBox29.TabStop = false;
            this.textBox29.Text = "TEST";
            this.textBox29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(3, 106);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(154, 41);
            this.label43.TabIndex = 14;
            this.label43.Text = "CURRENT";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.checkBox14);
            this.panel18.Controls.Add(this.label45);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(160, 53);
            this.panel18.TabIndex = 7;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Dock = System.Windows.Forms.DockStyle.Left;
            this.label45.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label45.Location = new System.Drawing.Point(0, 0);
            this.label45.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(64, 31);
            this.label45.TabIndex = 0;
            this.label45.Text = "SO2";
            this.label45.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel9.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(190, 10);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 3;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10177F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10177F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79646F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.checkBox15);
            this.panel19.Controls.Add(this.label47);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(160, 52);
            this.panel19.TabIndex = 7;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Dock = System.Windows.Forms.DockStyle.Left;
            this.label47.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
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
            this.label48.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(3, 104);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(154, 41);
            this.label48.TabIndex = 9;
            this.label48.Text = "CURRENT";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel10.TabIndex = 14;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.checkBox16);
            this.panel20.Controls.Add(this.label50);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Margin = new System.Windows.Forms.Padding(0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(160, 31);
            this.panel20.TabIndex = 7;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.BackColor = System.Drawing.Color.Transparent;
            this.label50.Dock = System.Windows.Forms.DockStyle.Left;
            this.label50.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label50.ForeColor = System.Drawing.Color.Black;
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
            this.label51.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(48, 130);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(64, 15);
            this.label51.TabIndex = 8;
            this.label51.Text = "CURRENT";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.SystemColors.Control;
            this.label61.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label61.Location = new System.Drawing.Point(3, 31);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(154, 99);
            this.label61.TabIndex = 9;
            this.label61.Text = "label61";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel11.Controls.Add(this.textBox35, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label53, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.panel21, 0, 0);
            this.tableLayoutPanel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(730, 10);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79917F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel11.TabIndex = 13;
            // 
            // textBox35
            // 
            this.textBox35.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox35.Enabled = false;
            this.textBox35.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox35.Location = new System.Drawing.Point(3, 55);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(154, 46);
            this.textBox35.TabIndex = 1;
            this.textBox35.TabStop = false;
            this.textBox35.Text = "TEST";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(3, 104);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(154, 41);
            this.label53.TabIndex = 12;
            this.label53.Text = "CURRENT";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.checkBox17);
            this.panel21.Controls.Add(this.label54);
            this.panel21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel21.Location = new System.Drawing.Point(0, 0);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(160, 52);
            this.panel21.TabIndex = 7;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.BackColor = System.Drawing.Color.Transparent;
            this.label54.Dock = System.Windows.Forms.DockStyle.Left;
            this.label54.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label54.Location = new System.Drawing.Point(0, 0);
            this.label54.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(68, 31);
            this.label54.TabIndex = 0;
            this.label54.Text = "NO2";
            this.label54.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel12.Controls.Add(this.textBox37, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.panel22, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label57, 0, 2);
            this.tableLayoutPanel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(550, 10);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 3;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.10042F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.79917F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel12.TabIndex = 12;
            // 
            // textBox37
            // 
            this.textBox37.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox37.Enabled = false;
            this.textBox37.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox37.Location = new System.Drawing.Point(3, 55);
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(154, 46);
            this.textBox37.TabIndex = 1;
            this.textBox37.TabStop = false;
            this.textBox37.Text = "TEST";
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.checkBox18);
            this.panel22.Controls.Add(this.label56);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(160, 52);
            this.panel22.TabIndex = 7;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.BackColor = System.Drawing.Color.Transparent;
            this.label56.Dock = System.Windows.Forms.DockStyle.Left;
            this.label56.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label56.Location = new System.Drawing.Point(0, 0);
            this.label56.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(54, 31);
            this.label56.TabIndex = 0;
            this.label56.Text = "NO";
            this.label56.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.BackColor = System.Drawing.Color.Transparent;
            this.label57.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label57.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label57.Location = new System.Drawing.Point(3, 104);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(154, 41);
            this.label57.TabIndex = 11;
            this.label57.Text = "CURRENT";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel13.Controls.Add(this.textBox39, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.label59, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(10, 175);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.49554F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.50446F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(160, 147);
            this.tableLayoutPanel13.TabIndex = 11;
            // 
            // textBox39
            // 
            this.textBox39.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox39.Enabled = false;
            this.textBox39.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox39.Location = new System.Drawing.Point(3, 56);
            this.textBox39.Multiline = true;
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(154, 47);
            this.textBox39.TabIndex = 1;
            this.textBox39.TabStop = false;
            this.textBox39.Text = "TEST";
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(3, 106);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(154, 41);
            this.label59.TabIndex = 13;
            this.label59.Text = "CURRENT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.checkBox19);
            this.panel23.Controls.Add(this.label60);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(160, 53);
            this.panel23.TabIndex = 7;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Dock = System.Windows.Forms.DockStyle.Left;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label60.Location = new System.Drawing.Point(0, 0);
            this.label60.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(67, 31);
            this.label60.TabIndex = 0;
            this.label60.Text = "NOx";
            this.label60.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.pictureBox1);
            this.panel24.Controls.Add(this.button1);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(363, 335);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(174, 113);
            this.panel24.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 90);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Snap Shot";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.tableLayoutPanel3.SetColumnSpan(this.chart1, 2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(543, 168);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.tableLayoutPanel3.SetRowSpan(this.chart1, 2);
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series17.Legend = "Legend1";
            series17.Name = "O2";
            series17.Points.Add(dataPoint26);
            series17.Points.Add(dataPoint27);
            series17.Points.Add(dataPoint28);
            series17.Points.Add(dataPoint29);
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series18.Legend = "Legend1";
            series18.Name = "CO";
            series18.Points.Add(dataPoint30);
            series18.Points.Add(dataPoint31);
            series18.Points.Add(dataPoint32);
            series18.Points.Add(dataPoint33);
            series18.Points.Add(dataPoint34);
            series18.Points.Add(dataPoint35);
            series18.Points.Add(dataPoint36);
            series18.Points.Add(dataPoint37);
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series19.Legend = "Legend1";
            series19.Name = "CO2";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series20.Legend = "Legend1";
            series20.Name = "NO";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series21.Legend = "Legend1";
            series21.Name = "NO2";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series22.Legend = "Legend1";
            series22.Name = "NOx";
            series22.YValueMembers = "Tag";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series23.Legend = "Legend1";
            series23.Name = "SO2";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series24.Legend = "Legend1";
            series24.Name = "CxHy";
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series25.Legend = "Legend1";
            series25.Name = "T(gas)";
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series26.Legend = "Legend1";
            series26.Name = "T(amb)";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series27.Legend = "Legend1";
            series27.Name = "Temp1";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series28.Legend = "Legend1";
            series28.Name = "Temp2";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series29.Legend = "Legend1";
            series29.Name = "T(cell)";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series30.Legend = "Legend1";
            series30.Name = "Efficiency";
            series31.ChartArea = "ChartArea1";
            series31.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series31.Legend = "Legend1";
            series31.Name = "Flow";
            series32.ChartArea = "ChartArea1";
            series32.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series32.Legend = "Legend1";
            series32.Name = "NH3";
            this.chart1.Series.Add(series17);
            this.chart1.Series.Add(series18);
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
            this.chart1.Size = new System.Drawing.Size(354, 280);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(906, 457);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.snapShot);
            this.panel12.Controls.Add(this.stopRecordingItem);
            this.panel12.Controls.Add(this.pauseRecordingItem);
            this.panel12.Controls.Add(this.startRecordingItem);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(914, 41);
            this.panel12.TabIndex = 23;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel12, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tabControl1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(920, 536);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // dataGridTimer
            // 
            this.dataGridTimer.Interval = 1000;
            this.dataGridTimer.Tick += new System.EventHandler(this.dataGridTimer_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 584);
            this.Controls.Add(this.tableLayoutPanel2);
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.bTile1.ResumeLayout(false);
            this.bTile1.PerformLayout();
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
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.bTile2.ResumeLayout(false);
            this.bTile2.PerformLayout();
            this.sTile0.ResumeLayout(false);
            this.sTile0.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
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
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel12.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem resetAllAveragesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar recordingProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel recordStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem hidePanelMenuItem;
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
        private TextBox textBox21;
        private Panel panel14;
        private CheckBox checkBox10;
        public Label label33;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox27;
        private Panel panel17;
        private CheckBox checkBox13;
        public Label label41;
        private Label label42;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox29;
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
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox35;
        private Label label53;
        private Panel panel21;
        private CheckBox checkBox17;
        public Label label54;
        private TableLayoutPanel tableLayoutPanel12;
        private TextBox textBox37;
        private Panel panel22;
        private CheckBox checkBox18;
        public Label label56;
        private Label label57;
        private TableLayoutPanel tableLayoutPanel13;
        private TextBox textBox39;
        private Label label59;
        private Panel panel23;
        private CheckBox checkBox19;
        public Label label60;
        private Panel panel24;
        private PictureBox pictureBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel14;
        public System.Windows.Forms.DataVisualization.Charting.Chart trendGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sTile2;
        private Label label23;
        private TableLayoutPanel sTile9;
        private Label label30;
        private TableLayoutPanel sTile8;
        private Label label29;
        private TableLayoutPanel sTile7;
        private Label label28;
        private TableLayoutPanel sTile6;
        private Label label27;
        private TableLayoutPanel sTile1;
        private Label label22;
        private TableLayoutPanel sTile0;
        private Label label21;
        private TableLayoutPanel sTile4;
        private Label label25;
        private TableLayoutPanel sTile3;
        private Label label24;
        private TableLayoutPanel sTile5;
        private Label label26;
        private Panel panel4;
        private TableLayoutPanel bTile2;
        private TableLayoutPanel bTile1;
        private Label tileLabel11;
        private Label tileLabel12;
        private Label label36;
        private Label label37;
        private Label label38;
        private Label label39;
        private System.Windows.Forms.Timer dataGridTimer;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem backGroundColorToolStripMenuItem;
        private ToolStripMenuItem resetColorToolStripMenuItem;
        private Label label61;
        public ToolStripStatusLabel recordTimeLabel;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label69;
        private Label label68;
        private Label label67;
        private Label label66;
        private Label label65;
        private Label label64;
        private Label label63;
        private Label label62;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label35;
        private Label label34;
        private TabPage tabPage4;
        private Label tileLabel1;
        private Label tileLabel3;
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
        private Button button5;
        private Button button12;
        private Button button11;
        private Button button10;
        private Button button9;
        private Button button4;
        private Button button7;
        private Button button6;
        private Button button8;
        private Button button3;
        private WindowWidgets.SignalStrength signalStrength1;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;


    }
}

