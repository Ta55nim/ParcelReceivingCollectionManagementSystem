using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmCollectionRequest : Form
    {
        private string userEmail;
        private bool adminMode = false;

        private string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        // USER MODE
        public FrmCollectionRequest(string email)
        {
            InitializeComponent();

            userEmail = email;
            adminMode = false;

            SetupUserMode();

            this.Load += FrmCollectionRequest_Load;

            btnRequest.Click += btnRequest_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        // ADMIN MODE
        public FrmCollectionRequest()
        {
            InitializeComponent();

            adminMode = true;

            SetupAdminMode();

            this.Load += FrmCollectionRequest_Load;

            btnRefresh.Click += btnRefresh_Click;
            btnClose.Click += btnClose_Click;
        }

        private void SetupUserMode()
        {
            lblTitle.Text = "Collection Request";

            lblParcel.Visible = true;
            cmbParcel.Visible = true;
            lblInfo.Visible = true;

            btnRequest.Visible = true;
            btnClear.Visible = true;

            dgvRequests.Visible = false;
            btnRefresh.Visible = false;
        }

        private void SetupAdminMode()
        {
            lblTitle.Text = "Collection Requests";

            lblParcel.Visible = false;
            cmbParcel.Visible = false;
            lblInfo.Visible = false;

            btnRequest.Visible = false;
            btnClear.Visible = false;

            dgvRequests.Visible = true;
            btnRefresh.Visible = true;
        }

        private void FrmCollectionRequest_Load(object sender, EventArgs e)
        {
            if (adminMode)
            {
                LoadCollectionRequests();
            }
            else
            {
                LoadParcels();
            }
        }

        // =========================
        // USER SIDE
        // =========================

        private void LoadParcels()
        {
            try
            {
                cmbParcel.Items.Clear();

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
                            p.Status
                        FROM dbo.PARCEL p
                        INNER JOIN dbo.[USER] u
                            ON p.UserID = u.UserID
                        WHERE u.Email = @Email
                        AND p.Status <> 'Collected'
                        AND
                        (
                            p.CollectionStatus IS NULL
                            OR p.CollectionStatus <> 'Requested'
                        )
                        ORDER BY p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email",
                            userEmail);

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ParcelItem item = new ParcelItem();

                                item.ParcelID =
                                    Convert.ToInt32(
                                        reader["ParcelID"]);

                                item.TrackingNumber =
                                    reader["TrackingNumber"].ToString();

                                item.CourierName =
                                    reader["CourierName"].ToString();

                                item.SenderName =
                                    reader["SenderName"] == DBNull.Value
                                    ? ""
                                    : reader["SenderName"].ToString();

                                item.ReceivedDate =
                                    Convert.ToDateTime(
                                        reader["ReceivedDate"]);

                                item.ExpectedCollectionDate =
                                    reader["ExpectedCollectionDate"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(
                                        reader["ExpectedCollectionDate"]);

                                item.Status =
                                    reader["Status"].ToString();

                                cmbParcel.Items.Add(item);
                            }
                        }
                    }
                }

                if (cmbParcel.Items.Count > 0)
                {
                    cmbParcel.SelectedIndex = 0;
                }
                else
                {
                    lblInfo.Text =
                        "No parcel is currently available for collection request.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load parcels.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if (cmbParcel.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a parcel.",
                    "Collection Request",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ParcelItem selectedParcel =
                (ParcelItem)cmbParcel.SelectedItem;

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string updateQuery = @"
                        UPDATE dbo.PARCEL
                        SET
                            CollectionRequestDate = @RequestDate,
                            CollectionStatus = 'Requested'
                        WHERE ParcelID = @ParcelID
                        AND UserID =
                        (
                            SELECT UserID
                            FROM dbo.[USER]
                            WHERE Email = @Email
                        )
                        AND
                        (
                            CollectionStatus IS NULL
                            OR CollectionStatus <> 'Requested'
                        )";

                    using (SqlCommand command =
                        new SqlCommand(updateQuery, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@RequestDate",
                            DateTime.Now.Date);

                        command.Parameters.AddWithValue(
                            "@ParcelID",
                            selectedParcel.ParcelID);

                        command.Parameters.AddWithValue(
                            "@Email",
                            userEmail);

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Collection request submitted successfully!",
                                "Collection Request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadParcels();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Collection request could not be submitted.",
                                "Collection Request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Collection request failed.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (cmbParcel.Items.Count > 0)
            {
                cmbParcel.SelectedIndex = 0;
            }
            else
            {
                cmbParcel.SelectedIndex = -1;

                lblInfo.Text =
                    "No parcel is currently available for collection request.";
            }
        }

        // =========================
        // ADMIN SIDE
        // =========================

        private void LoadCollectionRequests()
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
                            u.Name AS UserName,
                            u.Email,
                            p.CourierName,
                            p.SenderName,
                            p.ReceivedDate,
                            p.CollectionRequestDate,
                            p.CollectionStatus,
                            p.Status
                        FROM dbo.PARCEL p
                        INNER JOIN dbo.[USER] u
                            ON p.UserID = u.UserID
                        WHERE p.CollectionStatus = 'Requested'
                        ORDER BY
                            p.CollectionRequestDate DESC,
                            p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter =
                            new SqlDataAdapter(command))
                        {
                            DataTable table =
                                new DataTable();

                            adapter.Fill(table);

                            dgvRequests.DataSource = table;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load collection requests.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadCollectionRequests();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class ParcelItem
        {
            public int ParcelID { get; set; }

            public string TrackingNumber { get; set; }

            public string CourierName { get; set; }

            public string SenderName { get; set; }

            public DateTime ReceivedDate { get; set; }

            public DateTime? ExpectedCollectionDate { get; set; }

            public string Status { get; set; }

            public override string ToString()
            {
                return TrackingNumber;
            }
        }
    }
}