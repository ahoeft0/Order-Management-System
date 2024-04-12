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
        public Orders()
        {
            InitializeComponent();
            DataTable customerData = sendQuery("select first_name, last_name, customer_id from customer");
            customerData.Columns.Add("full_name", typeof(string), "first_name + ' ' + last_name");
            cmbCustomer.DataSource = customerData;
            cmbCustomer.DisplayMember = customerData.Columns[3].ColumnName;
            cmbCustomer.ValueMember = customerData.Columns[2].ColumnName;
            cmbCustomer.SelectedIndex = -1;
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
                                            "where c.customer_id = " + cmbCustomer.SelectedValue);
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
            DataTable orderData = sendQuery("select i.order_id, p.name as product, i.quantity, i.cost " +
                                            "from items_ordered as i " +
                                            "join product as p " +
                                            "on p.product_id = i.product_id " +
                                            "where order_id = " + cmbOrder.SelectedValue);
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
    }
}
