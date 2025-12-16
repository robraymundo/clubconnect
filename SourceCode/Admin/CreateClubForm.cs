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
    public partial class CreateClubForm : BaseForm
    {
        public CreateClubForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtClubName.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter club name!");
                return;
            }

            string query = "INSERT INTO Club (club_name) VALUES (@name)";
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@name", name);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Club added!");
                txtClubName.Clear();
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
