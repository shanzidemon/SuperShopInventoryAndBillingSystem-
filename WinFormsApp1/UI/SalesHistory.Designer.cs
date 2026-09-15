namespace ShopBillingSystem.UI
{
    partial class SalesHistory
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
            lblInstructions3 = new Label();
            cmbType = new ComboBox();
            label1 = new Label();
            cbInstructions = new CheckBox();
            txtTransaction = new TextBox();
            btnSearchTransaction = new Button();
            lblSearchProducts = new Label();
            dgvTransaction = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            type = new DataGridViewTextBoxColumn();
            grandTotal = new DataGridViewTextBoxColumn();
            transaction_date = new DataGridViewTextBoxColumn();
            tax = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            added_by = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblInstructions3);
            panel1.Controls.Add(cmbType);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cbInstructions);
            panel1.Controls.Add(txtTransaction);
            panel1.Controls.Add(btnSearchTransaction);
            panel1.Controls.Add(lblSearchProducts);
            panel1.Controls.Add(dgvTransaction);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1261, 684);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // lblInstructions3
            // 
            lblInstructions3.AutoSize = true;
            lblInstructions3.BackColor = Color.DarkSeaGreen;
            lblInstructions3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions3.Location = new Point(10, 607);
            lblInstructions3.Name = "lblInstructions3";
            lblInstructions3.Size = new Size(290, 60);
            lblInstructions3.TabIndex = 19;
            lblInstructions3.Text = "Write Date in search bar\r\nLike: Date/Month/year(07/05/2020)\r\nAnd press Search button\r\n";
            lblInstructions3.Visible = false;
            // 
            // cmbType
            // 
            cmbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "All", "Cash", "Card", "Mobile Banking" });
            cmbType.Location = new Point(882, 14);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 18;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(757, 20);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 17;
            label1.Text = "Transaction Type";
            // 
            // cbInstructions
            // 
            cbInstructions.AutoSize = true;
            cbInstructions.Location = new Point(1061, 20);
            cbInstructions.Name = "cbInstructions";
            cbInstructions.Size = new Size(106, 24);
            cbInstructions.TabIndex = 16;
            cbInstructions.Text = "Instructions";
            cbInstructions.UseVisualStyleBackColor = true;
            cbInstructions.CheckedChanged += cbInstructions_CheckedChanged;
            // 
            // txtTransaction
            // 
            txtTransaction.Location = new Point(154, 12);
            txtTransaction.Name = "txtTransaction";
            txtTransaction.Size = new Size(466, 27);
            txtTransaction.TabIndex = 15;
            // 
            // btnSearchTransaction
            // 
            btnSearchTransaction.BackColor = Color.DarkSeaGreen;
            btnSearchTransaction.Location = new Point(626, 12);
            btnSearchTransaction.Name = "btnSearchTransaction";
            btnSearchTransaction.Size = new Size(94, 29);
            btnSearchTransaction.TabIndex = 14;
            btnSearchTransaction.Text = "Search";
            btnSearchTransaction.UseVisualStyleBackColor = false;
            btnSearchTransaction.Click += btnSearchTransaction_Click;
            // 
            // lblSearchProducts
            // 
            lblSearchProducts.AutoSize = true;
            lblSearchProducts.BackColor = SystemColors.ButtonFace;
            lblSearchProducts.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchProducts.Location = new Point(10, 12);
            lblSearchProducts.Name = "lblSearchProducts";
            lblSearchProducts.Size = new Size(138, 30);
            lblSearchProducts.TabIndex = 13;
            lblSearchProducts.Text = "Search Transaction \r\n          By Date";
            // 
            // dgvTransaction
            // 
            dgvTransaction.AllowUserToAddRows = false;
            dgvTransaction.AllowUserToDeleteRows = false;
            dgvTransaction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransaction.Columns.AddRange(new DataGridViewColumn[] { id, type, grandTotal, transaction_date, tax, discount, added_by });
            dgvTransaction.Location = new Point(10, 48);
            dgvTransaction.Name = "dgvTransaction";
            dgvTransaction.ReadOnly = true;
            dgvTransaction.RowHeadersWidth = 51;
            dgvTransaction.Size = new Size(1157, 543);
            dgvTransaction.TabIndex = 0;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            id.DataPropertyName = "id";
            id.HeaderText = "Transaction ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.DataPropertyName = "type";
            type.HeaderText = "Type";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // grandTotal
            // 
            grandTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grandTotal.DataPropertyName = "grandTotal";
            grandTotal.HeaderText = "Tolal Bill";
            grandTotal.MinimumWidth = 6;
            grandTotal.Name = "grandTotal";
            grandTotal.ReadOnly = true;
            // 
            // transaction_date
            // 
            transaction_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            transaction_date.DataPropertyName = "transaction_date";
            transaction_date.HeaderText = "Transaction Date";
            transaction_date.MinimumWidth = 6;
            transaction_date.Name = "transaction_date";
            transaction_date.ReadOnly = true;
            // 
            // tax
            // 
            tax.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            tax.DataPropertyName = "tax";
            tax.HeaderText = "Tax";
            tax.MinimumWidth = 6;
            tax.Name = "tax";
            tax.ReadOnly = true;
            // 
            // discount
            // 
            discount.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            discount.DataPropertyName = "discount";
            discount.HeaderText = "Discount";
            discount.MinimumWidth = 6;
            discount.Name = "discount";
            discount.ReadOnly = true;
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
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SalesHistory";
            Size = new Size(1261, 684);
            Load += SalesHistory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransaction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvTransaction;
        private ComboBox cmbType;
        private Label label1;
        private CheckBox cbInstructions;
        private TextBox txtTransaction;
        private Button btnSearchTransaction;
        private Label lblSearchProducts;
        private Label lblInstructions3;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn grandTotal;
        private DataGridViewTextBoxColumn transaction_date;
        private DataGridViewTextBoxColumn tax;
        private DataGridViewTextBoxColumn discount;
        private DataGridViewTextBoxColumn added_by;
    }
}
