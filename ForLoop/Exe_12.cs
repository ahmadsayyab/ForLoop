using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_12
    {
        //12. Write a C# Sharp program to make such a pattern like a
        //right angle triangle with the number increased by 1.



        public static void PrintPattern()
        {
            string confirm;

            do
            {
                Console.WriteLine("Enter a digit to a pattern for");
                int num = int.Parse(Console.ReadLine());

                int n = 1;
                for (int i = 1; i <= num ; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(n + " ");
                        n++;
                    }
                    Console.Write("\n");
                }



                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }

}
