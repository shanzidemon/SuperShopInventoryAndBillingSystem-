using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class EmployeeDashboard : UserControl
    {
        private double TotalSales { get; set; }
        private int TotalOrders { get; set; }
        private int TotalProducts { get; set; }
        private int TotalCategories { get; set; }
        private DataAccess Data { get; set; }

        public EmployeeDashboard()
        {
            InitializeComponent();
            this.Data = new DataAccess();
        }

        private void EmployeeDashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void EmployeeDashboard_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadDashboardData();
            }
        }

        private void LoadDashboardData()
        {
            try
            {
                var sql1 = "SELECT SUM(grandTotal) FROM tbl_transactions;";
                var dt1 = this.Data.ExecuteQueryTable(sql1);

                if (dt1.Rows.Count > 0 && dt1.Rows[0][0] == DBNull.Value)
                {
                    this.lblTotalSalesCount.Text = "$00";
                }
                else if (dt1.Rows.Count > 0)
                {
                    this.TotalSales = Convert.ToDouble(dt1.Rows[0][0]);
                    this.lblTotalSalesCount.Text = "$" + this.TotalSales.ToString();
                }

                var sql2 = "SELECT COUNT(*) FROM tbl_transactions;";
                var dt2 = this.Data.ExecuteQueryTable(sql2);
                if (dt2.Rows.Count > 0)
                {
                    this.TotalOrders = Convert.ToInt32(dt2.Rows[0][0]);
                    this.lblTotalOrdersCount.Text = this.TotalOrders.ToString();
                }

                var sql3 = "SELECT COUNT(*) FROM tbl_products;";
                var dt3 = this.Data.ExecuteQueryTable(sql3);
                if (dt3.Rows.Count > 0)
                {
                    this.TotalProducts = Convert.ToInt32(dt3.Rows[0][0]);
                    this.lblTotalProductsCount.Text = this.TotalProducts.ToString();
                }

                var sql4 = "SELECT COUNT(*) FROM tbl_categories;";
                var dt4 = this.Data.ExecuteQueryTable(sql4);
                if (dt4.Rows.Count > 0)
                {
                    this.TotalCategories = Convert.ToInt32(dt4.Rows[0][0]);
                    this.lblTotalCategoriesCount.Text = this.TotalCategories.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occured.\n" + exc.Message);
            }
        }
    }
}
