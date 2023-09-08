using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_7
    {
        //7. Write a program in C# Sharp to display the multiplication table vertically from 1 to n.

        public static void FindTable()
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter a number, upto which you want to find a table");
                int n = int.Parse(Console.ReadLine());

                //int table = 0;

                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        //table = i * j;
                        Console.Write($"{i} X {j} = {i * j}  ");
                    }
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Do you want to continue yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
            
            
        }
    }
}
