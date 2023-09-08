using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_21
    {
        //21. Write a program in C# Sharp to display the sum of the series [ 9 + 99 + 999 + 9999 ...].


        //Exercise solution
        public static void FindSumOfSeris()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter number of terms");
                int num = int.Parse(Console.ReadLine());

                int sum = 0;
                int val = 9;

                for (int i = 1; i <= num; i++)
                {
                    sum += val;
                    Console.Write("{0}   ", val);
                    val =val * 10 + 9;
                }
                Console.WriteLine($"\nThe sum of the series is =  {sum}");


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
