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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

           


            var db = new DBDataContext();
            Login t = null;
            t = db.Logins.SingleOrDefault(p => p.Username == textBox1.Text && p.Password == textBox2.Text);


            if (t != null)
            {
                if (t.Role == "Admin")
                {
                    MessageBox.Show("Login as a Librarian");
                    LibrarianHomepage obj = new LibrarianHomepage();
                    obj.StartPosition = FormStartPosition.CenterScreen;
                    obj.Show();
                    this.Hide();
                         
                    textBox1.Clear();
                    textBox2.Clear();
                }
                else if (t.Role == "Faculty")
                {
                    MessageBox.Show("Login as a Faculty");
                    FacultyDashboard fd = new FacultyDashboard(t.Username);
                    fd.StartPosition = FormStartPosition.CenterScreen;
                    fd.Show();
                    this.Hide();
                    textBox1.Clear();
                    textBox2.Clear();

                }

                else 
                {
                    MessageBox.Show("Login as a Student");

                    StudentDashboard sd = new StudentDashboard(t.Username);
                    sd.StartPosition = FormStartPosition.CenterScreen;
                    sd.Show();
                    this.Hide();
                    textBox1.Clear();
                    textBox2.Clear();
                }

                

            }
            else
            {
                MessageBox.Show("Invalid Username or Password! ", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

