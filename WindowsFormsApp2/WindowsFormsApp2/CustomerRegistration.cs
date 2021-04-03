using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormCustomerRegistration : Form
    {
        function fn = new function();
        string query;
        public FormCustomerRegistration()
        {
            InitializeComponent();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboardForm dash = new dashboardForm();
            dash.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void setComboBox(string query, ComboBox comb)
        {
            SqlDataReader dr = fn.getFromCombo(query);
            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    comb.Items.Add(dr.GetString(i));
                }
            }
            dr.Close();
        }

        private void btnAlloteCustomer_Click(object sender, EventArgs e)
        {
            if (txtCname.Text != "" && txtdob.Text != "" && txtCgender.Text != ""
                && txtMobile.Text != "" && txtid.Text != "" && txtaddress.Text != ""
                && txtcheckin.Text != "" && txtRtype.Text != "" && txtBedtype.Text != "" || txtRno.Text != ""
                && txtcheckout.Text != "" && txtPrice.Text != "")
            {
                string cName = txtCname.Text;
                string dob = txtdob.Text;
                string gender = txtCgender.Text;
                int mobileno = int.Parse(txtMobile.Text);
                string id = txtid.Text;
                string address = txtaddress.Text;
                string checkIn = txtcheckin.Text;
                string roomtype = txtRtype.Text;
                string bedtype = txtBedtype.Text;
                string roomNo = txtRno.Text;
                string checkOut = txtcheckout.Text;
                string Price = txtPrice.Text;
                query = "insert into Customer(cname,c_dob,C_gender,c_mobileNo,idproof,c_address,checkin,roomid) values('" + cName + "','" + dob + "','" + gender + "','" + mobileno + "','" + id + "','" + address + "','" + checkIn + "','" + rid + "') update rooms set booked='Yes' where roomNo='" + txtRno.Text + "'";
                fn.setData(query, "Room Number " + txtRno.Text + " allocation uccessfully done to the respected customer " + txtCname.Text + "yeeeeeeee");
                ClearAll();

            }
            else
            {
                MessageBox.Show("Kindly fill all the form", "Information!!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtRtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRno.Items.Clear();
            query = "select * roomNo from rooms where bed='" + txtBedtype.Text + "' and roomType='" + txtRtype.Text + "' and booked='No'";
            setComboBox(query, txtRno);
        }
        int rid;
        private void txtRno_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price,roomid from rooms where roomNo='"+txtRno.Text+"'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid =int.Parse( ds.Tables[0].Rows[0][1].ToString());
        }

        private void txtBedtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRtype.SelectedIndex = -1;
            txtRno.Items.Clear();
           
           
        }
        public void ClearAll()
        {
            txtCname.Clear();
            txtdob.ResetText();
            txtCgender.SelectedIndex = -1;
            txtMobile.Clear();
            txtid.Clear();
            txtaddress.Clear();
            txtcheckin.ResetText();
            txtRtype.SelectedIndex = -1;
            txtBedtype.SelectedIndex = -1;
            txtRno.SelectedIndex = -1;
            txtPrice.Clear();
        }
    }
}
