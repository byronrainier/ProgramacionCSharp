using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entidades;

namespace CourseManagment.Domain.BL
{
    public class EstudianteBL : IBaseEntity<Estudiante>, IEstudiante
    {
        //Creacion de la lista tipo estudiantes.
        private List<Estudiante> estudiantes;

        //Constructor
        public EstudianteBL()
        {
            this.estudiantes = new List<Estudiante>();
        }

        //Implementacion de la interfaz base/generica
        public void Actualizar(Estudiante entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(Estudiante entity)
        {
            var estudiante = this.ObtenerEntity(entity.Matricula);
            this.estudiantes.Remove(estudiante);
        }

        public void Guardar(Estudiante entity)
        {
            this.estudiantes.Add(entity);
        }

        public Estudiante ObtenerEntity(string Id)
        {
            return this.estudiantes.Find(estudiantes => estudiantes.Matricula == Id);
        }

        public Estudiante ObtenerEntity(int Id)
        {
            throw new NotImplementedException();
        }

        //Implementacion de la interfaz propia del estudiante 

        public List<Estudiante> ObtenerEstudiantesPorCarrera(string carrera)
        {
            return this.estudiantes.FindAll(estudiantes => estudiantes.Carrera == carrera);
        }

        public List<Estudiante> ObtenerEstudiantesPorDepartamento(string departamento)
        {
            return this.estudiantes.FindAll(estudiantes => estudiantes.Departamento == departamento);
        }

        public List<Estudiante> ObtenerEstudiantesPorMatricula(int matricula)
        {
            throw new NotImplementedException();
        }

        public List<Estudiante> ObtenerRegistros()
        {
            return this.estudiantes;
        }

    }
}
