using System;

public class Program
{
    static public void Main ()
    {
        int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine($"El mayor es: {num1}");
}
else
{
    Console.WriteLine($"El mayor es: {num2}");
}
    }
}
