using System;

namespace InchToCM
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInchesInput = double.Parse(Console.ReadLine());
            double oneInch = 2.54;
            double result = userInchesInput * oneInch;
            Console.WriteLine(result);
        }
    }
}
