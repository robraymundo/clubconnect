namespace ClubMembership.User
{
    partial class MembershipInfoForm
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
            dgvMembership = new DataGridView();
            btnBack = new Button();
            btnPayment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMembership).BeginInit();
            SuspendLayout();
            // 
            // dgvMembership
            // 
            dgvMembership.AllowUserToAddRows = false;
            dgvMembership.AllowUserToDeleteRows = false;
            dgvMembership.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMembership.BackgroundColor = Color.Gainsboro;
            dgvMembership.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembership.Location = new Point(14, 24);
            dgvMembership.MultiSelect = false;
            dgvMembership.Name = "dgvMembership";
            dgvMembership.ReadOnly = true;
            dgvMembership.RowHeadersVisible = false;
            dgvMembership.RowHeadersWidth = 51;
            dgvMembership.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembership.Size = new Size(873, 426);
            dgvMembership.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(252, 470);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 33);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(459, 470);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(200, 33);
            btnPayment.TabIndex = 2;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // MembershipInfoForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnPayment);
            Controls.Add(btnBack);
            Controls.Add(dgvMembership);
            Name = "MembershipInfoForm";
            Text = "ClubConnect - Membership Information";
            Load += MembershipInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembership).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvMembership;
        private Button btnBack;
        private Button btnPayment;
    }
}