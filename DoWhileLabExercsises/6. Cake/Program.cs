using System;

namespace Cake
{
    class Program
    {


        static void Main(string[] args)
        {
            int cakeWidth = int.Parse(Console.ReadLine());
            int cakeLonght = int.Parse(Console.ReadLine());
            int cakeCurrentSize = cakeWidth * cakeLonght,
                takenPartsCounter = 0;
            string stopCommand = "STOP";

            while (true)
            {
                int partsTake;
                string userInput = Console.ReadLine();
                bool isPartTakeFromCake = int.TryParse(userInput, out partsTake);
                cakeCurrentSize -= partsTake;
                bool isCurrentCakeBelowZero = (cakeCurrentSize - partsTake) < 0;
                takenPartsCounter++;

                if (isCurrentCakeBelowZero)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(cakeCurrentSize)} pieces more.");
                    break;
                }
                else if (stopCommand == userInput && ((cakeCurrentSize - partsTake) > 0))
                {
                    Console.WriteLine($"{cakeCurrentSize} pieces are left.");
                    break;
                }
            }
        }

    }
}

