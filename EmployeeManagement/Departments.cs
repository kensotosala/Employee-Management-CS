namespace EmployeeManagement
{
    public partial class Departments : Form
    {
        // Object "Con"
        private Functions Con;

        // This function lists the departments in the database.
        public Departments()
        {
            // Initializes the components.
            InitializeComponent();
            // Creates a new Functions object.
            Con = new Functions();
            // Show the departments.
            ShowDepartments();
        }

        // This function lists the departments in the database.
        private void ShowDepartments()
        {
            // The SQL query to select all departments.
            string Query = "Select * from DepartmentTbl";
            // Sets the DataSource of the ListView to the results of the query.
            DepList.DataSource = Con.GetData(Query);
        }

        // This method is an event handler for the click event of the AddBtn control.
        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if the department name is empty.
                if (DepNameTb.Text == "")
                {
                    // Shows a message box indicating missing data.
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    // Gets the department name from the text box.
                    string Dep = DepNameTb.Text;
                    // Creates the SQL query to insert the department.
                    string Query = "Insert into DepartmentTbl values ('{0}')";
                    // Formats the query with the department name.
                    Query = string.Format(Query, Dep);
                    // Executes the query by calling the SetData method from the Con object.
                    Con.SetData(Query);
                    // Calls the ShowDepartments method to update the displayed departments.
                    ShowDepartments();
                    // Shows a message box indicating successful addition of the department.
                    MessageBox.Show("Department Added!!!");
                    // Clears the text box for the department name.
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                // Displays an error message box if an exception occurs during the process.
                MessageBox.Show(Ex.Message);
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Checks if the department name is empty.
                if (DepNameTb.Text == "")
                {
                    // Shows a message box indicating missing data.
                    MessageBox.Show("Missing Data!!!");
                }
                else
                {
                    // Gets the department name from the text box.
                    string Dep = DepNameTb.Text;
                    // Creates the SQL query to update the department.
                    string Query = "UPDATE DepartmentTbl SET DepName = '{0}' WHERE DepId = {1}";
                    // Formats the query with the department name.
                    Query = string.Format(Query, Dep, Key);
                    // Executes the query by calling the SetData method from the Con object.
                    Con.SetData(Query);
                    // Calls the ShowDepartments method to update the displayed departments.
                    ShowDepartments();
                    // Shows a message box indicating successful update of the department.
                    MessageBox.Show("Department Updated!!!");
                    // Clears the text box for the department name.
                    DepNameTb.Text = "";
                }
            }
            catch (Exception Ex)
            {
                // Displays an error message box if an exception occurs during the process.
                MessageBox.Show(Ex.Message);
            }
        }

        // Initializes an integer variable to hold a key value.
        private int Key = 0;

        // This method is an event handler for the CellContentClick event of the DepList DataGridView.
        private void DepList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Sets the text of the DepNameTb TextBox to the value of the selected cell in the second column of the selected row.
            DepNameTb.Text = DepList.SelectedRows[0].Cells[1].Value.ToString();

            // Checks if the department name is empty.
            if (DepNameTb.Text == "")
            {
                // If the department name is empty, sets the Key to 0.
                Key = 0;
            }
            else
            {
                // If the department name is not empty, converts the value of the first cell in the selected row (assumed to be an integer) to an integer and assigns it to the Key.
                Key = Convert.ToInt32(DepList.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }
    }
}