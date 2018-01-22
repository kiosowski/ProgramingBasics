using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatinLetters
{
    class LatinLetters
    {
        static void Main(string[] args)
        {
            for (var letter = 'a'; letter <= 'z'; letter++)
            {
                Console.WriteLine(" " +letter);
            }
            Console.WriteLine();
        }
    }
}
