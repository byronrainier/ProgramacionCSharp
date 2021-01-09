using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
   public class Empleados : Personas
    {
        public int Sueldo { get; set; }

        public void AplicarImpuesto(int sueldo)
        {
            this.Sueldo = sueldo;

            if (sueldo > 3000)
            {
                Console.WriteLine( "Si aplica para pagar Impuestos");
            }
            else
            {
                Console.WriteLine("NO aplica para pagar Impuestos");
            }
        }
    }
}
