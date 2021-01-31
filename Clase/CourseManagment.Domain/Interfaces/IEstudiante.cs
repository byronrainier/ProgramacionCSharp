
using System.Collections.Generic;
using CourseManagment.Domain.Entidades;

namespace CourseManagment.Domain.Interfaces
{
   public  interface IEstudiante : IBaseEntity<Estudiante>, IBusquedaDepartamentoCarreraEstudiante<Estudiante>
    {
        //Interfaz propia de tipo estudiante
        Estudiante ObtenerEstudiantesPorMatricula(string matricula);
    }
}
