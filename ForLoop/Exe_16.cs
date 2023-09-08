using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_16
    {
        //16. Write a program in C# Sharp to display the n terms of even natural number and their sum.

        public static void FindEvenNumAndSum()
        {
            string confirm;

            do
            {
                Console.WriteLine("Enter a number of terms");
                int num = int.Parse(Console.ReadLine());
                

                int sum = 0;
                int even_num;
                string print_evenNum = null;
                for (int i = 1; i <= num; i++)
                {
                    even_num = 2*i;
                    sum += even_num;

                    print_evenNum += " " + even_num;

                    
                }
                 Console.WriteLine($"The even numbers are: {print_evenNum}");
                Console.WriteLine($"The Sum of even Natural Number upto {num} terms : {sum}");

                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }

    }
}
