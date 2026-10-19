using System;

public class Program
{
    static public void Main ()
    {
        int numero = int.Parse(Console.ReadLine());

if (numero >= 0)
{
    Console.WriteLine("El numero es positivo o cero");
}
else
{
    Console.WriteLine("El numero es negativo");
}
    }
}
