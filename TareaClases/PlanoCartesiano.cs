using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
   public class PlanoCartesiano
    {
        #region "Propiedades"


        public int X { get; set; }
        public int Y { get; set; }

        #endregion


        #region "Metodos"

        public void DeterminarCuadrante()
        {
            if (X > 0 && Y > 0)
            {
                Console.WriteLine("Las coordenadas se encuentran en el primer cuadrante");
            }
            if (X < 0 && Y > 0)
            {
                Console.WriteLine("Las coordenadas se encuentran en el segundo cuadrante");
            }
            if (X < 0 && Y < 0)
            {
                Console.WriteLine("Las coordenadas se encuentran en el tercer cuadrante");
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine("Las coordenadas se encuentran en el cuarto cuadrante");
            }
            #endregion
        }
    }
}
