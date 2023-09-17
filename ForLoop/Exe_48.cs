using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_48
    {
        //48. Write a C# Sharp program to find Strong Numbers within a range of numbers.

        public static void CheckInput()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter the starting range");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the ending range");
                int end = int.Parse(Console.ReadLine());






                int i, n1, s1 = 0, j, k;
                int fact;
                for (k = start; k <= end; k++)
                {
                    n1 = k;
                    s1 = 0;

                    for (j = k; j > 0; j = j / 10)
                    {

                        fact = 1;
                        for (i = 1; i <= j % 10; i++)
                        {
                            fact = fact * i;
                        }
                        s1 = s1 + fact;
                    }

                    if (s1 == n1)

                        Console.Write("{0}  ", n1);
                }
                Console.Write("\n\n");











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

