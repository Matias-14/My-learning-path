using System;

namespace Pizarra
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 10)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
                num++;
            }


        }
    }
}
