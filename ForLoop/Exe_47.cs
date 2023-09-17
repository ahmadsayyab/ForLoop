using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_47
    {
        //47. Write a C# Sharp program to check whether a number is a Strong Number or not


        public static void CheckInput()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());



                string numStr = num.ToString();
                double sum = 0;
                //int raisedToPow;
               // double new_num;

                for (int i = 0; i < numStr.Length; i++)
                {
                    char digitChar = numStr[i];
                    int digit = int.Parse(digitChar.ToString());

                    int factorial = 1;
                    for (int j = 1; j <= digit; j++)
                    {
                        factorial *= j;
                    }

                    sum += factorial;
                }


                if (sum == num)
                {
                    Console.WriteLine($"{num} is a strong number");
                }
                else
                {
                    Console.WriteLine($"{num} is not a strong number");
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
