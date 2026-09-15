using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmAdminDashboard : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        private int adminID;

        public FrmAdminDashboard()
        {
            InitializeComponent();

            // Recieving And Entry button
            button1.Click += button1_Click;

            // Pickup Verification button
            button2.Click += button2_Click;
        }

        private void FrmAdminDashboard_Load(object sender, EventArgs e)
        {
            LoadAdminID();
            LoadDashboard();
        }

        private void LoadAdminID()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT TOP 1 AdminID
                        FROM dbo.ADMIN
                        WHERE Username = 'admin'";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        object result =
                            command.ExecuteScalar();

                        if (result != null)
                        {
                            adminID = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load Admin ID.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadDashboard()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    LoadSummary(connection);
                    LoadParcels(connection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load Admin Dashboard.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadSummary(SqlConnection connection)
        {
            string totalQuery =
                "SELECT COUNT(*) FROM dbo.PARCEL";

            string pendingQuery =
                "SELECT COUNT(*) FROM dbo.PARCEL WHERE Status = 'Pending'";

            string collectedQuery =
                "SELECT COUNT(*) FROM dbo.PARCEL WHERE Status = 'Collected'";

            string todayQuery =
                @"SELECT COUNT(*)
                  FROM dbo.PARCEL
                  WHERE ReceivedDate = CAST(GETDATE() AS DATE)";

            using (SqlCommand command =
                new SqlCommand(totalQuery, connection))
            {
                lblTotalValue.Text =
                    command.ExecuteScalar().ToString();
            }

            using (SqlCommand command =
                new SqlCommand(pendingQuery, connection))
            {
                lblPendingValue.Text =
                    command.ExecuteScalar().ToString();
            }

            using (SqlCommand command =
                new SqlCommand(collectedQuery, connection))
            {
                lblCollectedValue.Text =
                    command.ExecuteScalar().ToString();
            }

            using (SqlCommand command =
                new SqlCommand(todayQuery, connection))
            {
                lblTodayValue.Text =
                    command.ExecuteScalar().ToString();
            }
        }

        private void LoadParcels(SqlConnection connection)
        {
            string query = @"
                SELECT
                    ParcelID,
                    TrackingNumber,
                    CourierName,
                    SenderName,
                    LocationID AS StorageLocation,
                    ReceivedDate,
                    ExpectedCollectionDate,
                    Status
                FROM dbo.PARCEL
                ORDER BY ParcelID ASC";

            using (SqlCommand command =
                new SqlCommand(query, connection))
            {
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    DataTable table = new DataTable();

                    adapter.Fill(table);

                    dgvParcels.DataSource = table;
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnCollectionRequests_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Collection Requests feature will be opened here.",
                "Collection Requests");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Reports feature will be opened here.",
                "Reports");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginPortal loginPortal = new LoginPortal();

            loginPortal.Show();

            this.Close();
        }

        // ==========================================
        // RECIEVING AND ENTRY
        // ==========================================

        private void button1_Click(object sender, EventArgs e)
        {
            FrmParcelReceiving parcelReceiving =
                new FrmParcelReceiving();

            parcelReceiving.Show();
        }

        // ==========================================
        // PICKUP VERIFICATION
        // ==========================================

        private void button2_Click(object sender, EventArgs e)
        {
            if (adminID == 0)
            {
                MessageBox.Show(
                    "Admin ID could not be found.",
                    "Pickup Verification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            FrmPickupVerification pickupVerification =
                new FrmPickupVerification(adminID);

            pickupVerification.Show();
        }
    }
}