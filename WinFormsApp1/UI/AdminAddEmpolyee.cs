using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data;
using Microsoft.Data.SqlClient;

namespace ShopBillingSystem.UI
{
    public partial class AdminAddEmpolyee : UserControl
    {
        private string UserId {  get; set; } 
       private DataAccess Data { get; set; }
        private UserControl UserControl { get; set; }

        public AdminAddEmpolyee()
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.UserGridView();
        }

        public void SetUserId(string userId)
        {
            this.UserId = userId;
            this.txtAddBy.Text = UserId;
        }



        private void btnAddEmployeeData_Click(object sender, EventArgs e)
        {


            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                var query = "select * from tbl_users where Id = '" + this.txtUserId.Text + "';";
                var dt = this.Data.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {

                    var sql = @"update tbl_users
                                set Name = '" + this.txtUsername.Text + @"',
                                Password = '" + this.txtPassword.Text + @"',
                                Role = '" + this.cmbRole.Text + @"',
                                Added_Date = '" + this.dtpAddDate.Text + @"',
                                Added_By = '" + this.txtAddBy.Text + @"'
                                where Id = '" + this.txtUserId.Text + "'; ";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated properly");
                    else
                        MessageBox.Show("Data hasn't been updated properly");
                }
                else
                {
                    var sql = "insert into tbl_users values('" + this.txtUserId.Text + "', '" + this.txtUsername.Text + "', '" + this.txtPassword.Text + "', '" + this.cmbRole.Text + "', '" + this.dtpAddDate.Text + "','" + this.txtAddBy.Text + "');";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added properly");
                    else
                        MessageBox.Show("Data hasn't been added properly");
                }

                this.UserGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }


        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtUsername.Text) || string.IsNullOrEmpty(this.txtPassword.Text) ||
                string.IsNullOrEmpty(this.cmbRole.Text) || string.IsNullOrEmpty(this.txtAddBy.Text))
                return false;
            else
                return true;
        }







        private void ClearAll()
        {
            this.txtUserId.Clear();
            this.txtUsername.Clear();
            this.txtPassword.Clear();
            this.dtpAddDate.Text = "";
            this.cmbRole.SelectedIndex = -1;
           
            this.dgvUser.ClearSelection();
        }












        private void UserGridView(string sql = "select * from tbl_users;")
        {
            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = ds.Tables[0];
        }










        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to remove user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult res = MessageBox.Show("Are you sure to remove the user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;

                var id = this.dgvUser.CurrentRow.Cells[0].Value.ToString();
                var userName = this.dgvUser.CurrentRow.Cells[1].Value.ToString();

                var sql = "delete from tbl_users where Id = '" + id + "';";
                var count = this.Data.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(userName.ToUpper() + " has been removed from the list.");
                else
                    MessageBox.Show("Data hasn't been removed properly");

                this.UserGridView();
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }






        private void btnSearch_Click(object sender, EventArgs e)
        {
            var sql = "select * from tbl_users where Id = '" + this.txtSeaech.Text + "';";
            this.UserGridView(sql);
            this.dgvUser.ClearSelection();
        }



        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserId.Text = this.dgvUser.CurrentRow.Cells["Id"].Value.ToString();
            this.txtUsername.Text = this.dgvUser.CurrentRow.Cells["userName"].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells["Password"].Value.ToString();
            this.cmbRole.Text = this.dgvUser.CurrentRow.Cells["Role"].Value.ToString();
            this.dtpAddDate.Text = this.dgvUser.CurrentRow.Cells["Added_Date"].Value.ToString();

            this.txtAddBy.Text = this.dgvUser.CurrentRow.Cells["Added_By"].Value.ToString();
        }


        private void AdminAddEmpolyee_Load(object sender, EventArgs e)
        {
            this.dgvUser.ClearSelection();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSeaech_TextChanged(object sender, EventArgs e)
        {
            var sql = "select * from tbl_users where Name like '" + this.txtSeaech.Text + "%';";
            this.UserGridView(sql);
            this.dgvUser.ClearSelection();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.UserGridView();
            this.ClearAll();

        }

        private void panel2_Click(object sender, EventArgs e)
        {
            this.UserGridView();
            this.dgvUser.ClearSelection();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.UserGridView();
            this.dgvUser.ClearSelection();
        }


        private void GenerateUserID(string role)
        {
            role = role.Trim().ToLower();

            string prefix;

            if (role == "admin")
            {
                prefix = "adm";
            }
            else if (role == "employee")
            {
                prefix = "emp";
            }
            else
            {
                this.txtUserId.Text = "";
                return;
            }

            string sql = "SELECT TOP 1 Id FROM tbl_users " +
                         "WHERE Role = '" + role + "' " +
                         "ORDER BY Id DESC";

            var dt = this.Data.ExecuteQueryTable(sql);

            if (dt.Rows.Count == 0)
            {
                this.txtUserId.Text = prefix + "001";
            }
            else
            {
                string lastId = dt.Rows[0][0].ToString();

                int number = Convert.ToInt32(lastId.Substring(3));
                number++;

                this.txtUserId.Text = prefix + number.ToString("D3");
            }
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.GenerateUserID(cmbRole.Text);
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
        
