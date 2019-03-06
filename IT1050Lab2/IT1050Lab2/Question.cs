using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab2
{
    class Question
    {
        public static string AskFirst()
        {
            System.Console.WriteLine("What is the person's first name");
            return System.Console.ReadLine();
        }

        public static string AskLast()
        {
            System.Console.WriteLine("What is the person's last name");
            return System.Console.ReadLine();
        }

        public static int AskAge()
        {
            System.Console.WriteLine("What is the person's age");
            return int.Parse(System.Console.ReadLine());
        }

        public static bool AskMarried()
        {
            System.Console.WriteLine("Is the person married?");
            string input = System.Console.ReadLine().ToLower();
            return input.StartsWith("y") || input.StartsWith("t");
        }


    }
}