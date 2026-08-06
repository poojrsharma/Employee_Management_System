namespace Employee_Management_System
{
    partial class FrmEmployee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            pnlHeader = new Panel();
            grpEmployeeInfo = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            rbInactive = new RadioButton();
            rbActive = new RadioButton();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            dtpJoiningDate = new DateTimePicker();
            txtSalary = new TextBox();
            cmbDepartment = new ComboBox();
            cmbGender = new ComboBox();
            txtFullName = new TextBox();
            txtEmployeeId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            grpSearch = new GroupBox();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cmbSearchBy = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            grpSummary = new GroupBox();
            lblDepartmentValue = new Label();
            lblInactiveEmpValue = new Label();
            lblActiveEmpValue = new Label();
            lblTotalEmpValue = new Label();
            lblTotalDepartments = new Label();
            lblInactiveEmployees = new Label();
            lblActiveEmployees = new Label();
            lblTotalEmployees = new Label();
            grpEmployeeList = new GroupBox();
            dgvEmployees = new DataGridView();
            pnlHeader.SuspendLayout();
            grpEmployeeInfo.SuspendLayout();
            grpSearch.SuspendLayout();
            grpSummary.SuspendLayout();
            grpEmployeeList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(411, 19);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(461, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "EMPLOYEE MANAGEMENT SYSTEM";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.RoyalBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(2);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1234, 70);
            pnlHeader.TabIndex = 1;
            // 
            // grpEmployeeInfo
            // 
            grpEmployeeInfo.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grpEmployeeInfo.Controls.Add(btnExit);
            grpEmployeeInfo.Controls.Add(btnClear);
            grpEmployeeInfo.Controls.Add(btnDelete);
            grpEmployeeInfo.Controls.Add(btnUpdate);
            grpEmployeeInfo.Controls.Add(btnAdd);
            grpEmployeeInfo.Controls.Add(rbInactive);
            grpEmployeeInfo.Controls.Add(rbActive);
            grpEmployeeInfo.Controls.Add(txtEmail);
            grpEmployeeInfo.Controls.Add(txtPhone);
            grpEmployeeInfo.Controls.Add(dtpJoiningDate);
            grpEmployeeInfo.Controls.Add(txtSalary);
            grpEmployeeInfo.Controls.Add(cmbDepartment);
            grpEmployeeInfo.Controls.Add(cmbGender);
            grpEmployeeInfo.Controls.Add(txtFullName);
            grpEmployeeInfo.Controls.Add(txtEmployeeId);
            grpEmployeeInfo.Controls.Add(label9);
            grpEmployeeInfo.Controls.Add(label8);
            grpEmployeeInfo.Controls.Add(label7);
            grpEmployeeInfo.Controls.Add(label6);
            grpEmployeeInfo.Controls.Add(label5);
            grpEmployeeInfo.Controls.Add(label4);
            grpEmployeeInfo.Controls.Add(label3);
            grpEmployeeInfo.Controls.Add(label2);
            grpEmployeeInfo.Controls.Add(label1);
            grpEmployeeInfo.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployeeInfo.ForeColor = Color.Navy;
            grpEmployeeInfo.Location = new Point(11, 74);
            grpEmployeeInfo.Margin = new Padding(2);
            grpEmployeeInfo.Name = "grpEmployeeInfo";
            grpEmployeeInfo.Padding = new Padding(2);
            grpEmployeeInfo.Size = new Size(577, 404);
            grpEmployeeInfo.TabIndex = 2;
            grpEmployeeInfo.TabStop = false;
            grpEmployeeInfo.Text = "Employee Information";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DimGray;
            btnExit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(473, 350);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(90, 38);
            btnExit.TabIndex = 27;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Orange;
            btnClear.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(364, 350);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(90, 38);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(251, 350);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 38);
            btnDelete.TabIndex = 25;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DodgerBlue;
            btnUpdate.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(143, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 38);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.Transparent;
            btnAdd.Location = new Point(35, 350);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 38);
            btnAdd.TabIndex = 23;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbInactive.ForeColor = Color.Black;
            rbInactive.Location = new Point(237, 308);
            rbInactive.Name = "rbInactive";
            rbInactive.Size = new Size(82, 24);
            rbInactive.TabIndex = 22;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rbActive.ForeColor = Color.Black;
            rbActive.Location = new Point(150, 308);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(71, 24);
            rbActive.TabIndex = 21;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(150, 272);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 27);
            txtEmail.TabIndex = 19;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(150, 239);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 27);
            txtPhone.TabIndex = 18;
            // 
            // dtpJoiningDate
            // 
            dtpJoiningDate.Format = DateTimePickerFormat.Short;
            dtpJoiningDate.Location = new Point(150, 204);
            dtpJoiningDate.Name = "dtpJoiningDate";
            dtpJoiningDate.Size = new Size(261, 27);
            dtpJoiningDate.TabIndex = 17;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(150, 169);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(261, 27);
            txtSalary.TabIndex = 16;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Items.AddRange(new object[] { "HR", "IT", "Finance", "Sales", "Marketing", "Support" });
            cmbDepartment.Location = new Point(150, 134);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(261, 28);
            cmbDepartment.TabIndex = 15;
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "", "Male", "Female", "Other" });
            cmbGender.Location = new Point(150, 98);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(261, 28);
            cmbGender.TabIndex = 14;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(150, 65);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(338, 27);
            txtFullName.TabIndex = 13;
            // 
            // txtEmployeeId
            // 
            txtEmployeeId.BackColor = Color.WhiteSmoke;
            txtEmployeeId.Location = new Point(150, 28);
            txtEmployeeId.Name = "txtEmployeeId";
            txtEmployeeId.Size = new Size(261, 27);
            txtEmployeeId.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(33, 308);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 11;
            label9.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(33, 270);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 10;
            label8.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(33, 239);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 9;
            label7.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(33, 204);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 8;
            label6.Text = "Joining Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 169);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 7;
            label5.Text = "Salary";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 134);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 6;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 70);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 4;
            label2.Text = "Full Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 35);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 3;
            label1.Text = "Employee ID";
            // 
            // grpSearch
            // 
            grpSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpSearch.Controls.Add(btnSearch);
            grpSearch.Controls.Add(txtSearch);
            grpSearch.Controls.Add(cmbSearchBy);
            grpSearch.Controls.Add(label11);
            grpSearch.Controls.Add(label10);
            grpSearch.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSearch.ForeColor = Color.Navy;
            grpSearch.Location = new Point(622, 74);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(600, 175);
            grpSearch.TabIndex = 3;
            grpSearch.TabStop = false;
            grpSearch.Text = "Search Employee";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.RoyalBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(341, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(148, 32);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(161, 79);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(328, 27);
            txtSearch.TabIndex = 3;
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Location = new Point(161, 35);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new Size(328, 28);
            cmbSearchBy.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(57, 82);
            label11.Name = "label11";
            label11.Size = new Size(89, 20);
            label11.TabIndex = 1;
            label11.Text = "Search Text";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(57, 38);
            label10.Name = "label10";
            label10.Size = new Size(77, 20);
            label10.TabIndex = 0;
            label10.Text = "Search By";
            // 
            // grpSummary
            // 
            grpSummary.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            grpSummary.Controls.Add(lblDepartmentValue);
            grpSummary.Controls.Add(lblInactiveEmpValue);
            grpSummary.Controls.Add(lblActiveEmpValue);
            grpSummary.Controls.Add(lblTotalEmpValue);
            grpSummary.Controls.Add(lblTotalDepartments);
            grpSummary.Controls.Add(lblInactiveEmployees);
            grpSummary.Controls.Add(lblActiveEmployees);
            grpSummary.Controls.Add(lblTotalEmployees);
            grpSummary.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpSummary.ForeColor = Color.Navy;
            grpSummary.Location = new Point(622, 264);
            grpSummary.Name = "grpSummary";
            grpSummary.Size = new Size(600, 214);
            grpSummary.TabIndex = 4;
            grpSummary.TabStop = false;
            grpSummary.Text = "Summary";
            // 
            // lblDepartmentValue
            // 
            lblDepartmentValue.AutoSize = true;
            lblDepartmentValue.ForeColor = Color.FromArgb(0, 192, 192);
            lblDepartmentValue.Location = new Point(194, 151);
            lblDepartmentValue.Name = "lblDepartmentValue";
            lblDepartmentValue.Size = new Size(18, 20);
            lblDepartmentValue.TabIndex = 7;
            lblDepartmentValue.Text = "0";
            // 
            // lblInactiveEmpValue
            // 
            lblInactiveEmpValue.AutoSize = true;
            lblInactiveEmpValue.ForeColor = Color.FromArgb(255, 128, 0);
            lblInactiveEmpValue.Location = new Point(190, 118);
            lblInactiveEmpValue.Name = "lblInactiveEmpValue";
            lblInactiveEmpValue.Size = new Size(18, 20);
            lblInactiveEmpValue.TabIndex = 6;
            lblInactiveEmpValue.Text = "0";
            // 
            // lblActiveEmpValue
            // 
            lblActiveEmpValue.AutoSize = true;
            lblActiveEmpValue.ForeColor = Color.Green;
            lblActiveEmpValue.Location = new Point(190, 85);
            lblActiveEmpValue.Name = "lblActiveEmpValue";
            lblActiveEmpValue.Size = new Size(18, 20);
            lblActiveEmpValue.TabIndex = 5;
            lblActiveEmpValue.Text = "0";
            // 
            // lblTotalEmpValue
            // 
            lblTotalEmpValue.AutoSize = true;
            lblTotalEmpValue.ForeColor = Color.Red;
            lblTotalEmpValue.Location = new Point(190, 56);
            lblTotalEmpValue.Name = "lblTotalEmpValue";
            lblTotalEmpValue.Size = new Size(18, 20);
            lblTotalEmpValue.TabIndex = 4;
            lblTotalEmpValue.Text = "0";
            // 
            // lblTotalDepartments
            // 
            lblTotalDepartments.AutoSize = true;
            lblTotalDepartments.ForeColor = Color.FromArgb(0, 192, 192);
            lblTotalDepartments.Location = new Point(40, 151);
            lblTotalDepartments.Name = "lblTotalDepartments";
            lblTotalDepartments.Size = new Size(148, 20);
            lblTotalDepartments.TabIndex = 3;
            lblTotalDepartments.Text = "Total Departments :";
            // 
            // lblInactiveEmployees
            // 
            lblInactiveEmployees.AutoSize = true;
            lblInactiveEmployees.ForeColor = Color.FromArgb(255, 128, 0);
            lblInactiveEmployees.Location = new Point(39, 120);
            lblInactiveEmployees.Name = "lblInactiveEmployees";
            lblInactiveEmployees.Size = new Size(151, 20);
            lblInactiveEmployees.TabIndex = 2;
            lblInactiveEmployees.Text = "Inactive Employees :";
            // 
            // lblActiveEmployees
            // 
            lblActiveEmployees.AutoSize = true;
            lblActiveEmployees.ForeColor = Color.Green;
            lblActiveEmployees.Location = new Point(40, 89);
            lblActiveEmployees.Name = "lblActiveEmployees";
            lblActiveEmployees.Size = new Size(140, 20);
            lblActiveEmployees.TabIndex = 1;
            lblActiveEmployees.Text = "Active Employees :";
            // 
            // lblTotalEmployees
            // 
            lblTotalEmployees.AutoSize = true;
            lblTotalEmployees.ForeColor = Color.Red;
            lblTotalEmployees.Location = new Point(39, 56);
            lblTotalEmployees.Name = "lblTotalEmployees";
            lblTotalEmployees.Size = new Size(131, 20);
            lblTotalEmployees.TabIndex = 0;
            lblTotalEmployees.Text = "Total Employees :";
            // 
            // grpEmployeeList
            // 
            grpEmployeeList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpEmployeeList.Controls.Add(dgvEmployees);
            grpEmployeeList.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmployeeList.ForeColor = Color.Navy;
            grpEmployeeList.Location = new Point(12, 483);
            grpEmployeeList.Name = "grpEmployeeList";
            grpEmployeeList.Size = new Size(1210, 166);
            grpEmployeeList.TabIndex = 5;
            grpEmployeeList.TabStop = false;
            grpEmployeeList.Text = "Employee List";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.Fixed3D;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(3, 23);
            dgvEmployees.MultiSelect = false;
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployees.Size = new Size(1204, 140);
            dgvEmployees.TabIndex = 0;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // FrmEmployee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1234, 661);
            Controls.Add(grpEmployeeList);
            Controls.Add(grpSummary);
            Controls.Add(grpSearch);
            Controls.Add(grpEmployeeInfo);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimizeBox = false;
            Name = "FrmEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee Management System";
            WindowState = FormWindowState.Maximized;
            Load += FrmEmployee_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpEmployeeInfo.ResumeLayout(false);
            grpEmployeeInfo.PerformLayout();
            grpSearch.ResumeLayout(false);
            grpSearch.PerformLayout();
            grpSummary.ResumeLayout(false);
            grpSummary.PerformLayout();
            grpEmployeeList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private Panel pnlHeader;
        private GroupBox grpEmployeeInfo;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEmployeeId;
        private TextBox txtFullName;
        private ComboBox cmbGender;
        private ComboBox cmbDepartment;
        private DateTimePicker dtpJoiningDate;
        private TextBox txtSalary;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private RadioButton rbInactive;
        private RadioButton rbActive;
        private Button btnExit;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox grpSearch;
        private TextBox txtSearch;
        private ComboBox cmbSearchBy;
        private Label label11;
        private Label label10;
        private Button btnSearch;
        private GroupBox grpSummary;
        private Label lblTotalDepartments;
        private Label lblInactiveEmployees;
        private Label lblActiveEmployees;
        private Label lblTotalEmployees;
        private Label lblDepartmentValue;
        private Label lblInactiveEmpValue;
        private Label lblActiveEmpValue;
        private Label lblTotalEmpValue;
        private GroupBox grpEmployeeList;
        private DataGridView dgvEmployees;
    }
}
