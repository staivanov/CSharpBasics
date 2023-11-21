using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {

            int budget = int.Parse(Console.ReadLine());
            string seasonInput = Console.ReadLine();
            int fishermanNumber = int.Parse(Console.ReadLine());

            string spring = "Spring",
               summer = "Summer",
               autumn = "Autumn",
               winter = "Winter";

            int springBoatRent = 3000,
                summerBoatRent = 4200,
                autumnBoatRent = 4200,
                winterBoatRent = 2600;

            double groupNumberBelowOr6Discount = 0.1,
                groupNumber7to11Discount = 0.15,
                group12orAboveDiscount = 0.25,
                regularPrice = 0,
                totalPrice = 0;

            switch (seasonInput)
            {
                case "Spring":

                    if (fishermanNumber <= 6)
                    {
                        regularPrice = springBoatRent - (springBoatRent * groupNumberBelowOr6Discount);
                    }
                    else if (fishermanNumber >= 7 && fishermanNumber <= 11)
                    {
                        regularPrice = springBoatRent - (springBoatRent * groupNumber7to11Discount);
                    }
                    else if (fishermanNumber > 12)
                    {
                        regularPrice = springBoatRent - (springBoatRent * group12orAboveDiscount);
                    }

                    totalPrice = FishermanEvenDiscountCalc(fishermanNumber, totalPrice, regularPrice);
                    BudgetCalculator(budget, totalPrice);
                    break;

                case "Summer":
                    if (fishermanNumber <= 6)
                    {
                        regularPrice = summerBoatRent - (summerBoatRent * groupNumberBelowOr6Discount);
                    }
                    else if (fishermanNumber >= 7 && fishermanNumber <= 11)
                    {
                        regularPrice = summerBoatRent - (summerBoatRent * groupNumber7to11Discount);
                    }
                    else if (fishermanNumber > 12)
                    {
                        regularPrice = summerBoatRent - (summerBoatRent * group12orAboveDiscount);
                    }

                    totalPrice = FishermanEvenDiscountCalc(fishermanNumber, totalPrice, regularPrice);
                    BudgetCalculator(budget, totalPrice);

                    break;

                case "Autumn":
                    if (fishermanNumber <= 6)
                    {
                        regularPrice = autumnBoatRent - (autumnBoatRent * groupNumberBelowOr6Discount);
                    }
                    else if (fishermanNumber >= 7 && fishermanNumber <= 11)
                    {
                        regularPrice = autumnBoatRent - (autumnBoatRent * groupNumber7to11Discount);
                    }
                    else if (fishermanNumber > 12)
                    {
                        regularPrice = autumnBoatRent - (autumnBoatRent * group12orAboveDiscount);
                    }

                    totalPrice = regularPrice;

                    BudgetCalculator(budget, totalPrice);

                    break;

                case "Winter":
                    if (fishermanNumber <= 6)
                    {
                        regularPrice = winterBoatRent - (winterBoatRent * groupNumberBelowOr6Discount);
                    }
                    else if (fishermanNumber >= 7 && fishermanNumber <= 11)
                    {
                        regularPrice = winterBoatRent - (winterBoatRent * groupNumber7to11Discount);
                    }
                    else if (fishermanNumber > 12)
                    {
                        regularPrice = winterBoatRent - (winterBoatRent * group12orAboveDiscount);
                    }

                    totalPrice = FishermanEvenDiscountCalc(fishermanNumber, totalPrice, regularPrice);
                    BudgetCalculator(budget, totalPrice);

                    break;

                default:
                    break;

            }
        }


        public static void BudgetCalculator(int userBudget, double price)
        {
            if (userBudget >= price)
            {
                Console.WriteLine($"Yes! You have {userBudget - price}leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {-(userBudget - price)} leva.");
            }
        }


        public static double FishermanEvenDiscountCalc(int fishermanNumber, double totalPrice, double regularPrice)
        {
            bool isFishermanNumberEven = (fishermanNumber % 2) == 0 ? true : false;

            double evenFishermanNumberDiscount = 0.05;

            if (isFishermanNumberEven)
            {
                totalPrice = regularPrice - (regularPrice * evenFishermanNumberDiscount);
            }
            else
            {
                totalPrice = regularPrice;
            }

            return totalPrice;
        }
    }
}
