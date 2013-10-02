using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Globalization;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;
using Finisar.SQLite;
using System.IO;

namespace CRS
{

    public partial class PrintDocs : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        DataTable ds = new DataTable();
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        public string equipment = "";
        private string pEngineer, pCompany, pPhone,p, pState, pStreet, pCity, pEmail, pHomePage, pZip, pFax, pCellphone;
        public iTextSharp.text.Image picture;
        public PrintDocs()
        {
            InitializeComponent();
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
        public void printSnapShot(List<string> snapshots)
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

        public void printReport(List<string> names, string note)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 42, 35);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Report File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Report";
            FillVariables();
            sqlite_conn.Open();


            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                doc.Open();//Open Document To Write
                //Write Some Content
                Paragraph heading = new Paragraph("Engine Emissions Test Report");
                heading.Font.Size = 35;
                heading.Alignment = 1;
                doc.Add(heading);
                Paragraph personalData= new Paragraph();
                //heading.Font.Style = Font.Bold;//PdfWriter.GetInstance(doc, new FileStream(pdfpath + "/Columns.pdf", FileMode.Create));
                doc.Add(new Chunk(equipment));
                doc.Add(new Paragraph(String.Format("{0}", pStreet)));
                doc.Add(new Paragraph(String.Format("{0}, {1} {2}",new object[]{pCity, pState, pZip})));
                doc.Add(new Paragraph(String.Format("Phone: {0}", pPhone)));
                doc.Add(new Paragraph(String.Format("Mobile: {0}", pCellphone)));

                ColumnText column = new ColumnText(wri.DirectContent);
                //column.AddText(new Paragraph(personalData)));
                
                for (int z = 0; z < names.Count; z++)
                {
                    doc.NewPage();
                    try
                    {
                        var da = new SQLiteDataAdapter("SELECT Time, O2, CO, NOx, Tgas, Tamb, Tcell, Notes FROM " + names[z] + ";", sqlite_conn);
                        ds.Clear();
                        da.Fill(ds);
                        bindingSource1.DataSource = ds;
                        dataGridView1.DataSource = bindingSource1;
                        //dataGridView1.Columns.Insert(dataGridView1.ColumnCount,CBColumn);
                        da.Update(ds);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    try
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(names[z], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 20f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
                        cell.Colspan = dataGridView1.ColumnCount;
                        cell.HorizontalAlignment = 1;//0=Left, 1=Center, 2=Right
                        PdfPTable dgTable = new PdfPTable(dataGridView1.ColumnCount);

                        dgTable.AddCell(cell);

                        //Add headers from the DGV to the table
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            dgTable.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 10f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
                        }

                        //Flag First Row as Header
                        dgTable.HeaderRows = 1;

                        //Add actual rows from DGV to the table
                        for (int j = 0; j < dataGridView1.Rows.Count; j++)
                        {
                            for (int k = 0; k < dataGridView1.Columns.Count; k++)
                            {
                                if (dataGridView1[k, j].Value != null)
                                {
                                    dgTable.AddCell(new Phrase(dataGridView1[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.NORMAL, 10f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
                                }
                            }
                        }
                        //Adds table to pdf
                        doc.Add(dgTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(dataGridView1.ColumnCount.ToString());
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    Paragraph paragraph = new Paragraph("Average CO = \nAverage NOx = \nAverage COmass = \nAverage NOxmass = ");
                    //Adds above created text using different class object to our pdf document.
                    doc.Add(paragraph);
                }
                doc.Close();//Closes Document
                System.Diagnostics.Process.Start(sfd.FileName);
            }
            sqlite_conn.Close();
        }

        private void FillVariables()
        {
            sqlite_conn.Open();
            try
            {

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Personal_Data WHERE PData = 1;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    pEngineer = sqlite_datareader[1].ToString();
                    pCompany = sqlite_datareader[2].ToString();
                    pPhone = sqlite_datareader[3].ToString();
                    pState = sqlite_datareader[4].ToString();
                    pStreet = sqlite_datareader[5].ToString();
                    pZip = sqlite_datareader[6].ToString();
                    pCity = sqlite_datareader[7].ToString();
                    pFax = sqlite_datareader[8].ToString();
                    pCellphone = sqlite_datareader[9].ToString();
                    pEmail = sqlite_datareader[10].ToString();
                    pHomePage = sqlite_datareader[11].ToString();
                   
                }
                equipment = MainMenu.equipment;
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ex.StackTrace);
            }
            //try
            //{
                
            //    sqlite_cmd = new SQLiteCommand("SELECT * FROM Personal_Data WHERE owner = '" + this.siteBox.Text.ToString()
            //        + "' AND equipment = '" + this.equipBox.Text.ToString() + "';", sqlite_conn);
            //    sqlite_datareader = sqlite_cmd.ExecuteReader();

            //    while (sqlite_datareader.Read())
            //    {
            //        string unitNum = sqlite_datareader[2].ToString();
            //        tbUnitNum.Text = unitNum;

            //        string model = sqlite_datareader[3].ToString();
            //        tbModel.Text = model;

            //        string serialNum = sqlite_datareader[4].ToString();
            //        tbSerialNum.Text = serialNum;

            //        string service = sqlite_datareader[5].ToString();
            //        tbService.Text = service;

            //        string ignitionTiming = sqlite_datareader[6].ToString();
            //        tbIgnitionTiming.Text = ignitionTiming;

            //        string stackFlow = sqlite_datareader[7].ToString();
            //        tbStackFlow.Text = stackFlow;

            //        string stackTemp = sqlite_datareader[8].ToString();
            //        tbStackTemp.Text = stackTemp;

            //        string intakeMPL = sqlite_datareader[9].ToString();
            //        tbIntakeMPL.Text = intakeMPL;

            //        string intakeMPR = sqlite_datareader[10].ToString();
            //        tbIntakeMPR.Text = intakeMPR;

            //        string intakeMTL = sqlite_datareader[11].ToString();
            //        tbIntakeMTL.Text = intakeMTL;

            //        string intakeMTR = sqlite_datareader[12].ToString();
            //        tbIntakeMTR.Text = intakeMTR;

            //        string stackHeightFT = sqlite_datareader[13].ToString();
            //        tbStackHeightFT.Text = stackHeightFT;

            //        string stackHeightIN = sqlite_datareader[14].ToString();
            //        tbStackHeightIN.Text = stackHeightIN;

            //        string fuelSG = sqlite_datareader[15].ToString();
            //        tbFuelSG.Text = fuelSG;

            //        string RPM = sqlite_datareader[16].ToString();
            //        tbRPM.Text = RPM;

            //        string controllerMake = sqlite_datareader[17].ToString();
            //        AFControllerMake.Text = controllerMake;

            //        string controllerModel = sqlite_datareader[18].ToString();
            //        AFControllerModel.Text = controllerModel;

            //        string catalyticConverterMake = sqlite_datareader[19].ToString();
            //        tbCatalyticConverterMake.Text = catalyticConverterMake;

            //        string catalyticConverterModel = sqlite_datareader[20].ToString();
            //        tbCatalyticConverterModel.Text = catalyticConverterModel;

            //        string AirPermit = sqlite_datareader[21].ToString();
            //        this.tbAirPermit.Text = AirPermit;

            //        DateTime permitDate = Convert.ToDateTime(sqlite_datareader[22]);
            //        this.tbPermitDate.Value = permitDate;

            //        string permitEquip = sqlite_datareader[23].ToString();
            //        this.tbPermitEquip.Text = permitEquip;
            //    }
            //    sqlite_datareader.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("EquipBox: " + ex.Message);
            //}
            sqlite_conn.Close();
        }
        
    }
}
