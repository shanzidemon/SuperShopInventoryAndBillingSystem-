using Microsoft.Data;
using Microsoft.Data.SqlClient;
using ShopBillingSystem;
using ShopBillingSystem.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class FormLogin : Form
    {

        private DataAccess Data { get; set; }

        public FormLogin()
        {
            InitializeComponent();
            this.Data = new DataAccess();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var sql = "select * from dbo.tbl_Users where Id = '" + this.txtUserId.Text.Trim() + "' and Password = '" + this.txtPassword.Text.Trim() + "';";
            DataSet ds = this.Data.ExecuteQuery(sql);

            if (ds.Tables[0].Rows.Count == 1)
            {
                this.Visible = false;
                MessageBox.Show("Login Successful");
                var name = ds.Tables[0].Rows[0][1].ToString();
                var userId = ds.Tables[0].Rows[0][0].ToString();
                if (ds.Tables[0].Rows[0][3].ToString() == "admin")
                {
                    new FormAdmin(name,userId, this).Show();
                }
                else if (ds.Tables[0].Rows[0][3].ToString() == "employee")
                {
                    new FormEmployee(name, this).Show();
                }
            }
            else
            {
                MessageBox.Show("Login Failed");
            }

            
        }




        private void cbPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }



        }
    }
}
