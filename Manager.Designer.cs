namespace manangerPart3
{
    partial class Manager
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
            RequestdataGridView = new System.Windows.Forms.DataGridView();
            btnClose = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            lblFilterRequest = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            lblManager = new System.Windows.Forms.Label();
            RDassigned = new System.Windows.Forms.RadioButton();
            gBstatus = new System.Windows.Forms.GroupBox();
            btnUpdateProfile = new System.Windows.Forms.Button();
            FilterCombobox = new System.Windows.Forms.ComboBox();
            btnReturn = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            Workercombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)RequestdataGridView).BeginInit();
            panel1.SuspendLayout();
            gBstatus.SuspendLayout();
            SuspendLayout();
            // 
            // RequestdataGridView
            // 
            RequestdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            RequestdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RequestdataGridView.Location = new System.Drawing.Point(18, 130);
            RequestdataGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RequestdataGridView.Name = "RequestdataGridView";
            RequestdataGridView.RowHeadersWidth = 51;
            RequestdataGridView.RowTemplate.Height = 24;
            RequestdataGridView.Size = new System.Drawing.Size(601, 409);
            RequestdataGridView.TabIndex = 0;
            RequestdataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnClose
            // 
            btnClose.Location = new System.Drawing.Point(668, 456);
            btnClose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new System.Drawing.Size(187, 82);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += button1_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(668, 242);
            btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(187, 82);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += button2_Click;
            // 
            // lblFilterRequest
            // 
            lblFilterRequest.AutoSize = true;
            lblFilterRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblFilterRequest.Location = new System.Drawing.Point(13, 92);
            lblFilterRequest.Name = "lblFilterRequest";
            lblFilterRequest.Size = new System.Drawing.Size(156, 25);
            lblFilterRequest.TabIndex = 5;
            lblFilterRequest.Text = "Filter Requests";
            lblFilterRequest.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel1.Controls.Add(lblManager);
            panel1.Location = new System.Drawing.Point(-1, 2);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(912, 65);
            panel1.TabIndex = 10;
            // 
            // lblManager
            // 
            lblManager.AutoSize = true;
            lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblManager.Location = new System.Drawing.Point(312, 9);
            lblManager.Name = "lblManager";
            lblManager.Size = new System.Drawing.Size(139, 36);
            lblManager.TabIndex = 11;
            lblManager.Text = "Manager";
            // 
            // RDassigned
            // 
            RDassigned.AutoSize = true;
            RDassigned.Location = new System.Drawing.Point(17, 40);
            RDassigned.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            RDassigned.Name = "RDassigned";
            RDassigned.Size = new System.Drawing.Size(90, 24);
            RDassigned.TabIndex = 12;
            RDassigned.TabStop = true;
            RDassigned.Text = "Assigned";
            RDassigned.UseVisualStyleBackColor = true;
            RDassigned.CheckedChanged += RDassigned_CheckedChanged;
            // 
            // gBstatus
            // 
            gBstatus.BackColor = System.Drawing.SystemColors.InactiveCaption;
            gBstatus.Controls.Add(RDassigned);
            gBstatus.Location = new System.Drawing.Point(668, 130);
            gBstatus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gBstatus.Name = "gBstatus";
            gBstatus.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gBstatus.Size = new System.Drawing.Size(175, 84);
            gBstatus.TabIndex = 13;
            gBstatus.TabStop = false;
            gBstatus.Text = "Assign Job Status";
            gBstatus.Enter += groupBox1_Enter;
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Location = new System.Drawing.Point(761, 75);
            btnUpdateProfile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnUpdateProfile.Name = "btnUpdateProfile";
            btnUpdateProfile.Size = new System.Drawing.Size(121, 42);
            btnUpdateProfile.TabIndex = 14;
            btnUpdateProfile.Text = "Update Profile";
            btnUpdateProfile.UseVisualStyleBackColor = true;
            btnUpdateProfile.Click += button3_Click;
            // 
            // FilterCombobox
            // 
            FilterCombobox.FormattingEnabled = true;
            FilterCombobox.Items.AddRange(new object[] { "All", "New", "Assigned", "Work in progress", "completed " });
            FilterCombobox.Location = new System.Drawing.Point(175, 94);
            FilterCombobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            FilterCombobox.Name = "FilterCombobox";
            FilterCombobox.Size = new System.Drawing.Size(134, 28);
            FilterCombobox.TabIndex = 15;
            FilterCombobox.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
            // 
            // btnReturn
            // 
            btnReturn.Location = new System.Drawing.Point(668, 351);
            btnReturn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new System.Drawing.Size(187, 82);
            btnReturn.TabIndex = 16;
            btnReturn.Text = "Return";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.Location = new System.Drawing.Point(315, 97);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(149, 25);
            label1.TabIndex = 18;
            label1.Text = "Select Worker";
            // 
            // Workercombobox
            // 
            Workercombobox.FormattingEnabled = true;
            Workercombobox.Location = new System.Drawing.Point(468, 98);
            Workercombobox.Name = "Workercombobox";
            Workercombobox.Size = new System.Drawing.Size(151, 28);
            Workercombobox.TabIndex = 19;
            Workercombobox.SelectedIndexChanged += Workercombobox_SelectedIndexChanged;
            // 
            // Manager
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.InactiveCaption;
            ClientSize = new System.Drawing.Size(907, 562);
            Controls.Add(Workercombobox);
            Controls.Add(label1);
            Controls.Add(btnReturn);
            Controls.Add(FilterCombobox);
            Controls.Add(btnUpdateProfile);
            Controls.Add(gBstatus);
            Controls.Add(panel1);
            Controls.Add(lblFilterRequest);
            Controls.Add(btnUpdate);
            Controls.Add(btnClose);
            Controls.Add(RequestdataGridView);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Manager";
            Text = "Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)RequestdataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            gBstatus.ResumeLayout(false);
            gBstatus.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView RequestdataGridView;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblFilterRequest;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.RadioButton RDassigned;
        private System.Windows.Forms.GroupBox gBstatus;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.ComboBox FilterCombobox;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Workercombobox;
    }
}

