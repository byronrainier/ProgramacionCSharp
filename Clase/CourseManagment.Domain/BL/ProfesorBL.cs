using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entidades;
using System.Collections.Generic;

namespace CourseManagment.Domain.BL
{
    public class ProfesorBL : IBaseEntity<Profesor>
    {
        private List<Profesor> profesors;
        public ProfesorBL()
        {
            this.profesors = new List<Profesor>();
        }
        void IBaseEntity<Profesor>.Actualizar(Profesor entity)
        {
            throw new System.NotImplementedException();
        }

        void IBaseEntity<Profesor>.Eliminar(Profesor entity)
        {
            throw new System.NotImplementedException();
        }

        void IBaseEntity<Profesor>.Guardar(Profesor entity)
        {
            throw new System.NotImplementedException();
        }

        Profesor IBaseEntity<Profesor>.ObtenerEntity(int Id)
        {
            throw new System.NotImplementedException();
        }

        List<Profesor> IBaseEntity<Profesor>.ObtenerRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
