using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_33
    {
        //33. Write a C# Sharp program to display Pascal's triangle.

        public static void DisplayPascalTriangle()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number number of rows");
                int rows = int.Parse(Console.ReadLine());

                int c = 1, blk, i, j;
                for (i = 0; i < rows; i++)
                {
                    for (blk = 1; blk <= rows - i; blk++)
                        Console.Write("  ");
                    for (j = 0; j <= i; j++)
                    {
                        if (j == 0 || i == 0)
                            c = 1;
                        else
                            c = c * (i - j + 1) / j;
                        Console.Write("{0}   ", c);
                    }
                    Console.Write("\n");
                }



                Console.WriteLine("Do you want to continue? yes/no");
                string choice = Console.ReadLine();

                if (choice == "yes")
                {
                    confirm = true;
                }
                else
                {
                    confirm = false;
                }
            }
        }
    }
}
