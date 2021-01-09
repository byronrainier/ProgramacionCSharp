using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    public class Cuadrado : Triangulo
    {
        //Se heredo de la clase Triangulo los 3 lados antes definididos
        public double LadoD { get; set; }

        public  double CalculoPerimetro(double ladoA, double ladoB, double ladoC, double ladoD)
        {
            return  ladoA + ladoB + ladoC + ladoD;
        }

        //Se consiguio esta formula via Web para obtener la Superficie
        public double CalculoSuperficie(double ladoA, double ladoB, double ladoC, double ladoD)
        {
            return ladoA *  ladoB * ladoC * ladoD;
        }
    }
}
