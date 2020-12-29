using System;

namespace CalcMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 6

            int valor, Mult3 = 0, Mult5 = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Indicame un numero para sabes si es multiplo: ");
                valor = Convert.ToInt16(Console.ReadLine());
                if (valor % 3 == 0)
                {
                    Mult3++;
                }
                if (valor % 5 == 0)
                {
                    Mult5++;
                }
            }
            Console.WriteLine("Los multiplos de 3 fueron: " + Mult3);
            Console.WriteLine("Los multiplos de 5 fueron: " + Mult5);
        }
    }
}
