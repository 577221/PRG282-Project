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
    public partial class frmAdd : Form
    {
        MainForm mainForm;      //variable to control main form
        DataHandler datahandler = new DataHandler();        //creates datahandler object

        public frmAdd(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
        }

        private void frmAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainForm.Show(); 
            this.Close();
        }
    }
}
