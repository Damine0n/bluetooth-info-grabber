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
        private Button btn;
        private String unit; 
        private int index;
        List<double> average = new List<double>();
        public static  J2KNProtocol protocol = new J2KNProtocol();

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

            average.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            protocol.processProtocol();
            switch (elementComboBox.SelectedIndex)
            {
                case 0:
                    unit="%";
                    valLabel.Text = protocol.vO2;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vO2;
                    chartIt(protocol.vO2);
                    break;
                case 1:
                    unit = "ppm";
                    valLabel.Text = protocol.vCO;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vCO;
                    chartIt(protocol.vCO);
                    break;
                case 2:
                    unit = "ppm";
                    valLabel.Text = protocol.vCO + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vCO;
                    chartIt(protocol.vCO);
                    break;
                case 3:
                    unit = "ppm";
                    valLabel.Text = protocol.vCO2 + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vCO2;
                    chartIt(protocol.vCO2);
                    break;
                case 4:
                    unit = "ppm";
                    valLabel.Text = protocol.vNO + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vNO;
                    chartIt(protocol.vNO);
                    break;
                case 5:
                    unit = "ppm";
                    valLabel.Text = protocol.vNO + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vNO;
                    chartIt(protocol.vNO);
                    break;
                case 6:
                    unit = "ppm";
                    valLabel.Text = protocol.vNO2 + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vNO2;
                    break;
                case 7:
                    unit = "ppm";
                    valLabel.Text = protocol.vNO2 + unit;
                    aveLabel.Text = unit;
                    this.lbl2.Text = protocol.vNO2;
                    break;
                case 8:
                    valLabel.Text = protocol.vNOx + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vNOx;
                    break;
                case 9:
                    valLabel.Text = protocol.vNOx + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vNOx;
                    break;
                case 10:
                    valLabel.Text = protocol.vSO2 + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vSO2;
                    break;
                case 11:
                    valLabel.Text = protocol.vSO2 + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vSO2;
                    break;
                case 12:
                    valLabel.Text = protocol.vCxHy + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vCxHy;
                    break;
                case 13:
                    valLabel.Text = protocol.vCxHy + "ppm";
                    aveLabel.Text = "ppm";
                    this.lbl2.Text = protocol.vCxHy;
                    break;
                case 14:
                    valLabel.Text = protocol.vTgas + "°F";
                    aveLabel.Text = "°F";
                    this.lbl2.Text = protocol.vTgas;
                    break;
                case 15:
                    valLabel.Text = protocol.vTamb + "°F";
                    aveLabel.Text = "°F";
                    this.lbl2.Text = protocol.vTamb;
                    break;
                case 16:
                    valLabel.Text = protocol.vTcell + "°F";
                    aveLabel.Text = "°F";
                    this.lbl2.Text = protocol.vTcell;
                    break;
                case 17:
                    valLabel.Text = protocol.vEfficiency + "%";
                    aveLabel.Text = "%";
                    this.lbl2.Text = protocol.vEfficiency;
                    break;
                case 18:
                    valLabel.Text = protocol.vIFlow + "L/Min";
                    aveLabel.Text = "L/Min";
                    this.lbl2.Text = protocol.vIFlow;
                    break;
                case 19:
                    valLabel.Text = protocol.vDraft + "i.w.g.";
                    aveLabel.Text = "i.w.g.";
                    this.lbl2.Text = protocol.vDraft;
                    break;
                case 20:
                    valLabel.Text = protocol.vLosses + "%";
                    aveLabel.Text = "%";
                    this.lbl2.Text = protocol.vLosses;
                    break;
                case 21:
                    valLabel.Text = protocol.vExcessAir + "";
                    aveLabel.Text = "";
                    this.lbl2.Text = protocol.vExcessAir;
                    break;

            }
        }

        private void chartIt(string data)
        {
            chart1.Series[0].Points.AddY(data);
            chart1.Series[1].Points.AddY(data);
        }
    }
}
