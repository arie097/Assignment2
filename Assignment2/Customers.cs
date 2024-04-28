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
    public partial class Customers : Form
    {

        private SqlConnection? cn;
        private SqlDataAdapter da;
        private DataTable dt;

        public Customers()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addcust_btn_Click(object sender, EventArgs e)
        {
            if (cn != null)
            {
                // Construct the SQL INSERT statement
                string query = "INSERT INTO CustomersTable (CustomerName, PhoneNumber, Address, Email) VALUES (@custName, @phoneNumber, @address, @email)";

                // Create and configure a SqlCommand object
                using (SqlCommand cmd = new SqlCommand(query, cn))
                {
                    // Add parameters to the SqlCommand
                    cmd.Parameters.AddWithValue("@custName", custName.Text);
                    cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber.Text);
                    cmd.Parameters.AddWithValue("@address", address.Text);
                    cmd.Parameters.AddWithValue("@email", email.Text);

                    try
                    {

                        cmd.ExecuteNonQuery();

                        // Inform the user that the customer has been added successfully
                        MessageBox.Show("Customer added successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Clear the form controls for the next customer
                        custName.Clear();
                        phoneNumber.Clear();
                        address.Clear();
                        email.Clear();
                    }
                    catch (Exception ex)
                    {
                        // Display an error message if the insertion fails
                        MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("SELECT * FROM CustomersTable", cn);

            // Initialize and fill DataTable
            dt = new DataTable();
            da.Fill(dt);

            // Bind DataGridView to DataTable
            dataGridView1.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updatecust_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(customerIdTextBox.Text, out int customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;");
            cn.Open();

            string query = "UPDATE CustomersTable SET CustomerName = @customerName, PhoneNumber = @phoneNumber, Address = @address, Email = @email WHERE Id = @customerId";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@customerName", custName.Text);
            cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber.Text);
            cmd.Parameters.AddWithValue("@address", address.Text);
            cmd.Parameters.AddWithValue("@email", email.Text);
            cmd.Parameters.AddWithValue("@customerId", customerId);

            cmd.ExecuteNonQuery();

            cn.Close();

            MessageBox.Show("Customer updated successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void removecust_btn_Click(object sender, EventArgs e)
        {
            int customerId;
            if (!int.TryParse(this.customerIdTextBox.Text, out customerId))
            {
                MessageBox.Show("Please enter a valid customer ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQ5JPP16\SQLEXPRESS;Initial Catalog=sample;Integrated Security=True;"))
            {
                cn.Open();

                // Prepare the SQL delete command with parameter
                string query = "DELETE FROM CustomersTable WHERE Id = @customerId";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@customerId", customerId);

                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                // Check if any rows were deleted
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Customer removed successfully! Please Refresh to update the table", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Customer with the specified ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
            Customers login = new Customers();
            login.ShowDialog();
        }
    }
}
