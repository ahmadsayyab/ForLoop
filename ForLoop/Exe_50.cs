using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_50
    {
        //50. Write a program in C# Sharp to convert a decimal number into octal without using an array.

        public static void DecimalToOctal()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number");
                int n = int.Parse(Console.ReadLine());


                int  i, j, ocno = 0, dn;
                dn = n;
                i = 1;

                for (j = n; j > 0; j = j / 8)
                {
                    ocno = ocno + (j % 8) * i;
                    i = i * 10;
                    n = n / 8;
                }

                Console.Write("\nThe Octal of {0} is {1}.\n\n", dn, ocno);







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
