using System;

class Program
{
    static void Main()
    {
        string passwordGuardada = "Maite";
        string password = Console.ReadLine();

        if (password == passwordGuardada)
        {
            Console.WriteLine("Acceso concedido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}
