using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SikayetGoster
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=TRSA-TP061540\SQLEXPRESS; Initial Catalog=TurkTelekom; Integrated Security=SSPI; Persist Security Info=false; Trusted_Connection=Yes");
        DataTable table = new DataTable();

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from Sikayetler order by S_ID desc", con);
            adtr.Fill(table);
            dataGridView1.DataSource = table;

        }
    }
}
