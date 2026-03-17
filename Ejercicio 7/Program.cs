using System;
using System.Collections.Generic;

Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

Console.Write("¿Cuántos productos desea registrar?: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
Console.WriteLine($"\nRegistro de Producto {i + 1}");

Console.Write("Código: ");
string codigo = Console.ReadLine();

Producto p = new Producto();
Console.Write("Nombre: "); p.Nombre = Console.ReadLine();
Console.Write("Precio: "); p.Precio = double.Parse(Console.ReadLine());
Console.Write("Stock: "); p.Stock = int.Parse(Console.ReadLine());

productos[codigo] = p;
}

Console.WriteLine("\nPRODUCTOS REGISTRADOS");

foreach (KeyValuePair<string, Producto> item in productos)
{
Console.Write($"Código: {item.Key} | ");
item.Value.MostrarDatos();
}

Console.Write("\nIngrese un código para buscar: ");
string buscar = Console.ReadLine();

if (productos.ContainsKey(buscar))
{
Console.WriteLine("Producto encontrado:");
productos[buscar].MostrarDatos();
}
else
{
Console.WriteLine("No existe un producto con ese código.");
}

class Producto
{
    public string Nombre;
    public double Precio;
    public int Stock;

    public string EstadoStock()
    {
        if (Stock == 0) return "Agotado";
        else if (Stock <= 5) return "Bajo"; 
        else return "Normal";
    }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre} Precio: Q{Precio:F2} Stock: {Stock} Estado: {EstadoStock()}");
    }
}
