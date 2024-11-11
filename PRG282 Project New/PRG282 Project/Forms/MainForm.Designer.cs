namespace PRG282_Project
{
    partial class MainForm
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
            this.btnAddForm = new System.Windows.Forms.Button();
            this.btnViewForm = new System.Windows.Forms.Button();
            this.btnUpdateForm = new System.Windows.Forms.Button();
            this.btnDeleteForm = new System.Windows.Forms.Button();
            this.btnSummaryForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(12, 34);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(75, 23);
            this.btnAddForm.TabIndex = 8;
            this.btnAddForm.Text = "Add Student";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnViewForm
            // 
            this.btnViewForm.Location = new System.Drawing.Point(118, 34);
            this.btnViewForm.Name = "btnViewForm";
            this.btnViewForm.Size = new System.Drawing.Size(75, 23);
            this.btnViewForm.TabIndex = 9;
            this.btnViewForm.Text = "View All";
            this.btnViewForm.UseVisualStyleBackColor = true;
            this.btnViewForm.Click += new System.EventHandler(this.btnViewForm_Click);
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.Location = new System.Drawing.Point(12, 63);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateForm.TabIndex = 10;
            this.btnUpdateForm.Text = "Update";
            this.btnUpdateForm.UseVisualStyleBackColor = true;
            this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.Location = new System.Drawing.Point(118, 63);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteForm.TabIndex = 11;
            this.btnDeleteForm.Text = "Delete";
            this.btnDeleteForm.UseVisualStyleBackColor = true;
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // btnSummaryForm
            // 
            this.btnSummaryForm.Location = new System.Drawing.Point(61, 92);
            this.btnSummaryForm.Name = "btnSummaryForm";
            this.btnSummaryForm.Size = new System.Drawing.Size(75, 23);
            this.btnSummaryForm.TabIndex = 12;
            this.btnSummaryForm.Text = "Summary";
            this.btnSummaryForm.UseVisualStyleBackColor = true;
            this.btnSummaryForm.Click += new System.EventHandler(this.btnSummaryForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Please Select an option";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 131);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSummaryForm);
            this.Controls.Add(this.btnDeleteForm);
            this.Controls.Add(this.btnUpdateForm);
            this.Controls.Add(this.btnViewForm);
            this.Controls.Add(this.btnAddForm);
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnViewForm;
        private System.Windows.Forms.Button btnUpdateForm;
        private System.Windows.Forms.Button btnDeleteForm;
        private System.Windows.Forms.Button btnSummaryForm;
        private System.Windows.Forms.Label label1;
    }
}

