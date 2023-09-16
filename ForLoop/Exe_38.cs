using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_38
    {
        //38. Write a program in C# Sharp to check whether a number is a palindrome or not.

        public static void CheckNum()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                for (int t = num; t != 0; t = t / 10)
                {
                    int r = t % 10;
                    sum = sum * 10 + r;
                }

                if(sum == num)
                {
                    Console.WriteLine($"The {num} is a Palindrome");
                }
                else
                {
                    Console.WriteLine($"The {num} is a Palindrome");
                }





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
