using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Interfaces;

namespace CourseManagment.Domain.Interfaces
{
    public interface IBusquedaDepartamentoCarreraEstudiante<TEntity> where TEntity : class
    {
        List<TEntity> ObtenerEstudiantesPorDepartamento(string departamento);
        List<TEntity> ObtenerEstudiantesPorCarrera(string carrera);
    }
}
