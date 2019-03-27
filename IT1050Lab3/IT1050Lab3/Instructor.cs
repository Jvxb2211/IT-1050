using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab3
{
    class Instructor
    {
        public string Name { get; set; }
        public string CourseName { get; set; }

        public Instructor(string Name, string CourseName)
        {
            this.Name = Name;
            this.CourseName = CourseName;
        }

        public void SetStudentGrade(Student thisStudent, int thisGrade)
        {
            thisStudent.Grade = thisGrade; 
        }

        public string Print()
        {
            return (Name + " | Course : " + CourseName);
        }
    }
}
