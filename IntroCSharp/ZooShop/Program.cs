using System;

namespace ZooShop
{
    class Program
    {
        static void Main()
        {

            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;

            double dogFoodPackage = double.Parse(Console.ReadLine());
            double catFoodPackage = double.Parse(Console.ReadLine());
            double sum = (dogFoodPrice * dogFoodPackage) + (catFoodPackage * catFoodPrice);

            Console.WriteLine($"{sum}lv");

        }
    }
}
