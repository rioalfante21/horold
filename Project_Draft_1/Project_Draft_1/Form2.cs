using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Project_Draft_1
{
    public partial class userSignForm : Form
    {
        public userSignForm()
        {
            initialize();
            InitializeComponent();
            premrbtn.Select();
        }
        MySqlConnection conn;
        string MyConnectionString;
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
            catch (MySqlException ex)
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

        public void insert(string querytxt)
        {
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(querytxt, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully!!");
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConn();
                }
            }

        }

        public void createData(string namevalue)
        {
            string query1 = "create table "+ namevalue+" ( id int(4) primary key auto_increment, " +
                "item_name varchar(50), item_type varchar(10), item_value decimal(5,0), " +
                "item_quantity decimal(2,0), total_price decimal(10,0) generated always as (item_quantity * item_value));";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd1 = new MySqlCommand(query1, conn);
                    cmd1.ExecuteNonQuery();
                }
                catch(MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConn();
                }
            }
        }
       
        string date, user2, pass2, priv;

        private void Passtxt2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Usertxt2_TextChanged(object sender, EventArgs e)
        {
   
        }

        public static bool error=false;
  
        public void Signbtn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(usertxt2.Text))
            {
                error = true;
            }
            else
            {
                error = false;
            }
           if(passtxt3.Text != passtxt2.Text)
            {
                MessageBox.Show("Password does not match");
            }
            else
            {
                if (error == false )
                {
                    user2 = usertxt2.Text;
                    pass2 = passtxt2.Text;
                    if (premrbtn.Checked)
                    {
                        priv = "Premium";
                    }
                    else
                    {
                        priv = "Standard";
                    }
                    insert("insert into account_table (username, password, priv, date_signed) values" +
                        "('" + user2 + "', '" + pass2 + "', '" + priv + "', '" + DateTime.Now.ToShortDateString() + "'); ");
                    
                    createData(user2);
                    Form1 frm1 = new Form1();
                    this.Hide();
                    frm1.Show();

                }
                else
                {

                }
            }
         
        }
    }
}
