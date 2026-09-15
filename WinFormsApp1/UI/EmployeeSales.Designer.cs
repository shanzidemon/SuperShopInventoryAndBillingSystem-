using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    partial class EmployeeSales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvProducts = new DataGridView();
            colProductId = new DataGridViewTextBoxColumn();
            colProductName = new DataGridViewTextBoxColumn();
            colProductCategory = new DataGridViewTextBoxColumn();
            colProductPrice = new DataGridViewTextBoxColumn();
            colProductStock = new DataGridViewTextBoxColumn();
            colProductDescription = new DataGridViewTextBoxColumn();
            colProductAddedDate = new DataGridViewTextBoxColumn();
            dgvCart = new DataGridView();
            colCartId = new DataGridViewTextBoxColumn();
            colCartProduct = new DataGridViewTextBoxColumn();
            colCartPrice = new DataGridViewTextBoxColumn();
            colCartQty = new DataGridViewTextBoxColumn();
            colCartTotal = new DataGridViewTextBoxColumn();
            pnlProductDetails = new Panel();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            btnClear = new Button();
            btnRemove = new Button();
            btnAddToCart = new Button();
            lblPriceValue = new Label();
            lblPriceLabel = new Label();
            nudQuantity = new NumericUpDown();
            lblQuantityLabel = new Label();
            lblProductNameLabel = new Label();
            lblProductIdLabel = new Label();
            cmbCategory = new ComboBox();
            lblCategoryLabel = new Label();
            pnlCart = new Panel();
            cmbPaymentType = new ComboBox();
            label1 = new Label();
            lblTaxValue = new Label();
            lblTaxLabel = new Label();
            txtDiscount = new TextBox();
            lblSubtotalValue = new Label();
            lblDiscountLabel = new Label();
            lblSubtotalLabel = new Label();
            btnClearCart = new Button();
            btnPay = new Button();
            lblChangeValue = new Label();
            lblChangeLabel = new Label();
            txtAmount = new TextBox();
            lblAmountLabel = new Label();
            lblGrandTotalValue = new Label();
            lblGrandTotalLabel = new Label();
            lblSearchById = new Label();
            txtSearchById = new TextBox();
            btnSearchById = new Button();
            lblSearchByName = new Label();
            txtSearchByName = new TextBox();
            btnSearchByName = new Button();
            ((ISupportInitialize)dgvProducts).BeginInit();
            ((ISupportInitialize)dgvCart).BeginInit();
            pnlProductDetails.SuspendLayout();
            ((ISupportInitialize)nudQuantity).BeginInit();
            pnlCart.SuspendLayout();
            SuspendLayout();
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductId, colProductName, colProductCategory, colProductPrice, colProductStock, colProductDescription, colProductAddedDate });
            dgvProducts.Location = new Point(11, 77);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.ScrollBars = ScrollBars.Vertical;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(815, 394);
            dgvProducts.TabIndex = 28;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // colProductId
            // 
            colProductId.DataPropertyName = "id";
            colProductId.HeaderText = "ID";
            colProductId.MinimumWidth = 6;
            colProductId.Name = "colProductId";
            colProductId.ReadOnly = true;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "name";
            colProductName.HeaderText = "Name";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.ReadOnly = true;
            // 
            // colProductCategory
            // 
            colProductCategory.DataPropertyName = "category";
            colProductCategory.HeaderText = "Category";
            colProductCategory.MinimumWidth = 6;
            colProductCategory.Name = "colProductCategory";
            colProductCategory.ReadOnly = true;
            // 
            // colProductPrice
            // 
            colProductPrice.DataPropertyName = "price";
            colProductPrice.HeaderText = "Price";
            colProductPrice.MinimumWidth = 6;
            colProductPrice.Name = "colProductPrice";
            colProductPrice.ReadOnly = true;
            // 
            // colProductStock
            // 
            colProductStock.DataPropertyName = "qty";
            colProductStock.HeaderText = "Stock";
            colProductStock.MinimumWidth = 6;
            colProductStock.Name = "colProductStock";
            colProductStock.ReadOnly = true;
            // 
            // colProductDescription
            // 
            colProductDescription.DataPropertyName = "description";
            colProductDescription.HeaderText = "Description";
            colProductDescription.MinimumWidth = 6;
            colProductDescription.Name = "colProductDescription";
            colProductDescription.ReadOnly = true;
            // 
            // colProductAddedDate
            // 
            colProductAddedDate.DataPropertyName = "added_date";
            colProductAddedDate.HeaderText = "Added Date";
            colProductAddedDate.MinimumWidth = 6;
            colProductAddedDate.Name = "colProductAddedDate";
            colProductAddedDate.ReadOnly = true;
            // 
            // dgvCart
            // 
            dgvCart.AllowUserToAddRows = false;
            dgvCart.AllowUserToDeleteRows = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Columns.AddRange(new DataGridViewColumn[] { colCartId, colCartProduct, colCartPrice, colCartQty, colCartTotal });
            dgvCart.Location = new Point(5, 5);
            dgvCart.MultiSelect = false;
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.ScrollBars = ScrollBars.Vertical;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.Size = new Size(380, 365);
            dgvCart.TabIndex = 1;
            dgvCart.CellClick += dgvCart_CellClick;
            // 
            // colCartId
            // 
            colCartId.DataPropertyName = "ProductId";
            colCartId.HeaderText = "ID";
            colCartId.MinimumWidth = 6;
            colCartId.Name = "colCartId";
            colCartId.ReadOnly = true;
            // 
            // colCartProduct
            // 
            colCartProduct.DataPropertyName = "ProductName";
            colCartProduct.HeaderText = "Product";
            colCartProduct.MinimumWidth = 6;
            colCartProduct.Name = "colCartProduct";
            colCartProduct.ReadOnly = true;
            // 
            // colCartPrice
            // 
            colCartPrice.DataPropertyName = "Price";
            colCartPrice.HeaderText = "Price";
            colCartPrice.MinimumWidth = 6;
            colCartPrice.Name = "colCartPrice";
            colCartPrice.ReadOnly = true;
            // 
            // colCartQty
            // 
            colCartQty.DataPropertyName = "Qty";
            colCartQty.HeaderText = "Quantity";
            colCartQty.MinimumWidth = 6;
            colCartQty.Name = "colCartQty";
            colCartQty.ReadOnly = true;
            // 
            // colCartTotal
            // 
            colCartTotal.DataPropertyName = "Total";
            colCartTotal.HeaderText = "Total";
            colCartTotal.MinimumWidth = 6;
            colCartTotal.Name = "colCartTotal";
            colCartTotal.ReadOnly = true;
            // 
            // pnlProductDetails
            // 
            pnlProductDetails.BackColor = Color.White;
            pnlProductDetails.Controls.Add(txtProductId);
            pnlProductDetails.Controls.Add(txtProductName);
            pnlProductDetails.Controls.Add(btnClear);
            pnlProductDetails.Controls.Add(btnRemove);
            pnlProductDetails.Controls.Add(btnAddToCart);
            pnlProductDetails.Controls.Add(lblPriceValue);
            pnlProductDetails.Controls.Add(lblPriceLabel);
            pnlProductDetails.Controls.Add(nudQuantity);
            pnlProductDetails.Controls.Add(lblQuantityLabel);
            pnlProductDetails.Controls.Add(lblProductNameLabel);
            pnlProductDetails.Controls.Add(lblProductIdLabel);
            pnlProductDetails.Controls.Add(cmbCategory);
            pnlProductDetails.Controls.Add(lblCategoryLabel);
            pnlProductDetails.Location = new Point(11, 488);
            pnlProductDetails.Name = "pnlProductDetails";
            pnlProductDetails.Size = new Size(815, 228);
            pnlProductDetails.TabIndex = 29;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(573, 25);
            txtProductId.Name = "txtProductId";
            txtProductId.ReadOnly = true;
            txtProductId.Size = new Size(125, 27);
            txtProductId.TabIndex = 0;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(131, 80);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new Size(149, 27);
            txtProductName.TabIndex = 1;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSeaGreen;
            btnClear.Location = new Point(495, 169);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(98, 44);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.DarkSeaGreen;
            btnRemove.Location = new Point(374, 169);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(99, 44);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = Color.DarkSeaGreen;
            btnAddToCart.Location = new Point(242, 169);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(92, 44);
            btnAddToCart.TabIndex = 4;
            btnAddToCart.Text = "Add";
            btnAddToCart.UseVisualStyleBackColor = false;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // lblPriceValue
            // 
            lblPriceValue.AutoSize = true;
            lblPriceValue.Location = new Point(130, 127);
            lblPriceValue.Name = "lblPriceValue";
            lblPriceValue.Size = new Size(17, 20);
            lblPriceValue.TabIndex = 5;
            lblPriceValue.Text = "0";
            // 
            // lblPriceLabel
            // 
            lblPriceLabel.AutoSize = true;
            lblPriceLabel.Location = new Point(17, 127);
            lblPriceLabel.Name = "lblPriceLabel";
            lblPriceLabel.Size = new Size(44, 20);
            lblPriceLabel.TabIndex = 6;
            lblPriceLabel.Text = "Price:";
            // 
            // nudQuantity
            // 
            nudQuantity.Location = new Point(579, 88);
            nudQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudQuantity.Name = "nudQuantity";
            nudQuantity.Size = new Size(119, 27);
            nudQuantity.TabIndex = 7;
            nudQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblQuantityLabel
            // 
            lblQuantityLabel.AutoSize = true;
            lblQuantityLabel.Location = new Point(422, 93);
            lblQuantityLabel.Name = "lblQuantityLabel";
            lblQuantityLabel.Size = new Size(68, 20);
            lblQuantityLabel.TabIndex = 8;
            lblQuantityLabel.Text = "Quantity:";
            // 
            // lblProductNameLabel
            // 
            lblProductNameLabel.AutoSize = true;
            lblProductNameLabel.Location = new Point(14, 82);
            lblProductNameLabel.Name = "lblProductNameLabel";
            lblProductNameLabel.Size = new Size(107, 20);
            lblProductNameLabel.TabIndex = 9;
            lblProductNameLabel.Text = "Product Name:";
            // 
            // lblProductIdLabel
            // 
            lblProductIdLabel.AutoSize = true;
            lblProductIdLabel.Location = new Point(422, 25);
            lblProductIdLabel.Name = "lblProductIdLabel";
            lblProductIdLabel.Size = new Size(80, 20);
            lblProductIdLabel.TabIndex = 10;
            lblProductIdLabel.Text = "Product Id:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(131, 25);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(150, 28);
            cmbCategory.TabIndex = 11;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblCategoryLabel
            // 
            lblCategoryLabel.AutoSize = true;
            lblCategoryLabel.Location = new Point(17, 28);
            lblCategoryLabel.Name = "lblCategoryLabel";
            lblCategoryLabel.Size = new Size(69, 20);
            lblCategoryLabel.TabIndex = 12;
            lblCategoryLabel.Text = "Category";
            // 
            // pnlCart
            // 
            pnlCart.BackColor = Color.White;
            pnlCart.Controls.Add(cmbPaymentType);
            pnlCart.Controls.Add(label1);
            pnlCart.Controls.Add(lblTaxValue);
            pnlCart.Controls.Add(lblTaxLabel);
            pnlCart.Controls.Add(txtDiscount);
            pnlCart.Controls.Add(lblSubtotalValue);
            pnlCart.Controls.Add(lblDiscountLabel);
            pnlCart.Controls.Add(lblSubtotalLabel);
            pnlCart.Controls.Add(btnClearCart);
            pnlCart.Controls.Add(btnPay);
            pnlCart.Controls.Add(lblChangeValue);
            pnlCart.Controls.Add(lblChangeLabel);
            pnlCart.Controls.Add(txtAmount);
            pnlCart.Controls.Add(lblAmountLabel);
            pnlCart.Controls.Add(lblGrandTotalValue);
            pnlCart.Controls.Add(lblGrandTotalLabel);
            pnlCart.Controls.Add(dgvCart);
            pnlCart.Location = new Point(835, 77);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(390, 640);
            pnlCart.TabIndex = 30;
            // 
            // cmbPaymentType
            // 
            cmbPaymentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentType.FormattingEnabled = true;
            cmbPaymentType.Items.AddRange(new object[] { "Cash", "Card", "Mobile Banking" });
            cmbPaymentType.Location = new Point(130, 526);
            cmbPaymentType.Name = "cmbPaymentType";
            cmbPaymentType.Size = new Size(151, 28);
            cmbPaymentType.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 529);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 14;
            label1.Text = "Payment Type";
            // 
            // lblTaxValue
            // 
            lblTaxValue.AutoSize = true;
            lblTaxValue.Location = new Point(108, 494);
            lblTaxValue.Name = "lblTaxValue";
            lblTaxValue.Size = new Size(17, 20);
            lblTaxValue.TabIndex = 0;
            lblTaxValue.Text = "0";
            // 
            // lblTaxLabel
            // 
            lblTaxLabel.AutoSize = true;
            lblTaxLabel.Location = new Point(12, 491);
            lblTaxLabel.Name = "lblTaxLabel";
            lblTaxLabel.Size = new Size(33, 20);
            lblTaxLabel.TabIndex = 1;
            lblTaxLabel.Text = "Tax:";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(108, 439);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(80, 27);
            txtDiscount.TabIndex = 2;
            txtDiscount.TextChanged += txtDiscount_TextChanged;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Location = new Point(108, 390);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(17, 20);
            lblSubtotalValue.TabIndex = 3;
            lblSubtotalValue.Text = "0";
            // 
            // lblDiscountLabel
            // 
            lblDiscountLabel.AutoSize = true;
            lblDiscountLabel.Location = new Point(12, 439);
            lblDiscountLabel.Name = "lblDiscountLabel";
            lblDiscountLabel.Size = new Size(92, 20);
            lblDiscountLabel.TabIndex = 4;
            lblDiscountLabel.Text = "Discount(%):";
            // 
            // lblSubtotalLabel
            // 
            lblSubtotalLabel.AutoSize = true;
            lblSubtotalLabel.Location = new Point(12, 390);
            lblSubtotalLabel.Name = "lblSubtotalLabel";
            lblSubtotalLabel.Size = new Size(68, 20);
            lblSubtotalLabel.TabIndex = 5;
            lblSubtotalLabel.Text = "Subtotal:";
            // 
            // btnClearCart
            // 
            btnClearCart.BackColor = Color.DarkSeaGreen;
            btnClearCart.Location = new Point(263, 580);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.Size = new Size(92, 44);
            btnClearCart.TabIndex = 6;
            btnClearCart.Text = "Clear Cart";
            btnClearCart.UseVisualStyleBackColor = false;
            btnClearCart.Click += btnClearCart_Click;
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.DarkSeaGreen;
            btnPay.Location = new Point(30, 580);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(95, 44);
            btnPay.TabIndex = 7;
            btnPay.Text = "Pay";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // lblChangeValue
            // 
            lblChangeValue.AutoSize = true;
            lblChangeValue.Location = new Point(321, 491);
            lblChangeValue.Name = "lblChangeValue";
            lblChangeValue.Size = new Size(17, 20);
            lblChangeValue.TabIndex = 8;
            lblChangeValue.Text = "0";
            // 
            // lblChangeLabel
            // 
            lblChangeLabel.AutoSize = true;
            lblChangeLabel.Location = new Point(219, 494);
            lblChangeLabel.Name = "lblChangeLabel";
            lblChangeLabel.Size = new Size(62, 20);
            lblChangeLabel.TabIndex = 9;
            lblChangeLabel.Text = "Change:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(285, 439);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(80, 27);
            txtAmount.TabIndex = 10;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // lblAmountLabel
            // 
            lblAmountLabel.AutoSize = true;
            lblAmountLabel.Location = new Point(216, 439);
            lblAmountLabel.Name = "lblAmountLabel";
            lblAmountLabel.Size = new Size(65, 20);
            lblAmountLabel.TabIndex = 11;
            lblAmountLabel.Text = "Amount:";
            // 
            // lblGrandTotalValue
            // 
            lblGrandTotalValue.AutoSize = true;
            lblGrandTotalValue.Location = new Point(321, 390);
            lblGrandTotalValue.Name = "lblGrandTotalValue";
            lblGrandTotalValue.Size = new Size(17, 20);
            lblGrandTotalValue.TabIndex = 12;
            lblGrandTotalValue.Text = "0";
            // 
            // lblGrandTotalLabel
            // 
            lblGrandTotalLabel.AutoSize = true;
            lblGrandTotalLabel.Location = new Point(216, 390);
            lblGrandTotalLabel.Name = "lblGrandTotalLabel";
            lblGrandTotalLabel.Size = new Size(89, 20);
            lblGrandTotalLabel.TabIndex = 13;
            lblGrandTotalLabel.Text = "Grand Total:";
            // 
            // lblSearchById
            // 
            lblSearchById.AutoSize = true;
            lblSearchById.BackColor = SystemColors.ButtonFace;
            lblSearchById.Location = new Point(11, 19);
            lblSearchById.Name = "lblSearchById";
            lblSearchById.Size = new Size(90, 20);
            lblSearchById.TabIndex = 31;
            lblSearchById.Text = "Search By Id";
            // 
            // txtSearchById
            // 
            txtSearchById.Location = new Point(110, 16);
            txtSearchById.Name = "txtSearchById";
            txtSearchById.Size = new Size(150, 27);
            txtSearchById.TabIndex = 32;
            txtSearchById.TextChanged += txtSearchById_TextChanged;
            // 
            // btnSearchById
            // 
            btnSearchById.BackColor = Color.DarkSeaGreen;
            btnSearchById.Location = new Point(270, 15);
            btnSearchById.Name = "btnSearchById";
            btnSearchById.Size = new Size(94, 29);
            btnSearchById.TabIndex = 33;
            btnSearchById.Text = "Search";
            btnSearchById.UseVisualStyleBackColor = false;
            btnSearchById.Click += btnSearchById_Click;
            // 
            // lblSearchByName
            // 
            lblSearchByName.AutoSize = true;
            lblSearchByName.BackColor = SystemColors.ButtonFace;
            lblSearchByName.Location = new Point(390, 19);
            lblSearchByName.Name = "lblSearchByName";
            lblSearchByName.Size = new Size(117, 20);
            lblSearchByName.TabIndex = 34;
            lblSearchByName.Text = "Search By Name";
            // 
            // txtSearchByName
            // 
            txtSearchByName.Location = new Point(510, 16);
            txtSearchByName.Name = "txtSearchByName";
            txtSearchByName.Size = new Size(150, 27);
            txtSearchByName.TabIndex = 35;
            txtSearchByName.TextChanged += txtSearchByName_TextChanged;
            // 
            // btnSearchByName
            // 
            btnSearchByName.BackColor = Color.DarkSeaGreen;
            btnSearchByName.Location = new Point(670, 15);
            btnSearchByName.Name = "btnSearchByName";
            btnSearchByName.Size = new Size(94, 29);
            btnSearchByName.TabIndex = 36;
            btnSearchByName.Text = "Search";
            btnSearchByName.UseVisualStyleBackColor = false;
            btnSearchByName.Click += btnSearchByName_Click;
            // 
            // EmployeeSales
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblSearchByName);
            Controls.Add(btnSearchByName);
            Controls.Add(txtSearchByName);
            Controls.Add(btnSearchById);
            Controls.Add(txtSearchById);
            Controls.Add(lblSearchById);
            Controls.Add(pnlCart);
            Controls.Add(pnlProductDetails);
            Controls.Add(dgvProducts);
            Name = "EmployeeSales";
            Size = new Size(1240, 737);
            Load += EmployeeSales_Load;
            ((ISupportInitialize)dgvProducts).EndInit();
            ((ISupportInitialize)dgvCart).EndInit();
            pnlProductDetails.ResumeLayout(false);
            pnlProductDetails.PerformLayout();
            ((ISupportInitialize)nudQuantity).EndInit();
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn colProductId;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colProductCategory;
        private DataGridViewTextBoxColumn colProductPrice;
        private DataGridViewTextBoxColumn colProductStock;
        private DataGridViewTextBoxColumn colProductDescription;
        private DataGridViewTextBoxColumn colProductAddedDate;
        
        private DataGridView dgvCart;
        private DataGridViewTextBoxColumn colCartId;
        private DataGridViewTextBoxColumn colCartProduct;
        private DataGridViewTextBoxColumn colCartPrice;
        private DataGridViewTextBoxColumn colCartQty;
        private DataGridViewTextBoxColumn colCartTotal;
        
        private Label lblSearchByName;
        private Button btnSearchByName;
        private TextBox txtSearchByName;
        private Button btnSearchById;
        private TextBox txtSearchById;
        private Label lblSearchById;
        
        private Panel pnlCart;
        private Label lblTaxValue;
        private Label lblTaxLabel;
        private TextBox txtDiscount;
        private Label lblSubtotalValue;
        private Label lblDiscountLabel;
        private Label lblSubtotalLabel;
        private Button btnClearCart;
        private Button btnPay;
        private Label lblChangeValue;
        private Label lblChangeLabel;
        private TextBox txtAmount;
        private Label lblAmountLabel;
        private Label lblGrandTotalValue;
        private Label lblGrandTotalLabel;
        
        private Label lblProductIdLabel;
        private ComboBox cmbCategory;
        private Label lblCategoryLabel;
        private Panel pnlProductDetails;
        private TextBox txtProductId;
        private TextBox txtProductName;
        private Button btnClear;
        private Button btnRemove;
        private Button btnAddToCart;
        private Label lblPriceValue;
        private Label lblPriceLabel;
        private NumericUpDown nudQuantity;
        private Label lblQuantityLabel;
        private Label lblProductNameLabel;
        private ComboBox cmbPaymentType;
        private Label label1;
    }
}
