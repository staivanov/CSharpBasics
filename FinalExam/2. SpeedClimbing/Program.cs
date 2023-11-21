using System;

namespace SpeedClimbing
{
    class Program
    {
        static void Main(string[] args)
        {
            int record = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int climbingMeterPerSecond = int.Parse(Console.ReadLine());
            int delayMeters = 50,
                delaySecendsForDistance = 30;

            int delayTime = (distance / delayMeters) / delaySecendsForDistance;
            int finalTime = (distance * climbingMeterPerSecond) + delayMeters;

            bool isRecordRemain = record < finalTime ? true : false;

            if (!isRecordRemain)
            {
                Console.WriteLine($"Yes! The new record is {finalTime} seconds.");
            }
            else
            {
                int lackingTime = finalTime - record;
                Console.WriteLine($"No! He was {lackingTime} seconds slower.");
            }  
        }
    }
}
