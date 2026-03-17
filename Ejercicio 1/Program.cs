using System;
using System.Collections.Generic;

namespace RegistroEstudiantes
{
    class Estudiante
    {
        public string Nombre;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Estudiante(string nombre, double n1, double n2, double n3)
        {
            Nombre = nombre;
            Nota1 = n1;
            Nota2 = n2;
            Nota3 = n3;
        }

        public double CalcularPromedio() => (Nota1 + Nota2 + Nota3) / 3;

        public string DeterminarEstado() => CalcularPromedio() >= 60 ? "Aprobado" : "Reprobado";

        public void MostrarInformacion()
        {
            Console.WriteLine($"Estudiante: {Nombre,-15} | Promedio: {CalcularPromedio(),6:F2} | Estado: {DeterminarEstado()}");
        }
    }

    class Program
    {
        static void Main()
        {
            List<Estudiante> lista = new List<Estudiante>();
            Console.Write("¿Cuántos estudiantes desea registrar? ");
            int cant = int.Parse(Console.ReadLine());

            for (int i = 0; i < cant; i++) 
            {
                Console.WriteLine($"\nDatos del Estudiante {i + 1}:");
                Console.Write("Nombre: "); string nom = Console.ReadLine();
                Console.Write("Nota 1: "); double n1 = double.Parse(Console.ReadLine());
                Console.Write("Nota 2: "); double n2 = double.Parse(Console.ReadLine());
                Console.Write("Nota 3: "); double n3 = double.Parse(Console.ReadLine());
                lista.Add(new Estudiante(nom, n1, n2, n3));
            }

            Console.WriteLine("\nLISTA DE ESTUDIANTES");
            foreach (var e in lista) e.MostrarInformacion();

            var mejor = lista.OrderByDescending(e => e.CalcularPromedio()).First();
            Console.WriteLine($"\nEl mejor promedio es de: {mejor.Nombre} ({mejor.CalcularPromedio():F2})");
        }
    }
}
