using System;
using CourseManagment.Domain.Entidades;
using System.Windows.Forms;

namespace Formulario_Cliente
{
    public partial class FormCliente : Form
    {
        private Cliente ClienteBL;
        public FormCliente()
        {
            this.ClienteBL = new Cliente();
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente newCliente = new Cliente();

            newCliente.Nombre = txtNombres.Text;
            newCliente.Apellido = txtApellidos.Text;
            newCliente.Direccion = txtDireccion.Text;
            newCliente.Rut = txtRut.Text;
            newCliente.Entidad = txtEntidad.Text;
            newCliente.CodigoCliente = txtCliente.Text;
            newCliente.NumeroCuenta = txtCuenta.Text;
            newCliente.FechaIngreso = seleccionFecha.Value;

            ClienteBL.AgregarCliente(newCliente);

            dgvClientes.DataSource = ClienteBL.ObtenerClientes().ToArray();
            dgvClientes.Refresh();

        }
    }
}
