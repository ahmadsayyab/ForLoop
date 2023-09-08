using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_15
    {
        //15. Write a C# Sharp program to calculate the factorial of a given number.

        public static void FindFactorial()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter a number to find factorial for it");
                int num = int.Parse(Console.ReadLine());

                int fac = 1;
                for (int i = 1; i <= num; i++)
                {
                    fac *=  i;
                }
                Console.WriteLine($"Factorial of the {num} is: {fac}");


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
