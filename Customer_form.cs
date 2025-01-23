using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Admin_Part;

namespace assignment_lole
{
    public partial class Customer_form : Form
    {
        string id = "I01";
        public Customer_form()
        {
            InitializeComponent();
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=Requests;Integrated Security=True;TrustServerCertificate=true;"))
                {
                    string cuid = "I01";
                    conn.Open();
                    string queryString = $"SELECT Full_Name FROM Users WHERE UserID = @cuid";
                    using (SqlCommand command = new SqlCommand(queryString, conn))
                    {
                        command.Parameters.AddWithValue("@cuid", cuid); // Add cuid as parameter
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string c_name = reader["Full_Name"].ToString(); // Read the value from the reader
                                Hello_label_name.Text = c_name; // Set the label text to the retrieved value
                            }
                            else
                            {
                                MessageBox.Show("Customer not found");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting logged in customer name failed: " + ex.Message); // Show the exception message
            }
        }
        public Customer_form(string CuID)
        {
            InitializeComponent();
            string id=CuID;
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=(local);Initial Catalog=Requests;Integrated Security=True;TrustServerCertificate=true;"))
                {
                    try
                    {
                        conn.Open();
                        string queryString = "SELECT Full_Name FROM Users WHERE UserID = @UserId";
                        using (SqlCommand command = new SqlCommand(queryString, conn))
                        {
                            command.Parameters.Add("@UserId", SqlDbType.NVarChar).Value = id;
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string c_name = reader["Full_Name"].ToString();
                                    Hello_label_name.Text = c_name;
                                }
                                else
                                {
                                    MessageBox.Show("Customer not found");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Getting logged in customer name failed: " + ex.Message); // Show the exception message
            }

        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            Update_Profile update_Profile = new Update_Profile(id);
            update_Profile.Show();
            MessageBox.Show("I love");
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Services_button_Click(object sender, EventArgs e)
        {
            Services_form services_Form = new Services_form(id);
            services_Form.ShowDialog();
        }

        private void Request_button_Click(object sender, EventArgs e)
        {
            Request_form request_Form = new Request_form(id);
            request_Form.ShowDialog();
        }

        private void History_button_Click(object sender, EventArgs e)
        {
            History_form history_Form = new History_form(id);
            history_Form.ShowDialog();
        }
    }
}
