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
    public partial class Admin_Dashboard : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All Files *.* | *.*";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(ofd.FileName);
            }
        }
        private object SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox2.Image.Save(ms, pictureBox2.Image.RawFormat);
            return ms.GetBuffer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO admininfoss VALUES(@name,@email,@gender,@mobile,@bloodgroup)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();

            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@gender", textBox3.Text);
            cmd.Parameters.AddWithValue("@mobile",textBox4.Text);
            cmd.Parameters.AddWithValue("@bloodgroup", textBox5.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show(" Successfully data added", "Succeed!");
                
            }
            else
            {
                MessageBox.Show("There's some error", "failed!");
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Homepage p2 = new Homepage();
            p2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ViewMedicine1 vm1 = new ViewMedicine1();
            vm1.Show();
            this.Hide();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMedicine am = new AddMedicine();
            am.Show();
            this.Hide();

        }
    }
}
