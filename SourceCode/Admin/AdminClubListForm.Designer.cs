namespace ClubMembership.Admin
{
    partial class AdminClubListForm
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
            btnViewMembers = new Button();
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
            dgvClubs.Location = new Point(14, 14);
            dgvClubs.MultiSelect = false;
            dgvClubs.Name = "dgvClubs";
            dgvClubs.ReadOnly = true;
            dgvClubs.RowHeadersVisible = false;
            dgvClubs.RowHeadersWidth = 51;
            dgvClubs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClubs.Size = new Size(873, 450);
            dgvClubs.TabIndex = 0;
            // 
            // btnViewMembers
            // 
            btnViewMembers.Location = new Point(465, 473);
            btnViewMembers.Name = "btnViewMembers";
            btnViewMembers.Size = new Size(198, 33);
            btnViewMembers.TabIndex = 1;
            btnViewMembers.Text = "View Members";
            btnViewMembers.UseVisualStyleBackColor = true;
            btnViewMembers.Click += btnViewMembers_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(261, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(198, 33);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // AdminClubListForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnBack);
            Controls.Add(btnViewMembers);
            Controls.Add(dgvClubs);
            Name = "AdminClubListForm";
            Text = "ClubConnect - Club List";
            Load += AdminClubListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClubs).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvClubs;
        private Button btnViewMembers;
        private Button btnBack;
    }
}