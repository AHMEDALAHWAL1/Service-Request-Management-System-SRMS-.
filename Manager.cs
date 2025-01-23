using Admin_Part;
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

namespace manangerPart3
{
    public partial class Manager : Form
    {
        // Declare database connection and other necessary objects
        SqlConnection conn;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommand cmd;
        private string _userId;

        // Constructor to initialize the form with the user ID
        public Manager(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        // Event handler for cell content click in the DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.RequestdataGridView.Rows[e.RowIndex];
            }
        }

        // Event handler for form load
        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize and open the database connection
            conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;";
            conn.Open();

            // Load initial data into the DataGridView
            adap = new SqlDataAdapter("select RequestID, assigned, status from Requests", conn);
            ds = new System.Data.DataSet();
            adap.Fill(ds, "Requests");
            RequestdataGridView.DataSource = ds.Tables[0];

            // Load worker IDs into the Workercombobox
            LoadWorkerIDs();
        }


        // Method to load worker IDs into the combobox
        private void LoadWorkerIDs()
        {
            string sqlstm = "select UserID from Users where User_Role = 'Worker'";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
            DataSet ds = new DataSet();
            SDA.Fill(ds, "Users");
            Workercombobox.DataSource = ds.Tables[0];
            Workercombobox.DisplayMember = "UserID";
            Workercombobox.ValueMember = "UserID";
        }






        // Method to refresh the DataGridView
        private void Autorefresh()
        {
            // Query to select request data
            String sqlstm = "select RequestID, assigned, status from Requests";
            SqlDataAdapter SDA = new SqlDataAdapter(sqlstm, conn);
            DataSet ds = new System.Data.DataSet();
            SDA.Fill(ds, "Requests");
            RequestdataGridView.DataSource = ds.Tables[0];
        }

        // Event handler for the "Assign" button click
        private void button2_Click(object sender, EventArgs e)
        {
            if (RequestdataGridView.CurrentRow != null)
            {
                string ID = RequestdataGridView.CurrentRow.Cells["RequestID"].Value.ToString();
                string status = RequestdataGridView.CurrentRow.Cells["status"].Value.ToString();
                string selectedUserId = Workercombobox.SelectedValue.ToString();

                // Ensure the connection is open
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Check if the request is new and the "Assigned" radio button is checked
                if (status == "new" && RDassigned.Checked)
                {
                    string newStatus = "Assigned";

                    // Update the assigned user ID and status of the selected request
                    string updatequery = "UPDATE Requests SET assigned = @assigned, status = @status WHERE RequestID = @RequestID";
                    cmd = new SqlCommand(updatequery, conn);
                    cmd.Parameters.AddWithValue("@assigned", selectedUserId);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@RequestID", ID);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Assignment and Status Updated Successfully");

                    // Refresh the DataGridView
                    Autorefresh();
                }
                else
                {
                    MessageBox.Show("You can only assign 'new' requests.");
                }

                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select a row.");
            }
        }

        // Event handler for the close button click
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event handlers for various UI elements (empty for now)
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }
        private void radioButton1_CheckedChanged(object sender, EventArgs e) { }
        private void RDassigned_CheckedChanged(object sender, EventArgs e) { }
        private void groupBox1_Enter(object sender, EventArgs e) { }

        // Event handler for the "Update Profile" button click
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Update_Profile update_Profile = new Update_Profile(_userId);
            update_Profile.Show();
        }

        // Event handler for the ComboBox selection change (used for filtering)
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedStatus = FilterCombobox.SelectedItem.ToString();
            if (selectedStatus == "All")
            {
                Autorefresh(); // Reload all data
            }
            else
            {
                Filterselection(selectedStatus); // Filter by selected status
            }
        }

        // Method to filter requests by status
        private void Filterselection(string status)
        {
            SqlDataAdapter requestAdap = new SqlDataAdapter("select RequestID, assigned, status FROM Requests WHERE status = @status", conn);
            requestAdap.SelectCommand.Parameters.AddWithValue("@status", status);
            DataSet filterDS = new DataSet();
            requestAdap.Fill(filterDS, "Requests");
            RequestdataGridView.DataSource = filterDS.Tables[0];
        }

        // Event handler for the "Logout" button click
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
        }

        // Empty event handler (to be defined if needed)
        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e) { }

        private void Workercombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
