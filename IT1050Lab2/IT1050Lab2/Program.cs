using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person.SumOfAllAges = 0;
            int NumberOfPeople = 2;
            Person p1 = new Person();
            Person p2 = new Person();
            System.Console.WriteLine("In regards to the first person:");
            p1.FirstName = Question.AskFirst();
            p1.LastName = Question.AskLast();
            p1.Age = Question.AskAge();
            Person.SumOfAllAges += p1.Age;
            p1.Married = Question.AskMarried();
            if (p1.Married)
            {
                p1.Spouse = new Person();
                System.Console.WriteLine("In regards to this person's spouse:");
                p1.Spouse.FirstName = Question.AskFirst();
                p1.Spouse.LastName = p1.LastName;
                p1.Spouse.Age = Question.AskAge();
                Person.SumOfAllAges += p1.Spouse.Age;
                NumberOfPeople ++;
            }
            System.Console.WriteLine("In regards to the second person:");
            p2.FirstName = Question.AskFirst();
            p2.LastName = Question.AskLast();
            p2.Age = Question.AskAge();
            Person.SumOfAllAges += p2.Age;
            p2.Married = Question.AskMarried();

            if (p2.Married)
            {
                p2.Spouse = new Person();
                System.Console.WriteLine("In regards to this person's spouse:");
                p2.Spouse.FirstName = Question.AskFirst();
                p2.Spouse.LastName = p2.LastName;
                p2.Spouse.Age = Question.AskAge();
                Person.SumOfAllAges += p2.Spouse.Age;
                NumberOfPeople++;
            }

            p1.PrintNameAndAge();
            if (p1.Married)
            { p1.Spouse.PrintNameAndAge(); }
            p2.PrintNameAndAge();
            if (p2.Married)
            { p2.Spouse.PrintNameAndAge(); }

            System.Console.WriteLine("Average Age = " + (Person.SumOfAllAges / NumberOfPeople));

            System.Console.ReadKey();
         



        }
    }
}
