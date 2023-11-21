using System;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int reversedNumber = ReverNumber(userNumber);
            Console.WriteLine(reversedNumber);
        }

        public static int ReverNumber(int number)
        {
            if (number < 10)
                return number;

            string numberToString = number.ToString();
            string stringToNumber = "";
            
            for (int i = numberToString.Length - 1; i >= 0; i--)
            {
                stringToNumber += numberToString[i];
            }

            int numberReversed = int.Parse(stringToNumber);

            return numberReversed;
        }
    }
}
