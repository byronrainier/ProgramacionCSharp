using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseManagment.Domain.Entidades;

namespace CourseManagment
{
    public partial class formEstudiante : Form
    {
        private Estudiante estudianteBL;
        public formEstudiante()
        {
            this.estudianteBL = new Estudiante();
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

                estudianteBL.AgregarEstudiante(newEstudiante);

                dgvEstudiantes.DataSource = estudianteBL.ObtenerEstudiantes().ToArray();
                dgvEstudiantes.Refresh();

            }
        }
    }
}
