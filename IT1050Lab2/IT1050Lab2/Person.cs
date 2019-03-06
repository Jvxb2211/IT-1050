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

        public void GatherData()
        {
            this.FirstName = Question.AskFirst();
            this.LastName = Question.AskLast();
            this.Age = Question.AskAge();
            Person.SumOfAllAges += this.Age;
            this.Married = Question.AskMarried();
            if (this.Married)
            {
                this.Spouse = new Person();
                System.Console.WriteLine("In regards to this person's spouse:");
                this.Spouse.FirstName = Question.AskFirst();
                this.Spouse.LastName = this.LastName;
                this.Spouse.Age = Question.AskAge();
                Person.SumOfAllAges += this.Spouse.Age;
            }
        }
  
    

        

    }
}