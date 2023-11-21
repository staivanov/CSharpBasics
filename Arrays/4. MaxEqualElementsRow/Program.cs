using System;

namespace MaxEqualElementsRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 2, 1 };
            int[] biggestRow = GetBiggestElementsRow(numbers);

            foreach (var number in biggestRow)
            {
                Console.WriteLine(number);
            }
        }

        public static int[] GetBiggestElementsRow(int[] numbers)
        {
            int numbersLength = numbers.Length,
                pairCounter = 0,
                bestRowPair = 1,
                number = 1;

            for (int i = 1; i < numbersLength; i++)
            {
                if (numbers[i - 1] == numbers[i])
                {
                    pairCounter++;

                    if (bestRowPair <= pairCounter)
                    {
                        bestRowPair = pairCounter + 1;
                        number = numbers[i];
                    }
                }
                else
                {
                    pairCounter = 0;
                }
            }

            int[] biggestEqualRow = new int[bestRowPair];

            for (int i = 0; i < biggestEqualRow.Length; i++)
            {
                biggestEqualRow[i] = number;
            }

            return biggestEqualRow;
        }

    }
}
