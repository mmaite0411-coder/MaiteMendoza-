using System;

class Program
{
    static void Main()
    {
        double radio, area, perimetro;

        Console.Write("Ingresa el radio: ");
        radio = double.Parse(Console.ReadLine());

        area = Math.PI * radio * radio;
        perimetro = 2 * Math.PI * radio;

        Console.WriteLine("Area: " + area);
        Console.WriteLine("Perimetro: " + perimetro);
    }
}
