using System;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgeNumber = int.Parse(Console.ReadLine());
            string judgeName;
            double pointsGiven,
                pointsSum = academyPoints,
                nominationPointsMinimum = 1250.5;
            bool isNominated = false;


            while (judgeNumber > 0)
            {
                judgeName = Console.ReadLine();
                pointsGiven = double.Parse(Console.ReadLine());
                pointsGiven = (judgeName.Length * pointsGiven) / 2;
                pointsSum += pointsGiven;

                if (nominationPointsMinimum <= pointsSum)
                {
                    isNominated = true;
                    break;
                }  

                judgeNumber--;
            }
        

            if (isNominated)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {pointsSum}!");
            }
            else
            {
                double pointsDifference = nominationPointsMinimum - pointsSum;
                Console.WriteLine($"Sorry, {actorName} you need {pointsDifference} more!");
            }
        }
    }
}
