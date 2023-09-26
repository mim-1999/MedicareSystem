﻿using System;
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
    public partial class Response : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["sq"].ConnectionString;

        public Response()
        {
            InitializeComponent();
            BindGridView();

        }
        void BindGridView()
        {
            SqlConnection con = new SqlConnection(cs);
            string query = "SELECT response FROM response";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable data = new DataTable();
            sda.Fill(data);
            dataGridView1.DataSource = data;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.RowTemplate.Height = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buyer_Dashboard b3 = new Buyer_Dashboard();
            b3.Show();
            this.Hide();
        }
    }
}
