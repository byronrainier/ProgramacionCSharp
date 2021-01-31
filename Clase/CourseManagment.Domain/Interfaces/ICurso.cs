using CourseManagment.Domain.Entidades;
using CourseManagment.Domain.BL;


namespace CourseManagment.Domain.Interfaces
{
   public  interface ICurso : IBaseEntity<Curso>,  IBusquedaPorDepartamentoCurso<Curso>
    {
    }
}
