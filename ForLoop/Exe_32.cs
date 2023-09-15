using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_32
    {
        //32. Write a C# Sharp program to determine whether a given number is prime or not.

        public static void CheckInput()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number to check if it is a prime number");
                int num = int.Parse(Console.ReadLine());

                int n = 0;
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        n++;
                        break;
                    }
                }
                if (n == 0 && num != 1)
                    Console.Write("{0} is a prime number.\n", num);
                else
                    Console.Write("{0} is not a prime number\n", num);


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

