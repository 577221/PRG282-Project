namespace PRG282_Project
{
    partial class frmDelete
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cmbId = new System.Windows.Forms.ComboBox();
            this.lblSelectID = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(119, 120);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // cmbId
            // 
            this.cmbId.FormattingEnabled = true;
            this.cmbId.Location = new System.Drawing.Point(12, 71);
            this.cmbId.Name = "cmbId";
            this.cmbId.Size = new System.Drawing.Size(203, 24);
            this.cmbId.TabIndex = 2;
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Location = new System.Drawing.Point(22, 33);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(173, 16);
            this.lblSelectID.TabIndex = 3;
            this.lblSelectID.Text = "Select a student ID to delete";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(61, 154);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(100, 28);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 208);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lblSelectID);
            this.Controls.Add(this.cmbId);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDelete";
            this.Text = "Delete A Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDelete_FormClosing);
            this.Load += new System.EventHandler(this.frmDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cmbId;
        private System.Windows.Forms.Label lblSelectID;
        private System.Windows.Forms.Button btnDeleteAll;
    }
}