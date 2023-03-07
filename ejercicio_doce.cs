using System;

namespace ejercicio_doce
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Realiza un programa que calcula el espacio de disco real ocupado por un 
            fichero. Hay que tener en cuenta que el espacio de disco se asigna por bloques o 
            unidades de asignación de un tamaño fijo. Por lo tanto, un fichero siempre 
            ocupará un número entero de bloques, aunque el último solo se utilice 
            parcialmente.  El  tamaño  del  fichero  y  de  la  unidad  de  asignación  se 
            introducen por teclado. */

            Console.WriteLine("Introduce el espacio del fichero");

            int espacio_Fichero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el espacio de cada unidad de asignación");

            int espacio_Asignación = int.Parse(Console.ReadLine());

            int fichero = espacio_Fichero / espacio_Asignación;

            Console.WriteLine($"El fichero ocupa {fichero} unidades");
        }

   
    }
}