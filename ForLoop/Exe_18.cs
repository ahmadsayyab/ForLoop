using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_18
    {
        //18. Write a program in C# Sharp to find the sum of the series [ 1-X^2/2!+X^4/4!- .........].


        public static void FindSeriesSum()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter the value of X: ");
                int X = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of terms: ");
                int no_terms = int.Parse(Console.ReadLine());

                double sum = 1;
               double t = 1;
                for (int i = 1; i < no_terms; i++)
                {
                    double d = (2 * i) * (2 * i - 1);
                     t = -t * X * X / d;
                    sum = sum + t;
                }

                Console.WriteLine($"The sum = {sum}");
                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
