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
    
    public partial class Dashboard : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        public Dashboard()
        {
            InitializeComponent();
            BindGridView();
        }

      

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Image";
            ofd.Filter = "All Files *.* | *.*";
            ofd.ShowDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
            }
        }

        private void insert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "INSERT INTO SMEDICINES VALUES(@mid,@type,@name,@price,@image)";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@mid", textBox1.Text);
            cmd.Parameters.AddWithValue("@type", idtextbox.Text);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@price",pricetextbox.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Medicines Inserted Successfully", "Succeed!");
                BindGridView();
                ResetControl();
                con.Close();
               
            }
            else
            {
                MessageBox.Show("There's some problem", "Error!");
            }
        }
        private object SavePhoto()
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.GetBuffer();
        }

        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT * FROM smedicines";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            DataGridViewImageColumn dgv = new DataGridViewImageColumn();
            dgv = (DataGridViewImageColumn)dataGridView1.Columns[4];
            dgv.ImageLayout = DataGridViewImageCellLayout.Stretch;


            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            ResetControl();
        }

         void ResetControl()
        {
            textBox1.Clear();
            idtextbox.Clear();
            nametextbox.Clear();
            pricetextbox.Clear();
            pictureBox1.Image = Properties.Resources.up;
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            idtextbox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nametextbox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pricetextbox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);


        }

        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void update_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "UPDATE SMEDICINES SET mid=@mid,type=@type,name=@name,price=@price,image=@image where mid=@mid";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@mid", textBox1.Text);
            cmd.Parameters.AddWithValue("@type", idtextbox.Text);
            cmd.Parameters.AddWithValue("@name", nametextbox.Text);
            cmd.Parameters.AddWithValue("@price", pricetextbox.Text);
            cmd.Parameters.AddWithValue("@image", SavePhoto());

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Medicines Updated Successfully", "Succeed!");
                BindGridView();
                ResetControl();
                con.Close();

            }
            else
            {
                MessageBox.Show("There's some problem", "Error!");
            }

        }

        private void delete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "DELETE FROM SMEDICINES WHERE mid=@mid";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.Parameters.AddWithValue("@mid", textBox1.Text);

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Medicines Deleted Successfully!", "Deleted!");
                BindGridView();
                ResetControl();
                con.Close();

            }
            else
            {
                MessageBox.Show("There's some problem", "Error!");
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Homepage hp2 = new Homepage();
            hp2.Show();
            this.Hide();
        }

        private void userQueriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_Queries u1 = new User_Queries();
            u1.Show();
            this.Hide();
                
            
        }

        
    }
}
