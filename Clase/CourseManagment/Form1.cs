using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseManagment.Domain.Entidades;
using CourseManagment.Domain.BL;
using CourseManagment.Domain.Interfaces;

namespace CourseManagment
{
    public partial class formEstudiante : Form
    {
        private IEstudiante estudianteBL;
        public formEstudiante()
        {
            this.estudianteBL = new EstudianteBL();
            InitializeComponent();
        }
        private void formEstudiante_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante newEstudiante = new Estudiante();
            {
                newEstudiante.Nombre = txtNombres.Text;
                newEstudiante.Apellido = txtApellidos.Text;
                newEstudiante.Carrera = txtCarrera.Text;
                newEstudiante.Departamento = txtDepartamento.Text;
                newEstudiante.Direccion = txtDireccion.Text;
                newEstudiante.Matricula = txtMatricula.Text;
                newEstudiante.Rut = txtRut.Text;
                lblNotificacion.Text = "Estudiante agregado exitosamente.";

                estudianteBL.Guardar(newEstudiante);

                CargarEstudiantes();

                LimpiarCampos();

            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("El codigo del estudiante es requerido.", "Eliminar estudiante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatricula.Focus();
                return;
            }

            Estudiante estudiante= this.estudianteBL.ObtenerEstudiantesPorMatricula(txtMatricula.Text);

            this.estudianteBL.Eliminar(estudiante);

            LimpiarCampos();
            CargarEstudiantes();

            MessageBox.Show("Profesor Eliminado", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void CargarEstudiantes()
        {
            dgvEstudiantes.DataSource = estudianteBL.ObtenerRegistros().ToArray();
            dgvEstudiantes.Refresh();

        }
        private void LimpiarCampos()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCarrera.Text = string.Empty;
            txtDepartamento.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtMatricula.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtNombres.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.LimpiarCampos();
        }
        private void dgvEstudiantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow gridViewRow = this.dgvEstudiantes.Rows[e.RowIndex];

                txtNombres.Text = gridViewRow.Cells["Nombre"].Value.ToString();
                txtApellidos.Text = gridViewRow.Cells["Apellido"].Value.ToString();
                txtCarrera.Text = gridViewRow.Cells["Carrera"].Value.ToString();
                txtDepartamento.Text = gridViewRow.Cells["Departamento"].Value.ToString();
                txtDireccion.Text = gridViewRow.Cells["Direccion"].Value.ToString();
                txtMatricula.Text = gridViewRow.Cells["Matricula"].Value.ToString();
                txtRut.Text = gridViewRow.Cells["Rut"].Value.ToString();
            }
        }
    }
}
