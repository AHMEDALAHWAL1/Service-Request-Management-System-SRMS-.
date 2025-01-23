namespace Mina_Part
{
    partial class Worker
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
            this.lblWorker = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerdataGridView = new System.Windows.Forms.DataGridView();
            this.BtnUpdateProfile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblWorkerRequest = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gBJobstatus = new System.Windows.Forms.GroupBox();
            this.rdCompleted = new System.Windows.Forms.RadioButton();
            this.rdWorkInProgress = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.WorkerdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.gBJobstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorker.Location = new System.Drawing.Point(332, 18);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(118, 36);
            this.lblWorker.TabIndex = 1;
            this.lblWorker.Text = "Worker";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(18, 363);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 66);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 4;
            // 
            // WorkerdataGridView
            // 
            this.WorkerdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WorkerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WorkerdataGridView.Location = new System.Drawing.Point(18, 119);
            this.WorkerdataGridView.Name = "WorkerdataGridView";
            this.WorkerdataGridView.RowHeadersWidth = 51;
            this.WorkerdataGridView.RowTemplate.Height = 24;
            this.WorkerdataGridView.Size = new System.Drawing.Size(552, 236);
            this.WorkerdataGridView.TabIndex = 5;
            this.WorkerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnUpdateProfile
            // 
            this.BtnUpdateProfile.Location = new System.Drawing.Point(672, 79);
            this.BtnUpdateProfile.Name = "BtnUpdateProfile";
            this.BtnUpdateProfile.Size = new System.Drawing.Size(116, 39);
            this.BtnUpdateProfile.TabIndex = 6;
            this.BtnUpdateProfile.Text = "Update Profile";
            this.BtnUpdateProfile.UseVisualStyleBackColor = true;
            this.BtnUpdateProfile.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblWorker);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 73);
            this.panel1.TabIndex = 10;
            // 
            // lblWorkerRequest
            // 
            this.lblWorkerRequest.AutoSize = true;
            this.lblWorkerRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerRequest.Location = new System.Drawing.Point(15, 87);
            this.lblWorkerRequest.Name = "lblWorkerRequest";
            this.lblWorkerRequest.Size = new System.Drawing.Size(174, 25);
            this.lblWorkerRequest.TabIndex = 12;
            this.lblWorkerRequest.Text = "Worker Request:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(588, 251);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(200, 66);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(588, 363);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 66);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.button4_Click);
            // 
            // gBJobstatus
            // 
            this.gBJobstatus.Controls.Add(this.rdCompleted);
            this.gBJobstatus.Controls.Add(this.rdWorkInProgress);
            this.gBJobstatus.Location = new System.Drawing.Point(588, 124);
            this.gBJobstatus.Name = "gBJobstatus";
            this.gBJobstatus.Size = new System.Drawing.Size(200, 100);
            this.gBJobstatus.TabIndex = 15;
            this.gBJobstatus.TabStop = false;
            this.gBJobstatus.Text = "Update Job Status";
            // 
            // rdCompleted
            // 
            this.rdCompleted.AutoSize = true;
            this.rdCompleted.Location = new System.Drawing.Point(14, 52);
            this.rdCompleted.Name = "rdCompleted";
            this.rdCompleted.Size = new System.Drawing.Size(94, 20);
            this.rdCompleted.TabIndex = 1;
            this.rdCompleted.Text = "Completed";
            this.rdCompleted.UseVisualStyleBackColor = true;
            // 
            // rdWorkInProgress
            // 
            this.rdWorkInProgress.AutoSize = true;
            this.rdWorkInProgress.Location = new System.Drawing.Point(14, 26);
            this.rdWorkInProgress.Name = "rdWorkInProgress";
            this.rdWorkInProgress.Size = new System.Drawing.Size(131, 20);
            this.rdWorkInProgress.TabIndex = 0;
            this.rdWorkInProgress.Text = "Work In Progress\r\n";
            this.rdWorkInProgress.UseVisualStyleBackColor = true;
            this.rdWorkInProgress.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBJobstatus);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblWorkerRequest);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnUpdateProfile);
            this.Controls.Add(this.WorkerdataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClose);
            this.Name = "Worker";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WorkerdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gBJobstatus.ResumeLayout(false);
            this.gBJobstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWorker;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView WorkerdataGridView;
        private System.Windows.Forms.Button BtnUpdateProfile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblWorkerRequest;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox gBJobstatus;
        private System.Windows.Forms.RadioButton rdWorkInProgress;
        private System.Windows.Forms.RadioButton rdCompleted;
    }
}

