﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopandconditionalstatements
{
    class Forloopeg
    {
        static void Main()
        {
            int table, n;
            Console.WriteLine("enter table to be printed");
            table = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter number");
            n = Convert.ToInt32(Console.ReadLine());
            //for(initialization;condition;increment/decrement)
            for(int i=1; i<=n; i++)
            {
                int t = i * table;
                Console.WriteLine("{0} * {1} = {2}", i, table, t);
                Console.WriteLine("--------------------");
                //optimized
                Console.WriteLine("{0} * {1} = {2}", i, table, i*table);
            }
            Console.Read();
        }
    }
}
