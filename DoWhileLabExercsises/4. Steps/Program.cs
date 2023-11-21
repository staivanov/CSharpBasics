using System;

namespace Steps
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000,
                lastSteps,
                stepsSum = 0,
                stepsAboveGoal = 0,
                stepsBelowGoal = 0;

            string home = "Going home",
                homeCommand = " ";

            while (true)
            {
                homeCommand = Console.ReadLine();
                bool isStepsValid = int.TryParse(homeCommand, out lastSteps);
                stepsSum += lastSteps;

                if (stepsSum > stepsGoal)
                {
                    Console.WriteLine("Goal reached! Good job!");
                    stepsAboveGoal = stepsSum - stepsGoal;
                    Console.WriteLine($"{stepsAboveGoal} steps over the goal!");
                    break;
                }

                if (home == homeCommand)
                {
                    int stepstToHome = int.Parse(Console.ReadLine());
                    stepsSum = stepsSum + stepstToHome;

                    if (stepsSum < stepsGoal)
                    {
                        stepsBelowGoal = stepsGoal - stepsSum;
                        Console.WriteLine($"{stepsBelowGoal} more steps to reach goal.");
                        break;
                    }
                    else if (stepsSum > stepsGoal)
                    {
                        Console.WriteLine("Goal reached! Good job!");
                        stepsAboveGoal = stepsSum - stepsGoal;
                        Console.WriteLine($"{stepsAboveGoal} steps over the goal!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Goal reached. 10k steps.");
                        break;
                    }
                }
            }
        }
    }
}
