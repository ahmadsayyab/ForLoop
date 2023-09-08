using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_9
    {
        //9. Write a program in C# Sharp to display a right angle triangle with an asterisk

        public static void PrintTriangle()
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter a number to produce a triangle for");
                int num = int.Parse(Console.ReadLine());

                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }


                    Console.Write("\n");

                }


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");

           
            
        }
    }
}
