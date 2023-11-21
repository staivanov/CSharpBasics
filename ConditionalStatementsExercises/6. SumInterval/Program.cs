using System;

namespace _6._SumInterval
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            bool isBiggerNegative = userNumber > -100;
            bool isSmallerPositive = userNumber < 100;
            bool isZero = userNumber != 0 ? true : false;
            
            if(isBiggerNegative && isSmallerPositive && isZero)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
