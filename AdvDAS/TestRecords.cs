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
    public partial class TestRecords : Form
    {
        private SQLiteConnection sqlite_conn = new SQLiteConnection("Data Source=database1.db;Version=3;");
        private SQLiteCommand sqlite_cmd;
        private SQLiteDataReader sqlite_datareader;
        PrintDocs pDocs = new PrintDocs();
        DataTable ds = new DataTable();
        public TestRecords()
        {
            InitializeComponent();
            LoadTable();
            AutoCompleteTest();
        }

        private void LoadTable()
        {
            // We use these three SQLite objects:
            DataGridViewCheckBoxColumn CBColumn = new DataGridViewCheckBoxColumn();
            CBColumn.HeaderText = "Select";
            CBColumn.FalseValue = "0";
            CBColumn.TrueValue = "1";
            
            
                try
                {sqlite_conn.Open();
                    var da = new SQLiteDataAdapter("SELECT * FROM Test_Tables;", sqlite_conn);
                    da.Fill(ds);
                    bindingSource1.DataSource = ds;
                    dataGridView1.DataSource = bindingSource1;
                    //dataGridView1.Columns.Insert(dataGridView1.ColumnCount,CBColumn);
                    da.Update(ds);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            MainMenu.tested = dataGridView1.RowCount;
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
                MessageBox.Show(ex.Message);
            }
            tbSearch.AutoCompleteCustomSource = coll;
        }
        private void Print_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                MessageBox.Show(dataGridView1.SelectedRows[i].Cells[0].Value.ToString() + " , " + dataGridView1.SelectedRows[i].Cells[1].Value.ToString() + " , " + dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
                pDocs.printReport(dataGridView1.SelectedRows[i].Cells[0].Value.ToString(), dataGridView1.SelectedRows[i].Cells[1].Value.ToString(), dataGridView1.SelectedRows[i].Cells[2].Value.ToString());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(ds);
            DV.RowFilter = string.Format("Test LIKE '%{0}%' or Equipment LIKE '%{0}%' or Site LIKE '%{0}%'", tbSearch.Text);
            dataGridView1.DataSource = DV;
            
        }

    }
}
