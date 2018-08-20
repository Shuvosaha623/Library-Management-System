﻿using System;
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
    public partial class Notice : Form
    {
        public Notice()
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

        private void Notice_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
