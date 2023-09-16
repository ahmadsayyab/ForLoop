using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_41
    {
        //41. Write a program in C# Sharp to convert a decimal number into binary without using an array.

        public static void DeciToBin()
        {
            bool confirm = true;
            while (confirm)
            {
                int n, i, j, binno = 0, dn;
                Console.WriteLine("Enter a number");
                 n = int.Parse(Console.ReadLine());

                dn = n;
                i = 1;
                for (j = n; j > 0; j = j / 2)
                {
                    binno = binno + (n % 2) * i;
                    i = i * 10;
                    n = n / 2;
                    
                }

                Console.Write("\nThe Binary of {0} is {1}.\n\n", dn, binno);



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
