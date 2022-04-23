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

namespace MovieDatabase
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            showData();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\amali\Documents\movies.mdf;Integrated Security=True;Connect Timeout=30 ");
        private void showData()
        {
            con.Open();
            string q = "select * from MV";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            dgv.DataSource = ds.Tables[0];
            con.Close();
        }
        private void HOw_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
