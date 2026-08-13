using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese su nombre completo:");
        string nombreEntrada = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(nombreEntrada))
        {
            Console.WriteLine("Entrada inválida.");
            return;
        }

        string nombreLimpio = nombreEntrada.Trim();

        while (nombreLimpio.Contains("  "))
        {
            nombreLimpio = nombreLimpio.Replace("  ", " ");
        }

        Console.WriteLine("Nombre limpio: " + nombreLimpio);
        Console.WriteLine("Cantidad de caracteres: " + nombreLimpio.Length);
        Console.WriteLine("Mayúsculas: " + nombreLimpio.ToUpper());
        Console.WriteLine("Minúsculas: " + nombreLimpio.ToLower());
    }
}