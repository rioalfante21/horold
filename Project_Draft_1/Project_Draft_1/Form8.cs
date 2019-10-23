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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
            initialize();
        }
        MySqlConnection conn;
        string MyConnectionString;
        int itemQuantity1;
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
        public void getData(string query)
        {
            listView1.Items.Clear();
            ListViewItem dataItems;
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        dataItems = new ListViewItem(reader[1].ToString());
                        dataItems.SubItems.Add(reader[2].ToString());
                        dataItems.SubItems.Add(reader[3].ToString());
                        dataItems.SubItems.Add(reader[4].ToString());
                        listView1.Items.Add(dataItems);
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    this.CloseConn();
                }
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        public void clear()
        {
            typeCmbx.Items.Clear();
            nameCmbx.Items.Clear();
            QNmud.Value = 0;
        }
        public void editValue(string query)
        {

            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
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
        public void getQuantity1()
        {
            string query = "select item_quantity from items where item_name = '" + nameCmbx.SelectedItem.ToString() + "';";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        itemQuantity1 = reader.GetInt32("item_quantity");

                        QNmud.Minimum = itemQuantity1;

                    }
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
        public void addTypeComboBox()
        {
            string query = "select distinct item_type from items where item_quantity ;";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string dataType = reader.GetString("item_type");
                        typeCmbx.Items.Add(dataType);
                    }
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
        public void addNameCombox()
        {
            string query = "select * from items where item_type = '" + typeCmbx.SelectedItem.ToString() + "';";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string nameItem = reader.GetString("item_name");
                        nameCmbx.Items.Add(nameItem);

                    }
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            clear();
            getData("Select * from items");
            addTypeComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 frm7 = new Form7();
            frm7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to edit this item?", "Notice", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Item Successfully Edited");
     
                editValue("update items set item_quantity = " + QNmud.Value + " where item_name = '" + nameCmbx.SelectedItem.ToString() + "';");
                getData("select * from items where item_quantity;");
                clear();
                addTypeComboBox();
            }
        }

        private void typeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCmbx.Items.Clear();
            addNameCombox();
        }
    }
}
