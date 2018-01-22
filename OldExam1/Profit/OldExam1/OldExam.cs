using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldExam1
{
    class OldExam
    {
        static void Main(string[] args)
        {
            var workDays = int.Parse(Console.ReadLine());
            var moneyForDay = double.Parse(Console.ReadLine());
            var dollarToLev = double.Parse(Console.ReadLine());

            var monthSalary = workDays * moneyForDay;
            var revenue = monthSalary * 12 + monthSalary * 2.5;
            var tax = revenue * 0.75;

            var income = tax * dollarToLev;
            var money = income / 365;
            
            Console.WriteLine("{0:F2}",money);

        }
    }
}
