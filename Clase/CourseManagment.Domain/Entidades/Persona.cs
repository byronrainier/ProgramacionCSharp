using System;
using System.Collections.Generic;
using System.Text;
using CourseManagment.Domain.Excepciones;

namespace CourseManagment.Domain.Entidades
{
    public abstract class Persona
    {

        #region "Propiedades"

        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set
            {
                if (string.IsNullOrEmpty(this._nombre))
                    throw new Exception("El nombre es obligatorio !");

                 if (this._nombre.Length > 50)
                    throw new PersonaException("El nombre no puede tener mas de 50 caracteres....");

                    this._nombre = value;
               
            }
        }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Rut { get; set; }


        #endregion

    }
}
