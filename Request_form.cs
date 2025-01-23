
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
//Printing A4 | Black and white
//Printing A4 | Colour
//Binding | Comb
//Binding | Hard Cover
//Poster | A0/A1
//Poster | A2/A3
namespace assignment_lole
{
    public partial class Request_form : Form
    {
        List<Request> list = new List<Request>();
        
        public Request_form()
        {
            InitializeComponent();
        }
        public Request_form(string CuID)
        {
            InitializeComponent();
            id= CuID;
        }

        string id;
        int quantity;
        double price;
        string type;
        bool issurcharged;
        double surchargevalue;
        int counter = 0;

        private void rq_qbutton_Click(object sender, EventArgs e)
        {


        }




        private void Request_form_Load(object sender, EventArgs e)
        {

        }

        private void rq_calcbutton_Click(object sender, EventArgs e)
        {
            try
            {
                var quantity = Int32.Parse(rq_textBox1.Text);
                Request.Calc_price(type, quantity, ref price, out double discount, in issurcharged);
                var list = new string[] { "A4bnw", "A4co", "A0po", "A2po" };
                if (list.Contains(type))
                {
                    if (issurcharged == true)
                    {
                        surchargevalue = price * 0.3;
                        surchargevalue = Math.Round(surchargevalue, 2);
                        price *= 1.3;
                        rq_surchargelabel.Text = surchargevalue.ToString();
                    }
                    else { rq_surchargelabel.Text = "0.00"; }


                }
                price = Math.Round(price, 2);
                discount = Math.Round(discount, 2);
                rq_pricelabel.Text = price.ToString();
                rq_discountlabel.Text = discount.ToString();
            }
            catch { MessageBox.Show("Incorrect values in the controls"); }
        }



        private void rq_exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rq_addbutton_Click(object sender, EventArgs e)
        {
            int newrequestid;
            if (counter > 0)
            {
                newrequestid = Request.GeneraterequestID();
                newrequestid += counter;
            }
            else { newrequestid = Request.GeneraterequestID(); }



            double total_price = 0;
            if (Int32.TryParse(rq_textBox1.Text, out int value) && rq_comboBox1.SelectedIndex != -1)
            {
                quantity = value;
                Request.Calc_price(type, quantity, ref price, out double discount, in issurcharged);
                if (type == null) { MessageBox.Show("Please select the request type from the combobox"); return; };
                DateTime Today = DateTime.Now;
                price = Math.Round(price, 2);



                Request request = new Request(

                        newrequestid,
                        id,
                        type,
                        quantity,
                        price,
                        issurcharged,
                        "not-assigned",
                        "new",
                        Today.ToString("yyyy-MM-dd")

                        );
                list.Add(request);


                foreach (var item in list)
                {
                    total_price += item.Price;
                }
                total_price = Math.Round(total_price, 2);
                rq_totalprice.Text = total_price.ToString();

                rqGridView1.DataSource = null;
                rqGridView1.DataSource = list;
                rq_textBox1.Text = string.Empty;
                counter++;
            }
            else
            {
                MessageBox.Show("Not all columns filled lol");
                rq_textBox1.Text = string.Empty;
            }



        }




        private void rq_comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (rq_comboBox1.SelectedIndex)
            {
                case 0:
                    type = "A4bnw";
                    break;
                case 1:
                    type = "A4co";
                    break;
                case 2:
                    type = "CObi";
                    break;
                case 3:
                    type = "HCbi";
                    break;
                case 4:
                    type = "A0po";
                    break;
                case 5:
                    type = "A2po";
                    break;
                default:
                    break;
            }


        }

        private void rq_checkbox1_CheckedChanged(object sender, EventArgs e)
        {
            if (rq_checkbox1.Checked == true) { issurcharged = true; }
            else { issurcharged = false; }
        }

        private void rq_deletebutton_Click(object sender, EventArgs e)
        {


            List<int> selectedRowIndexes = new List<int>();
            foreach (DataGridViewRow row in rqGridView1.SelectedRows)
            {
                selectedRowIndexes.Add(row.Index);
            }


            selectedRowIndexes.Sort((a, b) => b.CompareTo(a));


            foreach (int index in selectedRowIndexes)
            {
                list.RemoveAt(index);
            }


            rqGridView1.DataSource = null;
            rqGridView1.DataSource = list;
        }

        private void rq_paybutton_Click(object sender, EventArgs e)
        {
            if (list.Any())
            {
                payment payment = new payment(list);
                payment.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Please add a request to the list to proceed to payment page");
            }
        }
    }
}
