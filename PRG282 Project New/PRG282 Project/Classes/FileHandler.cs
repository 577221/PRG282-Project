using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    internal class FileHandler
    {
        private string path = @"student.txt";
        private static List<Student> students = new List<Student>();

        public void loadData() //method used to load data into list for use with other methods
        {   

            FileStream filestream = new FileStream(path, FileMode.OpenOrCreate);
            StreamReader streamreader = new StreamReader(filestream);
            string text;
            while ((text = streamreader.ReadLine()) != null)
            {
                string[] strings = text.Split(',');
                Student newstudent = new Student(int.Parse(strings[0]), strings[1], int.Parse(strings[2]), strings[3]);
                students.Add(newstudent);
            }
            filestream.Close();
            streamreader.Close();
        }

        public void write()
        {
             
        }


        public void testFile()
        {
            if (File.Exists(path))
            {
                MessageBox.Show("File Found");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }

            
        }
    }
}
