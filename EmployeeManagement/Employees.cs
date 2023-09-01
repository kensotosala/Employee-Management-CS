namespace EmployeeManagement
{
    public partial class Employess : Form
    {
        // Object "Con"
        private Functions Con;

        public Employess()
        {
            InitializeComponent();
            Con = new Functions();
            // Show the Employees.
            ShowEmployees();
            GetDepartments();
        }

        // This function lists the Employees in the database.
        private void ShowEmployees()
        {
            // The SQL query to select all Employees.
            string Query = "Select * from EmployeeTbl";
            // Sets the DataSource of the ListView to the results of the query.
            dgvEmployees.DataSource = Con.GetData(Query);
        }

        private void GetDepartments()
        {
            string Query = "SELECT * FROM DepartmentTbl";
            var departments = Con.GetData(Query);

            cbxEmpDepartment.DisplayMember = "DepName";
            cbxEmpDepartment.ValueMember = "DepId";
            cbxEmpDepartment.DataSource = departments;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if the Employee name is empty.
                if (string.IsNullOrEmpty(EmpNameTb.Text) || cbxGender.SelectedIndex == -1 || cbxEmpDepartment.SelectedIndex == -1 || string.IsNullOrEmpty(txbDailySalary.Text))
                {
                    // Shows a message box indicating missing data.
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    // Gets the values from the text box.
                    string Name = EmpNameTb.Text;
                    string Gender = cbxGender.SelectedItem?.ToString() ?? "";
                    int Department = Convert.ToInt32(cbxEmpDepartment.SelectedValue.ToString());
                    string DOB = dtpDOB.Value.ToString("yyyy-MM-dd");
                    string JDate = dtpJoinDate.Value.ToString("yyyy-MM-dd");
                    int Salary = Convert.ToInt32(txbDailySalary.Text);

                    // Creates the SQL query to insert the Employee.
                    string Query = $"INSERT INTO EmployeeTbl (EmpName, EmpGen, EmpDep, EmpDOB, EmpJDate, EmpSal) VALUES ('{Name}', '{Gender}', {Department}, '{DOB}', '{JDate}', {Salary})";

                    // Execute the query and get the number of rows affected.
                    int rowsAffected = Con.SetData(Query);

                    if (rowsAffected > 0)
                    {
                        ShowEmployees();
                        // Shows a message box indicating successful addition of the Employee.
                        MessageBox.Show("Employee Added!!!");

                        // Clears the text for each component.
                        EmpNameTb.Text = "";
                        cbxGender.SelectedIndex = -1;
                        cbxEmpDepartment.SelectedIndex = -1;
                        txbDailySalary.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Failed to add Employee.");
                    }
                }
            }
            catch (Exception Ex)
            {
                // Displays an error message box if an exception occurs during the process.
                MessageBox.Show(Ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView.
                if (dgvEmployees.SelectedRows.Count > 0)
                {
                    // Get the selected row.
                    DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];

                    // Get the value in a specific column of the selected row (assuming you want to use a column for identification).
                    int employeeId = Convert.ToInt32(selectedRow.Cells["EmpId"].Value);

                    // Create a SQL query to delete the row from the database based on the identified value.
                    string query = $"DELETE FROM EmployeeTbl WHERE EmpId = {employeeId}";

                    // Execute the delete query and get the number of rows affected.
                    int rowsAffected = Con.SetData(query);

                    if (rowsAffected > 0)
                    {
                        // Delete the selected row from the DataGridView.
                        dgvEmployees.Rows.Remove(selectedRow);

                        // Show a success message.
                        MessageBox.Show("Employee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the Employee.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a Employee to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected in the DataGridView.
                if (dgvEmployees.SelectedRows.Count > 0)
                {


                    // Fix the code with Department


                    // Get the selected row.
                    DataGridViewRow selectedRow = dgvEmployees.SelectedRows[0];

                    // Get the value in the "EmployeeID" column of the selected row.
                    int employeeId = Convert.ToInt32(selectedRow.Cells["EmpId"].Value);

                    // Get the updated values from your input controls (textboxes, combo boxes, etc.).
                    string updatedName = EmpNameTb.Text;
                    string updatedGender = cbxGender.SelectedItem?.ToString() ?? "";
                    int updatedDepartment = Convert.ToInt32(cbxEmpDepartment.SelectedValue.ToString());
                    string updatedDOB = dtpDOB.Value.ToString("yyyy-MM-dd");
                    string updatedJDate = dtpJoinDate.Value.ToString("yyyy-MM-dd");
                    int updatedSalary = Convert.ToInt32(txbDailySalary.Text);

                    // Create a SQL query to update the row in the database.
                    string query = $"UPDATE EmployeeTbl SET EmpName = '{updatedName}', EmpGen = '{updatedGender}', EmpDep = {updatedDepartment}, EmpDOB = '{updatedDOB}', EmpJDate = '{updatedJDate}', EmpSal = {updatedSalary} WHERE EmpId = {employeeId}";

                    // Execute the update query and get the number of rows affected.
                    int rowsAffected = Con.SetData(query);

                    if (rowsAffected > 0)
                    {
                        // Update the selected row in the DataGridView with the new values.
                        selectedRow.Cells["NameColumn"].Value = updatedName;
                        selectedRow.Cells["GenderColumn"].Value = updatedGender;
                        selectedRow.Cells["DepartmentColumn"].Value = updatedDepartment;
                        selectedRow.Cells["DOBColumn"].Value = updatedDOB;
                        selectedRow.Cells["JDateColumn"].Value = updatedJDate;
                        selectedRow.Cells["SalaryColumn"].Value = updatedSalary;

                        // Show a success message.
                        MessageBox.Show("Employee updated successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the employee.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a employee to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

    }
}