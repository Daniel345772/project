using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] codigos = { "COD1", "COD2", "ERROR", "COD3", "EXIT", "COD4" };

            foreach (string codigo in codigos)
            {
                if (codigo == "ERROR")
                {
                    continue;
                }

                if (codigo == "EXIT")
                {
                    break;
                }

                Console.WriteLine($"Código procesado: {codigo}");
            }
        }
    }
}