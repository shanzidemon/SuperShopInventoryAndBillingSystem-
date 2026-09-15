namespace ShopBillingSystem.UI
{
    partial class FormAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            panel1 = new Panel();
            label4 = new Label();
            panel2 = new Panel();
            pnlBtn = new Panel();
            btnSalesHistory = new Button();
            btnDashBoard = new Button();
            btnAddCategory = new Button();
            btnAddEmoloyee = new Button();
            btnAddProduct = new Button();
            btnLogout = new Button();
            btnDashBord = new Button();
            lblUserName = new Label();
            label3 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlMain = new Panel();
            salesHistory1 = new SalesHistory();
            adminDashBoard1 = new AdminDashBoard();
            adminAddProducts1 = new AdminAddProducts(UserId);
            adminAddCategory1 = new AdminAddCategory();
            adminAddEmpolyee1 = new AdminAddEmpolyee();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            pnlBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMain.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1487, 36);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.DarkSeaGreen;
            label4.Font = new Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(7, 5);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(512, 27);
            label4.TabIndex = 2;
            label4.Text = "SHOP BILLING AND  MANAGEMENT SYSTEM";
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
            panel2.Location = new Point(0, 36);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(251, 742);
            panel2.TabIndex = 1;
            // 
            // pnlBtn
            // 
            pnlBtn.Controls.Add(btnSalesHistory);
            pnlBtn.Controls.Add(btnDashBoard);
            pnlBtn.Controls.Add(btnAddCategory);
            pnlBtn.Controls.Add(btnAddEmoloyee);
            pnlBtn.Controls.Add(btnAddProduct);
            pnlBtn.Location = new Point(47, 244);
            pnlBtn.Name = "pnlBtn";
            pnlBtn.Size = new Size(159, 423);
            pnlBtn.TabIndex = 15;
            // 
            // btnSalesHistory
            // 
            btnSalesHistory.BackColor = Color.LightGoldenrodYellow;
            btnSalesHistory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalesHistory.ForeColor = SystemColors.ActiveCaptionText;
            btnSalesHistory.Location = new Point(24, 353);
            btnSalesHistory.Margin = new Padding(2, 1, 2, 1);
            btnSalesHistory.Name = "btnSalesHistory";
            btnSalesHistory.Size = new Size(114, 56);
            btnSalesHistory.TabIndex = 15;
            btnSalesHistory.Text = "Sales History";
            btnSalesHistory.UseVisualStyleBackColor = false;
            btnSalesHistory.Click += btnSalesHistory_Click;
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
            // btnAddCategory
            // 
            btnAddCategory.BackColor = Color.LightGoldenrodYellow;
            btnAddCategory.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCategory.ForeColor = SystemColors.ActiveCaptionText;
            btnAddCategory.Location = new Point(24, 272);
            btnAddCategory.Margin = new Padding(2, 1, 2, 1);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(114, 56);
            btnAddCategory.TabIndex = 14;
            btnAddCategory.Text = " Add \r\n  Category";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
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
            btnAddEmoloyee.Text = " Add \r\nEmployee";
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
            btnAddProduct.Text = " Add\r\nProduct";
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
            lblUserName.Location = new Point(25, 222);
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
            label1.Location = new Point(40, 175);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(174, 27);
            label1.TabIndex = 3;
            label1.Text = "Admin's Portal";
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
            pnlMain.Controls.Add(salesHistory1);
            pnlMain.Controls.Add(adminDashBoard1);
            pnlMain.Controls.Add(adminAddProducts1);
            pnlMain.Controls.Add(adminAddCategory1);
            pnlMain.Controls.Add(adminAddEmpolyee1);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(251, 36);
            pnlMain.Margin = new Padding(0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1236, 742);
            pnlMain.TabIndex = 2;
            // 
            // salesHistory1
            // 
            salesHistory1.Dock = DockStyle.Fill;
            salesHistory1.Location = new Point(0, 0);
            salesHistory1.Name = "salesHistory1";
            salesHistory1.Size = new Size(1236, 742);
            salesHistory1.TabIndex = 3;
            salesHistory1.Visible = false;
            // 
            // adminDashBoard1
            // 
            adminDashBoard1.Dock = DockStyle.Fill;
            adminDashBoard1.Location = new Point(0, 0);
            adminDashBoard1.Margin = new Padding(0);
            adminDashBoard1.Name = "adminDashBoard1";
            adminDashBoard1.Size = new Size(1236, 742);
            adminDashBoard1.TabIndex = 3;
            // 
            // adminAddProducts1
            // 
            adminAddProducts1.Dock = DockStyle.Fill;
            adminAddProducts1.Location = new Point(0, 0);
            adminAddProducts1.Margin = new Padding(0);
            adminAddProducts1.Name = "adminAddProducts1";
            adminAddProducts1.Size = new Size(1236, 742);
            adminAddProducts1.TabIndex = 3;
            adminAddProducts1.Visible = false;
            // 
            // adminAddCategory1
            // 
            adminAddCategory1.Dock = DockStyle.Fill;
            adminAddCategory1.Location = new Point(0, 0);
            adminAddCategory1.Margin = new Padding(0);
            adminAddCategory1.Name = "adminAddCategory1";
            adminAddCategory1.Size = new Size(1236, 742);
            adminAddCategory1.TabIndex = 3;
            adminAddCategory1.Visible = false;
            // 
            // adminAddEmpolyee1
            // 
            adminAddEmpolyee1.Dock = DockStyle.Fill;
            adminAddEmpolyee1.Location = new Point(0, 0);
            adminAddEmpolyee1.Margin = new Padding(0);
            adminAddEmpolyee1.Name = "adminAddEmpolyee1";
            adminAddEmpolyee1.Size = new Size(1236, 742);
            adminAddEmpolyee1.TabIndex = 0;
            // 
            // FormAdmin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1487, 778);
            Controls.Add(pnlMain);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 1, 3, 1);
            MaximizeBox = false;
            Name = "FormAdmin";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "     User : Admin";
            FormClosed += FormAdmin_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnlBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label4;
        private Label label1;
        private Label lblUserName;
        private Label label3;
      
        private Button btnAddEmoloyee;
        private Button btnDashBord;
        private Button btnAddProduct;
        private Button btnLogout;
        private Button btnDashBoard;
        private Button btnAddCategory;
        private AdminAddProducts adminAddProducts1;
        private Panel pnlMain;
        private AdminAddCategory adminAddCategory1;
        private AdminAddEmpolyee adminAddEmpolyee1;
        private AdminDashBoard adminDashBoard1;
        private Panel pnlBtn;
        
        private Button btnSalesHistory;
        private SalesHistory salesHistory1;
    }
}