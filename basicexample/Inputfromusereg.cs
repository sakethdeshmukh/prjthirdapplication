﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicexample
{
    class Inputfromusereg
    {
        static void Main()
        {
            string name, city;
            int age;
            Console.WriteLine("Enter your name");
            name = Console.ReadLine(); ////Console.Read(); ////input from user
            Console.WriteLine("Enter your city");
            city = Console.ReadLine();
            Console.WriteLine("Enter your age");
            ///concerting string into int
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("-----------------");
            Console.WriteLine("Name;{0}  || City : {1}  || Age :{2}", name, city, age);
            Console.Read();


        }
    }
}
