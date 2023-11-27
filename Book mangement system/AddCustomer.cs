using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CRUD;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace libarary_mangement_system
{
    public partial class AddCustomer : Form
    {
        
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("spp_addCustomers", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Customer_Name", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@Customer_ID", SqlDbType.NVarChar).Value = textBox2.Text;
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("customer added");

            textBox1.Text = "";
            textBox2.Text = "";
           
            con.Close();
        }
    }
}
