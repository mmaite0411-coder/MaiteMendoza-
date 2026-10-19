    double compra;
        Console.WriteLine("Ejercicio 2: Envio gratis");
        Console.WriteLine("Ingresa el monto de la compra:");
        compra = Convert.ToDouble(Console.ReadLine());
        if (compra >= 500)
        {
            Console.WriteLine("Tienes envio gratis");
        }
        Console.WriteLine("Total: " + compra);
