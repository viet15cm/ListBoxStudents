using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBoxStudents
{
    class Student
    {
        private string ten;

        public Student(string ten)
        {
            this.Ten = ten;
        }

        public string Ten { get => ten; set => ten = value; }
    }
}
