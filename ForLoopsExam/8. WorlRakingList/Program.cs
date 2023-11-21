using System;

namespace _8._WorlRakingList
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentsNumber = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            int totalPoints = 0,
                w = 2000,
                f = 1200,
                sf = 720,
                finalPoints = 0,
                tournamentsWon = 0;

            string finishPosition;

            for (int i = 0; i < tournamentsNumber; i++)
            {
                finishPosition = Console.ReadLine();

                if(finishPosition == "W")
                {
                    totalPoints += w;
                    tournamentsWon++;
                }
                else if (finishPosition == "F")
                {
                    totalPoints += f;
                }
                else if(finishPosition == "SF")
                {
                    totalPoints += sf;
                }
            }

            finalPoints = totalPoints + startingPoints;
            Console.WriteLine($"Final points: {finalPoints}");
            double averagePoints = (double)totalPoints / (double)tournamentsNumber;
            Console.WriteLine($"Average points: {averagePoints}");
            double averageFinalsWon = (double)tournamentsWon / (double)tournamentsNumber * 100;
            Console.WriteLine($"{averageFinalsWon:F2}%");
        }
    }
}
