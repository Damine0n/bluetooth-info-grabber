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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series205 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint223 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint224 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint225 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 4.6D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint226 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2.2D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint227 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series206 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint228 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint229 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 500D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint230 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint231 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 200D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint232 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series207 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series208 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series209 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series210 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint233 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint234 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 261D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint235 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 2000D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint236 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 300D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint237 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series211 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series212 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series213 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint238 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint239 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 3D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint240 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 350D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint241 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 290D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint242 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series214 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint243 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint244 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 38D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint245 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 75D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint246 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint247 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series215 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series216 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series217 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series218 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series219 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series220 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series221 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series222 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series223 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint248 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 22D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint249 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 100D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint250 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 80D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint251 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series224 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint252 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint253 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint254 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint255 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint256 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint257 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint258 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint259 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series225 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series226 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series227 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series228 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series229 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series230 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series231 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series232 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series233 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series234 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series235 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series236 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series237 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series238 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.snapShot = new System.Windows.Forms.Button();
            this.stopRecordingItem = new System.Windows.Forms.Button();
            this.pauseRecordingItem = new System.Windows.Forms.Button();
            this.startRecordingItem = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.hTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.tileLabel11 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label11_ = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.rLabel1 = new System.Windows.Forms.Label();
            this.sTile2 = new System.Windows.Forms.TableLayoutPanel();
            this.button5 = new System.Windows.Forms.Button();
            this.label3_ = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tileLabel3 = new System.Windows.Forms.Label();
            this.sTile9 = new System.Windows.Forms.TableLayoutPanel();
            this.button12 = new System.Windows.Forms.Button();
            this.label10_ = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tileLabel10 = new System.Windows.Forms.Label();
            this.sTile8 = new System.Windows.Forms.TableLayoutPanel();
            this.button11 = new System.Windows.Forms.Button();
            this.label9_ = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tileLabel9 = new System.Windows.Forms.Label();
            this.sTile7 = new System.Windows.Forms.TableLayoutPanel();
            this.button10 = new System.Windows.Forms.Button();
            this.label8_ = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tileLabel8 = new System.Windows.Forms.Label();
            this.sTile6 = new System.Windows.Forms.TableLayoutPanel();
            this.button9 = new System.Windows.Forms.Button();
            this.label7_ = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tileLabel7 = new System.Windows.Forms.Label();
            this.sTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.label2_ = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.tileLabel2 = new System.Windows.Forms.Label();
            this.sTile4 = new System.Windows.Forms.TableLayoutPanel();
            this.button7 = new System.Windows.Forms.Button();
            this.label5_ = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tileLabel5 = new System.Windows.Forms.Label();
            this.sTile3 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.label4_ = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tileLabel4 = new System.Windows.Forms.Label();
            this.sTile5 = new System.Windows.Forms.TableLayoutPanel();
            this.button8 = new System.Windows.Forms.Button();
            this.label6_ = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tileLabel6 = new System.Windows.Forms.Label();
            this.hTile1 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.label12_ = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rLabel2 = new System.Windows.Forms.Label();
            this.tileLabel12 = new System.Windows.Forms.Label();
            this.sTile0 = new System.Windows.Forms.TableLayoutPanel();
            this.label1_ = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tileLabel1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
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
            this.panel12 = new System.Windows.Forms.Panel();
            this.recordingSign = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridTimer = new System.Windows.Forms.Timer(this.components);
            this.recordSign = new System.Windows.Forms.Timer(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileBackGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backGroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.instrumentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
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
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(920, 24);
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
            this.advancedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instrumentToolStripMenuItem});
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
            this.equipmentSiteToolStripMenuItem,
            this.toolStripSeparator4,
            this.themeToolStripMenuItem});
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
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox10.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox10.Location = new System.Drawing.Point(120, 0);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(15, 31);
            this.checkBox10.TabIndex = 9;
            this.toolTip1.SetToolTip(this.checkBox10, "Click to disable in report");
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox13.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox13.Location = new System.Drawing.Point(120, 0);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(15, 33);
            this.checkBox13.TabIndex = 5;
            this.toolTip1.SetToolTip(this.checkBox13, "Click to disable in report");
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox14.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox14.Location = new System.Drawing.Point(120, 0);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(15, 33);
            this.checkBox14.TabIndex = 4;
            this.toolTip1.SetToolTip(this.checkBox14, "Click to disable in report");
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox15.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox15.Location = new System.Drawing.Point(120, 0);
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
            this.checkBox16.Location = new System.Drawing.Point(120, 0);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(15, 31);
            this.checkBox16.TabIndex = 1;
            this.toolTip1.SetToolTip(this.checkBox16, "Click to disable in report");
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // checkBox19
            // 
            this.checkBox19.AutoSize = true;
            this.checkBox19.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox19.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox19.Location = new System.Drawing.Point(120, 0);
            this.checkBox19.Name = "checkBox19";
            this.checkBox19.Size = new System.Drawing.Size(15, 31);
            this.checkBox19.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox19, "Click to disable in report");
            this.checkBox19.UseVisualStyleBackColor = true;
            // 
            // snapShot
            // 
            this.snapShot.BackColor = System.Drawing.Color.Transparent;
            this.snapShot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("snapShot.BackgroundImage")));
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
            this.stopRecordingItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stopRecordingItem.BackgroundImage")));
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
            this.pauseRecordingItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pauseRecordingItem.BackgroundImage")));
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
            this.startRecordingItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startRecordingItem.BackgroundImage")));
            this.startRecordingItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.startRecordingItem.ForeColor = System.Drawing.Color.Transparent;
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
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Right;
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
            this.checkBox3.Location = new System.Drawing.Point(120, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 31);
            this.checkBox3.TabIndex = 6;
            this.toolTip1.SetToolTip(this.checkBox3, "Click to disable in report");
            this.checkBox3.UseVisualStyleBackColor = true;
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
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.shapeContainer1);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // hTile0
            // 
            this.hTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hTile0.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.hTile0, 2);
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.hTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.hTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile0.Controls.Add(this.tileLabel11, 0, 0);
            this.hTile0.Controls.Add(this.label11, 0, 1);
            this.hTile0.Controls.Add(this.label11_, 3, 1);
            this.hTile0.Controls.Add(this.button14, 1, 2);
            this.hTile0.Controls.Add(this.rLabel1, 1, 1);
            this.hTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hTile0.Location = new System.Drawing.Point(3, 335);
            this.hTile0.Name = "hTile0";
            this.hTile0.RowCount = 3;
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile0.Size = new System.Drawing.Size(354, 113);
            this.hTile0.TabIndex = 24;
            // 
            // tileLabel11
            // 
            this.tileLabel11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLabel11.AutoSize = true;
            this.hTile0.SetColumnSpan(this.tileLabel11, 4);
            this.tileLabel11.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel11.Location = new System.Drawing.Point(3, 0);
            this.tileLabel11.Name = "tileLabel11";
            this.tileLabel11.Size = new System.Drawing.Size(348, 31);
            this.tileLabel11.TabIndex = 0;
            this.tileLabel11.Text = "CO(mass)";
            this.tileLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 32);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.hTile0.SetRowSpan(this.label11, 2);
            this.label11.Size = new System.Drawing.Size(97, 80);
            this.label11.TabIndex = 4;
            this.label11.Text = "0.0";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11_
            // 
            this.label11_.AutoSize = true;
            this.label11_.BackColor = System.Drawing.SystemColors.Control;
            this.label11_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11_.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11_.Location = new System.Drawing.Point(254, 32);
            this.label11_.Margin = new System.Windows.Forms.Padding(1);
            this.label11_.Name = "label11_";
            this.hTile0.SetRowSpan(this.label11_, 2);
            this.label11_.Size = new System.Drawing.Size(99, 80);
            this.label11_.TabIndex = 5;
            this.label11_.Text = "0.0";
            this.label11_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button14
            // 
            this.hTile0.SetColumnSpan(this.button14, 2);
            this.button14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button14.Location = new System.Drawing.Point(102, 87);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(148, 23);
            this.button14.TabIndex = 6;
            this.button14.Text = "RESET AVERAGE";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // rLabel1
            // 
            this.rLabel1.AutoSize = true;
            this.hTile0.SetColumnSpan(this.rLabel1, 2);
            this.rLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel1.Location = new System.Drawing.Point(102, 31);
            this.rLabel1.Name = "rLabel1";
            this.rLabel1.Size = new System.Drawing.Size(148, 53);
            this.rLabel1.TabIndex = 7;
            this.rLabel1.Text = "g/bhp-hr";
            this.rLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile2
            // 
            this.sTile2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile2.ColumnCount = 1;
            this.sTile2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile2.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile2.Controls.Add(this.button5, 0, 4);
            this.sTile2.Controls.Add(this.label3_, 0, 3);
            this.sTile2.Controls.Add(this.label23, 0, 2);
            this.sTile2.Controls.Add(this.label3, 0, 1);
            this.sTile2.Controls.Add(this.tileLabel3, 0, 0);
            this.sTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile2.Location = new System.Drawing.Point(370, 10);
            this.sTile2.Margin = new System.Windows.Forms.Padding(10);
            this.sTile2.Name = "sTile2";
            this.sTile2.RowCount = 5;
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.42237F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.57763F));
            this.sTile2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile2.Size = new System.Drawing.Size(160, 145);
            this.sTile2.TabIndex = 4;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(3, 121);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 21);
            this.button5.TabIndex = 14;
            this.button5.Text = "AVERAGE";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label3_
            // 
            this.label3_.AutoSize = true;
            this.label3_.BackColor = System.Drawing.SystemColors.Control;
            this.label3_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3_.Location = new System.Drawing.Point(3, 83);
            this.label3_.Name = "label3_";
            this.label3_.Size = new System.Drawing.Size(154, 34);
            this.label3_.TabIndex = 12;
            this.label3_.Text = "0.0";
            this.label3_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(3, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(154, 15);
            this.label23.TabIndex = 10;
            this.label23.Text = "CURRENT";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "0.0";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile9.Controls.Add(this.label10_, 0, 3);
            this.sTile9.Controls.Add(this.label30, 0, 2);
            this.sTile9.Controls.Add(this.label10, 0, 1);
            this.sTile9.Controls.Add(this.tileLabel10, 0, 0);
            this.sTile9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile9.Location = new System.Drawing.Point(730, 175);
            this.sTile9.Margin = new System.Windows.Forms.Padding(10);
            this.sTile9.Name = "sTile9";
            this.sTile9.RowCount = 5;
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85458F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14542F));
            this.sTile9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile9.Size = new System.Drawing.Size(160, 147);
            this.sTile9.TabIndex = 19;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Transparent;
            this.button12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Location = new System.Drawing.Point(3, 122);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(154, 22);
            this.button12.TabIndex = 21;
            this.button12.Text = "AVERAGE";
            this.button12.UseVisualStyleBackColor = false;
            // 
            // label10_
            // 
            this.label10_.AutoSize = true;
            this.label10_.BackColor = System.Drawing.SystemColors.Control;
            this.label10_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10_.Location = new System.Drawing.Point(3, 81);
            this.label10_.Name = "label10_";
            this.label10_.Size = new System.Drawing.Size(154, 37);
            this.label10_.TabIndex = 19;
            this.label10_.Text = "0.0";
            this.label10_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(3, 66);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(154, 15);
            this.label30.TabIndex = 17;
            this.label30.Text = "CURRENT";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 35);
            this.label10.TabIndex = 18;
            this.label10.Text = "0.0";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile8.Controls.Add(this.label9_, 0, 3);
            this.sTile8.Controls.Add(this.label29, 0, 2);
            this.sTile8.Controls.Add(this.label9, 0, 1);
            this.sTile8.Controls.Add(this.tileLabel9, 0, 0);
            this.sTile8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile8.Location = new System.Drawing.Point(550, 175);
            this.sTile8.Margin = new System.Windows.Forms.Padding(10);
            this.sTile8.Name = "sTile8";
            this.sTile8.RowCount = 5;
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.94208F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.05791F));
            this.sTile8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile8.Size = new System.Drawing.Size(160, 147);
            this.sTile8.TabIndex = 18;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Transparent;
            this.button11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Location = new System.Drawing.Point(3, 122);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(154, 22);
            this.button11.TabIndex = 20;
            this.button11.Text = "AVERAGE";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label9_
            // 
            this.label9_.AutoSize = true;
            this.label9_.BackColor = System.Drawing.SystemColors.Control;
            this.label9_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9_.Location = new System.Drawing.Point(3, 81);
            this.label9_.Name = "label9_";
            this.label9_.Size = new System.Drawing.Size(154, 37);
            this.label9_.TabIndex = 18;
            this.label9_.Text = "0.0";
            this.label9_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(3, 66);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(154, 15);
            this.label29.TabIndex = 16;
            this.label29.Text = "CURRENT";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 35);
            this.label9.TabIndex = 17;
            this.label9.Text = "0.0";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile7.Controls.Add(this.label8_, 0, 3);
            this.sTile7.Controls.Add(this.label28, 0, 2);
            this.sTile7.Controls.Add(this.label8, 0, 1);
            this.sTile7.Controls.Add(this.tileLabel8, 0, 0);
            this.sTile7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile7.Location = new System.Drawing.Point(370, 175);
            this.sTile7.Margin = new System.Windows.Forms.Padding(10);
            this.sTile7.Name = "sTile7";
            this.sTile7.RowCount = 5;
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85619F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14381F));
            this.sTile7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile7.Size = new System.Drawing.Size(160, 147);
            this.sTile7.TabIndex = 17;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Transparent;
            this.button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Location = new System.Drawing.Point(3, 122);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(154, 22);
            this.button10.TabIndex = 19;
            this.button10.Text = "AVERAGE";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // label8_
            // 
            this.label8_.AutoSize = true;
            this.label8_.BackColor = System.Drawing.SystemColors.Control;
            this.label8_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8_.Location = new System.Drawing.Point(3, 81);
            this.label8_.Name = "label8_";
            this.label8_.Size = new System.Drawing.Size(154, 37);
            this.label8_.TabIndex = 17;
            this.label8_.Text = "0.0";
            this.label8_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(3, 66);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(154, 15);
            this.label28.TabIndex = 15;
            this.label28.Text = "CURRENT";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "0.0";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile6.Controls.Add(this.label7_, 0, 3);
            this.sTile6.Controls.Add(this.label27, 0, 2);
            this.sTile6.Controls.Add(this.label7, 0, 1);
            this.sTile6.Controls.Add(this.tileLabel7, 0, 0);
            this.sTile6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile6.Location = new System.Drawing.Point(190, 175);
            this.sTile6.Margin = new System.Windows.Forms.Padding(10);
            this.sTile6.Name = "sTile6";
            this.sTile6.RowCount = 5;
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85619F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14381F));
            this.sTile6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile6.Size = new System.Drawing.Size(160, 147);
            this.sTile6.TabIndex = 16;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Location = new System.Drawing.Point(3, 122);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(154, 22);
            this.button9.TabIndex = 18;
            this.button9.Text = "AVERAGE";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // label7_
            // 
            this.label7_.AutoSize = true;
            this.label7_.BackColor = System.Drawing.SystemColors.Control;
            this.label7_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7_.Location = new System.Drawing.Point(3, 81);
            this.label7_.Name = "label7_";
            this.label7_.Size = new System.Drawing.Size(154, 37);
            this.label7_.TabIndex = 16;
            this.label7_.Text = "0.0";
            this.label7_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(3, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(154, 15);
            this.label27.TabIndex = 14;
            this.label27.Text = "CURRENT";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 35);
            this.label7.TabIndex = 15;
            this.label7.Text = "0.0";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile1.Controls.Add(this.label2_, 0, 3);
            this.sTile1.Controls.Add(this.label2, 0, 1);
            this.sTile1.Controls.Add(this.label22, 0, 2);
            this.sTile1.Controls.Add(this.tileLabel2, 0, 0);
            this.sTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile1.Location = new System.Drawing.Point(190, 10);
            this.sTile1.Margin = new System.Windows.Forms.Padding(10);
            this.sTile1.Name = "sTile1";
            this.sTile1.RowCount = 5;
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85114F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14886F));
            this.sTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile1.Size = new System.Drawing.Size(160, 145);
            this.sTile1.TabIndex = 15;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Location = new System.Drawing.Point(3, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 21);
            this.button4.TabIndex = 13;
            this.button4.Text = "AVERAGE";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2_
            // 
            this.label2_.AutoSize = true;
            this.label2_.BackColor = System.Drawing.SystemColors.Control;
            this.label2_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2_.Location = new System.Drawing.Point(3, 81);
            this.label2_.Name = "label2_";
            this.label2_.Size = new System.Drawing.Size(154, 36);
            this.label2_.TabIndex = 11;
            this.label2_.Text = "0.0";
            this.label2_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "0.0";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(3, 66);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(154, 15);
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
            this.sTile4.Controls.Add(this.label5_, 0, 3);
            this.sTile4.Controls.Add(this.label25, 0, 2);
            this.sTile4.Controls.Add(this.label5, 0, 1);
            this.sTile4.Controls.Add(this.tileLabel5, 0, 0);
            this.sTile4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile4.Location = new System.Drawing.Point(730, 10);
            this.sTile4.Margin = new System.Windows.Forms.Padding(10);
            this.sTile4.Name = "sTile4";
            this.sTile4.RowCount = 5;
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85619F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14381F));
            this.sTile4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile4.Size = new System.Drawing.Size(160, 145);
            this.sTile4.TabIndex = 13;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Location = new System.Drawing.Point(3, 121);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(154, 21);
            this.button7.TabIndex = 16;
            this.button7.Text = "AVERAGE";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // label5_
            // 
            this.label5_.AutoSize = true;
            this.label5_.BackColor = System.Drawing.SystemColors.Control;
            this.label5_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_.Location = new System.Drawing.Point(3, 81);
            this.label5_.Name = "label5_";
            this.label5_.Size = new System.Drawing.Size(154, 36);
            this.label5_.TabIndex = 14;
            this.label5_.Text = "0.0";
            this.label5_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(3, 66);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(154, 15);
            this.label25.TabIndex = 12;
            this.label25.Text = "CURRENT";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 35);
            this.label5.TabIndex = 13;
            this.label5.Text = "0.0";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile3.Controls.Add(this.label4_, 0, 3);
            this.sTile3.Controls.Add(this.label24, 0, 2);
            this.sTile3.Controls.Add(this.label4, 0, 1);
            this.sTile3.Controls.Add(this.tileLabel4, 0, 0);
            this.sTile3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile3.Location = new System.Drawing.Point(550, 10);
            this.sTile3.Margin = new System.Windows.Forms.Padding(10);
            this.sTile3.Name = "sTile3";
            this.sTile3.RowCount = 5;
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85619F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14381F));
            this.sTile3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile3.Size = new System.Drawing.Size(160, 145);
            this.sTile3.TabIndex = 12;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Location = new System.Drawing.Point(3, 121);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 21);
            this.button6.TabIndex = 15;
            this.button6.Text = "AVERAGE";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // label4_
            // 
            this.label4_.AutoSize = true;
            this.label4_.BackColor = System.Drawing.SystemColors.Control;
            this.label4_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4_.Location = new System.Drawing.Point(3, 81);
            this.label4_.Name = "label4_";
            this.label4_.Size = new System.Drawing.Size(154, 36);
            this.label4_.TabIndex = 13;
            this.label4_.Text = "0.0";
            this.label4_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(3, 66);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(154, 15);
            this.label24.TabIndex = 11;
            this.label24.Text = "CURRENT";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "0.0";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.sTile5.Controls.Add(this.label6_, 0, 3);
            this.sTile5.Controls.Add(this.label26, 0, 2);
            this.sTile5.Controls.Add(this.label6, 0, 1);
            this.sTile5.Controls.Add(this.tileLabel6, 0, 0);
            this.sTile5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile5.Location = new System.Drawing.Point(10, 175);
            this.sTile5.Margin = new System.Windows.Forms.Padding(10);
            this.sTile5.Name = "sTile5";
            this.sTile5.RowCount = 5;
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85619F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14381F));
            this.sTile5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile5.Size = new System.Drawing.Size(160, 147);
            this.sTile5.TabIndex = 11;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Transparent;
            this.button8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Location = new System.Drawing.Point(3, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(154, 22);
            this.button8.TabIndex = 17;
            this.button8.Text = "AVERAGE";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // label6_
            // 
            this.label6_.AutoSize = true;
            this.label6_.BackColor = System.Drawing.SystemColors.Control;
            this.label6_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6_.Location = new System.Drawing.Point(3, 81);
            this.label6_.Name = "label6_";
            this.label6_.Size = new System.Drawing.Size(154, 37);
            this.label6_.TabIndex = 15;
            this.label6_.Text = "0.0";
            this.label6_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(3, 66);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(154, 15);
            this.label26.TabIndex = 13;
            this.label26.Text = "CURRENT";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 35);
            this.label6.TabIndex = 14;
            this.label6.Text = "0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // hTile1
            // 
            this.hTile1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hTile1.ColumnCount = 4;
            this.tableLayoutPanel1.SetColumnSpan(this.hTile1, 2);
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.hTile1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.hTile1.ContextMenuStrip = this.tilePopUpMenu;
            this.hTile1.Controls.Add(this.label12, 0, 1);
            this.hTile1.Controls.Add(this.label12_, 3, 1);
            this.hTile1.Controls.Add(this.button1, 1, 2);
            this.hTile1.Controls.Add(this.rLabel2, 1, 1);
            this.hTile1.Controls.Add(this.tileLabel12, 0, 0);
            this.hTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hTile1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hTile1.Location = new System.Drawing.Point(543, 335);
            this.hTile1.Name = "hTile1";
            this.hTile1.RowCount = 3;
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hTile1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.hTile1.Size = new System.Drawing.Size(354, 113);
            this.hTile1.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1, 32);
            this.label12.Margin = new System.Windows.Forms.Padding(1);
            this.label12.Name = "label12";
            this.hTile1.SetRowSpan(this.label12, 2);
            this.label12.Size = new System.Drawing.Size(97, 80);
            this.label12.TabIndex = 7;
            this.label12.Text = "0.0";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12_
            // 
            this.label12_.AutoSize = true;
            this.label12_.BackColor = System.Drawing.SystemColors.Control;
            this.label12_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12_.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12_.Location = new System.Drawing.Point(254, 32);
            this.label12_.Margin = new System.Windows.Forms.Padding(1);
            this.label12_.Name = "label12_";
            this.hTile1.SetRowSpan(this.label12_, 2);
            this.label12_.Size = new System.Drawing.Size(99, 80);
            this.label12_.TabIndex = 6;
            this.label12_.Text = "0.0";
            this.label12_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.hTile1.SetColumnSpan(this.button1, 2);
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(102, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "RESET AVERAGE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // rLabel2
            // 
            this.rLabel2.AutoSize = true;
            this.hTile1.SetColumnSpan(this.rLabel2, 2);
            this.rLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rLabel2.Location = new System.Drawing.Point(102, 31);
            this.rLabel2.Name = "rLabel2";
            this.rLabel2.Size = new System.Drawing.Size(148, 53);
            this.rLabel2.TabIndex = 9;
            this.rLabel2.Text = "g/bhp-hr";
            this.rLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tileLabel12
            // 
            this.tileLabel12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tileLabel12.AutoSize = true;
            this.hTile1.SetColumnSpan(this.tileLabel12, 4);
            this.tileLabel12.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileLabel12.Location = new System.Drawing.Point(3, 0);
            this.tileLabel12.Name = "tileLabel12";
            this.tileLabel12.Size = new System.Drawing.Size(348, 31);
            this.tileLabel12.TabIndex = 0;
            this.tileLabel12.Text = "NOx(mass)";
            this.tileLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sTile0
            // 
            this.sTile0.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sTile0.ColumnCount = 1;
            this.sTile0.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sTile0.ContextMenuStrip = this.tilePopUpMenu;
            this.sTile0.Controls.Add(this.label1_, 0, 3);
            this.sTile0.Controls.Add(this.label21, 0, 2);
            this.sTile0.Controls.Add(this.label1, 0, 1);
            this.sTile0.Controls.Add(this.tileLabel1, 0, 0);
            this.sTile0.Controls.Add(this.button3, 0, 4);
            this.sTile0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sTile0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sTile0.Location = new System.Drawing.Point(10, 10);
            this.sTile0.Margin = new System.Windows.Forms.Padding(10);
            this.sTile0.Name = "sTile0";
            this.sTile0.RowCount = 5;
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.85116F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.14884F));
            this.sTile0.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.sTile0.Size = new System.Drawing.Size(160, 145);
            this.sTile0.TabIndex = 14;
            // 
            // label1_
            // 
            this.label1_.AutoSize = true;
            this.label1_.BackColor = System.Drawing.SystemColors.Control;
            this.label1_.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1_.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1_.Location = new System.Drawing.Point(3, 81);
            this.label1_.Name = "label1_";
            this.label1_.Size = new System.Drawing.Size(154, 36);
            this.label1_.TabIndex = 10;
            this.label1_.Text = "0.0";
            this.label1_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(3, 66);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(154, 15);
            this.label21.TabIndex = 8;
            this.label21.Text = "CURRENT";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 35);
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
            this.button3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(3, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 21);
            this.button3.TabIndex = 12;
            this.button3.Text = "AVERAGE";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel11.Controls.Add(this.progressBar1, 0, 4);
            this.tableLayoutPanel11.Controls.Add(this.button13, 0, 5);
            this.tableLayoutPanel11.Controls.Add(this.cycleLabel, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.rTimelbl, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.tTimelbl, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.pTimelbl, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.plbl, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.tlbl, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.rlbl, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(363, 335);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 6;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel11.Size = new System.Drawing.Size(174, 113);
            this.tableLayoutPanel11.TabIndex = 25;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel11.SetColumnSpan(this.progressBar1, 2);
            this.progressBar1.Location = new System.Drawing.Point(25, 66);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(124, 13);
            this.progressBar1.TabIndex = 8;
            // 
            // button13
            // 
            this.tableLayoutPanel11.SetColumnSpan(this.button13, 2);
            this.button13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button13.Location = new System.Drawing.Point(3, 87);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(168, 23);
            this.button13.TabIndex = 25;
            this.button13.Text = "Reset All Averages";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // cycleLabel
            // 
            this.cycleLabel.AutoSize = true;
            this.tableLayoutPanel11.SetColumnSpan(this.cycleLabel, 2);
            this.cycleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleLabel.Location = new System.Drawing.Point(3, 0);
            this.cycleLabel.Name = "cycleLabel";
            this.cycleLabel.Size = new System.Drawing.Size(168, 13);
            this.cycleLabel.TabIndex = 1;
            this.cycleLabel.Text = "Cycle: 1";
            this.cycleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rTimelbl
            // 
            this.rTimelbl.AutoSize = true;
            this.rTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTimelbl.Location = new System.Drawing.Point(90, 13);
            this.rTimelbl.Name = "rTimelbl";
            this.rTimelbl.Size = new System.Drawing.Size(81, 16);
            this.rTimelbl.TabIndex = 26;
            this.rTimelbl.Text = "00:00:00";
            this.rTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tTimelbl
            // 
            this.tTimelbl.AutoSize = true;
            this.tTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTimelbl.Location = new System.Drawing.Point(90, 29);
            this.tTimelbl.Name = "tTimelbl";
            this.tTimelbl.Size = new System.Drawing.Size(81, 16);
            this.tTimelbl.TabIndex = 27;
            this.tTimelbl.Text = "00:00:00";
            this.tTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pTimelbl
            // 
            this.pTimelbl.AutoSize = true;
            this.pTimelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTimelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pTimelbl.Location = new System.Drawing.Point(90, 45);
            this.pTimelbl.Name = "pTimelbl";
            this.pTimelbl.Size = new System.Drawing.Size(81, 16);
            this.pTimelbl.TabIndex = 28;
            this.pTimelbl.Text = "00:00:00";
            this.pTimelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plbl
            // 
            this.plbl.AutoSize = true;
            this.plbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plbl.Location = new System.Drawing.Point(3, 45);
            this.plbl.Name = "plbl";
            this.plbl.Size = new System.Drawing.Size(81, 16);
            this.plbl.TabIndex = 23;
            this.plbl.Text = "Purge:";
            this.plbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tlbl
            // 
            this.tlbl.AutoSize = true;
            this.tlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlbl.Location = new System.Drawing.Point(3, 29);
            this.tlbl.Name = "tlbl";
            this.tlbl.Size = new System.Drawing.Size(81, 16);
            this.tlbl.TabIndex = 4;
            this.tlbl.Text = "Test:";
            this.tlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rlbl
            // 
            this.rlbl.AutoSize = true;
            this.rlbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rlbl.Location = new System.Drawing.Point(3, 13);
            this.rlbl.Name = "rlbl";
            this.rlbl.Size = new System.Drawing.Size(81, 16);
            this.rlbl.TabIndex = 2;
            this.rlbl.Text = "Ramp Up:";
            this.rlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            chartArea13.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea13.AxisY.ScaleBreakStyle.BreakLineStyle = System.Windows.Forms.DataVisualization.Charting.BreakLineStyle.Wave;
            chartArea13.AxisY.ScaleBreakStyle.CollapsibleSpaceThreshold = 10;
            chartArea13.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea13.AxisY.ScaleBreakStyle.MaxNumberOfBreaks = 1;
            chartArea13.AxisY.ScaleBreakStyle.Spacing = 10D;
            chartArea13.Name = "ChartArea1";
            this.trendGraph.ChartAreas.Add(chartArea13);
            this.trendGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Name = "Legend1";
            this.trendGraph.Legends.Add(legend13);
            this.trendGraph.Location = new System.Drawing.Point(279, 0);
            this.trendGraph.Margin = new System.Windows.Forms.Padding(0);
            this.trendGraph.Name = "trendGraph";
            this.trendGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series205.ChartArea = "ChartArea1";
            series205.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series205.Legend = "Legend1";
            series205.Name = "O2";
            series205.Points.Add(dataPoint223);
            series205.Points.Add(dataPoint224);
            series205.Points.Add(dataPoint225);
            series205.Points.Add(dataPoint226);
            series205.Points.Add(dataPoint227);
            series206.ChartArea = "ChartArea1";
            series206.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series206.Legend = "Legend1";
            series206.Name = "CO";
            series206.Points.Add(dataPoint228);
            series206.Points.Add(dataPoint229);
            series206.Points.Add(dataPoint230);
            series206.Points.Add(dataPoint231);
            series206.Points.Add(dataPoint232);
            series207.ChartArea = "ChartArea1";
            series207.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series207.Legend = "Legend1";
            series207.Name = "CO2";
            series208.ChartArea = "ChartArea1";
            series208.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series208.Legend = "Legend1";
            series208.Name = "NO";
            series209.ChartArea = "ChartArea1";
            series209.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series209.Legend = "Legend1";
            series209.Name = "NO2";
            series210.ChartArea = "ChartArea1";
            series210.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series210.Legend = "Legend1";
            series210.Name = "NOx";
            series210.Points.Add(dataPoint233);
            series210.Points.Add(dataPoint234);
            series210.Points.Add(dataPoint235);
            series210.Points.Add(dataPoint236);
            series210.Points.Add(dataPoint237);
            series210.YValueMembers = "Tag";
            series211.ChartArea = "ChartArea1";
            series211.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series211.Legend = "Legend1";
            series211.Name = "SO2";
            series212.ChartArea = "ChartArea1";
            series212.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series212.Legend = "Legend1";
            series212.Name = "CxHy";
            series213.ChartArea = "ChartArea1";
            series213.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series213.Legend = "Legend1";
            series213.Name = "T(gas)";
            series213.Points.Add(dataPoint238);
            series213.Points.Add(dataPoint239);
            series213.Points.Add(dataPoint240);
            series213.Points.Add(dataPoint241);
            series213.Points.Add(dataPoint242);
            series214.ChartArea = "ChartArea1";
            series214.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series214.Legend = "Legend1";
            series214.Name = "T(amb)";
            series214.Points.Add(dataPoint243);
            series214.Points.Add(dataPoint244);
            series214.Points.Add(dataPoint245);
            series214.Points.Add(dataPoint246);
            series214.Points.Add(dataPoint247);
            series215.ChartArea = "ChartArea1";
            series215.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series215.Legend = "Legend1";
            series215.Name = "T(cell)";
            series216.ChartArea = "ChartArea1";
            series216.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series216.Legend = "Legend1";
            series216.Name = "Efficiency";
            series217.ChartArea = "ChartArea1";
            series217.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series217.Legend = "Legend1";
            series217.Name = "I.Flow";
            series218.ChartArea = "ChartArea1";
            series218.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series218.Legend = "Legend1";
            series218.Name = "Draft";
            series219.ChartArea = "ChartArea1";
            series219.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series219.Legend = "Legend1";
            series219.Name = "Losses";
            series220.ChartArea = "ChartArea1";
            series220.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series220.Legend = "Legend1";
            series220.Name = "Excess Air";
            series221.ChartArea = "ChartArea1";
            series221.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series221.Legend = "Legend1";
            series221.Name = "CO(mass)";
            series222.ChartArea = "ChartArea1";
            series222.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series222.Legend = "Legend1";
            series222.Name = "NOx(mass)";
            this.trendGraph.Series.Add(series205);
            this.trendGraph.Series.Add(series206);
            this.trendGraph.Series.Add(series207);
            this.trendGraph.Series.Add(series208);
            this.trendGraph.Series.Add(series209);
            this.trendGraph.Series.Add(series210);
            this.trendGraph.Series.Add(series211);
            this.trendGraph.Series.Add(series212);
            this.trendGraph.Series.Add(series213);
            this.trendGraph.Series.Add(series214);
            this.trendGraph.Series.Add(series215);
            this.trendGraph.Series.Add(series216);
            this.trendGraph.Series.Add(series217);
            this.trendGraph.Series.Add(series218);
            this.trendGraph.Series.Add(series219);
            this.trendGraph.Series.Add(series220);
            this.trendGraph.Series.Add(series221);
            this.trendGraph.Series.Add(series222);
            this.trendGraph.Size = new System.Drawing.Size(621, 449);
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
            this.elementTable.Size = new System.Drawing.Size(272, 392);
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
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.85661F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.73301F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.58061F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.82977F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(900, 451);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel15.Controls.Add(this.label19, 0, 2);
            this.tableLayoutPanel15.Controls.Add(this.panel5, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.label54, 0, 1);
            this.tableLayoutPanel15.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(320, 224);
            this.tableLayoutPanel15.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 3;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel15.Size = new System.Drawing.Size(135, 90);
            this.tableLayoutPanel15.TabIndex = 14;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 75);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(129, 15);
            this.label19.TabIndex = 13;
            this.label19.Text = "CURRENT";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
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
            this.label54.BackColor = System.Drawing.SystemColors.Control;
            this.label54.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label54.Location = new System.Drawing.Point(3, 31);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(129, 44);
            this.label54.TabIndex = 14;
            this.label54.Text = "0.0";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel6.Controls.Add(this.label17, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.label53, 0, 1);
            this.tableLayoutPanel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(165, 224);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(135, 90);
            this.tableLayoutPanel6.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(3, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(129, 15);
            this.label17.TabIndex = 13;
            this.label17.Text = "CURRENT";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
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
            this.label53.BackColor = System.Drawing.SystemColors.Control;
            this.label53.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(3, 31);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(129, 44);
            this.label53.TabIndex = 14;
            this.label53.Text = "0.0";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel5.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 1);
            this.tableLayoutPanel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(10, 117);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(135, 87);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 15);
            this.label15.TabIndex = 13;
            this.label15.Text = "CURRENT";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
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
            this.label44.BackColor = System.Drawing.SystemColors.Control;
            this.label44.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(3, 31);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(129, 41);
            this.label44.TabIndex = 14;
            this.label44.Text = "0.0";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel3.SetColumnSpan(this.panel13, 2);
            this.panel13.ContextMenuStrip = this.tilePopUpMenu;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(10, 334);
            this.panel13.Margin = new System.Windows.Forms.Padding(10);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(290, 107);
            this.panel13.TabIndex = 22;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(135, 87);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(3, 72);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(129, 15);
            this.label31.TabIndex = 10;
            this.label31.Text = "CURRENT";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
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
            this.label40.BackColor = System.Drawing.SystemColors.Control;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(3, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(129, 41);
            this.label40.TabIndex = 11;
            this.label40.Text = "0.0";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel7.Controls.Add(this.panel17, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.label42, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label49, 0, 1);
            this.tableLayoutPanel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(320, 117);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(135, 87);
            this.tableLayoutPanel7.TabIndex = 17;
            // 
            // panel17
            // 
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
            this.label42.Location = new System.Drawing.Point(3, 72);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(129, 15);
            this.label42.TabIndex = 15;
            this.label42.Text = "CURRENT";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.SystemColors.Control;
            this.label49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(3, 33);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(129, 39);
            this.label49.TabIndex = 16;
            this.label49.Text = "0.0";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel8.Controls.Add(this.label43, 0, 2);
            this.tableLayoutPanel8.Controls.Add(this.panel18, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.label46, 0, 1);
            this.tableLayoutPanel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(165, 117);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(135, 87);
            this.tableLayoutPanel8.TabIndex = 16;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label43.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(3, 72);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(129, 15);
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
            this.panel18.Size = new System.Drawing.Size(135, 33);
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
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.BackColor = System.Drawing.SystemColors.Control;
            this.label46.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(3, 33);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(129, 39);
            this.label46.TabIndex = 15;
            this.label46.Text = "0.0";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel9.Size = new System.Drawing.Size(135, 87);
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
            this.panel19.Size = new System.Drawing.Size(135, 31);
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
            this.label48.Location = new System.Drawing.Point(3, 72);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(129, 15);
            this.label48.TabIndex = 9;
            this.label48.Text = "CURRENT";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.SystemColors.Control;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(3, 31);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(129, 41);
            this.label32.TabIndex = 10;
            this.label32.Text = "0.0";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel10.Size = new System.Drawing.Size(135, 87);
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
            this.label51.Location = new System.Drawing.Point(35, 72);
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
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.Location = new System.Drawing.Point(3, 31);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(129, 41);
            this.label61.TabIndex = 9;
            this.label61.Text = "0.0";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chart1
            // 
            chartArea14.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea14.AxisY.ScaleBreakStyle.Enabled = true;
            chartArea14.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea14);
            this.tableLayoutPanel3.SetColumnSpan(this.chart1, 2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend14.Name = "Legend1";
            this.chart1.Legends.Add(legend14);
            this.chart1.Location = new System.Drawing.Point(468, 3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.tableLayoutPanel3.SetRowSpan(this.chart1, 4);
            series223.ChartArea = "ChartArea1";
            series223.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series223.Legend = "Legend1";
            series223.Name = "O2";
            series223.Points.Add(dataPoint248);
            series223.Points.Add(dataPoint249);
            series223.Points.Add(dataPoint250);
            series223.Points.Add(dataPoint251);
            series224.ChartArea = "ChartArea1";
            series224.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series224.Legend = "Legend1";
            series224.Name = "CO";
            series224.Points.Add(dataPoint252);
            series224.Points.Add(dataPoint253);
            series224.Points.Add(dataPoint254);
            series224.Points.Add(dataPoint255);
            series224.Points.Add(dataPoint256);
            series224.Points.Add(dataPoint257);
            series224.Points.Add(dataPoint258);
            series224.Points.Add(dataPoint259);
            series225.ChartArea = "ChartArea1";
            series225.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series225.Legend = "Legend1";
            series225.Name = "CO2";
            series226.ChartArea = "ChartArea1";
            series226.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series226.Legend = "Legend1";
            series226.Name = "NO";
            series227.ChartArea = "ChartArea1";
            series227.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series227.Legend = "Legend1";
            series227.Name = "NO2";
            series228.ChartArea = "ChartArea1";
            series228.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series228.Legend = "Legend1";
            series228.Name = "NOx";
            series228.YValueMembers = "Tag";
            series229.ChartArea = "ChartArea1";
            series229.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series229.Legend = "Legend1";
            series229.Name = "SO2";
            series230.ChartArea = "ChartArea1";
            series230.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series230.Legend = "Legend1";
            series230.Name = "CxHy";
            series231.ChartArea = "ChartArea1";
            series231.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series231.Legend = "Legend1";
            series231.Name = "T(gas)";
            series232.ChartArea = "ChartArea1";
            series232.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series232.Legend = "Legend1";
            series232.Name = "T(amb)";
            series233.ChartArea = "ChartArea1";
            series233.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series233.Legend = "Legend1";
            series233.Name = "Temp1";
            series234.ChartArea = "ChartArea1";
            series234.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series234.Legend = "Legend1";
            series234.Name = "Temp2";
            series235.ChartArea = "ChartArea1";
            series235.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series235.Legend = "Legend1";
            series235.Name = "T(cell)";
            series236.ChartArea = "ChartArea1";
            series236.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series236.Legend = "Legend1";
            series236.Name = "Efficiency";
            series237.ChartArea = "ChartArea1";
            series237.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series237.Legend = "Legend1";
            series237.Name = "Flow";
            series238.ChartArea = "ChartArea1";
            series238.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series238.Legend = "Legend1";
            series238.Name = "NH3";
            this.chart1.Series.Add(series223);
            this.chart1.Series.Add(series224);
            this.chart1.Series.Add(series225);
            this.chart1.Series.Add(series226);
            this.chart1.Series.Add(series227);
            this.chart1.Series.Add(series228);
            this.chart1.Series.Add(series229);
            this.chart1.Series.Add(series230);
            this.chart1.Series.Add(series231);
            this.chart1.Series.Add(series232);
            this.chart1.Series.Add(series233);
            this.chart1.Series.Add(series234);
            this.chart1.Series.Add(series235);
            this.chart1.Series.Add(series236);
            this.chart1.Series.Add(series237);
            this.chart1.Series.Add(series238);
            this.chart1.Size = new System.Drawing.Size(429, 445);
            this.chart1.TabIndex = 23;
            this.chart1.Text = "chart1";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ContextMenuStrip = this.tilePopUpMenu;
            this.tableLayoutPanel13.Controls.Add(this.label59, 0, 2);
            this.tableLayoutPanel13.Controls.Add(this.panel23, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.label52, 0, 1);
            this.tableLayoutPanel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(10, 224);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 3;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel13.Size = new System.Drawing.Size(135, 90);
            this.tableLayoutPanel13.TabIndex = 11;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label59.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(3, 75);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(129, 15);
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
            this.panel23.Size = new System.Drawing.Size(135, 31);
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
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.SystemColors.Control;
            this.label52.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(3, 31);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(129, 44);
            this.label52.TabIndex = 14;
            this.label52.Text = "0.0";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage4.BackgroundImage")));
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.shapeContainer2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(906, 457);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Analyzer Control";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Location = new System.Drawing.Point(432, 184);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(75, 23);
            this.button16.TabIndex = 1;
            this.button16.Text = "Start Pump";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.Location = new System.Drawing.Point(496, 83);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(75, 23);
            this.button15.TabIndex = 0;
            this.button15.Text = "Beep";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.Transparent;
            this.panel12.Controls.Add(this.recordingSign);
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
            // recordingSign
            // 
            this.recordingSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.recordingSign.Image = ((System.Drawing.Image)(resources.GetObject("recordingSign.Image")));
            this.recordingSign.Location = new System.Drawing.Point(827, 4);
            this.recordingSign.Margin = new System.Windows.Forms.Padding(0);
            this.recordingSign.Name = "recordingSign";
            this.recordingSign.Size = new System.Drawing.Size(83, 34);
            this.recordingSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.recordingSign.TabIndex = 8;
            this.recordingSign.TabStop = false;
            this.recordingSign.Visible = false;
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
            // recordSign
            // 
            this.recordSign.Interval = 500;
            this.recordSign.Tick += new System.EventHandler(this.recordSign_Tick);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textColorToolStripMenuItem,
            this.tileBackGroundColorToolStripMenuItem,
            this.backGroundColorToolStripMenuItem,
            this.resetColorToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // textColorToolStripMenuItem
            // 
            this.textColorToolStripMenuItem.Name = "textColorToolStripMenuItem";
            this.textColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.textColorToolStripMenuItem.Text = "Text Color";
            // 
            // tileBackGroundColorToolStripMenuItem
            // 
            this.tileBackGroundColorToolStripMenuItem.Name = "tileBackGroundColorToolStripMenuItem";
            this.tileBackGroundColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.tileBackGroundColorToolStripMenuItem.Text = "Tile Color";
            // 
            // backGroundColorToolStripMenuItem
            // 
            this.backGroundColorToolStripMenuItem.Name = "backGroundColorToolStripMenuItem";
            this.backGroundColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.backGroundColorToolStripMenuItem.Text = "BackGround Color";
            // 
            // resetColorToolStripMenuItem
            // 
            this.resetColorToolStripMenuItem.Name = "resetColorToolStripMenuItem";
            this.resetColorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.resetColorToolStripMenuItem.Text = "Reset Color";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(153, 6);
            // 
            // instrumentToolStripMenuItem
            // 
            this.instrumentToolStripMenuItem.Name = "instrumentToolStripMenuItem";
            this.instrumentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.instrumentToolStripMenuItem.Text = "Instrument";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(900, 451);
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
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 3);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(900, 451);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 527;
            this.lineShape2.X2 = 339;
            this.lineShape2.Y1 = 99;
            this.lineShape2.Y2 = 204;
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
        private TableLayoutPanel hTile1;
        private TableLayoutPanel hTile0;
        private Label tileLabel11;
        private Label tileLabel12;
        private Label label11;
        private Label label11_;
        private Label label12_;
        private Label label12;
        private System.Windows.Forms.Timer dataGridTimer;
        private Label label61;
        public ToolStripStatusLabel recordTimeLabel;
        private Label label2_;
        private Label label2;
        private Label label1_;
        private Label label1;
        private Label label3_;
        private Label label3;
        private Label label10_;
        private Label label10;
        private Label label9_;
        private Label label9;
        private Label label8_;
        private Label label8;
        private Label label7_;
        private Label label7;
        private Label label5_;
        private Label label5;
        private Label label4_;
        private Label label4;
        private Label label6_;
        private Label label6;
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
        private Button button1;
        public Label rLabel2;
        private Button button14;
        private Label rLabel1;
        private PictureBox recordingSign;
        private Button button15;
        private Button button16;
        private System.Windows.Forms.Timer recordSign;
        private ToolStripMenuItem instrumentToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem themeToolStripMenuItem;
        private ToolStripMenuItem textColorToolStripMenuItem;
        private ToolStripMenuItem tileBackGroundColorToolStripMenuItem;
        private ToolStripMenuItem backGroundColorToolStripMenuItem;
        private ToolStripMenuItem resetColorToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;


    }
}

