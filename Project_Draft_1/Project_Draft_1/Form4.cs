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
using System.Text.RegularExpressions;

namespace Project_Draft_1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            initialize();
            InitializeComponent();
        }
        MySqlConnection conn;
        string MyConnectionString;
        string dataType;
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
        public void getData()
        {
            string query = "select distinct item_type from items;";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    AutoCompleteStringCollection sourceName = new AutoCompleteStringCollection();
                    while (reader.Read())
                    {


                        dataType = reader.GetString("item_type");
                        sourceName.Add(dataType);
                    }
                    typeTxt.AutoCompleteCustomSource = sourceName;
                    typeTxt.AutoCompleteMode = AutoCompleteMode.Suggest;
                    typeTxt.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        public void insertValue(string type, string name, double price, int quantity)
        {
            string query1 = " insert into items (item_name, item_type, item_price, item_quantity) values" +
                "('" + name + "', '" + type + "', '" + price + "', '" + quantity + "'); ";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query1, conn);
                    cmd.ExecuteNonQuery();
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
        string name1, type1;
        int quantity1;
        double price1;
        string initialcheck = @"([A-Z]\.)";
        string valid = @"^(\d|,)*\.?\d*$";
        private void TypeTxt_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(typeTxt.Text, initialcheck);
            if (!match.Success || string.IsNullOrEmpty(typeTxt.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Pricetxt_TextChanged(object sender, EventArgs e)
        {
            Match match = Regex.Match(pricetxt.Text, valid);
            if (!match.Success || string.IsNullOrEmpty(pricetxt.Text))
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            getData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            name1 = inametxt.Text;
            type1 = typeTxt.Text;
            quantity1 = Convert.ToInt32(quantitytxt.Value);
            price1 = Convert.ToDouble(pricetxt.Text);
            if (string.IsNullOrEmpty(inametxt.Text) || quantitytxt.Value == 0 || string.IsNullOrEmpty(pricetxt.Text))
            {
                MessageBox.Show("Error Input Fields");
            }
            else
            {
                insertValue(type1, name1, price1, quantity1);
                if (MessageBox.Show("Item Successfully Added", "item Added", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    inametxt.Text = "";
                    typeTxt.Text = "";
                    quantitytxt.Value = 0;
                    pricetxt.Text = "";
                }
            } 
        }
    }
}
