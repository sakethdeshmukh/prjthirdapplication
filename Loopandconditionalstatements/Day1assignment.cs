using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Day1assignment
    {
        static void Main()
        {
            string studentname, city, branch;
            int age, yearofjoining;
            Console.WriteLine("Enter studentname");
            studentname = Console.ReadLine();
            Console.WriteLine("Enter city");
            city = Console.ReadLine();
            Console.WriteLine("Enter branch");
            branch = Console.ReadLine();
            Console.WriteLine("Enter your age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your yearofjoining");
            yearofjoining = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------student details-------------");
            Console.WriteLine("studentname {0} ||  City : {1}  || branch :{2} || age :{3} || yearofjoining :{4} ", studentname, city, branch, age, yearofjoining);
            Console.Read();
        }
    }
}
