using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_31
    {
        //31. Write a program in C# Sharp to display the pattern like a diamond.

        public static void PrintPattern()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number number of rows");
                int rows = int.Parse(Console.ReadLine());

               
                for (int i = 0; i <= rows; i++)
                {
                    for (int j = 1; j <= rows - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
                    Console.Write("\n");
                }

                for (int i = rows - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= rows - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= 2 * i - 1; j++)
                        Console.Write("*");
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
