using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubMembership.User
{
    public partial class UserDashboard : BaseForm
    {
        public UserDashboard()
        {
            InitializeComponent();
        }
        private void btnViewClubs_Click(object sender, EventArgs e)
        {
            new ClubListForm().Show();
            this.Hide();
        }

        private void btnMembershipInfo_Click(object sender, EventArgs e)
        {
            new MembershipInfoForm().Show();
            this.Hide();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
            this.Hide();
        }

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
