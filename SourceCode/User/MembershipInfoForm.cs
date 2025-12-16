using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubMembership.User
{
    public partial class MembershipInfoForm : BaseForm
    {
        public MembershipInfoForm()
        {
            InitializeComponent();
        }

        private void MembershipInfoForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                conn.Open();
                string query = @"SELECT m.membership_type, m.membership_fee
                         FROM Membership m
                         JOIN Club c ON m.Club_ID = c.Club_ID";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvMembership.DataSource = dt;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new UserDashboard().Show();
            this.Close();
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            new PaymentForm().Show();
            this.Close();
        }

    }
}
