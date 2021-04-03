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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //progressBar1.Value = 0;
            //progressBar1.Value = progressBar1.Value + 4;
            //label1.Text = progressBar1.Value + "% Completed";
            //if (progressBar1.Value == 100)
            //{
            //    timer1.Enabled = false;
            //    this.Hide();
            //    Form2 f = new Form2();
            //    f.Show();

            ////}
            //progressBar1.Value = 0;
            //do
            //{
            //    progressBar1.Value = progressBar1.Value + 4;
            //    label1.Text = progressBar1.Value + "% Completed";


            //} while (progressBar1.Value < 100);
            //if (progressBar1.Value == 100)
            //{
            //    timer1.Enabled = false;
            //    this.Visible = false;

            //    //Form2 f = new Form2();
            //    //f.Show();

            //}

        //    progressBar1.Value = 0;
        //j:
        //    while (progressBar1.Value < 100)
        //    {
        //        progressBar1.Value = progressBar1.Value + 4;
        //        label1.Text = progressBar1.Value + "% Completed";
        //        if (progressBar1.Value == 100)
        //        {
        //            timer1.Enabled = false;
        //            this.Visible = false;
        //            Form2 f = new Form2();
        //            f.Show();
        //        }
        //        else { goto j; }
        //    }



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm f2 = new loginForm();
            f2.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
