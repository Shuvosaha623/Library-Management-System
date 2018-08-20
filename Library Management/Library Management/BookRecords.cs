using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management
{
    public partial class BookRecords : Form
    {
        public BookRecords()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianHomepage lh = new LibrarianHomepage();
            lh.StartPosition = FormStartPosition.CenterScreen;
            lh.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            
            string id = textBox2.Text;
            AB s = DB.ABs.SingleOrDefault(x => x.Book_Id == id);
            if (s != null)
            {
                textBox1.Text = s.Book_Name;
                textBox3.Text =s.Quantity;
                
                
            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void BookRecords_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            string id = textBox2.Text;
            AB s = DB.ABs.SingleOrDefault(x => x.Book_Id == id);
            if (s != null)
            {
              
                s.Book_Id = textBox2.Text;
                s.Book_Name = textBox1.Text;
                s.Quantity = textBox3.Text;
                DB.SubmitChanges();
                MessageBox.Show("Information Updated!!");
            }
           
            
           
        }

        private void BookRecords_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
