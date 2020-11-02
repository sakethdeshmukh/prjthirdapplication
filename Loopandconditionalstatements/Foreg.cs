using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Foreg

    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("enter your first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("num1 is the greatest");
                }
                else
                {
                    Console.WriteLine("num3 is the greatest");
                }
            }
            else if (num2 > num3)
                Console.WriteLine("num2 is the greatest");
            else
                Console.WriteLine("num3 is the greatest");
            Console.Read();
        }
    }
}


/////Read Introduction to .net
///1.Read Datatype in c#
///2.Write an Console Application to get Student Details from user and print the Same
///3.Create an Console Application to calculate area of square, area of rectangle using methods
///4.check the given number is odd number or not

