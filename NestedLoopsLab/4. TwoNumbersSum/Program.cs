using System;

namespace TwoNumbersSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int lastNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationNumberCounter = 0;

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                for (int x = firstNumber; x <= lastNumber; x++)
                {
                    int currentCombinationSum = x + i;
                    combinationNumberCounter++;

                    if(currentCombinationSum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{combinationNumberCounter} ({i} + {x} = {magicNumber})");
                    }
                }
            }    
        }
    }
}
