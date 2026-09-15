using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmParcelTracking : Form
    {
        private string userEmail;

        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmParcelTracking(string email)
        {
            InitializeComponent();

            userEmail = email;

            this.Load += FrmParcelTracking_Load;
            btnTrack.Click += btnTrack_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmParcelTracking_Load(object sender, EventArgs e)
        {
            ClearTrackingDetails();
        }

        private void btnTrack_Click(object sender, EventArgs e)
        {
            string trackingNumber = txtTrackingNumber.Text.Trim();

            if (trackingNumber == "")
            {
                MessageBox.Show(
                    "Please enter a tracking number.",
                    "Tracking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            p.TrackingNumber,
                            p.CourierName,
                            p.SenderName,
                            p.ReceivedDate,
                            p.ExpectedCollectionDate,
                            p.Status,
                            p.LocationID
                        FROM dbo.PARCEL p
                        INNER JOIN dbo.[USER] u
                            ON p.UserID = u.UserID
                        WHERE u.Email = @Email
                        AND p.TrackingNumber = @TrackingNumber";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email", userEmail);

                        command.Parameters.AddWithValue(
                            "@TrackingNumber", trackingNumber);

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtCourier.Text =
                                    reader["CourierName"].ToString();

                                txtSender.Text =
                                    reader["SenderName"].ToString();

                                txtReceivedDate.Text =
                                    Convert.ToDateTime(
                                        reader["ReceivedDate"])
                                        .ToString("yyyy-MM-dd");

                                if (reader["ExpectedCollectionDate"]
                                    != DBNull.Value)
                                {
                                    txtExpectedDate.Text =
                                        Convert.ToDateTime(
                                            reader["ExpectedCollectionDate"])
                                            .ToString("yyyy-MM-dd");
                                }
                                else
                                {
                                    txtExpectedDate.Text = "";
                                }

                                txtStatus.Text =
                                    reader["Status"].ToString();

                                if (reader["LocationID"] != DBNull.Value)
                                {
                                    txtLocation.Text =
                                        reader["LocationID"].ToString();
                                }
                                else
                                {
                                    txtLocation.Text = "";
                                }

                                MessageBox.Show(
                                    "Parcel found successfully.",
                                    "Tracking",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                ClearTrackingDetails();

                                MessageBox.Show(
                                    "No parcel found with this tracking number.",
                                    "Tracking",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Tracking failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTrackingDetails();
        }

        private void ClearTrackingDetails()
        {
            txtTrackingNumber.Clear();
            txtCourier.Clear();
            txtSender.Clear();
            txtReceivedDate.Clear();
            txtExpectedDate.Clear();
            txtStatus.Clear();
            txtLocation.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}