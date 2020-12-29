using System;

namespace Promedio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 4

            int sum = 0, valor = 0, prom = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Indiqueme un valor: ");
                valor = Convert.ToInt16(Console.ReadLine());

                sum = sum + valor;
            }
            prom = sum / 10;

            Console.WriteLine("La sumatoria es: " + sum);
            Console.WriteLine("El promedio es: " + prom);
        }
    }
}
