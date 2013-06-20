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
    class PrintDoc
    {
        private OpenFileDialog ofd;
        private SaveFileDialog sfd;
        private Trend trend;
        public PrintDoc()
        {
        }
        public OpenFileDialog OFD { get; set; }
        public SaveFileDialog SFD { get; set; }
        public Trend Trend { get; set; }
        public void print()
        {
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
            PdfPTable dgTable = new PdfPTable(trend.elementTable.ColumnCount - 1);
            dgTable.AddCell(cell);

            //Add headers from the DGV to the table
            for (int i = 0; i < trend.elementTable.ColumnCount - 1; i++)
            {
                dgTable.AddCell(new Phrase(trend.elementTable.Columns[i].HeaderText));
            }

            //Flag First Row as Header
            dgTable.HeaderRows = 1;

            //Add actual rows from DGV to the table
            for (int j = 0; j < trend.elementTable.Rows.Count; j++)
            {
                for (int k = 0; k < trend.elementTable.Columns.Count; k++)
                {
                    if (trend.elementTable[k, j].Value != null)
                    {
                        dgTable.AddCell(new Phrase(trend.elementTable[k, j].Value.ToString()));
                    }
                }
            }
            //Adds table to pdf
            doc.Add(dgTable);

            //Adds chart to PDF
            var chartimage = new MemoryStream();
            trend.trendChart.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            Chart_image.ScalePercent(75f);
            doc.Add(Chart_image);

            doc.Close();//Closes Document
        }
    }
}
