using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu nombre;");

            string nombre = Console.ReadLine();

            Console.WriteLine("Introduce tu edad;");

            string edad = Console.ReadLine();

            Console.WriteLine($"Te llamas {nombre} y tienes {edad} años");
        }
    }
}
