using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Admin_Part
{
    public partial class Update_Profile : Form
    {

        private string _connectionString = "Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;"; // Update with your actual connection string
        private string _userId;

        public Update_Profile(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnMenubtn2_Click(object sender, EventArgs e)
        {
            // Assuming you have a method to get the user role based on the user ID
            string User_Role = GetUserRole(_userId);

            // Redirect based on user role
            if (User_Role == "Admin")
            {
                this.Hide();
                // Assuming you have an AdminForm class
                Admin adminForm = new Admin(_userId);
                adminForm.Show();
            }
            else
            {
                this.Hide();
                LoginPage loginForm = new LoginPage();
                loginForm.Show();
            }

        }


        private string GetUserRole(string userId)
        {
            // Example implementation: Assuming you have a Users table with a UserRole column
            // You should replace this with your actual logic to retrieve the user role
            string User_Role = ""; // Initialize to an empty string

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    // Assuming your Users table has a column named UserRole
                    string query = "SELECT User_Role FROM Users WHERE UserID = @userId";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        object result = command.ExecuteScalar();
                        if (result != null)
                        {
                            User_Role = result.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching user role: {ex.Message}");
            }

            return User_Role;
        }







        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    




    private void UpdateMyProfile_Click(object sender, EventArgs e)
        {
            string newFullName = MyNewFullNametxt.Text.Trim();
            string newPhone = MyNewPhonetxt.Text.Trim();
            string newLoginName = MyNewLoginNametxt.Text.Trim();
            string newPassword = MyNewPasswordtxt.Text.Trim();

            if (string.IsNullOrWhiteSpace(newFullName) &&
                string.IsNullOrWhiteSpace(newPhone) &&
                string.IsNullOrWhiteSpace(newLoginName) &&
                string.IsNullOrWhiteSpace(newPassword))
            {
                MessageBox.Show("Please provide at least one field to update.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(_connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand())
                    {
                        command.Connection = connection;

                        // Dynamically build the query based on provided inputs
                        StringBuilder queryBuilder = new StringBuilder("UPDATE Users SET ");
                        bool isFirstField = true;

                        if (!string.IsNullOrWhiteSpace(newFullName))
                        {
                            queryBuilder.Append("Full_Name = @Full_Name");
                            command.Parameters.AddWithValue("@Full_Name", newFullName);
                            isFirstField = false;
                        }

                        if (!string.IsNullOrWhiteSpace(newPhone))
                        {
                            if (!isFirstField) queryBuilder.Append(", ");
                            queryBuilder.Append("User_Phone = @User_Phone");
                            command.Parameters.AddWithValue("@User_Phone", newPhone);
                            isFirstField = false;
                        }

                        if (!string.IsNullOrWhiteSpace(newLoginName))
                        {
                            if (!isFirstField) queryBuilder.Append(", ");
                            queryBuilder.Append("Login_Name = @Login_Name");
                            command.Parameters.AddWithValue("@Login_Name", newLoginName);
                            isFirstField = false;
                        }

                        if (!string.IsNullOrWhiteSpace(newPassword))
                        {
                            if (!isFirstField) queryBuilder.Append(", ");
                            string hashedPassword = HashPassword(newPassword);
                            queryBuilder.Append("User_Password = @User_Password");
                            command.Parameters.AddWithValue("@User_Password", hashedPassword);
                        }

                        queryBuilder.Append(" WHERE UserID = @userId");
                        command.Parameters.AddWithValue("@userId", _userId);

                        command.CommandText = queryBuilder.ToString();

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Profile updated successfully.");
                            ClearInputFields();
                        }
                        else
                        {
                            MessageBox.Show("Profile update failed. Please try again.");
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void ClearInputFields()
        {
            MyNewFullNametxt.Clear();
            MyNewPhonetxt.Clear();
            MyNewLoginNametxt.Clear();
            MyNewPasswordtxt.Clear();
        }

        private string HashPassword(string password)
        {
            // Placeholder for password hashing logic
            // Use a library like BCrypt.Net or similar for actual implementation
            return password; // Replace with actual hashing logic
        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {

            

        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MyNewFullNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyNewPhonetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyNewLoginNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void MyNewPasswordtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
