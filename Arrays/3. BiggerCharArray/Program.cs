using System;

namespace EarlyCharArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrOne = { 'a', 'c', 'e', '!' };
            char[] arrTwo = { 'a', 'd', 'e', '!' };
            char[] earlyCharArray = GetEarlyCharArray(arrOne, arrTwo);

            foreach (var charachter in earlyCharArray)
            {
                Console.WriteLine(charachter);
            }
        }

        public static char[] GetEarlyCharArray(char[] arrOne, char[] arrTwo)
        {
            int arrOneLength = arrOne.Length;

            for (int i = 0; i < arrOneLength; i++)
            {
                if (arrOne[i].CompareTo(arrTwo[i]) < 0)
                {
                    return arrOne;
                }
                else if (arrOne[i].CompareTo(arrTwo[i]) > 0)
                {
                    return arrTwo;
                }
            }
            //Arrays are lexicographically equal.
            return arrOne;
        }
    }
}
