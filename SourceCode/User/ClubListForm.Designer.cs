namespace ClubMembership.User
{
    partial class ClubListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvClubs = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClubs).BeginInit();
            SuspendLayout();
            // 
            // dgvClubs
            // 
            dgvClubs.AllowUserToAddRows = false;
            dgvClubs.AllowUserToDeleteRows = false;
            dgvClubs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClubs.BackgroundColor = Color.Gainsboro;
            dgvClubs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClubs.Location = new Point(15, 22);
            dgvClubs.MultiSelect = false;
            dgvClubs.Name = "dgvClubs";
            dgvClubs.ReadOnly = true;
            dgvClubs.RowHeadersVisible = false;
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClubs.Size = new Size(873, 423);
            dgvClubs.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(349, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(207, 33);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ClubListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnBack);
            Controls.Add(dgvClubs);
            Name = "ClubListForm";
            Text = "ClubConnect - Club List";
            Load += ClubListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClubs;
        private Button btnBack;
    }
}