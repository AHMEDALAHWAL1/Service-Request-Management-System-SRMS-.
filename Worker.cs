using Admin_Part;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Mina_Part
{
    public partial class Worker : Form
    {
        // Declare SqlConnection object
        SqlConnection Connection1;
        private string _userId;

        // Constructor to initialize the form with user ID
        public Worker(string userId)
        {
            InitializeComponent();
            _userId = userId;

            // Initialize SqlConnection with connection string
            string connectionString = @"Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;";
            Connection1 = new SqlConnection(connectionString);
        }
        // Event handler for closing the form

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        // Event handler for loading the form

        private void Form1_Load(object sender, EventArgs e)
        {

            string connectionString = @"Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select RequestID, assigned, status from Requests WHERE assigned = @userId", connection))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@userId", _userId);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    WorkerdataGridView.DataSource = table;
                }
            }


        }

        // Event handler for updating request status

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Method to update request status in the database
        private void UpdateDatabase()
        {
            if (WorkerdataGridView.CurrentRow != null)
            {
                // Retrieve the selected request RequestID
                string requestId = WorkerdataGridView.CurrentRow.Cells["RequestID"].Value.ToString();

                // Determine the new status based on the selected radio button
                string newStatus = rdWorkInProgress.Checked ? "Work in Progress" : "Completed";

                // Ensure the connection is open before querying and updating the database
                if (Connection1.State == ConnectionState.Closed)
                {
                    Connection1.Open();
                }

                // Fetch the current status from the database
                string currentStatus = GetCurrentStatus(requestId);

                // Validation logic
                if (newStatus == "Work in Progress" && currentStatus != "Assigned")
                {
                    MessageBox.Show("Cannot update to 'Work in Progress' unless the current status is 'Assigned'.");
                    Connection1.Close();
                    return;
                }
                else if (newStatus == "Completed")
                {
                    if (currentStatus != "Work in Progress")
                    {
                        MessageBox.Show("Cannot update to 'Completed' unless the current status is 'Work in Progress'.");
                        Connection1.Close();
                        return;
                    }
                    else if (currentStatus == "Completed")
                    {
                        MessageBox.Show("Request is already completed.");
                        Connection1.Close();
                        return;
                    }
                }

                // Define and execute the update query
                string updateQuery = "UPDATE Requests SET status = @status WHERE RequestID = @RequestID";
                using (SqlCommand cmd = new SqlCommand(updateQuery, Connection1))
                {
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@RequestID", requestId);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Status Updated Successfully");

                // Close the connection and refresh the DataGridView
                Connection1.Close();
                RefreshData();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }

        }

        // Method to get the current status from the database
        private string GetCurrentStatus(string requestId)
        {
            string currentStatus = string.Empty;

            string query = "SELECT status FROM Requests WHERE RequestID = @RequestID";
            using (SqlCommand cmd = new SqlCommand(query, Connection1))
            {
                cmd.Parameters.AddWithValue("@RequestID", requestId);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        currentStatus = reader["status"].ToString();
                    }
                }
            }

            return currentStatus;
        }



        // Method to refresh DataGridView with updated data
        private void RefreshData()
        {
            if (Connection1.State == ConnectionState.Closed)
            {
                Connection1.Open();
            }

            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT RequestID, assigned, status FROM Requests WHERE assigned = @userId", Connection1))
            {
                adapter.SelectCommand.Parameters.AddWithValue("@userId", _userId);
                DataTable table = new DataTable();
                adapter.Fill(table);
                WorkerdataGridView.DataSource = table;
            }

            Connection1.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Event handler for button click to go back to login page
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Event handler for button click to update profile
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Profile update_Profile = new Update_Profile(_userId);
            update_Profile.Show();
        }
    }
}
