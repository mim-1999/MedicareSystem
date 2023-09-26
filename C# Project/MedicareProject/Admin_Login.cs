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

namespace MedicareProject
{
    public partial class Admin_Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public Admin_Login()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (text1.Text != "" && textBox1.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * from admin where username= @username and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", text1.Text);
                cmd.Parameters.AddWithValue("@password", textBox1.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Admin_Dashboard adb = new Admin_Dashboard();
                    adb.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please fill both fields!", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void text1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text1.Text) == true)
            {
                text1.Focus();
                errorProvider1.SetError(this.text1, "Please fill the field first!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void text2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                textBox1.Focus();
                errorProvider2.SetError(this.textBox1, "Please fill the field first!");
            }
            else
            {
                errorProvider2.Clear();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage hp4 = new Homepage();
            hp4.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Homepage p9 = new Homepage();
            p9.Show();
            this.Hide();
        }
    }
}
