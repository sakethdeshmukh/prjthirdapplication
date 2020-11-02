using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Day1assq3evenodd
    {
        static void Main()
        {
            int x;
            Console.WriteLine("Input value of x");
            x = Convert.ToInt32(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("Number:{0} is even", x);
            }
            else
            {
                Console.WriteLine("Number:{0} is odd", x);
            }
            Console.ReadKey();
        }
    }
}
