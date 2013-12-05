using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;
using System.IO;
using log4net;
[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace CRS
{
    static class Program
    {
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static SQLiteConnection sqlite_conn;//= new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\database1.db;Version=3;");
        private static SQLiteCommand sqlite_cmd;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            log.Debug("Application Starting");
            if (!File.Exists(@"" + Directory.GetCurrentDirectory() + "\\database1.db"))
            {
                log.Debug("Creating Database1");
                sqlite_conn = new SQLiteConnection("Data Source=" + Directory.GetCurrentDirectory() + "\\database1.db;Version=3;New=True;");
                try
                {
                    sqlite_conn.Open();
                    log.Debug("Opened Connection");
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [CaliInfo] ([SpanGasCO] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    log.Debug("Creates CaliInfo");
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Calibration] ([Time] TEXT  NULL,[O2] TEXT  NULL,[CO] TEXT  NULL,[NO] TEXT  NULL,[NO2] TEXT  NULL,[IFlow] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Customers] ([CustomerID] TEXT  NULL PRIMARY KEY,[Company] TEXT  NULL,[Contact] TEXT  NULL,"
                        + "[Phone] integer  NULL,[Street] TEXT  NULL,[Zip] integer  NULL,[City] TEXT  NULL,"
                        + "[Fax] integer  NULL,[CellPhone] integer  NULL,[Email] TEXT  NULL,[Notes] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Equipments] ([owner] TEXT  NULL,[equipment] TEXT  NULL,[unitNum] TEXT  NULL,[model] TEXT  NULL,"
                        + "[serialNum] TEXT  NULL,[service] TEXT  NULL,[ignitionTiming] TEXT  NULL,[stackFlow] TEXT  NULL,[stackTemp] TEXT  NULL,[intakeMPL] TEXT  NULL,"
                        + "[intakeMPR] TEXT  NULL,[intakeMTL] TEXT  NULL,[intakeMTR] TEXT  NULL,[stackHeightFT] TEXT  NULL,[stackHeightIN] TEXT  NULL,[fuelSG] TEXT  NULL,"
                        + "[RPM] TEXT  NULL,[AFControllerMake] TEXT  NULL,[AFControllerModel] TEXT  NULL,[catalyticConverterMake] TEXT  NULL,[catalyticConverterModel] TEXT  NULL,"
                        + "[AirPermit] TEXT  NULL,[permitDate] TEXT  NULL,[permitEquip] TEXT  NULL,[COLimit] TEXT  NULL,[NOxLimit] TEXT  NULL,[LimitUnit] TEXT  NULL,"
                        + "[Heat] TEXT DEFAULT '1.26'  NULL,[SCF] TEXT  NULL,[HorsePower] TEXT DEFAULT '500' NULL,[FuelType] REAL  NULL,[EquipType] REAL  NULL,PRIMARY KEY ([owner],[equipment]));";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Personal_Data] ([PData] INTEGER  PRIMARY KEY NULL,[Engineer] TEXT  NULL,[Company] TEXT  NULL,"
                        + "[Phone] TEXT  NULL,[State] TEXT  NULL,[Street] TEXT  NULL,[Zip] TEXT  NULL,[City] TEXT  NULL,[Fax] TEXT  NULL,[CellPhone] TEXT  NULL,"
                        + "[Email] TEXT  NULL,[HomePage] TEXT  NULL,[Analyzer] TEXT  NULL,[SerialNo] TEXT  NULL,[LOGO] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [RAW_DATA] ([DATE_TIME] TIMESTAMP  PRIMARY KEY NULL,[O2] REAL  NULL,[ppmCO] REAL  NULL,"
                        + "[ppmNOx] REAL  NULL,[ppmNO] REAL  NULL,[ppmNO2] REAL  NULL,[Pump] REAL  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Readings] ([Time] TEXT DEFAULT '''''''''''''''''''''''''''''''CURRENT_TIME''''''''''''''''''''''''''''''' NOT NULL,"
                        + "[O2] TEXT  NULL,[CO] TEXT  NULL,[CO2] TEXT  NULL,[NO] TEXT  NULL,[NO2] TEXT  NULL,[NOx] TEXT  NULL,[SO2] TEXT  NULL,[CxHy] TEXT  NULL,"
                        + "[Tgas] TEXT  NULL,[Tamb] TEXT  NULL,[Tcell] TEXT  NULL,[Efficiency] TEXT  NULL,[IFlow] TEXT  NULL,[Draft] TEXT  NULL,"
                        + "[Losses] TEXT  NULL,[ExcessAir] TEXT  NULL,[Notes] TEXT  NULL,[COtpy] TEXT  NULL,[NOxtpy] TEXT  NULL,[CObhp] TEXT  NULL,"
                        + "[NOxbhp] TEXT  NULL,[COmmbtu] TEXT  NULL,[NOxmmbtu] TEXT  NULL,[COhr] TEXT  NULL,[NOxhr] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Sites] ([Site] TEXT  NULL,[Area] TEXT  NULL,[Facility] TEXT  NULL,[Customer] TEXT  NULL,PRIMARY KEY ([Site],[Customer]));";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [SnapShots] ("
                        + "[Time] TEXT DEFAULT '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''' NOT NULL,"
                        + "[O2] TEXT  NULL,[CO] TEXT  NULL,[CO2] TEXT  NULL,[NO] TEXT  NULL,[NO2] TEXT  NULL,[NOx] TEXT  NULL,[SO2] TEXT  NULL,[CxHy] TEXT  NULL,"
                        + "[Tgas] TEXT  NULL,[Tamb] TEXT  NULL,[Tcell] TEXT  NULL,[Efficiency] TEXT  NULL,[IFlow] TEXT  NULL,[Draft] TEXT  NULL,[Losses] TEXT  NULL,"
                        + "[ExcessAir] TEXT  NULL,[Notes] TEXT  NULL,[Date] TEXT  NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE [Test_Tables] ([Site] TEXT  NOT NULL,[Equipment] TEXT  NOT NULL,[Test] TEXT  PRIMARY KEY NOT NULL);";
                    sqlite_cmd.ExecuteNonQuery();
                    ////////////////////////////////////////////////////////////////
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    try
                    {
                        // Lets insert something into our new table:
                        sqlite_cmd.CommandText = "INSERT INTO Personal_Data (PData) Values(1)";

                        // And execute this again ;D
                        sqlite_cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        log.Debug(ex.Message + ex.StackTrace + "A");
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                catch (Exception ex)
                {
                    log.Debug(ex.Message + ex.StackTrace + "B");
                    MessageBox.Show(ex.StackTrace + ex.Message);
                }
            }


            DateTime now = DateTime.Now;
            if (new DateTime(now.Year, now.Month, now.Day) >= new DateTime(2013, 12, 31))
            {
                MessageBox.Show("The BETA portion has ended. Thank you for all your help.\n We truly appreciated it.");
                Application.Exit();
            }
            else
            {
                try
                {
                    log.Debug("Start Application Portion");
                    Application.EnableVisualStyles();
                    log.Debug("Application.EnableVisualStyles()");
                    Application.SetCompatibleTextRenderingDefault(false);
                    log.Debug("Application.SetCompatibleTextRenderingDefault(false)");
                    Application.Run(new MainMenu());
                    log.Debug("Main Menu Running");
                }
                catch (Exception ex)
                {
                    log.Debug(ex.Message + ex.StackTrace);
                }
            }

        }
    }
}
