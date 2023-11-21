using System;

namespace BiggestNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter index number from array of numbers");
            int userIndexNumber = int.Parse(Console.ReadLine());
            int[] numbers = new int[] { 5, 10, -1, 33, 0, 99, 200, 111, 112, 113, -5, 3 };
            Console.WriteLine(IsNumberBiggestFromNeighbours(numbers, userIndexNumber));
        }
        public static bool IsNumberBiggestFromNeighbours(int[] numbers, int indexOfElement)
        {
            int arrayLength = numbers.Length,
                firstElement = 0,
                lastElement = arrayLength - 1;

            bool isBiggest,
                isLastTwoNumbersComparison = indexOfElement == lastElement,
                isFirstTwoNumbersComparison = indexOfElement == firstElement;

            if (isLastTwoNumbersComparison)
            {
                isBiggest = numbers[indexOfElement] > numbers[indexOfElement - 1];
                return isBiggest;
            }
            else if (isFirstTwoNumbersComparison)
            {
                isBiggest = numbers[indexOfElement] > numbers[indexOfElement + 1];
                return isBiggest;
            }
            else
            {
                isBiggest = (numbers[indexOfElement] > numbers[indexOfElement - 1]) &&
                    (numbers[indexOfElement] > numbers[indexOfElement + 1]);
                return isBiggest;
            }
        }

    }
}
