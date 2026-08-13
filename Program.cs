using System;

class Program
{
    static void Main()
    {
        string[] operadores = new string[50];
        int totalOperadores = 0;
        string opcion;

        do
        {
            Console.WriteLine("\n=== CENTRO DE CONTROL ===");
            Console.WriteLine("1. Registrar operador");
            Console.WriteLine("2. Simular acceso");
            Console.WriteLine("3. Generar códigos de seguridad");
            Console.WriteLine("4. Estadísticas del sistema");
            Console.WriteLine("5. Mostrar fecha y hora");
            Console.WriteLine("6. Salir");
            Console.WriteLine("Seleccione una opción:");

            opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el nombre del operador:");
                    string nombre = Console.ReadLine();
                    
                    if (!string.IsNullOrWhiteSpace(nombre) && totalOperadores < operadores.Length)
                    {
                        string nombreLimpio = nombre.Trim();
                        while (nombreLimpio.Contains("  "))
                        {
                            nombreLimpio = nombreLimpio.Replace("  ", " ");
                        }
                        
                        operadores[totalOperadores] = nombreLimpio;
                        totalOperadores++;
                        Console.WriteLine("Operador registrado con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("Nombre inválido o límite de operadores alcanzado.");
                    }
                    break;

                case "2":
                    Console.WriteLine("Ingrese su edad:");
                    if (!int.TryParse(Console.ReadLine(), out int edad) || edad < 0)
                    {
                        Console.WriteLine("Edad inválida.");
                        break;
                    }

                    Console.WriteLine("Ingrese nivel de seguridad (1-5):");
                    if (!int.TryParse(Console.ReadLine(), out int nivel))
                    {
                        Console.WriteLine("Nivel inválido.");
                        break;
                    }

                    Console.WriteLine("¿Credencial activa? (si/no):");
                    string resp = Console.ReadLine().Trim().ToLower();
                    bool activa = (resp == "si" || resp == "sí");

                    if (resp != "si" && resp != "sí" && resp != "no")
                    {
                        Console.WriteLine("Respuesta inválida.");
                        break;
                    }

                    if (edad >= 18 && nivel >= 3 && activa)
                    {
                        Console.WriteLine("ACCESO CONCEDIDO.");
                    }
                    else
                    {
                        Console.WriteLine("ACCESO DENEGADO.");
                    }
                    break;

                case "3":
                    Console.WriteLine("¿Cuántos códigos necesita?");
                    if (int.TryParse(Console.ReadLine(), out int cant) && cant > 0)
                    {
                        Random rnd = new Random();
                        for (int i = 0; i < cant; i++)
                        {
                            Console.WriteLine("Código: " + rnd.Next(100000, 1000000));
                        }
                    }
                    else
                    {
                        Console.WriteLine("Cantidad no válida.");
                    }
                    break;

                case "4":
                    Console.WriteLine("\n--- ESTADÍSTICAS ---");
                    Console.WriteLine("Total de operadores registrados: " + totalOperadores);
                    Console.WriteLine("Operadores con más de 4 caracteres en el nombre:");
                    
                    for (int i = 0; i < totalOperadores; i++)
                    {
                        if (operadores[i].Length > 4)
                        {
                            Console.WriteLine("- " + operadores[i]);
                        }
                    }
                    break;

                case "5":
                    Console.WriteLine("Fecha y hora del sistema: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    break;

                case "6":
                    Console.WriteLine("Cerrando Centro de Control...");
                    break;

                default:
                    Console.WriteLine("OPCIÓN NO VÁLIDA");
                    break;
            }

        } while (opcion != "6");
    }
}