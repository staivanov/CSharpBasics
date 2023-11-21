using System;

namespace ArraySymmetryCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrOneSize = int.Parse(Console.ReadLine());
            int arrTwoSize = int.Parse(Console.ReadLine());

            int[] arrayOne = new int[arrOneSize];
            int[] arrayTwo = new int[arrTwoSize];
            bool areArraysEqual = AreArrayLengthEqual(arrayOne, arrayTwo);

            if (areArraysEqual)
            {            
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    Console.WriteLine($"Enter value for array one at index {i}");
                    arrayOne[i] = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Enter value for array two at index {i}");
                    arrayTwo[i] = int.Parse(Console.ReadLine());

                    bool isValueSame = arrayOne[i] != arrayTwo[i];

                    if (isValueSame)
                    {
                        areArraysEqual = false;
                        break;
                    }            
                }
            }

            Console.WriteLine($"Are arrays equal? {areArraysEqual}");
        }

        public static bool AreArrayLengthEqual(int[] arrayOne, int[] arrayTwo)
        {
            bool areArraysEqualSize = arrayOne.Length == arrayTwo.Length;
            return areArraysEqualSize;
        }
    }
}
