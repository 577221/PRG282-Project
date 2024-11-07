using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            LoadStudentsToGrid();
        }
        private void LoadStudentsToGrid()
        {
            students = FileHandler.LoadStudents();
            dataGridViewStudents.DataSource = new BindingSource { DataSource = students };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var newStudent = new Student
            {
                StudentID = txtStudentID.Text,
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Course = txtCourse.Text
            };

            students.Add(newStudent);
            FileHandler.SaveStudents(students);
            LoadStudentsToGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var studentID = txtStudentID.Text;
            var student = students.FirstOrDefault(s => s.StudentID == studentID);

            if (student != null)
            {
                student.Name = txtName.Text;
                student.Age = int.Parse(txtAge.Text);
                student.Course = txtCourse.Text;

                FileHandler.SaveStudents(students);
                LoadStudentsToGrid();
            }
            else
            {
                MessageBox.Show("Student not found.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                var studentID = dataGridViewStudents.SelectedRows[0].Cells["StudentID"].Value.ToString();
                var student = students.FirstOrDefault(s => s.StudentID == studentID);

                if (student != null)
                {
                    students.Remove(student);
                    FileHandler.SaveStudents(students);
                    LoadStudentsToGrid();
                }
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            LoadStudentsToGrid();
        }
    }
}
