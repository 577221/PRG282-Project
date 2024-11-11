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
        DataHandler datahandler = new DataHandler();
        private int Count = 0;
        private string firstColumnValue;

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
            datahandler.loadData();
            gridDelete.DataSource = datahandler.Students;
           // MessageBox.Show(datahandler.getMaxID().ToString());
        }

        private void frmDelete_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                datahandler.Delete(int.Parse(firstColumnValue));
                MessageBox.Show("Student successfully deleted!");
            }
            catch { MessageBox.Show("Something Went Wrong"); }

            gridDelete.DataSource = null;
            gridDelete.DataSource = datahandler.Students;
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            datahandler.DeleteAll();
            MessageBox.Show("All data deleted!");
            datahandler.loadData();
            gridDelete.DataSource = null;
            gridDelete.DataSource= datahandler.Students;
        }

        private void gridDelete_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                firstColumnValue = gridDelete.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }
    }
}
