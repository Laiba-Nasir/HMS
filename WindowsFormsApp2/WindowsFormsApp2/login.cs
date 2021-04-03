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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaCirclePictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "laiba" && txtPassword.Text == "5555")
            {
                txtforgot.Visible =false;
                dashboardForm form3 = new dashboardForm();
                this.Hide();
                form3.Show();
            }
            else
            {
                txtforgot.Visible = true;
                txtPassword.Clear();

            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.Show();
        }
    }
}
