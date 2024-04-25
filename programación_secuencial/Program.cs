using System;

namespace programación_secuencial
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Clear();

            int num1,num2;
            int Suma, Producto;

            Console.WriteLine("Ingresa un numero");
            Console.Write("-->");
            num1 = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Ingresa un numero");
            Console.Write("-->");
            num2 = int.Parse(Console.ReadLine()!);

            Suma = num1 + num2;
            Producto = num1 * num2;

            Console.WriteLine("");
            Console.WriteLine($"La Suma de {num1} y {num2} es: {Suma}");
            Console.WriteLine($"El Producto de {num1} y {num2} es: {Producto}");
        }
    }
}