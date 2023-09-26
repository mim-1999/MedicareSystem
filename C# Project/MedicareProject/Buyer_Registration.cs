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
    public partial class Buyer_Registration : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public Buyer_Registration()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button1.Enabled = true;
            }
            else
                button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButton1.Checked == true)
            {
                gender = "male";
            }
            if (radioButton2.Checked == true)
            {
                gender = "female";
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Name cannot be empty");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Username can not be empty");
            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Password cannot be not empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Confirm Password cannot be not empty");
            }
            else if (textBox5.Text == "")
            {
                MessageBox.Show("Email can not be empty");
            }
            else if (textBox5.Text.Contains('@') == false)
            {
                MessageBox.Show("Email must have an '@'sign");
            }
            else if (radioButton1.Checked == false && radioButton2.Checked == false)
            {
                MessageBox.Show("Select a gender");
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Select a bloodgroup");
            }
            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show("Password didn't match");
            }

            else
            {

                SqlConnection con = new SqlConnection(cs);
                string query = "INSERT INTO BUYER VALUES(@name,@username,@password,@email,@gender,@bloodgroup)";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox3.Text);
                cmd.Parameters.AddWithValue("@email", textBox4.Text);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@bloodgroup", comboBox1.SelectedItem);

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

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage bdm = new Homepage();
            bdm.Show();
            this.Hide();
                
        }
    }
}
