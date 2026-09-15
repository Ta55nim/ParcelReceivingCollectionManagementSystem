using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class MyProfile : Form
    {
        private string userEmail;

        public MyProfile(string email)
        {
            InitializeComponent();

            userEmail = email;

            // Load user profile when form opens
            LoadProfile();

            // Make profile details completely static
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;

            // Back to Dashboard button
            btnBackDashboard.Click += btnBackDashboard_Click;
        }

        private void LoadProfile()
        {
            string connectionString =
                @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    string query = @"SELECT Name, Email, Password, DateOfBirth, Gender, Address
                                     FROM dbo.[USER]
                                     WHERE Email = @Email
                                     AND Role = 'User'";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", userEmail);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["Name"].ToString();

                                textBox2.Text = reader["Email"].ToString();

                                textBox3.Text = reader["Password"].ToString();

                                if (reader["DateOfBirth"] != DBNull.Value)
                                {
                                    DateTime dob =
                                        Convert.ToDateTime(reader["DateOfBirth"]);

                                    textBox5.Text = dob.ToString("dd/MM/yyyy");
                                }

                                textBox6.Text = reader["Gender"].ToString();

                                textBox4.Text = reader["Address"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to load profile.\n\n" + ex.Message);
            }
        }

        private void btnBackDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}