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

        private void dgvProductData_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewCell id_cell = dgvProductData.Rows[e.RowIndex].Cells[0];
            DataGridViewCell name_cell = dgvProductData.Rows[e.RowIndex].Cells[1];
            DataGridViewCell price_cell = dgvProductData.Rows[e.RowIndex].Cells[2];
            DataGridViewCell remarks_cell = dgvProductData.Rows[e.RowIndex].Cells[3];

            int product_id = Convert.ToInt32(id_cell.Value);
            txtProductID.Text = product_id.ToString();

            string product_name = name_cell.Value.ToString();
            txtProductName.Text = product_name;

            double product_price = Convert.ToDouble(price_cell.Value);
            txtProductPrice.Text = product_price.ToString();

            string remarks = remarks_cell.Value.ToString();
            txtRemarks.Text = remarks;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
                return;

            string product_id = txtProductID.Text;
            string product_name = txtProductName.Text;
            string product_price = txtProductPrice.Text;
            string remarks = txtRemarks.Text;


            SqlConnection product_connection = new SqlConnection(connection_string);

            string update_query = "UPDATE Product SET ProductName = '" + product_name + "', ProductPrice = " + product_price + ", Remarks = '" + remarks + "' WHERE ProductID = " + product_id;
            SqlCommand product_command = new SqlCommand(update_query);

            if (product_connection.State == ConnectionState.Open)
                product_connection.Close();
            product_connection.Open();

            product_command.Connection = product_connection;
            int rows_updated = product_command.ExecuteNonQuery();
            if (rows_updated > 0)
                MessageBox.Show("Row Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text == "")
                return;

            SqlConnection product_connection = new SqlConnection(connection_string);
            SqlCommand product_command = new SqlCommand("DELETE FROM Product WHERE ProductID = " + txtProductID.Text);
            if (product_connection.State == ConnectionState.Open)
                product_connection.Close();
            product_connection.Open();

            product_command.Connection = product_connection;
            int rows_delete = product_command.ExecuteNonQuery();
            if (rows_delete > 0)
                MessageBox.Show("Row Deleted");
        }
    }
}
