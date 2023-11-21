using System;

namespace _12_TradeComission
{
    class Program
    {
        static void Main(string[] args)
        {
            string userCity = Console.ReadLine();
            double userSoldQuantity = double.Parse(Console.ReadLine());

            string sofia = "Sofia",
                varna = "Varna",
                plovdid = "Plovdiv";

            int minQuantityCategoryMaxValue = 500,
                minToMediumQuantityCategoryMaxValue = 1000,
                mediumQuantityMaxValue = 10000;

            double commissionRate = 0,
                commissionMoney = 0;

            const string minQuantityCategory = "Minimum",
                 minToMediumQuantiyCategory = "MinToMediumQuantiy",
                 mediumQuantity = "MediumQuantity,",
                 highQuantity = "HighQuantity";

            string categoryByUserQuantityInput = " ";

            if (userSoldQuantity > mediumQuantityMaxValue)
            {
                categoryByUserQuantityInput = highQuantity;
            }
            else if (userSoldQuantity <= mediumQuantityMaxValue && userSoldQuantity > minToMediumQuantityCategoryMaxValue)
            {
                categoryByUserQuantityInput = mediumQuantity;
            }
            else if (userSoldQuantity <= minToMediumQuantityCategoryMaxValue && userSoldQuantity > minQuantityCategoryMaxValue)
            {
                categoryByUserQuantityInput = minToMediumQuantiyCategory;
            }
            else
            {
                categoryByUserQuantityInput = minQuantityCategory;
            }


            if (sofia == userCity)
            {
                switch (categoryByUserQuantityInput)
                {
                    case minQuantityCategory:
                        commissionRate = 0.05;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case minToMediumQuantiyCategory:
                        commissionRate = 0.07;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case mediumQuantity:
                        commissionRate = 0.08;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case highQuantity:
                        commissionRate = 1.2;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (varna == userCity)
            {
                switch (categoryByUserQuantityInput)
                {
                    case minQuantityCategory:
                        commissionRate = 0.045;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case minToMediumQuantiyCategory:
                        commissionRate = 0.075;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case mediumQuantity:
                        commissionRate = 0.1;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case highQuantity:
                        commissionRate = 0.13;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (plovdid == userCity)
            {
                switch (categoryByUserQuantityInput)
                {
                    case minQuantityCategory:
                        commissionRate = 0.055;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case minToMediumQuantiyCategory:
                        commissionRate = 0.08;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case mediumQuantity:
                        commissionRate = 0.12;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    case highQuantity:
                        commissionRate = 0.145;
                        commissionMoney = userSoldQuantity * commissionRate;
                        Console.WriteLine(commissionMoney);
                        break;

                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
