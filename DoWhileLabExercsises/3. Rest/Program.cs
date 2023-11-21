using System;

namespace Rest
{
    class Program
    {
        static void Main(string[] args)
        {
            int excursionMoney = int.Parse(Console.ReadLine());
  
            string spend = "spend",
                save = "save",
                userCommand;

            int currentMoneySum = 0,
                daysCounter = 0,
                spendDaysCounter = 0;

            while (true)
            {

                int currentMoney = 0;
                userCommand = Console.ReadLine();
                bool isValidUserCommand = int.TryParse(userCommand, out currentMoney);

                if (isValidUserCommand)
                {
                    currentMoneySum += currentMoney;
                }

                if (userCommand == save)
                {
                    currentMoney = int.Parse(Console.ReadLine());
                    currentMoneySum = currentMoneySum + currentMoney;
                    spendDaysCounter = 0;
                    daysCounter++;

                    bool isExcursionMoneyEnough = excursionMoney <= currentMoneySum ? true : false;


                    if (isExcursionMoneyEnough)
                    {
                        Console.WriteLine($"You saved the money for {daysCounter} days.");
                        break;
                    }
                }
                else if (userCommand == spend)
                {
                    currentMoney = int.Parse(Console.ReadLine());
                    currentMoneySum = currentMoneySum - currentMoney;
                    spendDaysCounter++;
                    daysCounter++;

                    bool isCurrentMoneySumZero = currentMoneySum < 0 ? true : false;

                    if (isCurrentMoneySumZero)
                    {
                        currentMoneySum = 0;

                    }

                    if (spendDaysCounter == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{daysCounter}");
                        break;
                    }

                }
            }
        }
    }
}
