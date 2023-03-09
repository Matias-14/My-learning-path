using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un programa que pida al usuario introducir un número, y muestre si el número es positivo, negativo o si es cero.*/

            Console.WriteLine("Introduce un número, si es positivo, la pantalla te lo devolverá");

            int num1 = int.Parse(Console.ReadLine());

            if (num1 >= 0)
            {
                Console.WriteLine(num1);
            }


        }
    }
}
