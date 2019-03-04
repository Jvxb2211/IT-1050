using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab2
{
    class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public bool Married;
        public Person Spouse;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            string FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }

        public void PrintNameAndAge()
        {
            System.Console.WriteLine(GetFullName() + " (" + Age + ")");
        }
        
  
    

        

    }
}