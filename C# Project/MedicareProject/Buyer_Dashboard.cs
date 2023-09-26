using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicareProject
{
    public partial class Buyer_Dashboard : Form
    {
        public Buyer_Dashboard()
        {
            InitializeComponent();
        }

        private void adviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdviceForm af = new AdviceForm();
            af.Show();
            this.Hide();
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cart c1 = new Cart();
            c1.Show();
            this.Hide();
        }

           

        private void yourCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Response r1 = new Response();
            r1.Show();
            this.Hide();
        }

        private void logoutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Homepage hp = new Homepage();
            hp.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
