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
    public partial class Services_form : Form
    {
        string id;
        public Services_form()
        {
            InitializeComponent();
        }
        public Services_form(string CuID)
        {
            InitializeComponent();
            id = CuID;
        }
        private void svc_requestbutton_Click(object sender, EventArgs e)
        {
            Request_form request_Form = new Request_form(id);
            request_Form.ShowDialog();
        }

        private void svc_exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
