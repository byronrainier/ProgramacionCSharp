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
            txtNombres.Focus();

            ClienteBL.AgregarCliente(newCliente);

            CargarDatos();

            LimpiarCampos();

        }

        private void CargarDatos()
        {
            dgvClientes.DataSource = ClienteBL.ObtenerClientes().ToArray();
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
                txtCliente.Text = gridViewRow.Cells["CodigoCliente"].Value.ToString();
                txtDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                txtCuenta.Text = gridViewRow.Cells["NumeroCuenta"].Value.ToString();
                txtRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
                seleccionFecha.Text = gridViewRow.Cells["FechaIngreso"].Value.ToString();
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.ClienteBL.EliminarCliente(txtCliente.Text);
            this.LimpiarCampos();
            this.CargarDatos();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
