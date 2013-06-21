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
    public class PrintDoc
    {
        public PrintDoc()
        {
        }
        public OpenFileDialog OFD { get; set; }
        public Trend Trend { get; set; }
        public MainMenu MainMenu { get; set; }
        public void printTrend()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test Trend File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Trend Summary"; 
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            doc.Open();//Open Document To Write
            //Insert image
            iTextSharp.text.Image LOGO = iTextSharp.text.Image.GetInstance(OFD.FileName);
            LOGO.ScaleToFit(100f, 150f);
            LOGO.Border = iTextSharp.text.Rectangle.BOX;
            doc.Add(LOGO);
            //Write Some Content
            Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
            //Adds above created text using different class object to our pdf document.
            doc.Add(paragraph);
            PdfPCell cell = new PdfPCell(new Phrase("Trend Table",
                new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,
                20f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GREEN)));
            cell.Colspan = 3;
            cell.HorizontalAlignment = 1;//0=Left, 1=Center, 2=Right
            PdfPTable dgTable = new PdfPTable(Trend.elementTable.ColumnCount - 1);
            dgTable.AddCell(cell);

            //Add headers from the DGV to the table
            for (int i = 0; i < Trend.elementTable.ColumnCount - 1; i++)
            {
                dgTable.AddCell(new Phrase(Trend.elementTable.Columns[i].HeaderText));
            }

            //Flag First Row as Header
            dgTable.HeaderRows = 1;

            //Add actual rows from DGV to the table
            for (int j = 0; j < Trend.elementTable.Rows.Count; j++)
            {
                for (int k = 0; k < Trend.elementTable.Columns.Count; k++)
                {
                    if (Trend.elementTable[k, j].Value != null)
                    {
                        dgTable.AddCell(new Phrase(Trend.elementTable[k, j].Value.ToString()));
                    }
                }
            }
            //Adds table to pdf
            doc.Add(dgTable);

            //Adds chart to PDF
            var chartimage = new MemoryStream();
            Trend.trendChart.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            Chart_image.ScalePercent(75f);
            doc.Add(Chart_image);

            doc.Close();//Closes Document
            System.Diagnostics.Process.Start(sfd.FileName);
        }
        public void printSnapShot(string fileName)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test SnapShot File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save SnapShot";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write
                //Insert Image
                iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance(fileName);
                PNG.ScalePercent(50f);
                doc.Add(PNG);
                //Write Some Content
                Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
                //Adds above created text using different class object to our pdf document.
                doc.Add(paragraph);
                doc.Close();//Closes Document
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }
    }
}
