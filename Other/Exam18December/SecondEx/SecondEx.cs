using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondEx
{
    class SecondEx
    {
        static void Main(string[] args)
        {
            var allMoney = double.Parse(Console.ReadLine());
            var widthFloor = double.Parse(Console.ReadLine());
            var heightFloor = double.Parse(Console.ReadLine());
            var sideTriangle = double.Parse(Console.ReadLine());
            var heightTriangle = double.Parse(Console.ReadLine());
            var priceForOneTile = double.Parse(Console.ReadLine());
            var priceWorkMan = double.Parse(Console.ReadLine());

            var floor = widthFloor * heightFloor;
            var tile = sideTriangle * heightTriangle / 2.00;
            var needTile = Math.Ceiling((floor / tile)) + 5.00;
            var needMoney = (needTile * priceForOneTile) + priceWorkMan;

            if (needMoney > allMoney)
            {
                
                Console.WriteLine("You'll need {0:f2} lv more.", needMoney - allMoney);
            }
            else
            {
                
                Console.WriteLine("{0:f2} lv left.", allMoney - needMoney);
            }
        }
    }
}
