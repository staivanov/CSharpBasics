using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            double depositPeriodMonth = double.Parse(Console.ReadLine());
            double depositInterestRatePerYear = double.Parse(Console.ReadLine());
            double maturitySum = 0;
            double interestRateSum = depositSum * (depositInterestRatePerYear / 100);
            double oneMonthInterestRateSum = interestRateSum / 12;
            maturitySum = depositSum + oneMonthInterestRateSum * depositPeriodMonth;
            Console.WriteLine(maturitySum);
        }
    }
}
