using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_5
    {
        //5. Write a C# Sharp program to display the cube of an integer up to given number.

        public static void FindCube()
        {
            string confirm;
            do
            {
                Console.WriteLine("Enter a digit");
                int digit = int.Parse(Console.ReadLine());

                double cube = 0;

                for (int i = 1; i <= digit; i++)
                {
                    cube = Math.Pow(i, 3);
                    Console.WriteLine($"Number is : {i} and cube of the {i} is : {cube}");
                }

                Console.WriteLine("Do you want to continue type yes/no");
                confirm = Console.ReadLine();
            }while (confirm == "yes");
            

        }
    }
}
