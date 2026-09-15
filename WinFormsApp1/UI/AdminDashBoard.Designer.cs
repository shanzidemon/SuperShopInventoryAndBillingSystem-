namespace ShopBillingSystem.UI
{
    partial class AdminDashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashBoard));
            panel1 = new Panel();
            panel3 = new Panel();
            dptToday = new DateTimePicker();
            panel7 = new Panel();
            label5 = new Label();
            lblTodyIncome = new Label();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            label4 = new Label();
            lblEmployee = new Label();
            pictureBox1 = new PictureBox();
            panel9 = new Panel();
            lblManagar = new Label();
            lblManager = new Label();
            pictureBox2 = new PictureBox();
            panel6 = new Panel();
            label6 = new Label();
            lblTotalIncome = new Label();
            pictureBox4 = new PictureBox();
            panel2 = new Panel();
            pictureBox5 = new PictureBox();
            panel1.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(dptToday);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel6);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 180);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.Location = new Point(1217, 19);
            panel3.Name = "panel3";
            panel3.Size = new Size(17, 39);
            panel3.TabIndex = 4;
            // 
            // dptToday
            // 
            dptToday.CalendarMonthBackground = Color.DarkSeaGreen;
            dptToday.CustomFormat = "dd/MM/yyyy";
            dptToday.Location = new Point(1224, 19);
            dptToday.Name = "dptToday";
            dptToday.Size = new Size(10, 27);
            dptToday.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.DarkSeaGreen;
            panel7.Controls.Add(label5);
            panel7.Controls.Add(lblTodyIncome);
            panel7.Controls.Add(pictureBox3);
            panel7.Location = new Point(646, 16);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 148);
            panel7.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(99, 0);
            label5.Name = "label5";
            label5.Size = new Size(157, 28);
            label5.TabIndex = 5;
            label5.Text = "Today's Income";
            // 
            // lblTodyIncome
            // 
            lblTodyIncome.AutoSize = true;
            lblTodyIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTodyIncome.Location = new Point(3, 103);
            lblTodyIncome.Name = "lblTodyIncome";
            lblTodyIncome.Size = new Size(48, 28);
            lblTodyIncome.TabIndex = 4;
            lblTodyIncome.Text = "$00";
            lblTodyIncome.Click += lblTodyIncome_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(90, 90);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // panel8
            // 
            panel8.BackColor = Color.DarkSeaGreen;
            panel8.Controls.Add(label4);
            panel8.Controls.Add(lblEmployee);
            panel8.Controls.Add(pictureBox1);
            panel8.Location = new Point(345, 16);
            panel8.Name = "panel8";
            panel8.Size = new Size(254, 148);
            panel8.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(94, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 28);
            label4.TabIndex = 5;
            label4.Text = "Total Employee";
            // 
            // lblEmployee
            // 
            lblEmployee.AutoSize = true;
            lblEmployee.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployee.Location = new Point(3, 103);
            lblEmployee.Name = "lblEmployee";
            lblEmployee.Size = new Size(36, 28);
            lblEmployee.TabIndex = 4;
            lblEmployee.Text = "00";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel9
            // 
            panel9.BackColor = Color.DarkSeaGreen;
            panel9.Controls.Add(lblManagar);
            panel9.Controls.Add(lblManager);
            panel9.Controls.Add(pictureBox2);
            panel9.Location = new Point(28, 16);
            panel9.Name = "panel9";
            panel9.Size = new Size(246, 148);
            panel9.TabIndex = 1;
            // 
            // lblManagar
            // 
            lblManagar.AutoSize = true;
            lblManagar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManagar.Location = new Point(-2, 103);
            lblManagar.Name = "lblManagar";
            lblManagar.Size = new Size(36, 28);
            lblManagar.TabIndex = 3;
            lblManagar.Text = "00";
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblManager.Location = new Point(94, 0);
            lblManager.Name = "lblManager";
            lblManager.Size = new Size(127, 28);
            lblManager.TabIndex = 2;
            lblManager.Text = "Total Admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(90, 90);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DarkSeaGreen;
            panel6.Controls.Add(label6);
            panel6.Controls.Add(lblTotalIncome);
            panel6.Controls.Add(pictureBox4);
            panel6.Location = new Point(946, 16);
            panel6.Name = "panel6";
            panel6.Size = new Size(255, 148);
            panel6.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(108, 0);
            label6.Name = "label6";
            label6.Size = new Size(134, 28);
            label6.TabIndex = 6;
            label6.Text = "Total Income";
            // 
            // lblTotalIncome
            // 
            lblTotalIncome.AutoSize = true;
            lblTotalIncome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalIncome.Location = new Point(3, 103);
            lblTotalIncome.Name = "lblTotalIncome";
            lblTotalIncome.Size = new Size(48, 28);
            lblTotalIncome.TabIndex = 4;
            lblTotalIncome.Text = "$00";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(3, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(90, 90);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(31, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(1173, 541);
            panel2.TabIndex = 1;
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Fill;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(1173, 541);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // AdminDashBoard
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminDashBoard";
            Size = new Size(1256, 730);
            Load += AdminDashBoard_Load;
            panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private Panel panel6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Label lblManagar;
        private Label lblManager;
        private Label lblTodyIncome;
        private Label label4;
        private Label lblEmployee;
        private Label lblTotalIncome;
        private Label label5;
        private Label label6;
        private DateTimePicker dptToday;
        private PictureBox pictureBox5;
        private Panel panel3;
    }
}
