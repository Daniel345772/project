using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            bool accesoConcedido = false;

            while (intentos < 3 && !accesoConcedido)
            {
                Console.Write("Ingrese la contraseña: ");
                string clave = Console.ReadLine();

                if (clave == "1234")
                {
                    accesoConcedido = true;
                    Console.WriteLine("Acceso concedido");
                }
                else
                {
                    intentos++;
                    if (intentos < 3)
                    {
                        Console.WriteLine($"Contraseña incorrecta. Intentos restantes: {3 - intentos}");
                    }
                }
            }

            if (!accesoConcedido)
            {
                Console.WriteLine("Acceso bloqueado");
            }
        }
    }
}