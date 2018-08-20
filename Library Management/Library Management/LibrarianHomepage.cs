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
    public partial class LibrarianHomepage : Form
    {
        public LibrarianHomepage()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
            this.Hide();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Notice no = new Notice();
            no.StartPosition = FormStartPosition.CenterScreen;
            no.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update_Faculty_Registration obj = new Update_Faculty_Registration();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Update_Member_Profile us = new Update_Member_Profile();
            us.StartPosition = FormStartPosition.CenterScreen;
            us.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FacultyRegistration mr = new FacultyRegistration();
            mr.StartPosition = FormStartPosition.CenterScreen;
            mr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MemberRegistration ms = new MemberRegistration();
            ms.StartPosition = FormStartPosition.CenterScreen;
            ms.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update_Member_Profile uf = new Update_Member_Profile();
            uf.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Update_Member_Profile us = new Update_Member_Profile();
            us.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AddingBook aa = new AddingBook();
            aa.StartPosition = FormStartPosition.CenterScreen;
            aa.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            BookRecords br = new BookRecords();
            br.StartPosition = FormStartPosition.CenterScreen;
            br.Show();
            this.Hide();
        }

        private void LibrarianHomepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
