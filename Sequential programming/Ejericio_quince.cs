using System;

namespace ejercicio_quince
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el capital prestado");
            double capital = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el interés");
            double interes = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de años");
            double años = double.Parse(Console.ReadLine());

            double mensualidad_Calculo = años * 12;
            double media_De_Capital = capital / mensualidad_Calculo;
            double semisuma = (mensualidad_Calculo + capital) / 2;
            double interes_anual = (semisuma / 100) * interes * años;
            double capital_a_Devolver = semisuma + interes_anual;
            double cuota_mensual = capital_a_Devolver / mensualidad_Calculo;
            Console.WriteLine("El total a pagar es ");


        }


    }
}