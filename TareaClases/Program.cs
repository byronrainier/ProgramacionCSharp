using System;

namespace TareaClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Datos de la persona");
            Console.WriteLine("");

            Personas persona = new Personas();

            persona.Nombres = "Byron Rainier";
            persona.Apellidos = "Henriquez Diaz";
            persona.Edad = 15;

            Console.WriteLine($"Nombres: {persona.Nombres}");
            Console.WriteLine($"Apellidos: {persona.Apellidos}");
            Console.WriteLine($"Edad: {persona.Edad}");
            persona.ValidarEdad();

            Console.WriteLine("---------------------------------");

            Triangulo triangulo = new Triangulo();

            triangulo.LadoA = 24.8;
            triangulo.LadoB = 11.7;
            triangulo.LadoC = 8.17;

            triangulo.LeerDatosTriangulo();
            triangulo.ValidacionTipoTriangulo();
            triangulo.ImprimirLadoMayor();

            Console.WriteLine("---------------------------------");

            PlanoCartesiano plano = new PlanoCartesiano();

            plano.X = 8;
            plano.Y = -15;

            Console.WriteLine("Coordenada X: " + plano.X);
            Console.WriteLine("Coordenada Y: " + plano.Y);

            plano.DeterminarCuadrante();

            Console.WriteLine("---------------------------------");

            Cuadrado cuadrado = new Cuadrado();

            cuadrado.LadoA = 11.7;
            cuadrado.LadoB = 8.4;
            cuadrado.LadoC = 13.15;
            cuadrado.LadoD = 10.15;

            Console.WriteLine($"El lado A mide: {cuadrado.LadoA}");
            Console.WriteLine($"El lado B mide: {cuadrado.LadoB}");
            Console.WriteLine($"El lado C mide: {cuadrado.LadoC}");
            Console.WriteLine($"El lado D mide: {cuadrado.LadoD}");
            Console.WriteLine("La superficie  del Triangulo dado sus lados es: " + cuadrado.CalculoSuperficie(cuadrado.LadoA, cuadrado.LadoB, cuadrado.LadoC, cuadrado.LadoD));
            Console.WriteLine("El perimetro del Triangulo dado sus lados es: " +  cuadrado.CalculoPerimetro(cuadrado.LadoA, cuadrado.LadoB, cuadrado.LadoC, cuadrado.LadoD));

            Console.WriteLine("---------------------------------");

            Empleados empleado = new Empleados();

            empleado.Nombres = "Carlos Federico";
            empleado.Apellidos = " Henriquez Diaz";
            empleado.Sueldo = 2500;

            Console.WriteLine("Nombre completo del empleado: " + empleado.ObtenerDatos());
            Console.WriteLine("Sueldo: " + empleado.Sueldo);
            empleado.AplicarImpuesto(empleado.Sueldo);

            Console.WriteLine("---------------------------------");

            OperacionesAritmeticas operacion = new OperacionesAritmeticas();

            operacion.Num1 = 8;
            operacion.Num2 = 5;

            Console.WriteLine($"Primer Valor: {operacion.Num1}");
            Console.WriteLine($"Segundo Valor: {operacion.Num2}");

            Console.WriteLine($"Suma: {operacion.Suma(operacion.Num1, operacion.Num2)}");
            Console.WriteLine($"Resta: {operacion.Resta(operacion.Num1, operacion.Num2)}");
            Console.WriteLine($"Divison: {operacion.Divison(operacion.Num1, operacion.Num2)}");
            Console.WriteLine($"Multiplicacion: {operacion.Multiplicacion(operacion.Num1, operacion.Num2)}");


            Console.WriteLine("---------------------------------");

            Numeros numeros = new Numeros();

            numeros.Num1 = 75;
            numeros.Num2 = 15;
            numeros.Num3 = 40;
             
            numeros.ValidacionMayorMenor();

            Console.WriteLine("---------------------------------");

            TablaDeMultiplicacion tablaDeMultiplicacion = new TablaDeMultiplicacion();

            tablaDeMultiplicacion.Num1 = 8;

            for (int i = 0; i <= 12; i++)
            {
                Console.WriteLine(tablaDeMultiplicacion.Num1 + "x" + i + "=" + (i * tablaDeMultiplicacion.Num1));
            }

            Console.WriteLine("---------------------------------");

            Alumno alumno = new Alumno();

            alumno.Nombres = "Jean Alain";
            alumno.Apellidos = " Rodriguez";
            alumno.Edad = 23;

            Console.WriteLine($"Nombre completo del estudiante: {alumno.ObtenerDatos()}");
            alumno.ValidarEdad();

            Console.WriteLine("---------------------------------");

            Operarios operarios = new Operarios();

            operarios.ImprimirSueldos();

            Console.ReadLine();
        }
    }
}