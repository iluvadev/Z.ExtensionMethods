using System;

public static partial class Extensions
{
    /// <summary>
    /// Retorna el modul de l'enter en la base especificada
    /// Per evitar el problema de l'operador % amb nombres negatius
    /// </summary>
    /// <param name="x"></param>
    /// <param name="m"></param>
    /// <returns></returns>
    public static int Mod(this int x, int m)
        => (x % m + m) % m;
}