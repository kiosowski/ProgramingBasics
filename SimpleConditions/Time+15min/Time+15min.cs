using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var resultMinutes = 0;
            var resultHours = 0;
            var totalMinutes = 60 * hours + minutes + 15;
            if (totalMinutes / 60 == 24)
            {
                resultMinutes = totalMinutes % 60;
                
            }
            else
            {
                resultMinutes = totalMinutes % 60;
                resultHours = totalMinutes / 60;
                
            }
            Console.WriteLine("{0}:{1:00}",resultHours,resultMinutes);
                
        }
    }
}
