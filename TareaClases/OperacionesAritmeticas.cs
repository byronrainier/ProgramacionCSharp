using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    public class OperacionesAritmeticas
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public  int Suma(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Resta(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiplicacion(int num1, int num2)
        {
            return num1 *  num2;
        }

        public int Divison(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
