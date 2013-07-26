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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.label69 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.label67 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.label65 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.label63 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.label35 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.screenShotBox = new System.Windows.Forms.PictureBox();
            this.btnSnapShot = new System.Windows.Forms.Button();
            this.bTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.elementTable = new System.Windows.Forms.DataGridView();
            this.dgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgGraph = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.trendGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label33 = new System.Windows.Forms.Label();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.textBox30 = new System.Windows.Forms.TextBox();
            this.panel18 = new System.Windows.Forms.Panel();
            this.label45 = new System.Windows.Forms.Label();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label49 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.label50 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox35 = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.textBox36 = new System.Windows.Forms.TextBox();
            this.label53 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.label54 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox37 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox38 = new System.Windows.Forms.TextBox();
            this.panel22 = new System.Windows.Forms.Panel();
            this.label56 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox39 = new System.Windows.Forms.TextBox();
            this.label58 = new System.Windows.Forms.Label();
            this.label59 = new System.Windows.Forms.Label();
            this.textBox40 = new System.Windows.Forms.TextBox();
            this.panel23 = new System.Windows.Forms.Panel();
            this.label60 = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel12 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tilePopUpMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.bTile1.SuspendLayout();
            this.sTile2.SuspendLayout();
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
            this.sTile5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).BeginInit();
            this.bTile2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).BeginInit();
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
            this.recordTimeLabel.Size = new System.Drawing.Size(4, 19);
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
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox10.Location = new System.Drawing.Point(145, 0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 28);
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
            this.checkBox13.Size = new System.Drawing.Size(15, 31);
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
            this.checkBox14.Size = new System.Drawing.Size(15, 31);
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
            this.checkBox15.Size = new System.Drawing.Size(15, 31);
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
            this.checkBox17.Size = new System.Drawing.Size(15, 31);
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
            this.checkBox18.Size = new System.Drawing.Size(15, 31);
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
            this.checkBox19.Size = new System.Drawing.Size(15, 31);
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
            this.snapShot.Click += new System.EventHandler(this.snapShot_Click);
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
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox5.Location = new System.Drawing.Point(145, 0);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 31);
            this.checkBox5.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox5, "Click to disable in report");
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox3.Location = new System.Drawing.Point(145, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 31);
            this.checkBox3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.checkBox3, "Click to disable in report");
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox4.Location = new System.Drawing.Point(145, 0);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 31);
            this.checkBox4.TabIndex = 7;
            this.toolTip1.SetToolTip(this.checkBox4, "Click to disable in report");
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox0
            // 
            this.checkBox0.AutoSize = true;
            this.checkBox0.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox0.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox0.Location = new System.Drawing.Point(145, 0);
            this.checkBox0.Name = "checkBox0";
            this.checkBox0.Size = new System.Drawing.Size(15, 31);
            this.checkBox0.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox0, "Click to disable in report");
            this.checkBox0.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox1.Location = new System.Drawing.Point(145, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 31);
            this.checkBox1.TabIndex = 10;
            this.toolTip1.SetToolTip(this.checkBox1, "Click to disable in report");
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox6.Location = new System.Drawing.Point(145, 0);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(15, 31);
            this.checkBox6.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox6, "Click to disable in report");
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox7.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox7.Location = new System.Drawing.Point(145, 0);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(15, 31);
            this.checkBox7.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkBox7, "Click to disable in report");
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox8.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox8.Location = new System.Drawing.Point(145, 0);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(15, 31);
            this.checkBox8.TabIndex = 2;
            this.toolTip1.SetToolTip(this.checkBox8, "Click to disable in report");
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox9.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox9.Location = new System.Drawing.Point(145, 0);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(15, 31);
            this.checkBox9.TabIndex = 3;
            this.toolTip1.SetToolTip(this.checkBox9, "Click to disable in report");
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox2.Location = new System.Drawing.Point(145, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 28);
            this.checkBox2.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBox2, "Click to disable in report");
            this.checkBox2.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.sTile0, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile4, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.sTile5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.bTile2, 3, 2);
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
            this.sTile2.Controls.Add(this.label6, 0, 3);
            this.sTile2.Controls.Add(this.label23, 0, 2);
            this.sTile2.Controls.Add(this.label13, 0, 4);
            this.sTile2.Controls.Add(this.panel3, 0, 0);
            this.sTile2.Controls.Add(this.label5, 0, 1);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile2.Location = new System.Drawing.Point(370, 10);
            this.sTile2.Margin = new System.Windows.Forms.Padding(10);
            this.sTile2.Name = "sTile2";
            this.sTile2.RowCount = 5;
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62645F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.90712F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58455F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.2741F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile2.Size = new System.Drawing.Size(160, 145);
            this.sTile2.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "label6";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 24);
            this.label23.TabIndex = 10;
            this.label23.Text = "CURRENT";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 118);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label13.Size = new System.Drawing.Size(154, 27);
            this.label13.TabIndex = 4;
            this.label13.Text = "AVERAGE";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.checkBox2);
            this.panel3.Controls.Add(this.tileLabel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 28);
            this.panel3.TabIndex = 7;
            // 
            // tileLabel3
            // 
            this.tileLabel3.AutoSize = true;
            this.tileLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel3.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel3.Location = new System.Drawing.Point(0, 0);
            this.tileLabel3.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel3.Name = "tileLabel3";
            this.tileLabel3.Size = new System.Drawing.Size(68, 31);
            this.tileLabel3.TabIndex = 0;
            this.tileLabel3.Text = "CO2";
            this.tileLabel3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 34);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile9
            // 
            this.sTile9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile9.ColumnCount = 1;
            this.sTile9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile9.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile9.Controls.Add(this.label69, 0, 3);
            this.sTile9.Controls.Add(this.label30, 0, 2);
            this.sTile9.Controls.Add(this.label20, 0, 4);
            this.sTile9.Controls.Add(this.panel11, 0, 0);
            this.sTile9.Controls.Add(this.label68, 0, 1);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile9.Location = new System.Drawing.Point(730, 175);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 5;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65585F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65585F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67717F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67131F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33983F));
            this.sTile9.Size = new System.Drawing.Size(160, 147);
            this.sTile9.TabIndex = 19;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.BackColor = System.Drawing.SystemColors.Control;
            this.label69.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label69.Location = new System.Drawing.Point(3, 86);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(154, 33);
            this.label69.TabIndex = 19;
            this.label69.Text = "label69";
            this.label69.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 62);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(154, 24);
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
            this.label20.Location = new System.Drawing.Point(3, 119);
            this.label20.Name = "label20";
            this.label20.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label20.Size = new System.Drawing.Size(154, 28);
            this.label20.TabIndex = 4;
            this.label20.Text = "AVERAGE";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.checkBox9);
            this.panel11.Controls.Add(this.tileLabel10);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(160, 31);
            this.panel11.TabIndex = 7;
            // 
            // tileLabel10
            // 
            this.tileLabel10.AutoSize = true;
            this.tileLabel10.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel10.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel10.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel10.Location = new System.Drawing.Point(0, 0);
            this.tileLabel10.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel10.Name = "tileLabel10";
            this.tileLabel10.Size = new System.Drawing.Size(101, 31);
            this.tileLabel10.TabIndex = 0;
            this.tileLabel10.Text = "T(amb)";
            this.tileLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.BackColor = System.Drawing.SystemColors.Control;
            this.label68.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label68.Location = new System.Drawing.Point(3, 31);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(154, 31);
            this.label68.TabIndex = 18;
            this.label68.Text = "label68";
            this.label68.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile8
            // 
            this.sTile8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile8.ColumnCount = 1;
            this.sTile8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile8.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile8.Controls.Add(this.label67, 0, 3);
            this.sTile8.Controls.Add(this.label29, 0, 2);
            this.sTile8.Controls.Add(this.label19, 0, 4);
            this.sTile8.Controls.Add(this.panel10, 0, 0);
            this.sTile8.Controls.Add(this.label66, 0, 1);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile8.Location = new System.Drawing.Point(550, 175);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 5;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66611F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.66611F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.70071F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.60276F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.36431F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile8.Size = new System.Drawing.Size(160, 147);
            this.sTile8.TabIndex = 18;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.BackColor = System.Drawing.SystemColors.Control;
            this.label67.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label67.Location = new System.Drawing.Point(3, 86);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(154, 33);
            this.label67.TabIndex = 18;
            this.label67.Text = "label67";
            this.label67.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 62);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 24);
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
            this.label19.Location = new System.Drawing.Point(3, 119);
            this.label19.Name = "label19";
            this.label19.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label19.Size = new System.Drawing.Size(154, 28);
            this.label19.TabIndex = 4;
            this.label19.Text = "AVERAGE";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.checkBox8);
            this.panel10.Controls.Add(this.tileLabel9);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(160, 31);
            this.panel10.TabIndex = 7;
            // 
            // tileLabel9
            // 
            this.tileLabel9.AutoSize = true;
            this.tileLabel9.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel9.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel9.Location = new System.Drawing.Point(0, 0);
            this.tileLabel9.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel9.Name = "tileLabel9";
            this.tileLabel9.Size = new System.Drawing.Size(88, 31);
            this.tileLabel9.TabIndex = 0;
            this.tileLabel9.Text = "T(gas)";
            this.tileLabel9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.BackColor = System.Drawing.SystemColors.Control;
            this.label66.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label66.Location = new System.Drawing.Point(3, 31);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(154, 31);
            this.label66.TabIndex = 17;
            this.label66.Text = "label66";
            this.label66.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile7
            // 
            this.sTile7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile7.ColumnCount = 1;
            this.sTile7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile7.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile7.Controls.Add(this.label65, 0, 3);
            this.sTile7.Controls.Add(this.label18, 0, 4);
            this.sTile7.Controls.Add(this.panel9, 0, 0);
            this.sTile7.Controls.Add(this.label28, 0, 2);
            this.sTile7.Controls.Add(this.label64, 0, 1);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile7.Location = new System.Drawing.Point(370, 175);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 5;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile7.Size = new System.Drawing.Size(160, 147);
            this.sTile7.TabIndex = 17;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.BackColor = System.Drawing.SystemColors.Control;
            this.label65.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label65.Location = new System.Drawing.Point(3, 86);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(154, 33);
            this.label65.TabIndex = 17;
            this.label65.Text = "label65";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(3, 119);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label18.Size = new System.Drawing.Size(154, 28);
            this.label18.TabIndex = 4;
            this.label18.Text = "AVERAGE";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.checkBox7);
            this.panel9.Controls.Add(this.tileLabel8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(160, 31);
            this.panel9.TabIndex = 7;
            // 
            // tileLabel8
            // 
            this.tileLabel8.AutoSize = true;
            this.tileLabel8.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel8.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel8.Location = new System.Drawing.Point(0, 0);
            this.tileLabel8.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel8.Name = "tileLabel8";
            this.tileLabel8.Size = new System.Drawing.Size(80, 31);
            this.tileLabel8.TabIndex = 0;
            this.tileLabel8.Text = "CxHy";
            this.tileLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label64.Location = new System.Drawing.Point(3, 31);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(154, 31);
            this.label64.TabIndex = 16;
            this.label64.Text = "label64";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile6
            // 
            this.sTile6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile6.ColumnCount = 1;
            this.sTile6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile6.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile6.Controls.Add(this.label63, 0, 3);
            this.sTile6.Controls.Add(this.label27, 0, 2);
            this.sTile6.Controls.Add(this.label17, 0, 4);
            this.sTile6.Controls.Add(this.panel8, 0, 0);
            this.sTile6.Controls.Add(this.label62, 0, 1);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile6.Location = new System.Drawing.Point(190, 175);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 5;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile6.Size = new System.Drawing.Size(160, 147);
            this.sTile6.TabIndex = 16;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.BackColor = System.Drawing.SystemColors.Control;
            this.label63.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label63.Location = new System.Drawing.Point(3, 86);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(154, 33);
            this.label63.TabIndex = 16;
            this.label63.Text = "label63";
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
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 119);
            this.label17.Name = "label17";
            this.label17.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label17.Size = new System.Drawing.Size(154, 28);
            this.label17.TabIndex = 4;
            this.label17.Text = "AVERAGE";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBox6);
            this.panel8.Controls.Add(this.tileLabel7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(160, 31);
            this.panel8.TabIndex = 7;
            // 
            // tileLabel7
            // 
            this.tileLabel7.AutoSize = true;
            this.tileLabel7.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel7.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel7.Location = new System.Drawing.Point(0, 0);
            this.tileLabel7.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel7.Name = "tileLabel7";
            this.tileLabel7.Size = new System.Drawing.Size(64, 31);
            this.tileLabel7.TabIndex = 0;
            this.tileLabel7.Text = "SO2";
            this.tileLabel7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.BackColor = System.Drawing.SystemColors.Control;
            this.label62.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label62.Location = new System.Drawing.Point(3, 31);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(154, 31);
            this.label62.TabIndex = 15;
            this.label62.Text = "label62";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile1
            // 
            this.sTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile1.ColumnCount = 1;
            this.sTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile1.Controls.Add(this.label4, 0, 3);
            this.sTile1.Controls.Add(this.label3, 0, 1);
            this.sTile1.Controls.Add(this.label12, 0, 4);
            this.sTile1.Controls.Add(this.panel2, 0, 0);
            this.sTile1.Controls.Add(this.label22, 0, 2);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile1.Location = new System.Drawing.Point(190, 10);
            this.sTile1.Margin = new System.Windows.Forms.Padding(10);
            this.sTile1.Name = "sTile1";
            this.sTile1.RowCount = 5;
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67339F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67379F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34236F));
            this.sTile1.Size = new System.Drawing.Size(160, 145);
            this.sTile1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 31);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 118);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label12.Size = new System.Drawing.Size(154, 27);
            this.label12.TabIndex = 4;
            this.label12.Text = "AVERAGE";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.tileLabel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 31);
            this.panel2.TabIndex = 7;
            // 
            // tileLabel2
            // 
            this.tileLabel2.AutoSize = true;
            this.tileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel2.Location = new System.Drawing.Point(0, 0);
            this.tileLabel2.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel2.Name = "tileLabel2";
            this.tileLabel2.Size = new System.Drawing.Size(54, 31);
            this.tileLabel2.TabIndex = 0;
            this.tileLabel2.Text = "CO";
            this.tileLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 24);
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
            this.sTile0.Controls.Add(this.label2, 0, 3);
            this.sTile0.Controls.Add(this.label11, 0, 4);
            this.sTile0.Controls.Add(this.panel1, 0, 0);
            this.sTile0.Controls.Add(this.label21, 0, 2);
            this.sTile0.Controls.Add(this.label1, 0, 1);
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
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile0.Size = new System.Drawing.Size(160, 145);
            this.sTile0.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 118);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label11.Size = new System.Drawing.Size(154, 27);
            this.label11.TabIndex = 4;
            this.label11.Text = "AVERAGE";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox0);
            this.panel1.Controls.Add(this.tileLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 31);
            this.panel1.TabIndex = 7;
            // 
            // tileLabel1
            // 
            this.tileLabel1.AutoSize = true;
            this.tileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel1.Location = new System.Drawing.Point(0, 0);
            this.tileLabel1.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel1.Name = "tileLabel1";
            this.tileLabel1.Size = new System.Drawing.Size(49, 31);
            this.tileLabel1.TabIndex = 0;
            this.tileLabel1.Text = "O2";
            this.tileLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 24);
            this.label21.TabIndex = 8;
            this.label21.Text = "CURRENT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile4
            // 
            this.sTile4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile4.ColumnCount = 1;
            this.sTile4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile4.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile4.Controls.Add(this.label10, 0, 3);
            this.sTile4.Controls.Add(this.label15, 0, 4);
            this.sTile4.Controls.Add(this.label25, 0, 2);
            this.sTile4.Controls.Add(this.panel7, 0, 0);
            this.sTile4.Controls.Add(this.label9, 0, 1);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile4.Location = new System.Drawing.Point(730, 10);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 5;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile4.Size = new System.Drawing.Size(160, 145);
            this.sTile4.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 32);
            this.label10.TabIndex = 14;
            this.label10.Text = "label10";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 118);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label15.Size = new System.Drawing.Size(154, 27);
            this.label15.TabIndex = 4;
            this.label15.Text = "AVERAGE";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 62);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 24);
            this.label25.TabIndex = 12;
            this.label25.Text = "CURRENT";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.checkBox4);
            this.panel7.Controls.Add(this.tileLabel5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(160, 31);
            this.panel7.TabIndex = 7;
            // 
            // tileLabel5
            // 
            this.tileLabel5.AutoSize = true;
            this.tileLabel5.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel5.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel5.Location = new System.Drawing.Point(0, 0);
            this.tileLabel5.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel5.Name = "tileLabel5";
            this.tileLabel5.Size = new System.Drawing.Size(68, 31);
            this.tileLabel5.TabIndex = 0;
            this.tileLabel5.Text = "NO2";
            this.tileLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 31);
            this.label9.TabIndex = 13;
            this.label9.Text = "label9";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile3
            // 
            this.sTile3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile3.ColumnCount = 1;
            this.sTile3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile3.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile3.Controls.Add(this.label8, 0, 3);
            this.sTile3.Controls.Add(this.label14, 0, 4);
            this.sTile3.Controls.Add(this.panel6, 0, 0);
            this.sTile3.Controls.Add(this.label24, 0, 2);
            this.sTile3.Controls.Add(this.label7, 0, 1);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile3.Location = new System.Drawing.Point(550, 10);
            this.sTile3.Margin = new System.Windows.Forms.Padding(10);
            this.sTile3.Name = "sTile3";
            this.sTile3.RowCount = 5;
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.sTile3.Size = new System.Drawing.Size(160, 145);
            this.sTile3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 32);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(3, 118);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label14.Size = new System.Drawing.Size(154, 27);
            this.label14.TabIndex = 4;
            this.label14.Text = "AVERAGE";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.checkBox3);
            this.panel6.Controls.Add(this.tileLabel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(160, 31);
            this.panel6.TabIndex = 7;
            // 
            // tileLabel4
            // 
            this.tileLabel4.AutoSize = true;
            this.tileLabel4.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel4.Location = new System.Drawing.Point(0, 0);
            this.tileLabel4.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel4.Name = "tileLabel4";
            this.tileLabel4.Size = new System.Drawing.Size(54, 31);
            this.tileLabel4.TabIndex = 0;
            this.tileLabel4.Text = "NO";
            this.tileLabel4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 62);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 24);
            this.label24.TabIndex = 11;
            this.label24.Text = "CURRENT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile5
            // 
            this.sTile5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile5.ColumnCount = 1;
            this.sTile5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile5.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile5.Controls.Add(this.label35, 0, 3);
            this.sTile5.Controls.Add(this.label16, 0, 4);
            this.sTile5.Controls.Add(this.label26, 0, 2);
            this.sTile5.Controls.Add(this.panel5, 0, 0);
            this.sTile5.Controls.Add(this.label34, 0, 1);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Default;
            this.sTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile5.Location = new System.Drawing.Point(10, 175);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 5;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
            this.sTile5.Size = new System.Drawing.Size(160, 147);
            this.sTile5.TabIndex = 11;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.BackColor = System.Drawing.SystemColors.Control;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(3, 86);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 33);
            this.label35.TabIndex = 15;
            this.label35.Text = "label35";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 119);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label16.Size = new System.Drawing.Size(154, 28);
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
            this.label26.Location = new System.Drawing.Point(3, 62);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 24);
            this.label26.TabIndex = 13;
            this.label26.Text = "CURRENT";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.checkBox5);
            this.panel5.Controls.Add(this.tileLabel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(160, 31);
            this.panel5.TabIndex = 7;
            // 
            // tileLabel6
            // 
            this.tileLabel6.AutoSize = true;
            this.tileLabel6.BackColor = System.Drawing.Color.Transparent;
            this.tileLabel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileLabel6.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.tileLabel6.Location = new System.Drawing.Point(0, 0);
            this.tileLabel6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 0);
            this.tileLabel6.Name = "tileLabel6";
            this.tileLabel6.Size = new System.Drawing.Size(67, 31);
            this.tileLabel6.TabIndex = 0;
            this.tileLabel6.Text = "NOx";
            this.tileLabel6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.SystemColors.Control;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(3, 31);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(154, 31);
            this.label34.TabIndex = 14;
            this.label34.Text = "label34";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.screenShotBox);
            this.panel4.Controls.Add(this.btnSnapShot);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(363, 335);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 113);
            this.panel4.TabIndex = 20;
            // 
            // screenShotBox
            // 
            this.screenShotBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screenShotBox.Location = new System.Drawing.Point(0, 0);
            this.screenShotBox.Name = "screenShotBox";
            this.screenShotBox.Size = new System.Drawing.Size(174, 90);
            this.screenShotBox.TabIndex = 1;
            this.screenShotBox.TabStop = false;
            // 
            // btnSnapShot
            // 
            this.btnSnapShot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSnapShot.Location = new System.Drawing.Point(0, 90);
            this.btnSnapShot.Name = "btnSnapShot";
            this.btnSnapShot.Size = new System.Drawing.Size(174, 23);
            this.btnSnapShot.TabIndex = 0;
            this.btnSnapShot.Text = "Snap Shot";
            this.btnSnapShot.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel14.Controls.Add(this.elementTable, 0, 0);
            this.tableLayoutPanel14.Controls.Add(this.trendGraph, 1, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel14.TabIndex = 2;
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
            this.elementTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.elementTable.Location = new System.Drawing.Point(3, 3);
            this.elementTable.Margin = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.elementTable.Name = "elementTable";
            this.elementTable.Size = new System.Drawing.Size(272, 345);
            this.elementTable.TabIndex = 5;
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
            // trendGraph
            // 
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea1.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea1.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 5;
            chartArea1.Name = "ChartArea1";
            this.trendGraph.ChartAreas.Add(chartArea1);
            this.trendGraph.DataSource = this.elementTable;
            this.trendGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.trendGraph.Legends.Add(legend1);
            this.trendGraph.Location = new System.Drawing.Point(281, 3);
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
            this.trendGraph.Size = new System.Drawing.Size(616, 443);
            this.trendGraph.TabIndex = 1;
            this.trendGraph.Text = "trendChart";
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
            this.tableLayoutPanel4.Controls.Add(this.label32, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBox22, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.panel14, 0, 0);
            this.tableLayoutPanel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(370, 10);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.62645F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.90712F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.60777F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.58455F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.2741F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 62);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(154, 24);
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
            this.textBox21.Location = new System.Drawing.Point(3, 31);
            this.textBox21.Multiline = true;
            this.textBox21.Name = "textBox21";
            this.textBox21.ReadOnly = true;
            this.textBox21.Size = new System.Drawing.Size(154, 28);
            this.textBox21.TabIndex = 1;
            this.textBox21.TabStop = false;
            this.textBox21.Text = "TEST";
            this.textBox21.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 118);
            this.label32.Name = "label32";
            this.label32.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label32.Size = new System.Drawing.Size(154, 27);
            this.label32.TabIndex = 4;
            this.label32.Text = "AVERAGE";
            this.label32.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox22
            // 
            this.textBox22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox22.Enabled = false;
            this.textBox22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox22.Location = new System.Drawing.Point(3, 89);
            this.textBox22.Multiline = true;
            this.textBox22.Name = "textBox22";
            this.textBox22.ReadOnly = true;
            this.textBox22.Size = new System.Drawing.Size(154, 26);
            this.textBox22.TabIndex = 3;
            this.textBox22.TabStop = false;
            this.textBox22.Text = "20.8%";
            this.textBox22.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.checkBox10);
            this.panel14.Controls.Add(this.label33);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Margin = new System.Windows.Forms.Padding(0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(160, 28);
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
            this.tableLayoutPanel7.Controls.Add(this.label40, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.textBox28, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(370, 175);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 5;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox27.Location = new System.Drawing.Point(3, 34);
            this.textBox27.Multiline = true;
            this.textBox27.Name = "textBox27";
            this.textBox27.ReadOnly = true;
            this.textBox27.Size = new System.Drawing.Size(154, 25);
            this.textBox27.TabIndex = 1;
            this.textBox27.TabStop = false;
            this.textBox27.Text = "TEST";
            this.textBox27.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.BackColor = System.Drawing.Color.Transparent;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(3, 119);
            this.label40.Name = "label40";
            this.label40.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label40.Size = new System.Drawing.Size(154, 28);
            this.label40.TabIndex = 4;
            this.label40.Text = "AVERAGE";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox28
            // 
            this.textBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox28.Enabled = false;
            this.textBox28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox28.Location = new System.Drawing.Point(3, 89);
            this.textBox28.Multiline = true;
            this.textBox28.Name = "textBox28";
            this.textBox28.ReadOnly = true;
            this.textBox28.Size = new System.Drawing.Size(154, 27);
            this.textBox28.TabIndex = 3;
            this.textBox28.TabStop = false;
            this.textBox28.Text = "20.8%";
            this.textBox28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.checkBox13);
            this.panel17.Controls.Add(this.label41);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(0, 0);
            this.panel17.Margin = new System.Windows.Forms.Padding(0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(160, 31);
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
            this.label42.Location = new System.Drawing.Point(3, 62);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(154, 24);
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
            this.tableLayoutPanel8.Controls.Add(this.label44, 0, 4);
            this.tableLayoutPanel8.Controls.Add(this.textBox30, 0, 3);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(190, 175);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 5;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox29.Location = new System.Drawing.Point(3, 34);
            this.textBox29.Multiline = true;
            this.textBox29.Name = "textBox29";
            this.textBox29.ReadOnly = true;
            this.textBox29.Size = new System.Drawing.Size(154, 25);
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
            this.label43.Location = new System.Drawing.Point(3, 62);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(154, 24);
            this.label43.TabIndex = 14;
            this.label43.Text = "CURRENT";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(3, 119);
            this.label44.Name = "label44";
            this.label44.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label44.Size = new System.Drawing.Size(154, 28);
            this.label44.TabIndex = 4;
            this.label44.Text = "AVERAGE";
            this.label44.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox30
            // 
            this.textBox30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox30.Enabled = false;
            this.textBox30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox30.Location = new System.Drawing.Point(3, 89);
            this.textBox30.Multiline = true;
            this.textBox30.Name = "textBox30";
            this.textBox30.ReadOnly = true;
            this.textBox30.Size = new System.Drawing.Size(154, 27);
            this.textBox30.TabIndex = 3;
            this.textBox30.TabStop = false;
            this.textBox30.Text = "20.8%";
            this.textBox30.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.checkBox14);
            this.panel18.Controls.Add(this.label45);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(0, 0);
            this.panel18.Margin = new System.Windows.Forms.Padding(0);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(160, 31);
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
            this.tableLayoutPanel9.Controls.Add(this.label46, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.textBox32, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.panel19, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.label48, 0, 2);
            this.tableLayoutPanel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(190, 10);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 5;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65523F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67339F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67379F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34236F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel9.TabIndex = 15;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.Color.Transparent;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 118);
            this.label46.Name = "label46";
            this.label46.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label46.Size = new System.Drawing.Size(154, 27);
            this.label46.TabIndex = 4;
            this.label46.Text = "AVERAGE";
            this.label46.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox32
            // 
            this.textBox32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox32.Enabled = false;
            this.textBox32.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox32.Location = new System.Drawing.Point(3, 89);
            this.textBox32.Multiline = true;
            this.textBox32.Name = "textBox32";
            this.textBox32.ReadOnly = true;
            this.textBox32.Size = new System.Drawing.Size(154, 26);
            this.textBox32.TabIndex = 3;
            this.textBox32.TabStop = false;
            this.textBox32.Text = "20.8%";
            this.textBox32.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.checkBox15);
            this.panel19.Controls.Add(this.label47);
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(160, 31);
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
            this.label48.Location = new System.Drawing.Point(3, 62);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(154, 24);
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
            this.tableLayoutPanel10.Controls.Add(this.label49, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.textBox34, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.panel20, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.label51, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.label61, 0, 1);
            this.tableLayoutPanel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 5;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.05025F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.05263F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.52632F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel10.Size = new System.Drawing.Size(160, 145);
            this.tableLayoutPanel10.TabIndex = 14;
            // 
            // label49
            // 
            this.label49.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(49, 126);
            this.label49.Name = "label49";
            this.label49.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label49.Size = new System.Drawing.Size(62, 19);
            this.label49.TabIndex = 4;
            this.label49.Text = "AVERAGE";
            this.label49.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox34
            // 
            this.textBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox34.Enabled = false;
            this.textBox34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox34.Location = new System.Drawing.Point(3, 94);
            this.textBox34.Multiline = true;
            this.textBox34.Name = "textBox34";
            this.textBox34.ReadOnly = true;
            this.textBox34.Size = new System.Drawing.Size(154, 28);
            this.textBox34.TabIndex = 3;
            this.textBox34.TabStop = false;
            this.textBox34.Text = "20.8%";
            this.textBox34.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.label51.Location = new System.Drawing.Point(48, 76);
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
            this.label61.Size = new System.Drawing.Size(154, 45);
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
            this.tableLayoutPanel11.Controls.Add(this.label52, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.textBox36, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.label53, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.panel21, 0, 0);
            this.tableLayoutPanel11.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(730, 10);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 5;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox35.Location = new System.Drawing.Point(3, 34);
            this.textBox35.Multiline = true;
            this.textBox35.Name = "textBox35";
            this.textBox35.ReadOnly = true;
            this.textBox35.Size = new System.Drawing.Size(154, 25);
            this.textBox35.TabIndex = 1;
            this.textBox35.TabStop = false;
            this.textBox35.Text = "TEST";
            this.textBox35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(3, 118);
            this.label52.Name = "label52";
            this.label52.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label52.Size = new System.Drawing.Size(154, 27);
            this.label52.TabIndex = 4;
            this.label52.Text = "AVERAGE";
            this.label52.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox36
            // 
            this.textBox36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox36.Enabled = false;
            this.textBox36.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox36.Location = new System.Drawing.Point(3, 89);
            this.textBox36.Multiline = true;
            this.textBox36.Name = "textBox36";
            this.textBox36.ReadOnly = true;
            this.textBox36.Size = new System.Drawing.Size(154, 26);
            this.textBox36.TabIndex = 3;
            this.textBox36.TabStop = false;
            this.textBox36.Text = "20.8%";
            this.textBox36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(3, 62);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(154, 24);
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
            this.panel21.Size = new System.Drawing.Size(160, 31);
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
            this.tableLayoutPanel12.Controls.Add(this.label55, 0, 4);
            this.tableLayoutPanel12.Controls.Add(this.textBox38, 0, 3);
            this.tableLayoutPanel12.Controls.Add(this.panel22, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.label57, 0, 2);
            this.tableLayoutPanel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(550, 10);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 5;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox37.Location = new System.Drawing.Point(3, 34);
            this.textBox37.Multiline = true;
            this.textBox37.Name = "textBox37";
            this.textBox37.ReadOnly = true;
            this.textBox37.Size = new System.Drawing.Size(154, 25);
            this.textBox37.TabIndex = 1;
            this.textBox37.TabStop = false;
            this.textBox37.Text = "TEST";
            this.textBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.BackColor = System.Drawing.Color.Transparent;
            this.label55.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label55.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label55.Location = new System.Drawing.Point(3, 118);
            this.label55.Name = "label55";
            this.label55.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label55.Size = new System.Drawing.Size(154, 27);
            this.label55.TabIndex = 4;
            this.label55.Text = "AVERAGE";
            this.label55.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox38
            // 
            this.textBox38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox38.Enabled = false;
            this.textBox38.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox38.Location = new System.Drawing.Point(3, 89);
            this.textBox38.Multiline = true;
            this.textBox38.Name = "textBox38";
            this.textBox38.ReadOnly = true;
            this.textBox38.Size = new System.Drawing.Size(154, 26);
            this.textBox38.TabIndex = 3;
            this.textBox38.TabStop = false;
            this.textBox38.Text = "20.8%";
            this.textBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.checkBox18);
            this.panel22.Controls.Add(this.label56);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Margin = new System.Windows.Forms.Padding(0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(160, 31);
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
            this.label57.Location = new System.Drawing.Point(3, 62);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(154, 24);
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
            this.tableLayoutPanel13.Controls.Add(this.label58, 0, 4);
            this.tableLayoutPanel13.Controls.Add(this.label59, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.textBox40, 0, 3);
            this.tableLayoutPanel13.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(10, 175);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 5;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.65663F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.67671F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.67068F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.33936F));
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
            this.textBox39.Location = new System.Drawing.Point(3, 34);
            this.textBox39.Multiline = true;
            this.textBox39.Name = "textBox39";
            this.textBox39.ReadOnly = true;
            this.textBox39.Size = new System.Drawing.Size(154, 25);
            this.textBox39.TabIndex = 1;
            this.textBox39.TabStop = false;
            this.textBox39.Text = "TEST";
            this.textBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.BackColor = System.Drawing.Color.Transparent;
            this.label58.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label58.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label58.Location = new System.Drawing.Point(3, 119);
            this.label58.Name = "label58";
            this.label58.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.label58.Size = new System.Drawing.Size(154, 28);
            this.label58.TabIndex = 4;
            this.label58.Text = "AVERAGE";
            this.label58.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(3, 62);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(154, 24);
            this.label59.TabIndex = 13;
            this.label59.Text = "CURRENT";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox40
            // 
            this.textBox40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox40.Enabled = false;
            this.textBox40.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox40.Location = new System.Drawing.Point(3, 89);
            this.textBox40.Multiline = true;
            this.textBox40.Name = "textBox40";
            this.textBox40.ReadOnly = true;
            this.textBox40.Size = new System.Drawing.Size(154, 27);
            this.textBox40.TabIndex = 3;
            this.textBox40.TabStop = false;
            this.textBox40.Text = "20.8%";
            this.textBox40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.checkBox19);
            this.panel23.Controls.Add(this.label60);
            this.panel23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel23.Location = new System.Drawing.Point(0, 0);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(160, 31);
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
            this.chart1.DataSource = this.elementTable;
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
            this.sTile5.ResumeLayout(false);
            this.sTile5.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenShotBox)).EndInit();
            this.bTile2.ResumeLayout(false);
            this.bTile2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elementTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trendGraph)).EndInit();
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
        private Label label32;
        private TextBox textBox22;
        private Panel panel14;
        private CheckBox checkBox10;
        public Label label33;
        private TableLayoutPanel tableLayoutPanel7;
        private TextBox textBox27;
        private Label label40;
        private TextBox textBox28;
        private Panel panel17;
        private CheckBox checkBox13;
        public Label label41;
        private Label label42;
        private TableLayoutPanel tableLayoutPanel8;
        private TextBox textBox29;
        private Label label43;
        private Label label44;
        private TextBox textBox30;
        private Panel panel18;
        private CheckBox checkBox14;
        public Label label45;
        private TableLayoutPanel tableLayoutPanel9;
        private Label label46;
        private TextBox textBox32;
        private Panel panel19;
        private CheckBox checkBox15;
        public Label label47;
        private Label label48;
        private TableLayoutPanel tableLayoutPanel10;
        private Label label49;
        private TextBox textBox34;
        private Panel panel20;
        private CheckBox checkBox16;
        public Label label50;
        private Label label51;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox textBox35;
        private Label label52;
        private TextBox textBox36;
        private Label label53;
        private Panel panel21;
        private CheckBox checkBox17;
        public Label label54;
        private TableLayoutPanel tableLayoutPanel12;
        private TextBox textBox37;
        private Label label55;
        private TextBox textBox38;
        private Panel panel22;
        private CheckBox checkBox18;
        public Label label56;
        private Label label57;
        private TableLayoutPanel tableLayoutPanel13;
        private TextBox textBox39;
        private Label label58;
        private Label label59;
        private TextBox textBox40;
        private Panel panel23;
        private CheckBox checkBox19;
        public Label label60;
        private Panel panel24;
        private PictureBox pictureBox1;
        private Button button1;
        private TableLayoutPanel tableLayoutPanel14;
        public DataGridView elementTable;
        private DataGridViewTextBoxColumn dgName;
        private DataGridViewTextBoxColumn dgValue;
        private DataGridViewTextBoxColumn dgUnit;
        private DataGridViewCheckBoxColumn dgGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart trendGraph;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel sTile2;
        private Label label23;
        private Label label13;
        private Panel panel3;
        private CheckBox checkBox2;
        public Label tileLabel3;
        private TableLayoutPanel sTile9;
        private Label label30;
        private Label label20;
        private Panel panel11;
        private CheckBox checkBox9;
        public Label tileLabel10;
        private TableLayoutPanel sTile8;
        private Label label29;
        private Label label19;
        private Panel panel10;
        private CheckBox checkBox8;
        public Label tileLabel9;
        private TableLayoutPanel sTile7;
        private Label label18;
        private Panel panel9;
        private CheckBox checkBox7;
        public Label tileLabel8;
        private Label label28;
        private TableLayoutPanel sTile6;
        private Label label27;
        private Label label17;
        private Panel panel8;
        private CheckBox checkBox6;
        public Label tileLabel7;
        private TableLayoutPanel sTile1;
        private Label label12;
        private Panel panel2;
        private CheckBox checkBox1;
        public Label tileLabel2;
        private Label label22;
        private TableLayoutPanel sTile0;
        private Label label11;
        private Panel panel1;
        private CheckBox checkBox0;
        public Label tileLabel1;
        private Label label21;
        private TableLayoutPanel sTile4;
        private Label label15;
        private Label label25;
        private Panel panel7;
        private CheckBox checkBox4;
        public Label tileLabel5;
        private TableLayoutPanel sTile3;
        private Label label14;
        private Panel panel6;
        private CheckBox checkBox3;
        public Label tileLabel4;
        private Label label24;
        private TableLayoutPanel sTile5;
        private Label label16;
        private Label label26;
        private Panel panel5;
        private CheckBox checkBox5;
        public Label tileLabel6;
        private Panel panel4;
        private PictureBox screenShotBox;
        private Button btnSnapShot;
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


    }
}

