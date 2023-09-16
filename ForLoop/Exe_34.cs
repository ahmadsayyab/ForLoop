using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_34
    {
        //34. Write a program in C# Sharp to find prime numbers within a range of numbers.

        public static void FindPrimeNums()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter lower range");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter upper range");
                int end = int.Parse(Console.ReadLine());



                
                for (int num = start; num <= end; num++)
                {
                    int ctr = 0;

                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }

                    if (ctr == 0 && num != 1)
                        Console.Write("{0} ", num);
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


