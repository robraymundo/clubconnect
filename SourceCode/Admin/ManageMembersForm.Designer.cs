namespace ClubMembership.Admin
{
    partial class ManageMembersForm
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
            cmbStatus = new ComboBox();
            btnUpdate = new Button();
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
            dgvMembers.Location = new Point(14, 24);
            dgvMembers.MultiSelect = false;
            dgvMembers.Name = "dgvMembers";
            dgvMembers.ReadOnly = true;
            dgvMembers.RowHeadersVisible = false;
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(873, 428);
            dgvMembers.TabIndex = 0;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(647, 468);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(241, 31);
            cmbStatus.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(445, 468);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(196, 33);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 468);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(196, 33);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ManageMembersForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnBack);
            Controls.Add(btnUpdate);
            Controls.Add(cmbStatus);
            Controls.Add(dgvMembers);
            Name = "ManageMembersForm";
            Text = "ClubConnect - Manage Members";
            Load += ManageMembersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembers;
        private ComboBox cmbStatus;
        private Button btnUpdate;
        private Button btnBack;
    }
}