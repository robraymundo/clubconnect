namespace ClubMembership.User
{
    partial class UserDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDashboard));
            btnViewClubs = new Button();
            btnMembershipInfo = new Button();
            btnPayment = new Button();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnViewClubs
            // 
            btnViewClubs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnViewClubs.Location = new Point(335, 231);
            btnViewClubs.Name = "btnViewClubs";
            btnViewClubs.Size = new Size(233, 33);
            btnViewClubs.TabIndex = 0;
            btnViewClubs.Text = "View Clubs";
            btnViewClubs.UseVisualStyleBackColor = true;
            btnViewClubs.Click += btnViewClubs_Click;
            // 
            // btnMembershipInfo
            // 
            btnMembershipInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnMembershipInfo.Location = new Point(335, 289);
            btnMembershipInfo.Name = "btnMembershipInfo";
            btnMembershipInfo.Size = new Size(233, 33);
            btnMembershipInfo.TabIndex = 1;
            btnMembershipInfo.Text = "Membership Information";
            btnMembershipInfo.UseVisualStyleBackColor = true;
            btnMembershipInfo.Click += btnMembershipInfo_Click;
            // 
            // btnPayment
            // 
            btnPayment.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnPayment.Location = new Point(335, 344);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(233, 33);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            btnLogout.Location = new Point(335, 394);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(233, 33);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(pictureBox1);
            Controls.Add(btnLogout);
            Controls.Add(btnPayment);
            Controls.Add(btnMembershipInfo);
            Controls.Add(btnViewClubs);
            Name = "UserDashboard";
            Text = "ClubConnect - Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewClubs;
        private Button btnMembershipInfo;
        private Button btnPayment;
        private Button btnLogout;
        private PictureBox pictureBox1;
    }
}