namespace ClubMembership.User
{
    partial class AdminDashboard
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
            btnCreateClub = new Button();
            btnManageMembers = new Button();
            btnClubList = new Button();
            btnLogout = new Button();
            btnPaymentRequests = new Button();
            lblWelcome = new Label();
            SuspendLayout();
            // 
            // btnCreateClub
            // 
            btnCreateClub.Location = new Point(315, 158);
            btnCreateClub.Name = "btnCreateClub";
            btnCreateClub.Size = new Size(264, 33);
            btnCreateClub.TabIndex = 0;
            btnCreateClub.Text = "Create Club";
            btnCreateClub.UseVisualStyleBackColor = true;
            btnCreateClub.Click += btnCreateClub_Click;
            // 
            // btnManageMembers
            // 
            btnManageMembers.Location = new Point(315, 212);
            btnManageMembers.Name = "btnManageMembers";
            btnManageMembers.Size = new Size(264, 33);
            btnManageMembers.TabIndex = 1;
            btnManageMembers.Text = "Manage Members";
            btnManageMembers.UseVisualStyleBackColor = true;
            btnManageMembers.Click += btnManageMembers_Click;
            // 
            // btnClubList
            // 
            btnClubList.Location = new Point(315, 265);
            btnClubList.Name = "btnClubList";
            btnClubList.Size = new Size(264, 33);
            btnClubList.TabIndex = 2;
            btnClubList.Text = "Manage Clubs";
            btnClubList.UseVisualStyleBackColor = true;
            btnClubList.Click += btnClubList_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(315, 422);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(264, 33);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnPaymentRequests
            // 
            btnPaymentRequests.Location = new Point(315, 314);
            btnPaymentRequests.Name = "btnPaymentRequests";
            btnPaymentRequests.Size = new Size(264, 33);
            btnPaymentRequests.TabIndex = 4;
            btnPaymentRequests.Text = "Payments Requests";
            btnPaymentRequests.UseVisualStyleBackColor = true;
            btnPaymentRequests.Click += btnPaymentRequests_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(336, 70);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(197, 31);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "Welcome, Admin";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(lblWelcome);
            Controls.Add(btnLogout);
            Controls.Add(btnPaymentRequests);
            Controls.Add(btnClubList);
            Controls.Add(btnManageMembers);
            Controls.Add(btnCreateClub);
            Name = "AdminDashboard";
            Text = "ClubConnect - Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateClub;
        private Button btnManageMembers;
        private Button btnClubList;
        private Button btnLogout;
        private Button btnPaymentRequests;
        private Button btnMembersPerClub;
        private Label lblWelcome;
    }
}