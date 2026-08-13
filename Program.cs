using System;

class Program
{
    static void Main()
    {
        DateTime fechaActual = DateTime.Now;
        
        Console.WriteLine("Fecha y hora actual: " + fechaActual.ToString("dd/MM/yyyy HH:mm:ss"));
        Console.WriteLine("Día: " + fechaActual.Day);
        Console.WriteLine("Mes: " + fechaActual.Month);
        Console.WriteLine("Año: " + fechaActual.Year);

        Console.WriteLine("\nIngrese su fecha de nacimiento (dd/mm/yyyy):");
        if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
        {
            int edad = fechaActual.Year - fechaNacimiento.Year;
            
            if (fechaActual.Month < fechaNacimiento.Month || (fechaActual.Month == fechaNacimiento.Month && fechaActual.Day < fechaNacimiento.Day))
            {
                edad--;
            }
            
            Console.WriteLine("Edad calculada: " + edad + " años.");
        }
        else
        {
            Console.WriteLine("Formato de fecha inválido.");
        }
    }
}