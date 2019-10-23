using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Project_Draft_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            initialize();
            InitializeComponent();
        }
        MySqlConnection conn;
        string MyConnectionString;
        //initializing database connection
        public void initialize()
        {
            MyConnectionString = "server=localhost; uid=root; pwd=; database=test ;";
            conn = new MySqlConnection(MyConnectionString);
        }
        //Open database connection
        public bool OpenConn()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        //Close database connection
        public bool CloseConn()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void getData()
        {
            string query = "select * from account_table where username ='" + usertxt.Text +
                "' and password = '" + passtxt.Text + "'";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        username1 = reader.GetString("username");
                        pass1 = reader.GetString("password");
                        id1 = reader.GetInt32("id");

                        MessageBox.Show("Welcome " + username1);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("No Account been Recognized");
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConn();
                }
            }
        }
        public string username1 = null , pass1 = null;
        public static int id1;

        private void Linklbl1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            userSignForm usf1 = new userSignForm();
            this.Hide();
            usf1.Show();
        }

        public void Usertxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            this.Hide();
            frm6.Show();
        }

        public void Logbtn_Click(object sender, EventArgs e)
        {
            getData();
            if(username1!= null && pass1 != null)
            {
                MessageBox.Show("Logged in successfully");
                POS1 pos1 = new POS1();
                this.Hide();
                pos1.Show();
            }
            else
            {
                MessageBox.Show("Username and password cannot be recognized", "Log in failed");
            }
            
        }
    }
}
