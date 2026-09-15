namespace ShopBillingSystem.UI
{
    partial class EmployeeDashboard
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
            labelTitle = new Label();
            panelTotalSales = new Panel();
            lblTotalSalesCount = new Label();
            lblTotalSalesTitle = new Label();
            panelTotalOrders = new Panel();
            lblTotalOrdersCount = new Label();
            lblTotalOrdersTitle = new Label();
            panelTotalProducts = new Panel();
            lblTotalProductsCount = new Label();
            lblTotalProductsTitle = new Label();
            panelTotalCategories = new Panel();
            lblTotalCategoriesCount = new Label();
            lblTotalCategoriesTitle = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelTotalSales.SuspendLayout();
            panelTotalOrders.SuspendLayout();
            panelTotalProducts.SuspendLayout();
            panelTotalCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.ForeColor = Color.FromArgb(45, 45, 48);
            labelTitle.Location = new Point(3, 10);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(357, 46);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Employee Dashboard";
            // 
            // panelTotalSales
            // 
            panelTotalSales.BackColor = Color.FromArgb(52, 152, 219);
            panelTotalSales.Controls.Add(lblTotalSalesCount);
            panelTotalSales.Controls.Add(lblTotalSalesTitle);
            panelTotalSales.Location = new Point(3, 71);
            panelTotalSales.Margin = new Padding(3, 4, 3, 4);
            panelTotalSales.Name = "panelTotalSales";
            panelTotalSales.Size = new Size(293, 154);
            panelTotalSales.TabIndex = 1;
            // 
            // lblTotalSalesCount
            // 
            lblTotalSalesCount.AutoSize = true;
            lblTotalSalesCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalSalesCount.ForeColor = Color.White;
            lblTotalSalesCount.Location = new Point(23, 80);
            lblTotalSalesCount.Name = "lblTotalSalesCount";
            lblTotalSalesCount.Size = new Size(80, 54);
            lblTotalSalesCount.TabIndex = 1;
            lblTotalSalesCount.Text = " $0";
            // 
            // lblTotalSalesTitle
            // 
            lblTotalSalesTitle.AutoSize = true;
            lblTotalSalesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalSalesTitle.ForeColor = Color.White;
            lblTotalSalesTitle.Location = new Point(23, 27);
            lblTotalSalesTitle.Name = "lblTotalSalesTitle";
            lblTotalSalesTitle.Size = new Size(163, 32);
            lblTotalSalesTitle.TabIndex = 0;
            lblTotalSalesTitle.Text = "Total Sales";
            // 
            // panelTotalOrders
            // 
            panelTotalOrders.BackColor = Color.FromArgb(46, 204, 113);
            panelTotalOrders.Controls.Add(lblTotalOrdersCount);
            panelTotalOrders.Controls.Add(lblTotalOrdersTitle);
            panelTotalOrders.Location = new Point(317, 71);
            panelTotalOrders.Margin = new Padding(3, 4, 3, 4);
            panelTotalOrders.Name = "panelTotalOrders";
            panelTotalOrders.Size = new Size(291, 154);
            panelTotalOrders.TabIndex = 2;
            // 
            // lblTotalOrdersCount
            // 
            lblTotalOrdersCount.AutoSize = true;
            lblTotalOrdersCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalOrdersCount.ForeColor = Color.White;
            lblTotalOrdersCount.Location = new Point(23, 80);
            lblTotalOrdersCount.Name = "lblTotalOrdersCount";
            lblTotalOrdersCount.Size = new Size(46, 54);
            lblTotalOrdersCount.TabIndex = 1;
            lblTotalOrdersCount.Text = "0";
            // 
            // lblTotalOrdersTitle
            // 
            lblTotalOrdersTitle.AutoSize = true;
            lblTotalOrdersTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalOrdersTitle.ForeColor = Color.White;
            lblTotalOrdersTitle.Location = new Point(23, 27);
            lblTotalOrdersTitle.Name = "lblTotalOrdersTitle";
            lblTotalOrdersTitle.Size = new Size(179, 32);
            lblTotalOrdersTitle.TabIndex = 0;
            lblTotalOrdersTitle.Text = "Total Orders";
            // 
            // panelTotalProducts
            // 
            panelTotalProducts.BackColor = Color.FromArgb(243, 156, 18);
            panelTotalProducts.Controls.Add(lblTotalProductsCount);
            panelTotalProducts.Controls.Add(lblTotalProductsTitle);
            panelTotalProducts.Location = new Point(626, 71);
            panelTotalProducts.Margin = new Padding(3, 4, 3, 4);
            panelTotalProducts.Name = "panelTotalProducts";
            panelTotalProducts.Size = new Size(293, 154);
            panelTotalProducts.TabIndex = 3;
            // 
            // lblTotalProductsCount
            // 
            lblTotalProductsCount.AutoSize = true;
            lblTotalProductsCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalProductsCount.ForeColor = Color.White;
            lblTotalProductsCount.Location = new Point(23, 80);
            lblTotalProductsCount.Name = "lblTotalProductsCount";
            lblTotalProductsCount.Size = new Size(46, 54);
            lblTotalProductsCount.TabIndex = 1;
            lblTotalProductsCount.Text = "0";
            // 
            // lblTotalProductsTitle
            // 
            lblTotalProductsTitle.AutoSize = true;
            lblTotalProductsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalProductsTitle.ForeColor = Color.White;
            lblTotalProductsTitle.Location = new Point(23, 27);
            lblTotalProductsTitle.Name = "lblTotalProductsTitle";
            lblTotalProductsTitle.Size = new Size(143, 32);
            lblTotalProductsTitle.TabIndex = 0;
            lblTotalProductsTitle.Text = "Total Products";
            // 
            // panelTotalCategories
            // 
            panelTotalCategories.BackColor = Color.Red;
            panelTotalCategories.Controls.Add(lblTotalCategoriesCount);
            panelTotalCategories.Controls.Add(lblTotalCategoriesTitle);
            panelTotalCategories.Location = new Point(940, 71);
            panelTotalCategories.Margin = new Padding(3, 4, 3, 4);
            panelTotalCategories.Name = "panelTotalCategories";
            panelTotalCategories.Size = new Size(293, 154);
            panelTotalCategories.TabIndex = 6;
            // 
            // lblTotalCategoriesCount
            // 
            lblTotalCategoriesCount.AutoSize = true;
            lblTotalCategoriesCount.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTotalCategoriesCount.ForeColor = Color.White;
            lblTotalCategoriesCount.Location = new Point(23, 80);
            lblTotalCategoriesCount.Name = "lblTotalCategoriesCount";
            lblTotalCategoriesCount.Size = new Size(46, 54);
            lblTotalCategoriesCount.TabIndex = 1;
            lblTotalCategoriesCount.Text = "0";
            // 
            // lblTotalCategoriesTitle
            // 
            lblTotalCategoriesTitle.AutoSize = true;
            lblTotalCategoriesTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTotalCategoriesTitle.ForeColor = Color.White;
            lblTotalCategoriesTitle.Location = new Point(23, 27);
            lblTotalCategoriesTitle.Name = "lblTotalCategoriesTitle";
            lblTotalCategoriesTitle.Size = new Size(227, 32);
            lblTotalCategoriesTitle.TabIndex = 0;
            lblTotalCategoriesTitle.Text = "Total Categories";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.images1;
            pictureBox1.Location = new Point(12, 263);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(508, 479);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1000_F_1086684842_q1F1oMsj4iloIRtVpiB2SfieNWTVOXmM;
            pictureBox2.Location = new Point(517, 263);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(719, 479);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // EmployeeDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            Controls.Add(panelTotalCategories);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panelTotalProducts);
            Controls.Add(panelTotalOrders);
            Controls.Add(panelTotalSales);
            Controls.Add(labelTitle);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeDashboard";
            Size = new Size(1230, 737);
            Load += EmployeeDashboard_Load;
            VisibleChanged += EmployeeDashboard_VisibleChanged;
            panelTotalSales.ResumeLayout(false);
            panelTotalSales.PerformLayout();
            panelTotalOrders.ResumeLayout(false);
            panelTotalOrders.PerformLayout();
            panelTotalProducts.ResumeLayout(false);
            panelTotalProducts.PerformLayout();
            panelTotalCategories.ResumeLayout(false);
            panelTotalCategories.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Panel panelTotalSales;
        private Label lblTotalSalesCount;
        private Label lblTotalSalesTitle;
        private Panel panelTotalOrders;
        private Label lblTotalOrdersCount;
        private Label lblTotalOrdersTitle;
        private Panel panelTotalProducts;
        private Label lblTotalProductsCount;
        private Label lblTotalProductsTitle;
        private Panel panelTotalCategories;
        private Label lblTotalCategoriesCount;
        private Label lblTotalCategoriesTitle;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
