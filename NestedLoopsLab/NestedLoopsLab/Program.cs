using System;

namespace NestedLoopsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 24;
            int minutes = 60;

            for (int hour = 0; hour < hours; hour++)
            {
                for (int minute = 0; minute < minutes; minute++)
                {
                    Console.WriteLine($"{hour}:{ minute}");
                }
            }
        }
    }
}
