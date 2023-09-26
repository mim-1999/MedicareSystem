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

    public partial class Cart : Form
    {
        public static int gv = 0;


        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;
        
        public Cart()
        {
            InitializeComponent();
            BindGridView();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pictureBox1.Image = GetPhoto((byte[])dataGridView1.SelectedRows[0].Cells[4].Value);
        }
        private Image GetPhoto(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            
                num1 = Convert.ToInt32(textBox4.Text);
                gv = num1 + gv;
                
            
            label8.Text = Convert.ToString(gv);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Buyer_Dashboard b7 = new Buyer_Dashboard();
            b7.Show();
            this.Hide();
        }

        
    }
}
