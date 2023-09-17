using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_43
    {
        //43. Write a C# Sharp program to find the HCF (Highest Common Factor) of two numbers.

        public static void FindHCF()
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
                Console.Write("\nHCF of {0} and {1} is : {2}\n\n", num1, num2, hcf);








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
