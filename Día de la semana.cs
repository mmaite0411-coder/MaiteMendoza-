using System;

class Program
{
    static void Main()
    {
        int dia = int.Parse(Console.ReadLine());

        if (dia == 1)
            Console.WriteLine("Lunes");
        else if (dia == 2)
            Console.WriteLine("Martes");
        else if (dia == 3)
            Console.WriteLine("Miercoles");
        else if (dia == 4)
            Console.WriteLine("Jueves");
        else if (dia == 5)
            Console.WriteLine("Viernes");
        else if (dia == 6)
            Console.WriteLine("sabado");
        else if (dia == 7)
            Console.WriteLine("Domingo");
        else
            Console.WriteLine("Número no válido");
    }
}
