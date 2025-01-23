using System.Drawing;
using System.Windows.Forms;

namespace assignment_lole
{
    partial class Customer_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Hello_label = new Label();
            Hello_label_name = new Label();
            services_label = new Label();
            Services_button = new Button();
            Request_label = new Label();
            Request_button = new Button();
            History_label = new Label();
            History_button = new Button();
            Exit_button = new Button();
            Profile_button = new Button();
            SuspendLayout();
            // 
            // Hello_label
            // 
            Hello_label.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hello_label.Location = new Point(-6, 9);
            Hello_label.MaximumSize = new Size(1000, 1000);
            Hello_label.Name = "Hello_label";
            Hello_label.Size = new Size(95, 60);
            Hello_label.TabIndex = 1;
            Hello_label.Text = "Hello";
            // 
            // Hello_label_name
            // 
            Hello_label_name.AutoSize = true;
            Hello_label_name.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Hello_label_name.Location = new Point(76, 9);
            Hello_label_name.Name = "Hello_label_name";
            Hello_label_name.Size = new Size(186, 45);
            Hello_label_name.TabIndex = 2;
            Hello_label_name.Text = "Placeholder";
            // 
            // services_label
            // 
            services_label.AutoSize = true;
            services_label.Location = new Point(12, 69);
            services_label.Name = "services_label";
            services_label.Size = new Size(178, 15);
            services_label.TabIndex = 3;
            services_label.Text = "View a list of services we provide";
            // 
            // Services_button
            // 
            Services_button.Location = new Point(12, 87);
            Services_button.Name = "Services_button";
            Services_button.Size = new Size(269, 44);
            Services_button.TabIndex = 4;
            Services_button.Text = "Services";
            Services_button.UseVisualStyleBackColor = true;
            Services_button.Click += Services_button_Click;
            // 
            // Request_label
            // 
            Request_label.AutoSize = true;
            Request_label.Location = new Point(12, 134);
            Request_label.Name = "Request_label";
            Request_label.Size = new Size(182, 15);
            Request_label.TabIndex = 5;
            Request_label.Text = "Submit a request for our services:";
            // 
            // Request_button
            // 
            Request_button.Location = new Point(12, 152);
            Request_button.Name = "Request_button";
            Request_button.Size = new Size(269, 43);
            Request_button.TabIndex = 6;
            Request_button.Text = "Request";
            Request_button.UseVisualStyleBackColor = true;
            Request_button.Click += Request_button_Click;
            // 
            // History_label
            // 
            History_label.AutoSize = true;
            History_label.Location = new Point(12, 198);
            History_label.Name = "History_label";
            History_label.Size = new Size(129, 15);
            History_label.TabIndex = 7;
            History_label.Text = "View your order history";
            // 
            // History_button
            // 
            History_button.Location = new Point(12, 216);
            History_button.Name = "History_button";
            History_button.Size = new Size(269, 47);
            History_button.TabIndex = 8;
            History_button.Text = "History";
            History_button.UseVisualStyleBackColor = true;
            History_button.Click += History_button_Click;
            // 
            // Exit_button
            // 
            Exit_button.Location = new Point(301, 240);
            Exit_button.Name = "Exit_button";
            Exit_button.Size = new Size(75, 23);
            Exit_button.TabIndex = 9;
            Exit_button.Text = "Exit";
            Exit_button.UseVisualStyleBackColor = true;
            Exit_button.Click += Exit_button_Click;
            // 
            // Profile_button
            // 
            Profile_button.Location = new Point(301, 211);
            Profile_button.Name = "Profile_button";
            Profile_button.Size = new Size(75, 23);
            Profile_button.TabIndex = 10;
            Profile_button.Text = "Profile";
            Profile_button.UseVisualStyleBackColor = true;
            Profile_button.Click += Profile_button_Click;
            // 
            // Customer_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 273);
            Controls.Add(Profile_button);
            Controls.Add(Exit_button);
            Controls.Add(History_button);
            Controls.Add(History_label);
            Controls.Add(Request_button);
            Controls.Add(Request_label);
            Controls.Add(Services_button);
            Controls.Add(services_label);
            Controls.Add(Hello_label_name);
            Controls.Add(Hello_label);
            Name = "Customer_form";
            Text = "Printing Services";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login_label;
        private Label Hello_label;
        private Label Hello_label_name;
        private Label services_label;
        private Button Services_button;
        private Label Request_label;
        private Button Request_button;
        private Label History_label;
        private Button History_button;
        private Button Exit_button;
        private Button Profile_button;
    }
}
