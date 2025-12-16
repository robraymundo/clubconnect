using ClubMembership.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubMembership.User
{
    public partial class AdminDashboard : BaseForm
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        //private void AdminDashboardForm_Load(object sender, EventArgs e)
        //{
        //    lblWelcome.Text = $"Welcome, {CurrentUser.Username} (Admin)";
        //}

        private void btnCreateClub_Click(object sender, EventArgs e) => new CreateClubForm().ShowDialog();
        private void btnManageMembers_Click(object sender, EventArgs e) => new ManageMembersForm().ShowDialog();
        private void btnClubList_Click(object sender, EventArgs e) => new AdminClubListForm().ShowDialog();
        private void btnPaymentRequests_Click(object sender, EventArgs e) => new PaymentRequestsForm().ShowDialog();
        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().Show();
            }
        }
    }
}
