﻿using System;
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
    public partial class SetUpReport : Form
    {
        private PrintDoc pDoc;
        public SetUpReport(PrintDoc pDoc)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.pDoc = pDoc;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox10.Checked.Equals(false))
            {
                this.checkBox12.Enabled = false;
                this.checkBox13.Enabled = false;
                this.checkBox14.Enabled = false;
                this.checkBox16.Enabled = false;
                this.checkBox15.Enabled = false;
            }
            else
            {
                this.checkBox16.Enabled = true;
                this.checkBox12.Enabled = true;
                this.checkBox13.Enabled = true;
                this.checkBox14.Enabled = true;
                this.checkBox15.Enabled = true;
            }
        }

    }
}
