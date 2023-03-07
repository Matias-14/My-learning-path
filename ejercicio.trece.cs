using System;

namespace ajedrez
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("introduce la casilla");

            int[,] tablero = new int[8, 8]; // Puedes asignar los valores que quieras a cada elemento
            int casilla = int.Parse(Console.ReadLine()); // Puedes cambiar este valor por el que quieras
            int fila = (casilla - 1) / 8; // Restamos uno porque las filas empiezan en cero
            int columna = (casilla - 1) % 8; // Restamos uno porque las columnas empiezan en cero
            Console.WriteLine("La casilla {0} tiene el valor {1} y está en la fila {2} y la columna {3}", casilla, tablero[fila, columna], fila, columna);
        }

   
    }
}
