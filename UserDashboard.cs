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

            // My Profile button click event
            button1.Click += button1_Click;

            // Logout button click event
            button7.Click += button7_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyProfile myProfile = new MyProfile(userEmail);
            myProfile.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LoginPortal loginPortal = new LoginPortal();
            loginPortal.Show();

            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnRecipients_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}