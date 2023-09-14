using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_29
    {

        //29. Write a C# Sharp program to check whether a given number is an Armstrong number or not.

        public static void FindArmstrongNum()
        {

            


            bool confirm = true;
            while (confirm)
            {

                Console.WriteLine("Enter a number to check if it is Amstrong or not");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                int temp;
                for (temp = num; num != 0; num = num / 10)
                {
                    int r = num % 10;
                    sum = sum + (r * r * r);
                }
                if (sum == temp)
                    Console.Write("{0} is an Armstrong number.\n", temp);
                else
                    Console.Write("{0} is not an Armstrong number.\n", temp);

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

