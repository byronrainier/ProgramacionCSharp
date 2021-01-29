using CourseManagment.Domain.Entidades;
using CourseManagment.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;
using CourseManagment.Domain.BL;

namespace CourseManagment.Domain.BL
{

    public class ClienteBL : BaseBL<Cliente>, ICliente
    {
        public Cliente ObtenerClientePorCuenta(string cuenta)
        {
            return base.Entities.SingleOrDefault(Cliente => Cliente.NumeroCuenta == cuenta);
        }

        public Cliente ObtenerEntity(int Id)
        {
            return base.Entities.Find(Cliente => Cliente.CodigoCliente == Id);
        }

        public override void Guardar(Cliente entity)
        {
            entity.CodigoCliente = base.Entities.Count == 0 ? 1 : base.Entities.Max(Cliente => Cliente.CodigoCliente) + 1;
            base.Guardar(entity);
        }

    }
}
