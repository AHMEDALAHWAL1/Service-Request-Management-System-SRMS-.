using System.Drawing;
using System.Windows.Forms;

namespace assignment_lole
{
    partial class payment
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
            plabel = new Label();
            plistbox = new ListBox();
            pexit_button = new Button();
            paybutton = new Button();
            pricelabel = new Label();
            SuspendLayout();
            // 
            // plabel
            // 
            plabel.AutoSize = true;
            plabel.Location = new Point(36, 163);
            plabel.Name = "plabel";
            plabel.Size = new Size(51, 15);
            plabel.TabIndex = 0;
            plabel.Text = "Totalfee:";
            // 
            // plistbox
            // 
            plistbox.FormattingEnabled = true;
            plistbox.ItemHeight = 15;
            plistbox.Location = new Point(36, 12);
            plistbox.Name = "plistbox";
            plistbox.Size = new Size(458, 139);
            plistbox.TabIndex = 2;
            plistbox.SelectedIndexChanged += plistbox_SelectedIndexChanged;
            // 
            // pexit_button
            // 
            pexit_button.Location = new Point(338, 189);
            pexit_button.Name = "pexit_button";
            pexit_button.Size = new Size(75, 23);
            pexit_button.TabIndex = 3;
            pexit_button.Text = "Exit";
            pexit_button.UseVisualStyleBackColor = true;
            pexit_button.Click += pexit_button_Click;
            // 
            // paybutton
            // 
            paybutton.Location = new Point(419, 189);
            paybutton.Name = "paybutton";
            paybutton.Size = new Size(75, 23);
            paybutton.TabIndex = 4;
            paybutton.Text = "Pay";
            paybutton.UseVisualStyleBackColor = true;
            paybutton.Click += paybutton_Click;
            // 
            // pricelabel
            // 
            pricelabel.AutoSize = true;
            pricelabel.Location = new Point(93, 163);
            pricelabel.Name = "pricelabel";
            pricelabel.Size = new Size(38, 15);
            pricelabel.TabIndex = 5;
            pricelabel.Text = "label1";
            // 
            // payment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 224);
            Controls.Add(pricelabel);
            Controls.Add(paybutton);
            Controls.Add(pexit_button);
            Controls.Add(plistbox);
            Controls.Add(plabel);
            Name = "payment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label plabel;
        private ListBox plistbox;
        private Button pexit_button;
        private Button paybutton;
        private Label pricelabel;
    }
}