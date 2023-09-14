using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_27
    {
        //27. Write a C# Sharp program for checking if a number is a perfect number.

        public static void CheckAPerfectNumber()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;


                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        
                        sum += i;
                        Console.Write(i + " ");
                    }
                }
                Console.WriteLine($"\nThe sum of the divisor is : {sum}");
                if(sum == num)
                {
                    Console.WriteLine($"{num} is a perfect number");
                }
                else
                {
                    Console.WriteLine($"{num} is not a perfect number");
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
