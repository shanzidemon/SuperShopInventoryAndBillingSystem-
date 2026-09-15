namespace ShopBillingSystem.UI
{
    partial class FourmRecipt
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
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            dvgTotal = new DataGridView();
            type = new DataGridViewTextBoxColumn();
            grandTotal = new DataGridViewTextBoxColumn();
            transaction_date = new DataGridViewTextBoxColumn();
            tax = new DataGridViewTextBoxColumn();
            discount = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            dvgItems = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            qty = new DataGridViewTextBoxColumn();
            total = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgTotal).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvgItems).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(57, 17);
            label2.TabIndex = 8;
            label2.Text = "Items :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 400);
            label1.Name = "label1";
            label1.Size = new Size(78, 17);
            label1.TabIndex = 5;
            label1.Text = "Total bill :";
            // 
            // panel2
            // 
            panel2.Controls.Add(dvgTotal);
            panel2.Location = new Point(14, 424);
            panel2.Name = "panel2";
            panel2.Size = new Size(701, 169);
            panel2.TabIndex = 7;
            // 
            // dvgTotal
            // 
            dvgTotal.AllowUserToAddRows = false;
            dvgTotal.AllowUserToDeleteRows = false;
            dvgTotal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgTotal.Columns.AddRange(new DataGridViewColumn[] { type, grandTotal, transaction_date, tax, discount });
            dvgTotal.Dock = DockStyle.Fill;
            dvgTotal.Location = new Point(0, 0);
            dvgTotal.Name = "dvgTotal";
            dvgTotal.ReadOnly = true;
            dvgTotal.RowHeadersWidth = 51;
            dvgTotal.Size = new Size(701, 169);
            dvgTotal.TabIndex = 0;
            // 
            // type
            // 
            type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            type.DataPropertyName = "type";
            type.HeaderText = "Payment By";
            type.MinimumWidth = 6;
            type.Name = "type";
            type.ReadOnly = true;
            // 
            // grandTotal
            // 
            grandTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            grandTotal.DataPropertyName = "grandTotal";
            grandTotal.HeaderText = "Grand Total";
            grandTotal.MinimumWidth = 6;
            grandTotal.Name = "grandTotal";
            grandTotal.ReadOnly = true;
            // 
            // transaction_date
            // 
            transaction_date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            transaction_date.DataPropertyName = "transaction_date";
            transaction_date.HeaderText = "Taransaction Date";
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
            // panel1
            // 
            panel1.Controls.Add(dvgItems);
            panel1.Location = new Point(9, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 361);
            panel1.TabIndex = 6;
            // 
            // dvgItems
            // 
            dvgItems.AllowUserToAddRows = false;
            dvgItems.AllowUserToDeleteRows = false;
            dvgItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgItems.Columns.AddRange(new DataGridViewColumn[] { product_id, price, qty, total });
            dvgItems.Dock = DockStyle.Fill;
            dvgItems.Location = new Point(0, 0);
            dvgItems.Name = "dvgItems";
            dvgItems.ReadOnly = true;
            dvgItems.RowHeadersWidth = 51;
            dvgItems.Size = new Size(706, 361);
            dvgItems.TabIndex = 0;
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            product_id.DataPropertyName = "product_id";
            product_id.HeaderText = "Product Id";
            product_id.MinimumWidth = 6;
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            price.DataPropertyName = "price";
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            price.ReadOnly = true;
            // 
            // qty
            // 
            qty.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            qty.DataPropertyName = "qty";
            qty.HeaderText = "Quantity";
            qty.MinimumWidth = 6;
            qty.Name = "qty";
            qty.ReadOnly = true;
            // 
            // total
            // 
            total.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            total.DataPropertyName = "total";
            total.HeaderText = "Total";
            total.MinimumWidth = 6;
            total.Name = "total";
            total.ReadOnly = true;
            // 
            // FourmRecipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 624);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FourmRecipt";
            Text = "FourmRecipt";
            Load += FourmRecipt_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgTotal).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvgItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Panel panel2;
        private DataGridView dvgTotal;
        private DataGridViewTextBoxColumn type;
        private DataGridViewTextBoxColumn grandTotal;
        private DataGridViewTextBoxColumn transaction_date;
        private DataGridViewTextBoxColumn tax;
        private DataGridViewTextBoxColumn discount;
        private Panel panel1;
        private DataGridView dvgItems;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn qty;
        private DataGridViewTextBoxColumn total;
    }
}