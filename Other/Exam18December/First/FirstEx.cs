using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First     
{
    class FirstEx
    {
        static void Main(string[] args)
        {
            //s = v * t
            var firstSpeed = int.Parse(Console.ReadLine());
            var firstTime = int.Parse(Console.ReadLine());
            var secondTime = int.Parse(Console.ReadLine());
            var thirdTime = int.Parse(Console.ReadLine());

            var firstDistance = (firstSpeed * firstTime) / 60.00;
            var secondSpeed = firstSpeed + (firstSpeed * 0.1);
            var thirdSpeed = secondSpeed * 0.95;
            var secondDistance = (secondSpeed * secondTime) / 60.00;
            var thirdDistance = (thirdSpeed * thirdTime) / 60.00;

            var result = firstDistance + secondDistance + thirdDistance;
            Console.WriteLine("{0:f2}",result);

        }
    }
}
