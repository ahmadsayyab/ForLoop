using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_30
    {
        //30. Write a C# Sharp program to find the Armstrong number for a given range of numbers.


        public static void FindArmstrongInRange()
        {
            int num, r, sum, temp;
           
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter starting number or range");
                int start = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter ending number or range");
                int end = int.Parse(Console.ReadLine());


                for (num = start; num <= end; num++)
                {
                    temp = num;
                    sum = 0;

                    while (temp != 0)
                    {
                        r = temp % 10;
                        temp = temp / 10;
                        sum = sum + (r * r * r);
                    }
                    if (sum == num)
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
