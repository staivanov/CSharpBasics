using System;

namespace FindBiggetstElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 444, 55, 6, 7, 990 };

            int biggestNumber = GetBiggestNumberInArray(numbers);
            Console.WriteLine(biggestNumber);


        }

        public static int GetBiggestNumberInArray(int[] numbers)
        {
            int numbersLength = numbers.Length,
                biggestNumber = 0;

            for (int i = 0; i < numbersLength - 1; i++)
            {
                if (numbers[i] <= numbers[i + 1])
                {
                    biggestNumber = biggestNumber > numbers[i + 1]
                        ? biggestNumber : numbers[i + 1];
                }
            }

            return biggestNumber;
        }
    }
}
