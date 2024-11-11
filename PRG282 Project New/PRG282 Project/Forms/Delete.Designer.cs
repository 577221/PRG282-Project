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
            this.lblSelectID = new System.Windows.Forms.Label();
            this.btnDeleteAll = new System.Windows.Forms.Button();
            this.gridDelete = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(397, 213);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 211);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectID
            // 
            this.lblSelectID.AutoSize = true;
            this.lblSelectID.Location = new System.Drawing.Point(24, 11);
            this.lblSelectID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectID.Name = "lblSelectID";
            this.lblSelectID.Size = new System.Drawing.Size(142, 13);
            this.lblSelectID.TabIndex = 3;
            this.lblSelectID.Text = "Select a student ID to delete";
            // 
            // btnDeleteAll
            // 
            this.btnDeleteAll.Location = new System.Drawing.Point(91, 211);
            this.btnDeleteAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteAll.Name = "btnDeleteAll";
            this.btnDeleteAll.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAll.TabIndex = 4;
            this.btnDeleteAll.Text = "Delete All";
            this.btnDeleteAll.UseVisualStyleBackColor = true;
            this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
            // 
            // gridDelete
            // 
            this.gridDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDelete.Location = new System.Drawing.Point(12, 27);
            this.gridDelete.Name = "gridDelete";
            this.gridDelete.Size = new System.Drawing.Size(460, 180);
            this.gridDelete.TabIndex = 5;
            this.gridDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDelete_CellClick);
            // 
            // frmDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 245);
            this.Controls.Add(this.gridDelete);
            this.Controls.Add(this.btnDeleteAll);
            this.Controls.Add(this.lblSelectID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnBack);
            this.Name = "frmDelete";
            this.Text = "Delete A Student";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDelete_FormClosing);
            this.Load += new System.EventHandler(this.frmDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectID;
        private System.Windows.Forms.Button btnDeleteAll;
        private System.Windows.Forms.DataGridView gridDelete;
    }
}