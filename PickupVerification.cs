using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class FrmPickupVerification : Form
    {
        private int adminID;

        string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ParcelManagementDB;Integrated Security=True";

        public FrmPickupVerification(int id)
        {
            InitializeComponent();

            adminID = id;

            this.Load += FrmPickupVerification_Load;
            btnVerify.Click += btnVerify_Click;
            btnClear.Click += btnClear_Click;
            btnClose.Click += btnClose_Click;
        }

        private void FrmPickupVerification_Load(object sender, EventArgs e)
        {
            LoadRequestedParcels();
        }

        private void LoadRequestedParcels()
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
                            ParcelID,
                            TrackingNumber
                        FROM dbo.PARCEL
                        WHERE CollectionStatus = 'Requested'
                        AND VerificationStatus IS NULL
                        ORDER BY ParcelID DESC";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
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
                    "Unable to load requested parcels.\n\n"
                    + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (cmbParcel.SelectedItem == null)
            {
                MessageBox.Show(
                    "Please select a parcel.",
                    "Pickup Verification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            ParcelItem selectedParcel =
                (ParcelItem)cmbParcel.SelectedItem;

            DialogResult result = MessageBox.Show(
                "Are you sure you want to verify pickup for tracking number:\n\n"
                + selectedParcel.TrackingNumber,
                "Confirm Pickup Verification",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = @"
                        UPDATE dbo.PARCEL
                        SET
                            VerificationStatus = 'Verified',
                            VerifiedBy = @AdminID,
                            VerificationDate = @VerificationDate
                        WHERE ParcelID = @ParcelID
                        AND CollectionStatus = 'Requested'
                        AND VerificationStatus IS NULL";

                    using (SqlCommand command =
                        new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue(
                            "@AdminID", adminID);

                        command.Parameters.AddWithValue(
                            "@VerificationDate",
                            DateTime.Now.Date);

                        command.Parameters.AddWithValue(
                            "@ParcelID",
                            selectedParcel.ParcelID);

                        int rowsAffected =
                            command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show(
                                "Pickup verified successfully!",
                                "Pickup Verification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            LoadRequestedParcels();
                        }
                        else
                        {
                            MessageBox.Show(
                                "Pickup verification failed.\n"
                                + "The parcel may already have been verified.",
                                "Pickup Verification",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Pickup verification failed.\n\n"
                    + ex.Message,
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