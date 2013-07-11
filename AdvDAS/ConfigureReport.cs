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

namespace CRS
{
    public partial class ConfigureReport : Form
    {
        private PrintDoc pDoc;
        public ConfigureReport(PrintDoc pDoc)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.pDoc = pDoc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
        }
    }
}
