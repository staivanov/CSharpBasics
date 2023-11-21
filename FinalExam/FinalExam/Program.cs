using System;

namespace FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallRent = 0;
            string userInputRent = Console.ReadLine();
            bool isValidHallRent = int.TryParse(userInputRent, out hallRent);

            double statues = hallRent - (hallRent * 0.3);
            double catering = statues - (statues * 0.15);
            double surround = catering / 2.0;
            double expenses = statues + catering + surround + hallRent;
            Console.WriteLine(expenses);
        }
    }
}
