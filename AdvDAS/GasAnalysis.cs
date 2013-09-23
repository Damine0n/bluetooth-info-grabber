using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Finisar.SQLite;
using System.IO;

namespace CRS
{
    class GasAnalysis
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private J2KNProtocol protocol;
        public GasAnalysis(J2KNProtocol protocol)
        {
            this.protocol = protocol;
            sqlite_conn.Open();
        }
        public string newEntry()
        {
            string tableName="";
            for (int i = 1; i < 10000; i++)
            {
                try
                {                    
                    //Creates a new table:
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "CREATE TABLE Test_" + i + " AS SELECT * FROM Test_1 WHERE 0;";
                    sqlite_cmd.ExecuteNonQuery();

                    //Inserts something into our new table:
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO  Test_" + i + " (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                    + "Losses, ExcessAir, COmass, NOxmass) VALUES ('"
                    + DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US")) + "','" + protocol.vO2 + "','" + protocol.vCO + "','" 
                    + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','"+ protocol.vNOx + "','" + protocol.vSO2 + "','" 
                    + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','"+ protocol.vTcell + "','" + protocol.vEfficiency + "','" 
                    + protocol.vIFlow + "','" + protocol.vDraft + "','"+ protocol.vLosses + "','" + protocol.vExcessAir + "','" + protocol.vCOmass + "','" 
                    + protocol.vNOxmass + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                    tableName="Test_"+i;
                    System.Windows.Forms.MessageBox.Show(i.ToString());
                    break;
                    
                }
                catch
                {                    
                    continue;
                }
                 
            }
            System.Windows.Forms.MessageBox.Show(tableName);
            return tableName;
                
            
        }
        public void newEntry(string x)
        {
            try
                {
                    //Inserts something into our new table:
                    sqlite_cmd = sqlite_conn.CreateCommand();
                    sqlite_cmd.CommandText = "INSERT INTO " + x + " (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                    + "Losses, ExcessAir, COmass, NOxmass) VALUES ('"
                    + DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US")) + "','" + protocol.vO2 + "','" + protocol.vCO + "','" + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','"
                    + protocol.vNOx + "','" + protocol.vSO2 + "','" + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','"
                    + protocol.vTcell + "','" + protocol.vEfficiency + "','" + protocol.vIFlow + "','" + protocol.vDraft + "','"
                    + protocol.vLosses + "','" + protocol.vExcessAir + "','" + protocol.vCOmass + "','" + protocol.vNOxmass + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                }
                catch
                {

                }
        }
        public void newEntry(string note, bool testing)
        {
            if (testing)
            {
                sqlite_cmd = sqlite_conn.CreateCommand();
                try
                {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO Readings (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                        + "Losses, ExcessAir, COmass, NOxmass, Notes) VALUES ('"
                        + DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US")) + "','" + protocol.vO2 + "','" + protocol.vCO + "','" + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','"
                        + protocol.vNOx + "','" + protocol.vSO2 + "','" + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','"
                        + protocol.vTcell + "','" + protocol.vEfficiency + "','" + protocol.vIFlow + "','" + protocol.vDraft + "','"
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
                try
                {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO SnapShots (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft,"
                        + "Losses, ExcessAir, COmass, NOxmass, Notes) VALUES ('"
                        + DateTime.Now.ToString("T", CultureInfo.CreateSpecificCulture("en-US")) + "','" + protocol.vO2 + "','" + protocol.vCO + "','" + protocol.vCO2 + "','" + protocol.vNO + "','" + protocol.vNO2 + "','"
                        + protocol.vNOx + "','" + protocol.vSO2 + "','" + protocol.vCxHy + "','" + protocol.vTgas + "','" + protocol.vTamb + "','"
                        + protocol.vTcell + "','" + protocol.vEfficiency + "','" + protocol.vIFlow + "','" + protocol.vDraft + "','"
                        + protocol.vLosses + "','" + protocol.vExcessAir + "','" + protocol.vCOmass + "','" + protocol.vNOxmass + "','" + note + "');";

                    // And execute this again ;D
                    sqlite_cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
