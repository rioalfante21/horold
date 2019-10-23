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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            initialize();
        }
        MySqlConnection conn;
        string MyConnectionString;
        public string accntName, accntSub;
        double discountedPrice1, discountedPrice2, shippingFee;
        int quantityTemporary, itemQuantity, itemQuantity1, stocksLeft;
        double deliveryPrice;
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
            dataViewTable.Items.Clear();
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
                        dataItems.SubItems.Add(reader[5].ToString());
                        dataViewTable.Items.Add(dataItems);
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
                dataViewTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                dataViewTable.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        double totalprice1 = 0;
        public void sumtotal()
        {
            string query = "select sum(total_price) from " +accntName+";";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        totalprice1 = reader.GetDouble("sum(total_price)");
                    }
                }
                catch(MySqlException ex)
                {
                   
                }
                finally
                {
                    this.CloseConn();
                }
            }
        }
        public void showPayments()
        {
            if (string.IsNullOrEmpty(totalprice1.ToString()))
            {
                totalprice1 = 0;
            }
            sumtotal();
            discountedPrice1 = totalprice1 * 0.10;
            discountedPrice2 = totalprice1 - discountedPrice1;
            lblTp.Text = "P " + totalprice1.ToString() + "";
     
            if(accntSub!= "Premium")
            {
                lblDp.Text = "Not Applicable";
                if (CODrdBtn.Checked == true)
                {
                    shippingFee = 45;
                    lblSf.Text = "P " + shippingFee.ToString();
                }
                else if (OBrdbtn.Checked == true)
                {
                    shippingFee = 35;
                    lblSf.Text = "P " + shippingFee.ToString();
                }
                else if (CCrdbtn.Checked == true)
                {
                    shippingFee = 55;
                    lblSf.Text = "P " + shippingFee.ToString();
                }
                deliveryPrice = totalprice1 + shippingFee;
            }
            else
            {
                shippingFee = 0;
                lblSf.Text = "Free Shipping";
                lblDp.Text = "P " + discountedPrice2.ToString() + "";
                deliveryPrice = shippingFee + discountedPrice2;
            }
            button3.Text = "DELIVER \n P " + deliveryPrice;
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
        public void getQuantity()
        {
            string query = "select item_quantity from "+accntName+" where item_name = '" + nameCmbx.SelectedItem.ToString() + "';";
            if (this.OpenConn())
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        itemQuantity = reader.GetInt32("item_quantity");
                        QNmud.Value = itemQuantity;
                    }
                }
                catch (MySqlException ex)
                {
                 

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
  
                        QNmud.Maximum = itemQuantity1;

                    }
                }
                catch (MySqlException ex)
                {
                    

                }
                finally
                {
                    this.CloseConn();
                }
            }
        }
        public void addTypeComboBox()
        {
            string query = "select distinct item_type from "+accntName+" where item_quantity >0 ;";
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
            string query = "select * from "+accntName+" where item_type = '" + typeCmbx.SelectedItem.ToString() + "' and item_quantity >0;";
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
        public void clear()
        {
            typeCmbx.Items.Clear();
            nameCmbx.Items.Clear();
            QNmud.Value = 0;
            editValue("insert into "+accntName+ " (item_name, item_type, item_value, item_quantity) values('"+ " "+"', '"+" "+"', "+0+", "+0+");");
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            POS1 pos1 = new POS1();
            pos1.Show();
        }

        private void OBrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            showPayments();
        }

        private void CODrdBtn_CheckedChanged(object sender, EventArgs e)
        {
            showPayments();
        }

        private void CCrdbtn_CheckedChanged(object sender, EventArgs e)
        {
            showPayments();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CODrdBtn.Select();
            accntName = POS1.accntnamePOSForm;
            accntSub = POS1.accntsubPOSForm;
            getData("select * from "+accntName+" where item_quantity >0 ;");
            addTypeComboBox();
            showPayments();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if(QNmud.Value == 0)
            {
                if (MessageBox.Show("Are you sure you want to edit this item?", "Notice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Item Successfully Edited");
                    stocksLeft = (itemQuantity1 + quantityTemporary) - Convert.ToInt32(QNmud.Value);
                    editValue("delete from " + accntName + " where item_name = '" + nameCmbx.SelectedItem.ToString() + "';");
                    editValue("update items set item_quantity = " + stocksLeft + " where item_name = '" + nameCmbx.SelectedItem.ToString() + "';");
                    getData("select * from " + accntName + " where item_quantity >0;");
                    clear();
                    addTypeComboBox();
                    showPayments();
     
                }
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to edit this item?", "Notice", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MessageBox.Show("Item Successfully Edited");
                    stocksLeft = (itemQuantity1 + quantityTemporary) - Convert.ToInt32(QNmud.Value);
                    editValue("update " + accntName + " set item_quantity = " + QNmud.Value + " where item_name = '" + nameCmbx.SelectedItem.ToString() + "' ;");
                    editValue("update items set item_quantity = " + stocksLeft + " where item_name = '" + nameCmbx.SelectedItem.ToString() + "';");
                    getData("select * from " + accntName + " where item_quantity > 0;");
                    clear();
                    addTypeComboBox();
                    showPayments();

                }
            }
         
            
        }

        private void TypeCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            nameCmbx.Items.Clear();
            addNameCombox();
        }

        private void NameCmbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            QNmud.Value = 0;
            getQuantity();
            getQuantity1();
            quantityTemporary = Convert.ToInt32(QNmud.Value);

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if(totalprice1 == 0)
            {
                MessageBox.Show("The Cart is Empty","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               if( MessageBox.Show("Are you sure want to Check out?", "Check Out", MessageBoxButtons.YesNo)== DialogResult.Yes)
                {
                    MessageBox.Show("Expect the Item/s will be delivered within Three (3) working Days","Check out", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    editValue("delete from "+ accntName+";");
                    clear();
                    getData("select * from " + accntName + " where item_quantity > 0;");
                }
            }
        }

        private void DataViewTable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
