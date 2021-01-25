using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entidades
{
    public class Cliente : Persona
    {
        #region "Propiedades"

        

        private List<Cliente> clientes;

        public Cliente()
        {
            this.clientes = new List<Cliente>();
        }
        public int CodigoCliente { get; set; }
        public string Entidad { get; set; }
        public string  NumeroCuenta{ get; set; }
        public DateTime FechaIngreso { get; set; }

        #endregion


        #region "Metodos"

        
        public void AgregarCliente (Cliente cliente)
        {
            this.clientes.Add(cliente);
        }

        public void EliminarCliente (string codigocliente)
        {
            var cliente = this.clientes.Find(cod => cod.CodigoCliente == codigocliente);

            this.clientes.Remove(cliente);
        }
        public Cliente ObtenerClientePorCuenta(string cuenta)
        {
            return this.clientes.Find(cue => cue.NumeroCuenta == cuenta);
        }
        public List<Cliente> ObtenerClientes()
        {
            return this.clientes;
        }

        #endregion
    }
}
