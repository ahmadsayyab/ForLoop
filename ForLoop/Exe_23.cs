using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_23
    {
        //23. Write a program in C# Sharp to display the sum of the series [ 1+x+x^2/2!+x^3/3!+....].

        public static void FindSunm()
        {
            Console.WriteLine("Enter the values of X");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of terms");
            int terms = int.Parse(Console.ReadLine());

            double sum = 1; 
            double no_row = 1;
            for (int i = 1; i < terms; i++)
            {
                no_row = no_row * x / (float)i;
                sum += no_row;
            }
           
            Console.Write($"\nThe sum  is {sum}: \nNumber of terms = {terms}\nThe value of x = {x}\n");
        }
    }
}
