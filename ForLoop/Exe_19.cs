using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_19
    {
        //19. Write a program in C# Sharp to display the n terms of harmonic series and their sum.
        //1 + 1/2 + 1/3 + 1/4 + 1/5 ... 1/n terms

        public static void FindSum()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter the number of terms");
                int num = int.Parse(Console.ReadLine());

                double sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    Console.Write("1/{0} + ", i);
                    sum += 1 / (float)i;
                }

                Console.WriteLine($"\nSum of the series upto {num} terms: {sum}");


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
