using System;

public static class MergeSortAlgorithm
{
    public static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;
            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
    }

    static void Merge(int[] arr, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;
        while (i <= mid && j <= right)
        {
            if (arr[i] <= arr[j]) temp[k++] = arr[i++];
            else temp[k++] = arr[j++];
        }
        while (i <= mid) temp[k++] = arr[i++];
        while (j <= right) temp[k++] = arr[j++];
        for (i = left, k = 0; i <= right; i++, k++) arr[i] = temp[k];
    }
}

class Program
{
    static void Main()
    {
        //int[] datosOriginal = { 170, 45, 75, 90, 802, 24, 2, 66 };
        int[] datosOriginal = {1,3};

        Console.WriteLine("Original: " + string.Join(", ", datosOriginal));



        // Merge Sort
        int[] copia5 = (int[])datosOriginal.Clone();
        MergeSortAlgorithm.MergeSort(copia5, 0, copia5.Length - 1);
        Console.WriteLine("Merge Sort: " + string.Join(", ", copia5));


    }
}