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
    public partial class AdminClubListForm : BaseForm
    {
        public AdminClubListForm()
        {
            InitializeComponent();
        }

        public int ClubID;

        private void AdminClubListForm_Load(object sender, EventArgs e)
        {
            LoadClubs();
        }

        private void LoadClubs()
        {
            string query = "SELECT Club_ID, club_name, status FROM Club";
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClubs.DataSource = dt;
            }
        }

        private void btnViewMembers_Click(object sender, EventArgs e)
        {
            if (dgvClubs.CurrentRow == null) return;

            int clubId = Convert.ToInt32(dgvClubs.CurrentRow.Cells["Club_ID"].Value);
            MembersPerClubForm form = new MembersPerClubForm();
            form.ClubID = clubId;
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e) => this.Close();
    }
}
