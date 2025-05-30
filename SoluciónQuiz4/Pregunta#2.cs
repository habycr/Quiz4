using System;

public static class RevisarSonAnagramas
{
    public static bool SonAnagramas(string palabra1, string palabra2)
    {
        // No se consideran anagramas si son idénticas
        if (palabra1 == palabra2)
            return false;

        if (palabra1.Length != palabra2.Length)
            return false;

        return AuxiliarRevisarSonAnagramas.SonAnagramasRecursivo(palabra1, palabra2);
    }
}

public static class AuxiliarRevisarSonAnagramas
{
    public static bool SonAnagramasRecursivo(string p1, string p2)
    {
        if (p1.Length == 0 && p2.Length == 0)
            return true;

        char letra = p1[0];
        int pos = BuscarCaracter(p2, letra);

        if (pos == -1)
            return false;

        string nuevaP1 = EliminarCaracter(p1, 0);
        string nuevaP2 = EliminarCaracter(p2, pos);

        return SonAnagramasRecursivo(nuevaP1, nuevaP2);
    }

    public static int BuscarCaracter(string palabra, char objetivo)
    {
        for (int i = 0; i < palabra.Length; i++)
        {
            if (palabra[i] == objetivo)
                return i;
        }
        return -1;
    }

    public static string EliminarCaracter(string palabra, int indice)
    {
        string nueva = "";
        for (int i = 0; i < palabra.Length; i++)
        {
            if (i != indice)
                nueva += palabra[i];
        }
        return nueva;
    }
}