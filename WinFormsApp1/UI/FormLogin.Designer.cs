namespace WinFormsApp1
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel3 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtUserId = new TextBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            cbPassword = new CheckBox();
            btnLogin = new Button();
            label3 = new Label();
            label2 = new Label();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(panel2);
            panel3.ForeColor = Color.Black;
            panel3.Location = new Point(-8, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(344, 469);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(341, 401);
            panel2.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Jokerman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(-10, 227);
            label4.Name = "label4";
            label4.Size = new Size(341, 99);
            label4.TabIndex = 1;
            label4.Text = "          SHOP BILLING \r\n                  AND \r\n    MANAGEMENT SYSTEM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(58, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bernard MT Condensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(116, 15);
            label1.Name = "label1";
            label1.Size = new Size(108, 40);
            label1.TabIndex = 2;
            label1.Text = "SING IN";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(11, 171);
            txtUserId.Name = "txtUserId";
            txtUserId.Size = new Size(284, 27);
            txtUserId.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(11, 265);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(284, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(cbPassword);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtUserId);
            panel1.Location = new Point(393, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 404);
            panel1.TabIndex = 5;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Font = new Font("Lucida Bright", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPassword.Location = new Point(20, 298);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(129, 19);
            cbPassword.TabIndex = 8;
            cbPassword.Text = "Show Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DarkSeaGreen;
            btnLogin.Font = new Font("Bernard MT Condensed", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.ButtonFace;
            btnLogin.Location = new Point(69, 330);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 50);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += BtnLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 218);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 6;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(11, 120);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 5;
            label2.Text = "User ID :";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label1;
        private TextBox txtUserId;
        private TextBox txtPassword;
        private Panel panel1;
        private Button btnLogin;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private CheckBox cbPassword;
    }
}
