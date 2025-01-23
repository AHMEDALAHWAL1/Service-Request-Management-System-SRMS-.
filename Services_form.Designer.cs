using System.Drawing;
using System.Windows.Forms;

namespace assignment_lole
{
    partial class Services_form
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
            service_gbox1 = new GroupBox();
            service_label3 = new Label();
            service_label2 = new Label();
            label2 = new Label();
            label1 = new Label();
            service_label1 = new Label();
            service_gbox2 = new GroupBox();
            service_label6 = new Label();
            service_label5 = new Label();
            service_label4 = new Label();
            service_gbox3 = new GroupBox();
            service_label8 = new Label();
            service_label7 = new Label();
            services_label9 = new Label();
            svc_requestbutton = new Button();
            svc_exitbutton = new Button();
            service_gbox1.SuspendLayout();
            service_gbox2.SuspendLayout();
            service_gbox3.SuspendLayout();
            SuspendLayout();
            // 
            // service_gbox1
            // 
            service_gbox1.Controls.Add(service_label3);
            service_gbox1.Controls.Add(service_label2);
            service_gbox1.Controls.Add(label2);
            service_gbox1.Controls.Add(label1);
            service_gbox1.Controls.Add(service_label1);
            service_gbox1.Location = new Point(12, 29);
            service_gbox1.Name = "service_gbox1";
            service_gbox1.Size = new Size(356, 127);
            service_gbox1.TabIndex = 0;
            service_gbox1.TabStop = false;
            service_gbox1.Text = "Printing A4";
            // 
            // service_label3
            // 
            service_label3.AutoSize = true;
            service_label3.Location = new Point(117, 96);
            service_label3.Name = "service_label3";
            service_label3.Size = new Size(233, 15);
            service_label3.TabIndex = 3;
            service_label3.Text = "10% discount if printing 100 pages or more";
            // 
            // service_label2
            // 
            service_label2.AutoSize = true;
            service_label2.Location = new Point(6, 56);
            service_label2.Name = "service_label2";
            service_label2.Size = new Size(217, 15);
            service_label2.TabIndex = 3;
            service_label2.Text = "-Printing A4 coloured 2.50/RM per page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(655, 415);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 2;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(725, 419);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // service_label1
            // 
            service_label1.AutoSize = true;
            service_label1.Location = new Point(6, 32);
            service_label1.Name = "service_label1";
            service_label1.Size = new Size(250, 15);
            service_label1.TabIndex = 0;
            service_label1.Text = "-Printing A4 black and white 0.8/RM per page ";
            // 
            // service_gbox2
            // 
            service_gbox2.Controls.Add(service_label6);
            service_gbox2.Controls.Add(service_label5);
            service_gbox2.Controls.Add(service_label4);
            service_gbox2.Location = new Point(12, 174);
            service_gbox2.Name = "service_gbox2";
            service_gbox2.Size = new Size(356, 120);
            service_gbox2.TabIndex = 1;
            service_gbox2.TabStop = false;
            service_gbox2.Text = "Printing Posters";
            // 
            // service_label6
            // 
            service_label6.AutoSize = true;
            service_label6.Location = new Point(110, 93);
            service_label6.Name = "service_label6";
            service_label6.Size = new Size(240, 15);
            service_label6.TabIndex = 2;
            service_label6.Text = "10% discount if printing 100 posters or more";
            // 
            // service_label5
            // 
            service_label5.AutoSize = true;
            service_label5.Location = new Point(6, 57);
            service_label5.Name = "service_label5";
            service_label5.Size = new Size(193, 15);
            service_label5.TabIndex = 1;
            service_label5.Text = "-Printing A2/A3 3.00/RM per poster";
            // 
            // service_label4
            // 
            service_label4.AutoSize = true;
            service_label4.Location = new Point(6, 31);
            service_label4.Name = "service_label4";
            service_label4.Size = new Size(193, 15);
            service_label4.TabIndex = 0;
            service_label4.Text = "-Printing A0/A1 6.00/RM per poster";
            // 
            // service_gbox3
            // 
            service_gbox3.Controls.Add(service_label8);
            service_gbox3.Controls.Add(service_label7);
            service_gbox3.Location = new Point(393, 29);
            service_gbox3.Name = "service_gbox3";
            service_gbox3.Size = new Size(333, 127);
            service_gbox3.TabIndex = 2;
            service_gbox3.TabStop = false;
            service_gbox3.Text = "Binding";
            // 
            // service_label8
            // 
            service_label8.AutoSize = true;
            service_label8.Location = new Point(6, 56);
            service_label8.Name = "service_label8";
            service_label8.Size = new Size(167, 15);
            service_label8.TabIndex = 1;
            service_label8.Text = "-Hard cover 9.30/RM per book";
            // 
            // service_label7
            // 
            service_label7.AutoSize = true;
            service_label7.Location = new Point(6, 32);
            service_label7.Name = "service_label7";
            service_label7.Size = new Size(186, 15);
            service_label7.TabIndex = 0;
            service_label7.Text = "-Comb Binding 5.50/RM per book";
            // 
            // services_label9
            // 
            services_label9.AutoSize = true;
            services_label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            services_label9.Location = new Point(393, 174);
            services_label9.Name = "services_label9";
            services_label9.Size = new Size(341, 15);
            services_label9.TabIndex = 3;
            services_label9.Text = "All orders will incur a 30% surcharge fee if marked as urgent";
            // 
            // svc_requestbutton
            // 
            svc_requestbutton.Location = new Point(393, 219);
            svc_requestbutton.Name = "svc_requestbutton";
            svc_requestbutton.Size = new Size(167, 75);
            svc_requestbutton.TabIndex = 4;
            svc_requestbutton.Text = "Submit Request";
            svc_requestbutton.UseVisualStyleBackColor = true;
            svc_requestbutton.Click += svc_requestbutton_Click;
            // 
            // svc_exitbutton
            // 
            svc_exitbutton.Location = new Point(583, 219);
            svc_exitbutton.Name = "svc_exitbutton";
            svc_exitbutton.Size = new Size(143, 75);
            svc_exitbutton.TabIndex = 5;
            svc_exitbutton.Text = "Exit";
            svc_exitbutton.UseVisualStyleBackColor = true;
            svc_exitbutton.Click += svc_exitbutton_Click;
            // 
            // Services_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 314);
            Controls.Add(svc_exitbutton);
            Controls.Add(svc_requestbutton);
            Controls.Add(services_label9);
            Controls.Add(service_gbox3);
            Controls.Add(service_gbox2);
            Controls.Add(service_gbox1);
            Name = "Services_form";
            Text = "Services";
            service_gbox1.ResumeLayout(false);
            service_gbox1.PerformLayout();
            service_gbox2.ResumeLayout(false);
            service_gbox2.PerformLayout();
            service_gbox3.ResumeLayout(false);
            service_gbox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox service_gbox1;
        private GroupBox service_gbox2;
        private Label label2;
        private Label label1;
        private Label service_label1;
        private GroupBox service_gbox3;
        private Label service_label2;
        private Label service_label3;
        private Label service_label5;
        private Label service_label4;
        private Label service_label6;
        private Label service_label7;
        private Label service_label8;
        private Label services_label9;
        private Button svc_requestbutton;
        private Button svc_exitbutton;
    }
}