using System;

namespace Traveling
{
    class Program
    {
        static void Main(string[] args)
        {
            int excursionPrice = 0;
            string destination = " ";
            string stopCommand = "End";

            while (stopCommand != destination)
            {
                destination = Console.ReadLine();
                excursionPrice = int.Parse(Console.ReadLine());

                while (excursionPrice > 0)
                {
                    int currentIncome = int.Parse(Console.ReadLine());
                    excursionPrice -= currentIncome;            
                }

                if (excursionPrice < 0)
                {
                    Console.WriteLine($"Going to {destination}");
                }
            }
        }
    }
}
