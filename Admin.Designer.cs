namespace Admin_Part
{
    partial class Admin
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
            ViewUsersbtn = new System.Windows.Forms.Button();
            GenerateReportsbtn = new System.Windows.Forms.Button();
            UpdateUsersProfilebtn = new System.Windows.Forms.Button();
            ReturnLoginPagebtn = new System.Windows.Forms.Button();
            Exitbtn = new System.Windows.Forms.Button();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ViewUsersbtn
            // 
            ViewUsersbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ViewUsersbtn.Location = new System.Drawing.Point(95, 285);
            ViewUsersbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ViewUsersbtn.Name = "ViewUsersbtn";
            ViewUsersbtn.Size = new System.Drawing.Size(231, 111);
            ViewUsersbtn.TabIndex = 1;
            ViewUsersbtn.Text = "View All The Users";
            ViewUsersbtn.UseVisualStyleBackColor = true;
            ViewUsersbtn.Click += ViewUsersbtn_Click;
            // 
            // GenerateReportsbtn
            // 
            GenerateReportsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            GenerateReportsbtn.Location = new System.Drawing.Point(777, 285);
            GenerateReportsbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            GenerateReportsbtn.Name = "GenerateReportsbtn";
            GenerateReportsbtn.Size = new System.Drawing.Size(229, 111);
            GenerateReportsbtn.TabIndex = 2;
            GenerateReportsbtn.Text = "Generate Reports";
            GenerateReportsbtn.UseVisualStyleBackColor = true;
            GenerateReportsbtn.Click += GenerateReportsbtn_Click;
            // 
            // UpdateUsersProfilebtn
            // 
            UpdateUsersProfilebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UpdateUsersProfilebtn.Location = new System.Drawing.Point(450, 285);
            UpdateUsersProfilebtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            UpdateUsersProfilebtn.Name = "UpdateUsersProfilebtn";
            UpdateUsersProfilebtn.Size = new System.Drawing.Size(226, 111);
            UpdateUsersProfilebtn.TabIndex = 3;
            UpdateUsersProfilebtn.Text = "Update Your Profile";
            UpdateUsersProfilebtn.UseVisualStyleBackColor = true;
            UpdateUsersProfilebtn.Click += UpdateUsersProfilebtn_Click;
            // 
            // ReturnLoginPagebtn
            // 
            ReturnLoginPagebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            ReturnLoginPagebtn.Location = new System.Drawing.Point(271, 486);
            ReturnLoginPagebtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            ReturnLoginPagebtn.Name = "ReturnLoginPagebtn";
            ReturnLoginPagebtn.Size = new System.Drawing.Size(230, 106);
            ReturnLoginPagebtn.TabIndex = 5;
            ReturnLoginPagebtn.Text = "Return To The LoginPage";
            ReturnLoginPagebtn.UseVisualStyleBackColor = true;
            ReturnLoginPagebtn.Click += ReturnLoginPagebtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Exitbtn.Location = new System.Drawing.Point(593, 486);
            Exitbtn.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new System.Drawing.Size(230, 106);
            Exitbtn.TabIndex = 6;
            Exitbtn.Text = "Exit The System";
            Exitbtn.UseVisualStyleBackColor = true;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new System.Drawing.Point(-9, 1);
            panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1086, 154);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(137, 12);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(750, 91);
            label1.TabIndex = 3;
            label1.Text = "Admin / Menu Page";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Admin
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(1066, 692);
            Controls.Add(panel1);
            Controls.Add(Exitbtn);
            Controls.Add(ReturnLoginPagebtn);
            Controls.Add(UpdateUsersProfilebtn);
            Controls.Add(GenerateReportsbtn);
            Controls.Add(ViewUsersbtn);
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            Name = "Admin";
            Text = " ";
            Load += Admin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Button ViewUsersbtn;
        private System.Windows.Forms.Button GenerateReportsbtn;
        private System.Windows.Forms.Button UpdateUsersProfilebtn;
        private System.Windows.Forms.Button ReturnLoginPagebtn;
        private System.Windows.Forms.Button Exitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}

