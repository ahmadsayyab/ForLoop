using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_26
    {
        //26. Write a program in C# Sharp to find the sum of the series 1 +11 + 111 + 1111 + .. n terms.

        public static void FindSum()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number of terms");
                int terms = int.Parse(Console.ReadLine());

                int sum = 0;
                int n = 1;
                for (int i = 1; i <= terms; i++)
                {
                    Console.Write("{0} + ", n);
                    sum += n;
                    n = (n * 10) + 1;
                    Console.WriteLine(n);
                }
                Console.Write($"\nThe Sum is : {sum}\n");

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
