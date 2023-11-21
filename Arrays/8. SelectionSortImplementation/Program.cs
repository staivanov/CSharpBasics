using System;

namespace SelectionSortImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] numbers = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original nuymbers: ");
            s.DisplayElements(numbers, 6);
            s.SelectionSort(numbers, 6);
            Console.WriteLine();
            s.DisplayElements(numbers, 6);
        }
    }
}
