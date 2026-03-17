using System;
using System.Collections.Generic;

List<Venta> ventas = new List<Venta>();
double totalGeneral = 0;

Console.Write("¿Cuántas ventas registrará? ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
Console.Write("Producto: ");
string prod = Console.ReadLine();
Console.Write("Precio: ");
double pre = double.Parse(Console.ReadLine());
Console.Write("Cantidad: ");
int cant = int.Parse(Console.ReadLine());

ventas.Add(new Venta(prod, pre, cant));
}

foreach (var v in ventas)
{
double final = v.CalcularTotal();
totalGeneral += final;
Console.WriteLine($"Producto: {v.Producto} | Total: Q{final:N2}");
}

Console.WriteLine($"\nTOTAL GENERAL DE VENTAS: Q{totalGeneral:N2}");

public class Venta
{
    public string Producto;
    public double Precio;
    public int Cantidad;

    public Venta(string p, double pr, int c) { Producto = p; Precio = pr; Cantidad = c; }

    public double CalcularTotal()
    {
        double subtotal = Precio * Cantidad;
        double descuento = subtotal > 500 ? subtotal * 0.10 : 0;
        return subtotal - descuento;
    }
}
