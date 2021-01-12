using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Entidades
{
    public class Profesor : Persona
    {
        public string Codigo { get; set; }
        public string Carrera { get; set; }
        public string Departamento { get; set; }

    }
}
