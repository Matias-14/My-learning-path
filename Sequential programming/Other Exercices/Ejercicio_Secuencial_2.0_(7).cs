using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Un programa que pida al usuario introducir dos números y los multiplique, mostrando el resultado por pantalla. Recuerda que lo que se 
            lee por teclado es texto, así que tendrás que convertir a número entero la lectura de teclado (con la instrucción int.Parse, hay ejemplos 
            de su uso en las presentaciones*/

            Console.WriteLine("Introduce un número");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce otro número");

            int num2 = int.Parse(Console.ReadLine());

            int multiplicacion = num1 * num2;

            Console.WriteLine($"El resultado es {multiplicacion}");
        }
    }
}
