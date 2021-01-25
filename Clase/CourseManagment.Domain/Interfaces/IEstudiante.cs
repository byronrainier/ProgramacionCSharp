using System.Collections.Generic;
using CourseManagment.Domain.Entidades;

namespace CourseManagment.Domain.Interfaces
{
   public  interface IEstudiante
    {
        //Interfaz propia de tipo estudiante
        List<Estudiante> ObtenerEstudiantesPorCarrera(string carrera);
        List<Estudiante> ObtenerEstudiantesPorMatricula(int matricula);
        List<Estudiante> ObtenerEstudiantesPorDepartamento(string departamento);

    }
}
