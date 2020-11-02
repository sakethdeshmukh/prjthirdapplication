using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Day1assq3
    {
        static void Main()
        {
            int areaofsq, areaofrec, side, length, breadth;
            Console.WriteLine("Enter side");
            side = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth = Convert.ToInt32(Console.ReadLine());
            areaofsq = side * side;
            areaofrec = length * breadth;
            Console.WriteLine("----------area of square & area of rectangle-------------");
            Console.WriteLine("the area of square is :{0} & the area of rectangle is :{1}", areaofsq, areaofrec);
            Console.Read();
        }
    }
}
