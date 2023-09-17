using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_45
    {
        //45. Write a program in C# Sharp to find the LCM of any two numbers.

        public static void FindLCM()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter 1st number for LCM");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2nd number for LCM");
                int num2 = int.Parse(Console.ReadLine());

                int i, max, lcm = 1;
                max = (num1 > num2) ? num1 : num2;
                for (i = max; ; i += max)
                {
                    if (i % num1 == 0 && i % num2 == 0)
                    {
                        lcm = i;
                        break;
                    }
                }
                Console.Write("\nLCM of {0} and {1} = {2}\n\n", num1, num2, lcm);








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
