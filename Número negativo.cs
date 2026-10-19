using System;

class Program
{
    static void Main()
    {
        int numero = int.Parse(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("El numero es negativo");
            Console.WriteLine("Valor absoluto: " + Math.Abs(numero));
        }
    }
}
