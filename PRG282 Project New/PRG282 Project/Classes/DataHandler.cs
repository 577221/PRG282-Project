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
        static List<Student> students = new List<Student>();
        private string path = @"student.txt";
        private int count = 0;
        public void loadData()
        {
            students.Clear();
            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader streamreader = new StreamReader(filestream);
            string text;
            while ((text = streamreader.ReadLine()) != null)
            {
                string[] strings = text.Split(',');
                Student newstudent = new Student(int.Parse(strings[0]), strings[1], int.Parse(strings[2]), strings[3]);
                students.Add(newstudent);
                count++;    //counts each student in text file
            }
            count++;    //increases the count of students to one extra, adjusting for the next student that will be added
            filestream.Close();
            streamreader.Close();
        }

        public void Add(int StudentID, string StudentName, int StudentAge, string StudentCourse)
        {
            Student newstudent = new Student(StudentID, StudentName, StudentAge, StudentCourse);
            students.Add(newstudent);
            Count++; //increases the student count by one, adjusts for the next student that will be added
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
            MessageBox.Show("Data has been saved!");

        }



        public int Count { get => count; set => count = value; }
    }
}
