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
            p1.GatherData();

            System.Console.WriteLine("In regards to the second person:");
            p2.GatherData();

            p1.PrintNameAndAge();
            if (p1.Married)
            {
                p1.Spouse.PrintNameAndAge();
                NumberOfPeople++;
            }
            p2.PrintNameAndAge();
            if (p2.Married)
            {
                p2.Spouse.PrintNameAndAge();
                NumberOfPeople++;
            }

            System.Console.WriteLine("Average Age = " + (Person.SumOfAllAges / NumberOfPeople));

            System.Console.WriteLine("Press any key to continue...");

            System.Console.ReadKey();
        }
    }
}
