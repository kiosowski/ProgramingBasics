using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniPleven
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var firstNumber = number / 1000;
            var secondNumber = (number % 1000) / 100;
            var thirdNumber = (number % 100) / 10;
            var fourthNumber = number % 10;
            Console.WriteLine(firstNumber + secondNumber + thirdNumber + fourthNumber);
        }
    }
}

