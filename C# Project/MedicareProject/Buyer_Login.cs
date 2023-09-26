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
    public partial class Buyer_Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public Buyer_Login()
        {
            InitializeComponent();
        }

        

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && textbox2.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM BUYER where username= @username and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textbox1.Text);
                cmd.Parameters.AddWithValue("@password", textbox2.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Buyer_Dashboard bd = new Buyer_Dashboard();
                    bd.Show();
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

        private void textbox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox1.Text) == true)
            {
                textbox1.Focus();
                errorProvider1.SetError(this.textbox1, "Please fill the field first!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void textbox2_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textbox2.Text) == true)
            {
                textbox2.Focus();
                errorProvider2.SetError(this.textbox2, "Please fill the field first!");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            bool status = checkbox.Checked;
            switch (status)
            {
                case true:
                    textbox2.UseSystemPasswordChar = false;
                    break;
                default:
                    textbox2.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage p6 = new Homepage();
            p6.Show();
            this.Hide();

        }
    }
}
