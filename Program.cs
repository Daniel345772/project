using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            Console.Write("Ingrese el primer número: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }

            Console.Write("Ingrese el segundo número: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Entrada inválida. Ingrese un número válido: ");
            }

            double potencia = Math.Pow(num1, num2);
            double raizNum1 = Math.Sqrt(Math.Abs(num1));
            double raizNum2 = Math.Sqrt(Math.Abs(num2));
            double absolutoNum1 = Math.Abs(num1);
            double absolutoNum2 = Math.Abs(num2);
            double redondeoNum1 = Math.Round(num1, 2);
            double redondeoNum2 = Math.Round(num2, 2);
            double mayor = Math.Max(num1, num2);
            double menor = Math.Min(num1, num2);

            Console.WriteLine("\n--- Resultados Matemáticos ---");
            Console.WriteLine($"Potencia ({num1} ^ {num2}): {potencia}");
            Console.WriteLine($"Raíz cuadrada de |{num1}|: {raizNum1}");
            Console.WriteLine($"Raíz cuadrada de |{num2}|: {raizNum2}");
            Console.WriteLine($"Valor absoluto de {num1}: {absolutoNum1}");
            Console.WriteLine($"Valor absoluto de {num2}: {absolutoNum2}");
            Console.WriteLine($"Redondeo a 2 decimales ({num1}): {redondeoNum1}");
            Console.WriteLine($"Redondeo a 2 decimales ({num2}): {redondeoNum2}");
            Console.WriteLine($"Número mayor: {mayor}");
            Console.WriteLine($"Número menor: {menor}");
        }
    }
}