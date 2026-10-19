using System;

class Program
{
    static void Main()
    {
        double monto = double.Parse(Console.ReadLine());

        if (monto > 1000)
        {
            double total = monto * 0.9;
            Console.WriteLine("Total con descuento: " + total);
        }

        Console.WriteLine("Gracias por su compra");
    }
}
