using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[20];
            int elementPower = 5;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i * elementPower;
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
