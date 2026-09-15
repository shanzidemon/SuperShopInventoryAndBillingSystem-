namespace ShopBillingSystem.UI
{
    partial class AdminAddEmpolyee
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            txtUserId = new TextBox();
            label4 = new Label();
            btnClear = new Button();
            btnDelete = new Button();
            btnSaveEmployeeData = new Button();
            dtpAddDate = new DateTimePicker();
            txtAddBy = new TextBox();
            label6 = new Label();
            cmbRole = new ComboBox();
            label5 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtUsername = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            lblInstructions3 = new Label();
            cbInstructions = new CheckBox();
            lblInstructions2 = new Label();
            lblInstructions1 = new Label();
            txtSeaech = new TextBox();
            btnSearch = new Button();
            dgvUser = new DataGridView();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Id = new DataGridViewTextBoxColumn();
            userName = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Role = new DataGridViewTextBoxColumn();
            Added_Date = new DataGridViewTextBoxColumn();
            Added_By = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(txtUserId);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnSaveEmployeeData);
            panel1.Controls.Add(dtpAddDate);
            panel1.Controls.Add(txtAddBy);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 676);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(31, 398);
            panel3.Name = "panel3";
            panel3.Size = new Size(20, 43);
            panel3.TabIndex = 24;
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(132, 60);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(216, 27);
            txtUserId.TabIndex = 23;
            txtUserId.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(37, 67);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 22;
            label4.Text = "User Id :";
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.DarkSeaGreen;
            btnClear.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(28, 544);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(283, 35);
            btnClear.TabIndex = 20;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkSeaGreen;
            btnDelete.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(200, 473);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 35);
            btnDelete.TabIndex = 19;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSaveEmployeeData
            // 
            btnSaveEmployeeData.BackColor = Color.DarkSeaGreen;
            btnSaveEmployeeData.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveEmployeeData.Location = new Point(28, 473);
            btnSaveEmployeeData.Name = "btnSaveEmployeeData";
            btnSaveEmployeeData.Size = new Size(111, 35);
            btnSaveEmployeeData.TabIndex = 17;
            btnSaveEmployeeData.Text = "Save";
            btnSaveEmployeeData.UseVisualStyleBackColor = false;
            btnSaveEmployeeData.Click += btnAddEmployeeData_Click;
            // 
            // dtpAddDate
            // 
            dtpAddDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAddDate.CustomFormat = "dd/MM/yyyy";
            dtpAddDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpAddDate.Location = new Point(37, 398);
            dtpAddDate.Name = "dtpAddDate";
            dtpAddDate.Size = new Size(10, 25);
            dtpAddDate.TabIndex = 16;
            // 
            // txtAddBy
            // 
            txtAddBy.Location = new Point(126, 337);
            txtAddBy.Name = "txtAddBy";
            txtAddBy.ReadOnly = true;
            txtAddBy.Size = new Size(216, 27);
            txtAddBy.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ButtonFace;
            label6.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 340);
            label6.Name = "label6";
            label6.Size = new Size(83, 20);
            label6.TabIndex = 14;
            label6.Text = "Add-By : ";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "admin", "employee" });
            cmbRole.Location = new Point(132, 267);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(216, 28);
            cmbRole.TabIndex = 11;
            cmbRole.SelectedIndexChanged += cmbRole_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 274);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 7;
            label5.Text = "Role :";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(132, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(216, 27);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 205);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 3;
            label3.Text = "Password :";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(132, 129);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 27);
            txtUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 136);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 1;
            label2.Text = "Username :";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblInstructions3);
            panel2.Controls.Add(cbInstructions);
            panel2.Controls.Add(lblInstructions2);
            panel2.Controls.Add(lblInstructions1);
            panel2.Controls.Add(txtSeaech);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(dgvUser);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(348, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(934, 679);
            panel2.TabIndex = 1;
            panel2.Click += panel2_Click;
            // 
            // lblInstructions3
            // 
            lblInstructions3.AutoSize = true;
            lblInstructions3.BackColor = Color.DarkSeaGreen;
            lblInstructions3.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions3.Location = new Point(660, 626);
            lblInstructions3.Name = "lblInstructions3";
            lblInstructions3.Size = new Size(211, 40);
            lblInstructions3.TabIndex = 14;
            lblInstructions3.Text = "Write Id in search bar\r\nAnd press Search button";
            lblInstructions3.Visible = false;
            // 
            // cbInstructions
            // 
            cbInstructions.AutoSize = true;
            cbInstructions.Location = new Point(765, 29);
            cbInstructions.Name = "cbInstructions";
            cbInstructions.Size = new Size(106, 24);
            cbInstructions.TabIndex = 12;
            cbInstructions.Text = "Instructions";
            cbInstructions.UseVisualStyleBackColor = true;
            cbInstructions.CheckedChanged += cbInstructions_CheckedChanged;
            // 
            // lblInstructions2
            // 
            lblInstructions2.AutoSize = true;
            lblInstructions2.BackColor = Color.DarkSeaGreen;
            lblInstructions2.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions2.Location = new Point(447, 605);
            lblInstructions2.Name = "lblInstructions2";
            lblInstructions2.Size = new Size(207, 60);
            lblInstructions2.TabIndex = 11;
            lblInstructions2.Text = "For delete a User\r\nSelect a row\r\nAnd press Delete button";
            lblInstructions2.Visible = false;
            // 
            // lblInstructions1
            // 
            lblInstructions1.AutoSize = true;
            lblInstructions1.BackColor = Color.DarkSeaGreen;
            lblInstructions1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInstructions1.Location = new Point(13, 585);
            lblInstructions1.Name = "lblInstructions1";
            lblInstructions1.Size = new Size(428, 80);
            lblInstructions1.TabIndex = 10;
            lblInstructions1.Text = "For update a User \r\nDouble click a row update information in text boxes\r\nAnd press Save button\r\n\r\n";
            lblInstructions1.Visible = false;
            // 
            // txtSeaech
            // 
            txtSeaech.Location = new Point(140, 24);
            txtSeaech.Name = "txtSeaech";
            txtSeaech.Size = new Size(486, 27);
            txtSeaech.TabIndex = 3;
            txtSeaech.TextChanged += txtSeaech_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSeaGreen;
            btnSearch.Location = new Point(632, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { Id, userName, Password, Role, Added_Date, Added_By });
            dgvUser.Location = new Point(13, 57);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(858, 522);
            dgvUser.TabIndex = 1;
            dgvUser.DoubleClick += dgvUser_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Arial Rounded MT Bold", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 21);
            label1.Name = "label1";
            label1.Size = new Size(121, 30);
            label1.TabIndex = 0;
            label1.Text = "Search Employee\r\n            By Id";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Id
            // 
            Id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Id.DataPropertyName = "Id";
            Id.HeaderText = "User Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // userName
            // 
            userName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            userName.DataPropertyName = "Name";
            userName.HeaderText = "User Name";
            userName.MinimumWidth = 6;
            userName.Name = "userName";
            userName.ReadOnly = true;
            // 
            // Password
            // 
            Password.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Role
            // 
            Role.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Role.DataPropertyName = "Role";
            Role.HeaderText = "User Role";
            Role.MinimumWidth = 6;
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Added_Date
            // 
            Added_Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Added_Date.DataPropertyName = "Added_Date";
            Added_Date.HeaderText = "Added Date";
            Added_Date.MinimumWidth = 6;
            Added_Date.Name = "Added_Date";
            Added_Date.ReadOnly = true;
            // 
            // Added_By
            // 
            Added_By.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Added_By.DataPropertyName = "Added_By";
            Added_By.HeaderText = "Added BY";
            Added_By.MinimumWidth = 6;
            Added_By.Name = "Added_By";
            Added_By.ReadOnly = true;
            // 
            // AdminAddEmpolyee
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(0);
            Name = "AdminAddEmpolyee";
            Size = new Size(1282, 679);
            Load += AdminAddEmpolyee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label5;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtUsername;
        private Label label2;
        private DataGridView dgvUser;
        private ComboBox cmbRole;
        private DateTimePicker dtpAddDate;
        private TextBox txtAddBy;
        private Label label6;
        private Button btnClear;
        private Button btnDelete;
        
        private Button btnSaveEmployeeData;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtSeaech;
        private Button btnSearch;
        private Label label4;
        private TextBox txtUserId;
        private Label lblInstructions1;
        private Label lblInstructions2;
        private CheckBox cbInstructions;
        private Label lblInstructions3;
        private Panel panel3;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn userName;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewTextBoxColumn Role;
        private DataGridViewTextBoxColumn Added_Date;
        private DataGridViewTextBoxColumn Added_By;
    }
}
