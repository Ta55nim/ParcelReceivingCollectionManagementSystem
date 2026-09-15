using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmParcelReceiving : Form
    {
        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmParcelReceiving()
        {
            InitializeComponent();
        }

        private void FrmParcelReceiving_Load(object sender, EventArgs e)
        {
            GenerateTrackingNumber();
            LoadRecipients();

            dtpReceivedDate.Value = DateTime.Today;
            dtpExpectedCollectionDate.Value = DateTime.Today.AddDays(3);

            txtStatus.Text = "Pending";
        }

        // ==========================================
        // GENERATE TRACKING NUMBER
        // ==========================================

        private void GenerateTrackingNumber()
        {
            txtTrackingNumber.Text =
                "TRK" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
        }

        // ==========================================
        // LOAD REGISTERED USERS
        // ==========================================

        private void LoadRecipients()
        {
            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        SELECT UserID, Name
                        FROM dbo.[USER]
                        WHERE Role = 'User'
                        ORDER BY Name";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            cmbRecipient.Items.Clear();

                            while (reader.Read())
                            {
                                cmbRecipient.Items.Add(
                                    new UserItem
                                    {
                                        UserID =
                                            Convert.ToInt32(
                                                reader["UserID"]),

                                        Name =
                                            reader["Name"].ToString()
                                    });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load registered users.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // RECEIVE PARCEL
        // ==========================================

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (cmbRecipient.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a recipient.");

                return;
            }

            if (txtSenderName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter sender name.");

                txtSenderName.Focus();

                return;
            }

            if (txtCourierName.Text.Trim() == "")
            {
                MessageBox.Show(
                    "Please enter courier name.");

                txtCourierName.Focus();

                return;
            }

            if (dtpExpectedCollectionDate.Value.Date <
                dtpReceivedDate.Value.Date)
            {
                MessageBox.Show(
                    "Expected collection date cannot be before received date.");

                return;
            }

            try
            {
                UserItem selectedUser =
                    (UserItem)cmbRecipient.SelectedItem;

                int userID =
                    selectedUser.UserID;

                int? locationID = null;

                if (txtLocationID.Text.Trim() != "")
                {
                    int tempLocationID;

                    if (!int.TryParse(
                        txtLocationID.Text.Trim(),
                        out tempLocationID))
                    {
                        MessageBox.Show(
                            "Storage Location must be a number.");

                        txtLocationID.Focus();

                        return;
                    }

                    locationID = tempLocationID;
                }

                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        INSERT INTO dbo.PARCEL
                        (
                            TrackingNumber,
                            CourierName,
                            SenderName,
                            ReceivedDate,
                            ExpectedCollectionDate,
                            Status,
                            UserID,
                            LocationID
                        )
                        VALUES
                        (
                            @TrackingNumber,
                            @CourierName,
                            @SenderName,
                            @ReceivedDate,
                            @ExpectedCollectionDate,
                            @Status,
                            @UserID,
                            @LocationID
                        )";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@TrackingNumber",
                            txtTrackingNumber.Text);

                        command.Parameters.AddWithValue(
                            "@CourierName",
                            txtCourierName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@SenderName",
                            txtSenderName.Text.Trim());

                        command.Parameters.AddWithValue(
                            "@ReceivedDate",
                            dtpReceivedDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@ExpectedCollectionDate",
                            dtpExpectedCollectionDate.Value.Date);

                        command.Parameters.AddWithValue(
                            "@Status",
                            "Pending");

                        command.Parameters.AddWithValue(
                            "@UserID",
                            userID);

                        if (locationID.HasValue)
                        {
                            command.Parameters.AddWithValue(
                                "@LocationID",
                                locationID.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue(
                                "@LocationID",
                                DBNull.Value);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Parcel received successfully!\n\n" +
                    "Tracking Number: " +
                    txtTrackingNumber.Text,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to receive parcel.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ==========================================
        // CLEAR FORM
        // ==========================================

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            cmbRecipient.SelectedIndex = -1;

            txtSenderName.Clear();
            txtCourierName.Clear();
            txtLocationID.Clear();

            dtpReceivedDate.Value = DateTime.Today;

            dtpExpectedCollectionDate.Value =
                DateTime.Today.AddDays(3);

            txtStatus.Text = "Pending";

            GenerateTrackingNumber();
        }

        // ==========================================
        // CLOSE FORM
        // ==========================================

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ==========================================
        // USER ITEM
        // ==========================================

        private class UserItem
        {
            public int UserID { get; set; }

            public string Name { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
    }
}