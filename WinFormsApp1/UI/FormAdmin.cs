using WinFormsApp1;

namespace ShopBillingSystem.UI
{
    public partial class FormAdmin : Form
    {
        private FormLogin Fl { get; set; }


        public FormAdmin()
        {
            InitializeComponent();
        }

        string UserId {  get; set; }
        public FormAdmin(string name,string userId, FormLogin fl) : this()
        {
            this.lblUserName.Text += name;
            this.UserId=userId;
            this.Fl = fl;


            this.adminAddProducts1.SetUserId(this.UserId);
            this.adminAddCategory1.SetUserId(this.UserId);
            this.adminAddEmpolyee1.SetUserId(this.UserId);

        }




        private void btnAddEmoloyee_Click(object sender, EventArgs e)
        {
            adminAddCategory1.Visible = false;
            adminAddEmpolyee1.Visible = true;
            adminAddProducts1.Visible = false;
            adminDashBoard1.Visible = false;
            salesHistory1.Visible = false;
           
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Logged out from the system");
            this.Fl.Show();

        }


        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            adminAddCategory1.Visible = false;
            adminAddEmpolyee1.Visible = false;
            adminAddProducts1.Visible = true;
            adminDashBoard1.Visible = false;
            salesHistory1.Visible = false;


        }




        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            adminAddCategory1.Visible = false;
            adminAddEmpolyee1.Visible = false;
            adminAddProducts1.Visible = false;
            adminDashBoard1.Visible = true;
            salesHistory1.Visible = false;



        }



        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            adminAddCategory1.Visible = true;
            adminAddEmpolyee1.Visible = false;
            adminAddProducts1.Visible = false;
            adminDashBoard1.Visible = false;
            salesHistory1.Visible = false;



        }



        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pnlMain_Click(object sender, EventArgs e)
        {

        }

        private void btnSalesHistory_Click(object sender, EventArgs e)
        {
            adminAddCategory1.Visible = false;
            adminAddEmpolyee1.Visible = false;
            adminAddProducts1.Visible = false;
            adminDashBoard1.Visible = false;
            salesHistory1.Visible = true;


        }
    }
}
