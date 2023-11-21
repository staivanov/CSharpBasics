using System;

namespace _6._Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylonPrice = 1.5,
                paintPerLiterPrice = 14.5,
                thinnerPerLiterPrice = 5.00,
                addedNylonPerSquareMeter = 2,
                addedPaintPercent = 0.1,
                bagPrice = 0.4,
                salaryPerHourPercent = 0.3;

            double nylonPerSqMeter = double.Parse(Console.ReadLine());
            double paintLiter = double.Parse(Console.ReadLine());
            double thinnerLiter = double.Parse(Console.ReadLine());
            double workHours = double.Parse(Console.ReadLine());

            double finalNylonPrice = (nylonPerSqMeter * nylonPrice) + (addedNylonPerSquareMeter * nylonPrice),
                finalPaintPrice = (paintLiter + (paintLiter * addedPaintPercent)) * paintPerLiterPrice,
                finalThinnerPrice = thinnerLiter * thinnerPerLiterPrice,
                finalResourcePrice = finalNylonPrice + finalPaintPrice + finalThinnerPrice + bagPrice,
                salaryPerHour = finalResourcePrice * salaryPerHourPercent,
                workersSalary = salaryPerHour * workHours,
                paintingPrice = finalResourcePrice + workersSalary;

            Console.WriteLine(finalResourcePrice + workersSalary);
                

        }
    }
}
