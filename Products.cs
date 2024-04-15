using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

            //View Load
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

            //Price Change Load
            DataTable productData = sendQuery("select product_id, name from product");
            if (productData.Rows.Count > 0)
            {
                cmbProductPriceChange.DataSource = productData;
                cmbProductPriceChange.DisplayMember = productData.Columns[1].ColumnName;
                cmbProductPriceChange.ValueMember = productData.Columns[0].ColumnName;
                cmbProductPriceChange.SelectedIndex = -1;
            }

            //Create Load
            if (categoryData.Rows.Count > 0)
            {
                cmbCreateProductCategory.DataSource = categoryData;
                cmbCreateProductCategory.DisplayMember = categoryData.Columns[1].ColumnName;
                cmbCreateProductCategory.ValueMember = categoryData.Columns[0].ColumnName;
                cmbCreateProductCategory.SelectedIndex = -1;
            }

            if (providerData.Rows.Count > 0)
            {
                cmbCreateProductProvider.DataSource = providerData;
                cmbCreateProductProvider.DisplayMember = providerData.Columns[1].ColumnName;
                cmbCreateProductProvider.ValueMember = providerData.Columns[0].ColumnName;
                cmbCreateProductProvider.SelectedIndex = -1;
            }

            //Update Delete load
            if (categoryData.Rows.Count > 0)
            {
                cmbUpdateProductCategory.DataSource = categoryData;
                cmbUpdateProductCategory.DisplayMember = categoryData.Columns[1].ColumnName;
                cmbUpdateProductCategory.ValueMember = categoryData.Columns[0].ColumnName;
                cmbUpdateProductCategory.SelectedIndex = -1;
            }

            if (providerData.Rows.Count > 0)
            {
                cmbUpdateProductProvider.DataSource = providerData;
                cmbUpdateProductProvider.DisplayMember = providerData.Columns[1].ColumnName;
                cmbUpdateProductProvider.ValueMember = providerData.Columns[0].ColumnName;
                cmbUpdateProductProvider.SelectedIndex = -1;
            }
            if (productData.Rows.Count > 0)
            {
                cmbProductSelect.DataSource = productData;
                cmbProductSelect.DisplayMember = productData.Columns[1].ColumnName;
                cmbProductSelect.ValueMember = productData.Columns[0].ColumnName;
                cmbProductSelect.SelectedIndex = -1;
            }

            UpdateComboBoxes();
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

            //Create Reset
            txtCreateProductName.Text = "";
            cmbCreateProductCategory.SelectedIndex = -1;
            cmbCreateProductProvider.SelectedIndex = -1;
            mtxtCreateProductStock.Text = "";
            mtxtCreateProductPrice.Text = "";
            cmbCreateProductIsAvailable.SelectedIndex = -1;
            txtCreateProductDescription.Text = "";

            //Update Delete Reset
            cmbProductSelect.SelectedIndex = -1;
            txtUpdateProductName.Text = "";
            cmbUpdateProductCategory.SelectedIndex = -1;
            cmbUpdateProductProvider.SelectedIndex = -1;
            mtxtUpdateProductStock.Text = "";
            cmbUpdateProductIsAvailable.SelectedIndex = -1;
            txtUpdateProductDescription.Text = "";
        }

        // Validate price 
        private bool CheckPrice(string price)
        {
            // Define a regular expression pattern for a valid price 
            string pattern = @"^\$\d{1,4}\.\d{2}$";

            // Check if the price matches the pattern
            return Regex.IsMatch(price.Replace(" ", ""), pattern);
        }

        private void UpdateComboBoxes()
        {
            // Populate select combo boxes with data
            // Products setup
            DataTable products = sendQuery("SELECT product_id, name from product");
            if (products.Rows.Count > 0)
            {
                pProductInfo.Visible = false;
                cmbProductSelect.DataSource = products;
                cmbProductSelect.DisplayMember = products.Columns[1].ColumnName;
                cmbProductSelect.ValueMember = products.Columns[0].ColumnName;
                cmbProductSelect.SelectedIndex = -1;
            }

            //Price Change Load
            DataTable productData = sendQuery("select product_id, name from product");
            if (productData.Rows.Count > 0)
            {
                cmbProductPriceChange.DataSource = productData;
                cmbProductPriceChange.DisplayMember = productData.Columns[1].ColumnName;
                cmbProductPriceChange.ValueMember = productData.Columns[0].ColumnName;
                cmbProductPriceChange.SelectedIndex = -1;
            }
        }

        private void cmbProductSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text to show selected product info
            // Show product info after selection
            pProductInfo.Visible = true;

            // Update info
            DataTable productInfo = sendQuery("SELECT * FROM product WHERE product_id = " + cmbProductSelect.SelectedValue);
            txtUpdateProductName.Text = productInfo.Rows[0]["name"].ToString();
            cmbUpdateProductCategory.SelectedValue = productInfo.Rows[0]["category_id"].ToString();
            cmbUpdateProductProvider.SelectedValue = productInfo.Rows[0]["provider_id"].ToString();
            mtxtUpdateProductStock.Text = productInfo.Rows[0]["stock"].ToString();
            cmbUpdateProductIsAvailable.Text = productInfo.Rows[0]["is_available"].ToString();
            txtUpdateProductDescription.Text = productInfo.Rows[0]["description"].ToString();
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            // Variables
            string name = txtCreateProductName.Text;
            var category = cmbCreateProductCategory.SelectedValue;
            var provider = cmbCreateProductProvider.SelectedValue;
            string stock = mtxtCreateProductStock.Text;
            string price = mtxtCreateProductPrice.Text;
            string isAvailable = cmbCreateProductIsAvailable.Text;
            string description = txtCreateProductDescription.Text;

            // Return if NOT NULL fields are blank or invalid
            if (string.IsNullOrEmpty(name) || cmbCreateProductCategory.SelectedIndex == -1 || cmbCreateProductProvider.SelectedIndex == -1 || string.IsNullOrEmpty(stock) || !CheckPrice(price) || cmbCreateProductIsAvailable.SelectedIndex == -1)
            {
                MessageBox.Show("Please ensure Name, Category, Provider, Stock, Price, and Is Available have valid entries");
                return;
            }

            // Update variables to correct data type
            int categoryID = Convert.ToInt32(category);
            int providerID = Convert.ToInt32(provider);
            int stockINT = Convert.ToInt32(stock);
            decimal priceDECIMAL = Decimal.Parse(price.Replace("$", ""));
            bool isAvailableBOOL;
            if (isAvailable.ToString().Equals("true"))
                isAvailableBOOL = true;
            else
                isAvailableBOOL = false;

            // Use parameterized SQL to create a new product
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();

                    // Insert into product
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO product (name, category_id, provider_id, stock, current_price, is_available, description) " +
                                                                 "VALUES (@Name, " +
                                                                         "@Category, " +
                                                                         "@Provider, " +
                                                                         "@Stock, " +
                                                                         "@Price, " +
                                                                         "@IsAvailable, " +
                                                                         "@Description) " +
                                                                 "RETURNING product_id", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Category", categoryID);
                        cmd.Parameters.AddWithValue("@Provider", providerID);
                        cmd.Parameters.AddWithValue("@Stock", stockINT);
                        cmd.Parameters.AddWithValue("@Price", priceDECIMAL);
                        cmd.Parameters.AddWithValue("@IsAvailable", isAvailableBOOL);
                        cmd.Parameters.AddWithValue("@Description", description);

                        // Execute scalar to get the inserted product_id
                        int productID = Convert.ToInt32(cmd.ExecuteScalar());

                        // Insert into price_change (Initial price)
                        using (NpgsqlCommand priceChangeCmd = new NpgsqlCommand("INSERT INTO price_change (product_id, is_original_price, new_price, reason_change) " +
                                                                                "VALUES (@ProductID, " +
                                                                                        "@IsOriginalPrice, " +
                                                                                        "@NewPrice, " +
                                                                                        "@ReasonChange)", conn))
                        {
                            priceChangeCmd.Parameters.AddWithValue("@ProductID", productID);
                            priceChangeCmd.Parameters.AddWithValue("@IsOriginalPrice", true);
                            priceChangeCmd.Parameters.AddWithValue("@NewPrice", priceDECIMAL);
                            priceChangeCmd.Parameters.AddWithValue("@ReasonChange", "Initial Price");

                            priceChangeCmd.ExecuteNonQuery();
                        }
                    }
                }

                // Confirm & refresh
                MessageBox.Show("Product created successfully");
                UpdateComboBoxes();

                // Clear user input
                txtCreateProductName.Text = "";
                cmbCreateProductCategory.SelectedIndex = -1;
                cmbCreateProductProvider.SelectedIndex = -1;
                mtxtCreateProductStock.Text = "";
                mtxtCreateProductPrice.Text = "";
                cmbCreateProductIsAvailable.SelectedIndex = -1;
                txtCreateProductDescription.Text = "";
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error creating product: " + ex.Message);
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            // Get productID & other variables
            int productID = Convert.ToInt32(cmbProductSelect.SelectedValue);
            string name = txtUpdateProductName.Text;
            var category = cmbUpdateProductCategory.SelectedValue;
            var provider = cmbUpdateProductProvider.SelectedValue;
            string stock = mtxtUpdateProductStock.Text;
            string isAvailable = cmbUpdateProductIsAvailable.Text;
            string description = txtUpdateProductDescription.Text;

            // Update variables to correct data type
            int categoryID = Convert.ToInt32(category);
            int providerID = Convert.ToInt32(provider);
            int stockINT = Convert.ToInt32(stock);
            bool isAvailableBOOL;
            if (isAvailable.ToString().Equals("true"))
                isAvailableBOOL = true;
            else
                isAvailableBOOL = false;

            // Use parameterized SQL to update a product
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE product " +
                                                                 "SET name = @Name, " +
                                                                      "category_id = @Category, " +
                                                                      "provider_id = @Provider, " +
                                                                      "stock = @Stock, " +
                                                                      "is_available = @IsAvailable, " +
                                                                      "description = @Description " +
                                                                  "WHERE product_id = " + productID, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Category", categoryID);
                        cmd.Parameters.AddWithValue("@Provider", providerID);
                        cmd.Parameters.AddWithValue("@Stock", stockINT);
                        cmd.Parameters.AddWithValue("@IsAvailable", isAvailableBOOL);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Product updated successfully");
                UpdateComboBoxes();
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error updated product: " + ex.Message);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            // Get productID
            int productID = Convert.ToInt32(cmbProductSelect.SelectedValue);

            // Show error when product in currently in an active order
            if (sendQuery("SELECT * FROM items_ordered " +
                          "WHERE product_id = " + productID).Rows.Count > 0)
            {
                MessageBox.Show("Cannot delete this product as it's currently in active orders");
                return;
            }

            // Show confimration box
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete from price_change table using productID
                sendQuery("DELETE FROM price_change WHERE product_id = " + productID);

                // Delete from product table using productID 
                sendQuery("DELETE FROM product WHERE product_id = " + productID);

                // Confirm & refresh table/combo box
                MessageBox.Show("Product deleted successfully");
                pProductInfo.Visible = false;
                cmbProductSelect.SelectedIndex = -1;
                UpdateComboBoxes();
            }

            // Return when user clicks No
            else
                return;
        }
    }
}
