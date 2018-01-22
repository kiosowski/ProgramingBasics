using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_C
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = Console.ReadLine();
            var secondName = Console.ReadLine();
            var age = double.Parse(Console.ReadLine());
            var gender = char.Parse(Console.ReadLine());
            var PersonalID = double.Parse(Console.ReadLine());
            var number = double.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}", secondName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", PersonalID);
            Console.WriteLine("Unique Employee number: {0}", number);

        }
    }
}
