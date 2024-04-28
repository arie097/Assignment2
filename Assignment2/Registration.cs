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
    public partial class Registration : Form
    {

        private SqlConnection? cn;
        public Registration()
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (cn != null) // Check if the connection is initialized
            {
                if (!string.IsNullOrEmpty(txtusername.Text) && !string.IsNullOrEmpty(txtpassword.Text))
                {

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM LoginTable WHERE username = @username", cn))
                    {
                        cmd.Parameters.AddWithValue("@username", txtusername.Text);

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                MessageBox.Show("Username already exists. Please try another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                dr.Close();

                                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO LoginTable (username, password) VALUES (@username, @password)", cn))
                                {
                                    insertCmd.Parameters.AddWithValue("@username", txtusername.Text);
                                    insertCmd.Parameters.AddWithValue("@password", txtpassword.Text);

                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show("Your account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
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
            Login login = new Login();
            login.ShowDialog();
        }
    }
}
