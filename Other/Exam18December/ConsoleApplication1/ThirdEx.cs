using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ThirdEx
    {
        static void Main(string[] args)
        {
            var buyChrysanthemums = double.Parse(Console.ReadLine());
            var buyRoses = double.Parse(Console.ReadLine());
            var buyTulip = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var holiday = char.Parse(Console.ReadLine());
            var allFlowers = buyChrysanthemums + buyRoses + buyTulip;
            var price = 0.0;

            switch (season)
            {
                case "Spring":
                case "Summer":
                    if (holiday == 'Y')
                    {
                        price = (((buyChrysanthemums * 2.00) + (buyRoses * 4.10) + (buyTulip * 2.50)) * 1.15);


                     
                        if (buyTulip > 7 && season == "Spring")
                        {
                            price *= 0.95;
                        }
                        if (allFlowers > 20)
                        {
                            price *= 0.80;
                        }
                    }
                    else
                    {
                        price = ((buyChrysanthemums * 2.00) + (buyRoses * 4.10) + (buyTulip * 2.50)) ;
                        
                        if (buyTulip > 7 && season == "Spring")
                        {
                            price *= 0.95;
                        }
                        if (allFlowers > 20)
                        {
                            price *= 0.80;
                        }
                        
                    }
                    break;
                case "Autumn":
                case "Winter":
                    if (holiday == 'Y')
                    {
                        price = (((buyChrysanthemums * 3.75) + (buyRoses * 4.50) + (buyTulip * 4.15))) * 1.15;

                        
                        if (buyRoses >= 10 && season == "Winter")
                        {
                            price *= 0.90;
                        }
                        if (allFlowers > 20)
                        {
                            price *= 0.80;
                        }
                    }
                    else 
                    {
                        price = ((buyChrysanthemums * 3.75) + (buyRoses * 4.50) + (buyTulip * 4.15));
                        
                        if (buyRoses >= 10 && season == "Winter")
                        {
                            price *= 0.90;
                        }
                        if (allFlowers > 20)
                        {
                            price *= 0.80;
                        }
                        
                    }
                    break;

            }
            var finalPrice = price;
            Console.WriteLine("{0:f2}", finalPrice + 2.00);





        }
    }
}
