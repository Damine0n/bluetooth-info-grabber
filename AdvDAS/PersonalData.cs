using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvDAS
{
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Add Logo";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string s = ofd.FileName;
                pictureBox1.ImageLocation = s;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox5.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
