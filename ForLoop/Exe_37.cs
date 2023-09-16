using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_37
    {
        //37. Write a program in C# Sharp to display a number in reverse order.

        public static void DisplayANum()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
               


                

                int r;
                int sum = 0;
                for (int t = num; t != 0; t = t / 10)
                {
                    r = t % 10;
                    sum = sum * 10 + r;
                }
                Console.Write("The number in reverse order is : {0} \n", sum);

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
