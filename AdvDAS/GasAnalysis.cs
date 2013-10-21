using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
//using System.Data.SQLite;
using Finisar.SQLite;
using System.IO;

namespace CRS
{
    class GasAnalysis
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        public static string equipment = "";
        public static string site = "";
        private DateTime timeTaken;
        public GasAnalysis()
        {
            sqlite_conn.Open();
        }
        public GasAnalysis(DateTime timeTaken)
        {
            this.timeTaken = timeTaken;
            sqlite_conn.Open();
        }
        public string newEntry(J2KNProtocol protocol)
        {
            string tableName = "";
            if (equipment.Equals(""))
            {
                return "Error";
            }
            else
            {
                for (int i = 1; i < 10000; i++)
                {
                    try
                    {
                        tableName = "Test_" + i + "_" + DateTime.Now.ToString("MM_dd_yy");
                        //Creates a new table:
                        sqlite_cmd = sqlite_conn.CreateCommand();
                        sqlite_cmd.CommandText = "CREATE TABLE " + tableName + " AS SELECT * FROM Readings WHERE 0;";
                        sqlite_cmd.ExecuteNonQuery();

                        //Inserts something into our new table:
                        sqlite_cmd = sqlite_conn.CreateCommand();
                        sqlite_cmd.CommandText = "INSERT INTO  " + tableName + " (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                        + "Losses, ExcessAir) VALUES ('"
                        + DateTime.Now.ToString("HH:mm:ss") + "','" + protocol.vO2 + "','" + protocol.vCO + "','"
                        + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','" + protocol.vNOx + "','" + protocol.vSO2 + "','"
                        + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','" + protocol.vTcell + "','" + protocol.vEfficiency + "','"
                        + protocol.vIFlow + "','" + protocol.vDraft + "','" + protocol.vLosses + "','" + protocol.vExcessAir + "');";

                        // And execute this again ;D
                        sqlite_cmd.ExecuteNonQuery();

                        sqlite_cmd = sqlite_conn.CreateCommand();
                        sqlite_cmd.CommandText = "INSERT INTO Test_Tables (Site, Equipment, Test) VALUES ('" + site + "','" + equipment + "','" + tableName + "');";
                        sqlite_cmd.ExecuteNonQuery();
                        break;
                    }
                    catch
                    {
                        continue;
                    }

                }

                return tableName;
            }



        }
        public void newEntry(J2KNProtocol protocol, string x)
        {
            try
            {
                //Inserts something into our new table:
                sqlite_cmd = sqlite_conn.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO  " + x + " (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                + "Losses, ExcessAir) VALUES ('"
                + DateTime.Now.ToString("HH:mm:ss") + "','" + protocol.vO2 + "','" + protocol.vCO + "','"
                + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','" + protocol.vNOx + "','" + protocol.vSO2 + "','"
                + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','" + protocol.vTcell + "','" + protocol.vEfficiency + "','"
                + protocol.vIFlow + "','" + protocol.vDraft + "','" + protocol.vLosses + "','" + protocol.vExcessAir + "');";

                // And execute this again ;D
                sqlite_cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public void SnapShot(J2KNProtocol protocol, string note, bool testing, string tableName)
        {
            if (testing)
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                try
                {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO " + tableName + " (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                        + "Losses, ExcessAir, COmass, NOxmass, Notes) VALUES ('"
                        + timeTaken.ToString("HH:mm:ss") + "','" + protocol.vO2 + "','" + protocol.vCO + "','" + protocol.vCO2 + "','" 
                        + protocol.vNO + "','" + protocol.vNO2 + "','" + protocol.vNOx + "','" + protocol.vSO2 + "','" + protocol.vCxHy + "','" + protocol.vTgas + "','" 
                        + protocol.vTamb + "','"+ protocol.vTcell + "','" + protocol.vEfficiency + "','" + protocol.vIFlow + "','" + protocol.vDraft + "','"
                        + protocol.vLosses + "','" + protocol.vExcessAir + "','" + protocol.vCOmass + "','" + protocol.vNOxmass + "','" + note + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                for (int i = 0; i < 10000; i++)
                {
                    try
                    {
                        // Lets insert something into our new table:
                        sqlite_cmd.CommandText = "INSERT INTO SnapShots (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                            + "Losses, ExcessAir, Notes, Date, Index) VALUES ('"
                            + timeTaken.ToString("HH:mm:ss") + "','" + protocol.vO2 + "','" + protocol.vCO + "','" + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','"
                            + protocol.vNOx + "','" + protocol.vSO2 + "','" + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','"
                            + protocol.vTcell + "','" + protocol.vEfficiency + "','" + protocol.vIFlow + "','" + protocol.vDraft + "','"
                            + protocol.vLosses + "','" + protocol.vExcessAir + "','" + note + "','" + timeTaken.ToString("MM/dd/yyyy") + "','" +i+"');";

                        // And execute this again ;D
                        sqlite_cmd.ExecuteNonQuery();
                        break;
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace);
                        continue;
                    }
                }
            }
        }
    }
}
