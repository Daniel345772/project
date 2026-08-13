using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad;
            decimal salario;
            int anioNacimiento;

            Console.Write("Ingrese su edad: ");
            string entradaEdad = Console.ReadLine();
            while (!int.TryParse(entradaEdad, out edad) || edad < 0)
            {
                Console.Write("Edad inválida. Ingrese un número válido: ");
                entradaEdad = Console.ReadLine();
            }

            Console.Write("Ingrese su salario: ");
            string entradaSalario = Console.ReadLine();
            while (!decimal.TryParse(entradaSalario, out salario) || salario < 0)
            {
                Console.Write("Salario inválido. Ingrese un valor numérico válido: ");
                entradaSalario = Console.ReadLine();
            }

            Console.Write("Ingrese su año de nacimiento: ");
            string entradaAnio = Console.ReadLine();
            while (!int.TryParse(entradaAnio, out _) || int.Parse(entradaAnio) < 1900 || int.Parse(entradaAnio) > DateTime.Now.Year)
            {
                Console.Write("Año de nacimiento inválido. Ingrese un año válido: ");
                entradaAnio = Console.ReadLine();
            }

            anioNacimiento = int.Parse(entradaAnio);

            Console.WriteLine("\n--- Datos Registrados ---");
            Console.WriteLine($"Edad: {edad}");
            Console.WriteLine($"Salario: {salario:C}");
            Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
        }
    }
}       