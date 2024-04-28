using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Orders : Form
    {

        private SqlConnection? cn;
        
        private SqlDataAdapter da;
        private DataTable dt;

        public Orders()
        {
            InitializeComponent();
            InitializeConnection();
            da = new SqlDataAdapter("SELECT * FROM ProductsTable", cn);
            dt = new DataTable();

        }

        private void InitializeConnection()
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;");
            cn.Open();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private bool IsValidProductId(string productId)
        {
            return int.TryParse(productId, out _);
        }


        private bool IsValidOrderDate(string orderDate)
        {
            return DateTime.TryParse(orderDate, out _);
        }

        private bool IsValidOrderQuantity(string ordQuantity)
        {
            return int.TryParse(ordQuantity, out _);
        }

        private void addorder_btn_Click(object sender, EventArgs e)
        {
            // Check if connection is initialized
            if (cn == null)
            {
                MessageBox.Show("Connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construct the SQL INSERT statement for OrdersTable
            string query = "INSERT INTO OrdersTable (CustomerName, ProductId, OrderDate, Quantity) VALUES (@customerName, @productId, @orderDate, @ordQuantity)";

            // Create and configure a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                // Add parameters to the SqlCommand
                cmd.Parameters.AddWithValue("@customerName", customerName.Text);

                // Validate ProductId
                if (!IsValidProductId(productIdTextBox.Text))
                {
                    MessageBox.Show("Please enter a valid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.Parameters.AddWithValue("@productId", int.Parse(productIdTextBox.Text));

                // Validate OrderDate
                if (!IsValidOrderDate(orderDate.Text))
                {
                    MessageBox.Show("Please enter a valid Order Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.Parameters.AddWithValue("@orderDate", DateTime.Parse(orderDate.Text).Date); // Ensure only the date part is stored

                // Validate OrderQuantity
                if (!IsValidOrderQuantity(ordQuantityTextBox.Text))
                {
                    MessageBox.Show("Please enter a valid Order Quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                cmd.Parameters.AddWithValue("@ordQuantity", int.Parse(ordQuantityTextBox.Text));

                try
                {
                    // Execute the SQL command
                    cmd.ExecuteNonQuery();

                    // Inform the user that the order has been added successfully
                    MessageBox.Show("Order added successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the form controls for the next order
                    customerName.Clear();
                    productIdTextBox.Clear();
                    orderDate.Value = DateTime.Today;
                    ordQuantityTextBox.Clear();
                }
                catch (Exception ex)
                {
                    // Display an error message if the insertion fails
                    MessageBox.Show("Error adding order: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void productId_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeorder_btn_Click(object sender, EventArgs e)
        {
            int orderId;
            if (!int.TryParse(this.orderIdTextBox.Text, out orderId))
            {
                MessageBox.Show("Please enter a valid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open a connection to the database
            using (SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;"))
            {
                cn.Open();

                // Prepare the SQL delete command with parameter
                string query = "DELETE FROM OrdersTable WHERE OrderId = @orderId";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were deleted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order removed successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Order with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsValidOrderId(string orderId)
        {
            return int.TryParse(orderId, out _);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void orderId_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validate OrderId
            if (!IsValidOrderId(orderIdTextBox.Text))
            {
                MessageBox.Show("Please enter a valid order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int orderId = int.Parse(orderIdTextBox.Text);

            // Construct the SQL UPDATE statement for OrdersTable
            string query = "UPDATE OrdersTable SET CustomerName = @customerName, ProductId = @productId, OrderDate = @orderDate, Quantity = @quantity WHERE OrderId = @orderId";

            // Create and configure a SqlCommand object
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@customerName", customerName.Text);
                cmd.Parameters.AddWithValue("@productId", int.Parse(productIdTextBox.Text));
                cmd.Parameters.AddWithValue("@orderDate", DateTime.Parse(orderDate.Text));
                cmd.Parameters.AddWithValue("@quantity", int.Parse(ordQuantityTextBox.Text));
                cmd.Parameters.AddWithValue("@orderId", orderId);

                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Order updated successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Orders_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM OrdersTable", cn);

            // Initialize and fill DataTable
            dt = new DataTable();
            da.Fill(dt);

            // Bind DataGridView to DataTable
            dataGridView1.DataSource = dt;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Orders login = new Orders();
            login.ShowDialog();
        }
    }
}
