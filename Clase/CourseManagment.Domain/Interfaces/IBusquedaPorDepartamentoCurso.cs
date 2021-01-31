using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Interfaces
{
    public interface IBusquedaPorDepartamentoCurso<TEntity> where TEntity : class
    {
        List<TEntity> ObtenerCursosPorID(string id);
        List<TEntity> ObtenerCursosPorDepartamento(string departamento);
        List<TEntity> ObtenerCursosPorTitulo(string titulo);
    }
}
