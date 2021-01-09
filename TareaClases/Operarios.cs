using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    public class Operarios : Empleados
    {
        private int[] sueldos;

        public Operarios()
        {
            sueldos = new int[5];
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.Write("Indicar sueldo del operador:");
                string linea = Console.ReadLine();
                sueldos[i] = int.Parse(linea);
            }
        }
        public void ImprimirSueldos()
        {
            for (int i = 0; i < sueldos.Length; i++)
            {
                Console.WriteLine(sueldos[i]);
            }
            Console.ReadKey();
        }

    }
}
