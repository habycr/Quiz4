using System;

public static class BubbleSortAlgorithm
{
    public static void BubbleSort(int[][] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j][0] > arr[j + 1][0])
                {
                    int []temp = arr[j];
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
        int[][] datosOriginal = { 
            new int[] {1, 3},
            new int[] {6, 8},
            new int[] {9, 10},
            new int[] {2, 4}
        };

        BubbleSortAlgorithm.BubbleSort(datosOriginal);

        // Imprimir el resultado
        Console.WriteLine("Intervalos ordenados por inicio:");
        for (int i = 0; i < datosOriginal.Length; i++)
        {
            Console.WriteLine("{" + datosOriginal[i][0] + ", " + datosOriginal[i][1] + "}");
        }

    }
}