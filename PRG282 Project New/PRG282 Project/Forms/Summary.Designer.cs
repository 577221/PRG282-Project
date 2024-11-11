namespace PRG282_Project
{
    partial class frmSummary
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
            this.btnSummary = new System.Windows.Forms.Button();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblAvg = new System.Windows.Forms.Label();
            this.lblCountChange = new System.Windows.Forms.Label();
            this.lblAvgChange = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(86, 119);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSummary
            // 
            this.btnSummary.Location = new System.Drawing.Point(5, 119);
            this.btnSummary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSummary.Name = "btnSummary";
            this.btnSummary.Size = new System.Drawing.Size(75, 23);
            this.btnSummary.TabIndex = 1;
            this.btnSummary.Text = "Save";
            this.btnSummary.UseVisualStyleBackColor = true;
            this.btnSummary.Click += new System.EventHandler(this.btnSummary_Click);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(9, 26);
            this.lblCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(113, 19);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "Student Count :";
            // 
            // lblAvg
            // 
            this.lblAvg.AutoSize = true;
            this.lblAvg.Location = new System.Drawing.Point(9, 75);
            this.lblAvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvg.Name = "lblAvg";
            this.lblAvg.Size = new System.Drawing.Size(101, 19);
            this.lblAvg.TabIndex = 3;
            this.lblAvg.Text = "Average Age :";
            // 
            // lblCountChange
            // 
            this.lblCountChange.AutoSize = true;
            this.lblCountChange.Location = new System.Drawing.Point(81, 26);
            this.lblCountChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCountChange.Name = "lblCountChange";
            this.lblCountChange.Size = new System.Drawing.Size(0, 15);
            this.lblCountChange.TabIndex = 4;
            // 
            // lblAvgChange
            // 
            this.lblAvgChange.AutoSize = true;
            this.lblAvgChange.Location = new System.Drawing.Point(81, 75);
            this.lblAvgChange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvgChange.Name = "lblAvgChange";
            this.lblAvgChange.Size = new System.Drawing.Size(0, 15);
            this.lblAvgChange.TabIndex = 5;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(177, 149);
            this.Controls.Add(this.lblAvgChange);
            this.Controls.Add(this.lblCountChange);
            this.Controls.Add(this.lblAvg);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnSummary);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSummary";
            this.Text = "Show Summary of Students";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSummary_FormClosing);
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSummary;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblAvg;
        private System.Windows.Forms.Label lblCountChange;
        private System.Windows.Forms.Label lblAvgChange;
    }
}