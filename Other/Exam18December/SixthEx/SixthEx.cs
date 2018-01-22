using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixthEx
{
    class SixthEx
    {
        static void Main(string[] args)
        {
            var firstLetter = char.Parse(Console.ReadLine());
            var secondLetter = char.Parse(Console.ReadLine());
            var stop = char.Parse(Console.ReadLine());
            var counter = 0;
            for (char i = firstLetter; i <= secondLetter; i++)
            {
                for (char j = firstLetter; j <= secondLetter; j++)
                {
                    for (char k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i == stop || j == stop || k == stop)
                        {
                            
                            continue;
                        }
                        Console.Write("{0}{1}{2} ", i, j, k);
                        counter++;
                    }
                }
                
            }
            Console.WriteLine("{0}",counter);
        }
    }
}
