using System;

namespace Promedio1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Problema 2


            int valor, sum = 0, cantidad = 0, prom;

            do
            {
                Console.WriteLine("Dame un valor: ( Si Digitas Cero (0) se acaba el proceso!");
                valor = Convert.ToInt16(Console.ReadLine());
                sum += valor;
                cantidad++;

            } while (valor != 0);
            cantidad--;

            prom = sum / cantidad;

            Console.WriteLine("Cantidad de valores ingresados: " + cantidad + " " + "Para una suma total de: " + sum);
            Console.WriteLine("El promedio total es: " + prom);
        }
    }
}
