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
    public partial class frmUpdate : Form
    {
        MainForm mainForm;
        public frmUpdate(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Close();
        }

        private void Update_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }
    }
}
