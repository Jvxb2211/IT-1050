using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            string isCitizenReply;
            bool canVote;
            int heightFeet;
            double heightInches;
            double totalHeightCM;

            System.Console.Write("What is your first name? ");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle initial? ");
            middleInitial = System.Console.ReadLine();

            System.Console.Write("What is your last name? ");
            lastName = System.Console.ReadLine();

            fullName = (firstName + " " + middleInitial + ". " + lastName);

            System.Console.Write("How many feet tall are you? ");
            heightFeet = int.Parse(System.Console.ReadLine());

            System.Console.Write("How many inches past your base height in feet are you? ");
            heightInches = double.Parse(System.Console.ReadLine());

            totalHeightCM = (((heightFeet * 12) + heightInches) * 2.54);

            System.Console.WriteLine("How old are you? ");
            age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Are you a United States citizen? ");
            isCitizenReply = System.Console.ReadLine().ToLower();
            isCitizen = isCitizenReply.Contains("y") || isCitizenReply.Contains("t");

            bool ofAge = (age >= 18);
            canVote = ofAge && isCitizen;

            System.Console.WriteLine("Your full name is " + fullName);
            System.Console.WriteLine("Your total height in centimeters is " + totalHeightCM);
            System.Console.WriteLine("Your ability to vote is " + canVote);
            System.Console.ReadKey();
        }
    }
}
