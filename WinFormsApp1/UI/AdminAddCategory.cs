using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class AdminAddCategory : UserControl
    {
        private DataAccess Data { get; set; }
        private string UserId {  get; set; }
        
       public AdminAddCategory() : this("") 
        {
        }
        
        public AdminAddCategory(string userId)
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.CategoryGridView();
           
        }


        public void SetUserId(string userId)
        {
            this.UserId = userId;
            this.txtCateAddBy.Text = UserId;
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

                var query = "select * from tbl_products where Id = '" + this.txtCataId.Text + "';";
                var dt = this.Data.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {

                    var sql = @"update tbl_categories
                                set Title = '" + this.txtCataTitel.Text + @"',
                                description = '" + this.txtCateDesription.Text + @"',
                                added_date = '" + this.dtpCateAddDate.Value.ToString("dd/MM/yyyy") + @"',
                                added_by = '" + this.txtCateAddBy.Text + @"'
                                where Id = " + this.txtCataId.Text + "; ";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Category Updated Successfully");
                    else
                        MessageBox.Show("Category Update Failed");
                }
                else
                {
                    var sql = "insert into tbl_categories values('" + this.txtCataTitel.Text + "','" + txtCateDesription.Text + "','" + this.dtpCateAddDate.Value.ToString("dd/MM/yyyy") + "','" + this.txtCateAddBy.Text + "');";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Category Added Successfully");
                    else
                        MessageBox.Show("Category Add Field");
                }

                this.CategoryGridView();
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
                if (this.dgvCategory.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove Category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure to remove the Category ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var id = this.dgvCategory.CurrentRow.Cells[0].Value.ToString();
                var categoryName = this.dgvCategory.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from tbl_categories where Id = '" + id + "';";
                var count = this.Data.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(categoryName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Category hasn't removed successfully");

                this.CategoryGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }

        private void btnClearProducts_Click(object sender, EventArgs e)
        {
            this.CategoryGridView();
            this.ClearAll();


        }


        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtCataTitel.Text) || string.IsNullOrEmpty(this.txtCateDesription.Text) ||
                 string.IsNullOrEmpty(this.txtCateAddBy.Text))
                return false;
            else
                return true;
        }




        private void ClearAll()
        {
            this.txtCataId.Clear();
            this.dtpCateAddDate.Text = "";
            
            this.txtCataTitel.Clear();
            this.txtCateDesription.Clear();
            this.dgvCategory.ClearSelection();
        }


        private void CategoryGridView(string sql = "select * from tbl_categories;")
        {
            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dgvCategory.AutoGenerateColumns = false;
            this.dgvCategory.DataSource = ds.Tables[0];
        }

        private void AdminAddCategory_Load(object sender, EventArgs e)
        {
            this.dgvCategory.ClearSelection();
        }

        private void txtSearchCategoy_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from tbl_categories where Title like '" + this.txtSearchCategoy.Text + "%';";
            this.CategoryGridView(sql);
            this.dgvCategory.ClearSelection();
        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            var sql = "select * from tbl_categories where Id = " + this.txtSearchCategoy.Text + ";";
            this.CategoryGridView(sql);
            this.dgvCategory.ClearSelection();

        }

        private void dgvCategory_DoubleClick(object sender, EventArgs e)
        {
            this.txtCataId.Text = this.dgvCategory.CurrentRow.Cells["Id"].Value.ToString();
            this.txtCataTitel.Text = this.dgvCategory.CurrentRow.Cells["Title"].Value.ToString();
            this.txtCateDesription.Text = this.dgvCategory.CurrentRow.Cells["description"].Value.ToString();
            this.txtCateAddBy.Text = this.dgvCategory.CurrentRow.Cells["added_by"].Value.ToString();
            this.dtpCateAddDate.Text = this.dgvCategory.CurrentRow.Cells["added_date"].Value.ToString();
        }



        private void panel2_Click(object sender, EventArgs e)
        {
            this.CategoryGridView();
            this.dgvCategory.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.CategoryGridView();
            this.dgvCategory.ClearSelection();
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
