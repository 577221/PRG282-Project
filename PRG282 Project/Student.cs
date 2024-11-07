﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Student
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return $"{StudentID},{Name},{Age},{Course}";
        }
    }
}