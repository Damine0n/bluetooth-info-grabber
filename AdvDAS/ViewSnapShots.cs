using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SQLite;
using Finisar.SQLite;
namespace CRS
{
    public partial class ViewSnapShots : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        DataTable ds = new DataTable();
        public ViewSnapShots()
        {
            InitializeComponent();
            LoadTable();
            AutoCompleteTest();
            if (MainMenu.equipment.Equals("Equipment: Not Selected"))
            {
                button1.Enabled = false;
            }
        }

        private void LoadTable()
        {
            // We use these three SQLite objects:
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "Select";
            CBColumn.FalseValue = "0";
            CBColumn.TrueValue = "1";
            sqlite_conn.Open();
            try
            {
                var da = new SQLiteDataAdapter("SELECT * FROM SnapShots;", sqlite_conn);
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
        }

        void AutoCompleteTest()
        {
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                sqlite_cmd = new SQLiteCommand("SELECT * FROM Test_Tables;", sqlite_conn);
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                while (sqlite_datareader.Read())
                {
                    string tests = sqlite_datareader[1].ToString();
                    coll.Add(tests);
                }
                sqlite_datareader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            tbSearch.AutoCompleteCustomSource = coll;
        }
        private void Print_Click(object sender, EventArgs e)
        {
            List<string> snapData = new List<string>();
            for (int j = 0; j < dataGridView1.SelectedRows.Count; j++)
            {
                string data="";
                for (int k = 0; k < dataGridView1.ColumnCount ;k++ )
                {
                    data += dataGridView1.SelectedRows[j].Cells[k].Value.ToString() + " _ ";
                }
                snapData.Add(data);
            }
            PrintDocs pdocs = new PrintDocs();
            pdocs.printSnapShot(snapData);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(ds);
            DV.RowFilter = string.Format("Time LIKE '%{0}%'", tbSearch.Text);
            dataGridView1.DataSource = DV;
        }

    }
}
