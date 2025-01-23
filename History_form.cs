
using Microsoft.VisualBasic;
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

namespace assignment_lole
{
    public partial class History_form : Form
    {
        private string loggedInCustomerId;
        private string connectionString = "Data Source=(local);Initial Catalog=Requests;Integrated Security=True;TrustServerCertificate=true;";
        private bool isStatusSelected = false;
        private bool isDateChanged = false;
        private bool isTypeSelected = false;

        public History_form(string customerId)
        {
            InitializeComponent();

            loggedInCustomerId = customerId;
            id_label.Text = loggedInCustomerId;  // Assuming you have a label for this

            hi_combobox1.SelectedIndexChanged += Hi_combobox1_SelectedIndexChanged;
            hi_dateTimePicker1.ValueChanged += Hi_dateTimePicker1_ValueChanged;
            hi_comboBox2.SelectedIndexChanged += Hi_comboBox2_SelectedIndexChanged;
            hi_resetbutton.Click += Hi_resetbutton_Click;

            // Load initial data (all requests for this customer)
            LoadRequests();
        }

        private void Hi_combobox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            isStatusSelected = hi_combobox1.SelectedIndex != -1;
            LoadRequests();
        }

        private void Hi_dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            isDateChanged = true;
            LoadRequests();
        }

        private void Hi_comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            isTypeSelected = hi_comboBox2.SelectedIndex != -1;
            LoadRequests();
        }

        private void Hi_resetbutton_Click(object sender, EventArgs e)
        {
            ResetFilters();
        }

        private void ResetFilters()
        {
            isStatusSelected = isDateChanged = isTypeSelected = false;
            hi_combobox1.SelectedIndex = -1;
            hi_dateTimePicker1.Value = DateTime.Today;
            hi_comboBox2.SelectedIndex = -1;
            LoadRequests(); // This will load all requests for the logged-in customer
        }

        private void LoadRequests()
        {
            string status = isStatusSelected ? hi_combobox1.SelectedItem.ToString() : null;
            DateTime? selectedDate = isDateChanged ? hi_dateTimePicker1.Value : (DateTime?)null;

            string type = null;
            if (isTypeSelected)
            {
                switch (hi_comboBox2.SelectedIndex)
                {
                    case 0: type = "A4bnw"; break;
                    case 1: type = "A4co"; break;
                    case 2: type = "CObi"; break;
                    case 3: type = "HCbi"; break;
                    case 4: type = "A0po"; break;
                    case 5: type = "A2po"; break;
                }
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                List<string> whereClauses = new List<string> { "CustomerID = @CustomerId" };
                List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@CustomerId", SqlDbType.NVarChar, 3) { Value = loggedInCustomerId }
            };

                if (isStatusSelected)
                {
                    whereClauses.Add("Status = @Status");
                    parameters.Add(new SqlParameter("@Status", SqlDbType.NVarChar) { Value = status });
                }

                if (isTypeSelected)
                {
                    whereClauses.Add("Type = @Type");
                    parameters.Add(new SqlParameter("@Type", SqlDbType.NVarChar) { Value = type });
                }

                if (isDateChanged)
                {
                    whereClauses.Add("CONVERT(DATE, Date) = @Date");
                    parameters.Add(new SqlParameter("@Date", SqlDbType.Date) { Value = selectedDate });
                }

                string whereClause = string.Join(" AND ", whereClauses);
                string query = $"SELECT * FROM REQUESTS WHERE {whereClause}";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddRange(parameters.ToArray());

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable dataTable = new DataTable();
                            dataTable.Load(reader);

                            if (dataTable.Rows.Count == 0)
                            {
                                MessageBox.Show("No requests found for the selected criteria");
                                dataGridView1.DataSource = null;
                            }
                            else
                            {
                                dataGridView1.DataSource = dataTable;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
