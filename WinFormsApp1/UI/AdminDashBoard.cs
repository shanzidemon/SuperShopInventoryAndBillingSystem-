using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class AdminDashBoard : UserControl
    {
        private int TotalAdmin { get; set; }
        private int TotalEmployee { get; set; }
        private double TotalIncome { get; set; }
        private double TodayIncome { get; set; }
        private DataAccess Data { get; set; }


        public AdminDashBoard()
        {
            InitializeComponent();
            this.Data = new DataAccess();
        }

        private void AdminDashBoard_Load(object sender, EventArgs e)
        {
            var query = "select * from tbl_users where Role ='admin';";
            var dt = this.Data.ExecuteQueryTable(query);
            this.TotalAdmin = dt.Rows.Count;
            this.lblManagar.Text = this.TotalAdmin.ToString();



            var sql = "select * from tbl_users where Role ='employee';";
            var ds = this.Data.ExecuteQueryTable(sql);



            this.TotalEmployee = ds.Rows.Count;
            this.lblEmployee.Text = this.TotalEmployee.ToString();




            var sqle = "select sum([grandTotal]) from tbl_transactions;";
            var dst = this.Data.ExecuteQueryTable(sqle);

            if (dst.Rows[0][0] == DBNull.Value)
            {
                this.lblTotalIncome.Text = "$00";
            }

            else
            {

                this.TotalIncome = Convert.ToDouble(dst.Rows[0][0]);
                this.lblTotalIncome.Text = "$" + this.TotalIncome.ToString();

            }






            var sqleo = "select sum([grandTotal]) from tbl_transactions where transaction_date='" + this.dptToday.Value.ToString("dd/MM/yyyy") + "';";
            var dste = this.Data.ExecuteQueryTable(sqleo);

            if (dste.Rows[0][0] == DBNull.Value)
            {
                this.lblTodyIncome.Text = "$00";
            }


            else
            {
                this.TodayIncome = Convert.ToDouble(dste.Rows[0][0]);
                this.lblTodyIncome.Text = "$" + this.TodayIncome.ToString();
            }










        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void lblTodyIncome_Click(object sender, EventArgs e)
        {

        }
    }
}
