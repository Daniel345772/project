using System;

class Program
{
    static void Main(string[]args)
    {
        string opcion;
        do
        {
            Console.WriteLine("1. Consultar estado");
            Console.WriteLine("2. Mostrar temperatura");
            Console.WriteLine("3. Mostrar operadores");
            Console.WriteLine("4. Reiniciar sistema");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opcion:");

            opcion = Console.ReadLine()!;

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Consultando el estado del sistema");
                    break;
                case "2":
                    Console.WriteLine("Temperatura actual: Estable");
                    break;
                case "3":
                    Console.WriteLine("Mostrando lista de operadores");
                    break;
                case "4":
                    Console.WriteLine("Reiniciando el sistema");
                    break;
                case "5":
                    Console.WriteLine("Saliendo del sistema de forma segura.");
                    break;
                default:
                    Console.WriteLine("OPCION NO VALIDA");
                    break;
            }
        } while (opcion != "5");
    }
}