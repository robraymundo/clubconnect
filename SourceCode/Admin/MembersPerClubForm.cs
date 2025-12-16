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
    public partial class MembersPerClubForm : BaseForm
    {
        public MembersPerClubForm()
        {
            InitializeComponent();
        }

        public int ClubID;

        private void MembersPerClubForm_Load(object sender, EventArgs e)
        {
            lblClubName.Text = $"Members of Club ID: {ClubID}";
            LoadMembers();
        }

        private void LoadMembers()
        {
            string query = @"
                SELECT m.Member_ID, CONCAT(m.first_name,' ',m.last_name) AS FullName, ms.membership_status, ms.membership_type
                FROM Membership ms
                JOIN Member m ON ms.Member_ID = m.Member_ID
                WHERE ms.Club_ID=@id
            ";

            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", ClubID);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvMembers.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
