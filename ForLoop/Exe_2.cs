using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_2
    {
        //2. Write a C# Sharp program to find the sum of the first 10 natural numbers.

        public static void ShowSum()
        {
            int sum = 0;

            for(int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum is: {sum}");
        }
    }
}
