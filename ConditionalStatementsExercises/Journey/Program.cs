using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string summer = "summer",
                winter = "winter",
                bulgaria = "Bulgaria",
                balkans = "Balkans",
                europe = "Europe",
                camp = "Camp",
                hotel = "Hotel";


            double budgetMax100lv = 100,
                budgetMax1000lv = 1000,
                budgetAbove1000lv = 1000,
                amountSpent = 0,
                discount = 0;


            if (budget <= budgetMax100lv)
            {
                if (season == summer)
                {
                    discount = 0.3;
                    amountSpent = budget * discount;
                    Console.WriteLine($"Somewhere in {bulgaria}.");
                    Console.WriteLine($"{camp} - {amountSpent:F2}");
                }
                else if (season == winter)
                {
                    discount = 0.7;
                    amountSpent = budget * discount;
                    Console.WriteLine($"Somewhere in {bulgaria}.");
                    Console.WriteLine($"{hotel} - {amountSpent:F2}");
                }
            }
            else if (budget > budgetMax100lv && budget < budgetMax1000lv)
            {
                if (season == summer)
                {
                    discount = 0.4;
                    amountSpent = budget * discount;
                    Console.WriteLine($"Somewhere in {balkans}.");
                    Console.WriteLine($"{camp} - {amountSpent:F2}");
                }
                else if (season == winter)
                {
                    discount = 0.8;
                    amountSpent = budget * discount;
                    Console.WriteLine($"Somewhere in {balkans}.");
                    Console.WriteLine($"{hotel} - {amountSpent:F2}");
                }
            }
            else if (budget > budgetAbove1000lv)
            {
                amountSpent = budget * 0.9;
                Console.WriteLine($"Somewhere in {europe}.");
                Console.WriteLine($"{hotel} - {amountSpent:F2}");
            }
        }
    }
}
