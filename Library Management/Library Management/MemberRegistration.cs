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
    public partial class MemberRegistration : Form
    {
        public MemberRegistration()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            LibrarianHomepage lh = new LibrarianHomepage();
            lh.StartPosition = FormStartPosition.CenterScreen;
            lh.Show();
            this.Hide();

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            
            DBDataContext DB = new DBDataContext();

            Login w = new Login();
            w.Username = textBox1.Text; //new user k login database e pathysi
            w.Password = textBox9.Text; //new password k login database e pathysi
            w.Role = "Student";         //this is only for student

            MR m = new MR();
            m.Username = textBox1.Text;
            m.Name = textBox2.Text;
            m.Email = textBox3.Text;
            m.Department = comboBox2.Text;
            m.Address = textBox4.Text;
            m.Contact_No = textBox5.Text;
            m.Gender = comboBox1.Text;
           
            m.Blood_Group = comboBox3.Text;
            m.Books_Type = comboBox4.Text;
            m.Books_Name = textBox6.Text;
            m.Author_Editor = textBox7.Text;
            m.Book_Can_Hold = textBox8.Text;
            m.Password = textBox9.Text;

            DB.MRs.InsertOnSubmit(m);
            DB.Logins.InsertOnSubmit(w);
            DB.SubmitChanges();
            MessageBox.Show("Student Added!!");
            
        }

        private void MemberRegistration_Load(object sender, EventArgs e)
        {

        }

        private void MemberRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
