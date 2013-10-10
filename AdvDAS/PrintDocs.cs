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
using iTextSharp.text.pdf.draw;
using iTextSharp.text.pdf.events;
using iTextSharp.text.pdf.interfaces;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            sFacilty, sArea, eModel, eUnitNumber, eSerialNo, ePermitNumber, ePermitEquip, ePermitCO, ePermitNOx, eLimitUnit, aModel;
        public string COspan, NOspan, NO2span, calErr1, calErr2, calErr3;
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
            double COsum = 0;
            double NOxsum = 0;
            double COMassSum = 0;
            double NOxMassSum = 0;
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
                    LineSeparator UNDERLINE = new LineSeparator(1, 98, null, Element.ALIGN_CENTER, -2);
                    Chunk tab1 = new Chunk(UNDERLINE, doc.PageSize.Width - 20, true);

                    ColumnText ct = new ColumnText(wri.DirectContent);
                    Paragraph heading = new Paragraph("Engine Emissions Test Report");
                    Paragraph personalData = new Paragraph();
                    heading.Font.Size = 35;
                    heading.Alignment = 1;
                    heading.SpacingAfter = 18f;
                    doc.Add(heading);
                    iTextSharp.text.Image LOGO = iTextSharp.text.Image.GetInstance(pLogo);
                    LOGO.ScaleToFit(100f, 150f);
                    LOGO.Border = iTextSharp.text.Rectangle.BOX;
                    ct.AddElement(LOGO);
                    doc.Add(LOGO);

                    personalData.Add(new Paragraph(String.Format("{0}", pStreet)));
                    personalData.Add(new Paragraph(String.Format("{0}, {1} {2}", new object[] { pCity, pState, pZip })));
                    personalData.Add(new Paragraph(String.Format("Phone: {0}", pPhone)));
                    personalData.Add(new Paragraph(String.Format("Mobile: {0}", pCellphone)));
                    personalData.Add(new Paragraph(String.Format("Email: {0}", pEmail)));
                    doc.Add(personalData);

                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_RIGHT, new Phrase(pEngineer + "       " + DateTime.Now), doc.PageSize.Width, 0, 0);
                    doc.Add(new Paragraph());

                    Paragraph info = new Paragraph();
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("PHYSICAL LOCATION"));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Operational Area: " + sArea));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Facility Name: " + sFacilty + "\n"));
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("EQUIPMENT INFORMATION"));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Equipment : " + equipment));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Unit #: " + eUnitNumber + Chunk.NEWLINE));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Model: " + eModel));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Serial #: " + eSerialNo + "\n"));
                    //info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    //info.Add(new Phrase("Boiler Parameters: ?" + Chunk.NEWLINE));
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("PERMIT INFORMATION"));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Permit #: " + ePermitNumber));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Permit Date: " + ePermitDate + Chunk.NEWLINE));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Permit Equipment #: " + ePermitEquip));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Permit Units: " + Chunk.NEWLINE));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Permit CO Limit: " + ePermitCO));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Permit NOx Limit: " + ePermitNOx + "\n"));
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("ANALYZER INFORMATION"));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Model: " + aModel));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Serial #: " + sFacilty + "\n"));
                    doc.Add(info);

                    Paragraph calibrationInfo = new Paragraph();
                    calibrationInfo.Add(tab1);
                    calibrationInfo.Add(new Paragraph("Calibration Information"));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    calibrationInfo.Add(new Phrase("CO span gas " + aModel + " ppm"));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    calibrationInfo.Add(new Phrase("Cal error limit: " + calErr1 + Chunk.NEWLINE));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    calibrationInfo.Add(new Phrase("NO span gas " + aModel + " ppm"));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    calibrationInfo.Add(new Phrase("Cal error limit: " + calErr2 + Chunk.NEWLINE));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    calibrationInfo.Add(new Phrase("NO2 span gas " + aModel + " ppm"));
                    calibrationInfo.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    calibrationInfo.Add(new Phrase("Cal error limit: " + calErr3 + "\n"));
                    doc.Add(calibrationInfo);
                    doc.Add(tab1);
                    PdfPTable table = new PdfPTable(5);
                    PdfPCell cell = new PdfPCell(new Phrase("Emissions Test Results", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.TIMES_ROMAN, 15f, iTextSharp.text.Font.NORMAL)));
                    cell.Colspan = 5;
                    table.AddCell(cell);

                    ///////Row1
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Test 1"));
                    table.AddCell(new Phrase("Test 2"));
                    table.AddCell(new Phrase("Test 3"));
                    table.AddCell(new Phrase("Overall Average"));

                    ///////Row2
                    table.AddCell(new Phrase("O2%"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));

                    ///////Row3
                    table.AddCell(new Phrase("CO ppm"));
                    table.AddCell(new Phrase("NOx ppm"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));

                    ///////Row4
                    table.AddCell(new Phrase("NOx ppm"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));

                    ///////Row5
                    table.AddCell(new Phrase("CO mass"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));

                    ///////Row6
                    table.AddCell(new Phrase("NOx mass"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));
                    table.AddCell(new Phrase("Parameter"));

                    doc.Add(table);
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
                        var da = new SQLiteDataAdapter("SELECT Time, O2, CO, NO, NO2, NOx, Tgas, Tamb, Tcell FROM " + names[z] + ";", sqlite_conn);
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
                    for (int l = 0; l < dataGridView1.Rows.Count; l++)
                    {
                        COsum += Convert.ToDouble(dataGridView1.Rows[l].Cells[2].Value);
                        NOxsum += Convert.ToDouble(dataGridView1.Rows[l].Cells[5].Value);
                    }
                    int count = dataGridView1.Rows.Count;
                    double COavg = COsum / count;
                    double NOxavg = NOxsum / count;
                    double COmassavg = COMassSum / count;
                    double NOxmassavg = NOxMassSum / count;
                    Paragraph paragraph = new Paragraph("Average CO = " + COavg + "\nAverage NOx = " + NOxavg + "\nAverage COmass = " + COmassavg + "\nAverage NOxmass = " + NOxmassavg);
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
            fillPersonalData();
            fillSite();
            fillEquipment();
        }

        private void fillEquipment()
        {
            sqlite_conn.Open();
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

        private void fillSite()
        {
            sqlite_conn.Open();
            try
            {

                sqlite_cmd = new SQLiteCommand("SELECT * FROM Sites WHERE Site = '" + site + "';", sqlite_conn);
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
            sqlite_conn.Close();
        }

        private void fillPersonalData()
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
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            sqlite_conn.Close();
        }

    }
}
