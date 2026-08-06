using Microsoft.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Employee_Management_System
{
    public partial class FrmEmployee : Form
    {

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-8GK8C8D\\SQLEXPRESS;Database=EmployeeDB;TrustServerCertificate=true;Integrated Security=True");

        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

            LoadSummary();
            cmbSearchBy.Items.Add("Employee ID");
            cmbSearchBy.Items.Add("Full Name");
            cmbSearchBy.SelectedIndex = 0;
            LoadEmployee();


        }
        private void LoadEmployee()
        {
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employees", con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvEmployees.DataSource = dt;

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                con.Close();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployee())
                return;
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO Employees (EmployeeId,FullName, Gender, Department, Salary, JoiningDate, Phone, Email, Status)VALUES(@EmployeeId,@FullName, @Gender, @Department, @Salary, @JoiningDate, @Phone, @Email, @Status)", con);

                cmd.Parameters.AddWithValue("@EmployeeID", txtEmployeeId.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@JoiningDate", dtpJoiningDate.Value);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                string status = "";

                if (rbActive.Checked)
                {
                    status = "Active";
                }
                else if (rbInactive.Checked)
                {
                    status = "Inactive";
                }
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Employee Added Successfully.");
                LoadEmployee();


                LoadSummary();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployees.Rows[e.RowIndex];

                txtEmployeeId.Text = row.Cells["EmployeeId"].Value.ToString();
                txtFullName.Text = row.Cells["FullName"].Value.ToString();
                cmbGender.Text = row.Cells["Gender"].Value.ToString();
                cmbDepartment.Text = row.Cells["Department"].Value.ToString();
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
                dtpJoiningDate.Value = Convert.ToDateTime(row.Cells["JoiningDate"].Value);
                txtPhone.Text = row.Cells["Phone"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                if (row.Cells["Status"].Value.ToString() == "Active")
                    rbActive.Checked = true;
                else
                    rbInactive.Checked = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployee())
                return;
            try
            {
                con.Open();

                string status = rbActive.Checked ? "Active" : "Inactive";

                SqlCommand cmd = new SqlCommand(
                @"UPDATE Employees
                SET EmployeeId = @EmployeeId,
                FullName=@FullName,
                Gender=@Gender,
                Department=@Department,
                Salary=@Salary,
                JoiningDate=@JoiningDate,
                Phone=@Phone,
                Email=@Email,
                Status=@Status
                WHERE EmployeeId=@EmployeeId", con);

                cmd.Parameters.AddWithValue("@EmployeeId", txtEmployeeId.Text);
                cmd.Parameters.AddWithValue("@FullName", txtFullName.Text);
                cmd.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmd.Parameters.AddWithValue("@Department", cmbDepartment.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDecimal(txtSalary.Text));
                cmd.Parameters.AddWithValue("@JoiningDate", dtpJoiningDate.Value);
                cmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@Status", status);

                cmd.ExecuteNonQuery();
                con.Close();
                LoadSummary();
                MessageBox.Show("Employee Updated Successfully");



                LoadEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmployeeId.Text == "")
                {
                    MessageBox.Show("Please Select Employee First.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this employee?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeId=@EmployeeId", con);

                    cmd.Parameters.AddWithValue("@EmployeeId", txtEmployeeId.Text);

                    cmd.ExecuteNonQuery();

                    con.Close();

                    MessageBox.Show("Employee Deleted Successfully.");

                    LoadEmployee();

                    LoadSummary();
                    ClearData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }

        }
        private void ClearData()
        {
            txtEmployeeId.Clear();
            txtFullName.Clear();
            cmbGender.SelectedIndex = -1;
            cmbDepartment.SelectedIndex = -1;
            txtSalary.Clear();
            dtpJoiningDate.Value = DateTime.Now;
            txtPhone.Clear();
            txtEmail.Clear();

            rbActive.Checked = false;
            rbInactive.Checked = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                string query = "";

                if (cmbSearchBy.Text == "Employee ID")
                {
                    query = "SELECT * FROM Employees WHERE EmployeeId = @Search";
                }
                else if (cmbSearchBy.Text == "Full Name")
                {
                    query = "SELECT * FROM Employees WHERE FullName LIKE @Search";
                }

                SqlCommand cmd = new SqlCommand(query, con);

                if (cmbSearchBy.Text == "Full Name")
                {
                    cmd.Parameters.AddWithValue("@Search", "%" + txtSearch.Text + "%");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Search", txtSearch.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvEmployees.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private void LoadSummary()
        {
            try
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM Employees", con);
                lblTotalEmpValue.Text = cmd1.ExecuteScalar().ToString();

                SqlCommand cmd2 = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Status='Active'", con);
                lblActiveEmpValue.Text = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd3 = new SqlCommand("SELECT COUNT(*) FROM Employees WHERE Status='Inactive'", con);
                lblInactiveEmpValue.Text = cmd3.ExecuteScalar().ToString();

                SqlCommand cmd4 = new SqlCommand("SELECT COUNT(DISTINCT Department) FROM Employees", con);
                lblDepartmentValue.Text = cmd4.ExecuteScalar().ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }
        private bool ValidateEmployee()
        {
            // Employee Name
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter employee name.");
                txtFullName.Focus();
                return false;
            }

            if (!Regex.IsMatch(txtFullName.Text.Trim(), @"^[A-Za-z ]+$"))
            {
                MessageBox.Show("Employee name should contain only letters.");
                txtFullName.Focus();
                return false;
            }

            // Gender
            if (cmbGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please select gender.");
                cmbGender.Focus();
                return false;
            }

            // Department
            if (cmbDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please select department.");
                cmbDepartment.Focus();
                return false;
            }

            // Salary
            decimal salary;

            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                MessageBox.Show("Please enter salary.");
                txtSalary.Focus();
                return false;
            }

            if (!decimal.TryParse(txtSalary.Text, out salary))
            {
                MessageBox.Show("Salary must be numeric.");
                txtSalary.Focus();
                return false;
            }

            if (salary <= 0)
            {
                MessageBox.Show("Salary must be greater than 0.");
                txtSalary.Focus();
                return false;
            }

            // Phone
            if (!Regex.IsMatch(txtPhone.Text.Trim(), @"^[6-9][0-9]{9}$"))
            {
                MessageBox.Show("Please enter a valid 10-digit mobile number.");
                txtPhone.Focus();
                return false;
            }

            // Email
            if (!Regex.IsMatch(txtEmail.Text.Trim(),
                @"^[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Focus();
                return false;
            }

            // Status
            if (!rbActive.Checked && !rbInactive.Checked)
            {
                MessageBox.Show("Please select employee status.");
                return false;
            }

            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Are you sure you want to exit?",
               "Exit",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
