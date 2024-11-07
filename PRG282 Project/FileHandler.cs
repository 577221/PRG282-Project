using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    internal class FileHandler : Student
    {
        private const string FilePath = "students.txt";

        // Load all students from file
        public static List<Student> LoadStudents()
        {
            List<Student> students = new List<Student>();

            if (File.Exists(FilePath))
            {
                var lines = File.ReadAllLines(FilePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 4)
                    {
                        students.Add(new Student
                        {
                            StudentID = parts[0],
                            Name = parts[1],
                            Age = int.Parse(parts[2]),
                            Course = parts[3]
                        });
                    }
                }
            }

            return students;
        }

        // Save all students to file
        public static void SaveStudents(List<Student> students)
        {
            var lines = students.Select(s => s.ToString()).ToArray();
            File.WriteAllLines(FilePath, lines);
        }
    }
}

