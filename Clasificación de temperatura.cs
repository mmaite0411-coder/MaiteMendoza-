using System;

class Program
{
    static void Main()
    {
        int temp = int.Parse(Console.ReadLine());

        if (temp < 0)
            Console.WriteLine("Congelante");
        else if (temp <= 14)
            Console.WriteLine("Frio");
        else if (temp <= 24)
            Console.WriteLine("Templado");
        else if (temp <= 34)
            Console.WriteLine("Caluroso");
        else
            Console.WriteLine("Muy caluroso");
    }
}
