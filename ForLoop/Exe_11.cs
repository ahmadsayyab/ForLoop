using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_11
    {
        //11. Write a program in C# Sharp to make such a pattern like a right angle triangle
        //with a number which repeats a number in a row.


        public static void PrintPattern()
        {
            string confirm;


            do
            {

                Console.WriteLine("Enter a digit to print a pattern for");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(i);

                    }
                    Console.Write("\n");
                }


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
