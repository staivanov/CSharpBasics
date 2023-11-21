using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0,
                moneyIncome = 0;
            string enoughMoneyCommand = "NoMoreMoney";
            string money;

            while (true)
            {
                money = Console.ReadLine();
                bool isMoneyValid = double.TryParse(money, out moneyIncome);
             
                if (moneyIncome < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {sum}");
                    break;
                }
                else if (money == enoughMoneyCommand)
                {
                    Console.WriteLine($"Total: {sum}");
                    break;
                }
                sum += moneyIncome;
                Console.WriteLine($"Increase: {moneyIncome}");
            }

        }
    }
}
