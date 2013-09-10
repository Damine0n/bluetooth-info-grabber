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

namespace CRS
{
    public partial class ScaleDisplay : Form
    {
        public Control source;
        private Label lbl1,lbl2;
        public Button btn;
        private int index;
        private List<double> nums = new List<double>();
        string average;
        public J2KNProtocol protocol = new J2KNProtocol();

        public ScaleDisplay(Tuple<Label, Label, Button> tuple)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.lbl1 = tuple.Item1;
            this.lbl2 = tuple.Item2;
            this.btn = tuple.Item3;
            timer1.Start();
            
            
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
            resetAverage();
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
            timer1.Interval = MainMenu.dgInterval;
            switch (elementComboBox.SelectedIndex)
            {
                case 0:
                    nums.Add(Convert.ToDouble(protocol.vO2));
                    average = nums.Average().ToString("0.0");
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vO2;
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vO2;
                    break;
                case 1:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCO;
                    nums.Add(Convert.ToDouble(protocol.vCO));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vCO;
                    break;
                case 2:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCO;
                    nums.Add(Convert.ToDouble(protocol.vCO));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vCO;
                    break;
                case 3:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCO2;
                    nums.Add(Convert.ToDouble(protocol.vCO2));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vCO2;
                    break;
                case 4:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO;
                    nums.Add(Convert.ToDouble(protocol.vNO));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNO;
                    break;
                case 5:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO;
                    nums.Add(Convert.ToDouble(protocol.vNO));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNO;
                    break;
                case 6:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO2;
                    nums.Add(Convert.ToDouble(protocol.vNO2));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNO2;
                    break;
                case 7:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNO2;
                    nums.Add(Convert.ToDouble(protocol.vNO2));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNO2;
                    break;
                case 8:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNOx;
                    nums.Add(Convert.ToDouble(protocol.vNOx));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNOx;
                    break;
                case 9:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vNOx;
                    nums.Add(Convert.ToDouble(protocol.vNOx));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vNOx;
                    break;
                case 10:
                    this.lbl1.Text = elementComboBox.Text;
                    nums.Add(Convert.ToDouble(protocol.vSO2));
                    average = nums.Average().ToString("0.0");
                    valLabel.Text = protocol.vSO2;
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vSO2;
                    break;
                case 11:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vSO2;
                    nums.Add(Convert.ToDouble(protocol.vSO2));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    this.lbl2.Text = protocol.vSO2;
                    break;
                case 12:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCxHy;
                    nums.Add(Convert.ToDouble(protocol.vCxHy));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vCxHy;
                    break;
                case 13:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vCxHy;
                    nums.Add(Convert.ToDouble(protocol.vCxHy));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vCxHy;
                    break;
                case 14:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTgas;
                    nums.Add(Convert.ToDouble(protocol.vTgas));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vTgas;
                    break;
                case 15:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTamb;
                    nums.Add(Convert.ToDouble(protocol.vTamb));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vTamb;
                    break;
                case 16:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vTcell;
                    nums.Add(Convert.ToDouble(protocol.vTcell));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vTcell;
                    break;
                case 17:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vEfficiency;
                    nums.Add(Convert.ToDouble(protocol.vEfficiency));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vEfficiency;
                    break;
                case 18:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vIFlow;
                    nums.Add(Convert.ToDouble(protocol.vIFlow));
                    average = nums.Average().ToString("0.00");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vIFlow;
                    break;
                case 19:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vDraft;
                    nums.Add(Convert.ToDouble(protocol.vDraft));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vDraft;
                    break;
                case 20:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vLosses;
                    nums.Add(Convert.ToDouble(protocol.vLosses));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vLosses;
                    break;
                case 21:
                    this.lbl1.Text = elementComboBox.Text;
                    valLabel.Text = protocol.vExcessAir;
                    nums.Add(Convert.ToDouble(protocol.vExcessAir));
                    average = nums.Average().ToString("0.0");
                    aveLabel.Text = average;
                    btn.Text = average + " AVG";
                    this.lbl2.Text = protocol.vExcessAir;
                    break;
            }
            
            chartIt(valLabel.Text, average);
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
