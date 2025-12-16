namespace ClubMembership.User
{
    partial class PaymentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            cmbClub = new ComboBox();
            cmbPaymentMethod = new ComboBox();
            btnConfirm = new Button();
            btnBack = new Button();
            label1 = new Label();
            label3 = new Label();
            cmbMembershipType = new ComboBox();
            label2 = new Label();
            txtAmount = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cmbClub
            // 
            cmbClub.FormattingEnabled = true;
            cmbClub.Location = new Point(240, 245);
            cmbClub.Name = "cmbClub";
            cmbClub.Size = new Size(193, 31);
            cmbClub.TabIndex = 0;
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Online" });
            cmbPaymentMethod.Location = new Point(240, 349);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(196, 31);
            cmbPaymentMethod.TabIndex = 2;
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(453, 446);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(207, 33);
            btnConfirm.TabIndex = 3;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnPay_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(240, 446);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(207, 33);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnCancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 219);
            label1.Name = "label1";
            label1.Size = new Size(95, 23);
            label1.TabIndex = 5;
            label1.Text = "Select Club";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(240, 323);
            label3.Name = "label3";
            label3.Size = new Size(141, 23);
            label3.TabIndex = 8;
            label3.Text = "Payment Method";
            // 
            // cmbMembershipType
            // 
            cmbMembershipType.FormattingEnabled = true;
            cmbMembershipType.Location = new Point(464, 245);
            cmbMembershipType.Name = "cmbMembershipType";
            cmbMembershipType.Size = new Size(196, 31);
            cmbMembershipType.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 219);
            label2.Name = "label2";
            label2.Size = new Size(145, 23);
            label2.TabIndex = 7;
            label2.Text = "Membership Type";
            // 
            // txtAmount
            // 
            txtAmount.AutoSize = true;
            txtAmount.Location = new Point(240, 395);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(117, 23);
            txtAmount.TabIndex = 9;
            txtAmount.Text = "Total Amount:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(365, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(pictureBox1);
            Controls.Add(txtAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbMembershipType);
            Controls.Add(label1);
            Controls.Add(btnBack);
            Controls.Add(btnConfirm);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(cmbClub);
            Name = "PaymentForm";
            Text = "ClubConnect - Payment";
            Load += PaymentForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbMembership;
        private ComboBox cmbPaymentMethod;
        private Button btnConfirm;
        private Button btnBack;
        private Label label1;
        private Label label3;
        private ComboBox cmbMembershipType;
        private Label label2;
        private Label txtAmount;
        private ComboBox cmbClub;
        private PictureBox pictureBox1;
    }
}