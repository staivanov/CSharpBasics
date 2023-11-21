using System;

namespace MaxGrowingRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 2, 3, 4, 5, 2, 2, 4 };
            int[] result = GetMaxGrowingRow(numbers);

            foreach (var number in result)
            {
                Console.Write($"{number} ");
            }
        }

        public static int[] GetMaxGrowingRow(int[] numbers)
        {
            int pairCounter = 0,
                maxCounter = 0,
                bestStartIndex = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isNextNumberBigger = numbers[i] < numbers[i + 1];

                if (isNextNumberBigger)
                {
                    pairCounter++;
                }
                else
                {
                    if(pairCounter > maxCounter)
                    {
                        maxCounter = pairCounter;
                        bestStartIndex = i - pairCounter ;
                    }
                    pairCounter = 0;
                }    
            }

            int[] bestRowNumbers = new int[maxCounter + 1];

            for (int j = 0; j < bestRowNumbers.Length; j++)
            {
                bestRowNumbers[j] = numbers[bestStartIndex + j];
            }

            return bestRowNumbers;
        }
    }
}
