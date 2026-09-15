using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ParcelManagement
{
    public partial class LoginPortal : Form
    {
        public LoginPortal()
        {
            InitializeComponent();

            // Initially error messages will be hidden
            txtInvUN.Visible = false;
            txtInvPass.Visible = false;

            // Login button click event
            btnLogin.Click += btnLogin_Click;

            // Register button click event
            btnRegister.Click += btnRegister_Click;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Hide previous error messages first
            txtInvUN.Visible = false;
            txtInvPass.Visible = false;

            string username = textBox2.Text.Trim();
            string password = textBox3.Text;

            // =====================================
            // ADMIN LOGIN
            // =====================================

            if (username == "admin" && password == "1234")
            {
                MessageBox.Show("Admin Login Successful!");
                return;
            }

            // =====================================
            // USER LOGIN FROM DATABASE
            // =====================================

            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT Password
                                     FROM dbo.[USER]
                                     WHERE Email = @Email
                                     AND Role = 'User'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", username);

                        object result = cmd.ExecuteScalar();

                        // Email doesn't exist
                        if (result == null)
                        {
                            txtInvUN.Visible = true;
                            return;
                        }

                        // Email exists, check password
                        string databasePassword = result.ToString();

                        if (databasePassword != password)
                        {
                            txtInvPass.Visible = true;
                            return;
                        }

                        // =====================================
                        // CORRECT USER LOGIN
                        // =====================================

                        MessageBox.Show("User Login Successful!");

                        UserDashboard userDashboard = new UserDashboard(username);
                        userDashboard.Show();

                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database Error: " + ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegistrationPortal registrationPortal = new RegistrationPortal();
            registrationPortal.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}