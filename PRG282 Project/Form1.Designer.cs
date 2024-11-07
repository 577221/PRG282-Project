namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(29, 370);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(138, 370);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(251, 370);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(366, 370);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 3;
            this.btnViewAll.Text = "View";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(71, 31);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(153, 22);
            this.txtStudentID.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(71, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 22);
            this.txtName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(71, 89);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(153, 22);
            this.txtAge.TabIndex = 6;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(71, 118);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(153, 22);
            this.txtCourse.TabIndex = 7;
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Location = new System.Drawing.Point(251, 31);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(537, 280);
            this.dataGridViewStudents.TabIndex = 8;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(3, 31);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(20, 16);
            this.Name.TabIndex = 9;
            this.Name.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Course";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

