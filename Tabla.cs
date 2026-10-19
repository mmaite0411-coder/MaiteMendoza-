using System; '

public class Program
{
    static public void Main ()
    {
        // OR de la TABLA VERDE - es V1 OR V2
Console.WriteLine("-- OR Tabla 1-- V1 OR V2");
Console.WriteLine("V1 V2 | OR");
Console.WriteLine($"0  0  | {Convert.ToInt32(false | false)}"); // 0
Console.WriteLine($"1  0  | {Convert.ToInt32(true | false)}");  // 1
Console.WriteLine($"0  1  | {Convert.ToInt32(false | true)}");  // 1
Console.WriteLine($"1  1  | {Convert.ToInt32(true | true)}");   // 1

// OR de la TABLA ROJA - es (V1 AND V2) OR NOT V1
Console.WriteLine("\n-- OR Tabla 2- (AND) OR (Not)");
Console.WriteLine("V1 V2 | AND | Not | OR FINAL");
Console.WriteLine($"0  0  |  0  |  1  | {Convert.ToInt32((false & false) | !false)}"); // 1
Console.WriteLine($"1  0  |  0  |  0  | {Convert.ToInt32((true & false) | !true)}");  // 0
Console.WriteLine($"0  1  |  0  |  1  | {Convert.ToInt32((false & true) | !false)}");  // 1
Console.WriteLine($"1  1  |  1  |  0  | {Convert.ToInt32((true & true) | !true)}");   // 1
    }
}
