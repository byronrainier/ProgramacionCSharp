using System;

namespace ContadorDig
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 1

            int num1, dig = 0;

            Console.WriteLine("Favor indicar el numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1  <= 0)
            {
                Console.WriteLine("El numero debe ser mayor a cero");
                Environment.Exit(0); 
            }
            else if(num1 >= 999)
            {
                Console.WriteLine("El numero no puede sobrepasar el 999");
                Environment.Exit(0);
            }
            else
            {
                do
                {
                    num1 = num1 / 10;
                    dig++;
                } while (num1 > 0);
                Console.WriteLine("El numero indicado cuenta con " + dig + " " + "Digitos");
            }
        }
    }
}
