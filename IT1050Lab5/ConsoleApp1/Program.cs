using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string[][] grid = new string[8][];

            bool continuePlaying = true;
            
            void initializeBoard()
            {
                for (int i = 0; i < 8; i++)
                {
                    grid[i] = new string[8];

                    for (int j = 0; j < 8; j++)
                    {
                        grid[i][j] = "X";
                    }
                }

                for (int i = 2; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        grid[i][j] = " ";
                    }
                }
                printBoard();

                promptUser();
            }

            void printBoard()
            {
                Console.Clear();
                System.Console.WriteLine("    0  1  2  3  4  5  6  7");
     
                for (int i = 0; i < 8; i++)
                {
                    System.Console.WriteLine(" <-------------------------->");
                    System.Console.Write(i +" ");
                    System.Console.Write("|");
                    for (int j = 0; j < 8; j++)
                    {
                        System.Console.Write("|" + grid[i][j] + "|");
                    }
                    System.Console.Write("|");
                    System.Console.WriteLine();

                }
                System.Console.WriteLine(" <-------------------------->");
            }

            void promptUser()
            {
                System.Console.Write("Enter a target X coordinate between 0 and 7 : ");
                int targetX = int.Parse(System.Console.ReadLine());

                while (targetX < 0 || targetX > 7)
                {
                    System.Console.WriteLine("Invalid input. Reinitializing board. Press any key to continue...");
                    System.Console.ReadKey();
                    initializeBoard();
                }

                System.Console.Write("Enter a target Y coordinate between 0 and 7 : ");
                int targetY = int.Parse(System.Console.ReadLine());

                while (targetY < 0 || targetY > 7)
                {
                    System.Console.WriteLine("Invalid input. Reinitializing board. Press any key to continue...");
                    System.Console.ReadKey();
                    initializeBoard();
                }

                System.Console.Write("Enter a destination X coordinate between 0 and 7 : ");
                int destinationX = int.Parse(System.Console.ReadLine());
                System.Console.Write("Enter a destination Y coordinate between 0 and 7 : ");
                int destinationY = int.Parse(System.Console.ReadLine());
                
                grid[targetX][targetY] = " ";
                grid[destinationX][destinationY] = "X";

                printBoard();
                Continue();
            }

            bool Continue()
            {
                System.Console.Write("Would you like to continue? (y/n) : ");
                if (System.Console.ReadLine().ToLower().Contains("y"))
                {
                    return continuePlaying = true;
                }
                else
                {
                    return continuePlaying = false;
                }
            }

            initializeBoard();

            while(continuePlaying == true)
            {
                printBoard();
                promptUser();
            }
        }


    }
}
