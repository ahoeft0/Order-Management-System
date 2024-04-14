using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore
{
    // Form for CRUD for everything except orders
    public partial class Products : Form
    {
        string productSelectQuery = "select p.product_id, p.name as Name, p.description as Description, " +
                                              "c.name as Category, p.stock as Stock, p.current_price as CurrentPrice, " +
                                              "p.is_available as IsAvailable, po.name as Provider " +
                                              "from product as p " +
                                              "join category as c " +
                                              "on c.category_id = p.category_id " +
                                              "join provider as po " +
                                              "on po.provider_id = p.provider_id ";
        public Products()
        {
            InitializeComponent();

            dgvProductInformation.DataSource = sendQuery(productSelectQuery);

            DataTable mostExpensiveProduct = sendQuery(productSelectQuery + "order by p.current_price desc");
            txtExpensiveProduct.Text = mostExpensiveProduct.Rows[0].ItemArray[1].ToString() + ": $" + mostExpensiveProduct.Rows[0].ItemArray[5].ToString();

            txtPopularProduct.Text = mostPopularItem(sendQuery(productSelectQuery));

            DataTable providerData = sendQuery("select provider_id, name from provider");
            if (providerData.Rows.Count > 0)
            {
                cmbProviderFilter.DataSource = providerData;
                cmbProviderFilter.DisplayMember = providerData.Columns[1].ColumnName;
                cmbProviderFilter.ValueMember = providerData.Columns[0].ColumnName;
                cmbProviderFilter.SelectedIndex = -1;
            }

            DataTable categoryData = sendQuery("select category_id, name from category");
            if (categoryData.Rows.Count > 0)
            {
                cmbCategoryFilter.DataSource = categoryData;
                cmbCategoryFilter.DisplayMember = categoryData.Columns[1].ColumnName;
                cmbCategoryFilter.ValueMember = categoryData.Columns[0].ColumnName;
                cmbCategoryFilter.SelectedIndex = -1;
            }

            DataTable productData = sendQuery("select product_id, name from product");
            if (productData.Rows.Count > 0)
            {
                cmbProductPriceChange.DataSource = productData;
                cmbProductPriceChange.DisplayMember = productData.Columns[1].ColumnName;
                cmbProductPriceChange.ValueMember = productData.Columns[0].ColumnName;
                cmbProductPriceChange.SelectedIndex = -1;
            }
        }
        
        private string mostPopularItem(DataTable productData)
        {
            DataTable items_ordered = sendQuery("select SUM(quantity) as q, product_id " +
                                                "from items_ordered " +
                                                "group by product_id " +
                                                "order by q desc");
            DataTable mostPopularProduct = sendQuery("select name from product where product_id = " + items_ordered.Rows[0].ItemArray[1]);

            return mostPopularProduct.Rows[0].ItemArray[0].ToString();
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

        private void cmbProviderFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategoryFilter.SelectedIndex == -1)
            {
                dgvProductInformation.DataSource = sendQuery(productSelectQuery + "where p.provider_id = " + cmbProviderFilter.SelectedValue);
            }
            else
            {
                dgvProductInformation.DataSource = sendQuery(productSelectQuery + "where p.provider_id = " + cmbProviderFilter.SelectedValue + " " +
                                                             "and p.category_id = " + cmbCategoryFilter.SelectedValue);
            }
        }

        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProviderFilter.SelectedIndex == -1)
            {
                dgvProductInformation.DataSource = sendQuery(productSelectQuery + "where p.category_id = " + cmbCategoryFilter.SelectedValue);
            }
            else
            {
                dgvProductInformation.DataSource = sendQuery(productSelectQuery + "where p.provider_id = " + cmbProviderFilter.SelectedValue + " " +
                                                             "and p.category_id = " + cmbCategoryFilter.SelectedValue);
            }
        }

        private void btnClearFilters_Click(object sender, EventArgs e)
        {
            cmbCategoryFilter.SelectedIndex = -1;
            cmbProviderFilter.SelectedIndex = -1;

            dgvProductInformation.DataSource = sendQuery(productSelectQuery);
        }

        private void cmbProductPriceChange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbProductPriceChange.SelectedIndex > -1)
            {
                dgvPriceChangeHistory.DataSource = sendQuery("select date_change, new_price, reason_change " +
                                                             "from price_change " +
                                                             "where product_id = " + cmbProductPriceChange.SelectedValue + " " +
                                                             "order by date_change desc");
                btnOriginalPrice.Enabled = true;
                txtCurrentPrice.Text = "$" + sendQuery("select current_price from product where product_id = " + cmbProductPriceChange.SelectedValue).Rows[0].ItemArray[0].ToString();
            }
            enableButton();
        }

        private void btnSubmitPriceChange_Click(object sender, EventArgs e)
        {
            //var confirmResult = MessageBox.Show("Are you sure you want to submit this order?",
            //                        "Confirm Submit",
            //                        MessageBoxButtons.YesNo);
            //if (confirmResult == DialogResult.Yes)
            //{

            //}
            var confirmResult = MessageBox.Show("Are you sure you want to change the price of this product?",
                                    "Confirm Price Change",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                sendQuery("insert into price_change (product_id, is_original_price, new_price, reason_change, date_change)" +
                      "values (" + cmbProductPriceChange.SelectedValue + ", false, " + nupUpdatedPrice.Value + ", '" + txtReasonForChange.Text + "', CURRENT_DATE);");
                sendQuery("update product set current_price = " + nupUpdatedPrice.Value + " where product_id = " + cmbProductPriceChange.SelectedValue);

                txtReasonForChange.Text = "";
                btnSubmitPriceChange.Enabled = false;
                nupUpdatedPrice.Value = 0;
                txtCurrentPrice.Text = "$" + sendQuery("select current_price from product where product_id = " + cmbProductPriceChange.SelectedValue).Rows[0].ItemArray[0].ToString();
                dgvPriceChangeHistory.DataSource = sendQuery("select date_change, new_price, reason_change " +
                                                                 "from price_change " +
                                                                 "where product_id = " + cmbProductPriceChange.SelectedValue + " " +
                                                                 "order by date_change desc");
                btnOriginalPrice.Enabled = true;
            }
        }

        private void nupUpdatedPrice_ValueChanged(object sender, EventArgs e)
        {
            enableButton();
        }

        private void txtReasonForChange_TextChanged(object sender, EventArgs e)
        {
            enableButton();
        }
        private void enableButton()
        {
            bool cmbBool = cmbProductPriceChange.SelectedIndex > -1;
            bool nupBool = nupUpdatedPrice.Value > 0;
            bool txtBool = !txtReasonForChange.Text.Trim().Equals("");
            if(cmbBool && nupBool && txtBool)
            {
                btnSubmitPriceChange.Enabled = true;
            }
            else
            {
                btnSubmitPriceChange.Enabled = false;
            }
        }

        private void btnOriginalPrice_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to revert the price of this product to its current price??",
                                    "Confirm Revert",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                DataTable initialPrice = sendQuery("select new_price from price_change where product_id = " + cmbProductPriceChange.SelectedValue + " and is_original_price = true;");
                sendQuery("update product set current_price = " + initialPrice.Rows[0].ItemArray[0] + " where product_id = " + cmbProductPriceChange.SelectedValue);
                sendQuery("update price_change set date_change = CURRENT_DATE where product_id = " + cmbProductPriceChange.SelectedValue + " and is_original_price = true;");
                txtCurrentPrice.Text = "$" + sendQuery("select current_price from product where product_id = " + cmbProductPriceChange.SelectedValue).Rows[0].ItemArray[0].ToString();
                if (cmbProductPriceChange.SelectedIndex > -1)
                {
                    dgvPriceChangeHistory.DataSource = sendQuery("select date_change, new_price, reason_change " +
                                                                 "from price_change " +
                                                                 "where product_id = " + cmbProductPriceChange.SelectedValue + " " +
                                                                 "order by date_change desc");
                    btnOriginalPrice.Enabled = false;
                    txtCurrentPrice.Text = "$" + sendQuery("select current_price from product where product_id = " + cmbProductPriceChange.SelectedValue).Rows[0].ItemArray[0].ToString();
                }
            }
        }

        private void productsTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //View Reset
            cmbProviderFilter.SelectedIndex = -1;
            cmbCategoryFilter.SelectedIndex = -1;
            dgvProductInformation.DataSource = sendQuery(productSelectQuery);
            DataTable mostExpensiveProduct = sendQuery(productSelectQuery + "order by p.current_price desc");
            txtExpensiveProduct.Text = mostExpensiveProduct.Rows[0].ItemArray[1].ToString() + ": $" + mostExpensiveProduct.Rows[0].ItemArray[5].ToString();
            txtPopularProduct.Text = mostPopularItem(sendQuery(productSelectQuery));

            //Price Changes Reset
            cmbProductPriceChange.SelectedIndex = -1;
            nupUpdatedPrice.Value = 0;
            txtReasonForChange.Text = "";
            btnSubmitPriceChange.Enabled = false;
            btnOriginalPrice.Enabled = false;
            txtCurrentPrice.Text = "";
            dgvPriceChangeHistory.DataSource = null;
        }
    }
}
