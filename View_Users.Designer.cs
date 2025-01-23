namespace Admin_Part
{
    partial class View_Users
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnMenubtn1 = new System.Windows.Forms.Button();
            this.UserPasswordtxt = new System.Windows.Forms.TextBox();
            this.LoginNametxt = new System.Windows.Forms.TextBox();
            this.UserPhonetxt = new System.Windows.Forms.TextBox();
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.RegisterUsersbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.UserRole_ComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.NewUserRole_comboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.UserIDtxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.NewUserPhonetxt = new System.Windows.Forms.TextBox();
            this.NewUserPasswordtxt = new System.Windows.Forms.TextBox();
            this.UpdateUsersProfilebtn = new System.Windows.Forms.Button();
            this.NewLoginNametxt = new System.Windows.Forms.TextBox();
            this.NewFullNametxt = new System.Windows.Forms.TextBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_Group48DataSet = new Admin_Part.Assignment_Group48DataSet();
            this.usersTableAdapter = new Admin_Part.Assignment_Group48DataSetTableAdapters.UsersTableAdapter();
            this.UsersTable_dataGridView = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userPasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userRoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assignment_Group48DataSet1 = new Admin_Part.Assignment_Group48DataSet();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_Group48DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_Group48DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1302, 123);
            this.panel1.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(378, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin / View Users";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Users Profile Data:";
            // 
            // ReturnMenubtn1
            // 
            this.ReturnMenubtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnMenubtn1.Location = new System.Drawing.Point(1, 130);
            this.ReturnMenubtn1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ReturnMenubtn1.Name = "ReturnMenubtn1";
            this.ReturnMenubtn1.Size = new System.Drawing.Size(112, 41);
            this.ReturnMenubtn1.TabIndex = 25;
            this.ReturnMenubtn1.Text = "Main";
            this.ReturnMenubtn1.UseVisualStyleBackColor = true;
            this.ReturnMenubtn1.Click += new System.EventHandler(this.ReturnMenubtn1_Click);
            // 
            // UserPasswordtxt
            // 
            this.UserPasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordtxt.Location = new System.Drawing.Point(367, 210);
            this.UserPasswordtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UserPasswordtxt.Name = "UserPasswordtxt";
            this.UserPasswordtxt.Size = new System.Drawing.Size(222, 26);
            this.UserPasswordtxt.TabIndex = 30;
            this.UserPasswordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UserPasswordtxt.TextChanged += new System.EventHandler(this.UserPassowrdtxt_TextChanged);
            // 
            // LoginNametxt
            // 
            this.LoginNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginNametxt.Location = new System.Drawing.Point(8, 210);
            this.LoginNametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LoginNametxt.Name = "LoginNametxt";
            this.LoginNametxt.Size = new System.Drawing.Size(234, 26);
            this.LoginNametxt.TabIndex = 29;
            this.LoginNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UserPhonetxt
            // 
            this.UserPhonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPhonetxt.Location = new System.Drawing.Point(367, 108);
            this.UserPhonetxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UserPhonetxt.Name = "UserPhonetxt";
            this.UserPhonetxt.Size = new System.Drawing.Size(222, 26);
            this.UserPhonetxt.TabIndex = 28;
            this.UserPhonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Usernametxt
            // 
            this.Usernametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(8, 108);
            this.Usernametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(234, 26);
            this.Usernametxt.TabIndex = 27;
            this.Usernametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegisterUsersbtn
            // 
            this.RegisterUsersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterUsersbtn.Location = new System.Drawing.Point(297, 299);
            this.RegisterUsersbtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.RegisterUsersbtn.Name = "RegisterUsersbtn";
            this.RegisterUsersbtn.Size = new System.Drawing.Size(133, 56);
            this.RegisterUsersbtn.TabIndex = 26;
            this.RegisterUsersbtn.Text = "Register";
            this.RegisterUsersbtn.UseVisualStyleBackColor = true;
            this.RegisterUsersbtn.Click += new System.EventHandler(this.RegisterUsersbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.UserRole_ComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.UserPhonetxt);
            this.groupBox1.Controls.Add(this.UserPasswordtxt);
            this.groupBox1.Controls.Add(this.RegisterUsersbtn);
            this.groupBox1.Controls.Add(this.LoginNametxt);
            this.groupBox1.Controls.Add(this.Usernametxt);
            this.groupBox1.Location = new System.Drawing.Point(16, 364);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(613, 380);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Register_New_Users";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 258);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(183, 24);
            this.label14.TabIndex = 53;
            this.label14.Text = "Choose a User Role";
            // 
            // UserRole_ComboBox
            // 
            this.UserRole_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserRole_ComboBox.FormattingEnabled = true;
            this.UserRole_ComboBox.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Manager",
            "Worker"});
            this.UserRole_ComboBox.Location = new System.Drawing.Point(8, 285);
            this.UserRole_ComboBox.Name = "UserRole_ComboBox";
            this.UserRole_ComboBox.Size = new System.Drawing.Size(234, 24);
            this.UserRole_ComboBox.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(370, 182);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 25);
            this.label7.TabIndex = 35;
            this.label7.Text = "Enter a UserPassword:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "Enter a Login Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 80);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Enter a UserPhone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Enter a Full UserName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(183, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Register New Users";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.NewUserRole_comboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.UserIDtxt);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.NewUserPhonetxt);
            this.groupBox2.Controls.Add(this.NewUserPasswordtxt);
            this.groupBox2.Controls.Add(this.UpdateUsersProfilebtn);
            this.groupBox2.Controls.Add(this.NewLoginNametxt);
            this.groupBox2.Controls.Add(this.NewFullNametxt);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(635, 347);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox2.Size = new System.Drawing.Size(658, 388);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Users Profile";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(371, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(228, 25);
            this.label13.TabIndex = 52;
            this.label13.Text = "Choose a new User Role";
            // 
            // NewUserRole_comboBox
            // 
            this.NewUserRole_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NewUserRole_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserRole_comboBox.FormattingEnabled = true;
            this.NewUserRole_comboBox.Items.AddRange(new object[] {
            "Admin",
            "Customer",
            "Manager",
            "Worker"});
            this.NewUserRole_comboBox.Location = new System.Drawing.Point(374, 261);
            this.NewUserRole_comboBox.Name = "NewUserRole_comboBox";
            this.NewUserRole_comboBox.Size = new System.Drawing.Size(275, 26);
            this.NewUserRole_comboBox.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 58);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(301, 25);
            this.label12.TabIndex = 49;
            this.label12.Text = "Enter a UserID To Update Profile:";
            // 
            // UserIDtxt
            // 
            this.UserIDtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIDtxt.Location = new System.Drawing.Point(27, 87);
            this.UserIDtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UserIDtxt.Name = "UserIDtxt";
            this.UserIDtxt.Size = new System.Drawing.Size(275, 26);
            this.UserIDtxt.TabIndex = 48;
            this.UserIDtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 226);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(253, 25);
            this.label8.TabIndex = 47;
            this.label8.Text = "Enter a new UserPassword:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(368, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(231, 25);
            this.label9.TabIndex = 46;
            this.label9.Text = "Enter a new Login Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(21, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(224, 25);
            this.label10.TabIndex = 44;
            this.label10.Text = "Enter a new UserPhone:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(368, 58);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(255, 25);
            this.label11.TabIndex = 45;
            this.label11.Text = "Enter a new Full UserName:";
            // 
            // NewUserPhonetxt
            // 
            this.NewUserPhonetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserPhonetxt.Location = new System.Drawing.Point(26, 171);
            this.NewUserPhonetxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NewUserPhonetxt.Name = "NewUserPhonetxt";
            this.NewUserPhonetxt.Size = new System.Drawing.Size(276, 26);
            this.NewUserPhonetxt.TabIndex = 41;
            this.NewUserPhonetxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewUserPasswordtxt
            // 
            this.NewUserPasswordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewUserPasswordtxt.Location = new System.Drawing.Point(27, 261);
            this.NewUserPasswordtxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NewUserPasswordtxt.Name = "NewUserPasswordtxt";
            this.NewUserPasswordtxt.Size = new System.Drawing.Size(275, 26);
            this.NewUserPasswordtxt.TabIndex = 43;
            this.NewUserPasswordtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateUsersProfilebtn
            // 
            this.UpdateUsersProfilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateUsersProfilebtn.Location = new System.Drawing.Point(298, 329);
            this.UpdateUsersProfilebtn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.UpdateUsersProfilebtn.Name = "UpdateUsersProfilebtn";
            this.UpdateUsersProfilebtn.Size = new System.Drawing.Size(118, 51);
            this.UpdateUsersProfilebtn.TabIndex = 39;
            this.UpdateUsersProfilebtn.Text = "Update";
            this.UpdateUsersProfilebtn.UseVisualStyleBackColor = true;
            this.UpdateUsersProfilebtn.Click += new System.EventHandler(this.UpdateUsersProfilebtn_Click);
            // 
            // NewLoginNametxt
            // 
            this.NewLoginNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewLoginNametxt.Location = new System.Drawing.Point(374, 171);
            this.NewLoginNametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NewLoginNametxt.Name = "NewLoginNametxt";
            this.NewLoginNametxt.Size = new System.Drawing.Size(275, 26);
            this.NewLoginNametxt.TabIndex = 42;
            this.NewLoginNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewFullNametxt
            // 
            this.NewFullNametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFullNametxt.Location = new System.Drawing.Point(374, 87);
            this.NewFullNametxt.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.NewFullNametxt.Name = "NewFullNametxt";
            this.NewFullNametxt.Size = new System.Drawing.Size(275, 26);
            this.NewFullNametxt.TabIndex = 40;
            this.NewFullNametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.assignment_Group48DataSet;
            // 
            // assignment_Group48DataSet
            // 
            this.assignment_Group48DataSet.DataSetName = "Assignment_Group48DataSet";
            this.assignment_Group48DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UsersTable_dataGridView
            // 
            this.UsersTable_dataGridView.AllowUserToDeleteRows = false;
            this.UsersTable_dataGridView.AutoGenerateColumns = false;
            this.UsersTable_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersTable_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersTable_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.userPhoneDataGridViewTextBoxColumn,
            this.loginNameDataGridViewTextBoxColumn,
            this.userPasswordDataGridViewTextBoxColumn,
            this.userRoleDataGridViewTextBoxColumn});
            this.UsersTable_dataGridView.DataSource = this.usersBindingSource1;
            this.UsersTable_dataGridView.Location = new System.Drawing.Point(126, 190);
            this.UsersTable_dataGridView.Name = "UsersTable_dataGridView";
            this.UsersTable_dataGridView.RowHeadersWidth = 51;
            this.UsersTable_dataGridView.RowTemplate.Height = 26;
            this.UsersTable_dataGridView.Size = new System.Drawing.Size(1071, 150);
            this.UsersTable_dataGridView.TabIndex = 33;
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            this.userIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "Full_Name";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            // 
            // userPhoneDataGridViewTextBoxColumn
            // 
            this.userPhoneDataGridViewTextBoxColumn.DataPropertyName = "User_Phone";
            this.userPhoneDataGridViewTextBoxColumn.HeaderText = "User_Phone";
            this.userPhoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPhoneDataGridViewTextBoxColumn.Name = "userPhoneDataGridViewTextBoxColumn";
            // 
            // loginNameDataGridViewTextBoxColumn
            // 
            this.loginNameDataGridViewTextBoxColumn.DataPropertyName = "Login_Name";
            this.loginNameDataGridViewTextBoxColumn.HeaderText = "Login_Name";
            this.loginNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loginNameDataGridViewTextBoxColumn.Name = "loginNameDataGridViewTextBoxColumn";
            // 
            // userPasswordDataGridViewTextBoxColumn
            // 
            this.userPasswordDataGridViewTextBoxColumn.DataPropertyName = "User_Password";
            this.userPasswordDataGridViewTextBoxColumn.HeaderText = "User_Password";
            this.userPasswordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userPasswordDataGridViewTextBoxColumn.Name = "userPasswordDataGridViewTextBoxColumn";
            // 
            // userRoleDataGridViewTextBoxColumn
            // 
            this.userRoleDataGridViewTextBoxColumn.DataPropertyName = "User_Role";
            this.userRoleDataGridViewTextBoxColumn.HeaderText = "User_Role";
            this.userRoleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.userRoleDataGridViewTextBoxColumn.Name = "userRoleDataGridViewTextBoxColumn";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "Users";
            this.usersBindingSource1.DataSource = this.assignment_Group48DataSet1;
            // 
            // assignment_Group48DataSet1
            // 
            this.assignment_Group48DataSet1.DataSetName = "Assignment_Group48DataSet";
            this.assignment_Group48DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1303, 732);
            this.Controls.Add(this.UsersTable_dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ReturnMenubtn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "View_Users";
            this.Text = "View_Users";
            this.Load += new System.EventHandler(this.View_Users_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_Group48DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assignment_Group48DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReturnMenubtn1;
        private System.Windows.Forms.TextBox UserPasswordtxt;
        private System.Windows.Forms.TextBox LoginNametxt;
        private System.Windows.Forms.TextBox UserPhonetxt;
        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.Button RegisterUsersbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox NewUserPhonetxt;
        private System.Windows.Forms.TextBox NewUserPasswordtxt;
        private System.Windows.Forms.Button UpdateUsersProfilebtn;
        private System.Windows.Forms.TextBox NewLoginNametxt;
        private System.Windows.Forms.TextBox NewFullNametxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox UserIDtxt;
        private Assignment_Group48DataSet assignment_Group48DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private Assignment_Group48DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox UserRole_ComboBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox NewUserRole_comboBox;
        private System.Windows.Forms.DataGridView UsersTable_dataGridView;
        private Assignment_Group48DataSet assignment_Group48DataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userPasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userRoleDataGridViewTextBoxColumn;
    }
}