using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class function
    {
        //Get Connection of database and server
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=DESKTOP-GCQ36SA\\SQLEXPRESS;database=HMS;integrated security=True";
            return con;
        }
        //get data from database
        public DataSet getData(String query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(string query,string message)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("' " + message + " '", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public SqlDataReader getFromCombo(string query)
        {
            SqlConnection con = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
