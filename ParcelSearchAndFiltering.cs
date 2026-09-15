using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmParcelSearchAndFiltering : Form
    {
        private string userEmail;

        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmParcelSearchAndFiltering(string email)
        {
            InitializeComponent();

            userEmail = email;

            this.Load += FrmParcelSearchAndFiltering_Load;
            btnSearch.Click += btnSearch_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmParcelSearchAndFiltering_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.Clear();

            cmbStatus.Items.Add("All");
            cmbStatus.Items.Add("Received");
            cmbStatus.Items.Add("Stored");
            cmbStatus.Items.Add("Ready");
            cmbStatus.Items.Add("Collected");

            cmbStatus.SelectedIndex = 0;

            LoadParcels();
        }

        private void LoadParcels()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            p.ParcelID,
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
                        ORDER BY p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Email", userEmail);

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(command);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvParcels.DataSource = table;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load parcels.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT
                            p.ParcelID,
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

                        AND
                        (
                            @TrackingNumber = ''
                            OR p.TrackingNumber LIKE
                            '%' + @TrackingNumber + '%'
                        )

                        AND
                        (
                            @CourierName = ''
                            OR p.CourierName LIKE
                            '%' + @CourierName + '%'
                        )

                        AND
                        (
                            @SenderName = ''
                            OR p.SenderName LIKE
                            '%' + @SenderName + '%'
                        )

                        AND
                        (
                            @ReceivedDate = ''
                            OR CONVERT(VARCHAR(10), p.ReceivedDate, 23)
                            = @ReceivedDate
                        )

                        AND
                        (
                            @Status = 'All'
                            OR p.Status = @Status
                        )

                        AND
                        (
                            @LocationID = ''
                            OR CONVERT(VARCHAR(20), p.LocationID)
                            = @LocationID
                        )

                        ORDER BY p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email", userEmail);

                        command.Parameters.AddWithValue(
                            "@TrackingNumber",
                            txtTracking.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@CourierName",
                            txtCourier.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@SenderName",
                            txtSender.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@ReceivedDate",
                            txtReceivedDate.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@Status",
                            cmbStatus.Text);

                        command.Parameters.AddWithValue(
                            "@LocationID",
                            txtLocation.Text.Trim());

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(command);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        dgvParcels.DataSource = table;

                        if (table.Rows.Count == 0)
                        {
                            MessageBox.Show(
                                "No parcel found.",
                                "Search Result",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Search failed.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTracking.Clear();
            txtCourier.Clear();
            txtSender.Clear();
            txtReceivedDate.Clear();
            txtLocation.Clear();

            cmbStatus.SelectedIndex = 0;

            LoadParcels();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}