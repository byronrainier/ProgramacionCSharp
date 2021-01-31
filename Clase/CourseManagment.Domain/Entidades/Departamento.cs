namespace CourseManagment.Domain.Entidades
{
   public  class Departamento
    {
        #region "Propiedades"

        

        private int departamentoID;

        public int DepartamentoID
        {
            get { return departamentoID; }
            set { departamentoID = value; }
        }

        private string nombreDep;

        public string NombreDepartamento
        {
            get { return nombreDep; }
            set { nombreDep = value; }
        }

        private double presupuesto;

        public double Presupuesto
        {
            get { return presupuesto; }
            set { presupuesto = value; }
        }

        #endregion
    }
}
