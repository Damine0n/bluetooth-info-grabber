namespace CRS
{
    partial class ScaleDisplay
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScaleDisplay));
            this.elementComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataSource = new System.Windows.Forms.GroupBox();
            this.currentValues = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.recordingSelection = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.dataSource.SuspendLayout();
            this.currentValues.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.recordingSelection.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // elementComboBox
            // 
            this.elementComboBox.FormattingEnabled = true;
            this.elementComboBox.Items.AddRange(new object[] {
            "Do Not Display",
            "O2",
            "CO",
            "CO - Correction",
            "CO2",
            "NO",
            "NO - Correction",
            "NO2",
            "NO2 - Correction",
            "NOx",
            "NOx - Correction",
            "SO2",
            "SO2 - Correction",
            "CxHy",
            "CxHy - Correction",
            "T(gas)",
            "T(amb)",
            "Temp 1 ?",
            "Temp 2 ?",
            "T(cell)",
            "Efficiency",
            "Flow",
            "NH3"});
            this.elementComboBox.Location = new System.Drawing.Point(6, 19);
            this.elementComboBox.Name = "elementComboBox";
            this.elementComboBox.Size = new System.Drawing.Size(208, 21);
            this.elementComboBox.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.28675F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.71325F));
            this.tableLayoutPanel1.Controls.Add(this.dataSource, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.currentValues, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.recordingSelection, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox7, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.56051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.92994F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.6051F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.5414F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 314);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataSource
            // 
            this.dataSource.Controls.Add(this.elementComboBox);
            this.dataSource.Location = new System.Drawing.Point(3, 3);
            this.dataSource.Name = "dataSource";
            this.dataSource.Size = new System.Drawing.Size(220, 45);
            this.dataSource.TabIndex = 3;
            this.dataSource.TabStop = false;
            this.dataSource.Text = "Select Data Source";
            // 
            // currentValues
            // 
            this.currentValues.Controls.Add(this.label2);
            this.currentValues.Controls.Add(this.label1);
            this.currentValues.Location = new System.Drawing.Point(3, 54);
            this.currentValues.Name = "currentValues";
            this.currentValues.Size = new System.Drawing.Size(220, 62);
            this.currentValues.TabIndex = 5;
            this.currentValues.TabStop = false;
            this.currentValues.Text = "Current Values";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Average =   ppm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Value     =   ppm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(235, 3);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 4);
            this.panel1.Size = new System.Drawing.Size(313, 308);
            this.panel1.TabIndex = 11;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Green;
            series1.Name = "cValue";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Blue;
            series2.Name = "cAverage";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(313, 308);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "From (startTime) to Now Fix Later";
            this.chart1.Titles.Add(title1);
            // 
            // recordingSelection
            // 
            this.recordingSelection.Controls.Add(this.checkBox1);
            this.recordingSelection.Location = new System.Drawing.Point(3, 125);
            this.recordingSelection.Name = "recordingSelection";
            this.recordingSelection.Size = new System.Drawing.Size(220, 42);
            this.recordingSelection.TabIndex = 6;
            this.recordingSelection.TabStop = false;
            this.recordingSelection.Text = "Recording Selection";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(180, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Include Signal In Recorded File?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(3, 173);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(224, 127);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "LEGEND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(39, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 33);
            this.label4.TabIndex = 1;
            this.label4.Text = "AVERAGE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(39, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "VALUE";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(355, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(464, 320);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "ACCEPT";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ScaleDisplay
            // 
            this.AcceptButton = this.btnAccept;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(551, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScaleDisplay";
            this.Text = "Scale Display";
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.ScaleDisplay_HelpButtonClicked);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.dataSource.ResumeLayout(false);
            this.currentValues.ResumeLayout(false);
            this.currentValues.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.recordingSelection.ResumeLayout(false);
            this.recordingSelection.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ComboBox elementComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox dataSource;
        private System.Windows.Forms.GroupBox currentValues;
        private System.Windows.Forms.GroupBox recordingSelection;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        
    }
}