using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entidades;
using System.Collections.Generic;

namespace CourseManagment.Domain.BL
{
    public class ClienteBL : IBaseEntity<Cliente>
    {
        void IBaseEntity<Cliente>.Actualizar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        void IBaseEntity<Cliente>.Eliminar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        void IBaseEntity<Cliente>.Guardar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        Cliente IBaseEntity<Cliente>.ObtenerEntity(int Id)
        {
            throw new System.NotImplementedException();
        }

        List<Cliente> IBaseEntity<Cliente>.ObtenerRegistros()
        {
            throw new System.NotImplementedException();
        }
    }
}
