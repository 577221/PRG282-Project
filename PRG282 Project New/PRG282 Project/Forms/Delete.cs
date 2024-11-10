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
    
    public partial class frmDelete : Form
    {
        MainForm mainForm;

        public frmDelete(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void frmDelete_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
        }

        private void frmDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}
