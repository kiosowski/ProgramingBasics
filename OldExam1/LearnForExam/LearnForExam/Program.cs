using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            var countLoads = int.Parse(Console.ReadLine());

            var loadSum = 0;

            var loadsWithBus = 0.0;
            var loadsWithTruck = 0.0;
            var loadsWithTrain = 0.0;

            for (int i = 0; i < countLoads; i++)
            {
                var loads = int.Parse(Console.ReadLine());
                loadSum += loads;
                if (loads < 4)
                {
                    loadsWithBus += loads;
                }
                else if (loads > 3 && loads < 12)
                {
                    loadsWithTruck += loads;
                }
                else
                {
                    loadsWithTrain += loads;
                }
               
            }
            var average = (loadsWithBus * 200 + loadsWithTruck * 175 + loadsWithTrain * 120) /
           loadSum;
            Console.WriteLine("{0:F2}", average);

            Console.WriteLine("{0:F2}%", loadsWithBus / loadSum * 100);
            Console.WriteLine("{0:F2}%", loadsWithTruck / loadSum * 100);
            Console.WriteLine("{0:F2}%", loadsWithTrain / loadSum * 100);
        }

    }
}



