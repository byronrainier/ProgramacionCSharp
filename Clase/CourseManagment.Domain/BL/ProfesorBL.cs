using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace CourseManagment.Domain.BL
{
    public class ProfesorBL :  IProfesor
    {
        private List<Profesor> profesors;
        public ProfesorBL()
        {
            this.profesors = new List<Profesor>();
        }

        public void Actualizar(Profesor entity)
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar(Profesor entity)
        {
            this.profesors.Remove(entity);
        }

        public void Guardar(Profesor entity)
        {
            entity.ProfesorId = this.profesors.Count == 0 ? 1 : this.profesors.Max(profesor => profesor.ProfesorId) + 1;

            this.profesors.Add(entity);
        }

        public Profesor ObtenerEntity(int Id)
        {
            return this.profesors.Find(profesor => profesor.ProfesorId == Id);
        }

        public List<Profesor> ObtenerProfesoresPorCarrera(string carrera)
        {
            return this.profesors.FindAll(profesor => profesor.Carrera == carrera);
        }

        public Profesor ObtenerProfesoresPorCodigo(string codigo)
        {
            return this.profesors.Find(profesor => profesor.Codigo == codigo);
        }

        public List<Profesor> ObtenerProfesoresPorDepartamento(string departamento)
        {
            return this.profesors.FindAll(profesor => profesor.Departamento == departamento);
        }

        public List<Profesor> ObtenerRegistros()
        {
            return this.profesors;
        }
        public string PublicarNota()
        {
            return "Publique la nota";
        }
    }
}
