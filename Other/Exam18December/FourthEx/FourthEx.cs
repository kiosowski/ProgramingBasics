using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthEx
{
    class FourthEx
    {
        static void Main(string[] args)
        {
            var allStudents = int.Parse(Console.ReadLine());
            var top = 0.0;
            var good = 0.0;
            var middle = 0.0;
            var fail = 0.0;
            
            
            var sum = 0.0;

            for (int i = 1; i <= allStudents; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                if (grade >= 5.00)
                {
                    top++;
                }
                else if (grade >= 4.00 && grade <= 4.99)
                {
                    good++;
                }
                else if (grade >= 3.00 && grade <= 3.99)
                {
                    middle++;
                }
                else if (grade < 3.00)
                {
                    fail++;
                }
                sum += grade;
            }
            
            
            Console.WriteLine("Top students: {0:f2}%", top / allStudents * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", good / allStudents * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", middle / allStudents * 100);
            Console.WriteLine("Fail: {0:f2}%", fail / allStudents * 100);
            Console.WriteLine("Average: {0:f2}", sum / allStudents);
        }
    }
}
