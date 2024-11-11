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
            this.SuspendLayout();
            // 
            // btnAddForm
            // 
            this.btnAddForm.Location = new System.Drawing.Point(7, 15);
            this.btnAddForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(100, 28);
            this.btnAddForm.TabIndex = 8;
            this.btnAddForm.Text = "Add Student";
            this.btnAddForm.UseVisualStyleBackColor = true;
            this.btnAddForm.Click += new System.EventHandler(this.btnAddForm_Click);
            // 
            // btnViewForm
            // 
            this.btnViewForm.Location = new System.Drawing.Point(148, 15);
            this.btnViewForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewForm.Name = "btnViewForm";
            this.btnViewForm.Size = new System.Drawing.Size(100, 28);
            this.btnViewForm.TabIndex = 9;
            this.btnViewForm.Text = "View All";
            this.btnViewForm.UseVisualStyleBackColor = true;
            this.btnViewForm.Click += new System.EventHandler(this.btnViewForm_Click);
            // 
            // btnUpdateForm
            // 
            this.btnUpdateForm.Location = new System.Drawing.Point(7, 50);
            this.btnUpdateForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdateForm.Name = "btnUpdateForm";
            this.btnUpdateForm.Size = new System.Drawing.Size(100, 28);
            this.btnUpdateForm.TabIndex = 10;
            this.btnUpdateForm.Text = "Update";
            this.btnUpdateForm.UseVisualStyleBackColor = true;
            this.btnUpdateForm.Click += new System.EventHandler(this.btnUpdateForm_Click);
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.Location = new System.Drawing.Point(148, 50);
            this.btnDeleteForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteForm.TabIndex = 11;
            this.btnDeleteForm.Text = "Delete";
            this.btnDeleteForm.UseVisualStyleBackColor = true;
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // btnSummaryForm
            // 
            this.btnSummaryForm.Location = new System.Drawing.Point(79, 86);
            this.btnSummaryForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSummaryForm.Name = "btnSummaryForm";
            this.btnSummaryForm.Size = new System.Drawing.Size(100, 28);
            this.btnSummaryForm.TabIndex = 12;
            this.btnSummaryForm.Text = "Summary";
            this.btnSummaryForm.UseVisualStyleBackColor = true;
            this.btnSummaryForm.Click += new System.EventHandler(this.btnSummaryForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 130);
            this.Controls.Add(this.btnSummaryForm);
            this.Controls.Add(this.btnDeleteForm);
            this.Controls.Add(this.btnUpdateForm);
            this.Controls.Add(this.btnViewForm);
            this.Controls.Add(this.btnAddForm);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Student Management System";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddForm;
        private System.Windows.Forms.Button btnViewForm;
        private System.Windows.Forms.Button btnUpdateForm;
        private System.Windows.Forms.Button btnDeleteForm;
        private System.Windows.Forms.Button btnSummaryForm;
    }
}

