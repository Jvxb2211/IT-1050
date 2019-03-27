using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab3
{
    class Student
    {

        public string Name { get; set; }
        public int Grade { get; set; }
        public Instructor Teacher { get; set; }

        public Student(string thisName, Instructor thisTeacher)
        {
            this.Name = thisName;
            this.Teacher = thisTeacher;
        }

        public void SetGrade(int Grade)
        {
            Grade = this.Grade;
        }

        public void Print()
        {
            System.Console.WriteLine(this.Name + ", Grade : " + this.Grade + " | Teacher : " + Teacher.Print());
        }
        
     
     
    }
}
