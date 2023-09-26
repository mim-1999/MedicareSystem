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
    public partial class Registration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            string gender="";
            if (maleradiobutton.Checked == true)
            {
                gender = "male";
            }
            if (femaleradiobutton.Checked == true)
            {
                gender = "female";
            }
            if (nametextbox.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (usernametextbox.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (passwordtextbox.Text == "")
            {
                MessageBox.Show("Password cannot be not empty");
            }
            else if (confirmpasswordtextbox.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be not empty");
            }
            else if (emailtextbox.Text == "")
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (emailtextbox.Text.Contains('@') == false)
            {
                MessageBox.Show("Email must have an '@'sign");
            }
            else if (maleradiobutton.Checked == false && femaleradiobutton.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (bloodgroupcombobox.Text == "")
            {
                MessageBox.Show("Select a bloodgroup");
            }
            else if (passwordtextbox.Text != confirmpasswordtextbox.Text)
            {
                    MessageBox.Show("Password didn't match");
            }

            else
            {
                
                SqlConnection con = new SqlConnection(cs);
                string query = "INSERT INTO SUPPLIER VALUES(@name,@username,@password,@email,@gender,@bloodgroup)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
           
                cmd.Parameters.AddWithValue("@name", nametextbox.Text);
                cmd.Parameters.AddWithValue("@username", usernametextbox.Text);
                cmd.Parameters.AddWithValue("@password", passwordtextbox.Text);
                cmd.Parameters.AddWithValue("@email", emailtextbox.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodgroupcombobox.SelectedItem);

                int a = cmd.ExecuteNonQuery();
                if (a > 0)
                {
                    MessageBox.Show("Registration Successful", "Succeed!");
                    Homepage obj = new Homepage();
                    obj.Show();
                    this.Hide();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Registration failed", "failed!");
                }
               
             }
            
        }

        private void termscheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if(termscheckbox.Checked==true)
            {
                submitbutton.Enabled = true;
            }
            else
                submitbutton.Enabled = false;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Homepage dm = new Homepage();
            dm.Show();
            this.Hide();
        }
    }
}
