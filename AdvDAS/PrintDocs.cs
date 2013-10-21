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
        public static string COspan, NOspan, NO2span, calErr1, calErr2, calErr3;
        DateTime ePermitDate;
        public iTextSharp.text.Image picture;
        J2KNProtocol protocol = new J2KNProtocol();
        public PrintDocs()
        {
            InitializeComponent();
        }
        public OpenFileDialog OFD { get; set; }
        public MainMenu MainMenu { get; set; }


        public void printGraph(Chart graph)
        {
            for (int h = 0; h < 3; h++)
            {

            }
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
        public void printSnapShot(List<string> index)
        {
            //get Serial Number
            protocol.processProtocol("$0A0514");
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
            FillVariables();
            double O2sum = 0;
            double COsum = 0;
            double NOxsum = 0;
            double COMassSum = 0;
            double NOxMassSum = 0;
            double O2total = 0, COtotal = 0, NOxtotal = 0, COmtotal = 0, NOxmtotal = 0;
            int num=0;
            bool stop = false;
            List<Tuple<string, string, string, string, string>> averages = new List<Tuple<string, string, string, string, string>>();
            Document doc = new Document(iTextSharp.text.PageSize.LETTER, 20, 20, 10, 10);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:\\Users\\Daymen\\Source\\Repos\\bluetooth-info-grabber\\AdvDAS\\bin\\Debug\\Reports\\" + site + "\\" + equipment;
            sfd.Filter = "PDF File|*.pdf";
            sfd.FileName = "Report File " + DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            sfd.Title = "Save Report";

            sqlite_conn.Open();
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                num++;
                string path = sfd.FileName;
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream(path, FileMode.Create));
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                for (int z = 0; z < 3; z++)
                {
                    try
                    {
                        var da = new SQLiteDataAdapter("SELECT O2, CO, NOx FROM " + names[z] + ";", sqlite_conn);
                        ds.Clear();
                        da.Fill(ds);
                        bindingSource2.DataSource = ds;
                        dataGridView2.DataSource = bindingSource2;
                        da.Update(ds);
                    }
                    catch (Exception ex)
                    {
                        stop = true;
                        //MessageBox.Show(ex.Message + ex.StackTrace);
                    }

                    for (int l = 0; l < dataGridView1.Rows.Count; l++)
                    {
                        O2sum += Convert.ToDouble(dataGridView2.Rows[l].Cells[1].Value);
                        COsum += Convert.ToDouble(dataGridView2.Rows[l].Cells[2].Value);
                        NOxsum += Convert.ToDouble(dataGridView2.Rows[l].Cells[3].Value);
                    }
                    int count = dataGridView1.Rows.Count;
                    double O2avg = O2sum / count;
                    double COavg = COsum / count;
                    double NOxavg = NOxsum / count;
                    double COmassavg = COMassSum / count;
                    double NOxmassavg = NOxMassSum / count;
                    averages.Add(new Tuple<string, string, string, string, string>(O2avg.ToString(), COavg.ToString(), NOxavg.ToString(), COmassavg.ToString(), NOxmassavg.ToString()));
                    if (stop)
                    {
                        while (z < 3)
                        {
                            averages.Add(new Tuple<string, string, string, string, string>("---", "---", "---", "---", "---"));
                            z++;
                        }
                        break;
                    }
                    
                }
                
                for (int g = num; g < 0;g--)
                {
                    O2total += Convert.ToDouble(averages[g].Item1);
                    COtotal += Convert.ToDouble(averages[g].Item2);
                    NOxtotal += Convert.ToDouble(averages[g].Item3);
                    COmtotal += Convert.ToDouble(averages[g].Item4);
                    NOxmtotal += Convert.ToDouble(averages[g].Item5);
                }
                MessageBox.Show(""+ O2total+"   "+num);
                O2total = O2total/num;
                COtotal = COtotal/num;
                NOxtotal = NOxmtotal/num;
                COmtotal = COmtotal/num;
                NOxmtotal = NOxmtotal/num;
                string COLimitStatus = "Fail";
                string NOxLimitStatus = "Fail";
                if (COmtotal < Convert.ToDouble(ePermitCO))
                    COLimitStatus = "Pass";
                if (NOxmtotal < Convert.ToDouble(ePermitNOx))
                    NOxLimitStatus = "Pass";



                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                doc.Open();//Open Document To Write
                try
                {
                    iTextSharp.text.Font hel = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL);
                    //Write Some Content
                    LineSeparator UNDERLINE = new LineSeparator(1, 98, null, Element.ALIGN_CENTER, -2);
                    Chunk tab1 = new Chunk(UNDERLINE, doc.PageSize.Width - (doc.RightMargin*2), true);

                    ColumnText ct = new ColumnText(wri.DirectContent);
                    Paragraph heading = new Paragraph("Engine Emissions Test Report", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 25, iTextSharp.text.Font.NORMAL));
                    Paragraph personalData = new Paragraph("", hel);
                    Paragraph date = new Paragraph("\nEmissions Test Date: " + DateTime.Now.ToString("MM/dd/yyyy"));
                    iTextSharp.text.Image LOGO = iTextSharp.text.Image.GetInstance(pLogo);
                    LOGO.ScaleToFit(100f, 150f);
                    LOGO.Border = iTextSharp.text.Rectangle.BOX;
                    //doc.Add(new Chunk(new VerticalPositionMark(), doc.PageSize.Width, true));
                    doc.Add(LOGO);
                    heading.Alignment = 1;
                    date.SpacingAfter = 12f;
                    date.Alignment = 2;
                    heading.Add(date);
                    doc.Add(heading);
                    

                    personalData.Add(new Chunk(String.Format("{0}", pStreet)));
                    personalData.Add(new Chunk(new VerticalPositionMark(), 175, true));
                    personalData.Add(new Phrase("CO: " + eLimitUnit + "     NOx: " + eLimitUnit + "", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.NORMAL)));
                    personalData.Add(new Chunk(String.Format("\n{0}, {1} {2}\n", new object[] { pCity, pState, pZip })));
                    personalData.Add(new Chunk(String.Format("Phone: {0}", pPhone)));
                    personalData.Add(new Chunk(new VerticalPositionMark(), 235, true));
                    personalData.Add(new Phrase(" " + COmtotal + "                              " + NOxmtotal + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 20, iTextSharp.text.Font.BOLD)));
                    personalData.Add(new Chunk(String.Format("Mobile: {0}", pCellphone)));
                    personalData.Add(new Chunk(new VerticalPositionMark(), 224, true));
                    personalData.Add(new Phrase(" "+COLimitStatus + "                                       " + NOxLimitStatus + "\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 14, iTextSharp.text.Font.NORMAL)));
                    personalData.Add(new Chunk(String.Format("Email: {0}", pEmail)));
                    personalData.Add(new Chunk(new VerticalPositionMark(), 225, true));
                    personalData.Add(new Phrase(" (" + ePermitCO + ")                                                      (" + ePermitNOx + ")\n", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.NORMAL)));

                    doc.Add(personalData);

                    ColumnText.ShowTextAligned(wri.DirectContent, Element.ALIGN_RIGHT, new Phrase("Technician____________________________  Date_____________   "), doc.PageSize.Width, 10, 0);
                    doc.Add(new Paragraph());

                    Paragraph info = new Paragraph("", hel);
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("PHYSICAL LOCATION", hel));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Operational Area: " + sArea));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Facility Name: " + sFacilty + "\n"));
                    ////////////////////////////////////////////////
                    info.Add(tab1);
                    info.Add(new Paragraph("EQUIPMENT INFORMATION", hel));
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
                    info.Add(new Paragraph("PERMIT INFORMATION", hel));
                    info.Add(new Chunk(new VerticalPositionMark(), 50, true));
                    info.Add(new Phrase("Permit #: " + ePermitNumber));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Permit Date: " + ePermitDate.ToString("MM/dd/yyyy") + Chunk.NEWLINE));
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
                    info.Add(new Phrase("Model: J2KN"));
                    info.Add(new Chunk(new VerticalPositionMark(), 300, true));
                    info.Add(new Phrase("Serial #: " + protocol.vSerialNumber + "\n"));
                    doc.Add(info);
                    doc.Add(new Paragraph(""));

                    PdfPTable table = new PdfPTable(5);
                    table.HorizontalAlignment = Element.ALIGN_CENTER;
                    PdfPCell cell = new PdfPCell(new Phrase("Emissions Test Results", new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL)));
                    cell.Colspan = 5;
                    table.AddCell(cell);
                    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    ///////Row1
                    table.AddCell(new Phrase("Parameter",hel));
                    table.AddCell(new Phrase("Test 1", hel));
                    table.AddCell(new Phrase("Test 2", hel));
                    table.AddCell(new Phrase("Test 3", hel));
                    table.AddCell(new Phrase("Overall Average", hel));

                    ///////Row2
                    table.AddCell(new Phrase("O2%", hel));
                    table.AddCell(new Phrase("" + averages[0].Item1, hel));
                    table.AddCell(new Phrase("" + averages[1].Item1, hel));
                    table.AddCell(new Phrase("" + averages[2].Item1, hel));
                    table.AddCell(new Phrase(O2total.ToString(), hel));

                    ///////Row3
                    table.AddCell(new Phrase("CO ppm", hel));
                    table.AddCell(new Phrase("" + averages[0].Item2, hel));
                    table.AddCell(new Phrase("" + averages[1].Item2, hel));
                    table.AddCell(new Phrase("" + averages[2].Item2, hel));
                    table.AddCell(new Phrase(COtotal.ToString(), hel));

                    ///////Row4
                    table.AddCell(new Phrase("NOx ppm", hel));
                    table.AddCell(new Phrase("" + averages[0].Item3, hel));
                    table.AddCell(new Phrase("" + averages[1].Item3, hel));
                    table.AddCell(new Phrase("" + averages[2].Item3, hel));
                    table.AddCell(new Phrase(NOxtotal.ToString(), hel));

                    ///////Row5
                    table.AddCell(new Phrase("CO mass", hel));
                    table.AddCell(new Phrase("" + averages[0].Item4, hel));
                    table.AddCell(new Phrase("" + averages[1].Item4, hel));
                    table.AddCell(new Phrase("" + averages[2].Item4, hel));
                    table.AddCell(new Phrase(COmtotal.ToString(), hel));

                    ///////Row6
                    table.AddCell(new Phrase("NOx mass", hel));
                    table.AddCell(new Phrase("" + averages[0].Item5, hel));
                    table.AddCell(new Phrase("" + averages[1].Item5, hel));
                    table.AddCell(new Phrase("" + averages[2].Item5, hel));
                    table.AddCell(new Phrase(NOxmtotal.ToString(), hel));

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
                        da.Update(ds);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                    try
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(names[z], new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 15f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLUE)));
                        cell.Colspan = dataGridView1.ColumnCount;
                        cell.HorizontalAlignment = 1;//0=Left, 1=Center, 2=Right
                        PdfPTable dgTable = new PdfPTable(dataGridView1.ColumnCount);

                        dgTable.AddCell(cell);

                        //Add headers from the DGV to the table
                        for (int i = 0; i < dataGridView1.ColumnCount; i++)
                        {
                            dgTable.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.BOLD)));
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
                                    dgTable.AddCell(new Phrase(dataGridView1[k, j].Value.ToString(), new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10f, iTextSharp.text.Font.NORMAL, iTextSharp.text.BaseColor.BLACK)));
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
