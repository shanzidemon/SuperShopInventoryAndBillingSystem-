using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class EmployeeSales : UserControl
    {
        private DataAccess Data { get; set; }
        private string EmployeeName { get; set; }

        public EmployeeSales()
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.LoadCategories();
            this.LoadProducts();
        }

        public void SetEmployeeName(string name)
        {
            this.EmployeeName = name;
        }

        private void EmployeeSales_Load(object sender, EventArgs e)
        {
            this.dgvProducts.ClearSelection();
            this.dgvCart.ClearSelection();
        }

        private void LoadCategories()
        {
            var sql = "SELECT Id, Title FROM tbl_categories;";
            var dt = this.Data.ExecuteQueryTable(sql);

            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("All");
            foreach (DataRow row in dt.Rows)
            {
                cmbCategory.Items.Add(row["Title"].ToString());
            }
            cmbCategory.SelectedIndex = 0;
        }

        private void LoadProducts(string sql = "SELECT * FROM tbl_products;")
        {
            DataSet ds = this.Data.ExecuteQuery(sql);
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.DataSource = ds.Tables[0];
            this.dgvProducts.ClearSelection();
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchById.Text))
                {
                    this.LoadProducts();
                    return;
                }

                if (!int.TryParse(txtSearchById.Text, out int searchId))
                {
                    MessageBox.Show("Please enter a valid numeric ID to search.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var sql = "SELECT * FROM tbl_products WHERE id = " + searchId + ";";
                this.LoadProducts(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchByName.Text))
                {
                    this.LoadProducts();
                    return;
                }

                var sql = "SELECT * FROM tbl_products WHERE name LIKE '%" + txtSearchByName.Text + "%';";
                this.LoadProducts(sql);
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void txtSearchById_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchById.Text))
            {
                this.LoadProducts();
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchByName.Text))
            {
                this.LoadProducts();
            }
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedIndex == 0)
            {
                this.LoadProducts();
            }
            else
            {
                var sql = "SELECT * FROM tbl_products WHERE category = (SELECT Id FROM tbl_categories WHERE Title = '" + cmbCategory.SelectedItem.ToString() + "');";
                this.LoadProducts(sql);
            }
        }

        private decimal currentAvailableStock = 0;

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            txtProductId.Text = dgvProducts.Rows[e.RowIndex].Cells["colProductId"].Value.ToString();
            txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["colProductName"].Value.ToString();
            lblPriceValue.Text = dgvProducts.Rows[e.RowIndex].Cells["colProductPrice"].Value.ToString();
            
            if (decimal.TryParse(dgvProducts.Rows[e.RowIndex].Cells["colProductStock"].Value.ToString(), out decimal stock))
            {
                currentAvailableStock = stock;
            }
            else
            {
                currentAvailableStock = 0;
            }
            
            nudQuantity.Value = 1;
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductId.Text))
            {
                MessageBox.Show("Please select a product first.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (currentAvailableStock <= 0)
            {
                MessageBox.Show("This product is out of stock!", "Stock Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nudQuantity.Value > currentAvailableStock)
            {
                MessageBox.Show("Quantity exceeds available stock. Only " + currentAvailableStock + " items available.", "Stock Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool itemExists = false;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["colCartId"].Value != null && row.Cells["colCartId"].Value.ToString() == txtProductId.Text)
                    {
                        
                        row.Cells["colCartQty"].Value = nudQuantity.Value;
                        decimal price = Convert.ToDecimal(row.Cells["colCartPrice"].Value);
                        row.Cells["colCartTotal"].Value = price * nudQuantity.Value;
                        itemExists = true;
                        break;
                    }
                }

                if (!itemExists)
                {
                    decimal price = Convert.ToDecimal(lblPriceValue.Text);
                    dgvCart.Rows.Add(
                        Convert.ToInt32(txtProductId.Text),
                        txtProductName.Text,
                        price,
                        nudQuantity.Value,
                        price * nudQuantity.Value
                    );
                }

                CalculateTotals();
                ClearProductSelection();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCart.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvCart.SelectedRows[0].Index;
                    dgvCart.Rows.RemoveAt(rowIndex);
                    CalculateTotals();
                    ClearProductSelection();
                }
                else
                {
                    MessageBox.Show("Please select an item from the cart to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearProductSelection();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to clear the entire cart?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                dgvCart.Rows.Clear();
                CalculateTotals();
                ClearProductSelection();
            }
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                txtProductId.Text = dgvCart.Rows[e.RowIndex].Cells["colCartId"].Value.ToString();
                txtProductName.Text = dgvCart.Rows[e.RowIndex].Cells["colCartProduct"].Value.ToString();
                lblPriceValue.Text = dgvCart.Rows[e.RowIndex].Cells["colCartPrice"].Value.ToString();
                nudQuantity.Value = Convert.ToDecimal(dgvCart.Rows[e.RowIndex].Cells["colCartQty"].Value);

               
                currentAvailableStock = 0;
                foreach (DataGridViewRow row in dgvProducts.Rows)
                {
                    if (row.Cells["colProductId"].Value != null && row.Cells["colProductId"].Value.ToString() == txtProductId.Text)
                    {
                        if (decimal.TryParse(row.Cells["colProductStock"].Value.ToString(), out decimal stock))
                        {
                            currentAvailableStock = stock;
                        }
                        break;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void CalculateTotals()
        {
            try
            {
                decimal subtotal = 0;
                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["colCartTotal"].Value != null)
                    {
                        subtotal += Convert.ToDecimal(row.Cells["colCartTotal"].Value);
                    }
                }
                lblSubtotalValue.Text = subtotal.ToString("0.00");

                decimal discount = 0;
                decimal.TryParse(txtDiscount.Text, out discount);
                if (discount < 0) discount = 0;

                decimal discountedTotal = subtotal - (subtotal * discount / 100);

                decimal tax = discountedTotal * 0.05m;
                lblTaxValue.Text = tax.ToString("0.00");

                decimal grandTotal = discountedTotal + tax;

                lblGrandTotalValue.Text = grandTotal.ToString("0.00");

                decimal amount = 0;
                decimal.TryParse(txtAmount.Text, out amount);

                decimal change = amount - grandTotal;
                lblChangeValue.Text = change.ToString("0.00");
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void ClearProductSelection()
        {
            txtProductId.Clear();
            txtProductName.Clear();
            lblPriceValue.Text = "0";
            nudQuantity.Value = 1;
            dgvProducts.ClearSelection();
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            CalculateTotals();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0 || (dgvCart.Rows.Count == 1 && dgvCart.Rows[0].IsNewRow))
            {
                MessageBox.Show("Cart is empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                this.CalculateTotals();

                decimal grandTotal = Convert.ToDecimal(lblGrandTotalValue.Text);
                decimal amount = 0;
                decimal.TryParse(txtAmount.Text, out amount);

                if (amount < grandTotal)
                {
                    MessageBox.Show("Amount provided is less than the Grand Total. Please collect the full amount.", "Insufficient Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrEmpty(cmbPaymentType.Text))
                {
                    MessageBox.Show("Please select a Payment Type.", "Missing Payment Type", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure you want to proceed with payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                decimal discount = 0;
                decimal.TryParse(txtDiscount.Text, out discount);
                decimal tax = 0;
                decimal.TryParse(lblTaxValue.Text, out tax);

                string addedByName = string.IsNullOrEmpty(this.EmployeeName) ? "employee" : this.EmployeeName;
                
                
                string userId = "emp001"; 
                try
                {
                    var userDt = this.Data.ExecuteQueryTable("SELECT Id FROM tbl_users WHERE Name = '" + addedByName + "'");
                    if (userDt.Rows.Count > 0)
                    {
                        userId = userDt.Rows[0][0].ToString();
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show("An error has occured.\n" + exc.Message);
                }

                string transDate = DateTime.Now.ToString("dd/MM/yyyy");
                string paymentType = cmbPaymentType.Text;

                var sqlTransaction = "INSERT INTO tbl_transactions (type, grandTotal, transaction_date, tax, discount, added_by) VALUES ('" + paymentType + "', " + grandTotal + ", '" + transDate + "', " + tax + ", " + discount + ", '" + userId + "'); SELECT SCOPE_IDENTITY();";
                var dtTrans = this.Data.ExecuteQueryTable(sqlTransaction);
                int transactionId = Convert.ToInt32(dtTrans.Rows[0][0]);

                foreach (DataGridViewRow row in dgvCart.Rows)
                {
                    if (row.Cells["colCartId"].Value == null) continue;
                    
                    int productId = Convert.ToInt32(row.Cells["colCartId"].Value);
                    decimal price = Convert.ToDecimal(row.Cells["colCartPrice"].Value);
                    decimal qty = Convert.ToDecimal(row.Cells["colCartQty"].Value);
                    decimal total = Convert.ToDecimal(row.Cells["colCartTotal"].Value);

                    var sqlDetail = "INSERT INTO tbl_transaction_detail (product_id, price, qty, total, added_date, added_by, transactionId) VALUES (" + productId + ", " + price + ", " + qty + ", " + total + ", '" + transDate + "', '" + userId + "', " + transactionId + ");";
                    this.Data.ExecuteDMLQuery(sqlDetail);

                    var sqlUpdateQty = "UPDATE tbl_products SET qty = qty - " + qty + " WHERE id = " + productId + ";";
                    this.Data.ExecuteDMLQuery(sqlUpdateQty);
                }

                MessageBox.Show("Payment Successful!\nTransaction ID: " + transactionId, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvCart.Rows.Clear();
                this.CalculateTotals();
                this.ClearProductSelection();
                txtDiscount.Clear();
                txtAmount.Clear();
                cmbPaymentType.SelectedIndex = -1;
                this.LoadProducts();

                FourmRecipt receiptForm = new FourmRecipt(transactionId);
                receiptForm.Show();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
    }
}
