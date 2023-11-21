using System;
using System.Collections.Generic;

namespace CityShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            string sofia = "Sofia",
                plovdiv = "Plovdiv",
                varna = "Varna";

            const string COFFEE = "coffee",
              WATER = "water",
              BEER = "beer",
              SWEETS = "sweets",
              PEANUTS = "peanuts";

            double coffeePrice = 0,
                waterPrice = 0,
                beerPrice = 0,
                sweetsPrice = 0,
                peanutsPrice = 0;


            if (sofia == city)
            {
                switch (product)
                {
                    case COFFEE:
                        coffeePrice = 0.5;
                        Console.WriteLine(quantity * coffeePrice);
                        break;
                    case WATER:
                        waterPrice = 0.8;
                        Console.WriteLine(waterPrice * quantity);
                        break;
                    case BEER:
                        beerPrice = 1.2;
                        Console.WriteLine(beerPrice * quantity);
                        break;
                }
            }
        }
    }
}
