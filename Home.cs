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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=OnlineStore;User Id=postgres;Password=HoeftHuesman366");
            //conn.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand();
            //cmd.Connection = conn;
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select * from product";
            //NpgsqlDataReader reader = cmd.ExecuteReader();
            //if (reader.HasRows)
            //{
            //    DataTable dt = new DataTable();
            //    dt.Load(reader);
            //    dataGridView1.DataSource = dt;
            //}
            //cmd.Dispose();
            //conn.Close();
        }

        private void btnAdministration_Click(object sender, EventArgs e)
        {
            Administration adminForm = new Administration();
            this.Hide();
            adminForm.ShowDialog();
            this.Show();  //this.CLose() (if we want it to close and not reopen)
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            Orders orderForm = new Orders();
            this.Hide();
            orderForm.ShowDialog();
            this.Show();  //this.CLose() (if we want it to close and not reopen)
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            Products productsForm = new Products();
            this.Hide();
            productsForm.ShowDialog();
            this.Show();  //this.CLose() (if we want it to close and not reopen)
        }
    }
}