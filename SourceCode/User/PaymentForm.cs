using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Data;
using System.Windows.Forms;

namespace ClubMembership.User
{
    public partial class PaymentForm : BaseForm
    {
        private int _memberId;

        public PaymentForm()
        {
            InitializeComponent();
        }

        private void LoadCurrentMember()
        {
            using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
            {
                conn.Open();

                string selectQuery = @"
            SELECT Member_ID 
            FROM Member 
            WHERE email = @email
            LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Session.Username);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        _memberId = Convert.ToInt32(result);
                        return;
                    }
                }

                string insertQuery = @"
            INSERT INTO Member (first_name, last_name, email)
            VALUES ('User', 'Account', @email);
            SELECT LAST_INSERT_ID();";

                using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@email", Session.Username);
                    _memberId = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            LoadCurrentMember();
            LoadClubs(); 
            LoadMembershipTypes();

            cmbMembershipType.SelectedIndexChanged += (s, ev) => UpdateFee();
            UpdateFee();
        }

        private void LoadClubs()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
                {
                    conn.Open();
                    string query = "SELECT Club_ID, club_name FROM Club WHERE status='Active'";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        cmbClub.DisplayMember = "club_name";  
                        cmbClub.ValueMember = "Club_ID";    
                        cmbClub.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load clubs:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadMembershipTypes()
        {
            cmbMembershipType.Items.Clear();
            cmbMembershipType.Items.AddRange(new string[] { "Regular", "Premium", "VIP" });
            cmbMembershipType.SelectedIndex = 0;
        }

        private void UpdateFee()
        {
            switch (cmbMembershipType.SelectedItem.ToString())
            {
                case "Regular":
                    txtAmount.Text = "150.00";
                    break;
                case "Premium":
                    txtAmount.Text = "300.00";
                    break;
                case "VIP":
                    txtAmount.Text = "500.00";
                    break;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (cmbClub.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a club.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int clubID = Convert.ToInt32(cmbClub.SelectedValue);
            string membershipType = cmbMembershipType.SelectedItem.ToString();
            decimal amount = Convert.ToDecimal(txtAmount.Text.Trim());

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBHelper.ConnectionString))
                {
                    conn.Open();

                    int membershipID;

                    using (MySqlCommand cmd = new MySqlCommand(
                        @"INSERT INTO Membership (Member_ID, Club_ID, membership_status, membership_type, membership_fee)
                  VALUES (@mid, @cid, 'Active', @type, @fee); 
                  SELECT LAST_INSERT_ID();", conn))
                    {
                        cmd.Parameters.Add("@mid", MySqlDbType.Int32).Value = _memberId;
                        cmd.Parameters.Add("@cid", MySqlDbType.Int32).Value = clubID;
                        cmd.Parameters.Add("@type", MySqlDbType.VarChar).Value = membershipType;
                        cmd.Parameters.Add("@fee", MySqlDbType.Decimal).Value = amount;

                        membershipID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    using (MySqlCommand cmd2 = new MySqlCommand(
                        @"INSERT INTO Payment (Membership_ID, amount, payment_method, payment_status, remarks)
                  VALUES (@mid, @amount, 'Cash', 'Pending', @remarks)", conn))
                    {
                        cmd2.Parameters.Add("@mid", MySqlDbType.Int32).Value = membershipID;
                        cmd2.Parameters.Add("@amount", MySqlDbType.Decimal).Value = amount;
                        cmd2.Parameters.Add("@remarks", MySqlDbType.VarChar).Value = "Membership Payment";

                        cmd2.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"Membership '{membershipType}' for '{cmbClub.Text}' is now pending.\nAmount: ₱{amount:N2}",
                    "Payment Pending",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );



                new UserDashboard().Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error processing payment:\n" + ex.Message, "Payment Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            new UserDashboard().Show();
            this.Close();
        }
    }
}
