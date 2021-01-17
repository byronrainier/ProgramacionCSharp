using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entidades
{
    public class Profesor : Persona
    {
        private List<Profesor> Profesors;

        public Profesor()
        {
            this.Profesors = new List<Profesor>();
        }
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public string Departamento { get; set; }
        public string materiaImparte { get; set; }

        /// <summary>
        /// 
        /// Agrega/crea un nuevo profesor
        /// </summary>
        /// <param name="profesor"></param>
        public void AgregarProfesor( Profesor profesor)
        {
            this.Profesors.Add(profesor);
        }

        /// <summary>
        /// Elimina un registro de profesor por el parametro codigo
        /// </summary>
        /// <param name="codigo"></param>
        public void EliminarProfesor(string codigo)
        {
            var profesor = this.Profesors.Find(est => est.Codigo == Codigo);

            this.Profesors.Remove(profesor);
        }

        /// <summary>
        /// Permite conslutar un profesor filtrando por codigo
        /// </summary>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public Profesor ObtenerProfesorPorCodigo(string codigo)
        {
            return this.Profesors.Find(pro => pro.Codigo == codigo);
        }

        /// <summary>
        /// Permite buscar un profesor por el parametro de departamento
        /// </summary>
        /// <param name="departamento"></param>
        /// <returns></returns>
        public List<Profesor> ObtenerProfesores(string departamento)
        {
            return this.Profesors.FindAll(pro => pro.Departamento == departamento);
        }
        /// <summary>
        /// Permite leer la lista de profesores
        /// </summary>
        /// <returns>Lista de Profesores</returns>
        public List<Profesor> ObtenerProfesores()
        {
            return this.Profesors;
        }
    }
}
