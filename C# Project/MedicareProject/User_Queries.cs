using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace MedicareProject
{
    public partial class User_Queries : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public User_Queries()
        {
            InitializeComponent();
            BindGridView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO RESPONSE VALUES(@response)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            cmd.Parameters.AddWithValue("@response", textBox4.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully sent", "Succeed!");
                Dashboard d9 = new Dashboard();
                d9.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("There's some error", "failed!");
            }
        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM badvices";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 55;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dashboard dsb = new Dashboard();
            dsb.Show();
            this.Hide();
        }
    }
}
