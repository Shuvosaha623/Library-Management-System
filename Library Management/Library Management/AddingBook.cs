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
    public partial class AddingBook : Form
    {
        public AddingBook()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();

            AB w = new AB();

            w.Book_Id = textBox2.Text;
            w.Book_Name = textBox1.Text;
            w.Quantity = textBox3.Text;

            DB.ABs.InsertOnSubmit(w);
            DB.SubmitChanges();
            MessageBox.Show("Book Added!!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LibrarianHomepage al = new LibrarianHomepage();
            al.StartPosition = FormStartPosition.CenterScreen;
            al.Show();
            this.Hide();
        }

        private void AddingBook_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
