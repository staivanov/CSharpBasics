using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double oneUSD = 1.79549;
            double result = double.Parse(Console.ReadLine()) * oneUSD;
            Console.WriteLine(result);
        }
    }
}
