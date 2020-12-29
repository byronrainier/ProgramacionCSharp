using System;

namespace NotaEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Problema 5

            int reprobados = 0, aprobados = 0 , nota;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Indiqueme la nota del estudiante: ");
                nota = Convert.ToInt16(Console.ReadLine());

                if (nota >= 7)
                {
                    reprobados++;
                }
                else
                {
                    aprobados++;
                }
            }
            Console.WriteLine("La cantidad de aprobados son: " + aprobados);
            Console.WriteLine("La cantidad de reprobados son: " + reprobados);
        }
    }
}
