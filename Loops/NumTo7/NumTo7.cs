﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumTo7
{
    class NumTo7
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 1000; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
