using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class dashboardForm : Form
    {
        public dashboardForm()
        {
            InitializeComponent();
        }

        private void btnaddroom_Click(object sender, EventArgs e)
        {
            this.Hide();
            addroom r = new addroom();
            r.Show();
        }

        private void btncustomerreg_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCustomerRegistration cust = new FormCustomerRegistration();
            cust.Show();
        }

        private void dashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }

        private void btncheckout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Checkout c = new Checkout();
            c.Show();
            
        }
    }
}
