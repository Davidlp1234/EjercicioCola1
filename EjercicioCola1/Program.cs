using System;

namespace EjercicioCola1
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] NumeroReal = new double[5];

            for (byte i = 0; i <= 4; i++)
            {
                Console.Write("Introduce el numero {0}: ", i + 1);
                NumeroReal[i] = Convert.ToDouble(Console.ReadLine());
            }

            Console.ReadKey();

            

            Console.ReadKey();

        }
    }
}
