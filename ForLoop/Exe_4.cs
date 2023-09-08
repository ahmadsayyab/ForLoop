using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_4
    {
        //4. Write a C# Sharp program to read 10 numbers and find their average and sum.

        public static void FindSumAndAvg()
        {
            Console.WriteLine("Enter 10 numbers");
            int sum = 0;
            double avg;

            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine($"Enter number {i}: ");
                int num = int.Parse(Console.ReadLine());

                sum += num;
            }

            avg = sum / 10.0;
            Console.WriteLine($"The sum of your qo digits is: {sum}");
            Console.WriteLine($"The average is: {avg}");
            


        }
    }
}
