using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_25
    {
        //25. Write a C# Sharp program that displays the n terms of square natural numbers and their sum.

        public static void FindSum()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number of terms");
                int terms = int.Parse(Console.ReadLine());

                double sum = 0;
                double sqr;
                string sqr_terms = null;

                for (int i = 1; i <= terms; i++)
                {
                    sqr = Math.Pow(i, 2);
                    sum += sqr;
                    sqr_terms += sqr.ToString() + " ";
                }
                Console.WriteLine($"The square natural upto {terms} terms are :{sqr_terms}");
                Console.WriteLine($"The Sum of Square Natural Number upto {terms} terms = {sum}");

                Console.WriteLine("Do you want to continue? yes/no");
                string decide = Console.ReadLine();

                if (decide == "yes")
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
