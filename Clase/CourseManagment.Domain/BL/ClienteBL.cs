using CourseManagment.Domain.Interfaces;
using CourseManagment.Domain.Entidades;
using System.Collections.Generic;

namespace CourseManagment.Domain.BL
{

    public class ClienteBL : IBaseEntity<Cliente>
    {
        private List<Cliente> clientes;
        public ClienteBL()
        {
            this.clientes = new List<Cliente>();
        }

        public void Actualizar(Cliente entity)
        {
            throw new System.NotImplementedException();
        }

        public void Eliminar(Cliente entity)
        {
            var cliente = this.ObtenerEntity(entity.CodigoCliente);
            this.clientes.Remove(cliente);
        }

        public void Guardar(Cliente entity)
        {
            this.clientes.Add(entity);
        }

        public Cliente ObtenerEntity(int Id)
        {
            return this.clientes.Find(clientes => clientes.CodigoCliente == Id);
        }

        public List<Cliente> ObtenerRegistros()
        {
            return this.clientes;
        }
    }
}
