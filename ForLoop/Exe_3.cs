using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_3
    {
        //3. Write a C# Sharp program that displays the sum of n natural numbers.

        public static void ShowSum()
        {

            string confirm;

            do
            {
                Console.WriteLine("Enter a digit to sum natural numbers up to that");
                int n = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
                Console.WriteLine($"The sum of {n} number is: {sum}");

                Console.WriteLine("Do you want to continue type yes/no");
                confirm = Console.ReadLine().ToLower();

            }while( confirm == "yes" );
            
        }
    }
}
