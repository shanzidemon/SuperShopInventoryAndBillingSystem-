namespace ShopBillingSystem.UI
{
    partial class AdminAddCategory
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
            panel1 = new Panel();
            panel3 = new Panel();
            txtCataId = new TextBox();
            label8 = new Label();
            txtCateAddBy = new TextBox();
            dtpCateAddDate = new DateTimePicker();
            txtCateDesription = new TextBox();
            btnClearProducts = new Button();
            btnDeleteProducts = new Button();
            btnAddProducts = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtCataTitel = new TextBox();
            panel2 = new Panel();
            lblInstructions3 = new Label();
            cbInstructions = new CheckBox();
            lblInstructions2 = new Label();
            lblInstructions1 = new Label();
            txtSearchCategoy = new TextBox();
            btnSearchCategory = new Button();
            dgvCategory = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            added_by = new DataGridViewTextBoxColumn();
            added_date = new DataGridViewTextBoxColumn();
            lblSearchProducts = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtCataId);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtCateAddBy);
            panel1.Controls.Add(dtpCateAddDate);
            panel1.Controls.Add(txtCateDesription);
            panel1.Controls.Add(btnClearProducts);
            panel1.Controls.Add(btnDeleteProducts);
            panel1.Controls.Add(btnAddProducts);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtCataTitel);
            panel1.Location = new Point(0, 477);
            panel1.Name = "panel1";
            panel1.Size = new Size(1256, 250);
            panel1.TabIndex = 4;
            panel1.Click += panel1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(436, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(24, 31);
            panel3.TabIndex = 32;
            // 
            // txtCataId
            // 
            txtCataId.Location = new Point(142, 6);
            txtCataId.Name = "txtCataId";
            txtCataId.ReadOnly = true;
            txtCataId.Size = new Size(184, 27);
            txtCataId.TabIndex = 31;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ButtonFace;
            label8.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 11);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 30;
            label8.Text = "Category ID :";
            // 
            // txtCateAddBy
            // 
            txtCateAddBy.Location = new Point(142, 75);
            txtCateAddBy.Name = "txtCateAddBy";
            txtCateAddBy.ReadOnly = true;
            txtCateAddBy.Size = new Size(184, 27);
            txtCateAddBy.TabIndex = 28;
            // 
            // dtpCateAddDate
            // 
            dtpCateAddDate.CustomFormat = "dd/MM/yyyy";
            dtpCateAddDate.Location = new Point(450, 82);
            dtpCateAddDate.Name = "dtpCateAddDate";
            dtpCateAddDate.Size = new Size(10, 27);
            dtpCateAddDate.TabIndex = 22;
            // 
            // txtCateDesription
            // 
            txtCateDesription.Location = new Point(748, 6);
            txtCateDesription.Name = "txtCateDesription";
            txtCateDesription.Size = new Size(203, 27);
            txtCateDesription.TabIndex = 21;
            // 
            // btnClearProducts
            // 
            btnClearProducts.BackColor = Color.DarkSeaGreen;
            btnClearProducts.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearProducts.Location = new Point(689, 142);
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
            btnDeleteProducts.Location = new Point(450, 142);
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
            btnAddProducts.Location = new Point(211, 142);
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
            label6.Location = new Point(53, 82);
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
            label5.Location = new Point(628, 3);
            label5.Name = "label5";
            label5.Size = new Size(114, 20);
            label5.TabIndex = 7;
            label5.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, 6);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 3;
            label3.Text = "Titel :";
            // 
            // txtCataTitel
            // 
            txtCataTitel.Location = new Point(410, 6);
            txtCataTitel.Name = "txtCataTitel";
            txtCataTitel.Size = new Size(189, 27);
            txtCataTitel.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblInstructions3);
            panel2.Controls.Add(cbInstructions);
            panel2.Controls.Add(lblInstructions2);
            panel2.Controls.Add(lblInstructions1);
            panel2.Controls.Add(txtSearchCategoy);
            panel2.Controls.Add(btnSearchCategory);
            panel2.Controls.Add(dgvCategory);
            panel2.Controls.Add(lblSearchProducts);
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1253, 468);
            panel2.TabIndex = 5;
            panel2.Click += panel2_Click;
            // 
            // lblInstructions3
            // 
            lblInstructions3.AutoSize = true;
            lblInstructions3.BackColor = Color.DarkSeaGreen;
            lblInstructions3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions3.Location = new Point(977, 79);
            lblInstructions3.Name = "lblInstructions3";
            lblInstructions3.Size = new Size(211, 40);
            lblInstructions3.TabIndex = 13;
            lblInstructions3.Text = "Write Id in search bar\r\nAnd press Search button";
            lblInstructions3.Visible = false;
            // 
            // cbInstructions
            // 
            cbInstructions.AutoSize = true;
            cbInstructions.Location = new Point(845, 27);
            cbInstructions.Name = "cbInstructions";
            cbInstructions.Size = new Size(106, 24);
            cbInstructions.TabIndex = 12;
            cbInstructions.Text = "Instructions";
            cbInstructions.UseVisualStyleBackColor = true;
            cbInstructions.CheckedChanged += cbInstructions_CheckedChanged;
            // 
            // lblInstructions2
            // 
            lblInstructions2.AutoSize = true;
            lblInstructions2.BackColor = Color.DarkSeaGreen;
            lblInstructions2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions2.Location = new Point(977, 377);
            lblInstructions2.Name = "lblInstructions2";
            lblInstructions2.Size = new Size(207, 60);
            lblInstructions2.TabIndex = 11;
            lblInstructions2.Text = "For delete a categoy\r\nSelect  a row\r\nAnd press Delete button";
            lblInstructions2.Visible = false;
            // 
            // lblInstructions1
            // 
            lblInstructions1.AutoSize = true;
            lblInstructions1.BackColor = Color.DarkSeaGreen;
            lblInstructions1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions1.Location = new Point(977, 188);
            lblInstructions1.Name = "lblInstructions1";
            lblInstructions1.Size = new Size(193, 120);
            lblInstructions1.TabIndex = 10;
            lblInstructions1.Text = "For update a category \r\nDouble click a row\r\nUpdate information in\r\ntext boxes\r\nAnd press Save button\r\n\r\n";
            lblInstructions1.Visible = false;
            // 
            // txtSearchCategoy
            // 
            txtSearchCategoy.Location = new Point(157, 22);
            txtSearchCategoy.Name = "txtSearchCategoy";
            txtSearchCategoy.Size = new Size(564, 27);
            txtSearchCategoy.TabIndex = 3;
            txtSearchCategoy.TextChanged += txtSearchCategoy_TextChanged;
            // 
            // btnSearchCategory
            // 
            btnSearchCategory.BackColor = Color.DarkSeaGreen;
            btnSearchCategory.Location = new Point(727, 22);
            btnSearchCategory.Name = "btnSearchCategory";
            btnSearchCategory.Size = new Size(94, 29);
            btnSearchCategory.TabIndex = 2;
            btnSearchCategory.Text = "Search";
            btnSearchCategory.UseVisualStyleBackColor = false;
            btnSearchCategory.Click += btnSearchCategory_Click;
            // 
            // dgvCategory
            // 
            dgvCategory.AllowUserToAddRows = false;
            dgvCategory.AllowUserToDeleteRows = false;
            dgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCategory.Columns.AddRange(new DataGridViewColumn[] { Id, Title, description, added_by, added_date });
            dgvCategory.Location = new Point(24, 57);
            dgvCategory.Name = "dgvCategory";
            dgvCategory.ReadOnly = true;
            dgvCategory.RowHeadersWidth = 51;
            dgvCategory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCategory.Size = new Size(927, 395);
            dgvCategory.TabIndex = 1;
            dgvCategory.DoubleClick += dgvCategory_DoubleClick;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Category ID";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Title
            // 
            Title.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Category Titel";
            Title.MinimumWidth = 6;
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            description.DataPropertyName = "description";
            description.HeaderText = "Description";
            description.MinimumWidth = 6;
            description.Name = "description";
            description.ReadOnly = true;
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
            // added_date
            // 
            added_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            added_date.DataPropertyName = "added_date";
            added_date.HeaderText = "Added Date";
            added_date.MinimumWidth = 6;
            added_date.Name = "added_date";
            added_date.ReadOnly = true;
            // 
            // lblSearchProducts
            // 
            lblSearchProducts.AutoSize = true;
            lblSearchProducts.BackColor = SystemColors.ButtonFace;
            lblSearchProducts.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchProducts.Location = new Point(24, 22);
            lblSearchProducts.Name = "lblSearchProducts";
            lblSearchProducts.Size = new Size(120, 30);
            lblSearchProducts.TabIndex = 0;
            lblSearchProducts.Text = "Search Category \r\n          By Id";
            // 
            // AdminAddCategory
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AdminAddCategory";
            Size = new Size(1256, 730);
            Load += AdminAddCategory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCategory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label8;
        private TextBox txtCateAddBy;
        private DateTimePicker dtpCateAddDate;
        private TextBox txtCateDesription;
        private Button btnClearProducts;
        private Button btnDeleteProducts;
        private Button btnAddProducts;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox txtCataTitel;
        private Panel panel2;
        private TextBox txtSearchCategoy;
        private Button btnSearchCategory;
        private DataGridView dgvCategory;
        private Label lblSearchProducts;
        private TextBox txtCataId;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn added_by;
        private DataGridViewTextBoxColumn added_date;
        private Label lblInstructions1;
        private Label lblInstructions2;
        private CheckBox cbInstructions;
        private Label lblInstructions3;
        private Panel panel3;
    }
}
