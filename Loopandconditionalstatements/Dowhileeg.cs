using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Dowhileeg
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("enter the number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while (initialvalue > endvalue)
            {
                Console.WriteLine("inside while");
            }
            do
            {
                Console.WriteLine("initialvalue: {0}", initialvalue);
                initialvalue++;
            } while (initialvalue > endvalue);
            Console.Read();
        }
    }

}
