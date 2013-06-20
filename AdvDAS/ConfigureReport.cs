using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using System.IO;

namespace AdvDAS
{
    public partial class ConfigureReport : Form
    {
        public PrintDoc print1 = new PrintDoc();
        public ConfigureReport()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string s = ofd.FileName;
            }
            print1.OFD = ofd;
        }
    }
}
