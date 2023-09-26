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
    public partial class ViewMedicine1 : Form
    {
        public ViewMedicine1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin_Dashboard a = new Admin_Dashboard();
            a.Show();
            this.Hide();
        }
    }
}
