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
        DataHandler datahandler = new DataHandler();
        string selectedItem = null;
        string firstColumnValue;
        private void loadComboBox()
        {
            foreach (var student in datahandler.Students)
            {
                cmbID.Items.Add(student.Id);
            }
        }
        public void loadCourseBox()
        {

            foreach (var course in datahandler.Courses)
            {
                cmbCourse.Items.Add(course);
            }
        }

        private void loadStudentData()
        {
            Student student = datahandler.SearchData(int.Parse(selectedItem));
            txtName.Text = student.Name;
            txtAge.Text = student.Age.ToString();
            cmbCourse.Text = student.Course.ToString();
        }
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
            datahandler.loadData();
            gridUpdate.DataSource = datahandler.Students;
            loadComboBox();
            loadCourseBox();
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtName.Text)) { MessageBox.Show("Name cannot be empty"); return; }
                if (string.IsNullOrEmpty(cmbCourse.Text)) { MessageBox.Show("Course cannot be empty"); return; }
                datahandler.updateData(int.Parse(selectedItem), txtName.Text, int.Parse(txtAge.Text), cmbCourse.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong");
                return;
            }

            txtName.Clear();
            txtAge.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbID.SelectedIndex = -1;
            gridUpdate.DataSource = null;
            gridUpdate.DataSource = datahandler.Students;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(cmbID.Text)) { return; }
                selectedItem = cmbID.SelectedItem.ToString();
            }
            catch { }
            gridUpdate.CurrentCell = gridUpdate[0, int.Parse(selectedItem) - 1];
            loadStudentData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                firstColumnValue = gridUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
                cmbID.Text = gridUpdate.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtName.Text = gridUpdate.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtAge.Text = gridUpdate.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmbCourse.Text = gridUpdate.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
    }
}
