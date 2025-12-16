namespace ClubMembership.Admin
{
    partial class CreateClubForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateClubForm));
            btnCancel = new Button();
            btnSave = new Button();
            txtClubName = new TextBox();
            lblClubName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(359, 425);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(180, 33);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(359, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(180, 33);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtClubName
            // 
            txtClubName.Location = new Point(327, 264);
            txtClubName.Name = "txtClubName";
            txtClubName.Size = new Size(250, 30);
            txtClubName.TabIndex = 7;
            // 
            // lblClubName
            // 
            lblClubName.AutoSize = true;
            lblClubName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClubName.Location = new Point(327, 226);
            lblClubName.Name = "lblClubName";
            lblClubName.Size = new Size(104, 23);
            lblClubName.TabIndex = 6;
            lblClubName.Text = "Club Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(359, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 143);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // CreateClubForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(pictureBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtClubName);
            Controls.Add(lblClubName);
            Name = "CreateClubForm";
            Text = "ClubConnect - Create Club";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnSave;
        private TextBox txtClubName;
        private Label lblClubName;
        private PictureBox pictureBox1;
    }
}