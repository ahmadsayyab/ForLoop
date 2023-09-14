using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_24
    {
        //24. Write a program in C# Sharp to find the sum of the series [ x - x^3 + x^5 - x^7 + x^9 -.....].

        public static void FindSum()
        {
            bool confirm = true;

            while (confirm)
            {
                Console.WriteLine("Enter the value of X");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the number of terms");
                int terms = int.Parse(Console.ReadLine());

                double no_term = 1;
                double sum = 0;
                for (int i = 1, p = 1; i < terms + 1; i++)
                {
                    double ctr = Math.Pow(x, p);
                    sum += ctr * no_term;
                    no_term *= (-1);
                    p += 2;
                }
                Console.Write("\nThe sum = {0}\nNumber of terms = {1}\n The value of x = {2}\n", sum, no_term, x);

                Console.WriteLine("Do you want to continue? yes/no");
                string decide = Console.ReadLine();

                if(decide == "yes")
                {
                    confirm = true;
                }
                else
                {
                    confirm = false;
                }
            }
        }
    }
}
