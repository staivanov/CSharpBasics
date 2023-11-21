internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
        QuickSort(numbers, 0, 6);
        Display(numbers);
    }

    private static int[] QuickSort(int[] array, int low, int high)
    {
        if (low < high)
        {
            int pi = Partitioner(array, low, high);
            QuickSort(array, low, pi - 1);
            QuickSort(array, pi + 1, high);
        }
        return new int[5];
    }

    private static int Partitioner(int[] array, int low, int high)
    {
        int pivot = array[low],
            i = low + 1,
            j = high;

        do
        {
            while (i <= j && array[i] <= pivot) i++;
            while (i <= j && array[j] >= pivot) j--;

            if (i <= j) Swap(array, i, j);


        } while (i < j);

        Swap(array, low, j);

        return j;
    }

    private static void Swap(int[] array, int i, int j)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }

    private static void Display(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
    }
}