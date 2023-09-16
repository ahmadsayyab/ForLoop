using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_40
    {
        //40. Write a C# Sharp Program to display the following pattern using the alphabet.

        public static void DrawPattern()
        {

            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter number of rows");
                int rows = int.Parse(Console.ReadLine());

                int i, j;
                char alph = 'A';
                
                int ctr = 1;

                for (i = 1; i <= rows; i++)
                {
                    for (j = 0; j <= (ctr / 2); j++)
                    {
                        Console.Write("{0} ", alph++);
                    }
                    alph--;
                    alph--;

                    for (j = 0; j < (ctr / 2); j++)
                    {
                        Console.Write("{0} ", alph--);
                    }
                    ctr = ctr + 2;
                    alph = 'A';
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
