using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    public class Triangulo
    {
        #region "Propiedades"


        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        #endregion

        #region "Metodos"


        //Validacion Necesaria para deteminar si los 3 lados son iguales para clasificar el triangulo como equilatero.
        public void ValidacionTipoTriangulo() 
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                Console.WriteLine("El triangulo es Equilatero! ");
            }
            else
            {
                Console.WriteLine("El triangulo NO es equilatero! ");
            }
        }
        public  void LeerDatosTriangulo()
        {
            Console.WriteLine("Lado A mide: " + this.LadoA);
            Console.WriteLine("Lado B mide: " + this.LadoB);
            Console.WriteLine("Lado C mide: " + this.LadoC);
        }
        public void ImprimirLadoMayor()
        {
            if (LadoA  > LadoB && LadoA > LadoC)
            {
                Console.WriteLine("El lado  mayor es: " + LadoA);
            }
            if (LadoB > LadoA  && LadoB > LadoC)
            {
                Console.WriteLine("El lado  mayor es: " + LadoB);
            }
            else if(LadoC > LadoA && LadoC > LadoB)
            {
                Console.WriteLine("El lado  mayor es: " + LadoC);
            }
        }
        #endregion
    }
}
