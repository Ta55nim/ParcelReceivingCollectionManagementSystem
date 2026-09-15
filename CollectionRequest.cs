using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmCollectionRequest : Form
    {
        private string userEmail;

        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmCollectionRequest(string email)
        {
            InitializeComponent();

            userEmail = email;

            this.Load += FrmCollectionRequest_Load;
            btnRequest.Click += btnRequest_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmCollectionRequest_Load(object sender, EventArgs e)
        {
            LoadParcels();
        }

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
                            p.TrackingNumber
                        FROM dbo.PARCEL p
                        INNER JOIN dbo.[USER] u
                            ON p.UserID = u.UserID
                        WHERE u.Email = @Email
                        AND p.Status <> 'Collected'
                        ORDER BY p.ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@Email", userEmail);

                        using (SqlDataReader reader =
                            command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                cmbParcel.Items.Add(
                                    new ParcelItem
                                    {
                                        ParcelID =
                                            Convert.ToInt32(
                                                reader["ParcelID"]),

                                        TrackingNumber =
                                            reader["TrackingNumber"]
                                            .ToString()
                                    });
                            }
                        }
                    }
                }

                if (cmbParcel.Items.Count > 0)
                {
                    cmbParcel.SelectedIndex = 0;
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

                    // First check whether a request already exists
                    string checkQuery = @"
                        SELECT CollectionStatus
                        FROM dbo.PARCEL
                        WHERE ParcelID = @ParcelID
                        AND UserID =
                        (
                            SELECT UserID
                            FROM dbo.[USER]
                            WHERE Email = @Email
                        )";

                    using (SqlCommand checkCommand =
                        new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue(
                            "@ParcelID", selectedParcel.ParcelID);

                        checkCommand.Parameters.AddWithValue(
                            "@Email", userEmail);

                        object result =
                            checkCommand.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show(
                                "Parcel not found.",
                                "Collection Request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                            return;
                        }

                        if (result != DBNull.Value &&
                            result.ToString() == "Requested")
                        {
                            MessageBox.Show(
                                "Collection request already submitted.",
                                "Collection Request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            return;
                        }
                    }

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
                        )";

                    using (SqlCommand updateCommand =
                        new SqlCommand(updateQuery, connection))
                    {
                        updateCommand.Parameters.AddWithValue(
                            "@RequestDate", DateTime.Now.Date);

                        updateCommand.Parameters.AddWithValue(
                            "@ParcelID", selectedParcel.ParcelID);

                        updateCommand.Parameters.AddWithValue(
                            "@Email", userEmail);

                        int rowsAffected =
                            updateCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Collection request submitted successfully!",
                                "Collection Request",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(
                                "Collection request failed.",
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
                    "Collection request failed.\n\n" + ex.Message,
                    "Error",
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private class ParcelItem
        {
            public int ParcelID { get; set; }

            public string TrackingNumber { get; set; }

            public override string ToString()
            {
                return TrackingNumber;
            }
        }
    }
}