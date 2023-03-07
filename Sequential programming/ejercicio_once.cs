using System;

namespace ejercicio_once
{
    class Program
    {
        
        static void Main(string[] args)
        {
            /* Realiza  un  programa  que  muestra  los  resultados  de  una  encuesta  en 
            porcentajes. En la encuesta se puede contestar SI, NO o NO SABE-NO 
            CONTESTA.  Por  teclado  únicamente  se  introducirá  el  número  de 
            respuestas de cada categoría. */

            Console.WriteLine("Introduce el número de veces que han indicado SI");
            int si = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de veces que han indicado NO");
            int no = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el número de veces que han indicado NO SABE/ NO CONTESTA");
            int nsnc = int.Parse(Console.ReadLine());

            int participacion = si + no + nsnc;

            decimal resultado_Si = ((decimal)si / participacion) * 100;
            decimal resultado_No = ((decimal)no /participacion) * 100;
            decimal resultado_Nsnc = ((decimal)nsnc / participacion) * 100;

            Console.WriteLine($"Resultado SI: {resultado_Si}%");
            Console.WriteLine($"Resultado No: {resultado_No}%");
            Console.WriteLine($"Resultado NS/NC: {resultado_Nsnc}%");
        }

   
    }
}
