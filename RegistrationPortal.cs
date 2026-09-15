using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class RegistrationPortal : Form
    {
        // Database connection
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public RegistrationPortal()
        {
            InitializeComponent();

            // Register button click event
            button5.Click += button5_Click;

            // Password hide
            textBox3.PasswordChar = '*';
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Get values from the form
            string name = textBox1.Text;
            string email = textBox2.Text;
            string password = textBox3.Text;
            DateTime dob = dateTimePicker1.Value;
            string address = textBox4.Text;

            // Get gender
            string gender = "";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }
            else if (radioButton2.Checked)
            {
                gender = "Female";
            }

            // Check required fields
            if (name == "" || email == "" || password == "" ||
                gender == "" || address == "")
            {
                MessageBox.Show("Please fill up all the information.");
                return;
            }

            // Role will always be User
            string role = "User";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"INSERT INTO dbo.[USER]
                                     (Name, Email, Password, Role, DateOfBirth, Gender, Address)
                                     VALUES
                                     (@Name, @Email, @Password, @Role, @DateOfBirth, @Gender, @Address)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@Role", role);
                        command.Parameters.AddWithValue("@DateOfBirth", dob);
                        command.Parameters.AddWithValue("@Gender", gender);
                        command.Parameters.AddWithValue("@Address", address);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration Successful!");

                // Clear the form
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed.\n\n" + ex.Message);
            }
        }

        private void RegistrationPortal_Load(object sender, EventArgs e)
        {

        }
    }
}