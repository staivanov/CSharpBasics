internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
        MergeSort(numbers, 0, 6);
        DisplaySortedArray(numbers);

    }

    public static void MergeSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(array, left, mid);
            MergeSort(array, mid + 1, right);
            Merge(array, left, right, mid);
        }
    }

    private static void Merge(int[] array, int left, int right, int mid)
    {
        int i = left;
        int j = mid + 1;
        int k = left;
        int[] arrayB = new int[right + 1];

        while (i <= mid && j <= right)
        {
            if (array[i] < array[j])
            {
                arrayB[k] = array[i];
                i++;
            }
            else
            {
                arrayB[k] = array[j];
                j++;
            }
            k++;
        }

        while (i <= mid)
        {
            arrayB[k] = array[i];
            i++;
            k++;
        }

        while (j <= right)
        {
            arrayB[k] = array[j];
            j++;
            k++;
        }

        for (int x = left; x < right + 1; x++)
        {
            array[x] = arrayB[x];
        }
    }

    public static void DisplaySortedArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
    }

}