using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class EmployeeProfile : UserControl
    {
        private DataAccess Data { get; set; }
        private string UserName { get; set; }

        public EmployeeProfile()
        {
            InitializeComponent();
            this.Data = new DataAccess();
        }

        public void SetUserName(string name)
        {
            this.UserName = name;
            this.lblUserNameValue.Text = name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCurrentPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
                {
                    MessageBox.Show("Please fill in all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtNewPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var query = "select * from tbl_users where Name = '" + this.UserName + "' and Password = '" + txtCurrentPassword.Text.Trim() + "';";
                var dt = this.Data.ExecuteQueryTable(query);

                if (dt.Rows.Count == 1)
                {
                    var sql = "UPDATE tbl_users SET Password = '" + txtNewPassword.Text.Trim() + "' WHERE Name = '" + this.UserName + "';";
                    int count = this.Data.ExecuteDMLQuery(sql);

                    if (count == 1)
                    {
                        MessageBox.Show("Password changed successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCurrentPassword.Text = "";
                        txtNewPassword.Text = "";
                        txtConfirmPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password change failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Current password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
    }
}
