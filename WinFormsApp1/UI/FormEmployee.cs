using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1;

namespace ShopBillingSystem.UI
{
    public partial class FormEmployee : Form
    {
        private FormLogin Fl { get; set; }


        public FormEmployee(string name, FormLogin fl)
        {
            InitializeComponent();
            this.lblUserName.Text += name;
            this.Fl = fl;
            this.employeeProfile1.SetUserName(name);
            this.employeeSales1.SetEmployeeName(name);
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            
            employeeDashboard1.Visible = true;
            employeeSales1.Visible = false;
            employeeProfile1.Visible = false;
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            employeeDashboard1.Visible = true;
            employeeSales1.Visible = false;
            employeeProfile1.Visible = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            employeeDashboard1.Visible = false;
            employeeSales1.Visible = true;
            employeeProfile1.Visible = false;
        }

        private void btnAddEmoloyee_Click(object sender, EventArgs e)
        {
            employeeDashboard1.Visible = false;
            employeeSales1.Visible = false;
            employeeProfile1.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.Fl.Show();
        }

        private void FormEmployee_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void employeeDashboard1_Load(object sender, EventArgs e)
        {

        }
    }
}
