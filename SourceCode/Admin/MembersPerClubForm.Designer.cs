namespace ClubMembership.Admin
{
    partial class MembersPerClubForm
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
            dgvMembers = new DataGridView();
            lblClubName = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.AllowUserToAddRows = false;
            dgvMembers.AllowUserToDeleteRows = false;
            dgvMembers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembers.BackgroundColor = Color.Gainsboro;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(14, 69);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(873, 394);
            dgvMembers.TabIndex = 0;
            // 
            // lblClubName
            // 
            lblClubName.AutoSize = true;
            lblClubName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClubName.Location = new Point(14, 29);
            lblClubName.Name = "lblClubName";
            lblClubName.Size = new Size(116, 28);
            lblClubName.TabIndex = 1;
            lblClubName.Text = "Club Name";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(718, 476);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(169, 33);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MembersPerClubForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnBack);
            Controls.Add(lblClubName);
            Controls.Add(dgvMembers);
            Name = "MembersPerClubForm";
            Text = "ClubConnect - Members Per Club";
            Load += MembersPerClubForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMembers;
        private Label lblClubName;
        private Button btnBack;
    }
}