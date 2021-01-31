using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Interfaces
{
    public interface  IBusquedaPorIDCurso<TEntity> where TEntity : class
    {
        List<TEntity> BusquedaPorCursoID(string id);
        List<TEntity> BusquedaPorTituloCurso(string id);

    }
}
