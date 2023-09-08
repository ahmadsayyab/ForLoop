using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_8
    {
        //8. Write a C# Sharp program to display the n terms of odd natural numbers and their sums.


        public static void FindOddNumsAndSum()
        {
            string confirm;

            do
            {
                Console.WriteLine("Input number of terms : ");
                int num = int.Parse(Console.ReadLine());

                int odd_num = 0;
                string print_oddNum = null;
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    
                        
                        odd_num = 2*i -1;
                        sum += odd_num;
                        print_oddNum += " " + odd_num;
                    
                }
                Console.Write($"The odd numbers are: {print_oddNum}");
                Console.WriteLine($"\nSum of odd Natural numbers up to {num} terms: {sum}");

                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            }while (confirm == "yes");
        }
    }
}
