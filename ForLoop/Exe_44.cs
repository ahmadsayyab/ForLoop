using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_44
    {
        //44. Write a program in C# Sharp to find the LCM of any two numbers using HCF.


        public static void FindHLCM()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter 1st number for HCF");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number for HCF");
                int num2 = int.Parse(Console.ReadLine());

                int i, j, hcf = 1;
                j = (num1 < num2) ? num1 : num2;
                for (i = 1; i <= j; i++)
                {
                    if (num1 % i == 0 && num2 % i == 0)
                    {
                        hcf = i;
                    }
                }

                double LCM = (num1 * num2) / hcf;
                Console.Write($"The LCM of {num1} and {num2} is : {LCM}\n");








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
