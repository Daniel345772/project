using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarEstado("OPERATIVO", "El sistema funciona con normalidad.", ConsoleColor.Green);
            MostrarEstado("INFORMACIÓN", "Se ha registrado un nuevo acceso al sistema.", ConsoleColor.Cyan);
            MostrarEstado("ADVERTENCIA", "Uso de memoria elevado (85%).", ConsoleColor.Yellow);
            MostrarEstado("ERROR", "Fallo al conectar con la base de datos.", ConsoleColor.White, ConsoleColor.Red);
        }

        static void MostrarEstado(string estado, string mensaje, ConsoleColor colorTexto, ConsoleColor colorFondo = ConsoleColor.Black)
        {
            Console.ForegroundColor = colorTexto;
            Console.BackgroundColor = colorFondo;

            Console.Write($"[{estado}]");

            Console.ResetColor();
            Console.WriteLine($" {mensaje}");
        }
    }
}