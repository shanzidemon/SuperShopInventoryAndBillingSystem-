using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class AdminAddProducts : UserControl
    {
        private string UserId {  get; set; }
        private DataAccess Data { get; set; }
        public AdminAddProducts(string userId)
        {
            InitializeComponent();
            this.Data = new DataAccess();
           
            this.ProductsGridView();
        }

        public AdminAddProducts() : this("") 
        {
        }

        public void SetUserId(string userId) 
        {
            this.UserId = userId;
            this.txtProductsAddBy.Text=UserId;
        }


        private void btnAddProducts_Click(object sender, EventArgs e)
        {


            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from tbl_products where Id = '" + this.txtPId.Text + "';";
                var dt = this.Data.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {

                    var sql = @"update tbl_products
                                set name = '" + this.txtProductsName.Text + @"',
                                category = '" + this.txtProductsCategory.Text + @"',
                                description = '" + this.txtProductsDescription.Text + @"',
                                added_date = '" + this.dtpProductsAddDate.Value.ToString("dd/MM/yyyy") + @"',
                                added_by = '" + this.txtProductsAddBy.Text + @"',
                                qty = " + this.txtPQty.Text + @",
                                price = " + this.txtProductsPrice.Text + @"
                                where Id = " + this.txtPId.Text + "; ";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product Updated Successfully");
                    else
                        MessageBox.Show("Product Update Failed");
                }
                else
                {
                    var sql = "insert into tbl_products values('" + this.txtProductsName.Text + "'," + this.txtProductsCategory.Text + ",'" + this.txtProductsDescription.Text + "'," + this.txtProductsPrice.Text + "," + this.txtPQty.Text + ",'" + this.dtpProductsAddDate.Value.ToString("dd/MM/yyyy") + "','" + this.txtProductsAddBy.Text + "');";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product Added Successfully");
                    else
                        MessageBox.Show("Product Add Field");
                }

                this.ProductsGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }



        private void btnDeleteProducts_Click(object sender, EventArgs e)
        {

            try
            {
                if (this.dgvProducts.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure to remove the Product ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var id = this.dgvProducts.CurrentRow.Cells[0].Value.ToString();
                var productName = this.dgvProducts.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from tbl_products where Id = '" + id + "';";
                var count = this.Data.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(productName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("product hasn't removed successfully");

                this.ProductsGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }

        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {

            this.ProductsGridView();
            this.ClearAll();


        }

        private void ClearAll()
        {
            this.txtPId.Clear();
            this.txtProductsName.Clear();
            this.txtProductsCategory.Clear();
            this.dtpProductsAddDate.Text = "";
            this.txtProductsDescription.Clear();
            this.txtPQty.Clear();
            
            this.txtProductsPrice.Clear();
            this.dgvProducts.ClearSelection();
        }

        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtProductsName.Text) ||
                string.IsNullOrEmpty(this.txtProductsCategory.Text) || string.IsNullOrEmpty(this.txtProductsDescription.Text) ||
                 string.IsNullOrEmpty(this.txtPQty.Text) || string.IsNullOrEmpty(this.txtProductsAddBy.Text) || string.IsNullOrEmpty(this.txtProductsPrice.Text))
                return false;
            else
                return true;
        }







        private void ProductsGridView(string sql = "select * from tbl_products;")
        {
            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.DataSource = ds.Tables[0];
        }

        private void btnSearchProducts_Click(object sender, EventArgs e)
        {
            var sql = "select * from tbl_products where Id = '" + this.txtSearchProducts.Text + "';";
            this.ProductsGridView(sql);
            this.dgvProducts.ClearSelection();

        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {
            this.dgvProducts.ClearSelection();
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            this.txtPId.Text = this.dgvProducts.CurrentRow.Cells["id"].Value.ToString();
            this.txtProductsName.Text = this.dgvProducts.CurrentRow.Cells["name"].Value.ToString();
            this.txtProductsCategory.Text = this.dgvProducts.CurrentRow.Cells["category"].Value.ToString();
            this.txtProductsDescription.Text = this.dgvProducts.CurrentRow.Cells["description"].Value.ToString();
            this.txtPQty.Text = this.dgvProducts.CurrentRow.Cells["qty"].Value.ToString();
            this.txtProductsAddBy.Text = this.dgvProducts.CurrentRow.Cells["added_by"].Value.ToString();
            this.txtProductsPrice.Text = this.dgvProducts.CurrentRow.Cells["price"].Value.ToString();
            this.dtpProductsAddDate.Text = this.dgvProducts.CurrentRow.Cells["added_date"].Value.ToString();

        }

        private void txtSearchProducts_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from tbl_products where Name like '" + this.txtSearchProducts.Text + "%';";
            this.ProductsGridView(sql);
            this.dgvProducts.ClearSelection();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.ProductsGridView();
            this.dgvProducts.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.ProductsGridView();
            this.dgvProducts.ClearSelection();
        }

        private void cbInstructions_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbInstructions.Checked)
            {
                this.lblInstructions1.Visible = true;
                this.lblInstructions2.Visible = true;
                this.lblInstructions3.Visible = true;

            }
            else 
            { 
                this.lblInstructions1.Visible = false; 
                this.lblInstructions2.Visible = false;
                this.lblInstructions3.Visible = false;
            }
        }
    }
}
