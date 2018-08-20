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
    public partial class Update_Faculty_Registration : Form
    {
        public Update_Faculty_Registration()
        {
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            //int id = int.Parse(textBox3.Text);
            string id = textBox1.Text;
            FR s = DB.FRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {
                //textBox2.Text = s.Username;
                textBox9.Text = s.Password;
                textBox2.Text = s.Name;
                textBox3.Text = s.Email;
                textBox10.Text = s.Designation;
                textBox4.Text = s.Address;
                textBox5.Text = s.Contact_Number;
                comboBox1.Text = s.Gender;
                comboBox3.Text = s.Blood_Group;
                comboBox4.Text = s.Books_Type;
                textBox6.Text = s.Books_Name;
                textBox7.Text = s.Author_Editor;
                textBox8.Text = s.Book_Can_Hold;

            }
            else
            {
                MessageBox.Show("Data not found");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //int id = int.Parse(textBox3.Text);
            DBDataContext DB = new DBDataContext();
            string id = textBox1.Text;
            FR s = DB.FRs.SingleOrDefault(x => x.Username == id);
            Login ln = DB.Logins.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {
                DB.FRs.DeleteOnSubmit(s);
                DB.Logins.DeleteOnSubmit(ln);
                DB.SubmitChanges();
               
                
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            MessageBox.Show("Successfully Deleted The Information", "Delete Faculty", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            string id = textBox1.Text;
            FR s = DB.FRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {

                s.Name = textBox2.Text;
                s.Email = textBox3.Text;
               
                s.Address = textBox4.Text;
                s.Contact_Number = textBox5.Text;
                s.Gender = comboBox1.Text;
                s.Blood_Group = comboBox3.Text;
                s.Books_Type = comboBox4.Text;
                s.Books_Name = textBox6.Text;
                s.Author_Editor = textBox7.Text;
                s.Book_Can_Hold = textBox8.Text;
                s.Designation = textBox10.Text;


                DB.SubmitChanges();
                MessageBox.Show("Information Updated!!");
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if(c is TextBox)
                {
                    c.Text = " " ;
                }

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            LibrarianHomepage gg = new LibrarianHomepage();
            gg.StartPosition = FormStartPosition.CenterScreen;
            gg.Show();
            this.Hide();

        }

        private void Update_Faculty_Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
