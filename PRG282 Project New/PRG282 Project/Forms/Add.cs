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
        
        public void loadCourseBox()
        {

            foreach (var course in datahandler.Courses)
            {
                cmbCourse.Items.Add(course);
            }
        }


        public frmAdd(MainForm frm)
        {
            InitializeComponent();
            mainForm = frm;
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            mainForm.Hide();
            datahandler.loadData();
            try
            {
                txtId.Text = (datahandler.getMaxID() + 1).ToString();
            }
            catch  
            {
                txtId.Text = "1";
            }
            this.ActiveControl = txtName;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
                     
            try
            {
                if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Name cannot be empty");  return; }
                if (string.IsNullOrEmpty(cmbCourse.Text)) { MessageBox.Show("Course cannot be empty"); return; }
                datahandler.Add(int.Parse(txtId.Text), txtName.Text, int.Parse(txtAge.Text), cmbCourse.Text);
                MessageBox.Show("Student successfully added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
                return;
            }
            
            txtName.Clear();
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;
            txtId.Text = (datahandler.getMaxID() + 1).ToString();
        }

        private void frmAdd_Shown(object sender, EventArgs e)
        {
            txtId.Focus();
        }




    }
}
