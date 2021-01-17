using System;

namespace Clase
{
    public class Estudiante : Persona
    {
        public Estudiante(string carrera, string matricula)
        {
            this.Matricula = matricula;
            this.Carrera = carrera;

        }
        public Estudiante()
        {

        }
        public string Carrera { get; set; }
        public string Matricula { get; set; }
        public string Departamento { get; set; }

        public override void ImprimirDatos()
        {
            Console.WriteLine("----Datos del Estudiante----");

            Console.WriteLine($"Matricula: {Matricula}");
            Console.WriteLine($"Nombre: {this.ObtenerNombreCompleto()}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"Carrera: {Carrera}");


            Console.WriteLine("----------------------------");
        }
        
        // Aqui vemos la sobre carga de un metodo
        /// <summary>
        /// Obtener el estudiante por matricula.
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula)
        {
            return new Estudiante();
        }
        /// <summary>
        /// Obtener el estudiante por matricula y carrera.
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <param name="carrera">Carrera a la que pertenece el estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula, string carrera)
        {
            return new Estudiante();
        }
        /// <summary>
        /// Obtener el estudiante por matricula, carrera y departamento.
        /// </summary>
        /// <param name="matricula">Matricula del estudiante</param>
        /// <param name="carrera">Carrera a la que pertenece el estudiante</param>
        /// <param name="departamento">Departamento a la cual pertenece el estudiante</param>
        /// <returns></returns>
        public Estudiante ObtenerEstudiante(string matricula, string carrera, string departamento = null)
        {
            return new Estudiante();
        }
        public override void AgregarPersona(Persona persona, out int personaId)
        {
            throw new NotImplementedException();    
        }
    }
}
