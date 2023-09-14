using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_28
    {
        //28. Write a C# Sharp program to find the ‘perfect’ numbers within a given number range.

        public static void FindPerfectNumber()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter the starting range or number");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ending range or number");
                int end = int.Parse(Console.ReadLine());

                
                for (int n = start; n <= end; n++)
                {
                    int i = 1;
                    int sum = 0;
                    while (i < n)
                    {
                        if (n % i == 0)
                            sum += i;
                        i++;
                    }
                    if (sum == n)
                        Console.Write("{0} ", n);
                }
                Console.Write("\n");

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

