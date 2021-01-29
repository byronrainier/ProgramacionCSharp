using System.Collections.Generic;
using CourseManagment.Domain.Interfaces;


namespace CourseManagment.Domain.Interfaces
{
    public interface IBusquedaDepartamentoCarrera<TEntity> where TEntity : class
    {
        List<TEntity>ObtenerProfesoresPorDepartamento(string departamento);
        List<TEntity> ObtenerProfesoresPorCarrera(string carrera);
    }
}
