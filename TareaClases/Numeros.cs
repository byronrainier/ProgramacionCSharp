using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    public class Numeros : OperacionesAritmeticas
    {
        public int Num3 { get; set; }

        public void ValidacionMayorMenor()
        {
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine("El numero mayor es: " +Num1);
            }
            else
            {
                Console.WriteLine("El numero  menor es: " + Num1);
            }
            if (Num2 > Num1 && Num2 > Num3)
            {
                Console.WriteLine("El numero mayor es: " + Num2);
            }
            else
            {
                Console.WriteLine("El numero  menor es: " + Num2);
            }
            if (Num3 > Num2 &&  Num3 > Num1)
            {
                Console.WriteLine("El numero  mayor es: " + Num3);
            }
        }
    }
}
