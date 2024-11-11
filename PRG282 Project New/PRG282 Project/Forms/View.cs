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
    public partial class frmView : Form
    {
        MainForm mainForm;
        DataHandler datahandler = new DataHandler();
        public frmView(MainForm frm)
        {
            InitializeComponent();

            mainForm = frm;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
            datahandler.loadData();
            gridViewAll.DataSource = datahandler.Students;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void frmView_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}
