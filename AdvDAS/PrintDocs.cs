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
        private string equipment = "", site = "";
        private string pEngineer, pCompany, pPhone, pState, pStreet, pCity, pEmail, pHomePage, pZip, pFax, pCellphone, pLogo,
            sFacilty, sArea, eModel, eUnitNumber, eSerialNo, ePermitNumber, ePermitEquip,ePermitCO, ePermitNOx, eLimitUnit;
        DateTime ePermitDate;
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

        public void printReport(List<string> names)
        {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 10, 10, 10, 10);
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
                try
                {
                    //Write Some Content
                    ColumnText ct = new ColumnText(wri.DirectContent);
                    Paragraph heading = new Paragraph("Engine Emissions Test Report");
                    Paragraph personalData = new Paragraph();
                    heading.Font.Size = 35;
                    heading.Alignment = 1;
                    doc.Add(heading);
                    iTextSharp.text.Image LOGO = iTextSharp.text.Image.GetInstance(pLogo);
                    LOGO.ScaleToFit(100f, 150f);
                    LOGO.Border = iTextSharp.text.Rectangle.BOX;
                    doc.Add(LOGO);
                    personalData.Add(new Paragraph(String.Format("{0}", pStreet)));
                    personalData.Add(new Paragraph(String.Format("{0}, {1} {2}", new object[] { pCity, pState, pZip })));
                    personalData.Add(new Paragraph(String.Format("Phone: {0}", pPhone)));
                    personalData.Add(new Paragraph(String.Format("Mobile: {0}", pCellphone)));
                    personalData.Add(new Paragraph(String.Format("Email: {0}", pEmail)));
                    Phrase p = new Phrase();
                    p.Add("what up");
                    ct.YLine=3;
                    ct.Alignment = Element.ALIGN_JUSTIFIED;
                    ct.ExtraParagraphSpace = 6;
                    ct.Leading = 1.2f;
                    ct.FollowingIndent = 27;
                    //int linesWritten, column, status= ct.co
                    ct.SetSimpleColumn(new Phrase("Anhang zum Phytosanitären Transportdokument Nr.: EG/DE/\n"), 36, 36, 
                        doc.PageSize.Width - 36, doc.PageSize.Height - 36, 10, Element.ALIGN_LEFT);
                    ct.SetText(personalData);
                    ct.SetText(p);
                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT,p, 20, 0, 0);
                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, p, 10, 0, 0);
                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, p, 20, 20, 0);
                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, p, 10,20, 0);
                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_LEFT, p, 0, 0, 0);
                    ct.Go();
                    doc.Add(new Chunk(equipment));
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
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
                    pLogo = sqlite_datareader[12].ToString();
                }
                equipment = GasAnalysis.equipment;
                site = GasAnalysis.site;
                //sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            try
            {

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Sites WHERE Site = " + site + ";", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    sArea = sqlite_datareader[1].ToString();
                    sFacilty = sqlite_datareader[2].ToString();
                }
                equipment = GasAnalysis.equipment;
                site = GasAnalysis.site;
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            try
            {

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Equipments WHERE owner = '" + site
                    + "' AND equipment = '" + equipment + "';", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();

                while (sqlite_datareader.Read())
                {
                    eUnitNumber = sqlite_datareader[2].ToString();

                    eModel = sqlite_datareader[3].ToString();

                    eSerialNo = sqlite_datareader[4].ToString();

                    ePermitNumber = sqlite_datareader[21].ToString();

                    ePermitDate = Convert.ToDateTime(sqlite_datareader[22]);

                    ePermitEquip = sqlite_datareader[23].ToString();

                    ePermitCO = sqlite_datareader[24].ToString();

                    ePermitNOx = sqlite_datareader[25].ToString();

                    eLimitUnit = sqlite_datareader[26].ToString();
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("EquipBox: " + ex.Message);
            }
            sqlite_conn.Close();
        }

    }
}
