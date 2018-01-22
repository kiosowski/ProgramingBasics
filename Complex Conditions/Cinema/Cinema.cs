using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            var rows = double.Parse(Console.ReadLine());
            var columns = double.Parse(Console.ReadLine());
            var result = 0.0;
            if (type == "Premiere")
            {
                result = (rows * columns) * 12;
                Console.WriteLine("{0:f2}", result);
            }
            else if (type == "Normal")
            {
                result = (rows * columns) * 7.5;
                Console.WriteLine("{0:f2}", result);
            }
            else if (type == "Discount")
            {
                result = (rows * columns) * 5.00;
                Console.WriteLine("{0:f2}", result);
            }
        }
        
        }
    }

