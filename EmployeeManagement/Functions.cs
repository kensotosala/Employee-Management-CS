using System.Data;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    internal class Functions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter sda;
        private string ConStr;

        //This function initializes the database connection.
        public Functions()
        {
            // The connection string for the database
            ConStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\steve\Documents\emsDB.mdf;Integrated Security=True;Connect Timeout=30";
            // Creates a new SqlConnection object
            Con = new SqlConnection(ConStr);
            // Creates a new SqlCommnad Object
            Cmd = new SqlCommand();
            // Sets the connection for the SqlCommand Object
            Cmd.Connection = Con;
        }

        // This function gets data from the database and returns it as a DataTable object.
        // <param name="Query">The SQL query to execute.</param>
        public DataTable GetData(string Query)
        {
            // Creates a new DataTable Object
            dt = new DataTable();
            // Creates a new SqlDataAdapter Object
            sda = new SqlDataAdapter(Query, ConStr);
            // Fills the DataTable object with the results fo the query
            sda.Fill(dt);
            // Returns the DataTable object
            return dt;
        }

        // This function sets data in the database.
        // <param name="Querry">The SQL query to execute.</param>
        public int SetData(string Querry)
        {
            // The number of rows affected by the query.
            int cnt = 0;
            // Check if the connection is closed.
            if (Con.State == ConnectionState.Closed)
            {
                // Opens the connection if it is closed.
                Con.Open();
            }
            // Set the query text
            Cmd.CommandText = Querry;
            // Executes the query and gets the number of rows affected.
            cnt = Cmd.ExecuteNonQuery();
            // Returns the number of rows affected.
            return cnt;
        }
    }
}