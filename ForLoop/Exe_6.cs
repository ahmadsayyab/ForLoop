using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_6
    {
        //6. Write a program in C# Sharp to display the multiplication table of a given integer.

        public static void FindTable()
        {
            string confirm;

            do
            {
                Console.WriteLine("Enter a digit to find its table");
                int num = int.Parse(Console.ReadLine());

                int table = 0;

                for (int i = 1; i <= 10; i++)
                {
                    table = num * i;
                    Console.WriteLine($"{num} X {i} = {table}");
                }

                Console.WriteLine("Do you want to continue, type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
            
            
        }
    }
}
