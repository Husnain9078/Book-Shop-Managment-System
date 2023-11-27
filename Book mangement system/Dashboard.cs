using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace libarary_mangement_system
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBooks f = new AddBooks();
            f.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
                vb.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCustomer ac = new AddCustomer();
            ac.Show();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewCustomer vc = new ViewCustomer();
            vc.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SearchBooks sc = new SearchBooks();
            sc.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteBooks db = new DeleteBooks();
            db.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BooksRepot br = new BooksRepot();
            br.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnBooks rb = new ReturnBooks();
            rb.Show();
        }
    } 
}
