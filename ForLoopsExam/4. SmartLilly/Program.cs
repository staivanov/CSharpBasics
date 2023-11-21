using System;

namespace SmartLilly
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int lillysBrotherStealCounter = 0,
            initialBDmoney = 10,
            birthdayToyCounter = 0,
                moneyAfterSellingToys = 0,
                totalBDmoney = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    initialBDmoney = 10;
                    initialBDmoney = (i / 2) * initialBDmoney;
                    totalBDmoney = initialBDmoney + totalBDmoney;
                    lillysBrotherStealCounter++;
                }
                else
                {
                    birthdayToyCounter++;
                }
            }

            totalBDmoney = totalBDmoney - lillysBrotherStealCounter;
            moneyAfterSellingToys = toyPrice * birthdayToyCounter;
            totalBDmoney = totalBDmoney + moneyAfterSellingToys;

            bool isMoneyEnough = (totalBDmoney - washingMachinePrice) >= 0 ? true : false;

            if (isMoneyEnough)
            {
                double positiveResult = totalBDmoney - washingMachinePrice;
                Console.WriteLine($"Yes! {positiveResult:F2}");
            }
            else
            {
                double notEnoughMoney = washingMachinePrice - totalBDmoney;
                Console.WriteLine($"No! {notEnoughMoney:F2}");
            }

        }
    }
}
