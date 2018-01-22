using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firm
{
    class Firm
    {
        static void Main(string[] args)
        {
            var needHour = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workersOverTime = int.Parse(Console.ReadLine());

            var workDays = days * 0.90;
            var overtime = workersOverTime * 2 * days;
            var workTime = Math.Floor(workDays * 8 + overtime);

            if (needHour <= workTime)
            {
                Console.WriteLine("Yes!{0} hours left.", workTime - needHour);
            }
            else
            {
                Console.WriteLine("Not enough time!{0} hours needed.", needHour - workTime);
            }
        }
    }
}
