using System;

namespace SelectionSortImplementation
{
    public class Sort
    {
       public void SelectionSort(int[] arr, int n)
        {
            for (int i = 0; i < n-1; i++)
            {
                int position = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[i])
                    {
                        position = j;
                    }

                    int temp = arr[i];
                    arr[i] = arr[position];
                    arr[position] = temp;
                }
            }
        }


        public void DisplayElements(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");             
            }
        }
    }
}
