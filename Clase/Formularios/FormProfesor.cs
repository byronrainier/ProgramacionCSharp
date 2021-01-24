using System;
using CourseManagment.Domain.Entidades;
using System.Windows.Forms;

namespace Formularios
{
    public partial class FormProfesor : Form
    {
        private Profesor profesorBL; 
        public FormProfesor()
        {
            this.profesorBL = new Profesor();
            InitializeComponent();
        }

        private void FormProfesor_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Profesor newProfesor = new Profesor();

            newProfesor.Nombre = txtNombres.Text;
            newProfesor.Apellido = txtApellidos.Text;
            newProfesor.Direccion = txtDireccion.Text;
            newProfesor.Rut = txtRut.Text;
            newProfesor.materiaImparte = txtMateria.Text;
            newProfesor.Departamento = txtDepartamento.Text;
            newProfesor.Carrera = txtCarrera.Text;
            newProfesor.Codigo = txtCodigo.Text;
            txtNombres.Focus();

            profesorBL.AgregarProfesor(newProfesor);

            CargarDatos();

            LimpiarCampos();

        }
        private void CargarDatos()
        {
            dgvProfesores.DataSource = profesorBL.ObtenerProfesores().ToArray();
            dgvProfesores.Refresh();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtApellidos.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtMateria.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtRut.Text = string.Empty;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.profesorBL.EliminarProfesor(txtCodigo.Text);
            CargarDatos();
        }

        private void dgvProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvProfesores.Rows[e.RowIndex];

                txtNombres.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                txtCarrera.Text = gridViewRow.Cells["Carrera"].Value.ToString();
                txtDepartamento.Text = gridViewRow.Cells["Departamento"].Value.ToString();
                txtDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                txtCodigo.Text = gridViewRow.Cells["Codigo"].Value.ToString();
                txtRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
                txtMateria.Text = gridViewRow.Cells["materiaImparte"].Value.ToString();
            }
        }
    }
}
