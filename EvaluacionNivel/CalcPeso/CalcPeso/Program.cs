using System;

namespace CalcPeso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 3


            int grupo1 = 0, grupo2 = 0, grupo3 = 0, cantidadPiezas = 0;
            double pesoPieza;
            bool confirmacion = false;
            int val;

            do
            {
                Console.WriteLine("Indicame el peso de la pieza: ");
                pesoPieza = Convert.ToDouble(Console.ReadLine());
                cantidadPiezas++;


                Console.WriteLine(" ");

                Console.WriteLine("Seleccione una opcion\n" +
                    "\n 1)Añadir otra pieza" +
                    "\n 2)Ver resultado" +
                    "\n 3)Terminar programa");

                Console.WriteLine(" ");

                val = Convert.ToInt16(Console.ReadLine());

                switch (val)
                {
                    case 1:
                        confirmacion = false;
                        Console.Clear();
                        break;
                    case 2:
                        confirmacion = true;
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Dato invalido");
                        Environment.Exit(0);
                        break;
                }
            } while (confirmacion != true);

            if (pesoPieza >= 10.2)
            {
                grupo1++;
            }
            else if (pesoPieza <= 9.8)
            {
                grupo2++;
            }
            else if (pesoPieza >= 10.2 && pesoPieza <= 9.8)
            {
                grupo3++; 
            }

            Console.Clear();

            Console.WriteLine("La cantidad de piezas procesadas es: " + cantidadPiezas);
            Console.WriteLine(" ");

            Console.WriteLine("Las cantidad de piezas con peso mayor a 10.2Kg son:  " + grupo1);
            Console.WriteLine("Las cantidad de piezas con peso menor a 9.8Kg son:  " + grupo2);
            Console.WriteLine("Las cantidad de piezas con peso entre 10.2Kg y 9.8Kg son:  " + grupo3);

            Console.ReadKey();
        }
    }
}
