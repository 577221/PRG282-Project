using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    internal class DataHandler
    {
        private static List<Student> students = new List<Student>();
        private string path = @"student.txt";
        private string sumpath = @"summary.txt";
        private int agetotal = 0;
        public void loadData()
        {
            students.Clear();
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader streamreader = new StreamReader(filestream);
            string text;
            while ((text = streamreader.ReadLine()) != null)
            {
                string[] strings = text.Split(',');
                agetotal += int.Parse(strings[2]);
                Student newstudent = new Student(int.Parse(strings[0]), strings[1], int.Parse(strings[2]), strings[3]);
                students.Add(newstudent);
            }
            filestream.Close();
            streamreader.Close();
        }
        public void Add(int StudentID, string StudentName, int StudentAge, string StudentCourse)
        {
            Student newstudent = new Student(StudentID, StudentName, StudentAge, StudentCourse);
            students.Add(newstudent);
            saveData();
            MessageBox.Show("Student successfully added!");
        }
        public void Delete(int StudentID)
        {
            Student studentToRemove = students.FirstOrDefault(s=>s.Id==StudentID);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
                saveData();
                MessageBox.Show("Student successfully deleted!");
            }
            else MessageBox.Show("Student not found");
        }
        public void DeleteAll()
        {
            using (FileStream fs = File.Create(path)) {}
        }
        public void saveData()
        {
            FileStream filestream = new FileStream(path, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(filestream))
            {
                string text;
                foreach (Student student in students)
                {
                    text = student.Id + "," + student.Name + "," + student.Age + "," + student.Course;
                    writer.WriteLine(text);
                }
            }

            filestream.Close();
        }
        public void saveSummary()
        {
            string summary = "Student Count: " + getStudentCount().ToString() + "\nAverage Student Age: " + getAverageStudentAge().ToString();
            File.WriteAllText(sumpath, summary);
        }
        public int getMaxID()
        { 
            return students.Max(s => s.Id);
        }
        public int getStudentCount()
        { return students.Count(); }
        public int getAverageStudentAge()
        { 
            return agetotal/getStudentCount();
        }
        

        public int AgeTotal { get => agetotal; set => agetotal = value; }
        public List<Student> Students { get => students; set => students = value; }
    }
}
