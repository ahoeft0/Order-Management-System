using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace OnlineStore
{
    // Form for CRUD for orders and "possibly other features such as most popular or expensive product???"
    public partial class Orders : Form
    {
        decimal totalCost;

        public Orders()
        {
            InitializeComponent();

            //Order view setup
            DataTable customerData = sendQuery("select first_name, last_name, customer_id from customer");
            customerData.Columns.Add("full_name", typeof(string), "first_name + ' ' + last_name");
            cmbCustomer.DataSource = customerData;
            cmbCustomer.DisplayMember = customerData.Columns[3].ColumnName;
            cmbCustomer.ValueMember = customerData.Columns[2].ColumnName;
            cmbCustomer.SelectedIndex = -1;

            //Order create setup
            cmbCreateCustomer.DataSource = customerData;
            cmbCreateCustomer.DisplayMember = customerData.Columns[3].ColumnName;
            cmbCreateCustomer.ValueMember = customerData.Columns[2].ColumnName;
            cmbCreateCustomer.SelectedIndex = -1;

            DataTable productData = sendQuery("select product_id, name, current_price from product where is_available");
            productData.Columns.Add("productInfo", typeof(string), "name + ': ' + current_price");
            cmbCreateProduct.DataSource = productData;
            cmbCreateProduct.DisplayMember = productData.Columns[3].ColumnName;
            cmbCreateProduct.ValueMember = productData.Columns[0].ColumnName;
            cmbCreateProduct.SelectedIndex = -1;

            //Order update setup
            DataTable orderData = sendQuery("select order_id " + "from \"Order\" order by order_id");
            cmbUpdateOrder.DataSource = orderData;
            cmbUpdateOrder.DisplayMember = orderData.Columns[0].ColumnName;
            cmbUpdateOrder.ValueMember = orderData.Columns[0].ColumnName;
            cmbUpdateOrder.SelectedIndex = -1;

            cmbUpdateProduct.DataSource = productData;
            cmbUpdateProduct.DisplayMember = productData.Columns[3].ColumnName;
            cmbUpdateProduct.ValueMember = productData.Columns[0].ColumnName;
            cmbUpdateProduct.SelectedIndex = -1;
        }

        private DataTable sendQuery(string query)
        {
            DataTable dt = new DataTable();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                dt = new DataTable();
                dt.Load(reader);
            }
            cmd.Dispose();
            conn.Close();
            return dt;
        }

        private void cmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbOrder.DataSource = null;
            dgvOrderInformation.DataSource = null;
            txtDateOrdered.Text = "";
            txtOrderNumber.Text = "";
            txtTotalPrice.Text = "";
            DataTable orderData = sendQuery("select order_id " +
                                            "from \"Order\" as o " +
                                            "join customer as c " +
                                            "on c.customer_id = o.customer_id " +
                                            "where c.customer_id = " + cmbCustomer.SelectedValue + " " +
                                            "order by order_id");
            cmbOrder.DataSource = orderData;
            if (orderData.Columns.Count > 0)
            {
                cmbOrder.DisplayMember = orderData.Columns[0].ColumnName;
                cmbOrder.ValueMember = orderData.Columns[0].ColumnName;
                cmbOrder.SelectedIndex = -1;
            }
        }

        private void cmbOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable orderData = sendQuery("select p.name as product, i.quantity, i.cost " +
                                            "from items_ordered as i " +
                                            "join product as p " +
                                            "on p.product_id = i.product_id " +
                                            "where i.order_id = " + cmbOrder.SelectedValue);
            dgvOrderInformation.DataSource = orderData;
            string[] name = cmbCustomer.Text.Split(' ');
            DataTable order = sendQuery("select * " +
                                            "from \"Order\" as o " +
                                            "join customer as c " +
                                            "on c.customer_id = o.customer_id " +
                                            "where c.customer_id = " + cmbCustomer.SelectedValue + " " +
                                            "and o.order_id = " + cmbOrder.SelectedValue);
            txtOrderNumber.Text = order.Rows[0].ItemArray[0].ToString();
            txtTotalPrice.Text = order.Rows[0].ItemArray[2].ToString();
            txtDateOrdered.Text = order.Rows[0].ItemArray[3].ToString();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            bool added = false;
            for (int i = 0; i < lstBxOrderSummary.Items.Count; i++)
            {
                string[] oldEntry = lstBxOrderSummary.Items[i].ToString().Split(':');
                string[] newEntry = cmbCreateProduct.Text.Split(':');
                if (oldEntry[0] == newEntry[0])
                {
                    decimal price = Decimal.Parse(newEntry[1].Trim());
                    string product = newEntry[0];
                    int quantity = Int32.Parse(nupCreateQuantity.Text) + Int32.Parse(oldEntry[1]);
                    decimal totalPrice = quantity * price;
                    decimal updatedPrice = totalPrice - Decimal.Parse(oldEntry[2]);
                    totalCost += updatedPrice;
                    txtCreateTotalPrice.Text = "$" + totalCost;
                    string entry = product + ":" + quantity + ":" + totalPrice;
                    lstBxOrderSummary.Items.RemoveAt(i);
                    lstBxOrderSummary.Items.Add(entry);
                    added = true;
                }
            }
            if (!added)
            {
                string[] prodInfo = cmbCreateProduct.Text.ToString().Split(':');
                decimal price = Decimal.Parse(prodInfo[1].Trim());
                string product = prodInfo[0];
                int quantity = Int32.Parse(nupCreateQuantity.Text);
                decimal totalPrice = quantity * price;
                totalCost += totalPrice;
                txtCreateTotalPrice.Text = "$" + totalCost;
                string entry = product + ":" + quantity + ":" + totalPrice;
                lstBxOrderSummary.Items.Add(entry);
            }
            if (lstBxOrderSummary.Items.Count > 0 && cmbCreateCustomer.SelectedIndex > -1)
            {
                btnSubmitOrder.Enabled = true;
            }
            else
            {
                btnSubmitOrder.Enabled = false;
            }
        }

        private void btnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = Decimal.Parse(lstBxOrderSummary.SelectedItem.ToString().Split(':')[2]);
            totalCost -= totalPrice;
            txtCreateTotalPrice.Text = "$" + totalCost;
            lstBxOrderSummary.Items.Remove(lstBxOrderSummary.SelectedItem);
            if (lstBxOrderSummary.Items.Count > 0 && cmbCreateCustomer.SelectedIndex > -1)
            {
                btnSubmitOrder.Enabled = true;
            }
            else
            {
                btnSubmitOrder.Enabled = false;
            }
            if (lstBxOrderSummary.Items.Count == 0 || lstBxOrderSummary.SelectedIndex == -1)
            {
                btnRemoveFromOrder.Enabled = false;
            }
            else
            {
                btnRemoveFromOrder.Enabled = true;
            }
        }

        private void lstBxOrderSummary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxOrderSummary.SelectedIndex == -1)
            {
                btnRemoveFromOrder.Enabled = false;
            }
            else
            {
                btnRemoveFromOrder.Enabled = true;
            }
        }

        private void cmbCreateProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCreateProduct.SelectedIndex > -1)
            {
                btnAddToOrder.Enabled = true;
            }
            else if (cmbCreateProduct.SelectedIndex == -1)
            {
                btnAddToOrder.Enabled = false;
            }
        }

        private void cmbCreateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxOrderSummary.Items.Count > 0 && cmbCreateCustomer.SelectedIndex > -1)
            {
                btnSubmitOrder.Enabled = true;
            }
            else
            {
                btnSubmitOrder.Enabled = false;
            }
        }

        private void btnSubmitOrder_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to submit this order?",
                                     "Confirm Submit",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sendQuery("INSERT INTO \"Order\" (customer_id, total_cost, date_ordered) " +
                      "VALUES (" + cmbCreateCustomer.SelectedValue +
                      ", " + totalCost + ", CURRENT_DATE);");

                for (int i = 0; i < lstBxOrderSummary.Items.Count; i++)
                {
                    string[] entry = lstBxOrderSummary.Items[i].ToString().Split(':');
                    DataTable productInfo = sendQuery("select product_id from product where name = '" + entry[0] + "';");
                    int productId = productInfo.Rows[0].Field<int>(0);
                    DataTable orderInfo = sendQuery("select order_id from \"Order\" order by order_id desc");
                    int orderId = Int32.Parse(orderInfo.Rows[0].ItemArray[0].ToString());
                    sendQuery("INSERT INTO items_ordered (order_id, product_id, quantity, cost) " +
                          "VALUES (" + orderId + ", " + productId + ", " + entry[1] + ", " + entry[2] + ");");
                }

                lstBxOrderSummary.Items.Clear();
                btnSubmitOrder.Enabled = false;
                btnRemoveFromOrder.Enabled = false;
                btnAddToOrder.Enabled = false;
                nupCreateQuantity.Value = 1;
                cmbCreateCustomer.SelectedIndex = -1;
                cmbCreateProduct.SelectedIndex = -1;
                totalCost = 0;
                txtCreateTotalPrice.Text = "$0.00";

                DataTable orderData = sendQuery("select order_id " + "from \"Order\" order by order_id");
                cmbUpdateOrder.DataSource = orderData;
                cmbUpdateOrder.DisplayMember = orderData.Columns[0].ColumnName;
                cmbUpdateOrder.ValueMember = orderData.Columns[0].ColumnName;
                cmbUpdateOrder.SelectedIndex = -1;
            }
        }

        private void ordersTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Create reset
            lstBxOrderSummary.Items.Clear();
            btnSubmitOrder.Enabled = false;
            btnRemoveFromOrder.Enabled = false;
            btnAddToOrder.Enabled = false;
            nupCreateQuantity.Value = 1;
            cmbCreateCustomer.SelectedIndex = -1;
            cmbCreateProduct.SelectedIndex = -1;
            totalCost = 0;
            txtCreateTotalPrice.Text = "$0.00";

            //View Reset
            dgvOrderInformation.DataSource = null;
            cmbCustomer.SelectedIndex = -1;
            cmbOrder.SelectedIndex = -1;
            txtDateOrdered.Text = "";
            txtOrderNumber.Text = "";
            txtTotalPrice.Text = "";

            //Update Reset
            lstBxUpdateOrderInfo.Items.Clear();
            btnUpdateOrder.Enabled = false;
            btnUpdateRemoveOrder.Enabled = false;
            btnUpdateAddToOrder.Enabled = false;
            btnDeleteOrder.Enabled = false;
            nupUpdateQuantity.Value = 1;
            cmbUpdateOrder.SelectedIndex = -1;
            cmbUpdateProduct.SelectedIndex = -1;
            totalCost = 0;
            txtUpdateTotalCost.Text = "$0.00";
        }

        private void cmbUpdateOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstBxUpdateOrderInfo.Items.Clear();
            DataTable items_ordered = sendQuery("select p.name, io.quantity, io.cost " +
                                                "from items_ordered as io " +
                                                "join product as p on p.product_id = io.product_id " +
                                                "where io.order_id = " + cmbUpdateOrder.SelectedValue + ";");
            items_ordered.Columns.Add("entry", typeof(string), "name + ':' + quantity + ':' + cost");
            DataTable totalCost = sendQuery("select total_cost from \"Order\" where order_id = " + cmbUpdateOrder.SelectedValue + ";");
            for (int i = 0; i < items_ordered.Rows.Count; i++)
            {
                lstBxUpdateOrderInfo.Items.Add(items_ordered.Rows[i].ItemArray[3].ToString());
            }
            txtUpdateTotalCost.Text = totalCost.Rows[0].ItemArray[0].ToString();
            if (cmbUpdateOrder.SelectedIndex > -1)
            {
                btnDeleteOrder.Enabled = true;
            }
            else
            {
                btnDeleteOrder.Enabled = false;
            }
        }

        private void cmbUpdateProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUpdateProduct.SelectedIndex > -1 && cmbUpdateOrder.SelectedIndex > -1)
            {
                btnUpdateAddToOrder.Enabled = true;
            }
            else
            {
                btnUpdateAddToOrder.Enabled = false;
            }
        }

        private void btnUpdateAddToOrder_Click(object sender, EventArgs e)
        {
            bool added = false;
            for (int i = 0; i < lstBxUpdateOrderInfo.Items.Count; i++)
            {
                string[] oldEntry = lstBxUpdateOrderInfo.Items[i].ToString().Split(':');
                string[] newEntry = cmbUpdateProduct.Text.Split(':');
                if (oldEntry[0] == newEntry[0])
                {
                    decimal price = Decimal.Parse(newEntry[1].Trim());
                    string product = newEntry[0];
                    int quantity = Int32.Parse(nupUpdateQuantity.Text) + Int32.Parse(oldEntry[1]);
                    decimal totalPrice = quantity * price;
                    decimal updatedPrice = totalPrice - Decimal.Parse(oldEntry[2]);
                    totalCost += updatedPrice;
                    txtUpdateTotalCost.Text = "$" + totalCost;
                    string entry = product + ":" + quantity + ":" + totalPrice;
                    lstBxUpdateOrderInfo.Items.RemoveAt(i);
                    lstBxUpdateOrderInfo.Items.Add(entry);
                    added = true;
                }
            }
            if (!added)
            {
                string[] prodInfo = cmbUpdateProduct.Text.ToString().Split(':');
                decimal price = Decimal.Parse(prodInfo[1].Trim());
                string product = prodInfo[0];
                int quantity = Int32.Parse(nupUpdateQuantity.Text);
                decimal totalPrice = quantity * price;
                totalCost += totalPrice;
                txtUpdateTotalCost.Text = "$" + totalCost;
                string entry = product + ":" + quantity + ":" + totalPrice;
                lstBxUpdateOrderInfo.Items.Add(entry);
            }
            if (lstBxUpdateOrderInfo.Items.Count > 0 && cmbUpdateOrder.SelectedIndex > -1)
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
        }

        private void btnUpdateRemoveOrder_Click(object sender, EventArgs e)
        {
            decimal totalPrice = Decimal.Parse(lstBxUpdateOrderInfo.SelectedItem.ToString().Split(':')[2]);
            totalCost -= totalPrice;
            txtUpdateTotalCost.Text = "$" + totalCost;
            lstBxUpdateOrderInfo.Items.Remove(lstBxUpdateOrderInfo.SelectedItem);
            if (cmbUpdateOrder.SelectedIndex > -1 && lstBxUpdateOrderInfo.Items.Count > 0)
            {
                btnUpdateOrder.Enabled = true;
            }
            else
            {
                btnUpdateOrder.Enabled = false;
            }
            if (lstBxUpdateOrderInfo.Items.Count == 0 || lstBxUpdateOrderInfo.SelectedIndex == -1)
            {
                btnUpdateRemoveOrder.Enabled = false;
            }
            else
            {
                btnUpdateRemoveOrder.Enabled = true;
            }
        }

        private void lstBxUpdateOrderInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBxUpdateOrderInfo.SelectedIndex == -1)
            {
                btnUpdateRemoveOrder.Enabled = false;
            }
            else
            {
                btnUpdateRemoveOrder.Enabled = true;
            }
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to update this order?",
                                     "Confirm Update",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sendQuery("update \"Order\" set total_cost = " + totalCost + " where order_id = " + cmbUpdateOrder.SelectedValue + ";");
                sendQuery("delete from items_ordered where order_id = " + cmbUpdateOrder.SelectedValue);
                for (int i = 0; i < lstBxUpdateOrderInfo.Items.Count; i++)
                {
                    string[] entry = lstBxUpdateOrderInfo.Items[i].ToString().Split(':');
                    DataTable productInfo = sendQuery("select product_id from product where name = '" + entry[0] + "';");
                    int productId = productInfo.Rows[0].Field<int>(0);
                    sendQuery("INSERT INTO items_ordered (order_id, product_id, quantity, cost) " +
                          "VALUES (" + cmbUpdateOrder.SelectedValue + ", " + productId + ", " + entry[1] + ", " + entry[2] + ");");
                }
                btnUpdateOrder.Enabled = false;
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this order?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sendQuery("delete from items_ordered where order_id = " + cmbUpdateOrder.SelectedValue);
                sendQuery("delete from \"Order\" where order_id = " + cmbUpdateOrder.SelectedValue);

                lstBxUpdateOrderInfo.Items.Clear();
                btnUpdateOrder.Enabled = false;
                btnUpdateRemoveOrder.Enabled = false;
                btnUpdateAddToOrder.Enabled = false;
                btnDeleteOrder.Enabled = false;
                nupUpdateQuantity.Value = 1;
                cmbUpdateProduct.SelectedIndex = -1;
                totalCost = 0;
                txtUpdateTotalCost.Text = "$0.00";

                DataTable orderData = sendQuery("select order_id " + "from \"Order\" order by order_id");
                cmbUpdateOrder.DataSource = orderData;
                cmbUpdateOrder.DisplayMember = orderData.Columns[0].ColumnName;
                cmbUpdateOrder.ValueMember = orderData.Columns[0].ColumnName;
                cmbUpdateOrder.SelectedIndex = -1;
            }
        }
    }
}