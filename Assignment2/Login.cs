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
    public partial class Login : Form
    {

        private SqlConnection? cn;

        public Login()
        {
            InitializeComponent();
            InitializeConnection();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cn != null) // Check if the connection is initialized
            {
                if (!string.IsNullOrEmpty(txtusername.Text) && !string.IsNullOrEmpty(txtpassword.Text))
                {
                    // Query to check if the username and password match
                    string query = "SELECT COUNT(*) FROM LoginTable WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, cn))
                    {
                        // Add parameters
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);
                        cmd.Parameters.AddWithValue("@password", txtpassword.Text);

                        // Execute the query
                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0) // If a matching record is found
                        {
                            // Successful login
                            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Redirect to the homepage GUI
                            Home homepage = new Home();
                            this.Hide();
                            homepage.ShowDialog();
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Connection is not initialized.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Registration login = new Registration();
            login.ShowDialog();
        }
    }
}
