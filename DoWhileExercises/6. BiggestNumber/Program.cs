using System;

namespace BiggestNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            string commandStop = "Stop",
                 userCommand;

            int userNumber,
                biggestCurrentNumber = int.MinValue;

            while (true)
            {
                userCommand = Console.ReadLine();
                bool isValidNumber = int.TryParse(userCommand, out userNumber);

                if (userCommand == commandStop)
                {
                    Console.WriteLine(biggestCurrentNumber);
                    break;
                }

                else if (userNumber > biggestCurrentNumber)
                {
                    biggestCurrentNumber = userNumber;
                }             
            }
        }
    }
}
