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
    public partial class ClubListForm : BaseForm
    {
        public ClubListForm()
        {
            InitializeComponent();
        }

        private void ClubListForm_Load(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Club";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvClubs.DataSource = dt;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new UserDashboard().Show();
            this.Close();
        }

    }
}
