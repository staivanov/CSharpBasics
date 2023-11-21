using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = 1;
            int lastNumber = 10;

            for (int i = startNumber; i <= lastNumber; i++)
            {
                for (int y = startNumber; y <= lastNumber; y++)
                {
                    Console.WriteLine("{0} x {1} = {2}", i, y, i * y);
                }
            }
        }
    }
}
