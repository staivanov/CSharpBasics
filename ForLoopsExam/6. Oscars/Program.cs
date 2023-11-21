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

            string judgeName = "";
            double judgePoints = 0,
                nominationPoints = 1250.5,
                actorPoints = 0,
                totalPoints = 0;

            for (int i = 0; i < judgeNumber; i++)
            {
                judgeName = Console.ReadLine();
                judgePoints = double.Parse(Console.ReadLine());

                actorPoints = (judgeName.Length * judgePoints) / 2;
                totalPoints += actorPoints;
            }

            totalPoints = totalPoints + academyPoints;

            if (nominationPoints < totalPoints)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {actorName} you need {nominationPoints - totalPoints} more!");
            }
 
        }
    }
}
