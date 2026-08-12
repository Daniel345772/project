using System;

string usuarioCorrecto = "admin";
string contrasenaCorrecta = "1234";

int intentosRestantes = 3;
bool accesoConcedido = false;

while (intentosRestantes > 0 && !accesoConcedido)
{
    Console.Write("Ingrese usuario: ");
    string usuario = Console.ReadLine();

    Console.Write("Ingrese contraseña: ");
    string contrasena = Console.ReadLine();

    if (usuario == usuarioCorrecto && contrasena == contrasenaCorrecta)
    {
        Console.WriteLine("Acceso concedido al sistema.");
        accesoConcedido = true;
    }
    else
    {
        intentosRestantes--;

        if (intentosRestantes > 0)
        {
            Console.WriteLine($"Credenciales incorrectas. Intentos restantes: {intentosRestantes}");
        }
        else
        {
            Console.WriteLine("SISTEMA BLOQUEADO");
        }
    }
}