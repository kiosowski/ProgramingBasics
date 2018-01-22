using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square")
            {
                var firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine(firstNum * firstNum);
                            
            }
            else if (figure == "rectangle")
            {
                var firstNum = double.Parse(Console.ReadLine());
                var secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine(firstNum * secondNum);
            }
            else if (figure == "circle")
            {
                var firstNum = double.Parse(Console.ReadLine());
                Console.WriteLine(firstNum * firstNum * Math.PI);
            }
            else if (figure == "triangle")
            {
                var firstNum = double.Parse(Console.ReadLine());
                var secondNum = double.Parse(Console.ReadLine());
                Console.WriteLine(firstNum * secondNum / 2);

            }
           
           
        }
    }
}
