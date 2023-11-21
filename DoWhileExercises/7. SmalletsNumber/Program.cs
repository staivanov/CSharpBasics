using System;

namespace SmalletsNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallestCurrentValue = int.MaxValue,
                currentNumber = 0;

            string stopCommand = "Stop",
                userInput;

            while (true)
            {
                userInput = Console.ReadLine();
                bool isValidNumber = int.TryParse(userInput, out currentNumber);

                if (userInput == stopCommand)
                {
                    Console.WriteLine(smallestCurrentValue);
                    break;
                }
                else if (currentNumber < smallestCurrentValue)
                {
                    smallestCurrentValue = currentNumber;
                }
            }
        }
    }
}
