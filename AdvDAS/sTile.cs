using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Microsoft.VisualBasic;

namespace CRS
{
    public partial class ScaleDisplay : Form
    {
        public Control source;
        private Label lbl1, lbl2;
        public Button btn;
        private int index;
        private List<double> nums = new List<double>();
        string average;
        public static double correction;
        public J2KNProtocol protocol = new J2KNProtocol();
        DateTime now;

        public ScaleDisplay(Tuple<Label, Label, Button> tuple)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl1 = tuple.Item1;
            this.lbl2 = tuple.Item2;
            this.btn = tuple.Item3;
            if (protocol.processProtocol())
            {
                timer1.Start();
            }
        }
        public int Index
        {
            get { return index; }
            set { index = value; }
        }
        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.lbl1.Text = elementComboBox.Text;
            this.lbl2.Text = valLabel.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            elementComboBox.SelectedIndex = index;
            this.DialogResult = DialogResult.Cancel;
        }

        private void elementComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (protocol.processProtocol().Equals(true))
            {
                protocol.processProtocol();
                protocol.processProtocol("$0A0531");
                protocol.processProtocol("$0A054E");
            }
            switch (elementComboBox.SelectedIndex)
            {
                case 0:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vO2;

                    this.lbl2.Text = protocol.vO2;
                    break;
                case 1:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCO;

                    this.lbl2.Text = protocol.vCO;
                    break;
                case 2:
                    this.lbl1.Text = elementComboBox.Text;
                    string CO_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
                    if (!CO_C.Equals(""))
                    {
                        correction = Convert.ToDouble(CO_C);
                        protocol.populateCorrection(1, correction);
                    }
                    else
                        protocol.populateCorrection(1, 0);
                    valLabel.Text = protocol.tempvCO_C;

                    this.lbl2.Text = protocol.vCO_C;
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCO2;

                    this.lbl2.Text = protocol.vCO2;
                    break;
                case 8:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO;

                    this.lbl2.Text = protocol.vNO;
                    break;
                case 9:
                    this.lbl1.Text = elementComboBox.Text;
                    string NO_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
                    if (!NO_C.Equals(""))
                    {
                        correction = Convert.ToDouble(NO_C);
                        protocol.populateCorrection(2, correction);
                    }
                    else
                        protocol.populateCorrection(2, 0);
                    valLabel.Text = protocol.vNO_C;

                    this.lbl2.Text = protocol.vNO_C;
                    break;
                case 10:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO2;

                    this.lbl2.Text = protocol.vNO2;
                    break;
                case 11:
                    this.lbl1.Text = elementComboBox.Text;
                    string NO2_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
                    if (!NO2_C.Equals(""))
                    {
                        correction = Convert.ToDouble(NO2_C);
                        protocol.populateCorrection(3, correction);
                    }
                    else
                        protocol.populateCorrection(3, 0);
                    valLabel.Text = protocol.vNO2_C;

                    this.lbl2.Text = protocol.vNO2_C;
                    break;
                case 12:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNOx;

                    this.lbl2.Text = protocol.vNOx;
                    break;
                case 13:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNOx_C;
                    string NOx_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
                    if (!NOx_C.Equals(""))
                    {
                        correction = Convert.ToDouble(NOx_C);
                        protocol.populateCorrection(4, correction);
                    }
                    else
                        protocol.populateCorrection(4, 0);
                    this.lbl2.Text = protocol.vNOx_C;
                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vSO2;

                    this.lbl2.Text = protocol.vSO2;
                    break;
                case 19:
                    this.lbl1.Text = elementComboBox.Text;
                    string SO2_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");
                    if (!SO2_C.Equals(""))
                    {
                        correction = Convert.ToDouble(SO2_C);
                        protocol.populateCorrection(5, correction);
                    }
                    else
                        protocol.populateCorrection(5, 0);
                    valLabel.Text = protocol.vSO2_C;
                    this.lbl2.Text = protocol.vSO2_C;
                    break;
                case 20:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCxHy;

                    this.lbl2.Text = protocol.vCxHy;
                    break;
                case 21:
                    this.lbl1.Text = elementComboBox.Text;
                    string CxHy_C = Microsoft.VisualBasic.Interaction.InputBox("Enter the percentage number for O2 Correction. ", "O2 Correction");

                    if (!CxHy_C.Equals(""))
                    {
                        correction = Convert.ToDouble(CxHy_C);
                        protocol.populateCorrection(6, correction);
                    }
                    else
                        protocol.populateCorrection(6, 0);
                    valLabel.Text = protocol.vCxHy_C;

                    this.lbl2.Text = protocol.vCxHy_C;
                    break;
                case 22:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTgas;

                    this.lbl2.Text = protocol.vTgas;
                    break;
                case 23:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTamb;

                    this.lbl2.Text = protocol.vTamb;
                    break;
                case 24:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTcell;

                    this.lbl2.Text = protocol.vTcell;
                    break;
                case 25:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vEfficiency;

                    this.lbl2.Text = protocol.vEfficiency;
                    break;
                case 26:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vIFlow;

                    this.lbl2.Text = protocol.vIFlow;
                    break;
                case 27:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vDraft;

                    this.lbl2.Text = protocol.vDraft;
                    break;
                case 28:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vLosses;

                    this.lbl2.Text = protocol.vLosses;
                    break;
                case 29:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vExcessAir;
                    this.lbl2.Text = protocol.vExcessAir;
                    break;
            }
            resetAverage();
            try
            {
                nums.Add(Convert.ToDouble(valLabel.Text));
                average = nums.Average().ToString("0.0");
                aveLabel.Text = average;
                btn.Text = average + " AVG";
                chart1.Titles[0].Text=DateTime.Now.ToString("HH:mm:ss");
            }
            catch (Exception)
            {
                resetAverage();
            }
            
        }

        public void resetAverage()
        {
            nums.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            protocol.processProtocol();
            protocol.processProtocol("$0A0531");
            protocol.processProtocol("$0A054E");
            protocol.populateCorrection(correction);
            now = DateTime.Now;
            switch (elementComboBox.SelectedIndex)
            {
                case 0:
                    valLabel.Text = protocol.vO2;

                    break;
                case 1:
                    valLabel.Text = protocol.vCO;

                    break;
                case 2:
                    valLabel.Text = protocol.vCO_C;

                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    valLabel.Text = protocol.vCO2;

                    break;
                case 8:
                    valLabel.Text = protocol.vNO;

                    break;
                case 9:

                    valLabel.Text = protocol.vNO_C;
                    break;
                case 10:
                    valLabel.Text = protocol.vNO2;

                    break;
                case 11:

                    valLabel.Text = protocol.vNO2_C;

                    break;
                case 12:
                    valLabel.Text = protocol.vNOx;

                    break;
                case 13:
                    valLabel.Text = protocol.vNOx_C;

                    break;
                case 14:
                    break;
                case 15:
                    break;
                case 16:
                    break;
                case 17:
                    break;
                case 18:

                    valLabel.Text = protocol.vSO2;

                    break;
                case 19:

                    valLabel.Text = protocol.vSO2_C;

                    break;
                case 20:
                    valLabel.Text = protocol.vCxHy;

                    break;
                case 21:
                    valLabel.Text = protocol.vCxHy_C;

                    break;
                case 22:
                    valLabel.Text = protocol.vTgas;

                    break;
                case 23:
                    valLabel.Text = protocol.vTamb;

                    break;
                case 24:
                    valLabel.Text = protocol.vTcell;

                    break;
                case 25:
                    valLabel.Text = protocol.vEfficiency;

                    break;
                case 26:
                    valLabel.Text = protocol.vIFlow;

                    break;
                case 27:
                    valLabel.Text = protocol.vDraft;

                    break;
                case 28:
                    valLabel.Text = protocol.vLosses;

                    break;
                case 29:
                    valLabel.Text = protocol.vExcessAir;
                    break;
            }
            try
            {
                this.lbl2.Text = valLabel.Text;
                nums.Add(Convert.ToDouble(valLabel.Text));
                average = nums.Average().ToString("0.0");
                aveLabel.Text = average;
                this.btn.Text = average + " AVG";
                chartIt(valLabel.Text, average);
            }
            catch (Exception ex)
            {
            }
        }

        private void chartIt(string data1, string data2)
        {
            chart1.Series[0].Points.AddY(data1);
            //int num=Convert.ToInt32(data) * 2;
            //MessageBox.Show(num.ToString());
            //data = num.ToString();
            chart1.Series[1].Points.AddY(data2);
        }

        private void elementComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
        }
    }
}
