using System;

class Program {
    static void Main() {
        int saldo = int.Parse(Console.ReadLine());
        int compra = int.Parse(Console.ReadLine());

        if (saldo >= compra) {
            Console.WriteLine("Compra realizada");
            Console.WriteLine($"Saldo restante: {saldo - compra}");
        } else {
            Console.WriteLine("Saldo insuficiente");
        }
    }
