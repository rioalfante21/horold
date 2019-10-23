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
    public partial class POS1 : Form
    {
        public POS1()
        {
            initialize();
            InitializeComponent();

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
        public string accntname, accntsub;
        public int id2;
        public static string accntnamePOSForm, accntsubPOSForm;
        
        public void Form3_Load(object sender, EventArgs e)
        {
            typeCmbx.Items.Clear();
            addTypeComboBox();
            loadData("select * from items where item_quantity >0;");
            id2 = Form1.id1;
            getData();
            AcntNamelbl.Text = accntname;
            accntnamePOSForm = accntname;
            AcntSublbl.Text = accntsub;
            accntsubPOSForm = accntsub;
            addDataValue("insert into "+accntname+" (item_name, item_type, item_value, item_quantity) values ('"+""+"', '"+""+"', "+0+", "+0+")");
            if (accntsub == "Premium" || accntsub == "premium")
            {
                prembtn.Enabled = false;
                prembtn.Text = "PREMIUM USER";
            }
            else
            {
                prembtn.Enabled = true;
                prembtn.Text = "UPGRADE TO PREMIUM";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to log out?", "Log out?", MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                Form1 frm1 = new Form1();
                frm1.Show();
                this.Hide();
            }
        }

        public void getData()
        {
            string query ="select * from account_table where id = '"+id2+"';" ;
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        accntname = reader.GetString("username");
                        accntsub = reader.GetString("priv");
                      
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

        public void loadData( string tempQuery )
        {
            listView1.Items.Clear();
            ListViewItem items;
            string query2 = tempQuery;
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query2, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        items = new ListViewItem(reader[1].ToString());
                        items.SubItems.Add(reader[2].ToString());
                        items.SubItems.Add(reader[3].ToString());
                        items.SubItems.Add(reader[4].ToString());
                        listView1.Items.Add(items);
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
        public void addTypeComboBox()
        {
            string query = "select distinct item_type from items;";
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

        private void TypeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCmbx.Items.Clear();
            addNameCombox();
            loadData("select * from items where item_type = '"+typeCmbx.SelectedItem.ToString()+ "' and item_quantity >0;");
        }
        double price;
        public void addNameCombox()
        {
            string query = "select * from items where item_type = '"+typeCmbx.SelectedItem.ToString()+ "' and item_quantity >0;";
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

        private void NameCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            QNmud.Value = 0;
            getQuantity();
        }

        private void QNmud_ValueChanged(object sender, EventArgs e)
        {
          
        }

        private void Prembtn_Click(object sender, EventArgs e)
        {
            getData();
            addDataValue("update account_table set priv='Premium' where id = "+id2+";");
            prembtn.Enabled = false;
            prembtn.Text = "PREMIUM USER";
            AcntSublbl.Text = "Premium";
        }
        int itemQuantity;
        public void getQuantity()
        {
            string query = "select * from items where item_name = '" + nameCmbx.SelectedItem.ToString() + "';";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        itemQuantity = reader.GetInt32("item_quantity");
                        price = reader.GetDouble("item_price");
                        QNmud.Maximum = itemQuantity;
                                     
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

        private void Button3_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            frm5.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Add this item to cart? ", "Insert Item", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string typebuy = typeCmbx.SelectedItem.ToString();
                string namebuy = nameCmbx.SelectedItem.ToString();
                int quantitybuy = Convert.ToInt32(QNmud.Value);
                int stockremaining = itemQuantity - quantitybuy;
                addDataValue("insert into " + AcntNamelbl.Text + " (item_name, item_type, item_value, item_quantity) values" +
                    "('" + namebuy + "', '" + typebuy + "', '" + price + "', '" + quantitybuy + "');");
                addDataValue("update items set item_quantity = " + stockremaining + " where item_name = '" + namebuy + "';");
                clear();

            }
            loadData("select * from items where item_quantity >0;");
            addTypeComboBox();


        }

        public void addDataValue(string query)
        {
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
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
        public void clear()
        {
            typeCmbx.Items.Clear();
            nameCmbx.Items.Clear();
            QNmud.Value = 0;
        }
        
    }

}
