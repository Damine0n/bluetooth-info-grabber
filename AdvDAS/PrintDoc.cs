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
//using System.Data.SQLite;
using Finisar.SQLite;
using System.IO;

namespace CRS
{
    public class PrintDoc
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        DataTable ds = new DataTable();
        BindingSource bindingSource1 = new BindingSource();
        DataGridView testTable = new DataGridView();
        public PrintDoc()
        {
        }
        public OpenFileDialog OFD { get; set; }
        public MainMenu MainMenu { get; set; }


        public void printGraph(Chart graph)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Trend " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Trend Summary";
            PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(sfd.FileName, FileMode.Create));
            //Open Document To Write
            doc.Open();
            //Insert image
            iTextSharp.text.Image LOGO = iTextSharp.text.Image.GetInstance(OFD.FileName);
            LOGO.ScaleToFit(100f, 150f);
            LOGO.Border = iTextSharp.text.Rectangle.BOX;
            doc.Add(LOGO);
            //Write Some Content
            Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
            //Adds above created text using different class object to our pdf document.
            doc.Add(paragraph);

            //Adds chart to PDF
            var chartimage = new MemoryStream();
            graph.SaveImage(chartimage, ChartImageFormat.Png);
            iTextSharp.text.Image Chart_image = iTextSharp.text.Image.GetInstance(chartimage.GetBuffer());
            Chart_image.ScalePercent(75f);
            doc.Add(Chart_image);

            doc.Close();//Closes Document
            System.Diagnostics.Process.Start(sfd.FileName);
        }
        public void printSnapShot()
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test SnapShot File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Graph";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write

                //Write Some Content
                Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
                //Adds above created text using different class object to our pdf document.
                doc.Add(paragraph);
                doc.Close();//Closes Document
                System.Diagnostics.Process.Start(sfd.FileName);
            }
        }

        public void printReport(List<string> names)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Report File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Report";
            sqlite_conn.Open();


            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write

                //Write Some Content
                Paragraph paragraph = new Paragraph("This is the test paragraph.\nTestTest Test TEST 1234567890");
                //Adds above created text using different class object to our pdf document.
                doc.Add(paragraph);
                for (int z = 0; z < names.Count; z++)
                {
                    try
                    {
                        var da = new SQLiteDataAdapter("SELECT Time, O2, CO, NOx, COmass, NOxmass, Tgas, Tamb, Tcell , Notes FROM " + names[z] + ";", sqlite_conn);
                        da.Fill(ds);
                        bindingSource1.DataSource = ds;
                        testTable.DataSource = bindingSource1;
                        da.Update(ds);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message+ ex.StackTrace);
                    }
                    try
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(names[z], new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL,20f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.GREEN)));
                        cell.Colspan = 10;
                        cell.HorizontalAlignment = 1;//0=Left, 1=Center, 2=Right
                        PdfPTable dgTable = new PdfPTable(testTable.ColumnCount);

                        dgTable.AddCell(cell);

                        //Add headers from the DGV to the table
                        for (int i = 0; i < testTable.ColumnCount - 1; i++)
                        {
                            dgTable.AddCell(new Phrase(testTable.Columns[i].HeaderText));
                        }

                        //Flag First Row as Header
                        dgTable.HeaderRows = 1;

                        //Add actual rows from DGV to the table
                        for (int j = 0; j < testTable.Rows.Count; j++)
                        {
                            for (int k = 0; k < testTable.Columns.Count; k++)
                            {
                                if (testTable[k, j].Value != null)
                                {
                                    dgTable.AddCell(new Phrase(testTable[k, j].Value.ToString()));
                                }
                            }
                        }
                        //Adds table to pdf
                        doc.Add(dgTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(testTable.ColumnCount.ToString());
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    doc.Close();//Closes Document
                    System.Diagnostics.Process.Start(sfd.FileName);
                }

            }
        }
    }
}
