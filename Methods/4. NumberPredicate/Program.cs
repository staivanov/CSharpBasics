using System;

namespace NumberPredicate
{
    class Program
    {
        static void Main(string[] args)
        {
            int userDigit = int.Parse(Console.ReadLine());
            int[] myNumbers = new int[] { 8, 3, 10, 8, 5, -1, 4, 2, -8, 33, 25, 17, 9, 8 };
            int digitFrequency = GetNumberFrequencyFromArray(myNumbers, userDigit);
            Console.WriteLine(digitFrequency);
        }

        public static int GetNumberFrequencyFromArray(int[] numbers, int searchedDigit)
        {
            int numberCounter = 0;

            foreach (var number in numbers)
            {
                if (number == searchedDigit)
                    numberCounter++;
            }
            return numberCounter;
        }
    }
}
