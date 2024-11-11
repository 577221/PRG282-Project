using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class frmSummary : Form
    {
        MainForm mainForm;
        DataHandler datahandler = new DataHandler();    
        public frmSummary(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void frmSummary_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
            datahandler.loadData();
            try
            {
                lblCountChange.Text = datahandler.getStudentCount().ToString();
                lblAvgChange.Text = datahandler.getAverageStudentAge().ToString();
            }
            catch 
            {
                lblCountChange.Text = "No Students in file";
                lblAvgChange.Text = "No Students in file";
            }
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            datahandler.saveSummary();
            MessageBox.Show("Summary File Created Successfully");
        }
    }
}
