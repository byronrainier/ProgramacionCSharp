using CourseManagment.Domain.Entidades;

namespace CourseManagment.Domain.Interfaces
{
    public interface ICurso : IBaseEntity<Curso>, IBusquedaPorIDCurso<Curso>
    {
    }
}
