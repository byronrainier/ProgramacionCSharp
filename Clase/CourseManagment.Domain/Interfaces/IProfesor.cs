using System.Collections.Generic;
using CourseManagment.Domain.Entidades;

 namespace CourseManagment.Domain.Interfaces
{
    public interface IProfesor
    {
        List<Profesor> ObtenerProfesoresPorDepartamento(string departamento);
        List<Profesor> ObtenerProfesoresPorCarreras(string carrera);
        List<Profesor> ObtenerProfesoresPorCodigo(string codigo);
    }
}
