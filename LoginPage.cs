using manangerPart3;
using Mina_Part;
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
using assignment_lole;

namespace Admin_Part
{
    public partial class LoginPage : Form
    {
        private string connectionString = "Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;"; 
        private string currentUserId;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin1_Click(object sender, EventArgs e)
        {
            string username = insertuser.Text;
            string password = insertpass.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT UserID, User_Role FROM Users WHERE Login_Name = @Login_Name AND User_Password = @User_Password\r\n";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Login_Name", username);
                command.Parameters.AddWithValue("@User_Password", password);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    currentUserId = reader["UserID"].ToString();
                    string role = reader["User_Role"].ToString();

                    switch (role)
                    {
                        case "Admin":
                            Admin adminForm = new Admin(currentUserId);
                            adminForm.Show();
                            break;
                        case "Customer":
                            Customer_form customerForm = new Customer_form(currentUserId);
                            customerForm.Show();
                            break;
                        case "Manager":
                            Manager managerForm = new Manager(currentUserId);
                            managerForm.Show();
                            break;
                        case "Worker":
                            Worker workerForm = new Worker(currentUserId);
                            workerForm.Show();
                            break;
                        default:
                            MessageBox.Show("Invalid user role.");
                            break;
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                reader.Close();
            }

        }


        private void showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (showpass.Checked)
            {
                insertpass.UseSystemPasswordChar = false;


            }
            else
            {
                insertpass.UseSystemPasswordChar = true;
            }
        }

        private void btnClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void insertuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
