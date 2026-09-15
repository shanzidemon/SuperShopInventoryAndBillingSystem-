namespace ShopBillingSystem.UI
{
    partial class AdminAddProducts
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
            panel2 = new Panel();
            lblInstructions3 = new Label();
            cbInstructions = new CheckBox();
            lblInstructions1 = new Label();
            lblInstructions2 = new Label();
            txtSearchProducts = new TextBox();
            btnSearchProducts = new Button();
            dgvProducts = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            category = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            added_date = new DataGridViewTextBoxColumn();
            added_by = new DataGridViewTextBoxColumn();
            lblSearchProducts = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            txtPQty = new TextBox();
            txtPId = new TextBox();
            label8 = new Label();
            txtProductsDescription = new TextBox();
            label4 = new Label();
            label1 = new Label();
            txtProductsPrice = new TextBox();
            dtpProductsAddDate = new DateTimePicker();
            txtProductsAddBy = new TextBox();
            btnClearProducts = new Button();
            btnDeleteProducts = new Button();
            btnAddProducts = new Button();
            label6 = new Label();
            label5 = new Label();
            txtProductsCategory = new TextBox();
            label3 = new Label();
            txtProductsName = new TextBox();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(lblInstructions3);
            panel2.Controls.Add(cbInstructions);
            panel2.Controls.Add(lblInstructions1);
            panel2.Controls.Add(lblInstructions2);
            panel2.Controls.Add(txtSearchProducts);
            panel2.Controls.Add(btnSearchProducts);
            panel2.Controls.Add(dgvProducts);
            panel2.Controls.Add(lblSearchProducts);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1270, 480);
            panel2.TabIndex = 2;
            panel2.Click += panel2_Click;
            // 
            // lblInstructions3
            // 
            lblInstructions3.AutoSize = true;
            lblInstructions3.BackColor = Color.DarkSeaGreen;
            lblInstructions3.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions3.Location = new Point(1050, 92);
            lblInstructions3.Name = "lblInstructions3";
            lblInstructions3.Size = new Size(166, 51);
            lblInstructions3.TabIndex = 14;
            lblInstructions3.Text = "Write Id in search bar\r\nAnd\r\npress Search button";
            lblInstructions3.Visible = false;
            // 
            // cbInstructions
            // 
            cbInstructions.AutoSize = true;
            cbInstructions.Location = new Point(938, 20);
            cbInstructions.Name = "cbInstructions";
            cbInstructions.Size = new Size(106, 24);
            cbInstructions.TabIndex = 10;
            cbInstructions.Text = "Instructions";
            cbInstructions.UseVisualStyleBackColor = true;
            cbInstructions.CheckedChanged += cbInstructions_CheckedChanged;
            // 
            // lblInstructions1
            // 
            lblInstructions1.AutoSize = true;
            lblInstructions1.BackColor = Color.DarkSeaGreen;
            lblInstructions1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions1.Location = new Point(1050, 204);
            lblInstructions1.Name = "lblInstructions1";
            lblInstructions1.Size = new Size(172, 102);
            lblInstructions1.TabIndex = 9;
            lblInstructions1.Text = "For update a Product \r\nDouble click a row\r\nUpdate information in\r\ntext boxes\r\nAnd press Save button\r\n\r\n";
            lblInstructions1.Visible = false;
            // 
            // lblInstructions2
            // 
            lblInstructions2.AutoSize = true;
            lblInstructions2.BackColor = Color.DarkSeaGreen;
            lblInstructions2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions2.Location = new Point(1050, 377);
            lblInstructions2.Name = "lblInstructions2";
            lblInstructions2.Size = new Size(156, 68);
            lblInstructions2.TabIndex = 8;
            lblInstructions2.Text = "For delete a product\r\nSelect  a row \r\nAnd \r\npress Delete button";
            lblInstructions2.Visible = false;
            // 
            // txtSearchProducts
            // 
            txtSearchProducts.Location = new Point(147, 17);
            txtSearchProducts.Name = "txtSearchProducts";
            txtSearchProducts.Size = new Size(583, 27);
            txtSearchProducts.TabIndex = 3;
            txtSearchProducts.TextChanged += txtSearchProducts_TextChanged;
            // 
            // btnSearchProducts
            // 
            btnSearchProducts.BackColor = Color.DarkSeaGreen;
            btnSearchProducts.Location = new Point(736, 15);
            btnSearchProducts.Name = "btnSearchProducts";
            btnSearchProducts.Size = new Size(94, 29);
            btnSearchProducts.TabIndex = 2;
            btnSearchProducts.Text = "Search";
            btnSearchProducts.UseVisualStyleBackColor = false;
            btnSearchProducts.Click += btnSearchProducts_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { id, name, category, description, price, qty, added_date, added_by });
            dgvProducts.Location = new Point(14, 50);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(1030, 395);
            dgvProducts.TabIndex = 1;
            dgvProducts.DoubleClick += dgvProducts_DoubleClick;
            // 
            // id
            // 
            id.DataPropertyName = "id";
            id.HeaderText = "Product ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 125;
            // 
            // name
            // 
            name.DataPropertyName = "name";
            name.HeaderText = "Name";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            name.Width = 125;
            // 
            // category
            // 
            category.DataPropertyName = "category";
            category.HeaderText = "Category";
            category.MinimumWidth = 6;
            category.Name = "category";
            category.ReadOnly = true;
            category.Width = 125;
            // 
            // description
            // 
            description.DataPropertyName = "description";
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
            description.Width = 125;
            // 
            // price
            // 
            price.DataPropertyName = "price";
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 125;
            // 
            // qty
            // 
            qty.DataPropertyName = "qty";
            qty.HeaderText = "Quantity";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            qty.ReadOnly = true;
            qty.Width = 125;
            // 
            // added_date
            // 
            added_date.DataPropertyName = "added_date";
            added_date.HeaderText = "Added Date";
            added_date.MinimumWidth = 6;
            added_date.Name = "added_date";
            added_date.ReadOnly = true;
            added_date.Width = 125;
            // 
            // added_by
            // 
            added_by.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            added_by.DataPropertyName = "added_by";
            added_by.HeaderText = "Added By";
            added_by.MinimumWidth = 6;
            added_by.Name = "added_by";
            added_by.ReadOnly = true;
            // 
            // lblSearchProducts
            // 
            lblSearchProducts.AutoSize = true;
            lblSearchProducts.BackColor = SystemColors.ButtonFace;
            lblSearchProducts.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchProducts.Location = new Point(14, 17);
            lblSearchProducts.Name = "lblSearchProducts";
            lblSearchProducts.Size = new Size(119, 30);
            lblSearchProducts.TabIndex = 0;
            lblSearchProducts.Text = "Search Products \r\n          By Id";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtPQty);
            panel1.Controls.Add(txtPId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtProductsDescription);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtProductsPrice);
            panel1.Controls.Add(dtpProductsAddDate);
            panel1.Controls.Add(txtProductsAddBy);
            panel1.Controls.Add(btnClearProducts);
            panel1.Controls.Add(btnDeleteProducts);
            panel1.Controls.Add(btnAddProducts);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtProductsCategory);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtProductsName);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 478);
            panel1.Name = "panel1";
            panel1.Size = new Size(1267, 252);
            panel1.TabIndex = 3;
            panel1.Click += panel1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(1246, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(21, 35);
            panel3.TabIndex = 33;
            // 
            // txtPQty
            // 
            txtPQty.Location = new Point(93, 92);
            txtPQty.Name = "txtPQty";
            txtPQty.Size = new Size(107, 27);
            txtPQty.TabIndex = 32;
            // 
            // txtPId
            // 
            txtPId.Location = new Point(93, 22);
            txtPId.Name = "txtPId";
            txtPId.ReadOnly = true;
            txtPId.Size = new Size(107, 27);
            txtPId.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(11, 9);
            label8.Name = "label8";
            label8.Size = new Size(76, 40);
            label8.TabIndex = 30;
            label8.Text = "Product\r\n      ID     :";
            // 
            // txtProductsDescription
            // 
            txtProductsDescription.Location = new Point(864, 14);
            txtProductsDescription.Name = "txtProductsDescription";
            txtProductsDescription.Size = new Size(179, 27);
            txtProductsDescription.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(456, 95);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 27;
            label4.Text = "Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 95);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 25;
            label1.Text = "Quantity :";
            // 
            // txtProductsPrice
            // 
            txtProductsPrice.Location = new Point(523, 86);
            txtProductsPrice.Name = "txtProductsPrice";
            txtProductsPrice.Size = new Size(179, 27);
            txtProductsPrice.TabIndex = 24;
            // 
            // dtpProductsAddDate
            // 
            dtpProductsAddDate.CustomFormat = "dd/MM/yyyy";
            dtpProductsAddDate.Location = new Point(1254, 54);
            dtpProductsAddDate.Name = "dtpProductsAddDate";
            dtpProductsAddDate.Size = new Size(10, 27);
            dtpProductsAddDate.TabIndex = 22;
            // 
            // txtProductsAddBy
            // 
            txtProductsAddBy.Location = new Point(295, 90);
            txtProductsAddBy.Name = "txtProductsAddBy";
            txtProductsAddBy.ReadOnly = true;
            txtProductsAddBy.Size = new Size(127, 27);
            txtProductsAddBy.TabIndex = 21;
            // 
            // btnClearProducts
            // 
            btnClearProducts.BackColor = Color.DarkSeaGreen;
            btnClearProducts.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearProducts.Location = new Point(685, 157);
            btnClearProducts.Name = "btnClearProducts";
            btnClearProducts.Size = new Size(111, 35);
            btnClearProducts.TabIndex = 20;
            btnClearProducts.Text = "CLEAR";
            btnClearProducts.UseVisualStyleBackColor = false;
            btnClearProducts.Click += btnClearProducts_Click;
            // 
            // btnDeleteProducts
            // 
            btnDeleteProducts.BackColor = Color.DarkSeaGreen;
            btnDeleteProducts.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteProducts.Location = new Point(472, 157);
            btnDeleteProducts.Name = "btnDeleteProducts";
            btnDeleteProducts.Size = new Size(111, 35);
            btnDeleteProducts.TabIndex = 19;
            btnDeleteProducts.Text = "DELETE";
            btnDeleteProducts.UseVisualStyleBackColor = false;
            btnDeleteProducts.Click += btnDeleteProducts_Click;
            // 
            // btnAddProducts
            // 
            btnAddProducts.BackColor = Color.DarkSeaGreen;
            btnAddProducts.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddProducts.Location = new Point(259, 157);
            btnAddProducts.Name = "btnAddProducts";
            btnAddProducts.Size = new Size(111, 35);
            btnAddProducts.TabIndex = 17;
            btnAddProducts.Text = "Save";
            btnAddProducts.UseVisualStyleBackColor = false;
            btnAddProducts.Click += btnAddProducts_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(206, 92);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 14;
            label6.Text = "Add-By : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(744, 21);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 7;
            label5.Text = "Description :";
            // 
            // txtProductsCategory
            // 
            txtProductsCategory.Location = new Point(572, 18);
            txtProductsCategory.Name = "txtProductsCategory";
            txtProductsCategory.Size = new Size(166, 27);
            txtProductsCategory.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(456, 22);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 3;
            label3.Text = "Category ID :";
            // 
            // txtProductsName
            // 
            txtProductsName.Location = new Point(290, 18);
            txtProductsName.Name = "txtProductsName";
            txtProductsName.Size = new Size(160, 27);
            txtProductsName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 9);
            label2.Name = "label2";
            label2.Size = new Size(78, 40);
            label2.TabIndex = 1;
            label2.Text = "Product\r\n Name   :";
            // 
            // AdminAddProducts
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AdminAddProducts";
            Size = new Size(1270, 730);
            Load += AdminAddProducts_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private TextBox txtSearchProducts;
        private Button btnSearchProducts;
        private DataGridView dgvProducts;
        private Label lblSearchProducts;
        private Panel panel1;
        private Button btnClearProducts;
        private Button btnDeleteProducts;
        private Button btnAddProducts;
        private Label label6;
       
        private Label label5;
        private TextBox txtProductsCategory;
        private Label label3;
        private TextBox txtProductsName;
        private Label label2;
        private DateTimePicker dtpProductsAddDate;
        private TextBox txtProductsAddBy;
        private Label label4;
        
        private Label label1;
        private TextBox txtProductsPrice;
        private TextBox txtProductsDescription;
        private Label label8;
        private TextBox txtPId;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn category;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn added_date;
        private DataGridViewTextBoxColumn added_by;
        private TextBox txtPQty;
        private Label lblInstructions1;
        private Label lblInstructions2;
        private CheckBox cbInstructions;
        private Label lblInstructions3;
        private Panel panel3;
    }
}
