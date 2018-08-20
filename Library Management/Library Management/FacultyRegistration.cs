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
    public partial class FacultyRegistration : Form
    {
        public FacultyRegistration()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();

            Login w = new Login();
            w.Username = textBox1.Text;
            w.Password = textBox9.Text;
            w.Role = "Faculty";
            FR m = new FR();
            m.Username = textBox1.Text;
            m.Name = textBox2.Text;
            m.Email = textBox3.Text;
            m.Designation = textBox10.Text;
            m.Address = textBox4.Text;
            m.Contact_Number = textBox5.Text;
            m.Gender = comboBox1.Text;
           
            m.Blood_Group = comboBox3.Text;
            m.Books_Type = comboBox4.Text;
            m.Books_Name = textBox6.Text;
            m.Author_Editor = textBox7.Text;
            m.Book_Can_Hold = textBox8.Text;
            m.Password = textBox9.Text;

            DB.FRs.InsertOnSubmit(m);
            DB.Logins.InsertOnSubmit(w);
            DB.SubmitChanges();
            MessageBox.Show("Faculty Added!!");




        }

        private void button16_Click(object sender, EventArgs e)
        {
            LibrarianHomepage obj = new LibrarianHomepage();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
            this.Hide();
        }

        private void FacultyRegistration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
