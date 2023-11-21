using System;

namespace _9._PlantingBackyards
{
    class Program
    {
        static void Main(string[] args)
        {

            double pricePerMeter = 7.61;
            double discountPercent = 18;
            double plantingSize = double.Parse(Console.ReadLine());
            double plantingPrice = plantingSize * pricePerMeter;
            double discount = plantingPrice * (discountPercent / 100);
            double finalPrice = plantingPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
