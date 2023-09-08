using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_20
    {
        //20. Write a program in C# Sharp to display the pattern
        //like pyramid using an asterisk and each row contain an odd number of an asterisks.

        public static void PrintPattern()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter number of rows to print a pymramid like pattern");
                int rows = int.Parse(Console.ReadLine());

                int spaces = rows + 4 - 1;
                for (int i = 1; i <= rows ; i++)
                {
                    for (int k = spaces;  k >=  1; k--)
                    {
                        Console.Write(" ");
                    }
                    for (int j = 1; j <= i; j++)
                    {
                        if (i % 2 == 0)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("* ");
                        }
                        
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
