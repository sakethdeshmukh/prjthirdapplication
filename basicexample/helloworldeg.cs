using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class helloworldeg
    {
        static void Main()
        {
            Console.Write("Hello World");
          
            Console.WriteLine("--------");
            ///print your name
            string myname = "Saketh ", Fathername = "Raj";
            Console.WriteLine(myname);

            //concatination
            Console.WriteLine("concatination");
            Console.WriteLine("myname:" + myname);
            Console.WriteLine("-----------");
            ////place holder
            Console.WriteLine("Placeholder");
            Console.WriteLine("Myname:{0}", myname);
            Console.WriteLine("Myname:{0} ||Fathername:{1}", myname, Fathername);
            Console.Read();

        }
    }
}
