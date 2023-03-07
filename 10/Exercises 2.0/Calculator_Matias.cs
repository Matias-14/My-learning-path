using System;

namespace Ejercicio_numeros_Matias
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-------Segundo ejercicio-------");

            string continuar;
            do
            {
                Console.WriteLine("Introduce un número");
                double numero1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Introduce el segundo número");
                double numero2 = double.Parse(Console.ReadLine());

                string operacion;
                bool operacionValida;
                do
                {
                    Console.WriteLine("¿Qué operacion quieres hacer?");
                    operacion = Console.ReadLine();

                    operacionValida = true;
                    switch (operacion)
                    {
                        case "suma":
                            Console.WriteLine(numero1 + numero2);
                            break;
                        case "resta":
                            Console.WriteLine(numero1 - numero2);
                            break;
                        case "multiplicacion":
                            Console.WriteLine(numero1 * numero2);
                            break;
                        case "resto":
                            Console.WriteLine(numero1 % numero2);
                            break;
                        case "division":
                            Console.WriteLine(numero1 / numero2);
                            break;
                        default:
                            Console.WriteLine("Error de escritura, vuelve a introducir la operación. Recuerda, sólo puedes introducir \"suma\", \"resta\", \"multiplicación\", \"división\" o \"resto\".");
                            operacionValida = false;
                            break;
                    }
                } while (!operacionValida);

                Console.WriteLine("¿Quieres continuar? Escribe \"continuar\" para seguir o \"finalizar\" para terminar.");
                continuar = Console.ReadLine();
            } while (continuar == "continuar");

        }
    }
}
