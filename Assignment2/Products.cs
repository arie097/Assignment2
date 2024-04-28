using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Products : Form
    {
        private int productId;
        private SqlConnection? cn;
        private SqlDataAdapter da;
        private DataTable dt;

        public Products()
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

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (cn != null && cn.State == System.Data.ConnectionState.Open)
            {
                cn.Close();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // Initialize SqlDataAdapter
            da = new SqlDataAdapter("SELECT * FROM ProductsTable", cn);

            // Initialize and fill DataTable
            dt = new DataTable();
            da.Fill(dt);

            // Bind DataGridView to DataTable
            dataGridView1.DataSource = dt;
        }

        private void addprod_btn_Click(object sender, EventArgs e)
        {
            if (cn != null) // Check if the connection is initialized
            {
                // Construct the SQL INSERT statement
                string query = "INSERT INTO ProductsTable (ProductName, Description, Price, ProductQuantity) VALUES (@productName, @description, @price, @productQuantity)";

                // Create and configure a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@productName", productName.Text);
                    cmd.Parameters.AddWithValue("@description", description.Text);

                    // Parse and convert the price to float
                    if (float.TryParse(price.Text, out float priceValue))
                    {
                        cmd.Parameters.AddWithValue("@price", priceValue);
                    }
                    else
                    {
                        MessageBox.Show("Invalid price format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Parse and convert the product quantity to int
                    if (int.TryParse(productQuantity.Text, out int quantityValue))
                    {
                        cmd.Parameters.AddWithValue("@productQuantity", quantityValue);
                    }
                    else
                    {
                        MessageBox.Show("Invalid product quantity. Please enter a valid integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Exit the method if product quantity format is invalid
                    }

                    try
                    {
                        // Execute the SQL command
                        cmd.ExecuteNonQuery();

                        // Inform the user that the product has been added successfully
                        MessageBox.Show("Product added successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the form controls for the next product
                        productName.Clear();
                        description.Clear();
                        price.Clear();
                        productQuantity.Clear();
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if the insertion fails
                        MessageBox.Show("Error adding product: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(productIdTextBox.Text, out productId))
            {
                MessageBox.Show("Please enter a valid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;");
            cn.Open();
            SqlCommand cmd = new SqlCommand("UPDATE ProductsTable SET ProductName = @productName, Description = @description, Price = @price, ProductQuantity = @productQuantity WHERE Id = @productId", cn);
            cmd.Parameters.AddWithValue("@productName", productName.Text);
            cmd.Parameters.AddWithValue("@description", description.Text);
            cmd.Parameters.AddWithValue("@price", float.Parse(price.Text));
            cmd.Parameters.AddWithValue("@productQuantity", int.Parse(productQuantity.Text));
            cmd.Parameters.AddWithValue("@productId", productId);

            cmd.ExecuteNonQuery(); // Execute the SQL command without capturing the number of rows affected

            cn.Close();

            MessageBox.Show("Successfully Updated! Please Refresh to update the table");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void productId_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void removeprod_btn_Click(object sender, EventArgs e)
        {
            int productId;
            if (!int.TryParse(productIdTextBox.Text, out productId))
            {
                MessageBox.Show("Please enter a valid product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Open a connection to the database
            using (SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;"))
            {
                cn.Open();

                // Prepare the SQL delete command with parameter
                string query = "DELETE FROM ProductsTable WHERE Id = @productId";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@productId", productId);

                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were deleted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Product removed successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Product with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Home login = new Home();
            login.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Products login = new Products();
            login.ShowDialog();
        }
    }
}
