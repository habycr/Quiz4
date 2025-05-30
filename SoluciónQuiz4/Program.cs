using System;

class Program
{
    static void Main()
    {
        int[][] datosOriginal = {
            new int[] {6, 8},
            new int[] {1, 9},
            new int[] {2, 4}
        };

        // Paso 1: Ordenar
        BubbleSortAlgorithm.BubbleSort(datosOriginal);

        // Paso 2: Unir traslapados
        int[][] unidos = UnirIntervalos.UnirIntervalosTraslapados(datosOriginal, out int cantidad);

        // Paso 3: Imprimir
        Console.WriteLine("Intervalos unidos:");
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("{" + unidos[i][0] + "," + unidos[i][1] + "}");
        }


        // Para probar lo de anagramas
        Console.WriteLine("Saber si son anagramas:");
        string a = "roma";
        string b = "amor";

        bool resultado = RevisarSonAnagramas.SonAnagramas(a, b);
        Console.WriteLine(resultado ? "Sí son anagramas" : "No son anagramas");
    }
}

