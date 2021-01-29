using CourseManagment.Domain.Entidades;

namespace CourseManagment.Domain.Interfaces
{
    public interface ICliente
    {
        Cliente ObtenerEntity(int Id);
        Cliente ObtenerClientePorCuenta(string cuenta);
    }
}