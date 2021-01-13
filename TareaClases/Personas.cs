using System;

namespace TareaClases
{
    public class Personas
    {
        
        
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }
        public void ValidarEdad()
        {
            if (Edad > 18)
            {
                Console.WriteLine("Persona es mayor de edad!");
            }
            else
            {
                Console.WriteLine("La persona es menor de edad!");
            }
        }
        public string ObtenerDatos()
        {
            return string.Concat(this.Nombres, this.Apellidos);
        }
    }
}
