using System.Collections.Generic;
using CourseManagment.Domain.Entidades;

 namespace CourseManagment.Domain.Interfaces
{
    public interface IProfesor : IBaseEntity<Profesor>, IBusquedaDepartamentoCarrera<Profesor>
    {
        Profesor ObtenerProfesoresPorCodigo(string codigo);
    }
}
