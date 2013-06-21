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
    public partial class Trend : Form
    {
        List<Facts> elements = new List<Facts>();
        char degree = '°';
        Thread t;
        private PrintDoc pDoc;
        public Trend(PrintDoc pDoc)
        {
            InitializeComponent();
            filltable();
            this.pDoc = pDoc;
        }
        void filltable()
        {
            elements.Add(new Facts("O2", 0, "%"));
            elements.Add(new Facts("CO", 0, "ppm"));
            elements.Add(new Facts("CO2", 0, "ppm"));
            elements.Add(new Facts("NO", 0, "ppm"));
            elements.Add(new Facts("NO2", 0, "ppm"));
            elements.Add(new Facts("NOx", 0, "ppm"));
            elements.Add(new Facts("SO2", 0, "ppm"));
            elements.Add(new Facts("CxHy", 0, "ppm"));
            elements.Add(new Facts("T(gas)", 0, degree + "F"));
            elements.Add(new Facts("T(amb)", 0, degree + "F"));
            elements.Add(new Facts("Temp 1", 0, degree + "F"));
            elements.Add(new Facts("Temp 2", 0, degree + "F"));
            elements.Add(new Facts("T(cell)", 0, degree + "F"));
            elements.Add(new Facts("Efficiency", 0, "%"));
            elements.Add(new Facts("Flow", 0, "L/Min"));
            elements.Add(new Facts("NH3", 0, "ppm"));
            //elements.Add(new Facts ("CO(mass)",0, "ppm" ));
            //elements.Add(new Facts ("NOx(mass)",0, "ppm" ));
            for (int i = 0; i < elements.Count; i++)
            {
                elementTable.Rows.Add(elements[i].Name, elements[i].Value, elements[i].Unit);
            }
        }
        private void elementTable_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked == true)
                MessageBox.Show(e.Item.SubItems[1].Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string s = ofd.FileName;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test Trend File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Trend Summary";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //pDoc.printTrend();
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("Trend/Test", FileMode.Create));
                doc.Open();//Open Document To Write
                //Insert image
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(ofd.FileName);
                PNG.ScaleToFit(100f, 150f);
                PNG.Border = iTextSharp.text.Rectangle.BOX;
                //PNG.SetAbsolutePosition();
                doc.Add(PNG);
                //Write Some Content
                Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
                //Adds above created text using different class object to our pdf document.
                doc.Add(paragraph);
                PdfPCell cell = new PdfPCell(new Phrase("Trend Table",
                    new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,
                    20f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GREEN)));
                cell.Colspan = 3;
                cell.HorizontalAlignment = 1;//0=Left, 1=Center, 2=Right
                PdfPTable dgTable = new PdfPTable(elementTable.ColumnCount - 1);
                dgTable.AddCell(cell);

                //Add headers from the DGV to the table
                for (int i = 0; i < elementTable.ColumnCount - 1; i++)
                {
                    dgTable.AddCell(new Phrase(elementTable.Columns[i].HeaderText));
                }

                //Flag First Row as Header
                dgTable.HeaderRows = 1;

                //Add actual rows from DGV to the table
                for (int j = 0; j < elementTable.Rows.Count; j++)
                {
                    for (int k = 0; k < elementTable.Columns.Count; k++)
                    {
                        if (elementTable[k, j].Value != null)
                        {
                            dgTable.AddCell(new Phrase(elementTable[k, j].Value.ToString()));
                        }
                    }
                }
                //Adds table to pdf
                doc.Add(dgTable);

                //Adds chart to PDF
                var chartimage = new MemoryStream();
                trendChart.SaveImage(chartimage, ChartImageFormat.Png);
                iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
                Chart_image.ScalePercent(75f);
                doc.Add(Chart_image);

                doc.Close();//Closes Document
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        private void elementTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //This condition will make sure that this code execute if and only if checkbox cell is clicked.
            if (e.ColumnIndex == elementTable.Columns["dgGraph"].Index)  //Checking index of checkbox column is equal to clickable cell index.
            {
                elementTable.EndEdit();  //Stop editing of cell.
                t = new Thread(ThreadProc);
                t.Start();
                while (t.IsAlive)
                {
                    trendChart.Series[2].Points.AddY(Double.Parse(elementTable.Rows[e.RowIndex].Cells[1].Value.ToString()));//DataBindY((DataView)elementTable.DataSource, "dgValue");
                    Thread.Sleep(0);
                }
                MessageBox.Show("Value = " + elementTable.Rows[e.RowIndex].Cells[1].Value.ToString());  //Displaying value of that cell which is either true or false in this case.
                //trendChart.DataBindTable(Double.Parse(elementTable.Rows[e.RowIndex].Cells[1].Value.ToString()), "SalesName");
            }
        }

        private void ThreadProc(object obj)
        {
            for (int i = 0; i < 1000; i++)
            {
//                Thread.Sleep(1000);
                elementTable.Rows[3].Cells[1].Value = i;
            }
        }
    }
}