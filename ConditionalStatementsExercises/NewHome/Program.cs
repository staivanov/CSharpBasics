using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {

            double rosePrice = 5,
                dahliaPrice = 3.8,
                tulipPrice = 2.8,
                narcissusPrice = 3,
                gladiolusPrice = 2.5,
                flowerDiscount = 0,
                regularPrice = 0,
                totalPrice = 0;

            string flowerType = Console.ReadLine();
            int flowersNumber = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            bool isBudgetEnough;

            switch (flowerType)
            {
                case "Roses":
                    if (flowersNumber > 80)
                    {
                        flowerDiscount = 0.1;
                        regularPrice = flowersNumber * rosePrice;
                        totalPrice = regularPrice - (regularPrice * flowerDiscount);
                    }
                    else
                    {
                        totalPrice = flowersNumber * rosePrice;
                    }

                    totalPrice = budget - totalPrice;
                    isBudgetEnough = totalPrice > 0 ? true : false;

                    if (isBudgetEnough)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowerType} and {totalPrice} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {-totalPrice} leva more.");
                    }                  
                    break;

                case "Dahlias":
                    if (flowersNumber > 90)
                    {
                        flowerDiscount = 0.15;
                        regularPrice = flowersNumber * dahliaPrice;
                        totalPrice = regularPrice - (regularPrice * flowerDiscount);
                    }
                    else
                    {
                        totalPrice = flowersNumber * dahliaPrice;
                    }

                    totalPrice = budget - totalPrice;

                     isBudgetEnough = totalPrice > 0 ? true : false;

                    if (isBudgetEnough)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowerType} and {totalPrice} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {-totalPrice} leva more.");
                    }
                    break;

                case "Tulips":
                    if (flowersNumber > 80)
                    {
                        flowerDiscount = 0.15;
                        regularPrice = flowersNumber * tulipPrice;
                        totalPrice = regularPrice - (regularPrice * flowerDiscount);
                    }
                    else
                    {
                        totalPrice = flowersNumber * tulipPrice;
                    }

                    totalPrice = budget - totalPrice;

                    isBudgetEnough = totalPrice > 0 ? true : false;

                    if (isBudgetEnough)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowerType} and {totalPrice} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {-totalPrice} leva more.");
                    }
                    break;

                case "Narcissus":
                    if (flowersNumber < 120)
                    {
                        double flowerPricePercent = 0.15;
                        regularPrice = flowersNumber * narcissusPrice;
                        totalPrice = regularPrice + (regularPrice * flowerPricePercent);
                    }
                    else
                    {
                        totalPrice = flowersNumber * narcissusPrice;
                    }

                    totalPrice = budget - totalPrice;

                    isBudgetEnough = totalPrice > 0 ? true : false;

                    if (isBudgetEnough)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowerType} and {totalPrice} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {-totalPrice} leva more.");
                    }
                    break;

                case "Gladiolus":
                    if (flowersNumber < 80)
                    {
                        double flowerPricePercent = 0.20;
                        regularPrice = flowersNumber * narcissusPrice;
                        totalPrice = regularPrice + (regularPrice * flowerPricePercent);
                    }
                    else
                    {
                        totalPrice = flowersNumber * narcissusPrice;
                    }

                    totalPrice = budget - totalPrice;

                    isBudgetEnough = totalPrice > 0 ? true : false;

                    if (isBudgetEnough)
                    {
                        Console.WriteLine($"Hey, you have a great garden with {flowersNumber} {flowerType} and {totalPrice} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {-totalPrice} leva more.");
                    }
                    break;

                default:
                    Console.WriteLine($"Not enough money!");
                    break;

            }




        }
    }
}
