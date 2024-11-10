using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282_Project
{
    internal class Student
    {
        private int id;
        private string name;
        private int age;
        private string course;

        public Student(int id, string name, int age, string course)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.course = course;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
