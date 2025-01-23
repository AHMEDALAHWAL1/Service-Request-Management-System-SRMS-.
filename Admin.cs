using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admin_Part
{
    public partial class Admin : Form
    {
        private string _userId;
        public Admin(string userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void UpdateUsersProfilebtn_Click(object sender, EventArgs e) // Event handler for updating user profiles
        {
            this.Hide();
            Update_Profile Form4 = new Update_Profile(_userId);
            Form4.ShowDialog();
        }

        private void ViewUsersbtn_Click(object sender, EventArgs e) // Event handler for viewing users
        {
            this.Hide();
            View_Users form1 = new View_Users(_userId);
            form1.Show();
        }


        private void Exitbtn_Click(object sender, EventArgs e) // Event handler for exiting the application
        {
            this.Close();   
        }

        private void GenerateReportsbtn_Click(object sender, EventArgs e)  // Event handler for generating reports
        {
            this.Hide();
            Generate_Reports form6 = new Generate_Reports(_userId);
            form6.Show();
        }

        private void ReturnLoginPagebtn_Click(object sender, EventArgs e)  // Placeholder for returning to the login page
        {
            this.Hide();
            LoginPage loginPage = new LoginPage();
            loginPage.Show();   
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
