using System;
using CourseManagment.Domain.Entidades;
using System.Windows.Forms;
using CourseManagment.Domain.BL;
using CourseManagment.Domain.Interfaces;

namespace Formulario_Cliente
{
    public partial class FormCliente : Form
    {
        private ClienteBL clienteBL;
        private int clienteID;
        public FormCliente()
        {
            this.clienteBL = new ClienteBL();
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
            newCliente.NumeroCuenta = txtCuenta.Text;
            newCliente.FechaIngreso = seleccionFecha.Value;
            txtNombres.Focus();

            clienteBL.Guardar(newCliente);

            CargarDatos();

            LimpiarCampos();

        }

        private void CargarDatos()
        {
            dgvClientes.DataSource = clienteBL.ObtenerRegistros().ToArray();
            dgvClientes.Refresh();
        }

        private void LimpiarCampos()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCliente.Text = string.Empty;
            txtCuenta.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEntidad.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtNombres.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvClientes.Rows[e.RowIndex];

                txtNombres.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                txtEntidad.Text = gridViewRow.Cells["Entidad"].Value.ToString();
                txtDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                txtCuenta.Text = gridViewRow.Cells["NumeroCuenta"].Value.ToString();
                this.clienteID = Convert.ToInt32(gridViewRow.Cells["CodigoCliente"].Value);
                txtRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
                seleccionFecha.Text = gridViewRow.Cells["FechaIngreso"].Value.ToString();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Cliente cliente = this.clienteBL.ObtenerEntity(this.clienteID);
            this.clienteBL.Eliminar(cliente);
            LimpiarCampos();
            CargarDatos();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
