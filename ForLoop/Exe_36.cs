using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_36
    {
        //36. Write a program in C# Sharp to display such a pattern for n number of rows using a number
        //starting with the number 1. The first and last number of each row will be 1.

        public static void FindPattern()
        {


            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number of rows");
                int rows = int.Parse(Console.ReadLine());





                for (int i = 0; i <= rows; i++)
                {
                    /* print blank spaces */
                    for (int j = 1; j <= rows - i; j++)
                        Console.Write(" ");
                    /* Display number in ascending order upto middle*/
                    for (int j = 1; j <= i; j++)
                        Console.Write("{0}", j);

                    /* Display  number in reverse order after middle */
                    for (int j = i - 1; j >= 1; j--)
                        Console.Write("{0}", j);

                    Console.Write("\n");
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
