using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("How many Child Tickets?");
            int ticketsChild = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many Adult Tickets?");
            int ticketsAdult = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many Senior Tickets?");
            int ticketsSenior = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Is this an Evening show?");
            string showtimeAnswer = System.Console.ReadLine().ToLower();
            bool showtimeEvening = showtimeAnswer.Contains("y") || showtimeAnswer.Contains("t");

            System.Console.WriteLine("How many small sodas?");
            int snacksSmall = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many large sodas?");
            int snacksLarge = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many Hot Dogs?");
            int snacksDogs = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many Popcorns?");
            int snacksPop = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("How many Candies?");
            int snacksCandy = int.Parse(System.Console.ReadLine());

            double ticketsTotal = 0;
            if (showtimeEvening == true)
            {
                ticketsTotal = ticketsChild * 6.99;
                ticketsTotal += ticketsAdult * 10.99;
                ticketsTotal += ticketsSenior * 8.5;
            }
            else
            {
                ticketsTotal = (ticketsChild * 3.99);
                ticketsTotal += (ticketsAdult * 5.99);
                ticketsTotal += (ticketsSenior * 4.5);
            }

            double snacksTotal = snacksSmall * 3.50;
            snacksTotal += snacksLarge * 5.99;
            snacksTotal += snacksDogs * 3.99;
            snacksTotal += snacksPop * 4.50;
            snacksTotal += snacksCandy * 1.99;

            int ticketsNumber = ticketsAdult + ticketsChild + ticketsSenior;

            int discountPosibility = Math.Min(snacksPop, snacksLarge);
            int discount1 = Math.Min(discountPosibility, ticketsNumber) * 2;

            double discount2 = 0;
            if(ticketsNumber >= 3 && showtimeEvening == true && snacksPop >= 1)
            {
                discount2 = 4.50;
            }

            double discount3 = 0;
            if(snacksCandy >= 3)
            {
                discount3 = (snacksCandy / 4) * 1.99;
            }

            double discountTotal = discount1 + discount2 + discount3;

            double finalTotal = ticketsTotal + snacksTotal - discountTotal;

            System.Console.WriteLine("Tickets : " + ticketsTotal + " Snacks : " + snacksTotal + " Discounts: " + discountTotal);

            System.Console.WriteLine("The total for your show is: $" + finalTotal);
            System.Console.WriteLine("Press any key to close...");
            System.Console.ReadKey();

        }
    }
}
