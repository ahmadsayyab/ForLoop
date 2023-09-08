using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_14
    {
        //14. Write a program in C# Sharp to make such a pattern like a pyramid with an asterisk.

        public static void PrintPattern()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter a digit to crate a patter for");
                int rows = int.Parse(Console.ReadLine());

                int spaces = rows + 4 -1;
                for (int i = 1; i <= rows; i++)
                {
                    for (int k = spaces; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("* ");
                    }
                        
                    Console.Write("\n");
                    spaces--;
                }



                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
