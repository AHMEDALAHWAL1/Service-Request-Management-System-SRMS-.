using System.Drawing;
using System.Windows.Forms;

namespace assignment_lole
{
    partial class Request_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            rq_label1 = new Label();
            rq_comboBox1 = new ComboBox();
            rq_label2 = new Label();
            rq_textBox1 = new TextBox();
            rq_checkbox1 = new CheckBox();
            rq_label3 = new Label();
            rq_pricelabel = new Label();
            rq_label4 = new Label();
            rq_discountlabel = new Label();
            rq_addbutton = new Button();
            rq_exitbutton = new Button();
            rqGridView1 = new DataGridView();
            rq_calcbutton = new Button();
            rq_label5 = new Label();
            rq_surchargelabel = new Label();
            rq_label6 = new Label();
            rq_totalprice = new Label();
            rq_deletebutton = new Button();
            rq_paybutton = new Button();
            ((System.ComponentModel.ISupportInitialize)rqGridView1).BeginInit();
            SuspendLayout();
            // 
            // rq_label1
            // 
            rq_label1.AutoSize = true;
            rq_label1.Location = new Point(12, 19);
            rq_label1.Name = "rq_label1";
            rq_label1.Size = new Size(106, 15);
            rq_label1.TabIndex = 0;
            rq_label1.Text = "Select service type:";
            // 
            // rq_comboBox1
            // 
            rq_comboBox1.FormattingEnabled = true;
            rq_comboBox1.Items.AddRange(new object[] { "Printing A4 | Black and white ", "Printing A4 | Colour ", "Binding | Comb", "Binding | Hard Cover", "Poster | A0/A1", "Poster | A2/A3" });
            rq_comboBox1.Location = new Point(12, 37);
            rq_comboBox1.Name = "rq_comboBox1";
            rq_comboBox1.Size = new Size(169, 23);
            rq_comboBox1.TabIndex = 1;
            rq_comboBox1.SelectedIndexChanged += rq_comboBox1_SelectedIndexChanged;
            // 
            // rq_label2
            // 
            rq_label2.AutoSize = true;
            rq_label2.Location = new Point(12, 76);
            rq_label2.Name = "rq_label2";
            rq_label2.Size = new Size(88, 15);
            rq_label2.TabIndex = 2;
            rq_label2.Text = "Select quantity:";
            // 
            // rq_textBox1
            // 
            rq_textBox1.Location = new Point(12, 94);
            rq_textBox1.Name = "rq_textBox1";
            rq_textBox1.Size = new Size(169, 23);
            rq_textBox1.TabIndex = 3;
            // 
            // rq_checkbox1
            // 
            rq_checkbox1.AutoSize = true;
            rq_checkbox1.Location = new Point(12, 123);
            rq_checkbox1.Name = "rq_checkbox1";
            rq_checkbox1.Size = new Size(105, 19);
            rq_checkbox1.TabIndex = 5;
            rq_checkbox1.Text = "Mark as urgent";
            rq_checkbox1.UseVisualStyleBackColor = true;
            rq_checkbox1.CheckedChanged += rq_checkbox1_CheckedChanged;
            // 
            // rq_label3
            // 
            rq_label3.AutoSize = true;
            rq_label3.Location = new Point(34, 145);
            rq_label3.Name = "rq_label3";
            rq_label3.Size = new Size(36, 15);
            rq_label3.TabIndex = 6;
            rq_label3.Text = "Price:";
            // 
            // rq_pricelabel
            // 
            rq_pricelabel.AutoSize = true;
            rq_pricelabel.Location = new Point(80, 145);
            rq_pricelabel.Name = "rq_pricelabel";
            rq_pricelabel.Size = new Size(28, 15);
            rq_pricelabel.TabIndex = 7;
            rq_pricelabel.Text = "0.00";
            // 
            // rq_label4
            // 
            rq_label4.AutoSize = true;
            rq_label4.Location = new Point(13, 170);
            rq_label4.Name = "rq_label4";
            rq_label4.Size = new Size(57, 15);
            rq_label4.TabIndex = 8;
            rq_label4.Text = "Discount:";
            // 
            // rq_discountlabel
            // 
            rq_discountlabel.AutoSize = true;
            rq_discountlabel.Location = new Point(80, 170);
            rq_discountlabel.Name = "rq_discountlabel";
            rq_discountlabel.Size = new Size(28, 15);
            rq_discountlabel.TabIndex = 9;
            rq_discountlabel.Text = "0.00";
            // 
            // rq_addbutton
            // 
            rq_addbutton.Location = new Point(12, 260);
            rq_addbutton.Name = "rq_addbutton";
            rq_addbutton.Size = new Size(169, 42);
            rq_addbutton.TabIndex = 10;
            rq_addbutton.Text = "Add to list";
            rq_addbutton.UseVisualStyleBackColor = true;
            rq_addbutton.Click += rq_addbutton_Click;
            // 
            // rq_exitbutton
            // 
            rq_exitbutton.Location = new Point(12, 308);
            rq_exitbutton.Name = "rq_exitbutton";
            rq_exitbutton.Size = new Size(169, 43);
            rq_exitbutton.TabIndex = 11;
            rq_exitbutton.Text = "Exit";
            rq_exitbutton.UseVisualStyleBackColor = true;
            rq_exitbutton.Click += rq_exitbutton_Click;
            // 
            // rqGridView1
            // 
            rqGridView1.AllowUserToResizeColumns = false;
            rqGridView1.AllowUserToResizeRows = false;
            rqGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rqGridView1.Location = new Point(218, 37);
            rqGridView1.Name = "rqGridView1";
            rqGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rqGridView1.Size = new Size(837, 279);
            rqGridView1.TabIndex = 12;
            // 
            // rq_calcbutton
            // 
            rq_calcbutton.Location = new Point(75, 222);
            rq_calcbutton.Name = "rq_calcbutton";
            rq_calcbutton.Size = new Size(106, 23);
            rq_calcbutton.TabIndex = 13;
            rq_calcbutton.Text = "Calculate  Price";
            rq_calcbutton.UseVisualStyleBackColor = true;
            rq_calcbutton.Click += rq_calcbutton_Click;
            // 
            // rq_label5
            // 
            rq_label5.AutoSize = true;
            rq_label5.Location = new Point(5, 196);
            rq_label5.Name = "rq_label5";
            rq_label5.Size = new Size(65, 15);
            rq_label5.TabIndex = 14;
            rq_label5.Text = "Urgent fee:";
            // 
            // rq_surchargelabel
            // 
            rq_surchargelabel.AutoSize = true;
            rq_surchargelabel.Location = new Point(80, 196);
            rq_surchargelabel.Name = "rq_surchargelabel";
            rq_surchargelabel.Size = new Size(28, 15);
            rq_surchargelabel.TabIndex = 15;
            rq_surchargelabel.Text = "0.00";
            // 
            // rq_label6
            // 
            rq_label6.AutoSize = true;
            rq_label6.Location = new Point(212, 334);
            rq_label6.Name = "rq_label6";
            rq_label6.Size = new Size(64, 15);
            rq_label6.TabIndex = 16;
            rq_label6.Text = "Total Price:";
            // 
            // rq_totalprice
            // 
            rq_totalprice.AutoSize = true;
            rq_totalprice.Location = new Point(282, 334);
            rq_totalprice.Name = "rq_totalprice";
            rq_totalprice.Size = new Size(28, 15);
            rq_totalprice.TabIndex = 17;
            rq_totalprice.Text = "0.00";
            // 
            // rq_deletebutton
            // 
            rq_deletebutton.Location = new Point(901, 330);
            rq_deletebutton.Name = "rq_deletebutton";
            rq_deletebutton.Size = new Size(75, 23);
            rq_deletebutton.TabIndex = 19;
            rq_deletebutton.Text = "Delete";
            rq_deletebutton.UseVisualStyleBackColor = true;
            rq_deletebutton.Click += rq_deletebutton_Click;
            // 
            // rq_paybutton
            // 
            rq_paybutton.Location = new Point(982, 330);
            rq_paybutton.Name = "rq_paybutton";
            rq_paybutton.Size = new Size(75, 23);
            rq_paybutton.TabIndex = 20;
            rq_paybutton.Text = "Pay";
            rq_paybutton.UseVisualStyleBackColor = true;
            rq_paybutton.Click += rq_paybutton_Click;
            // 
            // Request_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 359);
            Controls.Add(rq_paybutton);
            Controls.Add(rq_deletebutton);
            Controls.Add(rq_totalprice);
            Controls.Add(rq_label6);
            Controls.Add(rq_surchargelabel);
            Controls.Add(rq_label5);
            Controls.Add(rq_calcbutton);
            Controls.Add(rqGridView1);
            Controls.Add(rq_exitbutton);
            Controls.Add(rq_addbutton);
            Controls.Add(rq_discountlabel);
            Controls.Add(rq_label4);
            Controls.Add(rq_pricelabel);
            Controls.Add(rq_label3);
            Controls.Add(rq_checkbox1);
            Controls.Add(rq_textBox1);
            Controls.Add(rq_label2);
            Controls.Add(rq_comboBox1);
            Controls.Add(rq_label1);
            Name = "Request_form";
            Text = "Request_form";
            Load += Request_form_Load;
            ((System.ComponentModel.ISupportInitialize)rqGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label rq_label1;
        private ComboBox rq_comboBox1;
        private Label rq_label2;
        private TextBox rq_textBox1;
        private CheckBox rq_checkbox1;
        private Label rq_label3;
        private Label rq_pricelabel;
        private Label rq_label4;
        private Label rq_discountlabel;
        private Button rq_addbutton;
        private Button rq_exitbutton;
        private DataGridView rqGridView1;
        private Button rq_calcbutton;
        private Label rq_label5;
        private Label rq_surchargelabel;
        private Label rq_label6;
        private Label rq_totalprice;
        private Button rq_deletebutton;
        private Button rq_paybutton;
    }
}