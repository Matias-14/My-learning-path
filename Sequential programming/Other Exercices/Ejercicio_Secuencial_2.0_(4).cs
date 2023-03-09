using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Programa que pase de los grados Celsius a grados Farenheit. Para ello, deberás guardar en una variable los grados Celsius, y 
            mostrar por pantalla "El equivalente en Farenheit es..." y el resultado de la fórmua (gradosCelsius*1,8)+32*/

            Console.WriteLine("Introduce el número de grados Celsius");

            double Celsius = double.Parse(Console.ReadLine());

            double Fahrenheit = (Celsius * 1.8) + 32;

            Console.WriteLine($"El equivalente en Farenheit es {Fahrenheit}");


        }
    }
}
