using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthEx
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var hatWidth = 4 * n + 1;
            var hatHeight = 2 * n + 5;
            var tire = 0;
            //upperpart
            Console.WriteLine("{0}/|\\{0}", new string('.', n * 2 - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', n * 2 - 1));
            

            for (int i = n * 2-1; i >= 1; i--)
            {
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.',i), new string('-', tire));
                tire +=1;
                
            }
            Console.WriteLine("{0}{1}{0}{1}{0}", new string('*',1), new string('-', n*2-1));

            Console.WriteLine("{0}", new string('*',hatWidth));

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j <= 2*n; j++)
                {
                    if (j == 2*n)
                    {
                        Console.Write("*");
                        break;
                    }
                    Console.Write(new string('*', 1) + new string('.', 1));

                    
                }
            }
            Console.WriteLine();
            Console.WriteLine("{0}", new string('*', hatWidth));

        }
    }
}
