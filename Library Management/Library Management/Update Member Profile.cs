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
    public partial class Update_Member_Profile : Form
    {
        public Update_Member_Profile()
        {
            InitializeComponent();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            LibrarianHomepage lh = new LibrarianHomepage();
            lh.StartPosition = FormStartPosition.CenterScreen;
            lh.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            
            string id = textBox1.Text;
            MR s = DB.MRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {
                
                textBox9.Text = s.Password;
                textBox9.Text = s.Password;
                textBox2.Text = s.Name;
                textBox3.Text = s.Email;
                
                comboBox2.Text = s.Department;
                textBox4.Text = s.Address;
                textBox5.Text = s.Contact_No;
                comboBox5.Text = s.Gender;
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

        private void button15_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();
            string id = textBox1.Text;
            MR s = DB.MRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {

                s.Name = textBox2.Text;
                s.Email = textBox3.Text;
                s.Department = comboBox4.Text;
                s.Address = textBox4.Text;
                s.Contact_No = textBox5.Text;
                s.Gender = comboBox5.Text;
                s.Blood_Group = comboBox3.Text;
                s.Books_Type = comboBox4.Text;
                s.Books_Name = textBox6.Text;
                s.Author_Editor = textBox7.Text;
                s.Book_Can_Hold = textBox8.Text;
                s.Password = textBox9.Text;

                DB.SubmitChanges();
                MessageBox.Show("Information Updated!!");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            DBDataContext DB = new DBDataContext();
            string id = textBox1.Text;
            MR s = DB.MRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {
                DB.MRs.DeleteOnSubmit(s);
                DB.SubmitChanges();
            }
            else
            {
                MessageBox.Show("Data not found");
            }
            MessageBox.Show("Successfully Deleted The Information", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void Update_Member_Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = " ";
                }

            }
        }
    }
}
