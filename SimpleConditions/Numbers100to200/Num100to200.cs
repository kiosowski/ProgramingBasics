﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers100to200
{
    class Num100to200
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
