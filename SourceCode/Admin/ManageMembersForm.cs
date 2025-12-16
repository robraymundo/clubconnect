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
    public partial class ManageMembersForm : BaseForm
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            cmbStatus.Items.AddRange(new string[] { "Active", "Inactive", "Expired" });
            LoadMembers();
        }

        private void LoadMembers()
        {
            string query = @"
                SELECT m.Member_ID, CONCAT(m.first_name,' ',m.last_name) AS FullName, 
                       c.club_name, ms.membership_status 
                FROM Member m
                LEFT JOIN Membership ms ON m.Member_ID = ms.Member_ID
                LEFT JOIN Club c ON ms.Club_ID = c.Club_ID
            ";
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvMembers.CurrentRow == null || cmbStatus.SelectedItem == null) return;

            int memberId = Convert.ToInt32(dgvMembers.CurrentRow.Cells["Member_ID"].Value);
            string newStatus = cmbStatus.SelectedItem.ToString();

            string query = "UPDATE Membership SET membership_status=@status WHERE Member_ID=@id";
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@status", newStatus);
                cmd.Parameters.AddWithValue("@id", memberId);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Status updated!");
                LoadMembers();
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
