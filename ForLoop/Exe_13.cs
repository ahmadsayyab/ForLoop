using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_13
    {
        //13. Write a program in C# Sharp to make such a pattern
        //like a pyramid with numbers increasing by 1.


        public static void PrintPattern()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter a digit to print pyramid like pattren for");
                int num = int.Parse(Console.ReadLine());

                int spaces = num + 4 - 1;
                int n =1 ;
                for (int i = 1; i <= num; i++)
                {
                    for (int k = spaces; k >= 1; k--)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("{0} ", n++);
                    }
                        
                    Console.Write("\n");
                    spaces--;
                }


                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}
