using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ClubMembership.Admin
{
    public partial class PaymentRequestsForm : BaseForm
    {
        public PaymentRequestsForm()
        {
            InitializeComponent();
        }

        private void PaymentRequestsForm_Load(object sender, EventArgs e) => LoadRequests();

        private void LoadRequests()
        {
            string query = @"
                SELECT p.Payment_ID, m.Member_ID, CONCAT(m.first_name,' ',m.last_name) AS MemberName,
                       ms.Membership_ID, p.amount, p.payment_status, p.payment_method
                FROM Payment p
                JOIN Membership ms ON p.Membership_ID = ms.Membership_ID
                JOIN Member m ON ms.Member_ID = m.Member_ID
                WHERE p.payment_status='Pending'
            ";

            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRequests.DataSource = dt;
            }
        }

        private void btnApprove_Click(object sender, EventArgs e) => UpdatePaymentStatus("Paid");
        private void btnReject_Click(object sender, EventArgs e) => UpdatePaymentStatus("Failed");

        private void UpdatePaymentStatus(string status)
        {
            if (dgvRequests.CurrentRow == null) return;

            int paymentId = Convert.ToInt32(dgvRequests.CurrentRow.Cells["Payment_ID"].Value);

            string query = "UPDATE Payment SET payment_status=@status WHERE Payment_ID=@id";
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", paymentId);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show($"Payment {status}!");
                LoadRequests();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
