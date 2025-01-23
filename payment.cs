using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_lole
{
    public partial class payment : Form
    {
        private List<Request> rqlist = new List<Request>();
        public payment()
        {
            InitializeComponent();
        }
        public payment(List<Request> list)
        {
            InitializeComponent();
            double total_price = 0;
            rqlist = list;
            // Iterate through the list of requests and add them to the ListBox
            foreach (var request in list)
            {
                
                total_price += request.Price;
                // Construct a string representation of the request
                string requestInfo = $"| Type |  {request.Request_type}     | Quantity | {request.Quantity}     | Price |    {request.Price}     | Date |    {request.Date}";

                // Add the string representation to the ListBox
                plistbox.Items.Add(requestInfo);
            }
            Math.Round(total_price, 2);
            pricelabel.Text = total_price.ToString();


        }

        private void plistbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pexit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paybutton_Click(object sender, EventArgs e)
        {
            try
            {
                Request.AddtoDB(rqlist);
                MessageBox.Show("Item added successfully");
                this.Close();
            }
            catch
            {
                MessageBox.Show("An error occured");
                this.Close();
            }

        }
    }
}
