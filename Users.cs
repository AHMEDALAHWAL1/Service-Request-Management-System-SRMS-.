using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Admin_Part
{
    public class Users
    {
      


        private string _connectionString;

        public Users(string connectionString)
        {
            // Connection string for connecting to the SQL Server database
            _connectionString = ("Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;");
        }




        // Method to bind data to a DataGridView
        public void BindData(DataGridView dataGridView)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))  // Using block to ensure the SqlConnection is properly disposed of
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);   // SQL command to select all users
                SqlDataAdapter sd = new SqlDataAdapter(cmd);   // SqlDataAdapter to fill the DataTable with the results
                DataTable dt = new DataTable();   // DataTable to hold the data
                sd.Fill(dt);   // Fill the DataTable with data from the database
                dataGridView.DataSource = dt;  // Set the DataGridView's data source to the DataTable
            }



        }
        // Method to insert a new user into the database
        public void InsertUser(string fullName, string userPhone, string loginName, string userPassword, string userRole)
        {

            // Validate numeric input for userPhone
            if (!decimal.TryParse(userPhone, out decimal parsedUserPhone))
            {
                MessageBox.Show("Error: User phone number must be a valid number.");
                return;
            }

            using (SqlConnection con = new SqlConnection(_connectionString))  // Using block to ensure the SqlConnection is properly disposed of
            {
                string query = "INSERT INTO Users (Full_Name, User_Phone, Login_Name, User_Password, User_Role) " +
                               "VALUES (@Full_Name, @User_Phone, @Login_Name, @User_Password, @User_Role)"; // SQL query to insert a new user

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Adding parameters to the SQL command to prevent SQL injection
                    cmd.Parameters.AddWithValue("@Full_Name", fullName);
                    cmd.Parameters.AddWithValue("@User_Phone", parsedUserPhone);
                    cmd.Parameters.AddWithValue("@Login_Name", loginName);
                    cmd.Parameters.AddWithValue("@User_Password", userPassword);
                    cmd.Parameters.AddWithValue("@User_Role", userRole);

                    try
                    {
                        con.Open();  // Open the database connection
                        cmd.ExecuteNonQuery();  // Execute the insert command
                        MessageBox.Show($"The User ( {loginName} ) added Successfully");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting user: " + ex.Message); // Show an error message if the insertion fails
                    }
                }
            }
        }


        // Method to update an existing user in the database
        public void UpdateUser(string userID, string fullName, string userPhone, string loginName, string userPassword, string userRole)
        {

            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();

                List<string> updates = new List<string>();  // Lists to hold the update statements and parameters
                List<SqlParameter> parameters = new List<SqlParameter>();

                if (!string.IsNullOrEmpty(fullName))    // Adding update statements and parameters if the corresponding fields are not empty
                {
                    updates.Add("Full_Name = @Full_Name");
                    parameters.Add(new SqlParameter("@Full_Name", fullName));
                }
                if (!string.IsNullOrEmpty(userPhone))
                {
                    // Validate numeric input for userPhone
                    if (!decimal.TryParse(userPhone, out decimal parsedUserPhone))
                    {
                        MessageBox.Show("Error: User phone number must be a valid number.");
                        return;
                    }

                    updates.Add("User_Phone = @User_Phone");
                    parameters.Add(new SqlParameter("@User_Phone", parsedUserPhone));
                }
                if (!string.IsNullOrEmpty(loginName))
                {
                    updates.Add("Login_Name = @Login_Name");
                    parameters.Add(new SqlParameter("@Login_Name", loginName));
                }
                if (!string.IsNullOrEmpty(userPassword))
                {
                    updates.Add("User_Password = @User_Password");
                    parameters.Add(new SqlParameter("@User_Password", userPassword));
                }
                if (!string.IsNullOrEmpty(userRole))
                {
                    updates.Add("User_Role = @User_Role");
                    parameters.Add(new SqlParameter("@User_Role", userRole));
                }

                if (updates.Count > 0)   // If there are updates to be made
                {
                    // Form the update query with the collected update statements
                    string query = $"UPDATE Users SET {string.Join(", ", updates)} WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Add the collected parameters to the command
                        cmd.Parameters.AddRange(parameters.ToArray());
                        cmd.Parameters.AddWithValue("@UserID", userID);

                        cmd.ExecuteNonQuery();  // Execute the update command
                    }

                    MessageBox.Show($"User ( {userID} ) information updated successfully");
                }
                else
                {
                    MessageBox.Show("No information provided to update.");
                }

                con.Close();  // Close the database connection
            }

        }


        
        public bool UserExists(string userID)
        {

            using (SqlConnection con = new SqlConnection(_connectionString))  // Using block to ensure the SqlConnection is properly disposed of
            {
                con.Open();
                string query = "SELECT 1 FROM Users WHERE UserID = @UserID";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    return cmd.ExecuteScalar() != null;
                }
            }



        }

        internal string GetRole(string username, string password)
        {
            throw new NotImplementedException();
        }


    }
}
