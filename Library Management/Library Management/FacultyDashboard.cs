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
    public partial class FacultyDashboard : Form
    {
        String s;
        public FacultyDashboard(String s)
        {
            InitializeComponent();
            this.s = s;

            DBDataContext DB = new DBDataContext();
            using (DB)
            {
                FR ci = DB.FRs.SingleOrDefault(p => p.Username == s);
                if (ci != null)
                {
                    textBox1.Text = ci.Username;
                    textBox2.Text = ci.Name;
                    textBox3.Text = ci.Email;
                    textBox4.Text = ci.Designation;
                    textBox5.Text = ci.Address;

                }

                    
             }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DBDataContext DB = new DBDataContext();

            string id = textBox8.Text;
            FR s = DB.FRs.SingleOrDefault(x => x.Username == id);
            if (s != null)
            {
                textBox6.Text = s.Books_Name;
                textBox7.Text = s.Author_Editor;


            }
            else
            {
                MessageBox.Show("Data not found");
            }


        }

        private void FacultyDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void FacultyDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
