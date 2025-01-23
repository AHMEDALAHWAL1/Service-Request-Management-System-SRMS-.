using System.Drawing;
using System.Windows.Forms;

namespace assignment_lole
{
    partial class History_form
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
            dataGridView1 = new DataGridView();
            Hi_textbox = new TextBox();
            hi_dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            hi_combobox1 = new ComboBox();
            hi_comboBox2 = new ComboBox();
            label3 = new Label();
            hi_resetbutton = new Button();
            label4 = new Label();
            id_label = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(14, 16);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1048, 568);
            dataGridView1.TabIndex = 0;
            // 
            // Hi_textbox
            // 
            Hi_textbox.Location = new Point(1183, 81);
            Hi_textbox.Margin = new Padding(3, 4, 3, 4);
            Hi_textbox.Name = "Hi_textbox";
            Hi_textbox.Size = new Size(114, 27);
            Hi_textbox.TabIndex = 2;
            // 
            // hi_dateTimePicker1
            // 
            hi_dateTimePicker1.Location = new Point(1069, 229);
            hi_dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            hi_dateTimePicker1.Name = "hi_dateTimePicker1";
            hi_dateTimePicker1.Size = new Size(228, 27);
            hi_dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1107, 137);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 4;
            label1.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1155, 92);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 5;
            label2.Text = "ID";
            // 
            // button1
            // 
            button1.Location = new Point(1183, 321);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(110, 36);
            button1.TabIndex = 6;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1069, 525);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(229, 59);
            button2.TabIndex = 7;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hi_combobox1
            // 
            hi_combobox1.FormattingEnabled = true;
            hi_combobox1.Items.AddRange(new object[] { "new ", "in-progress", "completed", "assigned" });
            hi_combobox1.Location = new Point(1159, 127);
            hi_combobox1.Margin = new Padding(3, 4, 3, 4);
            hi_combobox1.Name = "hi_combobox1";
            hi_combobox1.Size = new Size(138, 28);
            hi_combobox1.TabIndex = 9;
            // 
            // hi_comboBox2
            // 
            hi_comboBox2.FormattingEnabled = true;
            hi_comboBox2.Items.AddRange(new object[] { "Printing A4 | Black and white ", "Printing A4 | Colour ", "Binding | Comb", "Binding | Hard Cover", "Poster | A0/A1", "Poster | A2/A3" });
            hi_comboBox2.Location = new Point(1159, 165);
            hi_comboBox2.Margin = new Padding(3, 4, 3, 4);
            hi_comboBox2.Name = "hi_comboBox2";
            hi_comboBox2.Size = new Size(138, 28);
            hi_comboBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1107, 176);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 11;
            label3.Text = "Type";
            // 
            // hi_resetbutton
            // 
            hi_resetbutton.Location = new Point(1183, 283);
            hi_resetbutton.Margin = new Padding(3, 4, 3, 4);
            hi_resetbutton.Name = "hi_resetbutton";
            hi_resetbutton.Size = new Size(114, 31);
            hi_resetbutton.TabIndex = 12;
            hi_resetbutton.Text = "Reset Filters";
            hi_resetbutton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1069, 16);
            label4.Name = "label4";
            label4.Size = new Size(154, 20);
            label4.TabIndex = 13;
            label4.Text = "Currently logged in as";
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.Location = new Point(1216, 16);
            id_label.Name = "id_label";
            id_label.Size = new Size(50, 20);
            id_label.TabIndex = 14;
            id_label.Text = "label5";
            // 
            // History_form
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1311, 600);
            Controls.Add(id_label);
            Controls.Add(label4);
            Controls.Add(hi_resetbutton);
            Controls.Add(label3);
            Controls.Add(hi_comboBox2);
            Controls.Add(hi_combobox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hi_dateTimePicker1);
            Controls.Add(Hi_textbox);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "History_form";
            Text = "History_form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox Hi_textbox;
        private DateTimePicker hi_dateTimePicker1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private ComboBox hi_combobox1;
        private ComboBox hi_comboBox2;
        private Label label3;
        private Button hi_resetbutton;
        private Label label4;
        private Label id_label;
    }
}