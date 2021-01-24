using System.Collections.Generic;

namespace CourseManagment.Domain.Interfaces
{
    public interface IBaseEntity<TEntity> where TEntity : class
    {

        //Aqui definimos los metodos que son comunes
        void Guardar(TEntity entity);
        void Actualizar(TEntity entity);
        void Eliminar(TEntity entity);
        TEntity ObtenerEntity(int Id);
        List<TEntity> ObtenerRegistros();
    }
}
