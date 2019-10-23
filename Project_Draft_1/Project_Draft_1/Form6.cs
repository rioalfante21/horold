using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Draft_1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(admintxt.Text == "admin" && passtxt.Text == "password")
            {
                MessageBox.Show("Welcome Admin", "Log in Successfully");
                Form7 frm7 = new Form7();
                frm7.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("admin user and password incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();
        }
    }
}
