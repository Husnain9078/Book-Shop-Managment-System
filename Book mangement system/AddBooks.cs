using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using CRUD;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace libarary_mangement_system
{
    public partial class AddBooks : Form
    {
        
        public AddBooks()
        {
            InitializeComponent();
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SP_add_books", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@BookName", SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@AuthorName", SqlDbType.NVarChar).Value = textBox2.Text;
            cmd.Parameters.Add("@BookQuantity", SqlDbType.NVarChar).Value = textBox3.Text;
            cmd.Parameters.Add("@BookPrice", SqlDbType.NVarChar).Value = textBox4.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("BookAdded");
          
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            con.Close();
        }
    }
}
