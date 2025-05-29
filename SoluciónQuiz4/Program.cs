using System;
using System.Collections.Generic;

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



public static class Solapador
{
    public static List<int[]> Solapador(int[][] IntervalosOrdenados)
    {
        if (IntervalosOrdenados == null || IntervalosOrdenados.Length == 0)
            return new List<int[]>();

        // Convertir array a lista
        List<int[]> listaOrdenada = new List<int[]>(IntervalosOrdenados);
        List<int[]> lista2 = new List<int[]>();

        // Inicializar lista2 con el primer elemento de listaOrdenada y eliminarlo
        lista2.Add(listaOrdenada[0]);
        listaOrdenada.RemoveAt(0);

        while (listaOrdenada.Count > 0)
        {
            int[] UltimoEnLista2 = lista2[lista2.Count - 1]; // [a, b]
            int[] PrimeroListaOrdenada = listaOrdenada[0];    // [c, d]

            //  Verificar solapamiento (a <= d and c <= b)
            if (UltimoEnLista2[0] <= PrimeroListaOrdenada[1] &&
                PrimeroListaOrdenada[0] <= UltimoEnLista2[1])
            {
                // Fusionar: [a, max(b, d)]
                int[] merged = new int[]
                {
                    UltimoEnLista2[0],
                    Math.Max(UltimoEnLista2[1], PrimeroListaOrdenada[1])
                };

                // Eliminar [a, b] de lista2 y [c, d] de listaOrdenada
                lista2.RemoveAt(lista2.Count - 1);
                listaOrdenada.RemoveAt(0);

                // Agregar el intervalo fusionado a lista2
                lista2.Add(merged);
            }
            else
            {
                // No hay solapamiento, mover [c, d] a lista2
                lista2.Add(PrimeroListaOrdenada);
                listaOrdenada.RemoveAt(0);
            }
        }

        return lista2;
    }
}

class Program
{
    static void Main()
    {
        // Ordenar los intervalos con BubbleSort
        int[][] datosOriginal = {
            new int[] {6,8},
            new int[] {1,9},
            new int[] {2,4}
        };

        BubbleSortAlgorithm.BubbleSort(datosOriginal);

        Console.WriteLine("Intervalos ordenados por inicio:");
        foreach (var interval in datosOriginal)
        {
            Console.Write($"[{interval[0]}, {interval[1]}] ");
        }

        // Fusionar los intervalos
        List<int[]> mergedIntervals = Solapador.Solapador(datosOriginal);

        Console.WriteLine("\n\nIntervalos fusionados:");
        foreach (var interval in mergedIntervals)
        {
            Console.Write($"[{interval[0]}, {interval[1]}] ");
        }
    }
}