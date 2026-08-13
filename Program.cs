using System;

class Program
{
    static void Main()
    {
        Random random = new Random();

        Console.WriteLine("¿Cuántos códigos de seguridad desea generar?");
        if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
        {
            Console.WriteLine("Cantidad inválida.");
            return;
        }

        Console.WriteLine("\nCódigos generados:");
        for (int i = 0; i < cantidad; i++)
        {
            int codigo = random.Next(100000, 1000000);
            Console.WriteLine(codigo);
        }
    }
}