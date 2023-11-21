using System;

namespace BiggerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int biggestBetweenTwo = GetMax(numberOne, numberTwo);

            if (biggestBetweenTwo <= numberThree)
            {
                Console.WriteLine(numberThree);
            }
            else
            {
                Console.WriteLine(biggestBetweenTwo);
            }
        }

        public static int GetMax(int numberOne, int numberTwo)
        {
            int biggerNumber = numberOne > numberTwo ? numberOne : numberTwo;
            return biggerNumber;
        }
    }
}
