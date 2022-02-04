using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;//general data objects
using System.Data.SqlClient;//for sql server data objects
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleApp
{
    public partial class Form1 : Form
    {
        string connection_string = "Data Source = SULEMANPC\\SQLEXPRESS;Initial Catalog = PointOfSale; Integrated Security = True";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            SqlConnection product_connection = new SqlConnection(connection_string);
            SqlCommand product_command = new SqlCommand("SELECT * FROM Product");
            SqlDataAdapter da_product = new SqlDataAdapter();
            DataTable dt_product = new DataTable();

            if (product_connection.State == ConnectionState.Open)
                product_connection.Close();
            product_connection.Open();

            product_command.Connection = product_connection;

            da_product.SelectCommand = product_command;
            da_product.Fill(dt_product);
            dgvProductData.DataSource = dt_product;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection product_connection = new SqlConnection(connection_string);

            string product_name = txtProductName.Text;
            string product_price = txtProductPrice.Text;
            string remarks = txtRemarks.Text;

            string insert_query = "INSERT INTO Product VALUES('" + product_name + "'," + product_price + ", '" + remarks + "')";
            SqlCommand product_command = new SqlCommand(insert_query);
           
            if (product_connection.State == ConnectionState.Open)
                product_connection.Close();
            product_connection.Open();

            product_command.Connection = product_connection;
            int rows_inserted = product_command.ExecuteNonQuery();
            if (rows_inserted > 0)
            {
                MessageBox.Show("Data Saved");
                txtProductName.Text = "";
                txtProductPrice.Text = "";
                txtRemarks.Text = "";
            }

        }
    }
}
