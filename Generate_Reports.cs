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

namespace Admin_Part
{
    public partial class Generate_Reports : Form
    {

        // Connection string for connecting to the SQL Server database
        private string connectionString = "Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;";
        private string _userId;
        public Generate_Reports(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void ReturnMenubtn3_Click(object sender, EventArgs e) // Event handler for returning to the main menu
        {
            Admin form0 = new Admin(_userId);
            form0.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void Reportsbtn_Click(object sender, EventArgs e) // Event handler for generating reports
        {
            if (ChooseReportcombBox.SelectedItem != null)  // Check if a report type is selected
            {
                string selectedReport = ChooseReportcombBox.SelectedItem.ToString();
                int year;
                if (int.TryParse(Year_TextBox.Text, out year))  // Try to parse the year from the text box
                {
                    if (selectedReport == "Yearly Report")   // Generate the appropriate report based on the selection
                    {
                        GenerateYearlyReport(year);
                    }
                    else if (selectedReport == "Service Request Report")
                    {
                        if (ServiceReport_MonthCoBox.SelectedItem != null)
                        {
                            int month = ServiceReport_MonthCoBox.SelectedIndex + 1; // Assuming month is 0-based index
                            GenerateServiceRequestReport(year, month);
                        }
                        else
                        {
                            MessageBox.Show("Please select a month for the Service Request Report.");
                        }
                    }
                    else if (selectedReport == "Customer Report")
                    {
                        if (CustomerReport_AllCustomerRDB.Checked)
                        {
                            if (CustomerReport_MonthCoBox.SelectedItem != null)
                            {
                                int month = CustomerReport_MonthCoBox.SelectedIndex + 1; // Assuming month is 0-based index
                                GenerateAllCustomersReport(year, month);
                            }
                            else
                            {
                                MessageBox.Show("Please select a month for the Customer Report.");
                            }
                        }
                        else if (CustomerReport_CustomerRDB.Checked)
                        {
                            if (!string.IsNullOrEmpty(CustomerReport_CustomerIDtxtb.Text.Trim()))
                            {
                                if (CustomerReport_MonthCoBox.SelectedItem != null)
                                {
                                    string customerID = CustomerReport_CustomerIDtxtb.Text.Trim();
                                    int monthIndex = CustomerReport_MonthCoBox.SelectedIndex; // Get the index of the selected month
                                    string month = (monthIndex + 1).ToString(); // Convert the index to month number (1-based)

                                    // Now, month is a string representing the selected month
                                    GenerateCustomerReport(year, customerID, month);
                                }
                                else
                                {
                                    MessageBox.Show("Please select a month for the Customer Report.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please enter a Customer ID.");
                            }
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid year.");
                }
            }
            else
            {
                MessageBox.Show("Please select a report type.");
            }
        }

        private void GenerateYearlyReport(int year)
        {
            Reports_ListBox.Items.Clear();  // Clear the list box before adding new items
            string query = @"
                SELECT 
                    MONTH([date]) AS Month, 
                    ISNULL(SUM(price), 0) AS TotalPrice 
                FROM 
                    Requests 
                WHERE 
                    YEAR([date]) = @year AND 
                    [status] = 'Completed'
                GROUP BY 
                    MONTH([date])";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", year);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    var monthlyTotals = new Dictionary<int, decimal>();

                    while (reader.Read())
                    {
                        int month = reader.GetInt32(0);
                        decimal totalPrice = reader.GetDecimal(1);
                        monthlyTotals[month] = totalPrice;
                    }

                    reader.Close();

                    for (int month = 1; month <= 12; month++)
                    {
                        decimal totalPrice = monthlyTotals.ContainsKey(month) ? monthlyTotals[month] : 0;
                        Reports_ListBox.Items.Add($"Month: {month}, Total Price: {totalPrice:C}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void GenerateServiceRequestReport(int year, int month)
        {
            Reports_ListBox.Items.Clear();   // Clear the list box before adding new items
            string query = @"
                SELECT 
                    [Type], 
                    ISNULL(COUNT(RequestID), 0) AS TotalRequests, 
                    ISNULL(SUM(price), 0) AS TotalPrice 
                FROM 
                    Requests
                WHERE 
                    YEAR([date]) = @year 
                    AND MONTH([date]) = @month 
                    AND [status] = 'Completed'
                GROUP BY 
                    [Type]";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@year", year);
                command.Parameters.AddWithValue("@month", month);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    var results = new Dictionary<string, (int TotalRequests, decimal TotalPrice)>();

                    // Populate the results with data from the query
                    while (reader.Read())
                    {
                        string type = reader.GetString(0);
                        int totalRequests = reader.GetInt32(1);
                        decimal totalPrice = reader.GetDecimal(2);
                        results[type] = (totalRequests, totalPrice);
                    }

                    reader.Close();

                    // Display the results including types with 0 values
                    string typesQuery = @"
                        SELECT DISTINCT [Type] 
                        FROM Requests";

                    SqlCommand typesCommand = new SqlCommand(typesQuery, connection);
                    SqlDataReader typesReader = typesCommand.ExecuteReader();

                    // Collect all distinct types from the database
                    var allTypes = new HashSet<string>();
                    while (typesReader.Read())
                    {
                        allTypes.Add(typesReader.GetString(0));
                    }

                    typesReader.Close();

                    // Output the results including types with 0 values
                    foreach (string type in allTypes)
                    {
                        int totalRequests = results.ContainsKey(type) ? results[type].TotalRequests : 0;
                        decimal totalPrice = results.ContainsKey(type) ? results[type].TotalPrice : 0m;
                        Reports_ListBox.Items.Add($"Type: {type}, Total Requests: {totalRequests}, Total Price: {totalPrice:C}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void GenerateAllCustomersReport(int year, int month)   // Method to generate a report for all customers
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
            SELECT 
                u.UserID,
                COUNT(r.RequestID) AS TotalRequests,
                ISNULL(SUM(r.price), 0) AS TotalPrice
            FROM 
                Users u
            LEFT JOIN 
                Requests r ON u.UserID = r.CustomerID AND YEAR(r.[date]) = @Year AND MONTH(r.[date]) = @Month AND r.[status] = 'Completed'
            WHERE 
                u.User_Role = 'Customer'
            GROUP BY 
                u.UserID, u.Full_Name";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Month", month);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                Reports_ListBox.Items.Clear();
                while (reader.Read())
                {
                    string userID = reader["UserID"].ToString();
                    int totalRequests = Convert.ToInt32(reader["TotalRequests"]);
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);

                    Reports_ListBox.Items.Add($"Customer ID: {userID}, Total Requests: {totalRequests}, Total Price: {totalPrice:C}");
                }

                connection.Close();
            }
        }







        private void GenerateCustomerReport(int year, string customerID, string month)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE UserID = @CustomerID AND User_Role = 'Customer'";
                SqlCommand checkUserCommand = new SqlCommand(checkUserQuery, connection);
                checkUserCommand.Parameters.AddWithValue("@CustomerID", customerID);

                connection.Open();
                int userExists = (int)checkUserCommand.ExecuteScalar();

                if (userExists == 0)
                {
                    MessageBox.Show("Customer ID not found.");
                    connection.Close();
                    return;
                }

                string query = @"
            SELECT 
                COUNT(r.RequestID) AS TotalRequests,
                ISNULL(SUM(r.price), 0) AS TotalPrice
            FROM 
                Requests r
            WHERE 
                r.CustomerID = @CustomerID AND YEAR(r.[date]) = @Year AND MONTH(r.[date]) = @Month AND [status] = 'Completed'";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);
                command.Parameters.AddWithValue("@Year", year);
                command.Parameters.AddWithValue("@Month", month);

                SqlDataReader reader = command.ExecuteReader();

                Reports_ListBox.Items.Clear();
                if (reader.Read())
                {
                    int totalRequests = Convert.ToInt32(reader["TotalRequests"]);
                    decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);

                    Reports_ListBox.Items.Add($"Customer ID: {customerID}, Total Requests: {totalRequests}, Total Price: {totalPrice:C}");
                }

                connection.Close();
            }
        }

        private void Generate_Reports_Load(object sender, EventArgs e)
        {

        }
    }
    }





