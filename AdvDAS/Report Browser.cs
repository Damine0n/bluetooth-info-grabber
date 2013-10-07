using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Finisar.SQLite;

namespace CRS
{
    public partial class ReportBrowser : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataSet1 ds = new DataSet1();
        public ReportBrowser()
        {
            InitializeComponent();
            
            
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.DataBindings.Add("Table", bindingSource1, "");
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void ReportBrowser_Load(object sender, EventArgs e)
        {
var da = new SQLiteDataAdapter("SELECT * FROM Personal_Data WHERE PData = 1;", sqlite_conn);
            da.Fill(ds);

        }
    }
}
