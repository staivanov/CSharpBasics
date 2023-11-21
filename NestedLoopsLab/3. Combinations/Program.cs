using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            //x1+x2+x3 = n
            int userNumber = int.Parse(Console.ReadLine());
            int validNumberCombinationCounter = 0;

            for (int x1 = 0; x1 < userNumber; x1++)
            {
                for (int x2 = 0; x2 < userNumber; x2++)
                {
                    for (int x3 = 0; x3 < userNumber; x3++)
                    {
                        if(x1 + x2 + x3 == userNumber)
                        {
                            validNumberCombinationCounter++;
                        }
                    }
                }
            }
            Console.WriteLine(validNumberCombinationCounter);
        }
    }
}
