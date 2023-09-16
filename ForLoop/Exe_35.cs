using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_35
    {

        //35. Write a program in C# Sharp to display the first n terms of Fibonacci series.
        //Fibonacci series 0 1 1 2 3 5 8 13 .....

        public static void FibonacciSereiesTerms()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number of terms to display");
                int terms = int.Parse(Console.ReadLine());


                int prv = 0, pre = 1, trm, i;
                for (i = 3; i <= terms; i++)
                {
                    trm = prv + pre;
                    Console.Write("  {0}  ", trm);
                    prv = pre;
                    pre = trm;
                }
                Console.Write("\n");
            }






            Console.WriteLine("\nDo you want to continue? yes/no");
                string choice = Console.ReadLine();

                if (choice == "yes")
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
