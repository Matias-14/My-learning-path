using System;

namespace Pizarra
{
    class Program
    {
        static void Main(string[] args)
        {
            double i = 1;
            double suma = 0;

            while (i < 5) 
            {
                if (i % 2 == 0) 
                {
                    suma = suma + i;
              
                }
               i = i + 1;
            } 

            
            Console.WriteLine($"la suma es {suma}");

        }   
    }
}