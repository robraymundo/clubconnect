using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ClubMembership
{
    public partial class BaseForm : Form    
    {
        // --------------------------
        // Theme / Colors
        // --------------------------
        protected Color PrimaryColor = Color.FromArgb(33, 150, 243);
        protected Color ErrorColor = Color.Red;
        protected Color SuccessColor = Color.Green;
        protected Color WarningColor = Color.Orange;

        public BaseForm()
        {
            // --------------------------
            // General Form Settings
            // --------------------------
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.BackColor = Color.White;
            this.Font = new Font("Segoe UI", 10);
        }

        // --------------------------
        // Message Display
        // --------------------------
        protected void ShowError(Label lbl, string message)
        {
            if (lbl != null)
            {
                lbl.Text = message;
                lbl.ForeColor = ErrorColor;
            }
        }

        protected void ShowSuccess(Label lbl, string message)
        {
            if (lbl != null)
            {
                lbl.Text = message;
                lbl.ForeColor = SuccessColor;
            }
        }

        protected void ShowWarning(Label lbl, string message)
        {
            if (lbl != null)
            {
                lbl.Text = message;
                lbl.ForeColor = WarningColor;
            }
        }

        protected void ShowMessage(string message)
        {
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // --------------------------
        // Style DataGridView
        // --------------------------
        protected void StyleDataGridView(DataGridView dgv)
        {
            if (dgv == null) return;

            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
        }

        // --------------------------
        // Input Validation
        // --------------------------
        protected bool IsEmpty(TextBox txt)
        {
            return string.IsNullOrWhiteSpace(txt.Text);
        }

        protected bool IsNumeric(TextBox txt)
        {
            return double.TryParse(txt.Text.Trim(), out _);
        }

        // --------------------------
        // Navigation Helpers
        // --------------------------
        protected void OpenForm(Form form, bool modal = true)
        {
            if (modal) form.ShowDialog();
            else form.Show();
        }

        // --------------------------
        // Confirm on Close
        // --------------------------
        protected void ConfirmOnClose()
        {
            this.FormClosing += (s, e) =>
            {
                if (MessageBox.Show("Are you sure you want to exit?", "Confirm Exit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            };
        }

        // --------------------------
        // Logging
        // --------------------------
        protected void LogError(Exception ex)
        {
            try
            {
                File.AppendAllText("error.log", $"{DateTime.Now}: {ex.Message}{Environment.NewLine}");
            }
            catch
            {
                // Ignore logging errors
            }
        }

        // --------------------------
        // Execute MySQL Query Safely
        // --------------------------
        protected void ExecuteQuery(Action<MySqlConnection> action, Label lblError = null)
        {
            try
            {
                using (var conn = new MySqlConnection(DBHelper.ConnectionString))
                {
                    conn.Open();
                    action(conn);
                }
            }
            catch (Exception ex)
            {
                ShowError(lblError, ex.Message);
                LogError(ex);
            }
        }
    }
}
