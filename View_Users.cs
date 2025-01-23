using manangerPart3;
using Mina_Part;
using System;
using System.Windows.Forms;

namespace Admin_Part
{
    public partial class View_Users : Form
    {
        private Users _users;
        private string _userId;
        public View_Users(string userId)
        {
            InitializeComponent();
            _users = new Users("Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;");
            _userId = userId;
        }

        private void View_Users_Load(object sender, EventArgs e)
        {
            _users.BindData(UsersTable_dataGridView); // Binds data to the DataGridView when the form loads
        }

        private void RegisterUsersbtn_Click(object sender, EventArgs e)
        {
            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(Usernametxt.Text) ||
                string.IsNullOrWhiteSpace(UserPhonetxt.Text) ||
                string.IsNullOrWhiteSpace(LoginNametxt.Text) ||
                string.IsNullOrWhiteSpace(UserPasswordtxt.Text) ||
                UserRole_ComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // Insert the new user with the provided information
            _users.InsertUser(Usernametxt.Text, UserPhonetxt.Text, LoginNametxt.Text, UserPasswordtxt.Text, UserRole_ComboBox.Text);

            // Clear the input fields after inserting the user
            Usernametxt.Clear();
            UserPhonetxt.Clear();
            LoginNametxt.Clear();
            UserPasswordtxt.Clear();
            UserRole_ComboBox.SelectedIndex = -1;

            // Re-bind data to the DataGridView to reflect the new user
            _users.BindData(UsersTable_dataGridView);


        }

       





        private void UpdateUsersProfilebtn_Click(object sender, EventArgs e)
        {
            string userID = UserIDtxt.Text.Trim();  // Get the user ID from the textbox

            if (string.IsNullOrEmpty(userID))    // Check if the user ID is provided
            {
                MessageBox.Show("Please enter a UserID.");
                return;
            }

            // Check if the user exists in the database
            if (!_users.UserExists(userID))
            {
                MessageBox.Show($"User with UserID {userID} does not exist, Please Enter a Valid UserID.");
                return;
            }
            // Update the user information
            _users.UpdateUser(userID, NewFullNametxt.Text, NewUserPhonetxt.Text, NewLoginNametxt.Text, NewUserPasswordtxt.Text, NewUserRole_comboBox.Text);

            // Re-bind data to the DataGridView to reflect the updated user information
            _users.BindData(UsersTable_dataGridView);

            // Clear the text boxes after updating the user information
            ClearTextBoxes();
        }

        // Method to clear all text boxes used for updating user information
        private void ClearTextBoxes()
        {
            UserIDtxt.Clear();
            NewFullNametxt.Clear();
            NewUserPhonetxt.Clear();
            NewLoginNametxt.Clear();
            NewUserPasswordtxt.Clear();
            NewUserRole_comboBox.SelectedIndex = -1;
        }

        private void ReturnMenubtn1_Click(object sender, EventArgs e)
        {
            Admin form0 = new Admin(_userId);
            form0.Show();
            this.Hide();
        }

        private void UserPassowrdtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
