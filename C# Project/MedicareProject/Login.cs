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
    public partial class Login : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public Login()
        {
            InitializeComponent();
        }

       

        private void showpasswordcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool status = showpasswordcheckbox.Checked;
            switch (status)
            {
                case true:
                    logpasswordtextbox.UseSystemPasswordChar = false;
                    break;
                default:
                    logpasswordtextbox.UseSystemPasswordChar = true;
                    break;

            }
        }

        private void logusertextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logusertextbox.Text) == true)
            {
                logusertextbox.Focus();
                errorProvider1.SetError(this.logusertextbox, "Please fill the field first!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void logpasswordtextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(logpasswordtextbox.Text) == true)
            {
                logpasswordtextbox.Focus();
                errorProvider2.SetError(this.logpasswordtextbox, "Please fill the field first!");
            }
            else
            {
                errorProvider2.Clear();
            }

        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (logusertextbox.Text != "" && logpasswordtextbox.Text != "")
            {
                SqlConnection con = new SqlConnection(cs);
                string query = "SELECT * FROM SUPPLIER where username= @username and password=@password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", logusertextbox.Text);
                cmd.Parameters.AddWithValue("@password", logpasswordtextbox.Text);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    MessageBox.Show("Login Successful", "Succeed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dashboard obd=new Dashboard();
                    obd.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage p5 = new Homepage();
            p5.Show();
            this.Hide();
        }
    }
}
