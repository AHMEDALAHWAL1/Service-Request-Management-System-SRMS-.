
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_lole
{
    public class Request
    {
        private int request_id;
        private string customer_id;
        private string request_type;
        private int quantity;
        private double price;
        private bool issurcharged;
        private string assigned_to;
        private string status;
        private string date;

        public int Request_id
        {
            get { return request_id; }
            set { request_id = value; }
        }
        public string Customer_id
        {
            get { return customer_id; }
            set { customer_id = value; }
        }

        public string Request_type
        {

            get { return request_type; }
            set
            {
                if (value == "A4bnw" || value == "A4co" || value == "A0po" || value == "A2po" || value == "HCbi" || value == "CObi")
                {
                    request_type = value;
                }
                else
                {
                    throw new ArgumentException("Incorrect value assigned to request type");
                }

            }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }
        }
        public bool Issurcharged
        {
            get { return issurcharged; }
            set { issurcharged = value; }
        }
        public string Assigned_to
        {
            get { return assigned_to; }
            set { assigned_to = value; }
        }
        public string Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }
        public string Date
        {
            get { return date; }
            set { date = value; }
        }


        public Request(int arequest_id,string acustomer_id, string arequest_type, int aquantity, double aprice, bool aissurcharged, string aassigned_to, string astatus, string adate)
        {
            Request_id = arequest_id;
            Customer_id= acustomer_id;
            Request_type = arequest_type;
            Quantity = aquantity;
            Price = aprice;
            Issurcharged = aissurcharged;
            Assigned_to = aassigned_to;
            Status = astatus;
            Date = adate;
        }

        public static void Discount(int quantity, ref double price, out double discount)
        {
            if (quantity >= 100)
            {
                price *= 0.9;
                discount = price * 0.1;
            }
            else
            {
                discount = 0.0;

            }

        }

        public static void Calc_price(string type, int quantity, ref double price, out double discount, in bool issurcharge)
        {

            switch (type)
            {
                case "A4bnw":
                    price = quantity * 0.8;
                    if (issurcharge == true) { price *= 1.30; }
                    Discount(quantity, ref price, out discount);
                    break;

                case "A4co":
                    price = quantity * 2.5;
                    if (issurcharge == true) { price *= 1.30; }
                    Discount(quantity, ref price, out discount);
                    break;
                case "HCbi":
                    price = quantity * 9.3;
                    if (issurcharge == true) { price *= 1.30; }
                    discount = 0.0;
                    break;
                case "CObi":
                    price = quantity * 5.5;
                    if (issurcharge == true) { price *= 1.30; }
                    discount = 0.0;
                    break;
                case "A0po":
                    price = quantity * 6.0;
                    if (issurcharge == true) { price *= 1.30; }
                    Discount(quantity, ref price, out discount);
                    break;
                case "A2po":
                    price = quantity * 3.0;
                    if (issurcharge == true) { price *= 1.30; }
                    Discount(quantity, ref price, out discount);
                    break;
                default:
                    price = 0.0;
                    discount = 0.0;
                    throw new ArgumentException("Error parsing values through calc_method");

            }

        }

        public static int GeneraterequestID()
        {
            // Using "using" statements to ensure the connection and command are properly disposed of
            using (SqlConnection conn = new SqlConnection(@"Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;"))
            {
                conn.Open();

                string queryString = "SELECT TOP 1 RequestID FROM Requests ORDER BY RequestID DESC";

                using (SqlCommand command = new SqlCommand(queryString, conn))
                {
                    // Execute the query and handle the result
                    object result = command.ExecuteScalar();

                    // Check if the result is null
                    if (result != null)
                    {
                        string resultString = result.ToString();

                        // Attempt to parse the result to an integer
                        if (int.TryParse(resultString, out int id))
                        {
                            id++;
                            return id;
                        }
                        else
                        {
                            // Handle the case where parsing fails
                            throw new InvalidOperationException("The RequestID retrieved from the database is not a valid integer.");
                        }
                    }
                    else
                    {
                        // Handle the case where there are no rows in the table
                        return 1; // Assuming 1 as the starting RequestID if the table is empty
                    }
                }
            }
        }
        public static void AddtoDB(List<Request> list)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=Ali;Initial Catalog=Assignment_Group48;Integrated Security=True;"))
            {
                conn.Open();

                // Start building the query string
                string queryString = "INSERT INTO Requests (RequestID,CustomerID, Type, Quantity, Price, Surcharge, Assigned, Status, Date) VALUES ";

                // List to hold the parameterized values
                List<string> rows = new List<string>();
                int parameterIndex = 0;

                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = conn;

                    foreach (Request request in list)
                    {
                        // Create parameter names for this specific iteration
                        string requestIdParam = "@RequestID" + parameterIndex;
                        string customerIDParam = "@CustomerID" + parameterIndex;
                        string typeParam = "@Type" + parameterIndex;
                        string quantityParam = "@Quantity" + parameterIndex;
                        string priceParam = "@Price" + parameterIndex;
                        string surchargeParam = "@Surcharge" + parameterIndex;
                        string assignedParam = "@Assigned" + parameterIndex;
                        string statusParam = "@Status" + parameterIndex;
                        string dateParam = "@Date" + parameterIndex;

                        // Add the row to the query
                        rows.Add($"({requestIdParam},{customerIDParam}, {typeParam}, {quantityParam}, {priceParam}, {surchargeParam}, {assignedParam}, {statusParam}, {dateParam})");

                        // Add parameter values to the command
                        command.Parameters.AddWithValue(requestIdParam, request.Request_id);
                        command.Parameters.AddWithValue(customerIDParam, request.Customer_id);
                        command.Parameters.AddWithValue(typeParam, request.Request_type);
                        command.Parameters.AddWithValue(quantityParam, request.Quantity);
                        command.Parameters.AddWithValue(priceParam, request.Price);
                        command.Parameters.AddWithValue(surchargeParam, request.Issurcharged);
                        command.Parameters.AddWithValue(assignedParam, request.Assigned_to);
                        command.Parameters.AddWithValue(statusParam, request.Status);
                        command.Parameters.AddWithValue(dateParam, request.Date);

                        parameterIndex++;
                    }

                    // Join all the rows into the query string
                    queryString += string.Join(", ", rows);

                    // Set the command text
                    command.CommandText = queryString;

                    // Execute the SQL command
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
            