public class Program
{
    private static void Main(string[] args)
    {
        //int userNumber = int.Parse(Console.ReadLine());
        int n = 13;
        int[] numbers = { 4, 3, 1, 4, 2, 5, 8 };
        int[] rowNumbers = GetUserNumberRowSum(numbers, n);

        Console.WriteLine($"User number is {n}");

        foreach (var number in rowNumbers)
        {
            Console.Write($"{number} ");
        }
    }

    public static int[] GetUserNumberRowSum(int[] numbers, int searchedNumber)
    {
        int arrLength = numbers.Length;
        int numberSum = 0,
                    startSumIndex = 0,
                    endSumIndex = 1;
        int[] notFoundRow = { -1 };


        for (int i = 0; i < arrLength - 1; i++)
        {
            numberSum = numbers[i];

            for (int j = i + 1; j < arrLength; j++)
            {
                numberSum = numbers[j] + numberSum;

                if (numberSum == searchedNumber)
                {
                    startSumIndex = i;
                    endSumIndex = j;
                    break;
                }
                else if (numberSum > searchedNumber)
                {
                    numberSum = 0;
                    break;
                }
            }           
        }

        int[] numbersRow = new int[endSumIndex - startSumIndex + 1];

        for (int k = 0; k < numbersRow.Length; k++)
        {
            numbersRow[k] = numbers[startSumIndex + k];
        }

        return numbersRow;
    }
}