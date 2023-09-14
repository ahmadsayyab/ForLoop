using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_22
    {

        //22. Write a program in C# Sharp to print Floyd's Triangle.

        public static void FindFloydTriangle()
        {
            string confirm;

            do
            {

                Console.WriteLine("Enter number of terms");
                int rows = int.Parse(Console.ReadLine());


                int p;
                int q ;
                for (int i = 1; i <= rows; i++)
                {
                    if (i % 2 == 0)
                    {
                         p = 1; 
                         q = 0; 
                    }
                    else
                    { 
                        p = 0; q = 1; 
                    }
                    for (int j = 1; j <= i; j++)

                        if (j % 2 == 0)

                            Console.Write("{0}", p);

                        else
                            Console.Write("{0}", q);

                    Console.Write("\n");
                }



                Console.WriteLine("Do you want to continue? type yes/no");
                confirm = Console.ReadLine().ToLower();
            } while (confirm == "yes");
        }
    }
}

