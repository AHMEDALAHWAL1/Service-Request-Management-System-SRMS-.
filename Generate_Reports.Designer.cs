namespace Admin_Part
{
    partial class Generate_Reports
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
            this.ReturnMenubtn3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ServiceReport_MonthCoBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CustomerReport_AllCustomerRDB = new System.Windows.Forms.RadioButton();
            this.CustomerReport_CustomerRDB = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerReport_MonthCoBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CustomerReport_CustomerIDtxtb = new System.Windows.Forms.TextBox();
            this.ChooseReportcombBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Year_TextBox = new System.Windows.Forms.TextBox();
            this.Reports_ListBox = new System.Windows.Forms.ListBox();
            this.Reportsbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ReturnMenubtn3
            // 
            this.ReturnMenubtn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenubtn3.Location = new System.Drawing.Point(1, 123);
            this.ReturnMenubtn3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReturnMenubtn3.Name = "ReturnMenubtn3";
            this.ReturnMenubtn3.Size = new System.Drawing.Size(112, 41);
            this.ReturnMenubtn3.TabIndex = 36;
            this.ReturnMenubtn3.Text = "Main";
            this.ReturnMenubtn3.UseVisualStyleBackColor = true;
            this.ReturnMenubtn3.Click += new System.EventHandler(this.ReturnMenubtn3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1119, 123);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "Admin / Generate Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 29);
            this.label3.TabIndex = 41;
            this.label3.Text = "Choose The Report Type:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ServiceReport_MonthCoBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 221);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(398, 104);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Service Report Filters";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 50;
            this.label4.Text = "Month:";
            // 
            // ServiceReport_MonthCoBox
            // 
            this.ServiceReport_MonthCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceReport_MonthCoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceReport_MonthCoBox.FormattingEnabled = true;
            this.ServiceReport_MonthCoBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.ServiceReport_MonthCoBox.Location = new System.Drawing.Point(189, 43);
            this.ServiceReport_MonthCoBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ServiceReport_MonthCoBox.Name = "ServiceReport_MonthCoBox";
            this.ServiceReport_MonthCoBox.Size = new System.Drawing.Size(138, 26);
            this.ServiceReport_MonthCoBox.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CustomerReport_AllCustomerRDB);
            this.groupBox2.Controls.Add(this.CustomerReport_CustomerRDB);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.CustomerReport_MonthCoBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.CustomerReport_CustomerIDtxtb);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(1, 397);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(421, 159);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customer Report Filters";
            // 
            // CustomerReport_AllCustomerRDB
            // 
            this.CustomerReport_AllCustomerRDB.AutoSize = true;
            this.CustomerReport_AllCustomerRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport_AllCustomerRDB.Location = new System.Drawing.Point(230, 35);
            this.CustomerReport_AllCustomerRDB.Name = "CustomerReport_AllCustomerRDB";
            this.CustomerReport_AllCustomerRDB.Size = new System.Drawing.Size(119, 22);
            this.CustomerReport_AllCustomerRDB.TabIndex = 57;
            this.CustomerReport_AllCustomerRDB.TabStop = true;
            this.CustomerReport_AllCustomerRDB.Text = "All customers";
            this.CustomerReport_AllCustomerRDB.UseVisualStyleBackColor = true;
            // 
            // CustomerReport_CustomerRDB
            // 
            this.CustomerReport_CustomerRDB.AutoSize = true;
            this.CustomerReport_CustomerRDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport_CustomerRDB.Location = new System.Drawing.Point(21, 35);
            this.CustomerReport_CustomerRDB.Name = "CustomerReport_CustomerRDB";
            this.CustomerReport_CustomerRDB.Size = new System.Drawing.Size(125, 22);
            this.CustomerReport_CustomerRDB.TabIndex = 56;
            this.CustomerReport_CustomerRDB.TabStop = true;
            this.CustomerReport_CustomerRDB.Text = "By a customer";
            this.CustomerReport_CustomerRDB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 54;
            this.label8.Text = "Month:";
            // 
            // CustomerReport_MonthCoBox
            // 
            this.CustomerReport_MonthCoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerReport_MonthCoBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport_MonthCoBox.FormattingEnabled = true;
            this.CustomerReport_MonthCoBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.CustomerReport_MonthCoBox.Location = new System.Drawing.Point(189, 108);
            this.CustomerReport_MonthCoBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CustomerReport_MonthCoBox.Name = "CustomerReport_MonthCoBox";
            this.CustomerReport_MonthCoBox.Size = new System.Drawing.Size(138, 26);
            this.CustomerReport_MonthCoBox.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 18);
            this.label6.TabIndex = 47;
            this.label6.Text = "Enter the CustomerID";
            // 
            // CustomerReport_CustomerIDtxtb
            // 
            this.CustomerReport_CustomerIDtxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerReport_CustomerIDtxtb.Location = new System.Drawing.Point(189, 76);
            this.CustomerReport_CustomerIDtxtb.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.CustomerReport_CustomerIDtxtb.Name = "CustomerReport_CustomerIDtxtb";
            this.CustomerReport_CustomerIDtxtb.Size = new System.Drawing.Size(196, 24);
            this.CustomerReport_CustomerIDtxtb.TabIndex = 45;
            // 
            // ChooseReportcombBox
            // 
            this.ChooseReportcombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChooseReportcombBox.FormattingEnabled = true;
            this.ChooseReportcombBox.Items.AddRange(new object[] {
            "Yearly Report",
            "Service Request Report",
            "Customer Report"});
            this.ChooseReportcombBox.Location = new System.Drawing.Point(299, 162);
            this.ChooseReportcombBox.Name = "ChooseReportcombBox";
            this.ChooseReportcombBox.Size = new System.Drawing.Size(294, 24);
            this.ChooseReportcombBox.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(754, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 29);
            this.label5.TabIndex = 51;
            this.label5.Text = "Enter The Year:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Year_TextBox
            // 
            this.Year_TextBox.Location = new System.Drawing.Point(760, 162);
            this.Year_TextBox.Name = "Year_TextBox";
            this.Year_TextBox.Size = new System.Drawing.Size(202, 22);
            this.Year_TextBox.TabIndex = 52;
            // 
            // Reports_ListBox
            // 
            this.Reports_ListBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports_ListBox.FormattingEnabled = true;
            this.Reports_ListBox.ItemHeight = 22;
            this.Reports_ListBox.Location = new System.Drawing.Point(466, 221);
            this.Reports_ListBox.Name = "Reports_ListBox";
            this.Reports_ListBox.Size = new System.Drawing.Size(636, 268);
            this.Reports_ListBox.TabIndex = 53;
            // 
            // Reportsbtn
            // 
            this.Reportsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportsbtn.Location = new System.Drawing.Point(581, 518);
            this.Reportsbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Reportsbtn.Name = "Reportsbtn";
            this.Reportsbtn.Size = new System.Drawing.Size(382, 47);
            this.Reportsbtn.TabIndex = 54;
            this.Reportsbtn.Text = "Generate The Report";
            this.Reportsbtn.UseVisualStyleBackColor = true;
            this.Reportsbtn.Click += new System.EventHandler(this.Reportsbtn_Click);
            // 
            // Generate_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 598);
            this.Controls.Add(this.Reportsbtn);
            this.Controls.Add(this.Reports_ListBox);
            this.Controls.Add(this.Year_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChooseReportcombBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ReturnMenubtn3);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Generate_Reports";
            this.Text = "Generate_Reports";
            this.Load += new System.EventHandler(this.Generate_Reports_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ReturnMenubtn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox CustomerReport_CustomerIDtxtb;
        private System.Windows.Forms.ComboBox ChooseReportcombBox;
        private System.Windows.Forms.ComboBox ServiceReport_MonthCoBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CustomerReport_MonthCoBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton CustomerReport_AllCustomerRDB;
        private System.Windows.Forms.RadioButton CustomerReport_CustomerRDB;
        private System.Windows.Forms.TextBox Year_TextBox;
        private System.Windows.Forms.ListBox Reports_ListBox;
        private System.Windows.Forms.Button Reportsbtn;
    }
}