using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class FourmRecipt : Form
    {




        private DataAccess Data { get; set; }
        private int transactionId;

        public FourmRecipt(int transactionId)
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.transactionId = transactionId;
            this.Text = "Receipt - Transaction #" + transactionId;
            this.ItemGridView();
            this.TotalGridView();
        }

        

        private void ItemGridView()
        {
            string sql = "select * from tbl_transaction_detail where transactionId=" + this.transactionId;

            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dvgItems.AutoGenerateColumns = false;
            this.dvgItems.DataSource = ds.Tables[0];
        }

        private void TotalGridView()
        {
            string sql = "select * from tbl_transactions where id=" + this.transactionId;

            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dvgTotal.AutoGenerateColumns = false;
            this.dvgTotal.DataSource = ds.Tables[0];





        }
       
        
        private void FourmRecipt_Load(object sender, EventArgs e)
        {
            this.dvgItems.ClearSelection();
            this.dvgTotal.ClearSelection();


        }
    }
}
