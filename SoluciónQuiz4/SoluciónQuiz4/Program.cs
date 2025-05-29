using System;

public static class BubbleSortAlgorithm
{
    public static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

class Program
{
    static void Main()
    {
        int[] datosOriginal = { 170, 45, 75, 90, 802, 24, 2, 66 };

        Console.WriteLine("Original: " + string.Join(", ", datosOriginal));

        // Bubble Sort
        int[] copia1 = (int[])datosOriginal.Clone();
        BubbleSortAlgorithm.BubbleSort(copia1);
        Console.WriteLine("Bubble Sort: " + string.Join(", ", copia1));
    }
}