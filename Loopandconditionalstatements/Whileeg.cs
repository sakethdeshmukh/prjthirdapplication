using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Whileeg
    {
        static void Main()
        {
            int endvalue, initialvalue = 1;
            Console.WriteLine("enter the number");
            endvalue = Convert.ToInt32(Console.ReadLine());
            while(initialvalue<=endvalue)
            {
                //console.writeline("initialvalue:{0}", initialvalue);
                
                if(initialvalue%2==0)
                {
                    Console.WriteLine("{0} is even", initialvalue);
                }
                initialvalue++;
            }
            Console.Read();
        }
    }
}
