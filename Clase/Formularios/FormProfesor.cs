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

            dgvProfesores.DataSource = profesorBL.ObtenerProfesores().ToArray();
            dgvProfesores.Refresh();


        }
    }
}
