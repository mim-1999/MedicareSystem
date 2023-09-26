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
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        
        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Registration obj = new Registration();
            obj.Show();
            this.Hide();

           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login obj2 = new Login();
            obj2.Show();
            this.Hide();
        }

        private void registrationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buyer_Registration b1 = new Buyer_Registration();
            b1.Show();
            this.Hide();
                
            

        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Buyer_Login l1 = new Buyer_Login();
            l1.Show();
            this.Hide();
        }

        private void loginToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Admin_Login al = new Admin_Login();
            al.Show();
            this.Hide();

        }

        
    }
}
