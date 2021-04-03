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
    public partial class addroom : Form
    {
        function fn = new function();
        string query;
        public addroom()
        {
            InitializeComponent();
        }
        public void clearData()
        {
            txtRno.Clear();
            txtRtype.SelectedIndex = -1;
            txtBedtype.SelectedIndex = -1;
            txtPrice.Clear();
        }
        private void addroom_Load(object sender, EventArgs e)
        {
            query = "SELECT * from rooms";
          DataSet ds=  fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRno.Text != "" && txtRtype.Text != "" && txtBedtype.Text != "" && txtPrice.Text != "")
            {
                string roomno = txtRno.Text;
                string rtype = txtRtype.Text;
                string bedd = txtBedtype.Text;
                Int64 price = Int64.Parse(txtPrice.Text);
                query = "insert into rooms(roomNo,roomType,bed,price)values('"+roomno+"','"+ rtype+"','"+bedd+"',"+price+")";
                fn.setData(query, "Room Added Successfully yeahhhhhhhh");
                addroom_Load(this,null);
                clearData();
            }
            else
            {
                MessageBox.Show("Kindly fill the all section to proceed", "Warning!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboardForm dash = new dashboardForm();
            dash.Show();
        }
    }
}
