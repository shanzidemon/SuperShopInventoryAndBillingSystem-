namespace ShopBillingSystem.UI
{
    partial class FormEmployee
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            panel3 = new Panel();
            label16 = new Label();
            panel2 = new Panel();
            pnlBtn = new Panel();
            btnDashBoard = new Button();
            btnAddEmoloyee = new Button();
            btnAddProduct = new Button();
            btnLogout = new Button();
            btnDashBord = new Button();
            lblUserName = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlMain = new Panel();
            employeeDashboard1 = new EmployeeDashboard();
            employeeSales1 = new EmployeeSales();
            employeeProfile1 = new EmployeeProfile();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkSeaGreen;
            panel3.Controls.Add(label16);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(251, 0);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1236, 36);
            panel3.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.DarkSeaGreen;
            label16.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = SystemColors.ActiveCaptionText;
            label16.Location = new Point(2, 0);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(512, 27);
            label16.TabIndex = 2;
            label16.Text = "SHOP BILLING AND  MANAGEMENT SYSTEM";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(pnlBtn);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnDashBord);
            panel2.Controls.Add(lblUserName);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 778);
            panel2.TabIndex = 7;
            // 
            // pnlBtn
            // 
            pnlBtn.Controls.Add(btnDashBoard);
            pnlBtn.Controls.Add(btnAddEmoloyee);
            pnlBtn.Controls.Add(btnAddProduct);
            pnlBtn.Location = new Point(47, 244);
            pnlBtn.Name = "pnlBtn";
            pnlBtn.Size = new Size(159, 423);
            pnlBtn.TabIndex = 15;
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = Color.LightGoldenrodYellow;
            btnDashBoard.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashBoard.ForeColor = SystemColors.ActiveCaptionText;
            btnDashBoard.Location = new Point(24, 29);
            btnDashBoard.Margin = new Padding(2, 1, 2, 1);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new Size(114, 56);
            btnDashBoard.TabIndex = 12;
            btnDashBoard.Text = "Dash Board";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += btnDashBoard_Click;
            // 
            // btnAddEmoloyee
            // 
            btnAddEmoloyee.BackColor = Color.LightGoldenrodYellow;
            btnAddEmoloyee.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddEmoloyee.ForeColor = SystemColors.ActiveCaptionText;
            btnAddEmoloyee.Location = new Point(24, 191);
            btnAddEmoloyee.Margin = new Padding(2, 1, 2, 1);
            btnAddEmoloyee.Name = "btnAddEmoloyee";
            btnAddEmoloyee.Size = new Size(114, 56);
            btnAddEmoloyee.TabIndex = 8;
            btnAddEmoloyee.Text = "My Profile";
            btnAddEmoloyee.UseVisualStyleBackColor = false;
            btnAddEmoloyee.Click += btnAddEmoloyee_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = Color.LightGoldenrodYellow;
            btnAddProduct.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = SystemColors.ActiveCaptionText;
            btnAddProduct.Location = new Point(24, 110);
            btnAddProduct.Margin = new Padding(2, 1, 2, 1);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(114, 56);
            btnAddProduct.TabIndex = 11;
            btnAddProduct.Text = "New Sales";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.OldLace;
            btnLogout.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.Red;
            btnLogout.Location = new Point(71, 692);
            btnLogout.Margin = new Padding(2, 1, 2, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(114, 39);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnDashBord
            // 
            btnDashBord.BackColor = Color.LightYellow;
            btnDashBord.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDashBord.ForeColor = SystemColors.ActiveCaptionText;
            btnDashBord.Location = new Point(14, 229);
            btnDashBord.Margin = new Padding(2, 1, 2, 1);
            btnDashBord.Name = "btnDashBord";
            btnDashBord.Size = new Size(0, 0);
            btnDashBord.TabIndex = 7;
            btnDashBord.Text = "Dash Bord";
            btnDashBord.UseVisualStyleBackColor = false;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.BackColor = Color.DarkSeaGreen;
            lblUserName.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.ForeColor = SystemColors.ActiveCaptionText;
            lblUserName.Location = new Point(20, 209);
            lblUserName.Margin = new Padding(2, 0, 2, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(106, 20);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "Username : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkSeaGreen;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(73, 181);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DarkSeaGreen;
            label1.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(20, 175);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(212, 27);
            label1.TabIndex = 3;
            label1.Text = "Employee's Portal";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 4);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(employeeDashboard1);
            pnlMain.Controls.Add(employeeSales1);
            pnlMain.Controls.Add(employeeProfile1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(251, 36);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1236, 742);
            pnlMain.TabIndex = 8;
            // 
            // employeeDashboard1
            // 
            employeeDashboard1.BackColor = Color.FromArgb(245, 246, 250);
            employeeDashboard1.Dock = DockStyle.Fill;
            employeeDashboard1.Location = new Point(0, 0);
            employeeDashboard1.Margin = new Padding(0);
            employeeDashboard1.Name = "employeeDashboard1";
            employeeDashboard1.Size = new Size(1236, 742);
            employeeDashboard1.TabIndex = 0;
            employeeDashboard1.Load += employeeDashboard1_Load;
            // 
            // employeeSales1
            // 
            employeeSales1.Dock = DockStyle.Fill;
            employeeSales1.Location = new Point(0, 0);
            employeeSales1.Margin = new Padding(0);
            employeeSales1.Name = "employeeSales1";
            employeeSales1.Size = new Size(1236, 742);
            employeeSales1.TabIndex = 1;
            employeeSales1.Visible = false;
            // 
            // employeeProfile1
            // 
            employeeProfile1.BackColor = Color.White;
            employeeProfile1.Dock = DockStyle.Fill;
            employeeProfile1.Location = new Point(0, 0);
            employeeProfile1.Margin = new Padding(0);
            employeeProfile1.Name = "employeeProfile1";
            employeeProfile1.Size = new Size(1236, 742);
            employeeProfile1.TabIndex = 2;
            employeeProfile1.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // FormEmployee
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1487, 778);
            Controls.Add(pnlMain);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "     User : Employee";
            FormClosed += FormEmployee_FormClosed;
            Load += FormEmployee_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label16;
        private Panel panel2;
        private Panel pnlBtn;
        private Button btnDashBoard;
        private Button btnAddProduct;
        private Button btnAddEmoloyee;
        private Button btnLogout;
        private Button btnDashBord;
        private Label lblUserName;
        private Label label3;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel pnlMain;
        private EmployeeDashboard employeeDashboard1;
        private EmployeeSales employeeSales1;
        private EmployeeProfile employeeProfile1;
        private ContextMenuStrip contextMenuStrip1;
    }
}