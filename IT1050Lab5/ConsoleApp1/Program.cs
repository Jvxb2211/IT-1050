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

                for (int i = 3; i < 6; i++)
                {
                    for (int j = 0; j < 8; j++)
                    {
                        grid[i][j] = " ";
                    }
                }
            }

            void printBoard()
            {
                for (int i = 0; i < 8; i++)
                {
                    System.Console.WriteLine("<------------------------->");
                    System.Console.Write("|");
                    for (int j = 0; j < 8; j++)
                    {
                        System.Console.Write("|" + grid[i][j] + "|");
                    }
                    System.Console.Write("|");
                    System.Console.WriteLine();

                }
                System.Console.WriteLine("<------------------------->");
                System.Console.ReadKey();
            }

            initializeBoard();

            printBoard();


        }


    }
}
