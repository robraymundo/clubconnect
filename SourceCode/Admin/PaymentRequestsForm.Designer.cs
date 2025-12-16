namespace ClubMembership.Admin
{
    partial class PaymentRequestsForm
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
            dgvRequests = new DataGridView();
            btnApprove = new Button();
            btnReject = new Button();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.AllowUserToAddRows = false;
            dgvRequests.AllowUserToDeleteRows = false;
            dgvRequests.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRequests.BackgroundColor = Color.Gainsboro;
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(14, 14);
            dgvRequests.MultiSelect = false;
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersVisible = false;
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(873, 450);
            dgvRequests.TabIndex = 0;
            // 
            // btnApprove
            // 
            btnApprove.Location = new Point(519, 473);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(181, 33);
            btnApprove.TabIndex = 1;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            btnApprove.Click += btnApprove_Click;
            // 
            // btnReject
            // 
            btnReject.Location = new Point(707, 473);
            btnReject.Name = "btnReject";
            btnReject.Size = new Size(181, 33);
            btnReject.TabIndex = 2;
            btnReject.Text = "Reject";
            btnReject.UseVisualStyleBackColor = true;
            btnReject.Click += btnReject_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(14, 473);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(181, 33);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PaymentRequestsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(btnBack);
            Controls.Add(btnReject);
            Controls.Add(btnApprove);
            Controls.Add(dgvRequests);
            Name = "PaymentRequestsForm";
            Text = "ClubConnect - Payment Requests";
            Load += PaymentRequestsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRequests;
        private Button btnApprove;
        private Button btnReject;
        private Button btnBack;
    }
}