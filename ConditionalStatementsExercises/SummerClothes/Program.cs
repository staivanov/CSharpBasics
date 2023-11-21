using System;

namespace SummerClothes
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();

            string sneakers = "Sneakers",
                moccasins = "Moccasins",
                sandals = "Sandals",
                barefoot = "Barefoot";

            string sweatshirt = "Sweatshirt",
                shirt = "Shirt",
                tShirt = "T-Shirt",
                swimSuit = "Swim Suit";

            bool isBetween10to18 = degree >= 10 && degree <= 18,
                isBetween18to24 = degree > 18 && degree <= 24,
                isAbove24 = degree >= 25;

            switch (partOfDay)
            {
                case "Morning":
                    if (isBetween10to18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {sweatshirt} and {sneakers}.");
                    }
                    else if (isBetween18to24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {sweatshirt} and {moccasins}.");
                    }
                    else if (isAbove24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {tShirt} and {sandals}.");
                    }
                    break;
                case "Afternoon":
                    if (isBetween10to18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {sweatshirt} and {moccasins}.");
                    }
                    else if (isBetween18to24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {tShirt} and {sandals}.");
                    }
                    else if (isAbove24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {swimSuit} and {barefoot}.");
                    }
                    break;
                case "Evening":
                    if (isBetween10to18)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {shirt} and {moccasins}.");
                    }
                    else if (isBetween18to24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {shirt} and {moccasins}.");
                    }
                    else if (isAbove24)
                    {
                        Console.WriteLine($"It's {degree} degrees, get your {shirt} and {moccasins}.");
                    }
                    break;
            }
        }
    }
}
