using System;
using System.Collections.Generic;
using System.Text;

namespace TareaClases
{
    class Alumno : Personas
    {
        //Podemos usar las propiedades y metodos del padre Personas
        public string Matricula { get; set; }

        public string Carrera { get; set; }

        public string Recinto { get; set; }




        public Alumno (){}



        //Sobre carga del metodo ObetenerDatos utilizando diferentes parametros
        public Alumno ObtenerDatos (string matricula)
        {
            return new Alumno();
        }

        public Alumno ObtenerDatos (string matricula, string carrera, string recinto)
        {
            return new Alumno();
        }




    }
}
 