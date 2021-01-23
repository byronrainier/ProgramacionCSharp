using System;
using System.Collections.Generic;
using System.Text;

namespace CourseManagment.Domain.Excepciones
{
    public class PersonaException : Exception
    {
        public PersonaException (string message) : base(message) { }
    }
}
