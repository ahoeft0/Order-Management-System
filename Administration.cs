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
            // Populate select combo boxes with data
            // Customers setup
            DataTable customers = sendQuery("SELECT first_name, last_name, customer_id FROM customer");
            if (customers.Rows.Count > 0)
            {
                pCustomerInfo.Visible = false;
                customers.Columns.Add("full_name", typeof(string), "first_name + ' ' + last_name");
                cmbCustomerSelect.DataSource = customers;
                cmbCustomerSelect.ValueMember = customers.Columns[2].ColumnName;
                cmbCustomerSelect.DisplayMember = customers.Columns[3].ColumnName;
                cmbCustomerSelect.SelectedIndex = -1;
            }
        }

        public Administration()
        {
            InitializeComponent();

            // Populate views of each model with all data
            dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
            dgvCustomers.DataSource = sendQuery("SELECT * FROM category");
            dgvCustomers.DataSource = sendQuery("SELECT * FROM customer");
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

        // Create Customer
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

    }
}