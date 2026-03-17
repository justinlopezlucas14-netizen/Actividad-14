using System;
using System.Collections.Generic;

List<Libro> biblioteca = new List<Libro>();
Console.Write("¿Cuántos libros registrará?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Libro l = new Libro();
    Console.WriteLine($"\nLibro {i + 1}");
    Console.Write("Título: "); l.Titulo = Console.ReadLine();
    Console.Write("Autor: "); l.Autor = Console.ReadLine();
    Console.Write("Categoría: "); l.Categoria = Console.ReadLine();
    Console.Write("Páginas: "); l.Paginas = int.Parse(Console.ReadLine());
    biblioteca.Add(l);
}

if (biblioteca.Count > 0)
{
    Libro masLargo = biblioteca[0];
    Console.WriteLine("\nLISTADO DE LIBROS");
    foreach (Libro lib in biblioteca)
    {
        lib.MostrarDatos();
        if (lib.Paginas > masLargo.Paginas)
        {
            masLargo = lib;
        }
    }

    Console.WriteLine("\nLibro con más páginas:");
    masLargo.MostrarDatos();
}

class Libro
{
    public string Titulo;
    public string Autor;
    public string Categoria;
    public int Paginas;

    public string Clasificar()
    {
        if (Paginas >= 500) return "Muy extenso";
        else if (Paginas >= 200) return "Mediano";
        else return "Corto";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Título: {Titulo} | Autor: {Autor} | Categoría: {Categoria} | Páginas: {Paginas} | Tipo: {Clasificar()}");
    }
}