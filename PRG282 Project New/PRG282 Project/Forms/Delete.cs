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

        private void loadComboBox()
        {
            cmbId.Items.Clear();
            foreach (var student in datahandler.Students)
            {
                cmbId.Items.Add(student.Id);
            }
            cmbId.Text = "";
        }

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
            loadComboBox();
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
                int studentToDelete = int.Parse(cmbId.SelectedItem.ToString());  
                datahandler.Delete(studentToDelete);
            }
            catch 
            {
                MessageBox.Show("No value to delete");
            }
            loadComboBox();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            datahandler.DeleteAll();
            MessageBox.Show("All data deleted!");
            loadComboBox();
        }
    }
}
