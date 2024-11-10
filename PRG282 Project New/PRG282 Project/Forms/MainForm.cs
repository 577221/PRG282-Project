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
    public partial class MainForm : Form
    {
        frmAdd frmAdd; 
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            frmAdd newdd = new frmAdd(this);
            newdd.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnViewForm_Click(object sender, EventArgs e)
        {
            frmView newview = new frmView(this);
            newview.Show();
        }

        private void btnUpdateForm_Click(object sender, EventArgs e)
        {
            frmUpdate newupdate = new frmUpdate(this);
            newupdate.Show();
        }

        private void btnDeleteForm_Click(object sender, EventArgs e)
        {
            frmDelete newdelete = new frmDelete (this);
            newdelete.Show();
        }

        private void btnSummaryForm_Click(object sender, EventArgs e)
        {
            frmSummary frmSummary = new frmSummary(this);
            frmSummary.Show();
        }
    }
}
