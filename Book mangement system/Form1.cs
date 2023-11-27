using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text;
using System.Linq;
using System.Drawing;
using CRUD;

namespace libarary_mangement_system
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
      
            InitializeComponent();

          


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("select *from Sinup", con);
            cmd.Parameters.Add("@username", System.Data.SqlDbType.NVarChar).Value = textBox1.Text;
            cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = textBox2.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Dashboard d = new Dashboard();
                d.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Sinup Failed");

            } 
        }
    }
}
