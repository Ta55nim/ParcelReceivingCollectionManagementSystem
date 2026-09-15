using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmCollectionStatusHistory : Form
    {
        private string userEmail;

        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmCollectionStatusHistory(string email)
        {
            InitializeComponent();

            userEmail = email;

            btnRefresh.Click += btnRefresh_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmCollectionStatusHistory_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void LoadHistory()
        {
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
                            p.ReceivedDate,
                            p.ExpectedCollectionDate,
                            p.Status,
                            p.CollectionRequestDate,
                            p.CollectionStatus,
                            p.VerificationStatus,
                            p.VerificationDate,
                            p.CollectionDate,
                            p.Remarks
                        FROM dbo.PARCEL p
                        INNER JOIN dbo.[USER] u
                            ON p.UserID = u.UserID
                        WHERE u.Email = @Email
                        ORDER BY p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email",
                            userEmail);

                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvHistory.DataSource = table;
                        }
                    }
                }

                if (dgvHistory.Rows.Count == 0)
                {
                    MessageBox.Show(
                        "No collection history found.",
                        "Collection History",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load collection history.\n\n"
                    + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}