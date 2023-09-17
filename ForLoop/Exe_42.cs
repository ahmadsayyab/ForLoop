using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Exe_42
    {
        //42. Write a program in C# Sharp to convert a binary number into a
        //decimal number without using array, function and while loop.

        public static void BinToDeci()
        {
            bool confirm = true;
            while (confirm)
            {
                Console.WriteLine("Enter a binary number to convert it into decimal");
                int num = int.Parse(Console.ReadLine());


                
                int raisedToPow = 0;
                double sum = 0;

               
                
                string numStr = num.ToString();

                for (int i = numStr.Length-1; i >= 0 ; i--)
                {
                    char digitChar = numStr[i];
                    //Console.Write(digitChar);
                    int digit = int.Parse(digitChar.ToString()); 
                    //Console.WriteLine(digit);
                    
                    if (digit == 1)
                    {
                        int multiByTwo = digit * 2;
                        double new_num = Math.Pow(multiByTwo, raisedToPow);
                        //Console.WriteLine(new_num);
                        sum += new_num;
                       
                    }
                    raisedToPow++;
                    //Console.WriteLine(raisedToPow);
                }


                Console.WriteLine(sum);






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
