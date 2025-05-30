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
                    int[] temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}

public static class UnirIntervalos
{
    public static int[][] UnirIntervalosTraslapados(int[][] intervalos, out int cantidad)
    {
        int[][] resultado = new int[intervalos.Length][];
        int k = 0;

        for (int i = 0; i < intervalos.Length; i++)
        {
            if (k == 0)
            {
                resultado[k] = new int[] { intervalos[i][0], intervalos[i][1] };
                k++;
            }
            else
            {
                int[] ultimo = resultado[k - 1];

                if (ultimo[1] >= intervalos[i][0])
                {
                    if (intervalos[i][1] > ultimo[1])
                        ultimo[1] = intervalos[i][1];
                }
                else
                {
                    resultado[k] = new int[] { intervalos[i][0], intervalos[i][1] };
                    k++;
                }
            }
        }

        cantidad = k;
        return resultado;
    }
}
