using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcelManagement
{
    public partial class UserDashboard : Form
    {
        private string userEmail;

        public UserDashboard(string email)
        {
            InitializeComponent();

            userEmail = email;

            // My Profile button
            button1.Click += button1_Click;

            // My Parcel button
            button2.Click += button2_Click;

            // Collection History button
            button3.Click += button3_Click;

            // Tracking button
            button4.Click += button4_Click;

            // Collection Request button
            button5.Click += button5_Click;

            // Logout button
            button7.Click += button7_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyProfile myProfile =
                new MyProfile(userEmail);

            myProfile.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmParcelSearchAndFiltering parcelSearch =
                new FrmParcelSearchAndFiltering(userEmail);

            parcelSearch.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmCollectionStatusHistory history =
                new FrmCollectionStatusHistory(userEmail);

            history.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmParcelTracking parcelTracking =
                new FrmParcelTracking(userEmail);

            parcelTracking.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmCollectionRequest collectionRequest =
                new FrmCollectionRequest(userEmail);

            collectionRequest.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginPortal loginPortal =
                new LoginPortal();

            loginPortal.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void btnRecipients_Click(object sender, EventArgs e)
        {
        }
    }
}