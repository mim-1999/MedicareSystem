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
    public partial class AdviceForm : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public AdviceForm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO badvices VALUES(@typeofdisease,@otherdisease,@explainprob)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            cmd.Parameters.AddWithValue("@typeofdisease", textBox1.Text);
            cmd.Parameters.AddWithValue("@otherdisease", textBox2.Text);
            cmd.Parameters.AddWithValue("@explainprob", textBox3.Text);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Successfully sent", "Succeed!");
                Buyer_Dashboard bd6 = new Buyer_Dashboard();
                bd6.Show();
                this.Hide();
                con.Close();
            }
            else
            {
                MessageBox.Show("Error", "failed!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buyer_Dashboard db7 = new Buyer_Dashboard();
            db7.Show();
            this.Hide();
        }
    }
}
