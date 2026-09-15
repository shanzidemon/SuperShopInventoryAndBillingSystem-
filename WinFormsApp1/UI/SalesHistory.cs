using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShopBillingSystem.UI
{
    public partial class SalesHistory : UserControl
    {
        private DataAccess Data { get; set; }
        public SalesHistory()
        {
            InitializeComponent();
            this.Data = new DataAccess();
            this.TransactionGridView();

        }


        private void TransactionGridView(string sql = "select * from tbl_Transactions;")
        {
            DataSet ds = this.Data.ExecuteQuery(sql);

            this.dgvTransaction.AutoGenerateColumns = false;
            this.dgvTransaction.DataSource = ds.Tables[0];
        }



        private void FilterTransaction()
        {
            string paymentType = cmbType.SelectedItem.ToString();

            string sql = "select * from tbl_transactions where 1=1";


            if (txtTransaction.Text != "")
            {
                sql += " and transaction_date = '" + txtTransaction.Text + "'";
            }


            if (paymentType != "All")
            {
                sql += " and type = '" + paymentType + "'";
            }

            this.TransactionGridView(sql);
        }








        private void btnSearchTransaction_Click(object sender, EventArgs e)
        {
            this.FilterTransaction();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.dgvTransaction.ClearSelection();
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FilterTransaction();
        }

        private void cbInstructions_CheckedChanged(object sender, EventArgs e)
        {
            if (this.cbInstructions.Checked)
            {

                this.lblInstructions3.Visible = true;

            }
            else
            {

                this.lblInstructions3.Visible = false;
            }
        }

        private void SalesHistory_Load(object sender, EventArgs e)
        {
            this.dgvTransaction.ClearSelection();
        }
    }
}
