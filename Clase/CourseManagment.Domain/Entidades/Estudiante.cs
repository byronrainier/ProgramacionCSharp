 using System.Collections.Generic;
using System;

namespace CourseManagment.Domain.Entidades
{
    public class Estudiante : Persona
    {

        private List<Estudiante> estudiantes;

        public Estudiante()
        {
            this.estudiantes = new List<Estudiante>();
        }

        public string Carrera { get; set; }
        public string Matricula { get; set; }
        public string Departamento { get; set; }

        public void AgregarEstudiante(Estudiante estudiante) 
        {
            this.estudiantes.Add(estudiante);
        }
        public void EliminarEstudiante(string matricula)
        {
            var estudiante = this.estudiantes.Find(est => est.Matricula == matricula);

            this.estudiantes.Remove(estudiante);
        }
        public Estudiante ObtenerEstudiantePorMatricula(string matricula)
        {
            return this.estudiantes.Find(est => est.Matricula == matricula);
        }
        public List<Estudiante> ObtenerEstudiantes(string departamento)
        {
            return this.estudiantes.FindAll(est => est.Departamento == departamento);
        }
        public List<Estudiante> ObtenerEstudiantes()
        {
            return this.estudiantes;
        }
    }
}
