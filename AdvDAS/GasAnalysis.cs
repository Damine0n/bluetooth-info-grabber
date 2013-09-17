using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finisar.SQLite;

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
        }
        public void newEntry(string note)
        {
            sqlite_cmd = sqlite_conn.CreateCommand();
            try
            {
                    // Lets insert something into our new table:
                    sqlite_cmd.CommandText = "INSERT INTO Readings (Time, O2, CO, CO2, NO, NO2, NOx, SO2, CxHy, Tgas, Tamb, Tcell, Efficiency, IFlow, Draft, Losses, ExcessAir, COmass, NOxmass, Notes) VALUES ("
                        + DateTime.Now + "," + protocol.vO2 + "," + protocol.vCO + "," + protocol.vCO2 + "," + protocol.vNO + "," + protocol.vNO2 + "," 
                        + protocol.vNOx + "," + protocol.vSO2 + "," + protocol.vCxHy + "," + protocol.vTgas + "," + protocol.vTamb + ","
                        + protocol.vTcell + "," + protocol.vEfficiency + "," + protocol.vIFlow + "," + protocol.vDraft + ","
                        + protocol.vLosses + "," + protocol.vExcessAir + "," + protocol.vCOmass + "," + protocol.vNOxmass + ",'" + note + "');";

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
