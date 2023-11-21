using System;

namespace BiggestNumberFromNeightbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 55, 6, 7, 0 };
            GetBiggestNumberBetweenNeighbour(numbers);
        }

        public static void GetBiggestNumberBetweenNeighbour(int[] numbers)
        {
            int numbersLength = numbers.Length;
            int firsBiggestNumberIndex = 1;
            bool isBiggerFromNeighbours = false;

            while (firsBiggestNumberIndex < numbersLength - 1)
            {
                if (numbers[firsBiggestNumberIndex - 1] < numbers[firsBiggestNumberIndex]
                    && numbers[firsBiggestNumberIndex] > numbers[firsBiggestNumberIndex + 1])
                {
                    isBiggerFromNeighbours = true;
                    break;
                }

                firsBiggestNumberIndex++;
            }


            if (isBiggerFromNeighbours)
            {
                Console.WriteLine($"Number at index {firsBiggestNumberIndex} is biggest between his two neighbours.");
            }
            else
            {
                Console.WriteLine(-1);
            }
        }
    }
}
