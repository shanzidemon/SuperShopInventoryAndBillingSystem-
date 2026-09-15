namespace ShopBillingSystem.UI
{
    partial class EmployeeProfile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            lblPasswordChangeTitle = new Label();
            lblUserNameValue = new Label();
            lblUserNameLabel = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            btnConfirm = new Button();
            txtConfirmPassword = new TextBox();
            lblConfirmPassword = new Label();
            lblUserProfileTitle = new Label();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            txtCurrentPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_2200128716_1024x1024;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(289, 189);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.istockphoto_2200128716_1024x1024;
            pictureBox2.Location = new Point(0, 187);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 550);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.istockphoto_2200128716_1024x1024;
            pictureBox3.Location = new Point(1009, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(219, 189);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(txtCurrentPassword);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblPasswordChangeTitle);
            panel1.Controls.Add(lblUserNameValue);
            panel1.Controls.Add(lblUserNameLabel);
            panel1.Controls.Add(txtNewPassword);
            panel1.Controls.Add(lblNewPassword);
            panel1.Controls.Add(btnConfirm);
            panel1.Controls.Add(txtConfirmPassword);
            panel1.Controls.Add(lblConfirmPassword);
            panel1.Controls.Add(lblUserProfileTitle);
            panel1.Location = new Point(286, -12);
            panel1.Name = "panel1";
            panel1.Size = new Size(724, 749);
            panel1.TabIndex = 4;
            // 
            // lblPasswordChangeTitle
            // 
            lblPasswordChangeTitle.AutoSize = true;
            lblPasswordChangeTitle.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPasswordChangeTitle.Location = new Point(31, 182);
            lblPasswordChangeTitle.Name = "lblPasswordChangeTitle";
            lblPasswordChangeTitle.Size = new Size(312, 50);
            lblPasswordChangeTitle.TabIndex = 13;
            lblPasswordChangeTitle.Text = "Password Change";
            // 
            // lblUserNameValue
            // 
            lblUserNameValue.AutoSize = true;
            lblUserNameValue.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserNameValue.Location = new Point(276, 277);
            lblUserNameValue.Name = "lblUserNameValue";
            lblUserNameValue.Size = new Size(127, 31);
            lblUserNameValue.TabIndex = 12;
            lblUserNameValue.Text = "User Name";
            // 
            // lblUserNameLabel
            // 
            lblUserNameLabel.AutoSize = true;
            lblUserNameLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserNameLabel.Location = new Point(31, 277);
            lblUserNameLabel.Name = "lblUserNameLabel";
            lblUserNameLabel.Size = new Size(132, 31);
            lblUserNameLabel.TabIndex = 11;
            lblUserNameLabel.Text = "User Name:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(276, 401);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(221, 38);
            txtNewPassword.TabIndex = 10;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNewPassword.Location = new Point(31, 401);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(167, 31);
            lblNewPassword.TabIndex = 9;
            lblNewPassword.Text = "New Password:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SeaGreen;
            btnConfirm.Location = new Point(276, 605);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(176, 72);
            btnConfirm.TabIndex = 7;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(276, 474);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(221, 38);
            txtConfirmPassword.TabIndex = 6;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPassword.Location = new Point(31, 468);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(202, 31);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password:";
            // 
            // lblUserProfileTitle
            // 
            lblUserProfileTitle.AutoSize = true;
            lblUserProfileTitle.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserProfileTitle.Location = new Point(195, 12);
            lblUserProfileTitle.Name = "lblUserProfileTitle";
            lblUserProfileTitle.Size = new Size(339, 81);
            lblUserProfileTitle.TabIndex = 0;
            lblUserProfileTitle.Text = "User Profile";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.istockphoto_2200128716_1024x1024;
            pictureBox4.Location = new Point(1009, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(219, 550);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 336);
            label1.Name = "label1";
            label1.Size = new Size(197, 31);
            label1.TabIndex = 14;
            label1.Text = "Current Password:";
            // 
            // txtCurrentPassword
            // 
            txtCurrentPassword.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCurrentPassword.Location = new Point(276, 333);
            txtCurrentPassword.Name = "txtCurrentPassword";
            txtCurrentPassword.Size = new Size(221, 38);
            txtCurrentPassword.TabIndex = 15;
            txtCurrentPassword.UseSystemPasswordChar = true;
            // 
            // EmployeeProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox4);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "EmployeeProfile";
            Size = new Size(1228, 737);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Label lblConfirmPassword;
        private Label lblUserProfileTitle;
        private PictureBox pictureBox4;
        private Button btnConfirm;
        private TextBox txtConfirmPassword;
        private Label lblPasswordChangeTitle;
        private Label lblUserNameValue;
        private Label lblUserNameLabel;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtCurrentPassword;
        private Label label1;
    }
}
