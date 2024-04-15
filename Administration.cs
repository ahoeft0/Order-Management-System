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
using System.Text.RegularExpressions;

namespace OnlineStore
{
    // Form for CRUD for everything except orders
    public partial class Administration : Form
    {
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

        private void UpdateComboBoxes()
        {
            // Populate combo boxes with data
            // Customers setup
            DataTable customers = sendQuery("SELECT customer_id, first_name, last_name FROM customer");
            if (customers.Rows.Count > 0)
            {
                pCustomerInfo.Visible = false;
                customers.Columns.Add("full_name", typeof(string), "first_name + ' ' + last_name");
                cmbCustomerSelect.DataSource = customers;
                cmbCustomerSelect.ValueMember = customers.Columns[0].ColumnName;
                cmbCustomerSelect.DisplayMember = customers.Columns[3].ColumnName;
                cmbCustomerSelect.SelectedIndex = -1;
            }

            // Categories setup
            DataTable categories = sendQuery("SELECT category_id, name FROM category");
            if (categories.Rows.Count > 0)
            {
                pCategoryInfo.Visible = false;
                categories.Columns.Add("category_name", typeof(string), "name");
                cmbCategorySelect.DataSource = categories;
                cmbCategorySelect.ValueMember = categories.Columns[0].ColumnName;
                cmbCategorySelect.DisplayMember = categories.Columns[1].ColumnName;
                cmbCategorySelect.SelectedIndex = -1;
            }

            // Provider setup
            DataTable providers = sendQuery("SELECT provider_id, name FROM provider");
            if (providers.Rows.Count > 0)
            {
                pProviderInfo.Visible = false;
                providers.Columns.Add("provider_name", typeof(string), "name");
                cmbProviderSelect.DataSource = providers;
                cmbProviderSelect.ValueMember = providers.Columns[0].ColumnName;
                cmbProviderSelect.DisplayMember = providers.Columns[1].ColumnName;
                cmbProviderSelect.SelectedIndex = -1;
            }
        }

        public Administration()
        {
            InitializeComponent();

            // Populate views of each model with all data
            dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
            dgvCategories.DataSource = sendQuery("SELECT * FROM category");
            dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");

            // Populate combo boxes
            UpdateComboBoxes();

        }

        // Validate phone number
        private bool CheckPhone(string phoneNumber)
        {
            // Define a regular expression pattern for a valid phone number
            string pattern = @"^\(?\d{3}\)?-? *\d{3}-? *-?\d{4}$";

            // Check if the phone number matches the pattern
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e)
        {
            // Variables
            string firstName = txtCreateCustomerFirstName.Text;
            string lastName = txtCreateCustomerLastName.Text;
            string email = txtCreateCustomerEmail.Text;
            string phone = mtxtCreateCustomerPhone.Text;
            string streetAddress = txtCreateCustomerStreetAddress.Text;
            string city = txtCreateCustomerCity.Text;
            string state = mtxtCreateCustomerState.Text;
            string zipCodeSTR = mtxtCreateCustomerZipCode.Text;
            int? zipCodeINT = null;
            if (!string.IsNullOrEmpty(zipCodeSTR))
                zipCodeINT = Convert.ToInt32(zipCodeSTR);

            // Return if NON NULL fields are blank or invalid
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || !CheckPhone(phone))
            {
                MessageBox.Show("Please ensure First Name, Last Name, Email, and Phone have valid entries");
                return;
            }

            // Use parameterized SQL to create a new customer
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO customer (first_name, last_name, email, phone, street_address, city, state, zip_code) " +
                                                                 "VALUES (@FirstName, " +
                                                                         "@LastName, " +
                                                                         "@Email, " +
                                                                         "@Phone, " +
                                                                         "@StreetAddress, " +
                                                                         "@City, " +
                                                                         "@State, " +
                                                                         "@ZipCode)", conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@ZipCode", zipCodeINT);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Customer created successfully");
                dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
                UpdateComboBoxes();

                // Clear user input
                txtCreateCustomerFirstName.Text = "";
                txtCreateCustomerLastName.Text = "";
                txtCreateCustomerEmail.Text = "";
                mtxtCreateCustomerPhone.Text = "";
                txtCreateCustomerStreetAddress.Text = "";
                txtCreateCustomerCity.Text = "";
                mtxtCreateCustomerState.Text = "";
                mtxtCreateCustomerZipCode.Text = "";
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error creating customer: " + ex.Message);
            }
        }

        private void cmbCustomerSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text to show selected customer info
            // Show customer info after selection
            pCustomerInfo.Visible = true;

            // Update info
            DataTable customerInfo = sendQuery("SELECT * FROM customer WHERE customer_id = " + cmbCustomerSelect.SelectedValue);
            txtUpdateCustomerFirstName.Text = customerInfo.Rows[0]["first_name"].ToString();
            txtUpdateCustomerLastName.Text = customerInfo.Rows[0]["last_name"].ToString();
            txtUpdateCustomerEmail.Text = customerInfo.Rows[0]["email"].ToString();
            mtxtUpdateCustomerPhone.Text = customerInfo.Rows[0]["phone"].ToString();
            txtUpdateCustomerStreetAddress.Text = customerInfo.Rows[0]["street_address"].ToString();
            txtUpdateCustomerCity.Text = customerInfo.Rows[0]["city"].ToString();
            mtxtUpdateCustomerState.Text = customerInfo.Rows[0]["state"].ToString();
            mtxtUpdateCustomerZipCode.Text = customerInfo.Rows[0]["zip_code"].ToString();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // Get customerID & other variables
            int customerID = Convert.ToInt32(cmbCustomerSelect.SelectedValue);
            string firstName = txtUpdateCustomerFirstName.Text;
            string lastName = txtUpdateCustomerLastName.Text;
            string email = txtUpdateCustomerEmail.Text;
            string phone = mtxtUpdateCustomerPhone.Text;
            string streetAddress = txtUpdateCustomerStreetAddress.Text;
            string city = txtUpdateCustomerCity.Text;
            string state = mtxtUpdateCustomerState.Text;
            string zipCodeSTR = mtxtUpdateCustomerZipCode.Text;
            int? zipCodeINT = null;
            if (!string.IsNullOrEmpty(zipCodeSTR))
                zipCodeINT = Convert.ToInt32(zipCodeSTR);

            // Use parameterized SQL to update a customer
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE customer " +
                                                                 "SET first_name = @FirstName, " +
                                                                      "last_name = @LastName, " +
                                                                      "email = @Email, " +
                                                                      "phone = @Phone, " +
                                                                      "street_address = @StreetAddress, " +
                                                                      "city = @City, " +
                                                                      "state = @State, " +
                                                                      "zip_code = @ZipCode " + 
                                                                  "WHERE customer_id = " + customerID, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", firstName);
                        cmd.Parameters.AddWithValue("@LastName", lastName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@ZipCode", zipCodeINT);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Customer updated successfully");
                dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
                UpdateComboBoxes();
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error updated customer: " + ex.Message);
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            // Show confimration box
            DialogResult result = MessageBox.Show("Are you sure you want to proceed? All order info relating to this customer will also be deleted.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // User clicked Yes, proceed with the action
                // Get order_id(s) based on customer_id
                int customerID = Convert.ToInt32(cmbCustomerSelect.SelectedValue);
                DataTable orderIDs = sendQuery("SELECT order_id FROM \"Order\" WHERE customer_id = " + customerID);

                // Iterate over orderIDs and add them to an IN statement check
                // Delete from items_ordered & Order for customers with outstanding orders
                if (orderIDs.Rows.Count != 0)
                {
                    string orderIDsToDelete = "IN (";
                    for (int i = 0; i < orderIDs.Rows.Count; i++)
                    {
                        orderIDsToDelete += orderIDs.Rows[i]["order_id"];
                        if (i < orderIDs.Rows.Count - 1)
                            orderIDsToDelete += ", ";
                    }
                    orderIDsToDelete += ")";

                    // Delete from Items_Ordered using orderIDsToDelete
                    sendQuery("DELETE FROM items_ordered WHERE order_id " + orderIDsToDelete);

                    // Delete from Order table using orderIDsToDelete
                    sendQuery("DELETE FROM \"Order\" WHERE order_id " + orderIDsToDelete);
                }

                // Delete from customer table using customerID 
                sendQuery("DELETE FROM customer WHERE customer_id = " + customerID);

                // Confirm & refresh table/combo box
                MessageBox.Show("Customer deleted successfully");
                pCustomerInfo.Visible = false;
                dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
                cmbCustomerSelect.SelectedIndex = -1;
                UpdateComboBoxes();
            }

            // Return when user clicks No
            else
                return;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            // Variables
            string name = txtCreateCategoryName.Text;

            // Return if NON NULL fields are blank or invalid
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please ensure Name has a valid entry");
                return;
            }

            // Use parameterized SQL to create a new customer
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO category (name) " +
                                                                 "VALUES (@Name)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Category created successfully");
                dgvCategories.DataSource = sendQuery("SELECT * FROM category");
                UpdateComboBoxes();

                // Clear user input
                txtCreateCategoryName.Text = "";
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error creating category: " + ex.Message);
            }
        }

        private void cmbCategorySelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text to show selected category info
            // Show category info after selection
            pCategoryInfo.Visible = true;

            // Update info
            DataTable categoryInfo = sendQuery("SELECT * FROM category WHERE category_id = " + cmbCategorySelect.SelectedValue);
            txtUpdateCategoryName.Text = categoryInfo.Rows[0]["name"].ToString();
        }

        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            // Get categoryID & other variables
            int categoryID = Convert.ToInt32(cmbCategorySelect.SelectedValue);
            string name = txtUpdateCategoryName.Text;

            // Use parameterized SQL to update a customer
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE category " +
                                                                 "SET name = @Name " +
                                                                 "WHERE category_id = " + categoryID, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Category updated successfully");
                dgvCustomers.DataSource = sendQuery("SELECT * FROM category");
                UpdateComboBoxes();
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error updated category: " + ex.Message);
            }
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            // Get categoryID
            int categoryID = Convert.ToInt32(cmbCategorySelect.SelectedValue);

            // Show error when category is being used in products that are also being used
            if (sendQuery("SELECT * FROM product P " +
                          "JOIN items_ordered IO " +
                          "ON IO.product_id = P.product_id " +
                          "WHERE P.category_id = " + categoryID).Rows.Count > 0)
            {
                MessageBox.Show("Cannot delete this category as it's being used in products that have been ordered");
                return;
            }

            // Show confimration box
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete from customer table using customerID 
                sendQuery("DELETE FROM category WHERE category_id = " + categoryID);

                // Confirm & refresh table/combo box
                MessageBox.Show("Category deleted successfully");
                pCategoryInfo.Visible = false;
                dgvCategories.DataSource = sendQuery("SELECT * FROM category");
                cmbCategorySelect.SelectedIndex = -1;
                UpdateComboBoxes();
            }

            // Return when user clicks No
            else
                return;
        }

        private void btnCreateProvider_Click(object sender, EventArgs e)
        {
            // Variables
            string name = txtCreateProviderName.Text;
            string phone = mtxtCreateProviderPhone.Text;
            string streetAddress = txtCreateProviderStreetAddress.Text;
            string city = txtCreateProviderCity.Text;
            string state = mtxtCreateProviderState.Text;
            string zipCodeSTR = mtxtCreateProviderZipCode.Text;
            int? zipCodeINT = null;
            if (!string.IsNullOrEmpty(zipCodeSTR))
                zipCodeINT = Convert.ToInt32(zipCodeSTR);

            // Return if NON NULL fields are blank or invalid
            if (string.IsNullOrEmpty(name) || !CheckPhone(phone))
            {
                MessageBox.Show("Please ensure Name, Email, and Phone have valid entries");
                return;
            }

            // Use parameterized SQL to create a new customer
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("INSERT INTO provider (name, phone, street_address, city, state, zip_code) " +
                                                                 "VALUES (@Name, " +
                                                                         "@Phone, " +
                                                                         "@StreetAddress, " +
                                                                         "@City, " +
                                                                         "@State, " +
                                                                         "@ZipCode)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@ZipCode", zipCodeINT);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Provider created successfully");
                dgvProviders.DataSource = sendQuery("SELECT * FROM provider");
                UpdateComboBoxes();

                // Clear user input
                txtCreateProviderName.Text = "";
                mtxtCreateProviderPhone.Text = "";
                txtCreateProviderStreetAddress.Text = "";
                txtCreateProviderCity.Text = "";
                mtxtCreateProviderState.Text = "";
                mtxtCreateProviderZipCode.Text = "";
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error creating provider: " + ex.Message);
            }
        }

        private void cmbProviderSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update text to show selected provider info
            // Show provider info after selection
            pProviderInfo.Visible = true;

            // Update info
            DataTable providerInfo = sendQuery("SELECT * FROM provider WHERE provider_id = " + cmbProviderSelect.SelectedValue);
            txtUpdateProviderName.Text = providerInfo.Rows[0]["name"].ToString();
            mtxtUpdateProviderPhone.Text = providerInfo.Rows[0]["phone"].ToString();
            txtUpdateProviderStreetAddress.Text = providerInfo.Rows[0]["street_address"].ToString();
            txtUpdateProviderCity.Text = providerInfo.Rows[0]["city"].ToString();
            mtxtUpdateProviderState.Text = providerInfo.Rows[0]["state"].ToString();
            mtxtUpdateProviderZipCode.Text = providerInfo.Rows[0]["zip_code"].ToString();
        }

        private void btnUpdateProvider_Click(object sender, EventArgs e)
        {
            // Get providerID & other variables
            int providerID = Convert.ToInt32(cmbProviderSelect.SelectedValue);
            string name = txtUpdateProviderName.Text;
            string phone = mtxtUpdateProviderPhone.Text;
            string streetAddress = txtUpdateProviderStreetAddress.Text;
            string city = txtUpdateProviderCity.Text;
            string state = mtxtUpdateProviderState.Text;
            string zipCodeSTR = mtxtUpdateProviderZipCode.Text;
            int? zipCodeINT = null;
            if (!string.IsNullOrEmpty(zipCodeSTR))
                zipCodeINT = Convert.ToInt32(zipCodeSTR);

            // Use parameterized SQL to update a provider
            try
            {
                using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366"))
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand("UPDATE provider " +
                                                                 "SET name = @Name, " +
                                                                      "phone = @Phone, " +
                                                                      "street_address = @StreetAddress, " +
                                                                      "city = @City, " +
                                                                      "state = @State, " +
                                                                      "zip_code = @ZipCode " +
                                                                  "WHERE provider_id = " + providerID, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@StreetAddress", streetAddress);
                        cmd.Parameters.AddWithValue("@City", city);
                        cmd.Parameters.AddWithValue("@State", state);
                        cmd.Parameters.AddWithValue("@ZipCode", zipCodeINT);
                        cmd.ExecuteNonQuery();
                    }
                }
                // Confirm & refresh table
                MessageBox.Show("Provider updated successfully");
                dgvProviders.DataSource = sendQuery("SELECT * FROM provider");
                UpdateComboBoxes();
            }

            catch (Exception ex)
            {
                // Show error
                MessageBox.Show("Error updated provider: " + ex.Message);
            }
        }

        private void btnDeleteProvider_Click(object sender, EventArgs e)
        {
            // Get providerID
            int providerID = Convert.ToInt32(cmbProviderSelect.SelectedValue);

            // Show error when category is being used in products that are also being used
            if (sendQuery("SELECT * FROM product P " +
                          "JOIN items_ordered IO " +
                          "ON IO.product_id = P.product_id " +
                          "WHERE P.provider_id = " + providerID).Rows.Count > 0)
            {
                MessageBox.Show("Cannot delete this provder as it's being used in products that have been ordered");
                return;
            }

            // Show confimration box
            DialogResult result = MessageBox.Show("Are you sure you want to proceed?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Delete from customer table using customerID 
                sendQuery("DELETE FROM provider WHERE provider_id = " + providerID);

                // Confirm & refresh table/combo box
                MessageBox.Show("Provider deleted successfully");
                pCategoryInfo.Visible = false;
                dgvProviders.DataSource = sendQuery("SELECT * FROM provider");
                cmbProviderSelect.SelectedIndex = -1;
                UpdateComboBoxes();
            }

            // Return when user clicks No
            else
                return;
        }
    }
}