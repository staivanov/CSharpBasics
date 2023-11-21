using System;

namespace _7._FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            double chichenMenuPrice = 10.35,
                fishMenuPrice = 12.4,
                vegetarianMenuPrice = 8.15,
                deliveryPrice = 2.5,
                dessertPricePercent = 0.2;

            double chichenPortionNumber = double.Parse(Console.ReadLine());
            double fishPortionNumber = double.Parse(Console.ReadLine());
            double vegetarianPortionNumber = double.Parse(Console.ReadLine());

            double foodBill = chichenPortionNumber * chichenMenuPrice +
                fishPortionNumber * fishMenuPrice +
                vegetarianMenuPrice * vegetarianPortionNumber;
            double dessertBill = foodBill * dessertPricePercent;

            double totalPrice = dessertBill + foodBill + deliveryPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
