using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_49
    {
        //49. Write a C# Sharp program to find out the sum of the Arithmetic Progress series.

        public static void FindSumOfArithmSeries()
        {
                bool confirm = true;
                while (confirm)
                {
                    Console.WriteLine("Input the starting number of the A.P. series:");
                    int start = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the number of items for the A.P. series:");
                    int terms = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the common difference of A.P. series:");
                    int c_diff = int.Parse(Console.ReadLine());


                int  i, ln;
                int s1 = 0;

                s1 = (terms * (2 * start + (terms - 1) * c_diff)) / 2;
                ln = start + (terms - 1) * c_diff;
                Console.Write("\nThe Sum of the  A.P. series are : \n");

                for (i = start; i <= ln; i = i + c_diff)
                {
                    if (i != ln)
                        Console.Write("{0} + ", i);
                    else
                        Console.Write("{0} = {1} \n\n", i, s1);
                }

               








                Console.WriteLine("Do you want to continue? yes/no");
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
}
