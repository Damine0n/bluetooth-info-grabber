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
using Finisar.SQLite;
using System.IO;


namespace AdvDAS
{
    public partial class Trend : Form
    {
        List<Facts> elements = new List<Facts>();
        char degree = '°';
        Thread t;
        private PrintDoc pDoc;
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public Trend(PrintDoc pDoc)
        {
            InitializeComponent();
            filltable();
            this.pDoc = pDoc;
        }
        private void load_table()
        {
            // [snip] - As C# is purely object-oriented the following lines must be put into a class:


            // create a new database connection:
            sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");


            try
            {
                DataSet ds = new DataSet();
                var da = new SQLiteDataAdapter("SELECT * FROM test;", sqlite_conn);
                da.Fill(ds);
                elementTable.DataSource = ds.Tables[0].DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlite_conn.Close();
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
                trendChart.Series[i].Enabled = false;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Test Trend File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Trend Summary";
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //pDoc.printTrend();
                Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write
                ////Insert image
                //iTextSharp.text.Image PNG = iTextSharp.text.Image.GetInstance();
                //PNG.ScaleToFit(100f, 150f);
                //PNG.Border = iTextSharp.text.Rectangle.BOX;
                //PNG.SetAbsolutePosition();
                //doc.Add(PNG);
                ////Write Some Content
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
                if ((bool)elementTable.Rows[e.RowIndex].Cells[3].Value)//only activates on check
                {
                    DialogResult dialogResult = MessageBox.Show("If you select yes your chart's data will restart.", "Are you sure? ", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        foreach (var series in trendChart.Series)
                        {
                            series.Points.Clear();
                        }
                        trendChart.Series[e.RowIndex].Enabled = true;
                        t = new Thread(ThreadProc);
                        t.Start(e.RowIndex.ToString());
                        //Thread.Sleep(50);
                        while (t.IsAlive)
                        {
                            trendChart.Series[e.RowIndex].Points.AddY(Double.Parse(elementTable.Rows[e.RowIndex].Cells[1].Value.ToString()));//DataBindY((DataView)elementTable.DataSource, "dgValue");
                        }
                        MessageBox.Show("Value = " + elementTable.Rows[e.RowIndex].Cells[1].Value.ToString());  //Displaying value of that cell which is either true or false in this case.
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do nothing
                    } 
                }else
                {
                    trendChart.Series[e.RowIndex].Enabled=false;
                }
            }
        }

        private void ThreadProc(object obj)
        {
            Random ran = new Random();
            for (int i = 0; i < 100; i++)
            {
                //Thread.Sleep(100);
                elementTable.Rows[int.Parse(obj.ToString())].Cells[1].Value = ran.Next(0,100);
            }
        }
    }
}