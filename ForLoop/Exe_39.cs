using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_39
    {
        //39. Write a C# Sharp program to find the number and
        //sum of all integers between 100 and 200 divisible by 9.

        public static void FindNumsAndSum()
        {

                int sum = 0;
                for (int i = 101; i < 200; i++)
                {
                    if(i % 9 == 0)
                    {
                        Console.Write(i + " ");
                        sum += i;
                    }
                }
                Console.WriteLine($"\nThe sum is = {sum}");





            

        }
    }
}
