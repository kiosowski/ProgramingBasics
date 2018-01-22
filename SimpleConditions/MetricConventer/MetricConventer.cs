using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetricConventer
{
    class MetricConventer
    {
        static void Main(string[] args)
        {
            var numToConvert = double.Parse(Console.ReadLine());
            var fromMetric = Console.ReadLine();
            var toMetric = Console.ReadLine();
            var metres = 0.0;
            double result = 0;

            if (fromMetric == "mm")
            {
                metres = numToConvert * 0.001;           
            }
            if (fromMetric == "m")
            {
                metres = numToConvert;
            }
            if (fromMetric == "cm")
            {
                metres = numToConvert * 0.01;
            }
            if (fromMetric == "mi")
            {
                metres = numToConvert * 1/0.000621371192;
            }
            if (fromMetric == "in")
            {
                metres = numToConvert * 1/ 39.3700787;
            }
            if (fromMetric == "km")
            {
                metres = numToConvert * 1 / 0.001;
            }
            if (fromMetric == "ft")
            {
                metres = numToConvert * 1/ 3.2808399;
            }
            if (fromMetric == "yd")
            {
                metres = numToConvert * 1/ 1.0936133;
            }
            
            if (toMetric == "mm")
            {
                result = metres * 1000;
            }
            if (toMetric == "cm")
            {
                result = metres * 100;
            }
            if (toMetric == "mi")
            {
                result = metres * 0.000621371192;
            }
            if (toMetric == "in")
            {
                result = metres * 39.3700787;
            }
            if (toMetric == "km")
            {
                result = metres * 0.001;
            }
            if (toMetric == "ft")
            {
                result = metres * 3.2808399;
            }
            if (toMetric == "yd")
            {
                result = metres * 1.0936133;
            }
            if (toMetric == "m")
            {
                result = metres;
            }
            Console.WriteLine(result +" " + toMetric);
            




        }

    }
}







