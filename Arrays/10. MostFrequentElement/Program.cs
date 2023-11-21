using System;

namespace MostFrequentElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 11, 1, 1, 2, 2, 3, 3, 3, 3, 8, 99, 11, 11, 11, 11, 11, 21, 29, 43, 50 };
            Console.WriteLine(MostFrequentElementInArray(numbers));
        }

        public static int MostFrequentElementInArray(int[] arr)
        {
            Array.Sort(arr);
            int pairCounter = 1,
                mostFrequentElement = 0,
                frequentPairCounter = 0,
                arrLength = arr.Length;

            for (int i = 1; i < arrLength; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    pairCounter++;
                    bool isFrequentElementCounterLess = frequentPairCounter < pairCounter;

                    if (isFrequentElementCounterLess)
                    {
                        mostFrequentElement = arr[i];
                        frequentPairCounter = pairCounter;
                    }
                }
                else
                {
                    pairCounter = 0;
                }
            }

            return mostFrequentElement;
        }
    }
}
