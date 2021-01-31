namespace CourseManagment.Domain.Entidades
{
    public class Curso
    {
        #region "Propiedades"

        private string cursoID;

        public string CursoID
        {
            get { return cursoID; }
            set { cursoID = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private int credito;

        public int Credito
        {
            get { return credito; }
            set { credito = value; }
        }

        private int departamentoID;

        public int DepartamentoID
        {
            get { return departamentoID; }
            set { departamentoID = value; }
        }

        #endregion
    }
}
