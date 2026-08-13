using System;

class Program
{
    static void Main()
    {
        string[] nombres = { "Ana", "Carlos", "Leo", "Roberto", "Luz", "Daniel" };

        Console.WriteLine("Operadores con más de 4 caracteres:");
        
        foreach (string nombre in nombres)
        {
            if (nombre.Length > 4)
            {
                Console.WriteLine(nombre);
            }
        }
    }
}